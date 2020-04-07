using System;

namespace OrderCloud.SDK
{
	public class TokenResponse
	{
		/// <summary>
		/// The JWT token acquired from the OrderCloud authorization server and used in subsequent requests to the OrderClould API.
		/// </summary>
		public string AccessToken { get; set; }
		/// <summary>
		/// The expiration date/time of the authorization token
		/// </summary>
		public DateTime ExpiresUtc { get; set; }
		/// <summary>
		/// The refresh token acquired from the OrderCloud authorization server.
		/// </summary>
		public string RefreshToken { get; set; }
	}
}
