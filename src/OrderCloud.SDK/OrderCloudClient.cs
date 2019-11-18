using System;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using Flurl.Http;
using Flurl.Http.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

// allows test assemblies to access intrernal members, such as the Request method
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

		private IFlurlClient ApiClient => _clientFac.Get(Config.ApiUrl);
		private IFlurlClient AuthClient => _clientFac.Get(Config.AuthUrl);

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

		public void Dispose() => TokenResponse = null;

		internal bool EnableModelValidation { get; set; } = true;

		internal IFlurlRequest Request(params object[] pathSegments) => ApiClient
			.Request(pathSegments)
			.ConfigureRequest(settings => {
				settings.BeforeCallAsync = EnsureTokenAsync;
				settings.OnErrorAsync = ThrowApiExceptionAsync;
				settings.JsonSerializer = Serializer;
			});

		private async Task ThrowApiExceptionAsync(HttpCall call) {
			if (!(call.Exception is FlurlHttpException fex)) return;
			var resp = await fex.GetResponseJsonAsync<ApiErrorResponse>();
			throw new OrderCloudException(call, resp.Errors);
		}

		private async Task ThrowAuthExceptionAsync(HttpCall call) {
			if (!(call.Exception is FlurlHttpException fex)) return;
			var resp = await fex.GetResponseJsonAsync<AuthErrorResponse>();
			var error = new ApiError { ErrorCode = resp.error, Message = resp.error_description };
			throw new OrderCloudException(call, new[] { error });
		}

		private async Task EnsureTokenAsync(HttpCall call) {
			var hasToken =
				call.FlurlRequest.Headers.TryGetValue("Authorization", out var value) &&
				(value as string) != "Bearer ";

			if (!hasToken) {
				if (!IsAuthenticated)
					await AuthenticateAsync().ConfigureAwait(false);
				call.FlurlRequest.WithOAuthBearerToken(TokenResponse.AccessToken);
			}
		}

		private async Task<TokenResponse> AuthenticateAsync(OAuthTokenRequest req) {
			// http://tutorials.jenkov.com/oauth2/resource-owner-credentials-request-response.html
			var resp = await AuthClient
				.Request("oauth/token")
				.ConfigureRequest(settings => {
					settings.OnErrorAsync = ThrowAuthExceptionAsync;
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
			else if (Config.GrantType == GrantType.Password) {
				RequireConfigProp(c => c.ClientId);
				RequireConfigProp(c => c.ClientSecret);
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
