using System;

namespace OrderCloud.SDK
{
	public static class WebhookPayloads
	{
		public static class Addresses
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses")]
			public class Create : WebhookPayload<Address, Address, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses")]
			public class Create<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, CreateRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Save : WebhookPayload<Address, Address, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Save<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, SaveRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Patch : WebhookPayload<Address, Address, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Patch<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, PatchRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string BuyerID { get; set; }
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses/assignments")]
			public class SaveAssignment : WebhookPayload<AddressAssignment, object, SaveAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddressAssignment">Specific type of the AddressAssignment. If not using a custom type, specify AddressAssignment.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses/assignments")]
			public class SaveAssignment<TConfigData, TAddressAssignment> : WebhookPayload<TAddressAssignment, object, SaveAssignmentRouteParams, TConfigData>
				where TAddressAssignment : AddressAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/assignments.</summary>
			public class SaveAssignmentRouteParams
			{
				public string BuyerID { get; set; }
			}
		}
		public static class AdminAddresses
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/addresses.</summary>
			[SentOn("POST", "v1/addresses")]
			public class Create : WebhookPayload<Address, Address, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/addresses.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("POST", "v1/addresses")]
			public class Create<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, object, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/addresses/{addressID}")]
			public class Save : WebhookPayload<Address, Address, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("PUT", "v1/addresses/{addressID}")]
			public class Save<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, SaveRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/addresses/{addressID}.</summary>
			public class SaveRouteParams
			{
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/addresses/{addressID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/addresses/{addressID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/addresses/{addressID}.</summary>
			public class DeleteRouteParams
			{
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/addresses/{addressID}")]
			public class Patch : WebhookPayload<Address, Address, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("PATCH", "v1/addresses/{addressID}")]
			public class Patch<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, PatchRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/addresses/{addressID}.</summary>
			public class PatchRouteParams
			{
				public string AddressID { get; set; }
			}
		}
		public static class AdminUserGroups
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups.</summary>
			[SentOn("POST", "v1/usergroups")]
			public class Create : WebhookPayload<UserGroup, UserGroup, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("POST", "v1/usergroups")]
			public class Create<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, object, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/usergroups/{userGroupID}.</summary>
			[SentOn("PUT", "v1/usergroups/{userGroupID}")]
			public class Save : WebhookPayload<UserGroup, UserGroup, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("PUT", "v1/usergroups/{userGroupID}")]
			public class Save<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, SaveRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}.</summary>
			public class SaveRouteParams
			{
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}.</summary>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}.</summary>
			public class DeleteRouteParams
			{
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/usergroups/{userGroupID}.</summary>
			[SentOn("PATCH", "v1/usergroups/{userGroupID}")]
			public class Patch : WebhookPayload<UserGroup, UserGroup, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("PATCH", "v1/usergroups/{userGroupID}")]
			public class Patch<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, PatchRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}.</summary>
			public class PatchRouteParams
			{
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}/assignments/{userID}.</summary>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment : WebhookPayload<object, object, DeleteUserAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}/assignments/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment<TConfigData> : WebhookPayload<object, object, DeleteUserAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}/assignments/{userID}.</summary>
			public class DeleteUserAssignmentRouteParams
			{
				public string UserGroupID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups/assignments.</summary>
			[SentOn("POST", "v1/usergroups/assignments")]
			public class SaveUserAssignment : WebhookPayload<UserGroupAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroupAssignment">Specific type of the UserGroupAssignment. If not using a custom type, specify UserGroupAssignment.</typeparam>
			[SentOn("POST", "v1/usergroups/assignments")]
			public class SaveUserAssignment<TConfigData, TUserGroupAssignment> : WebhookPayload<TUserGroupAssignment, object, object, TConfigData>
				where TUserGroupAssignment : UserGroupAssignment
			{ }
		}
		public static class AdminUsers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/adminusers.</summary>
			[SentOn("POST", "v1/adminusers")]
			public class Create : WebhookPayload<User, User, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/adminusers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("POST", "v1/adminusers")]
			public class Create<TConfigData, TUser> : WebhookPayload<TUser, TUser, object, TConfigData>
				where TUser : User
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/adminusers/{userID}.</summary>
			[SentOn("PUT", "v1/adminusers/{userID}")]
			public class Save : WebhookPayload<User, User, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/adminusers/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("PUT", "v1/adminusers/{userID}")]
			public class Save<TConfigData, TUser> : WebhookPayload<TUser, TUser, SaveRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}.</summary>
			public class SaveRouteParams
			{
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/adminusers/{userID}.</summary>
			[SentOn("DELETE", "v1/adminusers/{userID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/adminusers/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/adminusers/{userID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}.</summary>
			public class DeleteRouteParams
			{
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/adminusers/{userID}.</summary>
			[SentOn("PATCH", "v1/adminusers/{userID}")]
			public class Patch : WebhookPayload<User, User, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/adminusers/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("PATCH", "v1/adminusers/{userID}")]
			public class Patch<TConfigData, TUser> : WebhookPayload<TUser, TUser, PatchRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}.</summary>
			public class PatchRouteParams
			{
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/adminusers/{userID}/unlock.</summary>
			[SentOn("POST", "v1/adminusers/{userID}/unlock")]
			public class UnlockUserAccount : WebhookPayload<object, object, UnlockUserAccountRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/adminusers/{userID}/unlock.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/adminusers/{userID}/unlock")]
			public class UnlockUserAccount<TConfigData> : WebhookPayload<object, object, UnlockUserAccountRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}/unlock.</summary>
			public class UnlockUserAccountRouteParams
			{
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/adminusers/{userID}/tokens.</summary>
			[SentOn("DELETE", "v1/adminusers/{userID}/tokens")]
			public class RevokeUserTokens : WebhookPayload<object, object, RevokeUserTokensRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/adminusers/{userID}/tokens.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/adminusers/{userID}/tokens")]
			public class RevokeUserTokens<TConfigData> : WebhookPayload<object, object, RevokeUserTokensRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}/tokens.</summary>
			public class RevokeUserTokensRouteParams
			{
				public string UserID { get; set; }
			}
		}
		public static class ApiClients
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients.</summary>
			[SentOn("POST", "v1/apiclients")]
			public class Create : WebhookPayload<ApiClient, ApiClient, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApiClient">Specific type of the ApiClient. If not using a custom type, specify ApiClient.</typeparam>
			[SentOn("POST", "v1/apiclients")]
			public class Create<TConfigData, TApiClient> : WebhookPayload<TApiClient, TApiClient, object, TConfigData>
				where TApiClient : ApiClient
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/apiclients/{apiClientID}.</summary>
			[SentOn("PUT", "v1/apiclients/{apiClientID}")]
			public class Save : WebhookPayload<ApiClient, ApiClient, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/apiclients/{apiClientID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApiClient">Specific type of the ApiClient. If not using a custom type, specify ApiClient.</typeparam>
			[SentOn("PUT", "v1/apiclients/{apiClientID}")]
			public class Save<TConfigData, TApiClient> : WebhookPayload<TApiClient, TApiClient, SaveRouteParams, TConfigData>
				where TApiClient : ApiClient
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}.</summary>
			public class SaveRouteParams
			{
				public string ApiClientID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/apiclients/{apiClientID}.</summary>
			[SentOn("DELETE", "v1/apiclients/{apiClientID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/apiclients/{apiClientID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/apiclients/{apiClientID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}.</summary>
			public class DeleteRouteParams
			{
				public string ApiClientID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/apiclients/{apiClientID}.</summary>
			[SentOn("PATCH", "v1/apiclients/{apiClientID}")]
			public class Patch : WebhookPayload<ApiClient, ApiClient, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/apiclients/{apiClientID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApiClient">Specific type of the ApiClient. If not using a custom type, specify ApiClient.</typeparam>
			[SentOn("PATCH", "v1/apiclients/{apiClientID}")]
			public class Patch<TConfigData, TApiClient> : WebhookPayload<TApiClient, TApiClient, PatchRouteParams, TConfigData>
				where TApiClient : ApiClient
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}.</summary>
			public class PatchRouteParams
			{
				public string ApiClientID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients/assignments.</summary>
			[SentOn("POST", "v1/apiclients/assignments")]
			public class SaveAssignment : WebhookPayload<ApiClientAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApiClientAssignment">Specific type of the ApiClientAssignment. If not using a custom type, specify ApiClientAssignment.</typeparam>
			[SentOn("POST", "v1/apiclients/assignments")]
			public class SaveAssignment<TConfigData, TApiClientAssignment> : WebhookPayload<TApiClientAssignment, object, object, TConfigData>
				where TApiClientAssignment : ApiClientAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteBuyerAssignment : WebhookPayload<object, object, DeleteBuyerAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteBuyerAssignment<TConfigData> : WebhookPayload<object, object, DeleteBuyerAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}.</summary>
			public class DeleteBuyerAssignmentRouteParams
			{
				public string ApiClientID { get; set; }
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteSupplierAssignment : WebhookPayload<object, object, DeleteSupplierAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteSupplierAssignment<TConfigData> : WebhookPayload<object, object, DeleteSupplierAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}.</summary>
			public class DeleteSupplierAssignmentRouteParams
			{
				public string ApiClientID { get; set; }
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients/{apiClientID}/secrets.</summary>
			[SentOn("POST", "v1/apiclients/{apiClientID}/secrets")]
			public class CreateSecret : WebhookPayload<ApiClientSecret, ApiClientSecretCreateResponse, CreateSecretRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients/{apiClientID}/secrets.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApiClientSecret">Specific type of the ApiClientSecret. If not using a custom type, specify ApiClientSecret.</typeparam>
			/// <typeparam name="TApiClientSecretCreateResponse">Specific type of the ApiClientSecretCreateResponse. If not using a custom type, specify ApiClientSecretCreateResponse.</typeparam>
			[SentOn("POST", "v1/apiclients/{apiClientID}/secrets")]
			public class CreateSecret<TConfigData, TApiClientSecret, TApiClientSecretCreateResponse> : WebhookPayload<TApiClientSecret, TApiClientSecretCreateResponse, CreateSecretRouteParams, TConfigData>
				where TApiClientSecret : ApiClientSecret
				where TApiClientSecretCreateResponse : ApiClientSecretCreateResponse
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}/secrets.</summary>
			public class CreateSecretRouteParams
			{
				public string ApiClientID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}.</summary>
			[SentOn("PATCH", "v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}")]
			public class PatchSecret : WebhookPayload<ApiClientSecret, ApiClientSecret, PatchSecretRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApiClientSecret">Specific type of the ApiClientSecret. If not using a custom type, specify ApiClientSecret.</typeparam>
			[SentOn("PATCH", "v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}")]
			public class PatchSecret<TConfigData, TApiClientSecret> : WebhookPayload<TApiClientSecret, TApiClientSecret, PatchSecretRouteParams, TConfigData>
				where TApiClientSecret : ApiClientSecret
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}.</summary>
			public class PatchSecretRouteParams
			{
				public string ApiClientID { get; set; }
				public string ApiClientSecretID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}.</summary>
			[SentOn("DELETE", "v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}")]
			public class DeleteSecret : WebhookPayload<object, object, DeleteSecretRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}")]
			public class DeleteSecret<TConfigData> : WebhookPayload<object, object, DeleteSecretRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}/secrets/{apiClientSecretID}.</summary>
			public class DeleteSecretRouteParams
			{
				public string ApiClientID { get; set; }
				public string ApiClientSecretID { get; set; }
			}
		}
		public static class ApprovalRules
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/approvalrules.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/approvalrules")]
			public class Create : WebhookPayload<ApprovalRule, ApprovalRule, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/approvalrules.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApprovalRule">Specific type of the ApprovalRule. If not using a custom type, specify ApprovalRule.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/approvalrules")]
			public class Create<TConfigData, TApprovalRule> : WebhookPayload<TApprovalRule, TApprovalRule, CreateRouteParams, TConfigData>
				where TApprovalRule : ApprovalRule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Save : WebhookPayload<ApprovalRule, ApprovalRule, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApprovalRule">Specific type of the ApprovalRule. If not using a custom type, specify ApprovalRule.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Save<TConfigData, TApprovalRule> : WebhookPayload<TApprovalRule, TApprovalRule, SaveRouteParams, TConfigData>
				where TApprovalRule : ApprovalRule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string ApprovalRuleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string ApprovalRuleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Patch : WebhookPayload<ApprovalRule, ApprovalRule, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApprovalRule">Specific type of the ApprovalRule. If not using a custom type, specify ApprovalRule.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Patch<TConfigData, TApprovalRule> : WebhookPayload<TApprovalRule, TApprovalRule, PatchRouteParams, TConfigData>
				where TApprovalRule : ApprovalRule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string ApprovalRuleID { get; set; }
			}
		}
		public static class BundleLineItems
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/bundles/{bundleID}.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/bundles/{bundleID}")]
			public class Create : WebhookPayload<BundleItems, LineItem, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleItems">Specific type of the BundleItems. If not using a custom type, specify BundleItems.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/bundles/{bundleID}")]
			public class Create<TConfigData, TBundleItems, TLineItem> : WebhookPayload<TBundleItems, TLineItem, CreateRouteParams, TConfigData>
				where TBundleItems : BundleItems
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/bundles/{bundleID}.</summary>
			public class CreateRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/bundles/{bundleID}/{bundleItemID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/bundles/{bundleID}/{bundleItemID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/bundles/{bundleID}/{bundleItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/bundles/{bundleID}/{bundleItemID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/bundles/{bundleID}/{bundleItemID}.</summary>
			public class DeleteRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string BundleID { get; set; }
				public string BundleItemID { get; set; }
			}
		}
		public static class Bundles
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/bundles.</summary>
			[SentOn("POST", "v1/bundles")]
			public class Create : WebhookPayload<Bundle, Bundle, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/bundles.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundle">Specific type of the Bundle. If not using a custom type, specify Bundle.</typeparam>
			[SentOn("POST", "v1/bundles")]
			public class Create<TConfigData, TBundle> : WebhookPayload<TBundle, TBundle, object, TConfigData>
				where TBundle : Bundle
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/bundles/{bundleID}.</summary>
			[SentOn("PUT", "v1/bundles/{bundleID}")]
			public class Save : WebhookPayload<Bundle, Bundle, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundle">Specific type of the Bundle. If not using a custom type, specify Bundle.</typeparam>
			[SentOn("PUT", "v1/bundles/{bundleID}")]
			public class Save<TConfigData, TBundle> : WebhookPayload<TBundle, TBundle, SaveRouteParams, TConfigData>
				where TBundle : Bundle
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/bundles/{bundleID}.</summary>
			public class SaveRouteParams
			{
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/bundles/{bundleID}.</summary>
			[SentOn("DELETE", "v1/bundles/{bundleID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/bundles/{bundleID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/bundles/{bundleID}.</summary>
			public class DeleteRouteParams
			{
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/bundles/{bundleID}.</summary>
			[SentOn("PATCH", "v1/bundles/{bundleID}")]
			public class Patch : WebhookPayload<Bundle, Bundle, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundle">Specific type of the Bundle. If not using a custom type, specify Bundle.</typeparam>
			[SentOn("PATCH", "v1/bundles/{bundleID}")]
			public class Patch<TConfigData, TBundle> : WebhookPayload<TBundle, TBundle, PatchRouteParams, TConfigData>
				where TBundle : Bundle
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/bundles/{bundleID}.</summary>
			public class PatchRouteParams
			{
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/bundles/productassignments.</summary>
			[SentOn("POST", "v1/bundles/productassignments")]
			public class SaveProductAssignment : WebhookPayload<BundleProductAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/bundles/productassignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleProductAssignment">Specific type of the BundleProductAssignment. If not using a custom type, specify BundleProductAssignment.</typeparam>
			[SentOn("POST", "v1/bundles/productassignments")]
			public class SaveProductAssignment<TConfigData, TBundleProductAssignment> : WebhookPayload<TBundleProductAssignment, object, object, TConfigData>
				where TBundleProductAssignment : BundleProductAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/bundles/{bundleID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/bundles/{bundleID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/bundles/{bundleID}/productassignments/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/bundles/{bundleID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/bundles/{bundleID}/productassignments/{productID}.</summary>
			public class DeleteProductAssignmentRouteParams
			{
				public string BundleID { get; set; }
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/bundles/assignments.</summary>
			[SentOn("POST", "v1/bundles/assignments")]
			public class SaveAssignment : WebhookPayload<BundleAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/bundles/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleAssignment">Specific type of the BundleAssignment. If not using a custom type, specify BundleAssignment.</typeparam>
			[SentOn("POST", "v1/bundles/assignments")]
			public class SaveAssignment<TConfigData, TBundleAssignment> : WebhookPayload<TBundleAssignment, object, object, TConfigData>
				where TBundleAssignment : BundleAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/bundles/{bundleID}/assignments/{buyerID}.</summary>
			[SentOn("DELETE", "v1/bundles/{bundleID}/assignments/{buyerID}")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/bundles/{bundleID}/assignments/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/bundles/{bundleID}/assignments/{buyerID}")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/bundles/{bundleID}/assignments/{buyerID}.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string BundleID { get; set; }
				public string BuyerID { get; set; }
			}
		}
		public static class BundleSubscriptionItems
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/subscriptions/{subscriptionID}/bundles/{bundleID}.</summary>
			[SentOn("POST", "v1/subscriptions/{subscriptionID}/bundles/{bundleID}")]
			public class Create : WebhookPayload<BundleItems, LineItem, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/subscriptions/{subscriptionID}/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleItems">Specific type of the BundleItems. If not using a custom type, specify BundleItems.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/subscriptions/{subscriptionID}/bundles/{bundleID}")]
			public class Create<TConfigData, TBundleItems, TLineItem> : WebhookPayload<TBundleItems, TLineItem, CreateRouteParams, TConfigData>
				where TBundleItems : BundleItems
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}/bundles/{bundleID}.</summary>
			public class CreateRouteParams
			{
				public string SubscriptionID { get; set; }
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/subscriptions/{subscriptionID}/bundles/{bundleID}/{bundleItemID}.</summary>
			[SentOn("DELETE", "v1/subscriptions/{subscriptionID}/bundles/{bundleID}/{bundleItemID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/subscriptions/{subscriptionID}/bundles/{bundleID}/{bundleItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/subscriptions/{subscriptionID}/bundles/{bundleID}/{bundleItemID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}/bundles/{bundleID}/{bundleItemID}.</summary>
			public class DeleteRouteParams
			{
				public string SubscriptionID { get; set; }
				public string BundleID { get; set; }
				public string BundleItemID { get; set; }
			}
		}
		public static class Buyers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers.</summary>
			[SentOn("POST", "v1/buyers")]
			public class Create : WebhookPayload<Buyer, Buyer, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyer">Specific type of the Buyer. If not using a custom type, specify Buyer.</typeparam>
			[SentOn("POST", "v1/buyers")]
			public class Create<TConfigData, TBuyer> : WebhookPayload<TBuyer, TBuyer, object, TConfigData>
				where TBuyer : Buyer
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}")]
			public class Save : WebhookPayload<Buyer, Buyer, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyer">Specific type of the Buyer. If not using a custom type, specify Buyer.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}")]
			public class Save<TConfigData, TBuyer> : WebhookPayload<TBuyer, TBuyer, SaveRouteParams, TConfigData>
				where TBuyer : Buyer
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}")]
			public class Patch : WebhookPayload<Buyer, Buyer, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyer">Specific type of the Buyer. If not using a custom type, specify Buyer.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}")]
			public class Patch<TConfigData, TBuyer> : WebhookPayload<TBuyer, TBuyer, PatchRouteParams, TConfigData>
				where TBuyer : Buyer
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
			}
		}
		public static class Cart
		{
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart.</summary>
			[SentOn("PUT", "v1/cart")]
			public class Save : WebhookPayload<Order, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PUT", "v1/cart")]
			public class Save<TConfigData, TOrder> : WebhookPayload<TOrder, TOrder, object, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart.</summary>
			[SentOn("DELETE", "v1/cart")]
			public class Delete : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/cart")]
			public class Delete<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/{orderID}.</summary>
			[SentOn("PUT", "v1/cart/{orderID}")]
			public class SetActiveCart : WebhookPayload<object, object, SetActiveCartRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/{orderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("PUT", "v1/cart/{orderID}")]
			public class SetActiveCart<TConfigData> : WebhookPayload<object, object, SetActiveCartRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/{orderID}.</summary>
			public class SetActiveCartRouteParams
			{
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart.</summary>
			[SentOn("PATCH", "v1/cart")]
			public class Patch : WebhookPayload<Order, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/cart")]
			public class Patch<TConfigData, TOrder> : WebhookPayload<TOrder, TOrder, object, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/lineitems.</summary>
			[SentOn("POST", "v1/cart/lineitems")]
			public class CreateLineItem : WebhookPayload<LineItem, LineItem, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/lineitems.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/cart/lineitems")]
			public class CreateLineItem<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, object, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/lineitems/{lineItemID}.</summary>
			[SentOn("PUT", "v1/cart/lineitems/{lineItemID}")]
			public class SaveLineItem : WebhookPayload<LineItem, LineItem, SaveLineItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/lineitems/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PUT", "v1/cart/lineitems/{lineItemID}")]
			public class SaveLineItem<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, SaveLineItemRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/lineitems/{lineItemID}.</summary>
			public class SaveLineItemRouteParams
			{
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/lineitems/{lineItemID}.</summary>
			[SentOn("PATCH", "v1/cart/lineitems/{lineItemID}")]
			public class PatchLineItem : WebhookPayload<LineItem, LineItem, PatchLineItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/lineitems/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PATCH", "v1/cart/lineitems/{lineItemID}")]
			public class PatchLineItem<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, PatchLineItemRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/lineitems/{lineItemID}.</summary>
			public class PatchLineItemRouteParams
			{
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/lineitems/{lineItemID}.</summary>
			[SentOn("DELETE", "v1/cart/lineitems/{lineItemID}")]
			public class DeleteLineItem : WebhookPayload<object, object, DeleteLineItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/lineitems/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/cart/lineitems/{lineItemID}")]
			public class DeleteLineItem<TConfigData> : WebhookPayload<object, object, DeleteLineItemRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/lineitems/{lineItemID}.</summary>
			public class DeleteLineItemRouteParams
			{
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/bundles/{bundleID}.</summary>
			[SentOn("POST", "v1/cart/bundles/{bundleID}")]
			public class CreateBundleItem : WebhookPayload<BundleItems, LineItem, CreateBundleItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleItems">Specific type of the BundleItems. If not using a custom type, specify BundleItems.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/cart/bundles/{bundleID}")]
			public class CreateBundleItem<TConfigData, TBundleItems, TLineItem> : WebhookPayload<TBundleItems, TLineItem, CreateBundleItemRouteParams, TConfigData>
				where TBundleItems : BundleItems
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/bundles/{bundleID}.</summary>
			public class CreateBundleItemRouteParams
			{
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/bundles/{bundleID}/{bundleItemID}.</summary>
			[SentOn("DELETE", "v1/cart/bundles/{bundleID}/{bundleItemID}")]
			public class DeleteBundleItem : WebhookPayload<object, object, DeleteBundleItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/bundles/{bundleID}/{bundleItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/cart/bundles/{bundleID}/{bundleItemID}")]
			public class DeleteBundleItem<TConfigData> : WebhookPayload<object, object, DeleteBundleItemRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/bundles/{bundleID}/{bundleItemID}.</summary>
			public class DeleteBundleItemRouteParams
			{
				public string BundleID { get; set; }
				public string BundleItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/promotions/{promoCode}.</summary>
			[SentOn("POST", "v1/cart/promotions/{promoCode}")]
			public class AddPromotion : WebhookPayload<object, OrderPromotion, AddPromotionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/promotions/{promoCode}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderPromotion">Specific type of the OrderPromotion. If not using a custom type, specify OrderPromotion.</typeparam>
			[SentOn("POST", "v1/cart/promotions/{promoCode}")]
			public class AddPromotion<TConfigData, TOrderPromotion> : WebhookPayload<object, TOrderPromotion, AddPromotionRouteParams, TConfigData>
				where TOrderPromotion : OrderPromotion
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/promotions/{promoCode}.</summary>
			public class AddPromotionRouteParams
			{
				public string PromoCode { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/promotions/{promoCode}.</summary>
			[SentOn("DELETE", "v1/cart/promotions/{promoCode}")]
			public class DeletePromotion : WebhookPayload<object, object, DeletePromotionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/promotions/{promoCode}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/cart/promotions/{promoCode}")]
			public class DeletePromotion<TConfigData> : WebhookPayload<object, object, DeletePromotionRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/promotions/{promoCode}.</summary>
			public class DeletePromotionRouteParams
			{
				public string PromoCode { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/applypromotions.</summary>
			[SentOn("POST", "v1/cart/applypromotions")]
			public class ApplyPromotions : WebhookPayload<object, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/applypromotions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/cart/applypromotions")]
			public class ApplyPromotions<TConfigData, TOrder> : WebhookPayload<object, TOrder, object, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/fromuser.</summary>
			[SentOn("PATCH", "v1/cart/fromuser")]
			public class PatchFromUser : WebhookPayload<User, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/fromuser.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/cart/fromuser")]
			public class PatchFromUser<TConfigData, TUser, TOrder> : WebhookPayload<TUser, TOrder, object, TConfigData>
				where TUser : User
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/payments.</summary>
			[SentOn("POST", "v1/cart/payments")]
			public class CreatePayment : WebhookPayload<Payment, Payment, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/payments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPayment">Specific type of the Payment. If not using a custom type, specify Payment.</typeparam>
			[SentOn("POST", "v1/cart/payments")]
			public class CreatePayment<TConfigData, TPayment> : WebhookPayload<TPayment, TPayment, object, TConfigData>
				where TPayment : Payment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/payments/{paymentID}.</summary>
			[SentOn("PATCH", "v1/cart/payments/{paymentID}")]
			public class PatchPayment : WebhookPayload<Payment, Payment, PatchPaymentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/payments/{paymentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPayment">Specific type of the Payment. If not using a custom type, specify Payment.</typeparam>
			[SentOn("PATCH", "v1/cart/payments/{paymentID}")]
			public class PatchPayment<TConfigData, TPayment> : WebhookPayload<TPayment, TPayment, PatchPaymentRouteParams, TConfigData>
				where TPayment : Payment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/payments/{paymentID}.</summary>
			public class PatchPaymentRouteParams
			{
				public string PaymentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/payments/{paymentID}.</summary>
			[SentOn("DELETE", "v1/cart/payments/{paymentID}")]
			public class DeletePayment : WebhookPayload<object, object, DeletePaymentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/payments/{paymentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/cart/payments/{paymentID}")]
			public class DeletePayment<TConfigData> : WebhookPayload<object, object, DeletePaymentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/payments/{paymentID}.</summary>
			public class DeletePaymentRouteParams
			{
				public string PaymentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/payments/{paymentID}/transactions.</summary>
			[SentOn("POST", "v1/cart/payments/{paymentID}/transactions")]
			public class CreatePaymentTransaction : WebhookPayload<PaymentTransaction, Payment, CreatePaymentTransactionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/payments/{paymentID}/transactions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPaymentTransaction">Specific type of the PaymentTransaction. If not using a custom type, specify PaymentTransaction.</typeparam>
			/// <typeparam name="TPayment">Specific type of the Payment. If not using a custom type, specify Payment.</typeparam>
			[SentOn("POST", "v1/cart/payments/{paymentID}/transactions")]
			public class CreatePaymentTransaction<TConfigData, TPaymentTransaction, TPayment> : WebhookPayload<TPaymentTransaction, TPayment, CreatePaymentTransactionRouteParams, TConfigData>
				where TPaymentTransaction : PaymentTransaction
				where TPayment : Payment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/payments/{paymentID}/transactions.</summary>
			public class CreatePaymentTransactionRouteParams
			{
				public string PaymentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/payments/{paymentID}/transactions/{transactionID}.</summary>
			[SentOn("DELETE", "v1/cart/payments/{paymentID}/transactions/{transactionID}")]
			public class DeletePaymentTransaction : WebhookPayload<object, object, DeletePaymentTransactionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/cart/payments/{paymentID}/transactions/{transactionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/cart/payments/{paymentID}/transactions/{transactionID}")]
			public class DeletePaymentTransaction<TConfigData> : WebhookPayload<object, object, DeletePaymentTransactionRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/cart/payments/{paymentID}/transactions/{transactionID}.</summary>
			public class DeletePaymentTransactionRouteParams
			{
				public string PaymentID { get; set; }
				public string TransactionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/submit.</summary>
			[SentOn("POST", "v1/cart/submit")]
			public class Submit : WebhookPayload<object, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/submit.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/cart/submit")]
			public class Submit<TConfigData, TOrder> : WebhookPayload<object, TOrder, object, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/validate.</summary>
			[SentOn("POST", "v1/cart/validate")]
			public class Validate : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/validate.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/cart/validate")]
			public class Validate<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/calculate.</summary>
			[SentOn("POST", "v1/cart/calculate")]
			public class Calculate : WebhookPayload<object, OrderWorksheet, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/calculate.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderWorksheet">Specific type of the OrderWorksheet. If not using a custom type, specify OrderWorksheet.</typeparam>
			[SentOn("POST", "v1/cart/calculate")]
			public class Calculate<TConfigData, TOrderWorksheet> : WebhookPayload<object, TOrderWorksheet, object, TConfigData>
				where TOrderWorksheet : OrderWorksheet
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/estimateshipping.</summary>
			[SentOn("POST", "v1/cart/estimateshipping")]
			public class EstimateShipping : WebhookPayload<object, OrderWorksheet, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/estimateshipping.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderWorksheet">Specific type of the OrderWorksheet. If not using a custom type, specify OrderWorksheet.</typeparam>
			[SentOn("POST", "v1/cart/estimateshipping")]
			public class EstimateShipping<TConfigData, TOrderWorksheet> : WebhookPayload<object, TOrderWorksheet, object, TConfigData>
				where TOrderWorksheet : OrderWorksheet
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/shipmethods.</summary>
			[SentOn("POST", "v1/cart/shipmethods")]
			public class SelectShipMethods : WebhookPayload<OrderShipMethodSelection, OrderWorksheet, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/cart/shipmethods.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderShipMethodSelection">Specific type of the OrderShipMethodSelection. If not using a custom type, specify OrderShipMethodSelection.</typeparam>
			/// <typeparam name="TOrderWorksheet">Specific type of the OrderWorksheet. If not using a custom type, specify OrderWorksheet.</typeparam>
			[SentOn("POST", "v1/cart/shipmethods")]
			public class SelectShipMethods<TConfigData, TOrderShipMethodSelection, TOrderWorksheet> : WebhookPayload<TOrderShipMethodSelection, TOrderWorksheet, object, TConfigData>
				where TOrderShipMethodSelection : OrderShipMethodSelection
				where TOrderWorksheet : OrderWorksheet
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/shipto.</summary>
			[SentOn("PUT", "v1/cart/shipto")]
			public class SetShippingAddress : WebhookPayload<Address, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PUT", "v1/cart/shipto")]
			public class SetShippingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, object, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/shipto.</summary>
			[SentOn("PATCH", "v1/cart/shipto")]
			public class PatchShippingAddress : WebhookPayload<Address, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/cart/shipto")]
			public class PatchShippingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, object, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/billto.</summary>
			[SentOn("PUT", "v1/cart/billto")]
			public class SetBillingAddress : WebhookPayload<Address, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/cart/billto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PUT", "v1/cart/billto")]
			public class SetBillingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, object, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/billto.</summary>
			[SentOn("PATCH", "v1/cart/billto")]
			public class PatchBillingAddress : WebhookPayload<Address, Order, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/cart/billto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/cart/billto")]
			public class PatchBillingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, object, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
		}
		public static class Catalogs
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs.</summary>
			[SentOn("POST", "v1/catalogs")]
			public class Create : WebhookPayload<Catalog, Catalog, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCatalog">Specific type of the Catalog. If not using a custom type, specify Catalog.</typeparam>
			[SentOn("POST", "v1/catalogs")]
			public class Create<TConfigData, TCatalog> : WebhookPayload<TCatalog, TCatalog, object, TConfigData>
				where TCatalog : Catalog
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}.</summary>
			[SentOn("PUT", "v1/catalogs/{catalogID}")]
			public class Save : WebhookPayload<Catalog, Catalog, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCatalog">Specific type of the Catalog. If not using a custom type, specify Catalog.</typeparam>
			[SentOn("PUT", "v1/catalogs/{catalogID}")]
			public class Save<TConfigData, TCatalog> : WebhookPayload<TCatalog, TCatalog, SaveRouteParams, TConfigData>
				where TCatalog : Catalog
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}.</summary>
			public class SaveRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}.</summary>
			public class DeleteRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}.</summary>
			[SentOn("PATCH", "v1/catalogs/{catalogID}")]
			public class Patch : WebhookPayload<Catalog, Catalog, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCatalog">Specific type of the Catalog. If not using a custom type, specify Catalog.</typeparam>
			[SentOn("PATCH", "v1/catalogs/{catalogID}")]
			public class Patch<TConfigData, TCatalog> : WebhookPayload<TCatalog, TCatalog, PatchRouteParams, TConfigData>
				where TCatalog : Catalog
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}.</summary>
			public class PatchRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/assignments.</summary>
			[SentOn("POST", "v1/catalogs/assignments")]
			public class SaveAssignment : WebhookPayload<CatalogAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCatalogAssignment">Specific type of the CatalogAssignment. If not using a custom type, specify CatalogAssignment.</typeparam>
			[SentOn("POST", "v1/catalogs/assignments")]
			public class SaveAssignment<TConfigData, TCatalogAssignment> : WebhookPayload<TCatalogAssignment, object, object, TConfigData>
				where TCatalogAssignment : CatalogAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/assignments.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/productassignments.</summary>
			[SentOn("POST", "v1/catalogs/productassignments")]
			public class SaveProductAssignment : WebhookPayload<ProductCatalogAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/productassignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCatalogAssignment">Specific type of the ProductCatalogAssignment. If not using a custom type, specify ProductCatalogAssignment.</typeparam>
			[SentOn("POST", "v1/catalogs/productassignments")]
			public class SaveProductAssignment<TConfigData, TProductCatalogAssignment> : WebhookPayload<TProductCatalogAssignment, object, object, TConfigData>
				where TProductCatalogAssignment : ProductCatalogAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/productassignments/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/productassignments/{productID}.</summary>
			public class DeleteProductAssignmentRouteParams
			{
				public string CatalogID { get; set; }
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/bundleassignments.</summary>
			[SentOn("POST", "v1/catalogs/bundleassignments")]
			public class SaveBundleAssignment : WebhookPayload<BundleCatalogAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/bundleassignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleCatalogAssignment">Specific type of the BundleCatalogAssignment. If not using a custom type, specify BundleCatalogAssignment.</typeparam>
			[SentOn("POST", "v1/catalogs/bundleassignments")]
			public class SaveBundleAssignment<TConfigData, TBundleCatalogAssignment> : WebhookPayload<TBundleCatalogAssignment, object, object, TConfigData>
				where TBundleCatalogAssignment : BundleCatalogAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/bundleassignments/{bundleID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/bundleassignments/{bundleID}")]
			public class DeleteBundleAssignment : WebhookPayload<object, object, DeleteBundleAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/bundleassignments/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/bundleassignments/{bundleID}")]
			public class DeleteBundleAssignment<TConfigData> : WebhookPayload<object, object, DeleteBundleAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/bundleassignments/{bundleID}.</summary>
			public class DeleteBundleAssignmentRouteParams
			{
				public string CatalogID { get; set; }
				public string BundleID { get; set; }
			}
		}
		public static class Categories
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories")]
			public class Create : WebhookPayload<Category, Category, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCategory">Specific type of the Category. If not using a custom type, specify Category.</typeparam>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories")]
			public class Create<TConfigData, TCategory> : WebhookPayload<TCategory, TCategory, CreateRouteParams, TConfigData>
				where TCategory : Category
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories.</summary>
			public class CreateRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			[SentOn("PUT", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Save : WebhookPayload<Category, Category, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCategory">Specific type of the Category. If not using a custom type, specify Category.</typeparam>
			[SentOn("PUT", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Save<TConfigData, TCategory> : WebhookPayload<TCategory, TCategory, SaveRouteParams, TConfigData>
				where TCategory : Category
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			public class SaveRouteParams
			{
				public string CatalogID { get; set; }
				public string CategoryID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			public class DeleteRouteParams
			{
				public string CatalogID { get; set; }
				public string CategoryID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			[SentOn("PATCH", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Patch : WebhookPayload<Category, Category, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCategory">Specific type of the Category. If not using a custom type, specify Category.</typeparam>
			[SentOn("PATCH", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Patch<TConfigData, TCategory> : WebhookPayload<TCategory, TCategory, PatchRouteParams, TConfigData>
				where TCategory : Category
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			public class PatchRouteParams
			{
				public string CatalogID { get; set; }
				public string CategoryID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/assignments.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string CatalogID { get; set; }
				public string CategoryID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/assignments.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/assignments")]
			public class SaveAssignment : WebhookPayload<CategoryAssignment, object, SaveAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCategoryAssignment">Specific type of the CategoryAssignment. If not using a custom type, specify CategoryAssignment.</typeparam>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/assignments")]
			public class SaveAssignment<TConfigData, TCategoryAssignment> : WebhookPayload<TCategoryAssignment, object, SaveAssignmentRouteParams, TConfigData>
				where TCategoryAssignment : CategoryAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/assignments.</summary>
			public class SaveAssignmentRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/productassignments.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/productassignments")]
			public class SaveProductAssignment : WebhookPayload<CategoryProductAssignment, object, SaveProductAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/productassignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCategoryProductAssignment">Specific type of the CategoryProductAssignment. If not using a custom type, specify CategoryProductAssignment.</typeparam>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/productassignments")]
			public class SaveProductAssignment<TConfigData, TCategoryProductAssignment> : WebhookPayload<TCategoryProductAssignment, object, SaveProductAssignmentRouteParams, TConfigData>
				where TCategoryProductAssignment : CategoryProductAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/productassignments.</summary>
			public class SaveProductAssignmentRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}.</summary>
			public class DeleteProductAssignmentRouteParams
			{
				public string CatalogID { get; set; }
				public string CategoryID { get; set; }
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/bundleassignments.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/bundleassignments")]
			public class SaveBundleAssignment : WebhookPayload<CategoryBundleAssignment, object, SaveBundleAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/bundleassignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCategoryBundleAssignment">Specific type of the CategoryBundleAssignment. If not using a custom type, specify CategoryBundleAssignment.</typeparam>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/bundleassignments")]
			public class SaveBundleAssignment<TConfigData, TCategoryBundleAssignment> : WebhookPayload<TCategoryBundleAssignment, object, SaveBundleAssignmentRouteParams, TConfigData>
				where TCategoryBundleAssignment : CategoryBundleAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/bundleassignments.</summary>
			public class SaveBundleAssignmentRouteParams
			{
				public string CatalogID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/bundleassignments/{bundleID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/bundleassignments/{bundleID}")]
			public class DeleteBundleAssignment : WebhookPayload<object, object, DeleteBundleAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/bundleassignments/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/bundleassignments/{bundleID}")]
			public class DeleteBundleAssignment<TConfigData> : WebhookPayload<object, object, DeleteBundleAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}/bundleassignments/{bundleID}.</summary>
			public class DeleteBundleAssignmentRouteParams
			{
				public string CatalogID { get; set; }
				public string CategoryID { get; set; }
				public string BundleID { get; set; }
			}
		}
		public static class Certs
		{
		}
		public static class CostCenters
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters")]
			public class Create : WebhookPayload<CostCenter, CostCenter, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCostCenter">Specific type of the CostCenter. If not using a custom type, specify CostCenter.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters")]
			public class Create<TConfigData, TCostCenter> : WebhookPayload<TCostCenter, TCostCenter, CreateRouteParams, TConfigData>
				where TCostCenter : CostCenter
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Save : WebhookPayload<CostCenter, CostCenter, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCostCenter">Specific type of the CostCenter. If not using a custom type, specify CostCenter.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Save<TConfigData, TCostCenter> : WebhookPayload<TCostCenter, TCostCenter, SaveRouteParams, TConfigData>
				where TCostCenter : CostCenter
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string CostCenterID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string CostCenterID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Patch : WebhookPayload<CostCenter, CostCenter, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCostCenter">Specific type of the CostCenter. If not using a custom type, specify CostCenter.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Patch<TConfigData, TCostCenter> : WebhookPayload<TCostCenter, TCostCenter, PatchRouteParams, TConfigData>
				where TCostCenter : CostCenter
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string CostCenterID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string BuyerID { get; set; }
				public string CostCenterID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters/assignments")]
			public class SaveAssignment : WebhookPayload<CostCenterAssignment, object, SaveAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCostCenterAssignment">Specific type of the CostCenterAssignment. If not using a custom type, specify CostCenterAssignment.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters/assignments")]
			public class SaveAssignment<TConfigData, TCostCenterAssignment> : WebhookPayload<TCostCenterAssignment, object, SaveAssignmentRouteParams, TConfigData>
				where TCostCenterAssignment : CostCenterAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/assignments.</summary>
			public class SaveAssignmentRouteParams
			{
				public string BuyerID { get; set; }
			}
		}
		public static class CreditCards
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards")]
			public class Create : WebhookPayload<CreditCard, CreditCard, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCreditCard">Specific type of the CreditCard. If not using a custom type, specify CreditCard.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards")]
			public class Create<TConfigData, TCreditCard> : WebhookPayload<TCreditCard, TCreditCard, CreateRouteParams, TConfigData>
				where TCreditCard : CreditCard
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Save : WebhookPayload<CreditCard, CreditCard, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCreditCard">Specific type of the CreditCard. If not using a custom type, specify CreditCard.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Save<TConfigData, TCreditCard> : WebhookPayload<TCreditCard, TCreditCard, SaveRouteParams, TConfigData>
				where TCreditCard : CreditCard
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string CreditCardID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string CreditCardID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Patch : WebhookPayload<CreditCard, CreditCard, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCreditCard">Specific type of the CreditCard. If not using a custom type, specify CreditCard.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Patch<TConfigData, TCreditCard> : WebhookPayload<TCreditCard, TCreditCard, PatchRouteParams, TConfigData>
				where TCreditCard : CreditCard
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string CreditCardID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards/assignments")]
			public class SaveAssignment : WebhookPayload<CreditCardAssignment, object, SaveAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TCreditCardAssignment">Specific type of the CreditCardAssignment. If not using a custom type, specify CreditCardAssignment.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards/assignments")]
			public class SaveAssignment<TConfigData, TCreditCardAssignment> : WebhookPayload<TCreditCardAssignment, object, SaveAssignmentRouteParams, TConfigData>
				where TCreditCardAssignment : CreditCardAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/assignments.</summary>
			public class SaveAssignmentRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string BuyerID { get; set; }
				public string CreditCardID { get; set; }
			}
		}
		public static class DeliveryConfigurations
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrations/deliveryconfig.</summary>
			[SentOn("POST", "v1/integrations/deliveryconfig")]
			public class Create : WebhookPayload<DeliveryConfig, DeliveryConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrations/deliveryconfig.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TDeliveryConfig">Specific type of the DeliveryConfig. If not using a custom type, specify DeliveryConfig.</typeparam>
			[SentOn("POST", "v1/integrations/deliveryconfig")]
			public class Create<TConfigData, TDeliveryConfig> : WebhookPayload<TDeliveryConfig, TDeliveryConfig, object, TConfigData>
				where TDeliveryConfig : DeliveryConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			[SentOn("PUT", "v1/integrations/deliveryconfig/{deliveryConfigID}")]
			public class Save : WebhookPayload<DeliveryConfig, DeliveryConfig, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TDeliveryConfig">Specific type of the DeliveryConfig. If not using a custom type, specify DeliveryConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/deliveryconfig/{deliveryConfigID}")]
			public class Save<TConfigData, TDeliveryConfig> : WebhookPayload<TDeliveryConfig, TDeliveryConfig, SaveRouteParams, TConfigData>
				where TDeliveryConfig : DeliveryConfig
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			public class SaveRouteParams
			{
				public string DeliveryConfigID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			[SentOn("DELETE", "v1/integrations/deliveryconfig/{deliveryConfigID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/deliveryconfig/{deliveryConfigID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			public class DeleteRouteParams
			{
				public string DeliveryConfigID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			[SentOn("PATCH", "v1/integrations/deliveryconfig/{deliveryConfigID}")]
			public class Patch : WebhookPayload<DeliveryConfig, DeliveryConfig, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TDeliveryConfig">Specific type of the DeliveryConfig. If not using a custom type, specify DeliveryConfig.</typeparam>
			[SentOn("PATCH", "v1/integrations/deliveryconfig/{deliveryConfigID}")]
			public class Patch<TConfigData, TDeliveryConfig> : WebhookPayload<TDeliveryConfig, TDeliveryConfig, PatchRouteParams, TConfigData>
				where TDeliveryConfig : DeliveryConfig
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrations/deliveryconfig/{deliveryConfigID}.</summary>
			public class PatchRouteParams
			{
				public string DeliveryConfigID { get; set; }
			}
		}
		public static class EntitySyncs
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/categories.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/categories")]
			public class DeleteCategories : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/categories.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/categories")]
			public class DeleteCategories<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/categories.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/categories")]
			public class SaveCategories : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/categories.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/categories")]
			public class SaveCategories<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/suppliers.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/suppliers")]
			public class DeleteSuppliers : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/suppliers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/suppliers")]
			public class DeleteSuppliers<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/suppliers.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/suppliers")]
			public class SaveSuppliers : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/suppliers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/suppliers")]
			public class SaveSuppliers<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/buyers/users.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/buyers/users")]
			public class DeleteBuyerUsers : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/buyers/users.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/buyers/users")]
			public class DeleteBuyerUsers<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/buyers/users.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/buyers/users")]
			public class SaveBuyerUsers : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/buyers/users.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/buyers/users")]
			public class SaveBuyerUsers<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/suppliers/users.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/suppliers/users")]
			public class DeleteSupplierUsers : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/suppliers/users.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/suppliers/users")]
			public class DeleteSupplierUsers<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/suppliers/users.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/suppliers/users")]
			public class SaveSupplierUsers : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/suppliers/users.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/suppliers/users")]
			public class SaveSupplierUsers<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/adminusers.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/adminusers")]
			public class DeleteAdminUsers : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/adminusers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/adminusers")]
			public class DeleteAdminUsers<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/adminusers.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/adminusers")]
			public class SaveAdminUsers : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/adminusers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/adminusers")]
			public class SaveAdminUsers<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/buyers.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/buyers")]
			public class DeleteBuyers : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/buyers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/buyers")]
			public class DeleteBuyers<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/buyers.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/buyers")]
			public class SaveBuyers : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/buyers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/buyers")]
			public class SaveBuyers<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/buyers/usergroups.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/buyers/usergroups")]
			public class DeleteUserGroups : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/buyers/usergroups.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/buyers/usergroups")]
			public class DeleteUserGroups<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/buyers/usergroups.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/buyers/usergroups")]
			public class SaveUserGroups : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/buyers/usergroups.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/buyers/usergroups")]
			public class SaveUserGroups<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/products/inventoryrecords.</summary>
			[SentOn("DELETE", "v1/integrations/entitysync/products/inventoryrecords")]
			public class DeleteInventoryRecords : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/entitysync/products/inventoryrecords.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/entitysync/products/inventoryrecords")]
			public class DeleteInventoryRecords<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/products/inventoryrecords.</summary>
			[SentOn("PUT", "v1/integrations/entitysync/products/inventoryrecords")]
			public class SaveInventoryRecords : WebhookPayload<EntitySyncConfig, EntitySyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/entitysync/products/inventoryrecords.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TEntitySyncConfig">Specific type of the EntitySyncConfig. If not using a custom type, specify EntitySyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/entitysync/products/inventoryrecords")]
			public class SaveInventoryRecords<TConfigData, TEntitySyncConfig> : WebhookPayload<TEntitySyncConfig, TEntitySyncConfig, object, TConfigData>
				where TEntitySyncConfig : EntitySyncConfig
			{ }
		}
		public static class ErrorConfigs
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/ErrorConfig.</summary>
			[SentOn("DELETE", "v1/integrations/ErrorConfig")]
			public class Delete : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/ErrorConfig.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/ErrorConfig")]
			public class Delete<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/ErrorConfig.</summary>
			[SentOn("PUT", "v1/integrations/ErrorConfig")]
			public class Save : WebhookPayload<ErrorConfig, ErrorConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/ErrorConfig.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TErrorConfig">Specific type of the ErrorConfig. If not using a custom type, specify ErrorConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/ErrorConfig")]
			public class Save<TConfigData, TErrorConfig> : WebhookPayload<TErrorConfig, TErrorConfig, object, TConfigData>
				where TErrorConfig : ErrorConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/ErrorConfig.</summary>
			[SentOn("PATCH", "v1/integrations/ErrorConfig")]
			public class Patch : WebhookPayload<ErrorConfig, ErrorConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/ErrorConfig.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TErrorConfig">Specific type of the ErrorConfig. If not using a custom type, specify ErrorConfig.</typeparam>
			[SentOn("PATCH", "v1/integrations/ErrorConfig")]
			public class Patch<TConfigData, TErrorConfig> : WebhookPayload<TErrorConfig, TErrorConfig, object, TConfigData>
				where TErrorConfig : ErrorConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrations/ErrorConfig/validate.</summary>
			[SentOn("POST", "v1/integrations/ErrorConfig/validate")]
			public class Validate : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrations/ErrorConfig/validate.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/integrations/ErrorConfig/validate")]
			public class Validate<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
		}
		public static class ForgottenCredentials
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/password/reset.</summary>
			[SentOn("POST", "v1/password/reset")]
			public class SendVerificationCode : WebhookPayload<PasswordResetRequest, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/password/reset.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPasswordResetRequest">Specific type of the PasswordResetRequest. If not using a custom type, specify PasswordResetRequest.</typeparam>
			[SentOn("POST", "v1/password/reset")]
			public class SendVerificationCode<TConfigData, TPasswordResetRequest> : WebhookPayload<TPasswordResetRequest, object, object, TConfigData>
				where TPasswordResetRequest : PasswordResetRequest
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/password/reset/{verificationCode}.</summary>
			[SentOn("PUT", "v1/password/reset/{verificationCode}")]
			public class ResetPasswordByVerificationCode : WebhookPayload<PasswordReset, object, ResetPasswordByVerificationCodeRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/password/reset/{verificationCode}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPasswordReset">Specific type of the PasswordReset. If not using a custom type, specify PasswordReset.</typeparam>
			[SentOn("PUT", "v1/password/reset/{verificationCode}")]
			public class ResetPasswordByVerificationCode<TConfigData, TPasswordReset> : WebhookPayload<TPasswordReset, object, ResetPasswordByVerificationCodeRouteParams, TConfigData>
				where TPasswordReset : PasswordReset
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/password/reset/{verificationCode}.</summary>
			public class ResetPasswordByVerificationCodeRouteParams
			{
				public string VerificationCode { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/username/retrieve.</summary>
			[SentOn("POST", "v1/username/retrieve")]
			public class RetrieveUsername : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/username/retrieve.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/username/retrieve")]
			public class RetrieveUsername<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
		}
		public static class ImpersonationConfigs
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/impersonationconfig.</summary>
			[SentOn("POST", "v1/impersonationconfig")]
			public class Create : WebhookPayload<ImpersonationConfig, ImpersonationConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/impersonationconfig.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TImpersonationConfig">Specific type of the ImpersonationConfig. If not using a custom type, specify ImpersonationConfig.</typeparam>
			[SentOn("POST", "v1/impersonationconfig")]
			public class Create<TConfigData, TImpersonationConfig> : WebhookPayload<TImpersonationConfig, TImpersonationConfig, object, TConfigData>
				where TImpersonationConfig : ImpersonationConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/impersonationconfig/{impersonationConfigID}.</summary>
			[SentOn("DELETE", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/impersonationconfig/{impersonationConfigID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/impersonationconfig/{impersonationConfigID}.</summary>
			public class DeleteRouteParams
			{
				public string ImpersonationConfigID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/impersonationconfig/{impersonationConfigID}.</summary>
			[SentOn("PUT", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Save : WebhookPayload<ImpersonationConfig, ImpersonationConfig, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/impersonationconfig/{impersonationConfigID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TImpersonationConfig">Specific type of the ImpersonationConfig. If not using a custom type, specify ImpersonationConfig.</typeparam>
			[SentOn("PUT", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Save<TConfigData, TImpersonationConfig> : WebhookPayload<TImpersonationConfig, TImpersonationConfig, SaveRouteParams, TConfigData>
				where TImpersonationConfig : ImpersonationConfig
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/impersonationconfig/{impersonationConfigID}.</summary>
			public class SaveRouteParams
			{
				public string ImpersonationConfigID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/impersonationconfig/{impersonationConfigID}.</summary>
			[SentOn("PATCH", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Patch : WebhookPayload<ImpersonationConfig, ImpersonationConfig, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/impersonationconfig/{impersonationConfigID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TImpersonationConfig">Specific type of the ImpersonationConfig. If not using a custom type, specify ImpersonationConfig.</typeparam>
			[SentOn("PATCH", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Patch<TConfigData, TImpersonationConfig> : WebhookPayload<TImpersonationConfig, TImpersonationConfig, PatchRouteParams, TConfigData>
				where TImpersonationConfig : ImpersonationConfig
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/impersonationconfig/{impersonationConfigID}.</summary>
			public class PatchRouteParams
			{
				public string ImpersonationConfigID { get; set; }
			}
		}
		public static class Incrementors
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/incrementors.</summary>
			[SentOn("POST", "v1/incrementors")]
			public class Create : WebhookPayload<Incrementor, Incrementor, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/incrementors.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TIncrementor">Specific type of the Incrementor. If not using a custom type, specify Incrementor.</typeparam>
			[SentOn("POST", "v1/incrementors")]
			public class Create<TConfigData, TIncrementor> : WebhookPayload<TIncrementor, TIncrementor, object, TConfigData>
				where TIncrementor : Incrementor
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/incrementors/{incrementorID}.</summary>
			[SentOn("PUT", "v1/incrementors/{incrementorID}")]
			public class Save : WebhookPayload<Incrementor, Incrementor, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/incrementors/{incrementorID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TIncrementor">Specific type of the Incrementor. If not using a custom type, specify Incrementor.</typeparam>
			[SentOn("PUT", "v1/incrementors/{incrementorID}")]
			public class Save<TConfigData, TIncrementor> : WebhookPayload<TIncrementor, TIncrementor, SaveRouteParams, TConfigData>
				where TIncrementor : Incrementor
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/incrementors/{incrementorID}.</summary>
			public class SaveRouteParams
			{
				public string IncrementorID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/incrementors/{incrementorID}.</summary>
			[SentOn("DELETE", "v1/incrementors/{incrementorID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/incrementors/{incrementorID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/incrementors/{incrementorID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/incrementors/{incrementorID}.</summary>
			public class DeleteRouteParams
			{
				public string IncrementorID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/incrementors/{incrementorID}.</summary>
			[SentOn("PATCH", "v1/incrementors/{incrementorID}")]
			public class Patch : WebhookPayload<Incrementor, Incrementor, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/incrementors/{incrementorID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TIncrementor">Specific type of the Incrementor. If not using a custom type, specify Incrementor.</typeparam>
			[SentOn("PATCH", "v1/incrementors/{incrementorID}")]
			public class Patch<TConfigData, TIncrementor> : WebhookPayload<TIncrementor, TIncrementor, PatchRouteParams, TConfigData>
				where TIncrementor : Incrementor
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/incrementors/{incrementorID}.</summary>
			public class PatchRouteParams
			{
				public string IncrementorID { get; set; }
			}
		}
		public static class IntegrationEvents
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrationEvents.</summary>
			[SentOn("POST", "v1/integrationEvents")]
			public class Create : WebhookPayload<IntegrationEvent, IntegrationEvent, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrationEvents.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TIntegrationEvent">Specific type of the IntegrationEvent. If not using a custom type, specify IntegrationEvent.</typeparam>
			[SentOn("POST", "v1/integrationEvents")]
			public class Create<TConfigData, TIntegrationEvent> : WebhookPayload<TIntegrationEvent, TIntegrationEvent, object, TConfigData>
				where TIntegrationEvent : IntegrationEvent
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrationEvents/{integrationEventID}.</summary>
			[SentOn("PUT", "v1/integrationEvents/{integrationEventID}")]
			public class Save : WebhookPayload<IntegrationEvent, IntegrationEvent, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrationEvents/{integrationEventID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TIntegrationEvent">Specific type of the IntegrationEvent. If not using a custom type, specify IntegrationEvent.</typeparam>
			[SentOn("PUT", "v1/integrationEvents/{integrationEventID}")]
			public class Save<TConfigData, TIntegrationEvent> : WebhookPayload<TIntegrationEvent, TIntegrationEvent, SaveRouteParams, TConfigData>
				where TIntegrationEvent : IntegrationEvent
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrationEvents/{integrationEventID}.</summary>
			public class SaveRouteParams
			{
				public string IntegrationEventID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrationEvents/{integrationEventID}.</summary>
			[SentOn("DELETE", "v1/integrationEvents/{integrationEventID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrationEvents/{integrationEventID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrationEvents/{integrationEventID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrationEvents/{integrationEventID}.</summary>
			public class DeleteRouteParams
			{
				public string IntegrationEventID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrationEvents/{integrationEventID}.</summary>
			[SentOn("PATCH", "v1/integrationEvents/{integrationEventID}")]
			public class Patch : WebhookPayload<IntegrationEvent, IntegrationEvent, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrationEvents/{integrationEventID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TIntegrationEvent">Specific type of the IntegrationEvent. If not using a custom type, specify IntegrationEvent.</typeparam>
			[SentOn("PATCH", "v1/integrationEvents/{integrationEventID}")]
			public class Patch<TConfigData, TIntegrationEvent> : WebhookPayload<TIntegrationEvent, TIntegrationEvent, PatchRouteParams, TConfigData>
				where TIntegrationEvent : IntegrationEvent
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrationEvents/{integrationEventID}.</summary>
			public class PatchRouteParams
			{
				public string IntegrationEventID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/estimateshipping.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/estimateshipping")]
			public class EstimateShipping : WebhookPayload<object, OrderWorksheet, EstimateShippingRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/estimateshipping.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderWorksheet">Specific type of the OrderWorksheet. If not using a custom type, specify OrderWorksheet.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/estimateshipping")]
			public class EstimateShipping<TConfigData, TOrderWorksheet> : WebhookPayload<object, TOrderWorksheet, EstimateShippingRouteParams, TConfigData>
				where TOrderWorksheet : OrderWorksheet
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/estimateshipping.</summary>
			public class EstimateShippingRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/shipmethods.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/shipmethods")]
			public class SelectShipmethods : WebhookPayload<OrderShipMethodSelection, OrderWorksheet, SelectShipmethodsRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/shipmethods.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderShipMethodSelection">Specific type of the OrderShipMethodSelection. If not using a custom type, specify OrderShipMethodSelection.</typeparam>
			/// <typeparam name="TOrderWorksheet">Specific type of the OrderWorksheet. If not using a custom type, specify OrderWorksheet.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/shipmethods")]
			public class SelectShipmethods<TConfigData, TOrderShipMethodSelection, TOrderWorksheet> : WebhookPayload<TOrderShipMethodSelection, TOrderWorksheet, SelectShipmethodsRouteParams, TConfigData>
				where TOrderShipMethodSelection : OrderShipMethodSelection
				where TOrderWorksheet : OrderWorksheet
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/shipmethods.</summary>
			public class SelectShipmethodsRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/calculate.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/calculate")]
			public class Calculate : WebhookPayload<object, OrderWorksheet, CalculateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/calculate.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderWorksheet">Specific type of the OrderWorksheet. If not using a custom type, specify OrderWorksheet.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/calculate")]
			public class Calculate<TConfigData, TOrderWorksheet> : WebhookPayload<object, TOrderWorksheet, CalculateRouteParams, TConfigData>
				where TOrderWorksheet : OrderWorksheet
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/calculate.</summary>
			public class CalculateRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
		}
		public static class InventoryIntegrations
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/inventory.</summary>
			[SentOn("DELETE", "v1/integrations/inventory")]
			public class Delete : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/inventory.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/inventory")]
			public class Delete<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/inventory.</summary>
			[SentOn("PUT", "v1/integrations/inventory")]
			public class Save : WebhookPayload<InventoryIntegration, InventoryIntegration, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/inventory.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryIntegration">Specific type of the InventoryIntegration. If not using a custom type, specify InventoryIntegration.</typeparam>
			[SentOn("PUT", "v1/integrations/inventory")]
			public class Save<TConfigData, TInventoryIntegration> : WebhookPayload<TInventoryIntegration, TInventoryIntegration, object, TConfigData>
				where TInventoryIntegration : InventoryIntegration
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/inventory.</summary>
			[SentOn("PATCH", "v1/integrations/inventory")]
			public class Patch : WebhookPayload<InventoryIntegration, InventoryIntegration, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/inventory.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryIntegration">Specific type of the InventoryIntegration. If not using a custom type, specify InventoryIntegration.</typeparam>
			[SentOn("PATCH", "v1/integrations/inventory")]
			public class Patch<TConfigData, TInventoryIntegration> : WebhookPayload<TInventoryIntegration, TInventoryIntegration, object, TConfigData>
				where TInventoryIntegration : InventoryIntegration
			{ }
		}
		public static class InventoryRecords
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/inventoryrecords.</summary>
			[SentOn("POST", "v1/products/{productID}/inventoryrecords")]
			public class Create : WebhookPayload<InventoryRecord, InventoryRecord, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/inventoryrecords.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecord">Specific type of the InventoryRecord. If not using a custom type, specify InventoryRecord.</typeparam>
			[SentOn("POST", "v1/products/{productID}/inventoryrecords")]
			public class Create<TConfigData, TInventoryRecord> : WebhookPayload<TInventoryRecord, TInventoryRecord, CreateRouteParams, TConfigData>
				where TInventoryRecord : InventoryRecord
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/inventoryrecords.</summary>
			public class CreateRouteParams
			{
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			public class DeleteRouteParams
			{
				public string ProductID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			[SentOn("PUT", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}")]
			public class Save : WebhookPayload<InventoryRecord, InventoryRecord, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecord">Specific type of the InventoryRecord. If not using a custom type, specify InventoryRecord.</typeparam>
			[SentOn("PUT", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}")]
			public class Save<TConfigData, TInventoryRecord> : WebhookPayload<TInventoryRecord, TInventoryRecord, SaveRouteParams, TConfigData>
				where TInventoryRecord : InventoryRecord
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			public class SaveRouteParams
			{
				public string ProductID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			[SentOn("PATCH", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}")]
			public class Patch : WebhookPayload<InventoryRecord, InventoryRecord, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecord">Specific type of the InventoryRecord. If not using a custom type, specify InventoryRecord.</typeparam>
			[SentOn("PATCH", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}")]
			public class Patch<TConfigData, TInventoryRecord> : WebhookPayload<TInventoryRecord, TInventoryRecord, PatchRouteParams, TConfigData>
				where TInventoryRecord : InventoryRecord
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/inventoryrecords/{inventoryRecordID}.</summary>
			public class PatchRouteParams
			{
				public string ProductID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/{variantID}/inventoryrecords.</summary>
			[SentOn("POST", "v1/products/{productID}/variants/{variantID}/inventoryrecords")]
			public class CreateVariant : WebhookPayload<InventoryRecord, InventoryRecord, CreateVariantRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/{variantID}/inventoryrecords.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecord">Specific type of the InventoryRecord. If not using a custom type, specify InventoryRecord.</typeparam>
			[SentOn("POST", "v1/products/{productID}/variants/{variantID}/inventoryrecords")]
			public class CreateVariant<TConfigData, TInventoryRecord> : WebhookPayload<TInventoryRecord, TInventoryRecord, CreateVariantRouteParams, TConfigData>
				where TInventoryRecord : InventoryRecord
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}/inventoryrecords.</summary>
			public class CreateVariantRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			[SentOn("PUT", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}")]
			public class SaveVariant : WebhookPayload<InventoryRecord, InventoryRecord, SaveVariantRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecord">Specific type of the InventoryRecord. If not using a custom type, specify InventoryRecord.</typeparam>
			[SentOn("PUT", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}")]
			public class SaveVariant<TConfigData, TInventoryRecord> : WebhookPayload<TInventoryRecord, TInventoryRecord, SaveVariantRouteParams, TConfigData>
				where TInventoryRecord : InventoryRecord
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			public class SaveVariantRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			[SentOn("PATCH", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}")]
			public class PatchVariant : WebhookPayload<InventoryRecord, InventoryRecord, PatchVariantRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecord">Specific type of the InventoryRecord. If not using a custom type, specify InventoryRecord.</typeparam>
			[SentOn("PATCH", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}")]
			public class PatchVariant<TConfigData, TInventoryRecord> : WebhookPayload<TInventoryRecord, TInventoryRecord, PatchVariantRouteParams, TConfigData>
				where TInventoryRecord : InventoryRecord
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			public class PatchVariantRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}")]
			public class DeleteVariant : WebhookPayload<object, object, DeleteVariantRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}")]
			public class DeleteVariant<TConfigData> : WebhookPayload<object, object, DeleteVariantRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}.</summary>
			public class DeleteVariantRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/inventoryrecords/assignments.</summary>
			[SentOn("POST", "v1/products/{productID}/inventoryrecords/assignments")]
			public class SaveAssignment : WebhookPayload<InventoryRecordAssignment, object, SaveAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/inventoryrecords/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecordAssignment">Specific type of the InventoryRecordAssignment. If not using a custom type, specify InventoryRecordAssignment.</typeparam>
			[SentOn("POST", "v1/products/{productID}/inventoryrecords/assignments")]
			public class SaveAssignment<TConfigData, TInventoryRecordAssignment> : WebhookPayload<TInventoryRecordAssignment, object, SaveAssignmentRouteParams, TConfigData>
				where TInventoryRecordAssignment : InventoryRecordAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/inventoryrecords/assignments.</summary>
			public class SaveAssignmentRouteParams
			{
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/inventoryrecords/{inventoryRecordID}/assignments.</summary>
			[SentOn("DELETE", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/inventoryrecords/{inventoryRecordID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}/inventoryrecords/{inventoryRecordID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/inventoryrecords/{inventoryRecordID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string ProductID { get; set; }
				public string InventoryRecordID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/{variantID}/inventoryrecords/assignments.</summary>
			[SentOn("POST", "v1/products/{productID}/variants/{variantID}/inventoryrecords/assignments")]
			public class SaveVariantAssignment : WebhookPayload<InventoryRecordAssignment, object, SaveVariantAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/{variantID}/inventoryrecords/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TInventoryRecordAssignment">Specific type of the InventoryRecordAssignment. If not using a custom type, specify InventoryRecordAssignment.</typeparam>
			[SentOn("POST", "v1/products/{productID}/variants/{variantID}/inventoryrecords/assignments")]
			public class SaveVariantAssignment<TConfigData, TInventoryRecordAssignment> : WebhookPayload<TInventoryRecordAssignment, object, SaveVariantAssignmentRouteParams, TConfigData>
				where TInventoryRecordAssignment : InventoryRecordAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}/inventoryrecords/assignments.</summary>
			public class SaveVariantAssignmentRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}/assignments.</summary>
			[SentOn("DELETE", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}/assignments")]
			public class DeleteVariantAssignment : WebhookPayload<object, object, DeleteVariantAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}/assignments")]
			public class DeleteVariantAssignment<TConfigData> : WebhookPayload<object, object, DeleteVariantAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}/inventoryrecords/{inventoryRecordID}/assignments.</summary>
			public class DeleteVariantAssignmentRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
				public string InventoryRecordID { get; set; }
			}
		}
		public static class LineItems
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/lineitems.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/lineitems")]
			public class Create : WebhookPayload<LineItem, LineItem, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/lineitems.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/lineitems")]
			public class Create<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, CreateRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems.</summary>
			public class CreateRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Save : WebhookPayload<LineItem, LineItem, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Save<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, SaveRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			public class SaveRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			public class DeleteRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Patch : WebhookPayload<LineItem, LineItem, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Patch<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, PatchRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			public class PatchRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class SetShippingAddress : WebhookPayload<Address, LineItem, SetShippingAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class SetShippingAddress<TConfigData, TAddress, TLineItem> : WebhookPayload<TAddress, TLineItem, SetShippingAddressRouteParams, TConfigData>
				where TAddress : Address
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			public class SetShippingAddressRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class PatchShippingAddress : WebhookPayload<Address, LineItem, PatchShippingAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class PatchShippingAddress<TConfigData, TAddress, TLineItem> : WebhookPayload<TAddress, TLineItem, PatchShippingAddressRouteParams, TConfigData>
				where TAddress : Address
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			public class PatchShippingAddressRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string LineItemID { get; set; }
			}
		}
		public static class Locales
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/locales.</summary>
			[SentOn("POST", "v1/locales")]
			public class Create : WebhookPayload<Locale, Locale, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/locales.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLocale">Specific type of the Locale. If not using a custom type, specify Locale.</typeparam>
			[SentOn("POST", "v1/locales")]
			public class Create<TConfigData, TLocale> : WebhookPayload<TLocale, TLocale, object, TConfigData>
				where TLocale : Locale
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/locales/{localeID}.</summary>
			[SentOn("PUT", "v1/locales/{localeID}")]
			public class Save : WebhookPayload<Locale, Locale, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/locales/{localeID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLocale">Specific type of the Locale. If not using a custom type, specify Locale.</typeparam>
			[SentOn("PUT", "v1/locales/{localeID}")]
			public class Save<TConfigData, TLocale> : WebhookPayload<TLocale, TLocale, SaveRouteParams, TConfigData>
				where TLocale : Locale
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/locales/{localeID}.</summary>
			public class SaveRouteParams
			{
				public string LocaleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/locales/{localeID}.</summary>
			[SentOn("DELETE", "v1/locales/{localeID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/locales/{localeID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/locales/{localeID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/locales/{localeID}.</summary>
			public class DeleteRouteParams
			{
				public string LocaleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/locales/{localeID}.</summary>
			[SentOn("PATCH", "v1/locales/{localeID}")]
			public class Patch : WebhookPayload<Locale, Locale, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/locales/{localeID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLocale">Specific type of the Locale. If not using a custom type, specify Locale.</typeparam>
			[SentOn("PATCH", "v1/locales/{localeID}")]
			public class Patch<TConfigData, TLocale> : WebhookPayload<TLocale, TLocale, PatchRouteParams, TConfigData>
				where TLocale : Locale
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/locales/{localeID}.</summary>
			public class PatchRouteParams
			{
				public string LocaleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/locales/assignments.</summary>
			[SentOn("POST", "v1/locales/assignments")]
			public class SaveAssignment : WebhookPayload<LocaleAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/locales/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLocaleAssignment">Specific type of the LocaleAssignment. If not using a custom type, specify LocaleAssignment.</typeparam>
			[SentOn("POST", "v1/locales/assignments")]
			public class SaveAssignment<TConfigData, TLocaleAssignment> : WebhookPayload<TLocaleAssignment, object, object, TConfigData>
				where TLocaleAssignment : LocaleAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/locales/{localeID}/assignments.</summary>
			[SentOn("DELETE", "v1/locales/{localeID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/locales/{localeID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/locales/{localeID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/locales/{localeID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string LocaleID { get; set; }
			}
		}
		public static class Me
		{
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me.</summary>
			[SentOn("PUT", "v1/me")]
			public class Save : WebhookPayload<MeUser, MeUser, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMeUser">Specific type of the MeUser. If not using a custom type, specify MeUser.</typeparam>
			[SentOn("PUT", "v1/me")]
			public class Save<TConfigData, TMeUser> : WebhookPayload<TMeUser, TMeUser, object, TConfigData>
				where TMeUser : MeUser
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me.</summary>
			[SentOn("PATCH", "v1/me")]
			public class Patch : WebhookPayload<MeUser, MeUser, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMeUser">Specific type of the MeUser. If not using a custom type, specify MeUser.</typeparam>
			[SentOn("PATCH", "v1/me")]
			public class Patch<TConfigData, TMeUser> : WebhookPayload<TMeUser, TMeUser, object, TConfigData>
				where TMeUser : MeUser
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/addresses.</summary>
			[SentOn("POST", "v1/me/addresses")]
			public class CreateAddress : WebhookPayload<BuyerAddress, BuyerAddress, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/addresses.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyerAddress">Specific type of the BuyerAddress. If not using a custom type, specify BuyerAddress.</typeparam>
			[SentOn("POST", "v1/me/addresses")]
			public class CreateAddress<TConfigData, TBuyerAddress> : WebhookPayload<TBuyerAddress, TBuyerAddress, object, TConfigData>
				where TBuyerAddress : BuyerAddress
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/me/addresses/{addressID}")]
			public class SaveAddress : WebhookPayload<BuyerAddress, BuyerAddress, SaveAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyerAddress">Specific type of the BuyerAddress. If not using a custom type, specify BuyerAddress.</typeparam>
			[SentOn("PUT", "v1/me/addresses/{addressID}")]
			public class SaveAddress<TConfigData, TBuyerAddress> : WebhookPayload<TBuyerAddress, TBuyerAddress, SaveAddressRouteParams, TConfigData>
				where TBuyerAddress : BuyerAddress
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/addresses/{addressID}.</summary>
			public class SaveAddressRouteParams
			{
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/me/addresses/{addressID}")]
			public class PatchAddress : WebhookPayload<BuyerAddress, object, PatchAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyerAddress">Specific type of the BuyerAddress. If not using a custom type, specify BuyerAddress.</typeparam>
			[SentOn("PATCH", "v1/me/addresses/{addressID}")]
			public class PatchAddress<TConfigData, TBuyerAddress> : WebhookPayload<TBuyerAddress, object, PatchAddressRouteParams, TConfigData>
				where TBuyerAddress : BuyerAddress
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/addresses/{addressID}.</summary>
			public class PatchAddressRouteParams
			{
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/me/addresses/{addressID}")]
			public class DeleteAddress : WebhookPayload<object, object, DeleteAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/addresses/{addressID}")]
			public class DeleteAddress<TConfigData> : WebhookPayload<object, object, DeleteAddressRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/addresses/{addressID}.</summary>
			public class DeleteAddressRouteParams
			{
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/creditcards.</summary>
			[SentOn("POST", "v1/me/creditcards")]
			public class CreateCreditCard : WebhookPayload<BuyerCreditCard, BuyerCreditCard, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/creditcards.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyerCreditCard">Specific type of the BuyerCreditCard. If not using a custom type, specify BuyerCreditCard.</typeparam>
			[SentOn("POST", "v1/me/creditcards")]
			public class CreateCreditCard<TConfigData, TBuyerCreditCard> : WebhookPayload<TBuyerCreditCard, TBuyerCreditCard, object, TConfigData>
				where TBuyerCreditCard : BuyerCreditCard
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/creditcards/{creditcardID}.</summary>
			[SentOn("PUT", "v1/me/creditcards/{creditcardID}")]
			public class SaveCreditCard : WebhookPayload<BuyerCreditCard, BuyerCreditCard, SaveCreditCardRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/creditcards/{creditcardID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyerCreditCard">Specific type of the BuyerCreditCard. If not using a custom type, specify BuyerCreditCard.</typeparam>
			[SentOn("PUT", "v1/me/creditcards/{creditcardID}")]
			public class SaveCreditCard<TConfigData, TBuyerCreditCard> : WebhookPayload<TBuyerCreditCard, TBuyerCreditCard, SaveCreditCardRouteParams, TConfigData>
				where TBuyerCreditCard : BuyerCreditCard
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/creditcards/{creditcardID}.</summary>
			public class SaveCreditCardRouteParams
			{
				public string CreditcardID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/creditcards/{creditcardID}.</summary>
			[SentOn("PATCH", "v1/me/creditcards/{creditcardID}")]
			public class PatchCreditCard : WebhookPayload<BuyerCreditCard, object, PatchCreditCardRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/creditcards/{creditcardID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBuyerCreditCard">Specific type of the BuyerCreditCard. If not using a custom type, specify BuyerCreditCard.</typeparam>
			[SentOn("PATCH", "v1/me/creditcards/{creditcardID}")]
			public class PatchCreditCard<TConfigData, TBuyerCreditCard> : WebhookPayload<TBuyerCreditCard, object, PatchCreditCardRouteParams, TConfigData>
				where TBuyerCreditCard : BuyerCreditCard
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/creditcards/{creditcardID}.</summary>
			public class PatchCreditCardRouteParams
			{
				public string CreditcardID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/creditcards/{creditcardID}.</summary>
			[SentOn("DELETE", "v1/me/creditcards/{creditcardID}")]
			public class DeleteCreditCard : WebhookPayload<object, object, DeleteCreditCardRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/creditcards/{creditcardID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/creditcards/{creditcardID}")]
			public class DeleteCreditCard<TConfigData> : WebhookPayload<object, object, DeleteCreditCardRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/creditcards/{creditcardID}.</summary>
			public class DeleteCreditCardRouteParams
			{
				public string CreditcardID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/orders.</summary>
			[SentOn("PUT", "v1/me/orders")]
			public class TransferAnonUserOrder : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/orders.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("PUT", "v1/me/orders")]
			public class TransferAnonUserOrder<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/password.</summary>
			[SentOn("POST", "v1/me/password")]
			public class ResetPasswordByToken : WebhookPayload<TokenPasswordReset, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/password.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TTokenPasswordReset">Specific type of the TokenPasswordReset. If not using a custom type, specify TokenPasswordReset.</typeparam>
			[SentOn("POST", "v1/me/password")]
			public class ResetPasswordByToken<TConfigData, TTokenPasswordReset> : WebhookPayload<TTokenPasswordReset, object, object, TConfigData>
				where TTokenPasswordReset : TokenPasswordReset
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/register.</summary>
			[SentOn("PUT", "v1/me/register")]
			public class Register : WebhookPayload<MeUser, AccessTokenBasic, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/register.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMeUser">Specific type of the MeUser. If not using a custom type, specify MeUser.</typeparam>
			/// <typeparam name="TAccessTokenBasic">Specific type of the AccessTokenBasic. If not using a custom type, specify AccessTokenBasic.</typeparam>
			[SentOn("PUT", "v1/me/register")]
			public class Register<TConfigData, TMeUser, TAccessTokenBasic> : WebhookPayload<TMeUser, TAccessTokenBasic, object, TConfigData>
				where TMeUser : MeUser
				where TAccessTokenBasic : AccessTokenBasic
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections.</summary>
			[SentOn("POST", "v1/me/productcollections")]
			public class CreateProductCollection : WebhookPayload<ProductCollection, ProductCollection, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCollection">Specific type of the ProductCollection. If not using a custom type, specify ProductCollection.</typeparam>
			[SentOn("POST", "v1/me/productcollections")]
			public class CreateProductCollection<TConfigData, TProductCollection> : WebhookPayload<TProductCollection, TProductCollection, object, TConfigData>
				where TProductCollection : ProductCollection
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/productcollections/{productCollectionID}.</summary>
			[SentOn("PATCH", "v1/me/productcollections/{productCollectionID}")]
			public class PatchProductCollection : WebhookPayload<ProductCollection, ProductCollection, PatchProductCollectionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/productcollections/{productCollectionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCollection">Specific type of the ProductCollection. If not using a custom type, specify ProductCollection.</typeparam>
			[SentOn("PATCH", "v1/me/productcollections/{productCollectionID}")]
			public class PatchProductCollection<TConfigData, TProductCollection> : WebhookPayload<TProductCollection, TProductCollection, PatchProductCollectionRouteParams, TConfigData>
				where TProductCollection : ProductCollection
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}.</summary>
			public class PatchProductCollectionRouteParams
			{
				public string ProductCollectionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/productcollections/{productCollectionID}.</summary>
			[SentOn("PUT", "v1/me/productcollections/{productCollectionID}")]
			public class SaveProductCollection : WebhookPayload<ProductCollection, ProductCollection, SaveProductCollectionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/productcollections/{productCollectionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCollection">Specific type of the ProductCollection. If not using a custom type, specify ProductCollection.</typeparam>
			[SentOn("PUT", "v1/me/productcollections/{productCollectionID}")]
			public class SaveProductCollection<TConfigData, TProductCollection> : WebhookPayload<TProductCollection, TProductCollection, SaveProductCollectionRouteParams, TConfigData>
				where TProductCollection : ProductCollection
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}.</summary>
			public class SaveProductCollectionRouteParams
			{
				public string ProductCollectionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/productcollections/{productCollectionID}.</summary>
			[SentOn("DELETE", "v1/me/productcollections/{productCollectionID}")]
			public class DeleteProductCollection : WebhookPayload<object, object, DeleteProductCollectionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/productcollections/{productCollectionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/productcollections/{productCollectionID}")]
			public class DeleteProductCollection<TConfigData> : WebhookPayload<object, object, DeleteProductCollectionRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}.</summary>
			public class DeleteProductCollectionRouteParams
			{
				public string ProductCollectionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/productcollections/{productCollectionID}/{productID}.</summary>
			[SentOn("PUT", "v1/me/productcollections/{productCollectionID}/{productID}")]
			public class CreateProductCollectionEntry : WebhookPayload<object, object, CreateProductCollectionEntryRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/productcollections/{productCollectionID}/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("PUT", "v1/me/productcollections/{productCollectionID}/{productID}")]
			public class CreateProductCollectionEntry<TConfigData> : WebhookPayload<object, object, CreateProductCollectionEntryRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/{productID}.</summary>
			public class CreateProductCollectionEntryRouteParams
			{
				public string ProductCollectionID { get; set; }
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/products.</summary>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/products")]
			public class SaveProductCollectionEntry : WebhookPayload<ProductCollectionEntry, object, SaveProductCollectionEntryRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/products.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCollectionEntry">Specific type of the ProductCollectionEntry. If not using a custom type, specify ProductCollectionEntry.</typeparam>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/products")]
			public class SaveProductCollectionEntry<TConfigData, TProductCollectionEntry> : WebhookPayload<TProductCollectionEntry, object, SaveProductCollectionEntryRouteParams, TConfigData>
				where TProductCollectionEntry : ProductCollectionEntry
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/products.</summary>
			public class SaveProductCollectionEntryRouteParams
			{
				public string ProductCollectionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/productcollections/{productCollectionID}/{productID}.</summary>
			[SentOn("DELETE", "v1/me/productcollections/{productCollectionID}/{productID}")]
			public class DeleteProductCollectionEntry : WebhookPayload<object, object, DeleteProductCollectionEntryRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/productcollections/{productCollectionID}/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/productcollections/{productCollectionID}/{productID}")]
			public class DeleteProductCollectionEntry<TConfigData> : WebhookPayload<object, object, DeleteProductCollectionEntryRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/{productID}.</summary>
			public class DeleteProductCollectionEntryRouteParams
			{
				public string ProductCollectionID { get; set; }
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/invitations.</summary>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/invitations")]
			public class CreateProductCollectionInvitation : WebhookPayload<ProductCollectionInvitation, ProductCollectionInvitation, CreateProductCollectionInvitationRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/invitations.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCollectionInvitation">Specific type of the ProductCollectionInvitation. If not using a custom type, specify ProductCollectionInvitation.</typeparam>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/invitations")]
			public class CreateProductCollectionInvitation<TConfigData, TProductCollectionInvitation> : WebhookPayload<TProductCollectionInvitation, TProductCollectionInvitation, CreateProductCollectionInvitationRouteParams, TConfigData>
				where TProductCollectionInvitation : ProductCollectionInvitation
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/invitations.</summary>
			public class CreateProductCollectionInvitationRouteParams
			{
				public string ProductCollectionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/productcollections/{productCollectionID}/invitations/{invitationID}.</summary>
			[SentOn("PATCH", "v1/me/productcollections/{productCollectionID}/invitations/{invitationID}")]
			public class PatchProductCollectionInvitation : WebhookPayload<ProductCollectionInvitation, ProductCollectionInvitation, PatchProductCollectionInvitationRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/productcollections/{productCollectionID}/invitations/{invitationID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductCollectionInvitation">Specific type of the ProductCollectionInvitation. If not using a custom type, specify ProductCollectionInvitation.</typeparam>
			[SentOn("PATCH", "v1/me/productcollections/{productCollectionID}/invitations/{invitationID}")]
			public class PatchProductCollectionInvitation<TConfigData, TProductCollectionInvitation> : WebhookPayload<TProductCollectionInvitation, TProductCollectionInvitation, PatchProductCollectionInvitationRouteParams, TConfigData>
				where TProductCollectionInvitation : ProductCollectionInvitation
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/invitations/{invitationID}.</summary>
			public class PatchProductCollectionInvitationRouteParams
			{
				public string ProductCollectionID { get; set; }
				public string InvitationID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/productcollections/{productCollectionID}/invitations/{invitationID}.</summary>
			[SentOn("DELETE", "v1/me/productcollections/{productCollectionID}/invitations/{invitationID}")]
			public class DeleteProductCollectionInvitation : WebhookPayload<object, object, DeleteProductCollectionInvitationRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/productcollections/{productCollectionID}/invitations/{invitationID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/productcollections/{productCollectionID}/invitations/{invitationID}")]
			public class DeleteProductCollectionInvitation<TConfigData> : WebhookPayload<object, object, DeleteProductCollectionInvitationRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/invitations/{invitationID}.</summary>
			public class DeleteProductCollectionInvitationRouteParams
			{
				public string ProductCollectionID { get; set; }
				public string InvitationID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/invitations/accept/{invitationID}.</summary>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/invitations/accept/{invitationID}")]
			public class AcceptProductCollectionInvitation : WebhookPayload<object, object, AcceptProductCollectionInvitationRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/invitations/accept/{invitationID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/invitations/accept/{invitationID}")]
			public class AcceptProductCollectionInvitation<TConfigData> : WebhookPayload<object, object, AcceptProductCollectionInvitationRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/invitations/accept/{invitationID}.</summary>
			public class AcceptProductCollectionInvitationRouteParams
			{
				public string ProductCollectionID { get; set; }
				public string InvitationID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/invitations/decline/{invitationID}.</summary>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/invitations/decline/{invitationID}")]
			public class DeclineProductCollectionInvitation : WebhookPayload<object, object, DeclineProductCollectionInvitationRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/productcollections/{productCollectionID}/invitations/decline/{invitationID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/me/productcollections/{productCollectionID}/invitations/decline/{invitationID}")]
			public class DeclineProductCollectionInvitation<TConfigData> : WebhookPayload<object, object, DeclineProductCollectionInvitationRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/productcollections/{productCollectionID}/invitations/decline/{invitationID}.</summary>
			public class DeclineProductCollectionInvitationRouteParams
			{
				public string ProductCollectionID { get; set; }
				public string InvitationID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/subscriptions.</summary>
			[SentOn("POST", "v1/me/subscriptions")]
			public class CreateSubscription : WebhookPayload<Subscription, Subscription, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/subscriptions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscription">Specific type of the Subscription. If not using a custom type, specify Subscription.</typeparam>
			[SentOn("POST", "v1/me/subscriptions")]
			public class CreateSubscription<TConfigData, TSubscription> : WebhookPayload<TSubscription, TSubscription, object, TConfigData>
				where TSubscription : Subscription
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/subscriptions/{subscriptionID}.</summary>
			[SentOn("PUT", "v1/me/subscriptions/{subscriptionID}")]
			public class SaveSubscription : WebhookPayload<Subscription, Subscription, SaveSubscriptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/subscriptions/{subscriptionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscription">Specific type of the Subscription. If not using a custom type, specify Subscription.</typeparam>
			[SentOn("PUT", "v1/me/subscriptions/{subscriptionID}")]
			public class SaveSubscription<TConfigData, TSubscription> : WebhookPayload<TSubscription, TSubscription, SaveSubscriptionRouteParams, TConfigData>
				where TSubscription : Subscription
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}.</summary>
			public class SaveSubscriptionRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/subscriptions/{subscriptionID}.</summary>
			[SentOn("PATCH", "v1/me/subscriptions/{subscriptionID}")]
			public class PatchSubscription : WebhookPayload<Subscription, Subscription, PatchSubscriptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/subscriptions/{subscriptionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscription">Specific type of the Subscription. If not using a custom type, specify Subscription.</typeparam>
			[SentOn("PATCH", "v1/me/subscriptions/{subscriptionID}")]
			public class PatchSubscription<TConfigData, TSubscription> : WebhookPayload<TSubscription, TSubscription, PatchSubscriptionRouteParams, TConfigData>
				where TSubscription : Subscription
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}.</summary>
			public class PatchSubscriptionRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/subscriptions/{subscriptionID}.</summary>
			[SentOn("DELETE", "v1/me/subscriptions/{subscriptionID}")]
			public class DeleteSubscription : WebhookPayload<object, object, DeleteSubscriptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/subscriptions/{subscriptionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/subscriptions/{subscriptionID}")]
			public class DeleteSubscription<TConfigData> : WebhookPayload<object, object, DeleteSubscriptionRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}.</summary>
			public class DeleteSubscriptionRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/subscriptions/{subscriptionID}/items.</summary>
			[SentOn("POST", "v1/me/subscriptions/{subscriptionID}/items")]
			public class CreateSubscriptionItem : WebhookPayload<LineItem, LineItem, CreateSubscriptionItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/subscriptions/{subscriptionID}/items.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/me/subscriptions/{subscriptionID}/items")]
			public class CreateSubscriptionItem<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, CreateSubscriptionItemRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}/items.</summary>
			public class CreateSubscriptionItemRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			[SentOn("PUT", "v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class SaveSubscriptionItem : WebhookPayload<LineItem, LineItem, SaveSubscriptionItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PUT", "v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class SaveSubscriptionItem<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, SaveSubscriptionItemRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			public class SaveSubscriptionItemRouteParams
			{
				public string SubscriptionID { get; set; }
				public string SubscriptionItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			[SentOn("PATCH", "v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class PatchSubscriptionItem : WebhookPayload<LineItem, LineItem, PatchSubscriptionItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PATCH", "v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class PatchSubscriptionItem<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, PatchSubscriptionItemRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			public class PatchSubscriptionItemRouteParams
			{
				public string SubscriptionID { get; set; }
				public string SubscriptionItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			[SentOn("DELETE", "v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class DeleteSubscriptionItem : WebhookPayload<object, object, DeleteSubscriptionItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class DeleteSubscriptionItem<TConfigData> : WebhookPayload<object, object, DeleteSubscriptionItemRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			public class DeleteSubscriptionItemRouteParams
			{
				public string SubscriptionID { get; set; }
				public string SubscriptionItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}.</summary>
			[SentOn("POST", "v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}")]
			public class CreateSubscriptionBundleItem : WebhookPayload<BundleItems, LineItem, CreateSubscriptionBundleItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TBundleItems">Specific type of the BundleItems. If not using a custom type, specify BundleItems.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}")]
			public class CreateSubscriptionBundleItem<TConfigData, TBundleItems, TLineItem> : WebhookPayload<TBundleItems, TLineItem, CreateSubscriptionBundleItemRouteParams, TConfigData>
				where TBundleItems : BundleItems
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}.</summary>
			public class CreateSubscriptionBundleItemRouteParams
			{
				public string SubscriptionID { get; set; }
				public string BundleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}/{bundleItemID}.</summary>
			[SentOn("DELETE", "v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}/{bundleItemID}")]
			public class DeleteSubscriptionBundleItem : WebhookPayload<object, object, DeleteSubscriptionBundleItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}/{bundleItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}/{bundleItemID}")]
			public class DeleteSubscriptionBundleItem<TConfigData> : WebhookPayload<object, object, DeleteSubscriptionBundleItemRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/me/subscriptions/{subscriptionID}/items/bundles/{bundleID}/{bundleItemID}.</summary>
			public class DeleteSubscriptionBundleItemRouteParams
			{
				public string SubscriptionID { get; set; }
				public string BundleID { get; set; }
				public string BundleItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/tokens.</summary>
			[SentOn("DELETE", "v1/me/tokens")]
			public class RevokeTokens : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/tokens.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/me/tokens")]
			public class RevokeTokens<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
		}
		public static class MessageSenders
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders.</summary>
			[SentOn("POST", "v1/messagesenders")]
			public class Create : WebhookPayload<MessageSender, MessageSender, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMessageSender">Specific type of the MessageSender. If not using a custom type, specify MessageSender.</typeparam>
			[SentOn("POST", "v1/messagesenders")]
			public class Create<TConfigData, TMessageSender> : WebhookPayload<TMessageSender, TMessageSender, object, TConfigData>
				where TMessageSender : MessageSender
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/messagesenders/{messageSenderID}.</summary>
			[SentOn("PUT", "v1/messagesenders/{messageSenderID}")]
			public class Save : WebhookPayload<MessageSender, MessageSender, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/messagesenders/{messageSenderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMessageSender">Specific type of the MessageSender. If not using a custom type, specify MessageSender.</typeparam>
			[SentOn("PUT", "v1/messagesenders/{messageSenderID}")]
			public class Save<TConfigData, TMessageSender> : WebhookPayload<TMessageSender, TMessageSender, SaveRouteParams, TConfigData>
				where TMessageSender : MessageSender
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}.</summary>
			public class SaveRouteParams
			{
				public string MessageSenderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}.</summary>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}.</summary>
			public class DeleteRouteParams
			{
				public string MessageSenderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/messagesenders/{messageSenderID}.</summary>
			[SentOn("PATCH", "v1/messagesenders/{messageSenderID}")]
			public class Patch : WebhookPayload<MessageSender, MessageSender, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/messagesenders/{messageSenderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMessageSender">Specific type of the MessageSender. If not using a custom type, specify MessageSender.</typeparam>
			[SentOn("PATCH", "v1/messagesenders/{messageSenderID}")]
			public class Patch<TConfigData, TMessageSender> : WebhookPayload<TMessageSender, TMessageSender, PatchRouteParams, TConfigData>
				where TMessageSender : MessageSender
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}.</summary>
			public class PatchRouteParams
			{
				public string MessageSenderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}/assignments.</summary>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string MessageSenderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/assignments.</summary>
			[SentOn("POST", "v1/messagesenders/assignments")]
			public class SaveAssignment : WebhookPayload<MessageSenderAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMessageSenderAssignment">Specific type of the MessageSenderAssignment. If not using a custom type, specify MessageSenderAssignment.</typeparam>
			[SentOn("POST", "v1/messagesenders/assignments")]
			public class SaveAssignment<TConfigData, TMessageSenderAssignment> : WebhookPayload<TMessageSenderAssignment, object, object, TConfigData>
				where TMessageSenderAssignment : MessageSenderAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/CCListenerAssignments.</summary>
			[SentOn("POST", "v1/messagesenders/CCListenerAssignments")]
			public class SaveCCListenerAssignment : WebhookPayload<MessageCCListenerAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/CCListenerAssignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TMessageCCListenerAssignment">Specific type of the MessageCCListenerAssignment. If not using a custom type, specify MessageCCListenerAssignment.</typeparam>
			[SentOn("POST", "v1/messagesenders/CCListenerAssignments")]
			public class SaveCCListenerAssignment<TConfigData, TMessageCCListenerAssignment> : WebhookPayload<TMessageCCListenerAssignment, object, object, TConfigData>
				where TMessageCCListenerAssignment : MessageCCListenerAssignment
			{ }
		}
		public static class OpenIdConnects
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/openidconnects.</summary>
			[SentOn("POST", "v1/openidconnects")]
			public class Create : WebhookPayload<OpenIdConnect, OpenIdConnect, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/openidconnects.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOpenIdConnect">Specific type of the OpenIdConnect. If not using a custom type, specify OpenIdConnect.</typeparam>
			[SentOn("POST", "v1/openidconnects")]
			public class Create<TConfigData, TOpenIdConnect> : WebhookPayload<TOpenIdConnect, TOpenIdConnect, object, TConfigData>
				where TOpenIdConnect : OpenIdConnect
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/openidconnects/{openidconnectID}.</summary>
			[SentOn("PUT", "v1/openidconnects/{openidconnectID}")]
			public class Save : WebhookPayload<OpenIdConnect, OpenIdConnect, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/openidconnects/{openidconnectID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOpenIdConnect">Specific type of the OpenIdConnect. If not using a custom type, specify OpenIdConnect.</typeparam>
			[SentOn("PUT", "v1/openidconnects/{openidconnectID}")]
			public class Save<TConfigData, TOpenIdConnect> : WebhookPayload<TOpenIdConnect, TOpenIdConnect, SaveRouteParams, TConfigData>
				where TOpenIdConnect : OpenIdConnect
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/openidconnects/{openidconnectID}.</summary>
			public class SaveRouteParams
			{
				public string OpenidconnectID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/openidconnects/{openidconnectID}.</summary>
			[SentOn("DELETE", "v1/openidconnects/{openidconnectID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/openidconnects/{openidconnectID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/openidconnects/{openidconnectID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/openidconnects/{openidconnectID}.</summary>
			public class DeleteRouteParams
			{
				public string OpenidconnectID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/openidconnects/{openidconnectID}.</summary>
			[SentOn("PATCH", "v1/openidconnects/{openidconnectID}")]
			public class Patch : WebhookPayload<OpenIdConnect, OpenIdConnect, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/openidconnects/{openidconnectID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOpenIdConnect">Specific type of the OpenIdConnect. If not using a custom type, specify OpenIdConnect.</typeparam>
			[SentOn("PATCH", "v1/openidconnects/{openidconnectID}")]
			public class Patch<TConfigData, TOpenIdConnect> : WebhookPayload<TOpenIdConnect, TOpenIdConnect, PatchRouteParams, TConfigData>
				where TOpenIdConnect : OpenIdConnect
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/openidconnects/{openidconnectID}.</summary>
			public class PatchRouteParams
			{
				public string OpenidconnectID { get; set; }
			}
		}
		public static class OrderReturns
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns.</summary>
			[SentOn("POST", "v1/orderreturns")]
			public class Create : WebhookPayload<OrderReturn, OrderReturn, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("POST", "v1/orderreturns")]
			public class Create<TConfigData, TOrderReturn> : WebhookPayload<TOrderReturn, TOrderReturn, object, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orderreturns/{returnID}.</summary>
			[SentOn("PUT", "v1/orderreturns/{returnID}")]
			public class Save : WebhookPayload<OrderReturn, OrderReturn, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orderreturns/{returnID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("PUT", "v1/orderreturns/{returnID}")]
			public class Save<TConfigData, TOrderReturn> : WebhookPayload<TOrderReturn, TOrderReturn, SaveRouteParams, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}.</summary>
			public class SaveRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orderreturns/{returnID}.</summary>
			[SentOn("DELETE", "v1/orderreturns/{returnID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orderreturns/{returnID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/orderreturns/{returnID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}.</summary>
			public class DeleteRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orderreturns/{returnID}.</summary>
			[SentOn("PATCH", "v1/orderreturns/{returnID}")]
			public class Patch : WebhookPayload<OrderReturn, OrderReturn, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orderreturns/{returnID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("PATCH", "v1/orderreturns/{returnID}")]
			public class Patch<TConfigData, TOrderReturn> : WebhookPayload<TOrderReturn, TOrderReturn, PatchRouteParams, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}.</summary>
			public class PatchRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orderreturns/{returnID}/items/{lineItemID}.</summary>
			[SentOn("DELETE", "v1/orderreturns/{returnID}/items/{lineItemID}")]
			public class DeleteItem : WebhookPayload<object, OrderReturn, DeleteItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orderreturns/{returnID}/items/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("DELETE", "v1/orderreturns/{returnID}/items/{lineItemID}")]
			public class DeleteItem<TConfigData, TOrderReturn> : WebhookPayload<object, TOrderReturn, DeleteItemRouteParams, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}/items/{lineItemID}.</summary>
			public class DeleteItemRouteParams
			{
				public string ReturnID { get; set; }
				public string LineItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/cancel.</summary>
			[SentOn("POST", "v1/orderreturns/{returnID}/cancel")]
			public class Cancel : WebhookPayload<object, OrderReturn, CancelRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/cancel.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("POST", "v1/orderreturns/{returnID}/cancel")]
			public class Cancel<TConfigData, TOrderReturn> : WebhookPayload<object, TOrderReturn, CancelRouteParams, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}/cancel.</summary>
			public class CancelRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/complete.</summary>
			[SentOn("POST", "v1/orderreturns/{returnID}/complete")]
			public class Complete : WebhookPayload<object, OrderReturn, CompleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/complete.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("POST", "v1/orderreturns/{returnID}/complete")]
			public class Complete<TConfigData, TOrderReturn> : WebhookPayload<object, TOrderReturn, CompleteRouteParams, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}/complete.</summary>
			public class CompleteRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/submit.</summary>
			[SentOn("POST", "v1/orderreturns/{returnID}/submit")]
			public class Submit : WebhookPayload<object, OrderReturn, SubmitRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/submit.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("POST", "v1/orderreturns/{returnID}/submit")]
			public class Submit<TConfigData, TOrderReturn> : WebhookPayload<object, TOrderReturn, SubmitRouteParams, TConfigData>
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}/submit.</summary>
			public class SubmitRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/approve.</summary>
			[SentOn("POST", "v1/orderreturns/{returnID}/approve")]
			public class Approve : WebhookPayload<ApprovalInfo, OrderReturn, ApproveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/approve.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApprovalInfo">Specific type of the ApprovalInfo. If not using a custom type, specify ApprovalInfo.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("POST", "v1/orderreturns/{returnID}/approve")]
			public class Approve<TConfigData, TApprovalInfo, TOrderReturn> : WebhookPayload<TApprovalInfo, TOrderReturn, ApproveRouteParams, TConfigData>
				where TApprovalInfo : ApprovalInfo
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}/approve.</summary>
			public class ApproveRouteParams
			{
				public string ReturnID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/decline.</summary>
			[SentOn("POST", "v1/orderreturns/{returnID}/decline")]
			public class Decline : WebhookPayload<ApprovalInfo, OrderReturn, DeclineRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orderreturns/{returnID}/decline.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TApprovalInfo">Specific type of the ApprovalInfo. If not using a custom type, specify ApprovalInfo.</typeparam>
			/// <typeparam name="TOrderReturn">Specific type of the OrderReturn. If not using a custom type, specify OrderReturn.</typeparam>
			[SentOn("POST", "v1/orderreturns/{returnID}/decline")]
			public class Decline<TConfigData, TApprovalInfo, TOrderReturn> : WebhookPayload<TApprovalInfo, TOrderReturn, DeclineRouteParams, TConfigData>
				where TApprovalInfo : ApprovalInfo
				where TOrderReturn : OrderReturn
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orderreturns/{returnID}/decline.</summary>
			public class DeclineRouteParams
			{
				public string ReturnID { get; set; }
			}
		}
		public static class Orders
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}.</summary>
			[SentOn("POST", "v1/orders/{direction}")]
			public class Create : WebhookPayload<Order, Order, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}")]
			public class Create<TConfigData, TOrder> : WebhookPayload<TOrder, TOrder, CreateRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}.</summary>
			public class CreateRouteParams
			{
				public OrderDirection Direction { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}")]
			public class Save : WebhookPayload<Order, Order, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}")]
			public class Save<TConfigData, TOrder> : WebhookPayload<TOrder, TOrder, SaveRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}.</summary>
			public class SaveRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}.</summary>
			public class DeleteRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}")]
			public class Patch : WebhookPayload<Order, Order, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}")]
			public class Patch<TConfigData, TOrder> : WebhookPayload<TOrder, TOrder, PatchRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}.</summary>
			public class PatchRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/submit.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/submit")]
			public class Submit : WebhookPayload<object, Order, SubmitRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/submit.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/submit")]
			public class Submit<TConfigData, TOrder> : WebhookPayload<object, TOrder, SubmitRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/submit.</summary>
			public class SubmitRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/approve.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/approve")]
			public class Approve : WebhookPayload<OrderApprovalInfo, Order, ApproveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/approve.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderApprovalInfo">Specific type of the OrderApprovalInfo. If not using a custom type, specify OrderApprovalInfo.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/approve")]
			public class Approve<TConfigData, TOrderApprovalInfo, TOrder> : WebhookPayload<TOrderApprovalInfo, TOrder, ApproveRouteParams, TConfigData>
				where TOrderApprovalInfo : OrderApprovalInfo
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/approve.</summary>
			public class ApproveRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/decline.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/decline")]
			public class Decline : WebhookPayload<OrderApprovalInfo, Order, DeclineRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/decline.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderApprovalInfo">Specific type of the OrderApprovalInfo. If not using a custom type, specify OrderApprovalInfo.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/decline")]
			public class Decline<TConfigData, TOrderApprovalInfo, TOrder> : WebhookPayload<TOrderApprovalInfo, TOrder, DeclineRouteParams, TConfigData>
				where TOrderApprovalInfo : OrderApprovalInfo
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/decline.</summary>
			public class DeclineRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/cancel.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/cancel")]
			public class Cancel : WebhookPayload<object, Order, CancelRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/cancel.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/cancel")]
			public class Cancel<TConfigData, TOrder> : WebhookPayload<object, TOrder, CancelRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/cancel.</summary>
			public class CancelRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/split.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/split")]
			public class Split : WebhookPayload<object, OrderSplitResult, SplitRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/split.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderSplitResult">Specific type of the OrderSplitResult. If not using a custom type, specify OrderSplitResult.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/split")]
			public class Split<TConfigData, TOrderSplitResult> : WebhookPayload<object, TOrderSplitResult, SplitRouteParams, TConfigData>
				where TOrderSplitResult : OrderSplitResult
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/split.</summary>
			public class SplitRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/forward.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/forward")]
			public class Forward : WebhookPayload<object, OrderSplitResult, ForwardRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/forward.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderSplitResult">Specific type of the OrderSplitResult. If not using a custom type, specify OrderSplitResult.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/forward")]
			public class Forward<TConfigData, TOrderSplitResult> : WebhookPayload<object, TOrderSplitResult, ForwardRouteParams, TConfigData>
				where TOrderSplitResult : OrderSplitResult
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/forward.</summary>
			public class ForwardRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/complete.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/complete")]
			public class Complete : WebhookPayload<object, Order, CompleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/complete.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/complete")]
			public class Complete<TConfigData, TOrder> : WebhookPayload<object, TOrder, CompleteRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/complete.</summary>
			public class CompleteRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/ship.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/ship")]
			public class Ship : WebhookPayload<Shipment, Order, ShipRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/ship.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TShipment">Specific type of the Shipment. If not using a custom type, specify Shipment.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/ship")]
			public class Ship<TConfigData, TShipment, TOrder> : WebhookPayload<TShipment, TOrder, ShipRouteParams, TConfigData>
				where TShipment : Shipment
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/ship.</summary>
			public class ShipRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/shipto.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/shipto")]
			public class SetShippingAddress : WebhookPayload<Address, Order, SetShippingAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/shipto")]
			public class SetShippingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, SetShippingAddressRouteParams, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/shipto.</summary>
			public class SetShippingAddressRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/shipto.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/shipto")]
			public class PatchShippingAddress : WebhookPayload<Address, Order, PatchShippingAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/shipto")]
			public class PatchShippingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, PatchShippingAddressRouteParams, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/shipto.</summary>
			public class PatchShippingAddressRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/billto.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/billto")]
			public class SetBillingAddress : WebhookPayload<Address, Order, SetBillingAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/billto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/billto")]
			public class SetBillingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, SetBillingAddressRouteParams, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/billto.</summary>
			public class SetBillingAddressRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/billto.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/billto")]
			public class PatchBillingAddress : WebhookPayload<Address, Order, PatchBillingAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/billto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/billto")]
			public class PatchBillingAddress<TConfigData, TAddress, TOrder> : WebhookPayload<TAddress, TOrder, PatchBillingAddressRouteParams, TConfigData>
				where TAddress : Address
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/billto.</summary>
			public class PatchBillingAddressRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/fromuser.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/fromuser")]
			public class PatchFromUser : WebhookPayload<User, Order, PatchFromUserRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/fromuser.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/fromuser")]
			public class PatchFromUser<TConfigData, TUser, TOrder> : WebhookPayload<TUser, TOrder, PatchFromUserRouteParams, TConfigData>
				where TUser : User
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/fromuser.</summary>
			public class PatchFromUserRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class AddPromotion : WebhookPayload<object, OrderPromotion, AddPromotionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderPromotion">Specific type of the OrderPromotion. If not using a custom type, specify OrderPromotion.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class AddPromotion<TConfigData, TOrderPromotion> : WebhookPayload<object, TOrderPromotion, AddPromotionRouteParams, TConfigData>
				where TOrderPromotion : OrderPromotion
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			public class AddPromotionRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string PromoCode { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class RemovePromotion : WebhookPayload<object, Order, RemovePromotionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class RemovePromotion<TConfigData, TOrder> : WebhookPayload<object, TOrder, RemovePromotionRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			public class RemovePromotionRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string PromoCode { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/applypromotions.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/applypromotions")]
			public class ApplyPromotions : WebhookPayload<object, Order, ApplyPromotionsRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/applypromotions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrder">Specific type of the Order. If not using a custom type, specify Order.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/applypromotions")]
			public class ApplyPromotions<TConfigData, TOrder> : WebhookPayload<object, TOrder, ApplyPromotionsRouteParams, TConfigData>
				where TOrder : Order
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/applypromotions.</summary>
			public class ApplyPromotionsRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/validate.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/validate")]
			public class Validate : WebhookPayload<object, object, ValidateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/validate.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/validate")]
			public class Validate<TConfigData> : WebhookPayload<object, object, ValidateRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/validate.</summary>
			public class ValidateRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
		}
		public static class OrderSyncs
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/OrderSync.</summary>
			[SentOn("DELETE", "v1/integrations/OrderSync")]
			public class Delete : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/OrderSync.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/OrderSync")]
			public class Delete<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/OrderSync.</summary>
			[SentOn("PUT", "v1/integrations/OrderSync")]
			public class Save : WebhookPayload<OrderSyncConfig, OrderSyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/OrderSync.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderSyncConfig">Specific type of the OrderSyncConfig. If not using a custom type, specify OrderSyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/OrderSync")]
			public class Save<TConfigData, TOrderSyncConfig> : WebhookPayload<TOrderSyncConfig, TOrderSyncConfig, object, TConfigData>
				where TOrderSyncConfig : OrderSyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/OrderSync.</summary>
			[SentOn("PATCH", "v1/integrations/OrderSync")]
			public class Patch : WebhookPayload<OrderSyncConfig, OrderSyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/OrderSync.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TOrderSyncConfig">Specific type of the OrderSyncConfig. If not using a custom type, specify OrderSyncConfig.</typeparam>
			[SentOn("PATCH", "v1/integrations/OrderSync")]
			public class Patch<TConfigData, TOrderSyncConfig> : WebhookPayload<TOrderSyncConfig, TOrderSyncConfig, object, TConfigData>
				where TOrderSyncConfig : OrderSyncConfig
			{ }
		}
		public static class Payments
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments")]
			public class Create : WebhookPayload<Payment, Payment, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPayment">Specific type of the Payment. If not using a custom type, specify Payment.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments")]
			public class Create<TConfigData, TPayment> : WebhookPayload<TPayment, TPayment, CreateRouteParams, TConfigData>
				where TPayment : Payment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments.</summary>
			public class CreateRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			public class DeleteRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string PaymentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Patch : WebhookPayload<Payment, Payment, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPayment">Specific type of the Payment. If not using a custom type, specify Payment.</typeparam>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Patch<TConfigData, TPayment> : WebhookPayload<TPayment, TPayment, PatchRouteParams, TConfigData>
				where TPayment : Payment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			public class PatchRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string PaymentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions")]
			public class CreateTransaction : WebhookPayload<PaymentTransaction, Payment, CreateTransactionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPaymentTransaction">Specific type of the PaymentTransaction. If not using a custom type, specify PaymentTransaction.</typeparam>
			/// <typeparam name="TPayment">Specific type of the Payment. If not using a custom type, specify Payment.</typeparam>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions")]
			public class CreateTransaction<TConfigData, TPaymentTransaction, TPayment> : WebhookPayload<TPaymentTransaction, TPayment, CreateTransactionRouteParams, TConfigData>
				where TPaymentTransaction : PaymentTransaction
				where TPayment : Payment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions.</summary>
			public class CreateTransactionRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string PaymentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}")]
			public class DeleteTransaction : WebhookPayload<object, object, DeleteTransactionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}")]
			public class DeleteTransaction<TConfigData> : WebhookPayload<object, object, DeleteTransactionRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}.</summary>
			public class DeleteTransactionRouteParams
			{
				public OrderDirection Direction { get; set; }
				public string OrderID { get; set; }
				public string PaymentID { get; set; }
				public string TransactionID { get; set; }
			}
		}
		public static class PriceSchedules
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules.</summary>
			[SentOn("POST", "v1/priceschedules")]
			public class Create : WebhookPayload<PriceSchedule, PriceSchedule, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule. If not using a custom type, specify PriceSchedule.</typeparam>
			[SentOn("POST", "v1/priceschedules")]
			public class Create<TConfigData, TPriceSchedule> : WebhookPayload<TPriceSchedule, TPriceSchedule, object, TConfigData>
				where TPriceSchedule : PriceSchedule
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/priceschedules/{priceScheduleID}.</summary>
			[SentOn("PUT", "v1/priceschedules/{priceScheduleID}")]
			public class Save : WebhookPayload<PriceSchedule, PriceSchedule, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/priceschedules/{priceScheduleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule. If not using a custom type, specify PriceSchedule.</typeparam>
			[SentOn("PUT", "v1/priceschedules/{priceScheduleID}")]
			public class Save<TConfigData, TPriceSchedule> : WebhookPayload<TPriceSchedule, TPriceSchedule, SaveRouteParams, TConfigData>
				where TPriceSchedule : PriceSchedule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}.</summary>
			public class SaveRouteParams
			{
				public string PriceScheduleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}.</summary>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}.</summary>
			public class DeleteRouteParams
			{
				public string PriceScheduleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/priceschedules/{priceScheduleID}.</summary>
			[SentOn("PATCH", "v1/priceschedules/{priceScheduleID}")]
			public class Patch : WebhookPayload<PriceSchedule, PriceSchedule, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/priceschedules/{priceScheduleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule. If not using a custom type, specify PriceSchedule.</typeparam>
			[SentOn("PATCH", "v1/priceschedules/{priceScheduleID}")]
			public class Patch<TConfigData, TPriceSchedule> : WebhookPayload<TPriceSchedule, TPriceSchedule, PatchRouteParams, TConfigData>
				where TPriceSchedule : PriceSchedule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}.</summary>
			public class PatchRouteParams
			{
				public string PriceScheduleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			[SentOn("POST", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class SavePriceBreak : WebhookPayload<PriceBreak, PriceSchedule, SavePriceBreakRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPriceBreak">Specific type of the PriceBreak. If not using a custom type, specify PriceBreak.</typeparam>
			/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule. If not using a custom type, specify PriceSchedule.</typeparam>
			[SentOn("POST", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class SavePriceBreak<TConfigData, TPriceBreak, TPriceSchedule> : WebhookPayload<TPriceBreak, TPriceSchedule, SavePriceBreakRouteParams, TConfigData>
				where TPriceBreak : PriceBreak
				where TPriceSchedule : PriceSchedule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			public class SavePriceBreakRouteParams
			{
				public string PriceScheduleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class DeletePriceBreak : WebhookPayload<object, object, DeletePriceBreakRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class DeletePriceBreak<TConfigData> : WebhookPayload<object, object, DeletePriceBreakRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			public class DeletePriceBreakRouteParams
			{
				public string PriceScheduleID { get; set; }
			}
		}
		public static class ProductCollections
		{
		}
		public static class ProductFacets
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/productfacets.</summary>
			[SentOn("POST", "v1/productfacets")]
			public class Create : WebhookPayload<ProductFacet, ProductFacet, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/productfacets.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductFacet">Specific type of the ProductFacet. If not using a custom type, specify ProductFacet.</typeparam>
			[SentOn("POST", "v1/productfacets")]
			public class Create<TConfigData, TProductFacet> : WebhookPayload<TProductFacet, TProductFacet, object, TConfigData>
				where TProductFacet : ProductFacet
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/productfacets/{productFacetID}.</summary>
			[SentOn("PUT", "v1/productfacets/{productFacetID}")]
			public class Save : WebhookPayload<ProductFacet, ProductFacet, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/productfacets/{productFacetID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductFacet">Specific type of the ProductFacet. If not using a custom type, specify ProductFacet.</typeparam>
			[SentOn("PUT", "v1/productfacets/{productFacetID}")]
			public class Save<TConfigData, TProductFacet> : WebhookPayload<TProductFacet, TProductFacet, SaveRouteParams, TConfigData>
				where TProductFacet : ProductFacet
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/productfacets/{productFacetID}.</summary>
			public class SaveRouteParams
			{
				public string ProductFacetID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/productfacets/{productFacetID}.</summary>
			[SentOn("DELETE", "v1/productfacets/{productFacetID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/productfacets/{productFacetID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/productfacets/{productFacetID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/productfacets/{productFacetID}.</summary>
			public class DeleteRouteParams
			{
				public string ProductFacetID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/productfacets/{productFacetID}.</summary>
			[SentOn("PATCH", "v1/productfacets/{productFacetID}")]
			public class Patch : WebhookPayload<ProductFacet, ProductFacet, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/productfacets/{productFacetID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductFacet">Specific type of the ProductFacet. If not using a custom type, specify ProductFacet.</typeparam>
			[SentOn("PATCH", "v1/productfacets/{productFacetID}")]
			public class Patch<TConfigData, TProductFacet> : WebhookPayload<TProductFacet, TProductFacet, PatchRouteParams, TConfigData>
				where TProductFacet : ProductFacet
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/productfacets/{productFacetID}.</summary>
			public class PatchRouteParams
			{
				public string ProductFacetID { get; set; }
			}
		}
		public static class Products
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products.</summary>
			[SentOn("POST", "v1/products")]
			public class Create : WebhookPayload<Product, Product, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProduct">Specific type of the Product. If not using a custom type, specify Product.</typeparam>
			[SentOn("POST", "v1/products")]
			public class Create<TConfigData, TProduct> : WebhookPayload<TProduct, TProduct, object, TConfigData>
				where TProduct : Product
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}.</summary>
			[SentOn("PUT", "v1/products/{productID}")]
			public class Save : WebhookPayload<Product, Product, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProduct">Specific type of the Product. If not using a custom type, specify Product.</typeparam>
			[SentOn("PUT", "v1/products/{productID}")]
			public class Save<TConfigData, TProduct> : WebhookPayload<TProduct, TProduct, SaveRouteParams, TConfigData>
				where TProduct : Product
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}.</summary>
			public class SaveRouteParams
			{
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}.</summary>
			public class DeleteRouteParams
			{
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}.</summary>
			[SentOn("PATCH", "v1/products/{productID}")]
			public class Patch : WebhookPayload<Product, Product, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProduct">Specific type of the Product. If not using a custom type, specify Product.</typeparam>
			[SentOn("PATCH", "v1/products/{productID}")]
			public class Patch<TConfigData, TProduct> : WebhookPayload<TProduct, TProduct, PatchRouteParams, TConfigData>
				where TProduct : Product
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}.</summary>
			public class PatchRouteParams
			{
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/generate.</summary>
			[SentOn("POST", "v1/products/{productID}/variants/generate")]
			public class GenerateVariants : WebhookPayload<object, Product, GenerateVariantsRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/generate.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProduct">Specific type of the Product. If not using a custom type, specify Product.</typeparam>
			[SentOn("POST", "v1/products/{productID}/variants/generate")]
			public class GenerateVariants<TConfigData, TProduct> : WebhookPayload<object, TProduct, GenerateVariantsRouteParams, TConfigData>
				where TProduct : Product
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/generate.</summary>
			public class GenerateVariantsRouteParams
			{
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/variants/{variantID}.</summary>
			[SentOn("PUT", "v1/products/{productID}/variants/{variantID}")]
			public class SaveVariant : WebhookPayload<Variant, Variant, SaveVariantRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/variants/{variantID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TVariant">Specific type of the Variant. If not using a custom type, specify Variant.</typeparam>
			[SentOn("PUT", "v1/products/{productID}/variants/{variantID}")]
			public class SaveVariant<TConfigData, TVariant> : WebhookPayload<TVariant, TVariant, SaveVariantRouteParams, TConfigData>
				where TVariant : Variant
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}.</summary>
			public class SaveVariantRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/variants/{variantID}.</summary>
			[SentOn("PATCH", "v1/products/{productID}/variants/{variantID}")]
			public class PatchVariant : WebhookPayload<Variant, Variant, PatchVariantRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/variants/{variantID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TVariant">Specific type of the Variant. If not using a custom type, specify Variant.</typeparam>
			[SentOn("PATCH", "v1/products/{productID}/variants/{variantID}")]
			public class PatchVariant<TConfigData, TVariant> : WebhookPayload<TVariant, TVariant, PatchVariantRouteParams, TConfigData>
				where TVariant : Variant
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}.</summary>
			public class PatchVariantRouteParams
			{
				public string ProductID { get; set; }
				public string VariantID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/suppliers/{supplierID}.</summary>
			[SentOn("PUT", "v1/products/{productID}/suppliers/{supplierID}")]
			public class SaveSupplier : WebhookPayload<object, object, SaveSupplierRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/suppliers/{supplierID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("PUT", "v1/products/{productID}/suppliers/{supplierID}")]
			public class SaveSupplier<TConfigData> : WebhookPayload<object, object, SaveSupplierRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/suppliers/{supplierID}.</summary>
			public class SaveSupplierRouteParams
			{
				public string ProductID { get; set; }
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/suppliers/{supplierID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}/suppliers/{supplierID}")]
			public class RemoveSupplier : WebhookPayload<object, object, RemoveSupplierRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/suppliers/{supplierID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}/suppliers/{supplierID}")]
			public class RemoveSupplier<TConfigData> : WebhookPayload<object, object, RemoveSupplierRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/suppliers/{supplierID}.</summary>
			public class RemoveSupplierRouteParams
			{
				public string ProductID { get; set; }
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/assignments.</summary>
			[SentOn("POST", "v1/products/assignments")]
			public class SaveAssignment : WebhookPayload<ProductAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductAssignment">Specific type of the ProductAssignment. If not using a custom type, specify ProductAssignment.</typeparam>
			[SentOn("POST", "v1/products/assignments")]
			public class SaveAssignment<TConfigData, TProductAssignment> : WebhookPayload<TProductAssignment, object, object, TConfigData>
				where TProductAssignment : ProductAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/assignments/{buyerID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}/assignments/{buyerID}")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/assignments/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/products/{productID}/assignments/{buyerID}")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/assignments/{buyerID}.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string ProductID { get; set; }
				public string BuyerID { get; set; }
			}
		}
		public static class ProductSyncs
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/productsync.</summary>
			[SentOn("DELETE", "v1/integrations/productsync")]
			public class Delete : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/productsync.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/productsync")]
			public class Delete<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/productsync.</summary>
			[SentOn("PUT", "v1/integrations/productsync")]
			public class Save : WebhookPayload<ProductSyncConfig, ProductSyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/productsync.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductSyncConfig">Specific type of the ProductSyncConfig. If not using a custom type, specify ProductSyncConfig.</typeparam>
			[SentOn("PUT", "v1/integrations/productsync")]
			public class Save<TConfigData, TProductSyncConfig> : WebhookPayload<TProductSyncConfig, TProductSyncConfig, object, TConfigData>
				where TProductSyncConfig : ProductSyncConfig
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/productsync.</summary>
			[SentOn("PATCH", "v1/integrations/productsync")]
			public class Patch : WebhookPayload<ProductSyncConfig, ProductSyncConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/productsync.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TProductSyncConfig">Specific type of the ProductSyncConfig. If not using a custom type, specify ProductSyncConfig.</typeparam>
			[SentOn("PATCH", "v1/integrations/productsync")]
			public class Patch<TConfigData, TProductSyncConfig> : WebhookPayload<TProductSyncConfig, TProductSyncConfig, object, TConfigData>
				where TProductSyncConfig : ProductSyncConfig
			{ }
		}
		public static class Promotions
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions.</summary>
			[SentOn("POST", "v1/promotions")]
			public class Create : WebhookPayload<Promotion, Promotion, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPromotion">Specific type of the Promotion. If not using a custom type, specify Promotion.</typeparam>
			[SentOn("POST", "v1/promotions")]
			public class Create<TConfigData, TPromotion> : WebhookPayload<TPromotion, TPromotion, object, TConfigData>
				where TPromotion : Promotion
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/promotions/{promotionID}.</summary>
			[SentOn("PUT", "v1/promotions/{promotionID}")]
			public class Save : WebhookPayload<Promotion, Promotion, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/promotions/{promotionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPromotion">Specific type of the Promotion. If not using a custom type, specify Promotion.</typeparam>
			[SentOn("PUT", "v1/promotions/{promotionID}")]
			public class Save<TConfigData, TPromotion> : WebhookPayload<TPromotion, TPromotion, SaveRouteParams, TConfigData>
				where TPromotion : Promotion
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}.</summary>
			public class SaveRouteParams
			{
				public string PromotionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}.</summary>
			[SentOn("DELETE", "v1/promotions/{promotionID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/promotions/{promotionID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}.</summary>
			public class DeleteRouteParams
			{
				public string PromotionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/promotions/{promotionID}.</summary>
			[SentOn("PATCH", "v1/promotions/{promotionID}")]
			public class Patch : WebhookPayload<Promotion, Promotion, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/promotions/{promotionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPromotion">Specific type of the Promotion. If not using a custom type, specify Promotion.</typeparam>
			[SentOn("PATCH", "v1/promotions/{promotionID}")]
			public class Patch<TConfigData, TPromotion> : WebhookPayload<TPromotion, TPromotion, PatchRouteParams, TConfigData>
				where TPromotion : Promotion
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}.</summary>
			public class PatchRouteParams
			{
				public string PromotionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions/assignments.</summary>
			[SentOn("POST", "v1/promotions/assignments")]
			public class SaveAssignment : WebhookPayload<PromotionAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TPromotionAssignment">Specific type of the PromotionAssignment. If not using a custom type, specify PromotionAssignment.</typeparam>
			[SentOn("POST", "v1/promotions/assignments")]
			public class SaveAssignment<TConfigData, TPromotionAssignment> : WebhookPayload<TPromotionAssignment, object, object, TConfigData>
				where TPromotionAssignment : PromotionAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}/assignments.</summary>
			[SentOn("DELETE", "v1/promotions/{promotionID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/promotions/{promotionID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string PromotionID { get; set; }
			}
		}
		public static class SecurityProfiles
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles.</summary>
			[SentOn("POST", "v1/securityprofiles")]
			public class Create : WebhookPayload<SecurityProfile, SecurityProfile, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSecurityProfile">Specific type of the SecurityProfile. If not using a custom type, specify SecurityProfile.</typeparam>
			[SentOn("POST", "v1/securityprofiles")]
			public class Create<TConfigData, TSecurityProfile> : WebhookPayload<TSecurityProfile, TSecurityProfile, object, TConfigData>
				where TSecurityProfile : SecurityProfile
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/securityprofiles/{securityProfileID}.</summary>
			[SentOn("PUT", "v1/securityprofiles/{securityProfileID}")]
			public class Save : WebhookPayload<SecurityProfile, SecurityProfile, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/securityprofiles/{securityProfileID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSecurityProfile">Specific type of the SecurityProfile. If not using a custom type, specify SecurityProfile.</typeparam>
			[SentOn("PUT", "v1/securityprofiles/{securityProfileID}")]
			public class Save<TConfigData, TSecurityProfile> : WebhookPayload<TSecurityProfile, TSecurityProfile, SaveRouteParams, TConfigData>
				where TSecurityProfile : SecurityProfile
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}.</summary>
			public class SaveRouteParams
			{
				public string SecurityProfileID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}.</summary>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}.</summary>
			public class DeleteRouteParams
			{
				public string SecurityProfileID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/securityprofiles/{securityProfileID}.</summary>
			[SentOn("PATCH", "v1/securityprofiles/{securityProfileID}")]
			public class Patch : WebhookPayload<SecurityProfile, SecurityProfile, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/securityprofiles/{securityProfileID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSecurityProfile">Specific type of the SecurityProfile. If not using a custom type, specify SecurityProfile.</typeparam>
			[SentOn("PATCH", "v1/securityprofiles/{securityProfileID}")]
			public class Patch<TConfigData, TSecurityProfile> : WebhookPayload<TSecurityProfile, TSecurityProfile, PatchRouteParams, TConfigData>
				where TSecurityProfile : SecurityProfile
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}.</summary>
			public class PatchRouteParams
			{
				public string SecurityProfileID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}/assignments.</summary>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string SecurityProfileID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles/assignments.</summary>
			[SentOn("POST", "v1/securityprofiles/assignments")]
			public class SaveAssignment : WebhookPayload<SecurityProfileAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSecurityProfileAssignment">Specific type of the SecurityProfileAssignment. If not using a custom type, specify SecurityProfileAssignment.</typeparam>
			[SentOn("POST", "v1/securityprofiles/assignments")]
			public class SaveAssignment<TConfigData, TSecurityProfileAssignment> : WebhookPayload<TSecurityProfileAssignment, object, object, TConfigData>
				where TSecurityProfileAssignment : SecurityProfileAssignment
			{ }
		}
		public static class SellerApprovalRules
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/approvalrules.</summary>
			[SentOn("POST", "v1/approvalrules")]
			public class Create : WebhookPayload<SellerApprovalRule, SellerApprovalRule, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/approvalrules.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSellerApprovalRule">Specific type of the SellerApprovalRule. If not using a custom type, specify SellerApprovalRule.</typeparam>
			[SentOn("POST", "v1/approvalrules")]
			public class Create<TConfigData, TSellerApprovalRule> : WebhookPayload<TSellerApprovalRule, TSellerApprovalRule, object, TConfigData>
				where TSellerApprovalRule : SellerApprovalRule
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/approvalrules/{approvalRuleID}.</summary>
			[SentOn("PUT", "v1/approvalrules/{approvalRuleID}")]
			public class Save : WebhookPayload<SellerApprovalRule, SellerApprovalRule, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/approvalrules/{approvalRuleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSellerApprovalRule">Specific type of the SellerApprovalRule. If not using a custom type, specify SellerApprovalRule.</typeparam>
			[SentOn("PUT", "v1/approvalrules/{approvalRuleID}")]
			public class Save<TConfigData, TSellerApprovalRule> : WebhookPayload<TSellerApprovalRule, TSellerApprovalRule, SaveRouteParams, TConfigData>
				where TSellerApprovalRule : SellerApprovalRule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/approvalrules/{approvalRuleID}.</summary>
			public class SaveRouteParams
			{
				public string ApprovalRuleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/approvalrules/{approvalRuleID}.</summary>
			[SentOn("DELETE", "v1/approvalrules/{approvalRuleID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/approvalrules/{approvalRuleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/approvalrules/{approvalRuleID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/approvalrules/{approvalRuleID}.</summary>
			public class DeleteRouteParams
			{
				public string ApprovalRuleID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/approvalrules/{approvalRuleID}.</summary>
			[SentOn("PATCH", "v1/approvalrules/{approvalRuleID}")]
			public class Patch : WebhookPayload<SellerApprovalRule, SellerApprovalRule, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/approvalrules/{approvalRuleID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSellerApprovalRule">Specific type of the SellerApprovalRule. If not using a custom type, specify SellerApprovalRule.</typeparam>
			[SentOn("PATCH", "v1/approvalrules/{approvalRuleID}")]
			public class Patch<TConfigData, TSellerApprovalRule> : WebhookPayload<TSellerApprovalRule, TSellerApprovalRule, PatchRouteParams, TConfigData>
				where TSellerApprovalRule : SellerApprovalRule
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/approvalrules/{approvalRuleID}.</summary>
			public class PatchRouteParams
			{
				public string ApprovalRuleID { get; set; }
			}
		}
		public static class Shipments
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments.</summary>
			[SentOn("POST", "v1/shipments")]
			public class Create : WebhookPayload<Shipment, Shipment, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TShipment">Specific type of the Shipment. If not using a custom type, specify Shipment.</typeparam>
			[SentOn("POST", "v1/shipments")]
			public class Create<TConfigData, TShipment> : WebhookPayload<TShipment, TShipment, object, TConfigData>
				where TShipment : Shipment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}.</summary>
			[SentOn("PUT", "v1/shipments/{shipmentID}")]
			public class Save : WebhookPayload<Shipment, Shipment, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TShipment">Specific type of the Shipment. If not using a custom type, specify Shipment.</typeparam>
			[SentOn("PUT", "v1/shipments/{shipmentID}")]
			public class Save<TConfigData, TShipment> : WebhookPayload<TShipment, TShipment, SaveRouteParams, TConfigData>
				where TShipment : Shipment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}.</summary>
			public class SaveRouteParams
			{
				public string ShipmentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}.</summary>
			[SentOn("DELETE", "v1/shipments/{shipmentID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/shipments/{shipmentID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}.</summary>
			public class DeleteRouteParams
			{
				public string ShipmentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/shipments/{shipmentID}.</summary>
			[SentOn("PATCH", "v1/shipments/{shipmentID}")]
			public class Patch : WebhookPayload<Shipment, Shipment, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/shipments/{shipmentID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TShipment">Specific type of the Shipment. If not using a custom type, specify Shipment.</typeparam>
			[SentOn("PATCH", "v1/shipments/{shipmentID}")]
			public class Patch<TConfigData, TShipment> : WebhookPayload<TShipment, TShipment, PatchRouteParams, TConfigData>
				where TShipment : Shipment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}.</summary>
			public class PatchRouteParams
			{
				public string ShipmentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}/shipto.</summary>
			[SentOn("PUT", "v1/shipments/{shipmentID}/shipto")]
			public class SetShipToAddress : WebhookPayload<Address, Shipment, SetShipToAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}/shipto.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TShipment">Specific type of the Shipment. If not using a custom type, specify Shipment.</typeparam>
			[SentOn("PUT", "v1/shipments/{shipmentID}/shipto")]
			public class SetShipToAddress<TConfigData, TAddress, TShipment> : WebhookPayload<TAddress, TShipment, SetShipToAddressRouteParams, TConfigData>
				where TAddress : Address
				where TShipment : Shipment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}/shipto.</summary>
			public class SetShipToAddressRouteParams
			{
				public string ShipmentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}/shipfrom.</summary>
			[SentOn("PUT", "v1/shipments/{shipmentID}/shipfrom")]
			public class SetShipFromAddress : WebhookPayload<Address, Shipment, SetShipFromAddressRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}/shipfrom.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			/// <typeparam name="TShipment">Specific type of the Shipment. If not using a custom type, specify Shipment.</typeparam>
			[SentOn("PUT", "v1/shipments/{shipmentID}/shipfrom")]
			public class SetShipFromAddress<TConfigData, TAddress, TShipment> : WebhookPayload<TAddress, TShipment, SetShipFromAddressRouteParams, TConfigData>
				where TAddress : Address
				where TShipment : Shipment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}/shipfrom.</summary>
			public class SetShipFromAddressRouteParams
			{
				public string ShipmentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments/{shipmentID}/items.</summary>
			[SentOn("POST", "v1/shipments/{shipmentID}/items")]
			public class SaveItem : WebhookPayload<ShipmentItem, ShipmentItem, SaveItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments/{shipmentID}/items.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TShipmentItem">Specific type of the ShipmentItem. If not using a custom type, specify ShipmentItem.</typeparam>
			[SentOn("POST", "v1/shipments/{shipmentID}/items")]
			public class SaveItem<TConfigData, TShipmentItem> : WebhookPayload<TShipmentItem, TShipmentItem, SaveItemRouteParams, TConfigData>
				where TShipmentItem : ShipmentItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}/items.</summary>
			public class SaveItemRouteParams
			{
				public string ShipmentID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}.</summary>
			[SentOn("DELETE", "v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}")]
			public class DeleteItem : WebhookPayload<object, object, DeleteItemRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}")]
			public class DeleteItem<TConfigData> : WebhookPayload<object, object, DeleteItemRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}.</summary>
			public class DeleteItemRouteParams
			{
				public string ShipmentID { get; set; }
				public string OrderID { get; set; }
				public string LineItemID { get; set; }
			}
		}
		public static class Specs
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs.</summary>
			[SentOn("POST", "v1/specs")]
			public class Create : WebhookPayload<Spec, Spec, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpec">Specific type of the Spec. If not using a custom type, specify Spec.</typeparam>
			[SentOn("POST", "v1/specs")]
			public class Create<TConfigData, TSpec> : WebhookPayload<TSpec, TSpec, object, TConfigData>
				where TSpec : Spec
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}.</summary>
			[SentOn("PUT", "v1/specs/{specID}")]
			public class Save : WebhookPayload<Spec, Spec, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpec">Specific type of the Spec. If not using a custom type, specify Spec.</typeparam>
			[SentOn("PUT", "v1/specs/{specID}")]
			public class Save<TConfigData, TSpec> : WebhookPayload<TSpec, TSpec, SaveRouteParams, TConfigData>
				where TSpec : Spec
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}.</summary>
			public class SaveRouteParams
			{
				public string SpecID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}.</summary>
			[SentOn("DELETE", "v1/specs/{specID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/specs/{specID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}.</summary>
			public class DeleteRouteParams
			{
				public string SpecID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}.</summary>
			[SentOn("PATCH", "v1/specs/{specID}")]
			public class Patch : WebhookPayload<Spec, Spec, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpec">Specific type of the Spec. If not using a custom type, specify Spec.</typeparam>
			[SentOn("PATCH", "v1/specs/{specID}")]
			public class Patch<TConfigData, TSpec> : WebhookPayload<TSpec, TSpec, PatchRouteParams, TConfigData>
				where TSpec : Spec
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}.</summary>
			public class PatchRouteParams
			{
				public string SpecID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/specs/{specID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/productassignments/{productID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/specs/{specID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/productassignments/{productID}.</summary>
			public class DeleteProductAssignmentRouteParams
			{
				public string SpecID { get; set; }
				public string ProductID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/productassignments.</summary>
			[SentOn("POST", "v1/specs/productassignments")]
			public class SaveProductAssignment : WebhookPayload<SpecProductAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/productassignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpecProductAssignment">Specific type of the SpecProductAssignment. If not using a custom type, specify SpecProductAssignment.</typeparam>
			[SentOn("POST", "v1/specs/productassignments")]
			public class SaveProductAssignment<TConfigData, TSpecProductAssignment> : WebhookPayload<TSpecProductAssignment, object, object, TConfigData>
				where TSpecProductAssignment : SpecProductAssignment
			{ }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/{specID}/options.</summary>
			[SentOn("POST", "v1/specs/{specID}/options")]
			public class CreateOption : WebhookPayload<SpecOption, SpecOption, CreateOptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/{specID}/options.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpecOption">Specific type of the SpecOption. If not using a custom type, specify SpecOption.</typeparam>
			[SentOn("POST", "v1/specs/{specID}/options")]
			public class CreateOption<TConfigData, TSpecOption> : WebhookPayload<TSpecOption, TSpecOption, CreateOptionRouteParams, TConfigData>
				where TSpecOption : SpecOption
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options.</summary>
			public class CreateOptionRouteParams
			{
				public string SpecID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}/options/{optionID}.</summary>
			[SentOn("PUT", "v1/specs/{specID}/options/{optionID}")]
			public class SaveOption : WebhookPayload<SpecOption, SpecOption, SaveOptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}/options/{optionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpecOption">Specific type of the SpecOption. If not using a custom type, specify SpecOption.</typeparam>
			[SentOn("PUT", "v1/specs/{specID}/options/{optionID}")]
			public class SaveOption<TConfigData, TSpecOption> : WebhookPayload<TSpecOption, TSpecOption, SaveOptionRouteParams, TConfigData>
				where TSpecOption : SpecOption
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options/{optionID}.</summary>
			public class SaveOptionRouteParams
			{
				public string SpecID { get; set; }
				public string OptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}/options/{optionID}.</summary>
			[SentOn("PATCH", "v1/specs/{specID}/options/{optionID}")]
			public class PatchOption : WebhookPayload<SpecOption, SpecOption, PatchOptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}/options/{optionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpecOption">Specific type of the SpecOption. If not using a custom type, specify SpecOption.</typeparam>
			[SentOn("PATCH", "v1/specs/{specID}/options/{optionID}")]
			public class PatchOption<TConfigData, TSpecOption> : WebhookPayload<TSpecOption, TSpecOption, PatchOptionRouteParams, TConfigData>
				where TSpecOption : SpecOption
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options/{optionID}.</summary>
			public class PatchOptionRouteParams
			{
				public string SpecID { get; set; }
				public string OptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/options/{optionID}.</summary>
			[SentOn("DELETE", "v1/specs/{specID}/options/{optionID}")]
			public class DeleteOption : WebhookPayload<object, object, DeleteOptionRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/options/{optionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/specs/{specID}/options/{optionID}")]
			public class DeleteOption<TConfigData> : WebhookPayload<object, object, DeleteOptionRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options/{optionID}.</summary>
			public class DeleteOptionRouteParams
			{
				public string SpecID { get; set; }
				public string OptionID { get; set; }
			}
		}
		public static class SpendingAccounts
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts")]
			public class Create : WebhookPayload<SpendingAccount, SpendingAccount, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpendingAccount">Specific type of the SpendingAccount. If not using a custom type, specify SpendingAccount.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts")]
			public class Create<TConfigData, TSpendingAccount> : WebhookPayload<TSpendingAccount, TSpendingAccount, CreateRouteParams, TConfigData>
				where TSpendingAccount : SpendingAccount
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Save : WebhookPayload<SpendingAccount, SpendingAccount, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpendingAccount">Specific type of the SpendingAccount. If not using a custom type, specify SpendingAccount.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Save<TConfigData, TSpendingAccount> : WebhookPayload<TSpendingAccount, TSpendingAccount, SaveRouteParams, TConfigData>
				where TSpendingAccount : SpendingAccount
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string SpendingAccountID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string SpendingAccountID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Patch : WebhookPayload<SpendingAccount, SpendingAccount, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpendingAccount">Specific type of the SpendingAccount. If not using a custom type, specify SpendingAccount.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Patch<TConfigData, TSpendingAccount> : WebhookPayload<TSpendingAccount, TSpendingAccount, PatchRouteParams, TConfigData>
				where TSpendingAccount : SpendingAccount
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string SpendingAccountID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts/assignments")]
			public class SaveAssignment : WebhookPayload<SpendingAccountAssignment, object, SaveAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSpendingAccountAssignment">Specific type of the SpendingAccountAssignment. If not using a custom type, specify SpendingAccountAssignment.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts/assignments")]
			public class SaveAssignment<TConfigData, TSpendingAccountAssignment> : WebhookPayload<TSpendingAccountAssignment, object, SaveAssignmentRouteParams, TConfigData>
				where TSpendingAccountAssignment : SpendingAccountAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/assignments.</summary>
			public class SaveAssignmentRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments.</summary>
			public class DeleteAssignmentRouteParams
			{
				public string BuyerID { get; set; }
				public string SpendingAccountID { get; set; }
			}
		}
		public static class SubscriptionIntegrations
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/subscription.</summary>
			[SentOn("DELETE", "v1/integrations/subscription")]
			public class Delete : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/subscription.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/subscription")]
			public class Delete<TConfigData> : WebhookPayload<object, object, object, TConfigData>
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/subscription.</summary>
			[SentOn("PUT", "v1/integrations/subscription")]
			public class Save : WebhookPayload<SubscriptionIntegration, SubscriptionIntegration, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/subscription.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscriptionIntegration">Specific type of the SubscriptionIntegration. If not using a custom type, specify SubscriptionIntegration.</typeparam>
			[SentOn("PUT", "v1/integrations/subscription")]
			public class Save<TConfigData, TSubscriptionIntegration> : WebhookPayload<TSubscriptionIntegration, TSubscriptionIntegration, object, TConfigData>
				where TSubscriptionIntegration : SubscriptionIntegration
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/subscription.</summary>
			[SentOn("PATCH", "v1/integrations/subscription")]
			public class Patch : WebhookPayload<SubscriptionIntegration, SubscriptionIntegration, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/subscription.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscriptionIntegration">Specific type of the SubscriptionIntegration. If not using a custom type, specify SubscriptionIntegration.</typeparam>
			[SentOn("PATCH", "v1/integrations/subscription")]
			public class Patch<TConfigData, TSubscriptionIntegration> : WebhookPayload<TSubscriptionIntegration, TSubscriptionIntegration, object, TConfigData>
				where TSubscriptionIntegration : SubscriptionIntegration
			{ }
		}
		public static class SubscriptionItems
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/subscriptions/{subscriptionID}/items.</summary>
			[SentOn("POST", "v1/subscriptions/{subscriptionID}/items")]
			public class Create : WebhookPayload<LineItem, LineItem, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/subscriptions/{subscriptionID}/items.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("POST", "v1/subscriptions/{subscriptionID}/items")]
			public class Create<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, CreateRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}/items.</summary>
			public class CreateRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			[SentOn("PUT", "v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class Save : WebhookPayload<LineItem, LineItem, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PUT", "v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class Save<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, SaveRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			public class SaveRouteParams
			{
				public string SubscriptionID { get; set; }
				public string SubscriptionItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			[SentOn("DELETE", "v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			public class DeleteRouteParams
			{
				public string SubscriptionID { get; set; }
				public string SubscriptionItemID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			[SentOn("PATCH", "v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class Patch : WebhookPayload<LineItem, LineItem, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TLineItem">Specific type of the LineItem. If not using a custom type, specify LineItem.</typeparam>
			[SentOn("PATCH", "v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}")]
			public class Patch<TConfigData, TLineItem> : WebhookPayload<TLineItem, TLineItem, PatchRouteParams, TConfigData>
				where TLineItem : LineItem
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}/items/{subscriptionItemID}.</summary>
			public class PatchRouteParams
			{
				public string SubscriptionID { get; set; }
				public string SubscriptionItemID { get; set; }
			}
		}
		public static class Subscriptions
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/subscriptions.</summary>
			[SentOn("POST", "v1/subscriptions")]
			public class Create : WebhookPayload<Subscription, Subscription, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/subscriptions.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscription">Specific type of the Subscription. If not using a custom type, specify Subscription.</typeparam>
			[SentOn("POST", "v1/subscriptions")]
			public class Create<TConfigData, TSubscription> : WebhookPayload<TSubscription, TSubscription, object, TConfigData>
				where TSubscription : Subscription
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/subscriptions/{subscriptionID}.</summary>
			[SentOn("PUT", "v1/subscriptions/{subscriptionID}")]
			public class Save : WebhookPayload<Subscription, Subscription, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/subscriptions/{subscriptionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscription">Specific type of the Subscription. If not using a custom type, specify Subscription.</typeparam>
			[SentOn("PUT", "v1/subscriptions/{subscriptionID}")]
			public class Save<TConfigData, TSubscription> : WebhookPayload<TSubscription, TSubscription, SaveRouteParams, TConfigData>
				where TSubscription : Subscription
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}.</summary>
			public class SaveRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/subscriptions/{subscriptionID}.</summary>
			[SentOn("DELETE", "v1/subscriptions/{subscriptionID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/subscriptions/{subscriptionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/subscriptions/{subscriptionID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}.</summary>
			public class DeleteRouteParams
			{
				public string SubscriptionID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/subscriptions/{subscriptionID}.</summary>
			[SentOn("PATCH", "v1/subscriptions/{subscriptionID}")]
			public class Patch : WebhookPayload<Subscription, Subscription, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/subscriptions/{subscriptionID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSubscription">Specific type of the Subscription. If not using a custom type, specify Subscription.</typeparam>
			[SentOn("PATCH", "v1/subscriptions/{subscriptionID}")]
			public class Patch<TConfigData, TSubscription> : WebhookPayload<TSubscription, TSubscription, PatchRouteParams, TConfigData>
				where TSubscription : Subscription
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/subscriptions/{subscriptionID}.</summary>
			public class PatchRouteParams
			{
				public string SubscriptionID { get; set; }
			}
		}
		public static class SupplierAddresses
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/addresses.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/addresses")]
			public class Create : WebhookPayload<Address, Address, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/addresses.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("POST", "v1/suppliers/{supplierID}/addresses")]
			public class Create<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, CreateRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses.</summary>
			public class CreateRouteParams
			{
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Save : WebhookPayload<Address, Address, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("PUT", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Save<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, SaveRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			public class SaveRouteParams
			{
				public string SupplierID { get; set; }
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			public class DeleteRouteParams
			{
				public string SupplierID { get; set; }
				public string AddressID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Patch : WebhookPayload<Address, Address, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TAddress">Specific type of the Address. If not using a custom type, specify Address.</typeparam>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Patch<TConfigData, TAddress> : WebhookPayload<TAddress, TAddress, PatchRouteParams, TConfigData>
				where TAddress : Address
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			public class PatchRouteParams
			{
				public string SupplierID { get; set; }
				public string AddressID { get; set; }
			}
		}
		public static class Suppliers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers.</summary>
			[SentOn("POST", "v1/suppliers")]
			public class Create : WebhookPayload<Supplier, Supplier, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSupplier">Specific type of the Supplier. If not using a custom type, specify Supplier.</typeparam>
			[SentOn("POST", "v1/suppliers")]
			public class Create<TConfigData, TSupplier> : WebhookPayload<TSupplier, TSupplier, object, TConfigData>
				where TSupplier : Supplier
			{ }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}.</summary>
			public class DeleteRouteParams
			{
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}")]
			public class Save : WebhookPayload<Supplier, Supplier, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSupplier">Specific type of the Supplier. If not using a custom type, specify Supplier.</typeparam>
			[SentOn("PUT", "v1/suppliers/{supplierID}")]
			public class Save<TConfigData, TSupplier> : WebhookPayload<TSupplier, TSupplier, SaveRouteParams, TConfigData>
				where TSupplier : Supplier
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}.</summary>
			public class SaveRouteParams
			{
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}")]
			public class Patch : WebhookPayload<Supplier, Supplier, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TSupplier">Specific type of the Supplier. If not using a custom type, specify Supplier.</typeparam>
			[SentOn("PATCH", "v1/suppliers/{supplierID}")]
			public class Patch<TConfigData, TSupplier> : WebhookPayload<TSupplier, TSupplier, PatchRouteParams, TConfigData>
				where TSupplier : Supplier
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}.</summary>
			public class PatchRouteParams
			{
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/buyers/{buyerID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/buyers/{buyerID}")]
			public class SaveBuyer : WebhookPayload<object, object, SaveBuyerRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/buyers/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("PUT", "v1/suppliers/{supplierID}/buyers/{buyerID}")]
			public class SaveBuyer<TConfigData> : WebhookPayload<object, object, SaveBuyerRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/buyers/{buyerID}.</summary>
			public class SaveBuyerRouteParams
			{
				public string SupplierID { get; set; }
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/buyers/{buyerID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/buyers/{buyerID}")]
			public class DeleteBuyer : WebhookPayload<object, object, DeleteBuyerRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/buyers/{buyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/buyers/{buyerID}")]
			public class DeleteBuyer<TConfigData> : WebhookPayload<object, object, DeleteBuyerRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/buyers/{buyerID}.</summary>
			public class DeleteBuyerRouteParams
			{
				public string SupplierID { get; set; }
				public string BuyerID { get; set; }
			}
		}
		public static class SupplierUserGroups
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups")]
			public class Create : WebhookPayload<UserGroup, UserGroup, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups")]
			public class Create<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, CreateRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups.</summary>
			public class CreateRouteParams
			{
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Save : WebhookPayload<UserGroup, UserGroup, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("PUT", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Save<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, SaveRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			public class SaveRouteParams
			{
				public string SupplierID { get; set; }
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			public class DeleteRouteParams
			{
				public string SupplierID { get; set; }
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Patch : WebhookPayload<UserGroup, UserGroup, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Patch<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, PatchRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			public class PatchRouteParams
			{
				public string SupplierID { get; set; }
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment : WebhookPayload<object, object, DeleteUserAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment<TConfigData> : WebhookPayload<object, object, DeleteUserAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			public class DeleteUserAssignmentRouteParams
			{
				public string SupplierID { get; set; }
				public string UserGroupID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups/assignments.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups/assignments")]
			public class SaveUserAssignment : WebhookPayload<UserGroupAssignment, object, SaveUserAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroupAssignment">Specific type of the UserGroupAssignment. If not using a custom type, specify UserGroupAssignment.</typeparam>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups/assignments")]
			public class SaveUserAssignment<TConfigData, TUserGroupAssignment> : WebhookPayload<TUserGroupAssignment, object, SaveUserAssignmentRouteParams, TConfigData>
				where TUserGroupAssignment : UserGroupAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/assignments.</summary>
			public class SaveUserAssignmentRouteParams
			{
				public string SupplierID { get; set; }
			}
		}
		public static class SupplierUsers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/users")]
			public class Create : WebhookPayload<User, User, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("POST", "v1/suppliers/{supplierID}/users")]
			public class Create<TConfigData, TUser> : WebhookPayload<TUser, TUser, CreateRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users.</summary>
			public class CreateRouteParams
			{
				public string SupplierID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/users/{userID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Save : WebhookPayload<User, User, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/users/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("PUT", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Save<TConfigData, TUser> : WebhookPayload<TUser, TUser, SaveRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}.</summary>
			public class SaveRouteParams
			{
				public string SupplierID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/users/{userID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/users/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}.</summary>
			public class DeleteRouteParams
			{
				public string SupplierID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/users/{userID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Patch : WebhookPayload<User, User, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/users/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Patch<TConfigData, TUser> : WebhookPayload<TUser, TUser, PatchRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}.</summary>
			public class PatchRouteParams
			{
				public string SupplierID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users/{userID}/unlock.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/users/{userID}/unlock")]
			public class UnlockUserAccount : WebhookPayload<object, object, UnlockUserAccountRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users/{userID}/unlock.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/suppliers/{supplierID}/users/{userID}/unlock")]
			public class UnlockUserAccount<TConfigData> : WebhookPayload<object, object, UnlockUserAccountRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}/unlock.</summary>
			public class UnlockUserAccountRouteParams
			{
				public string SupplierID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/users/{userID}/tokens.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/users/{userID}/tokens")]
			public class RevokeUserTokens : WebhookPayload<object, object, RevokeUserTokensRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/users/{userID}/tokens.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/users/{userID}/tokens")]
			public class RevokeUserTokens<TConfigData> : WebhookPayload<object, object, RevokeUserTokensRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}/tokens.</summary>
			public class RevokeUserTokensRouteParams
			{
				public string SupplierID { get; set; }
				public string UserID { get; set; }
			}
		}
		public static class TrackingEvents
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrations/trackingEvents.</summary>
			[SentOn("POST", "v1/integrations/trackingEvents")]
			public class Create : WebhookPayload<TrackingEvent, TrackingEvent, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrations/trackingEvents.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TTrackingEvent">Specific type of the TrackingEvent. If not using a custom type, specify TrackingEvent.</typeparam>
			[SentOn("POST", "v1/integrations/trackingEvents")]
			public class Create<TConfigData, TTrackingEvent> : WebhookPayload<TTrackingEvent, TTrackingEvent, object, TConfigData>
				where TTrackingEvent : TrackingEvent
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/trackingEvents/{eventID}.</summary>
			[SentOn("PUT", "v1/integrations/trackingEvents/{eventID}")]
			public class Save : WebhookPayload<TrackingEvent, TrackingEvent, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrations/trackingEvents/{eventID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TTrackingEvent">Specific type of the TrackingEvent. If not using a custom type, specify TrackingEvent.</typeparam>
			[SentOn("PUT", "v1/integrations/trackingEvents/{eventID}")]
			public class Save<TConfigData, TTrackingEvent> : WebhookPayload<TTrackingEvent, TTrackingEvent, SaveRouteParams, TConfigData>
				where TTrackingEvent : TrackingEvent
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrations/trackingEvents/{eventID}.</summary>
			public class SaveRouteParams
			{
				public string EventID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/trackingEvents/{eventID}.</summary>
			[SentOn("DELETE", "v1/integrations/trackingEvents/{eventID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrations/trackingEvents/{eventID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/integrations/trackingEvents/{eventID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrations/trackingEvents/{eventID}.</summary>
			public class DeleteRouteParams
			{
				public string EventID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/trackingEvents/{eventID}.</summary>
			[SentOn("PATCH", "v1/integrations/trackingEvents/{eventID}")]
			public class Patch : WebhookPayload<TrackingEvent, TrackingEvent, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrations/trackingEvents/{eventID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TTrackingEvent">Specific type of the TrackingEvent. If not using a custom type, specify TrackingEvent.</typeparam>
			[SentOn("PATCH", "v1/integrations/trackingEvents/{eventID}")]
			public class Patch<TConfigData, TTrackingEvent> : WebhookPayload<TTrackingEvent, TTrackingEvent, PatchRouteParams, TConfigData>
				where TTrackingEvent : TrackingEvent
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/integrations/trackingEvents/{eventID}.</summary>
			public class PatchRouteParams
			{
				public string EventID { get; set; }
			}
		}
		public static class UserGroups
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups")]
			public class Create : WebhookPayload<UserGroup, UserGroup, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups")]
			public class Create<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, CreateRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Save : WebhookPayload<UserGroup, UserGroup, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Save<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, SaveRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Patch : WebhookPayload<UserGroup, UserGroup, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroup">Specific type of the UserGroup. If not using a custom type, specify UserGroup.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Patch<TConfigData, TUserGroup> : WebhookPayload<TUserGroup, TUserGroup, PatchRouteParams, TConfigData>
				where TUserGroup : UserGroup
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string UserGroupID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment : WebhookPayload<object, object, DeleteUserAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment<TConfigData> : WebhookPayload<object, object, DeleteUserAssignmentRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			public class DeleteUserAssignmentRouteParams
			{
				public string BuyerID { get; set; }
				public string UserGroupID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups/assignments")]
			public class SaveUserAssignment : WebhookPayload<UserGroupAssignment, object, SaveUserAssignmentRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups/assignments.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUserGroupAssignment">Specific type of the UserGroupAssignment. If not using a custom type, specify UserGroupAssignment.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups/assignments")]
			public class SaveUserAssignment<TConfigData, TUserGroupAssignment> : WebhookPayload<TUserGroupAssignment, object, SaveUserAssignmentRouteParams, TConfigData>
				where TUserGroupAssignment : UserGroupAssignment
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/assignments.</summary>
			public class SaveUserAssignmentRouteParams
			{
				public string BuyerID { get; set; }
			}
		}
		public static class Users
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users")]
			public class Create : WebhookPayload<User, User, CreateRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/users")]
			public class Create<TConfigData, TUser> : WebhookPayload<TUser, TUser, CreateRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users.</summary>
			public class CreateRouteParams
			{
				public string BuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/users/{userID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/users/{userID}")]
			public class Save : WebhookPayload<User, User, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/users/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("PUT", "v1/buyers/{buyerID}/users/{userID}")]
			public class Save<TConfigData, TUser> : WebhookPayload<TUser, TUser, SaveRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}.</summary>
			public class SaveRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/users/{userID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/users/{userID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/users/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/users/{userID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}.</summary>
			public class DeleteRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/users/{userID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/users/{userID}")]
			public class Patch : WebhookPayload<User, User, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/users/{userID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("PATCH", "v1/buyers/{buyerID}/users/{userID}")]
			public class Patch<TConfigData, TUser> : WebhookPayload<TUser, TUser, PatchRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}.</summary>
			public class PatchRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}")]
			public class Move : WebhookPayload<object, User, MoveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TUser">Specific type of the User. If not using a custom type, specify User.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}")]
			public class Move<TConfigData, TUser> : WebhookPayload<object, TUser, MoveRouteParams, TConfigData>
				where TUser : User
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}.</summary>
			public class MoveRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
				public string NewBuyerID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/accesstoken.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/accesstoken")]
			public class GetAccessToken : WebhookPayload<ImpersonateTokenRequest, AccessToken, GetAccessTokenRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/accesstoken.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TImpersonateTokenRequest">Specific type of the ImpersonateTokenRequest. If not using a custom type, specify ImpersonateTokenRequest.</typeparam>
			/// <typeparam name="TAccessToken">Specific type of the AccessToken. If not using a custom type, specify AccessToken.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/accesstoken")]
			public class GetAccessToken<TConfigData, TImpersonateTokenRequest, TAccessToken> : WebhookPayload<TImpersonateTokenRequest, TAccessToken, GetAccessTokenRouteParams, TConfigData>
				where TImpersonateTokenRequest : ImpersonateTokenRequest
				where TAccessToken : AccessToken
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}/accesstoken.</summary>
			public class GetAccessTokenRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/unlock.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/unlock")]
			public class UnlockUserAccount : WebhookPayload<object, object, UnlockUserAccountRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/unlock.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/unlock")]
			public class UnlockUserAccount<TConfigData> : WebhookPayload<object, object, UnlockUserAccountRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}/unlock.</summary>
			public class UnlockUserAccountRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/users/{userID}/tokens.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/users/{userID}/tokens")]
			public class RevokeUserTokens : WebhookPayload<object, object, RevokeUserTokensRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/users/{userID}/tokens.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/buyers/{buyerID}/users/{userID}/tokens")]
			public class RevokeUserTokens<TConfigData> : WebhookPayload<object, object, RevokeUserTokensRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}/tokens.</summary>
			public class RevokeUserTokensRouteParams
			{
				public string BuyerID { get; set; }
				public string UserID { get; set; }
			}
		}
		public static class Webhooks
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/webhooks.</summary>
			[SentOn("POST", "v1/webhooks")]
			public class Create : WebhookPayload<Webhook, Webhook, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/webhooks.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TWebhook">Specific type of the Webhook. If not using a custom type, specify Webhook.</typeparam>
			[SentOn("POST", "v1/webhooks")]
			public class Create<TConfigData, TWebhook> : WebhookPayload<TWebhook, TWebhook, object, TConfigData>
				where TWebhook : Webhook
			{ }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/webhooks/{webhookID}.</summary>
			[SentOn("PUT", "v1/webhooks/{webhookID}")]
			public class Save : WebhookPayload<Webhook, Webhook, SaveRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/webhooks/{webhookID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TWebhook">Specific type of the Webhook. If not using a custom type, specify Webhook.</typeparam>
			[SentOn("PUT", "v1/webhooks/{webhookID}")]
			public class Save<TConfigData, TWebhook> : WebhookPayload<TWebhook, TWebhook, SaveRouteParams, TConfigData>
				where TWebhook : Webhook
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/webhooks/{webhookID}.</summary>
			public class SaveRouteParams
			{
				public string WebhookID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/webhooks/{webhookID}.</summary>
			[SentOn("DELETE", "v1/webhooks/{webhookID}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/webhooks/{webhookID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/webhooks/{webhookID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/webhooks/{webhookID}.</summary>
			public class DeleteRouteParams
			{
				public string WebhookID { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/webhooks/{webhookID}.</summary>
			[SentOn("PATCH", "v1/webhooks/{webhookID}")]
			public class Patch : WebhookPayload<Webhook, Webhook, PatchRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/webhooks/{webhookID}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TWebhook">Specific type of the Webhook. If not using a custom type, specify Webhook.</typeparam>
			[SentOn("PATCH", "v1/webhooks/{webhookID}")]
			public class Patch<TConfigData, TWebhook> : WebhookPayload<TWebhook, TWebhook, PatchRouteParams, TConfigData>
				where TWebhook : Webhook
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/webhooks/{webhookID}.</summary>
			public class PatchRouteParams
			{
				public string WebhookID { get; set; }
			}
		}
		public static class XpIndices
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/xpindices/{thingType}/{key}.</summary>
			[SentOn("DELETE", "v1/xpindices/{thingType}/{key}")]
			public class Delete : WebhookPayload<object, object, DeleteRouteParams, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/xpindices/{thingType}/{key}.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, use the non-generic payload type instead.</typeparam>
			[SentOn("DELETE", "v1/xpindices/{thingType}/{key}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, DeleteRouteParams, TConfigData>
			{ }
			/// <summary>Type used to represent route parameter name/value pairs for v1/xpindices/{thingType}/{key}.</summary>
			public class DeleteRouteParams
			{
				public XpThingType ThingType { get; set; }
				public string Key { get; set; }
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/xpindices.</summary>
			[SentOn("PUT", "v1/xpindices")]
			public class Put : WebhookPayload<XpIndex, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/xpindices.</summary>
			/// <typeparam name="TConfigData">Specific type of the ConfigData. If not using a custom type, specify dynamic.</typeparam>
			/// <typeparam name="TXpIndex">Specific type of the XpIndex. If not using a custom type, specify XpIndex.</typeparam>
			[SentOn("PUT", "v1/xpindices")]
			public class Put<TConfigData, TXpIndex> : WebhookPayload<TXpIndex, object, object, TConfigData>
				where TXpIndex : XpIndex
			{ }
		}
	}
}
