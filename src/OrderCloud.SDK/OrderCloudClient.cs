using System;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Threading;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// allows test assemblies to access internal members, such as the Request method
// https://stackoverflow.com/questions/1211707/how-to-access-classes-in-another-assembly-for-unit-testing-purposes
[assembly: InternalsVisibleTo("OrderCloud.SDK.Tests")]
[assembly: InternalsVisibleTo("OC.Tests")]

namespace OrderCloud.SDK
{
	public partial interface IOrderCloudClient
	{
		/// <summary>
		/// Contains OAuth2 credentials and other configuration settings.
		/// </summary>
		OrderCloudClientConfig Config { get; }

		/// <summary>
		/// When authenticated, contains information about the access token. 
		/// </summary>
		TokenResponse TokenResponse { get; set; }

		/// <summary>
		/// Indicates whether a valid, unexpired token has been acquired and cached.
		/// Normally you don't need to worry about when to request a new token; this will happen implicitly as needed.
		/// </summary>
		bool IsAuthenticated { get; }

		/// <summary>
		/// Sends a token request to the OrderCloud authorization server using credentials set in OrderCloudClient.Config.
		/// Normally you don't need to call this explicitly; it's called implicitly as needed, and the token is cached for its stated duration.
		/// </summary>
		Task<TokenResponse> AuthenticateAsync();

		/// <summary>
		/// Sends a token request to the OrderCloud authorization server using the OAuth2 password grant flow.
		/// </summary>
		Task<TokenResponse> AuthenticateAsync(string clientID, string username, string password, params ApiRole[] roles);

		/// <summary>
		/// Sends a token request to the OrderCloud authorization server using the OAuth2 client credentials grant flow.
		/// </summary>
		Task<TokenResponse> AuthenticateAsync(string clientID, string clientSecret, params ApiRole[] roles);

		/// <summary>
		/// Sends a token request to the OrderCloud authorization server using the OAuth2 refresh_token grant flow.
		/// </summary>
		Task<TokenResponse> RefreshTokenAsync(string refreshToken);

		/// <summary>
		/// Sends a token request to the OrderCloud authorization server using the OAuth2 refresh_token grant flow.
		/// </summary>
		Task<TokenResponse> RefreshTokenAsync(string clientID, string refreshToken);
	}

	public partial class OrderCloudClient : IDisposable
	{
		private static readonly IFlurlClientFactory _clientFac = new PerBaseUrlFlurlClientFactory();

		internal static readonly ISerializer Serializer = new NewtonsoftJsonSerializer(new JsonSerializerSettings {
			ContractResolver = new OrderCloudContractResolver(),
			Converters = {
				new StringEnumConverter(),
				new DynamicConverter(),
				new PartialConverter()
			}
		});

		protected virtual IFlurlClient ApiClient => _clientFac.Get(Config.ApiUrl);
		protected virtual IFlurlClient AuthClient => _clientFac.Get(Config.AuthUrl);

		public OrderCloudClient() : this(new OrderCloudClientConfig()) { }

		public OrderCloudClient(OrderCloudClientConfig config) {
			Config = config;
			InitResources();
		}

		/// <inheritdoc/>
		public OrderCloudClientConfig Config { get; }

		/// <inheritdoc/>
		public TokenResponse TokenResponse { get; set; }

		/// <inheritdoc/>
		public bool IsAuthenticated => TokenResponse?.AccessToken != null && TokenResponse.ExpiresUtc > DateTime.UtcNow;

		/// <inheritdoc/>
		public async Task<TokenResponse> AuthenticateAsync() {
			ValidateConfig();
			var authTask = (Config.GrantType == GrantType.ClientCredentials) ?
				AuthenticateAsync(Config.ClientId, Config.ClientSecret, Config.Roles ?? new ApiRole[0]) :
				AuthenticateAsync(Config.ClientId, Config.Username, Config.Password, Config.Roles ?? new ApiRole[0]);
			return TokenResponse = await authTask;
		}

		/// <inheritdoc/>
		public Task<TokenResponse> AuthenticateAsync(string clientID, string username, string password, params ApiRole[] roles) {
			Require(clientID, nameof(clientID));
			Require(username, nameof(username));
			Require(password, nameof(password));

			var req = new OAuthTokenRequestWithPasswordGrant {
				client_id = clientID,
				username = username,
				password = password,
				scope = string.Join(" ", roles)
			};
			return AuthenticateAsync(req);
		}

		/// <inheritdoc/>
		public Task<TokenResponse> AuthenticateAsync(string clientID, string clientSecret, params ApiRole[] roles) {
			var req = new OAuthTokenRequestWithClientCredentialsGrant {
				client_id = clientID,
				client_secret = clientSecret,
				scope = string.Join(" ", roles)
			};
			return AuthenticateAsync(req);
		}

		public Task<TokenResponse> RefreshTokenAsync(string refreshToken) {
			return RefreshTokenAsync(Config.ClientId, refreshToken);
		}

		public Task<TokenResponse> RefreshTokenAsync(string clientID, string refreshToken) {
			Require(clientID, nameof(clientID));
			Require(refreshToken, nameof(refreshToken));

			var req = new OAuthTokenRequestWithRefreshTokenGrant {
				client_id = clientID,
				refresh_token = refreshToken
			};
			return AuthenticateAsync(req);
		}

		public void Dispose() => TokenResponse = null;

		internal bool EnableModelValidation { get; set; } = true;

		/// <summary>
		/// Creates an authenticated request that can be sent using Flurl semantics. Normally not needed since the SDK
		/// provides higher-level strongly-typed methods for all public endpoints, but if there's ever a need to call
		/// an undocumented endpoint, or the SDK version is behind the API version, this provides lower-level access.
		/// </summary>
		public IFlurlRequest Request(params object[] pathSegments) => ApiClient
			.Request(pathSegments)
			.ConfigureRequest(settings => {
				settings.BeforeCallAsync = EnsureTokenAsync;
				settings.OnErrorAsync = call => ThrowOcExceptionAsync<ApiErrorResponse>(call, r => r.Errors);
				settings.JsonSerializer = Serializer;
			});

		private async Task ThrowOcExceptionAsync<TError>(FlurlCall call, Func<TError, ApiError[]> buildErrors) {
			if (!(call.Exception is FlurlHttpException fex))
				return;

			ApiError[] errors;
			try {
				var body = await fex.GetResponseStringAsync();
				var resp = Serializer.Deserialize<TError>(body);
				errors = buildErrors(resp);
			}
			catch (Exception) {
				errors = new[] { new ApiError { Message = fex.Message } };
			}
			throw new OrderCloudException(call, errors);
		}

		private readonly SemaphoreSlim _authLock = new(1);

		private async Task EnsureTokenAsync(FlurlCall call) {
			if (call.Request.Headers.TryGetFirst("Authorization", out var value) && value.TrimEnd() != "Bearer")
				return; // a token was provided explicitly

			if (!IsAuthenticated) {
				await _authLock.WaitAsync();
				try {
					// expired token? try a refresh
					if (TokenResponse?.RefreshToken != null && TokenResponse.ExpiresUtc < DateTime.UtcNow) {
						try {
							var resp = await RefreshTokenAsync(TokenResponse.RefreshToken);
							TokenResponse.AccessToken = resp.AccessToken;
							TokenResponse.ExpiresUtc = resp.ExpiresUtc;
							TokenResponse.RefreshToken = resp.RefreshToken ?? TokenResponse.RefreshToken;
						}
						catch {
							// if anything goes wrong while refreshing the token, we'll fall back on re-authenticating below
						}
					}

					if (!IsAuthenticated)
						await AuthenticateAsync().ConfigureAwait(false);
				}
				finally {
					_authLock.Release();
				}
			}

			call.Request.WithOAuthBearerToken(TokenResponse.AccessToken);
		}

		private async Task<TokenResponse> AuthenticateAsync(OAuthTokenRequest req) {
			// https://jenkov.com/tutorials/oauth2/resource-owner-credentials-request-response.html
			var resp = await AuthClient
				.Request("oauth/token")
				.ConfigureRequest(settings => {
					settings.OnErrorAsync = call => ThrowOcExceptionAsync<AuthErrorResponse>(call, r => new[] {
						new ApiError {
							ErrorCode = r.error,
							Message = r.error_description
						}
					}); ;
					settings.JsonSerializer = Serializer;
				})
				.PostUrlEncodedAsync(req)
				.ReceiveJson<OAuthTokenResponse>()
				.ConfigureAwait(false);

			return new TokenResponse {
				AccessToken = resp?.access_token,
				// a bit arbitrary, but trim 30 seconds off the expiration to allow for latency
				ExpiresUtc = DateTime.UtcNow + TimeSpan.FromSeconds(resp?.expires_in ?? 0) - TimeSpan.FromSeconds(30),
				RefreshToken = resp?.refresh_token
			};
		}

		private void ValidateConfig() {
			if (Config.GrantType == GrantType.Password) {
				RequireConfigProp(c => c.ClientId);
				RequireConfigProp(c => c.Username);
				RequireConfigProp(c => c.Password);
			}
			else if (Config.GrantType == GrantType.ClientCredentials) {
				RequireConfigProp(c => c.ClientId);
			}
		}

		private void Require(string value, string name) {
			if (string.IsNullOrEmpty(value))
				throw new ArgumentException(name + " is required.");
		}

		private void RequireConfigProp(Expression<Func<OrderCloudClientConfig, string>> prop) {
			var val = prop.Compile().Invoke(Config);
			if (string.IsNullOrEmpty(val)) {
				var name = (prop.Body as MemberExpression)?.Member.Name;
				throw new ArgumentException(name + " is required on OrderCloudClient.Config.");
			}
		}
	}
}
