using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCloud.SDK
{
	/// <summary>
	/// OAuth2 grant type.
	/// </summary>
	public enum GrantType
	{
		None,
		/// <summary>
		/// Requires that a username and password be provided. Appropriate for end-user applications where a human is entering their personal OrderCloud credentials.
		/// </summary>
		Password,
		/// <summary>
		/// Requires that a client secret be provided. Appropriate for server-to-server integrations where secret can be secured/encryped; NEVER use in end-user applications.
		/// </summary>
		ClientCredentials
	}

	public class OrderCloudClientConfig
	{
		private string _username;
		private string _clientSecret;

		/// <summary>
		/// The OAuth2 grant type that will be used to authenticate.
		/// </summary>
		public GrantType GrantType { get; set; }
		/// <summary>
		/// The base URL of the OrderCloud API you're targeting. This URL can be found on your dashboard or in the upper right hand context menu of your OrderCloud application in Sitecore Portal.
		/// </summary>
		public string ApiUrl { get; set; } = "https://api.ordercloud.io";
		/// <summary>
		/// The OAuth2 client ID. Always required.
		/// </summary>
		public string ClientId { get; set; }
		/// <summary>
		/// The OAuth2 client secret. Required if GrantType is ClientCredentials.
		/// </summary>
		public string ClientSecret
		{
			get => _clientSecret;
			set
			{
				_clientSecret = value;
				if (!string.IsNullOrEmpty(_clientSecret))
					GrantType = GrantType.ClientCredentials;
			}
		}
		/// <summary>
		/// The OAuth2 username. Required if GrantType is Password.
		/// </summary>
		public string Username {
			get => _username;
			set {
				_username = value;
				if (!string.IsNullOrEmpty(_username))
					GrantType = GrantType.Password;
			}
		}
		/// <summary>
		/// The OAuth2 password. Required if GrantType is Password.
		/// </summary>
		public string Password { get; set; }
		/// <summary>
		/// A list of one or more roles to declare with each call. (User must be assigned these roles via a security profile.)
		/// </summary>
		public ApiRole[] Roles { get; set; }
	}
}
