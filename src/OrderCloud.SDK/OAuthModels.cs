using System;
using System.Collections.Generic;
using System.Text;

namespace OrderCloud.SDK
{
	internal class OAuthTokenResponse
	{
		public string access_token { get; set; }
		public string token_type { get; set; }
		public long expires_in { get; set; }
		public string refresh_token { get; set; }
	}

	internal abstract class OAuthTokenRequest
	{
		public string grant_type { get; set; }
		public string client_id { get; set; }
		public string scope { get; set; }
	}

	internal class OAuthTokenRequestWithPasswordGrant : OAuthTokenRequest
	{
		public OAuthTokenRequestWithPasswordGrant() {
			grant_type = "password";
		}

		public string username { get; set; }
		public string password { get; set; }
		public string client_secret { get; set; }
	}

	internal class OAuthTokenRequestWithClientCredentialsGrant : OAuthTokenRequest
	{
		public OAuthTokenRequestWithClientCredentialsGrant() {
			grant_type = "client_credentials";
		}

		public string client_secret { get; set; }
	}
	
	internal class OAuthTokenRequestWithRefreshTokenGrant : OAuthTokenRequest 
	{
		public OAuthTokenRequestWithRefreshTokenGrant() {
			grant_type = "refresh_token";
		}
        
		public string refresh_token { get; set; }
		public string client_secret { get; set; }
	}

	public class PublicKey : OrderCloudModel
	{
		/// <summary>Kty of the public key.</summary>
		public string kty { get => GetProp<string>("kty"); set => SetProp<string>("kty", value); }
		/// <summary>N of the public key.</summary>
		public string n { get => GetProp<string>("n"); set => SetProp<string>("n", value); }
		/// <summary>E of the public key.</summary>
		public string e { get => GetProp<string>("e"); set => SetProp<string>("e", value); }
		/// <summary>Alg of the public key.</summary>
		public string alg { get => GetProp<string>("alg"); set => SetProp<string>("alg", value); }
		/// <summary>Use of the public key.</summary>
		public string use { get => GetProp<string>("use"); set => SetProp<string>("use", value); }
		/// <summary>Kid of the public key.</summary>
		public string kid { get => GetProp<string>("kid"); set => SetProp<string>("kid", value); }
	}
}
