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
	}

	internal class OAuthTokenRequestWithClientCredentialsGrant : OAuthTokenRequest
	{
		public OAuthTokenRequestWithClientCredentialsGrant() {
			grant_type = "client_credentials";
		}

		public string client_secret { get; set; }
	}
}
