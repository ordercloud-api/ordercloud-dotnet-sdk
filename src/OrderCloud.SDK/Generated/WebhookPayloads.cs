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
		public static class PasswordResets
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
