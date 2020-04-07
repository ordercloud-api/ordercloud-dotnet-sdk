using System;

namespace OrderCloud.SDK
{
	public static class WebhookPayloads
	{
		public static class Addresses
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses")]
			public class Create : WebhookPayload<Address, Address, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses")]
			public class Create<TConfigData> : WebhookPayload<Address, Address, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Save : WebhookPayload<Address, Address, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Save<TConfigData> : WebhookPayload<Address, Address, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Patch : WebhookPayload<Address, Address, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/addresses/{addressID}")]
			public class Patch<TConfigData> : WebhookPayload<Address, Address, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/{addressID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string BuyerID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/addresses/{addressID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/addresses/{addressID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses/assignments")]
			public class SaveAssignment : WebhookPayload<AddressAssignment, object, SaveAssignment.SaveAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/addresses/assignments.</summary>
				public class SaveAssignmentRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/addresses/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/addresses/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<AddressAssignment, object, SaveAssignment.SaveAssignmentRouteParams, TConfigData> { }
		}
		public static class AdminAddresses
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/addresses.</summary>
			[SentOn("POST", "v1/addresses")]
			public class Create : WebhookPayload<Address, Address, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/addresses, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/addresses")]
			public class Create<TConfigData> : WebhookPayload<Address, Address, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/addresses/{addressID}")]
			public class Save : WebhookPayload<Address, Address, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/addresses/{addressID}.</summary>
				public class SaveRouteParams
				{
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/addresses/{addressID}")]
			public class Save<TConfigData> : WebhookPayload<Address, Address, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/addresses/{addressID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/addresses/{addressID}.</summary>
				public class DeleteRouteParams
				{
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/addresses/{addressID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/addresses/{addressID}")]
			public class Patch : WebhookPayload<Address, Address, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/addresses/{addressID}.</summary>
				public class PatchRouteParams
				{
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/addresses/{addressID}")]
			public class Patch<TConfigData> : WebhookPayload<Address, Address, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class AdminUserGroups
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups.</summary>
			[SentOn("POST", "v1/usergroups")]
			public class Create : WebhookPayload<UserGroup, UserGroup, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/usergroups")]
			public class Create<TConfigData> : WebhookPayload<UserGroup, UserGroup, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/usergroups/{userGroupID}.</summary>
			[SentOn("PUT", "v1/usergroups/{userGroupID}")]
			public class Save : WebhookPayload<UserGroup, UserGroup, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}.</summary>
				public class SaveRouteParams
				{
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/usergroups/{userGroupID}")]
			public class Save<TConfigData> : WebhookPayload<UserGroup, UserGroup, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}.</summary>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}.</summary>
				public class DeleteRouteParams
				{
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/usergroups/{userGroupID}.</summary>
			[SentOn("PATCH", "v1/usergroups/{userGroupID}")]
			public class Patch : WebhookPayload<UserGroup, UserGroup, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}.</summary>
				public class PatchRouteParams
				{
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/usergroups/{userGroupID}")]
			public class Patch<TConfigData> : WebhookPayload<UserGroup, UserGroup, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}/assignments/{userID}.</summary>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment : WebhookPayload<object, object, DeleteUserAssignment.DeleteUserAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/usergroups/{userGroupID}/assignments/{userID}.</summary>
				public class DeleteUserAssignmentRouteParams
				{
					public string UserGroupID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/usergroups/{userGroupID}/assignments/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment<TConfigData> : WebhookPayload<object, object, DeleteUserAssignment.DeleteUserAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups/assignments.</summary>
			[SentOn("POST", "v1/usergroups/assignments")]
			public class SaveUserAssignment : WebhookPayload<UserGroupAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/usergroups/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/usergroups/assignments")]
			public class SaveUserAssignment<TConfigData> : WebhookPayload<UserGroupAssignment, object, object, TConfigData> { }
		}
		public static class AdminUsers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/adminusers.</summary>
			[SentOn("POST", "v1/adminusers")]
			public class Create : WebhookPayload<User, User, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/adminusers, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/adminusers")]
			public class Create<TConfigData> : WebhookPayload<User, User, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/adminusers/{userID}.</summary>
			[SentOn("PUT", "v1/adminusers/{userID}")]
			public class Save : WebhookPayload<User, User, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}.</summary>
				public class SaveRouteParams
				{
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/adminusers/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/adminusers/{userID}")]
			public class Save<TConfigData> : WebhookPayload<User, User, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/adminusers/{userID}.</summary>
			[SentOn("DELETE", "v1/adminusers/{userID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}.</summary>
				public class DeleteRouteParams
				{
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/adminusers/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/adminusers/{userID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/adminusers/{userID}.</summary>
			[SentOn("PATCH", "v1/adminusers/{userID}")]
			public class Patch : WebhookPayload<User, User, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/adminusers/{userID}.</summary>
				public class PatchRouteParams
				{
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/adminusers/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/adminusers/{userID}")]
			public class Patch<TConfigData> : WebhookPayload<User, User, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class ApiClients
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients.</summary>
			[SentOn("POST", "v1/apiclients")]
			public class Create : WebhookPayload<ApiClient, ApiClient, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/apiclients")]
			public class Create<TConfigData> : WebhookPayload<ApiClient, ApiClient, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/apiclients/{apiClientID}.</summary>
			[SentOn("PUT", "v1/apiclients/{apiClientID}")]
			public class Save : WebhookPayload<ApiClient, ApiClient, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}.</summary>
				public class SaveRouteParams
				{
					public string ApiClientID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/apiclients/{apiClientID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/apiclients/{apiClientID}")]
			public class Save<TConfigData> : WebhookPayload<ApiClient, ApiClient, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/apiclients/{apiClientID}.</summary>
			[SentOn("DELETE", "v1/apiclients/{apiClientID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}.</summary>
				public class DeleteRouteParams
				{
					public string ApiClientID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/apiclients/{apiClientID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/apiclients/{apiClientID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/apiclients/{apiClientID}.</summary>
			[SentOn("PATCH", "v1/apiclients/{apiClientID}")]
			public class Patch : WebhookPayload<ApiClient, ApiClient, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/apiclients/{apiClientID}.</summary>
				public class PatchRouteParams
				{
					public string ApiClientID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/apiclients/{apiClientID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/apiclients/{apiClientID}")]
			public class Patch<TConfigData> : WebhookPayload<ApiClient, ApiClient, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients/assignments.</summary>
			[SentOn("POST", "v1/apiclients/assignments")]
			public class SaveAssignment : WebhookPayload<ApiClientAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/apiclients/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/apiclients/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<ApiClientAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteBuyerAssignment : WebhookPayload<object, object, DeleteBuyerAssignment.DeleteBuyerAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}.</summary>
				public class DeleteBuyerAssignmentRouteParams
				{
					public string ApiClientID { get; set; }
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteBuyerAssignment<TConfigData> : WebhookPayload<object, object, DeleteBuyerAssignment.DeleteBuyerAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteSupplierAssignment : WebhookPayload<object, object, DeleteSupplierAssignment.DeleteSupplierAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}.</summary>
				public class DeleteSupplierAssignmentRouteParams
				{
					public string ApiClientID { get; set; }
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/ApiClients/Assignments/{apiClientID}")]
			public class DeleteSupplierAssignment<TConfigData> : WebhookPayload<object, object, DeleteSupplierAssignment.DeleteSupplierAssignmentRouteParams, TConfigData> { }
		}
		public static class ApprovalRules
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/approvalrules.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/approvalrules")]
			public class Create : WebhookPayload<ApprovalRule, ApprovalRule, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/approvalrules, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/approvalrules")]
			public class Create<TConfigData> : WebhookPayload<ApprovalRule, ApprovalRule, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Save : WebhookPayload<ApprovalRule, ApprovalRule, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string ApprovalRuleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/approvalrules/{approvalRuleID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Save<TConfigData> : WebhookPayload<ApprovalRule, ApprovalRule, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string ApprovalRuleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/approvalrules/{approvalRuleID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Patch : WebhookPayload<ApprovalRule, ApprovalRule, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/approvalrules/{approvalRuleID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string ApprovalRuleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/approvalrules/{approvalRuleID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/approvalrules/{approvalRuleID}")]
			public class Patch<TConfigData> : WebhookPayload<ApprovalRule, ApprovalRule, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class Buyers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers.</summary>
			[SentOn("POST", "v1/buyers")]
			public class Create : WebhookPayload<Buyer, Buyer, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers")]
			public class Create<TConfigData> : WebhookPayload<Buyer, Buyer, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}")]
			public class Save : WebhookPayload<Buyer, Buyer, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}")]
			public class Save<TConfigData> : WebhookPayload<Buyer, Buyer, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}")]
			public class Patch : WebhookPayload<Buyer, Buyer, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}")]
			public class Patch<TConfigData> : WebhookPayload<Buyer, Buyer, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class Catalogs
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs.</summary>
			[SentOn("POST", "v1/catalogs")]
			public class Create : WebhookPayload<Catalog, Catalog, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/catalogs")]
			public class Create<TConfigData> : WebhookPayload<Catalog, Catalog, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}.</summary>
			[SentOn("PUT", "v1/catalogs/{catalogID}")]
			public class Save : WebhookPayload<Catalog, Catalog, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}.</summary>
				public class SaveRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/catalogs/{catalogID}")]
			public class Save<TConfigData> : WebhookPayload<Catalog, Catalog, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}.</summary>
				public class DeleteRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}.</summary>
			[SentOn("PATCH", "v1/catalogs/{catalogID}")]
			public class Patch : WebhookPayload<Catalog, Catalog, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}.</summary>
				public class PatchRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/catalogs/{catalogID}")]
			public class Patch<TConfigData> : WebhookPayload<Catalog, Catalog, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/assignments.</summary>
			[SentOn("POST", "v1/catalogs/assignments")]
			public class SaveAssignment : WebhookPayload<CatalogAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/catalogs/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<CatalogAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/assignments.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/productassignments.</summary>
			[SentOn("POST", "v1/catalogs/productassignments")]
			public class SaveProductAssignment : WebhookPayload<ProductCatalogAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/productassignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/catalogs/productassignments")]
			public class SaveProductAssignment<TConfigData> : WebhookPayload<ProductCatalogAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignment.DeleteProductAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/productassignments/{productID}.</summary>
				public class DeleteProductAssignmentRouteParams
				{
					public string CatalogID { get; set; }
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/productassignments/{productID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignment.DeleteProductAssignmentRouteParams, TConfigData> { }
		}
		public static class Categories
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories")]
			public class Create : WebhookPayload<Category, Category, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories.</summary>
				public class CreateRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories")]
			public class Create<TConfigData> : WebhookPayload<Category, Category, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			[SentOn("PUT", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Save : WebhookPayload<Category, Category, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
				public class SaveRouteParams
				{
					public string CatalogID { get; set; }
					public string CategoryID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/catalogs/{catalogID}/categories/{categoryID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Save<TConfigData> : WebhookPayload<Category, Category, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
				public class DeleteRouteParams
				{
					public string CatalogID { get; set; }
					public string CategoryID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
			[SentOn("PATCH", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Patch : WebhookPayload<Category, Category, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}.</summary>
				public class PatchRouteParams
				{
					public string CatalogID { get; set; }
					public string CategoryID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/catalogs/{catalogID}/categories/{categoryID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/catalogs/{catalogID}/categories/{categoryID}")]
			public class Patch<TConfigData> : WebhookPayload<Category, Category, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/assignments.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string CatalogID { get; set; }
					public string CategoryID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/assignments.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/assignments")]
			public class SaveAssignment : WebhookPayload<CategoryAssignment, object, SaveAssignment.SaveAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/assignments.</summary>
				public class SaveAssignmentRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<CategoryAssignment, object, SaveAssignment.SaveAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/productassignments.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/productassignments")]
			public class SaveProductAssignment : WebhookPayload<CategoryProductAssignment, object, SaveProductAssignment.SaveProductAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/productassignments.</summary>
				public class SaveProductAssignmentRouteParams
				{
					public string CatalogID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/catalogs/{catalogID}/categories/productassignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/catalogs/{catalogID}/categories/productassignments")]
			public class SaveProductAssignment<TConfigData> : WebhookPayload<CategoryProductAssignment, object, SaveProductAssignment.SaveProductAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignment.DeleteProductAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}.</summary>
				public class DeleteProductAssignmentRouteParams
				{
					public string CatalogID { get; set; }
					public string CategoryID { get; set; }
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/catalogs/{catalogID}/categories/{categoryID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignment.DeleteProductAssignmentRouteParams, TConfigData> { }
		}
		public static class CostCenters
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters")]
			public class Create : WebhookPayload<CostCenter, CostCenter, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters")]
			public class Create<TConfigData> : WebhookPayload<CostCenter, CostCenter, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Save : WebhookPayload<CostCenter, CostCenter, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string CostCenterID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/costcenters/{costCenterID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Save<TConfigData> : WebhookPayload<CostCenter, CostCenter, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string CostCenterID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Patch : WebhookPayload<CostCenter, CostCenter, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string CostCenterID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/costcenters/{costCenterID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/costcenters/{costCenterID}")]
			public class Patch<TConfigData> : WebhookPayload<CostCenter, CostCenter, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string BuyerID { get; set; }
					public string CostCenterID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/costcenters/{costCenterID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters/assignments")]
			public class SaveAssignment : WebhookPayload<CostCenterAssignment, object, SaveAssignment.SaveAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/costcenters/assignments.</summary>
				public class SaveAssignmentRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/costcenters/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/costcenters/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<CostCenterAssignment, object, SaveAssignment.SaveAssignmentRouteParams, TConfigData> { }
		}
		public static class CreditCards
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards")]
			public class Create : WebhookPayload<CreditCard, CreditCard, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards")]
			public class Create<TConfigData> : WebhookPayload<CreditCard, CreditCard, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Save : WebhookPayload<CreditCard, CreditCard, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string CreditCardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/creditcards/{creditCardID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Save<TConfigData> : WebhookPayload<CreditCard, CreditCard, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string CreditCardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Patch : WebhookPayload<CreditCard, CreditCard, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string CreditCardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/creditcards/{creditCardID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/creditcards/{creditCardID}")]
			public class Patch<TConfigData> : WebhookPayload<CreditCard, CreditCard, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards/assignments")]
			public class SaveAssignment : WebhookPayload<CreditCardAssignment, object, SaveAssignment.SaveAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/assignments.</summary>
				public class SaveAssignmentRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/creditcards/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/creditcards/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<CreditCardAssignment, object, SaveAssignment.SaveAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string BuyerID { get; set; }
					public string CreditCardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/creditcards/{creditCardID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
		}
		public static class ImpersonationConfigs
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/impersonationconfig.</summary>
			[SentOn("POST", "v1/impersonationconfig")]
			public class Create : WebhookPayload<ImpersonationConfig, ImpersonationConfig, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/impersonationconfig, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/impersonationconfig")]
			public class Create<TConfigData> : WebhookPayload<ImpersonationConfig, ImpersonationConfig, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/impersonationconfig/{impersonationConfigID}.</summary>
			[SentOn("DELETE", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/impersonationconfig/{impersonationConfigID}.</summary>
				public class DeleteRouteParams
				{
					public string ImpersonationConfigID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/impersonationconfig/{impersonationConfigID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/impersonationconfig/{impersonationConfigID}.</summary>
			[SentOn("PUT", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Save : WebhookPayload<ImpersonationConfig, ImpersonationConfig, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/impersonationconfig/{impersonationConfigID}.</summary>
				public class SaveRouteParams
				{
					public string ImpersonationConfigID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/impersonationconfig/{impersonationConfigID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Save<TConfigData> : WebhookPayload<ImpersonationConfig, ImpersonationConfig, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/impersonationconfig/{impersonationConfigID}.</summary>
			[SentOn("PATCH", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Patch : WebhookPayload<ImpersonationConfig, ImpersonationConfig, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/impersonationconfig/{impersonationConfigID}.</summary>
				public class PatchRouteParams
				{
					public string ImpersonationConfigID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/impersonationconfig/{impersonationConfigID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/impersonationconfig/{impersonationConfigID}")]
			public class Patch<TConfigData> : WebhookPayload<ImpersonationConfig, ImpersonationConfig, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class Incrementors
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/incrementors.</summary>
			[SentOn("POST", "v1/incrementors")]
			public class Create : WebhookPayload<Incrementor, Incrementor, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/incrementors, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/incrementors")]
			public class Create<TConfigData> : WebhookPayload<Incrementor, Incrementor, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/incrementors/{incrementorID}.</summary>
			[SentOn("PUT", "v1/incrementors/{incrementorID}")]
			public class Save : WebhookPayload<Incrementor, Incrementor, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/incrementors/{incrementorID}.</summary>
				public class SaveRouteParams
				{
					public string IncrementorID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/incrementors/{incrementorID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/incrementors/{incrementorID}")]
			public class Save<TConfigData> : WebhookPayload<Incrementor, Incrementor, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/incrementors/{incrementorID}.</summary>
			[SentOn("DELETE", "v1/incrementors/{incrementorID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/incrementors/{incrementorID}.</summary>
				public class DeleteRouteParams
				{
					public string IncrementorID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/incrementors/{incrementorID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/incrementors/{incrementorID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/incrementors/{incrementorID}.</summary>
			[SentOn("PATCH", "v1/incrementors/{incrementorID}")]
			public class Patch : WebhookPayload<Incrementor, Incrementor, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/incrementors/{incrementorID}.</summary>
				public class PatchRouteParams
				{
					public string IncrementorID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/incrementors/{incrementorID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/incrementors/{incrementorID}")]
			public class Patch<TConfigData> : WebhookPayload<Incrementor, Incrementor, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class IntegrationEvents
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrationEvents.</summary>
			[SentOn("POST", "v1/integrationEvents")]
			public class Create : WebhookPayload<IntegrationEvent, IntegrationEvent, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/integrationEvents, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/integrationEvents")]
			public class Create<TConfigData> : WebhookPayload<IntegrationEvent, IntegrationEvent, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrationEvents/{integrationEventID}.</summary>
			[SentOn("PUT", "v1/integrationEvents/{integrationEventID}")]
			public class Save : WebhookPayload<IntegrationEvent, IntegrationEvent, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/integrationEvents/{integrationEventID}.</summary>
				public class SaveRouteParams
				{
					public string IntegrationEventID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/integrationEvents/{integrationEventID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/integrationEvents/{integrationEventID}")]
			public class Save<TConfigData> : WebhookPayload<IntegrationEvent, IntegrationEvent, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrationEvents/{integrationEventID}.</summary>
			[SentOn("DELETE", "v1/integrationEvents/{integrationEventID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/integrationEvents/{integrationEventID}.</summary>
				public class DeleteRouteParams
				{
					public string IntegrationEventID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/integrationEvents/{integrationEventID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/integrationEvents/{integrationEventID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrationEvents/{integrationEventID}.</summary>
			[SentOn("PATCH", "v1/integrationEvents/{integrationEventID}")]
			public class Patch : WebhookPayload<IntegrationEvent, IntegrationEvent, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/integrationEvents/{integrationEventID}.</summary>
				public class PatchRouteParams
				{
					public string IntegrationEventID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/integrationEvents/{integrationEventID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/integrationEvents/{integrationEventID}")]
			public class Patch<TConfigData> : WebhookPayload<IntegrationEvent, IntegrationEvent, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/estimateshipping.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/estimateshipping")]
			public class EstimateShipping : WebhookPayload<object, OrderWorksheet, EstimateShipping.EstimateShippingRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/estimateshipping.</summary>
				public class EstimateShippingRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/estimateshipping, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/estimateshipping")]
			public class EstimateShipping<TConfigData> : WebhookPayload<object, OrderWorksheet, EstimateShipping.EstimateShippingRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/shipmethods.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/shipmethods")]
			public class SelectShipmethods : WebhookPayload<OrderShipMethodSelection, OrderWorksheet, SelectShipmethods.SelectShipmethodsRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/shipmethods.</summary>
				public class SelectShipmethodsRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/shipmethods, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/shipmethods")]
			public class SelectShipmethods<TConfigData> : WebhookPayload<OrderShipMethodSelection, OrderWorksheet, SelectShipmethods.SelectShipmethodsRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/calculate.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/calculate")]
			public class Calculate : WebhookPayload<object, OrderWorksheet, Calculate.CalculateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/calculate.</summary>
				public class CalculateRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/calculate, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/calculate")]
			public class Calculate<TConfigData> : WebhookPayload<object, OrderWorksheet, Calculate.CalculateRouteParams, TConfigData> { }
		}
		public static class LineItems
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/lineitems.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/lineitems")]
			public class Create : WebhookPayload<LineItem, LineItem, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems.</summary>
				public class CreateRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/lineitems, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/lineitems")]
			public class Create<TConfigData> : WebhookPayload<LineItem, LineItem, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Save : WebhookPayload<LineItem, LineItem, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
				public class SaveRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string LineItemID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Save<TConfigData> : WebhookPayload<LineItem, LineItem, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
				public class DeleteRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string LineItemID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/lineitems/{lineItemID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Patch : WebhookPayload<LineItem, LineItem, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}.</summary>
				public class PatchRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string LineItemID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}")]
			public class Patch<TConfigData> : WebhookPayload<LineItem, LineItem, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class SetShippingAddress : WebhookPayload<Address, LineItem, SetShippingAddress.SetShippingAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
				public class SetShippingAddressRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string LineItemID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class SetShippingAddress<TConfigData> : WebhookPayload<Address, LineItem, SetShippingAddress.SetShippingAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class PatchShippingAddress : WebhookPayload<Address, LineItem, PatchShippingAddress.PatchShippingAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto.</summary>
				public class PatchShippingAddressRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string LineItemID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/lineitems/{lineItemID}/shipto")]
			public class PatchShippingAddress<TConfigData> : WebhookPayload<Address, LineItem, PatchShippingAddress.PatchShippingAddressRouteParams, TConfigData> { }
		}
		public static class Me
		{
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me.</summary>
			[SentOn("PUT", "v1/me")]
			public class Save : WebhookPayload<MeUser, MeUser, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/me")]
			public class Save<TConfigData> : WebhookPayload<MeUser, MeUser, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me.</summary>
			[SentOn("PATCH", "v1/me")]
			public class Patch : WebhookPayload<MeUser, MeUser, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/me")]
			public class Patch<TConfigData> : WebhookPayload<MeUser, MeUser, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/addresses.</summary>
			[SentOn("POST", "v1/me/addresses")]
			public class CreateAddress : WebhookPayload<BuyerAddress, BuyerAddress, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/addresses, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/me/addresses")]
			public class CreateAddress<TConfigData> : WebhookPayload<BuyerAddress, BuyerAddress, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/me/addresses/{addressID}")]
			public class SaveAddress : WebhookPayload<BuyerAddress, BuyerAddress, SaveAddress.SaveAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/me/addresses/{addressID}.</summary>
				public class SaveAddressRouteParams
				{
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/me/addresses/{addressID}")]
			public class SaveAddress<TConfigData> : WebhookPayload<BuyerAddress, BuyerAddress, SaveAddress.SaveAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/me/addresses/{addressID}")]
			public class PatchAddress : WebhookPayload<BuyerAddress, object, PatchAddress.PatchAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/me/addresses/{addressID}.</summary>
				public class PatchAddressRouteParams
				{
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/me/addresses/{addressID}")]
			public class PatchAddress<TConfigData> : WebhookPayload<BuyerAddress, object, PatchAddress.PatchAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/me/addresses/{addressID}")]
			public class DeleteAddress : WebhookPayload<object, object, DeleteAddress.DeleteAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/me/addresses/{addressID}.</summary>
				public class DeleteAddressRouteParams
				{
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/me/addresses/{addressID}")]
			public class DeleteAddress<TConfigData> : WebhookPayload<object, object, DeleteAddress.DeleteAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/creditcards.</summary>
			[SentOn("POST", "v1/me/creditcards")]
			public class CreateCreditCard : WebhookPayload<BuyerCreditCard, BuyerCreditCard, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/creditcards, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/me/creditcards")]
			public class CreateCreditCard<TConfigData> : WebhookPayload<BuyerCreditCard, BuyerCreditCard, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/creditcards/{creditcardID}.</summary>
			[SentOn("PUT", "v1/me/creditcards/{creditcardID}")]
			public class SaveCreditCard : WebhookPayload<BuyerCreditCard, BuyerCreditCard, SaveCreditCard.SaveCreditCardRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/me/creditcards/{creditcardID}.</summary>
				public class SaveCreditCardRouteParams
				{
					public string CreditcardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/creditcards/{creditcardID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/me/creditcards/{creditcardID}")]
			public class SaveCreditCard<TConfigData> : WebhookPayload<BuyerCreditCard, BuyerCreditCard, SaveCreditCard.SaveCreditCardRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/creditcards/{creditcardID}.</summary>
			[SentOn("PATCH", "v1/me/creditcards/{creditcardID}")]
			public class PatchCreditCard : WebhookPayload<BuyerCreditCard, object, PatchCreditCard.PatchCreditCardRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/me/creditcards/{creditcardID}.</summary>
				public class PatchCreditCardRouteParams
				{
					public string CreditcardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/me/creditcards/{creditcardID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/me/creditcards/{creditcardID}")]
			public class PatchCreditCard<TConfigData> : WebhookPayload<BuyerCreditCard, object, PatchCreditCard.PatchCreditCardRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/creditcards/{creditcardID}.</summary>
			[SentOn("DELETE", "v1/me/creditcards/{creditcardID}")]
			public class DeleteCreditCard : WebhookPayload<object, object, DeleteCreditCard.DeleteCreditCardRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/me/creditcards/{creditcardID}.</summary>
				public class DeleteCreditCardRouteParams
				{
					public string CreditcardID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/me/creditcards/{creditcardID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/me/creditcards/{creditcardID}")]
			public class DeleteCreditCard<TConfigData> : WebhookPayload<object, object, DeleteCreditCard.DeleteCreditCardRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/register.</summary>
			[SentOn("PUT", "v1/me/register")]
			public class Register : WebhookPayload<MeUser, AccessTokenBasic, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/register, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/me/register")]
			public class Register<TConfigData> : WebhookPayload<MeUser, AccessTokenBasic, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/orders.</summary>
			[SentOn("PUT", "v1/me/orders")]
			public class TransferAnonUserOrder : WebhookPayload<object, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/me/orders, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/me/orders")]
			public class TransferAnonUserOrder<TConfigData> : WebhookPayload<object, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/password.</summary>
			[SentOn("POST", "v1/me/password")]
			public class ResetPasswordByToken : WebhookPayload<TokenPasswordReset, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/me/password, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/me/password")]
			public class ResetPasswordByToken<TConfigData> : WebhookPayload<TokenPasswordReset, object, object, TConfigData> { }
		}
		public static class MessageSenders
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders.</summary>
			[SentOn("POST", "v1/messagesenders")]
			public class Create : WebhookPayload<MessageSender, MessageSender, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/messagesenders")]
			public class Create<TConfigData> : WebhookPayload<MessageSender, MessageSender, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/messagesenders/{messageSenderID}.</summary>
			[SentOn("PUT", "v1/messagesenders/{messageSenderID}")]
			public class Save : WebhookPayload<MessageSender, MessageSender, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}.</summary>
				public class SaveRouteParams
				{
					public string MessageSenderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/messagesenders/{messageSenderID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/messagesenders/{messageSenderID}")]
			public class Save<TConfigData> : WebhookPayload<MessageSender, MessageSender, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}.</summary>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}.</summary>
				public class DeleteRouteParams
				{
					public string MessageSenderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/messagesenders/{messageSenderID}.</summary>
			[SentOn("PATCH", "v1/messagesenders/{messageSenderID}")]
			public class Patch : WebhookPayload<MessageSender, MessageSender, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}.</summary>
				public class PatchRouteParams
				{
					public string MessageSenderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/messagesenders/{messageSenderID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/messagesenders/{messageSenderID}")]
			public class Patch<TConfigData> : WebhookPayload<MessageSender, MessageSender, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}/assignments.</summary>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/messagesenders/{messageSenderID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string MessageSenderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/messagesenders/{messageSenderID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/messagesenders/{messageSenderID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/assignments.</summary>
			[SentOn("POST", "v1/messagesenders/assignments")]
			public class SaveAssignment : WebhookPayload<MessageSenderAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/messagesenders/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<MessageSenderAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/CCListenerAssignments.</summary>
			[SentOn("POST", "v1/messagesenders/CCListenerAssignments")]
			public class SaveCCListenerAssignment : WebhookPayload<MessageCCListenerAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/messagesenders/CCListenerAssignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/messagesenders/CCListenerAssignments")]
			public class SaveCCListenerAssignment<TConfigData> : WebhookPayload<MessageCCListenerAssignment, object, object, TConfigData> { }
		}
		public static class OpenIdConnects
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/openidconnects.</summary>
			[SentOn("POST", "v1/openidconnects")]
			public class Create : WebhookPayload<OpenIdConnect, OpenIdConnect, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/openidconnects, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/openidconnects")]
			public class Create<TConfigData> : WebhookPayload<OpenIdConnect, OpenIdConnect, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/openidconnects/{openidconnectID}.</summary>
			[SentOn("PUT", "v1/openidconnects/{openidconnectID}")]
			public class Save : WebhookPayload<OpenIdConnect, OpenIdConnect, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/openidconnects/{openidconnectID}.</summary>
				public class SaveRouteParams
				{
					public string OpenidconnectID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/openidconnects/{openidconnectID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/openidconnects/{openidconnectID}")]
			public class Save<TConfigData> : WebhookPayload<OpenIdConnect, OpenIdConnect, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/openidconnects/{openidconnectID}.</summary>
			[SentOn("DELETE", "v1/openidconnects/{openidconnectID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/openidconnects/{openidconnectID}.</summary>
				public class DeleteRouteParams
				{
					public string OpenidconnectID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/openidconnects/{openidconnectID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/openidconnects/{openidconnectID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/openidconnects/{openidconnectID}.</summary>
			[SentOn("PATCH", "v1/openidconnects/{openidconnectID}")]
			public class Patch : WebhookPayload<OpenIdConnect, OpenIdConnect, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/openidconnects/{openidconnectID}.</summary>
				public class PatchRouteParams
				{
					public string OpenidconnectID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/openidconnects/{openidconnectID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/openidconnects/{openidconnectID}")]
			public class Patch<TConfigData> : WebhookPayload<OpenIdConnect, OpenIdConnect, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class Orders
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}.</summary>
			[SentOn("POST", "v1/orders/{direction}")]
			public class Create : WebhookPayload<Order, Order, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}.</summary>
				public class CreateRouteParams
				{
					public OrderDirection Direction { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}")]
			public class Create<TConfigData> : WebhookPayload<Order, Order, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}")]
			public class Save : WebhookPayload<Order, Order, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}.</summary>
				public class SaveRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}")]
			public class Save<TConfigData> : WebhookPayload<Order, Order, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}.</summary>
				public class DeleteRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}")]
			public class Patch : WebhookPayload<Order, Order, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}.</summary>
				public class PatchRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}")]
			public class Patch<TConfigData> : WebhookPayload<Order, Order, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/submit.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/submit")]
			public class Submit : WebhookPayload<object, Order, Submit.SubmitRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/submit.</summary>
				public class SubmitRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/submit, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/submit")]
			public class Submit<TConfigData> : WebhookPayload<object, Order, Submit.SubmitRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/approve.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/approve")]
			public class Approve : WebhookPayload<OrderApprovalInfo, Order, Approve.ApproveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/approve.</summary>
				public class ApproveRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/approve, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/approve")]
			public class Approve<TConfigData> : WebhookPayload<OrderApprovalInfo, Order, Approve.ApproveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/decline.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/decline")]
			public class Decline : WebhookPayload<OrderApprovalInfo, Order, Decline.DeclineRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/decline.</summary>
				public class DeclineRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/decline, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/decline")]
			public class Decline<TConfigData> : WebhookPayload<OrderApprovalInfo, Order, Decline.DeclineRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/cancel.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/cancel")]
			public class Cancel : WebhookPayload<object, Order, Cancel.CancelRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/cancel.</summary>
				public class CancelRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/cancel, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/cancel")]
			public class Cancel<TConfigData> : WebhookPayload<object, Order, Cancel.CancelRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/split.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/split")]
			public class Split : WebhookPayload<object, OrderSplitResult, Split.SplitRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/split.</summary>
				public class SplitRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/split, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/split")]
			public class Split<TConfigData> : WebhookPayload<object, OrderSplitResult, Split.SplitRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/forward.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/forward")]
			public class Forward : WebhookPayload<object, OrderSplitResult, Forward.ForwardRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/forward.</summary>
				public class ForwardRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/forward, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/forward")]
			public class Forward<TConfigData> : WebhookPayload<object, OrderSplitResult, Forward.ForwardRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/complete.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/complete")]
			public class Complete : WebhookPayload<object, Order, Complete.CompleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/complete.</summary>
				public class CompleteRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/complete, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/complete")]
			public class Complete<TConfigData> : WebhookPayload<object, Order, Complete.CompleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/ship.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/ship")]
			public class Ship : WebhookPayload<Shipment, Order, Ship.ShipRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/ship.</summary>
				public class ShipRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/ship, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/ship")]
			public class Ship<TConfigData> : WebhookPayload<Shipment, Order, Ship.ShipRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/shipto.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/shipto")]
			public class SetShippingAddress : WebhookPayload<Address, Order, SetShippingAddress.SetShippingAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/shipto.</summary>
				public class SetShippingAddressRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/shipto, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/shipto")]
			public class SetShippingAddress<TConfigData> : WebhookPayload<Address, Order, SetShippingAddress.SetShippingAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/shipto.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/shipto")]
			public class PatchShippingAddress : WebhookPayload<Address, Order, PatchShippingAddress.PatchShippingAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/shipto.</summary>
				public class PatchShippingAddressRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/shipto, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/shipto")]
			public class PatchShippingAddress<TConfigData> : WebhookPayload<Address, Order, PatchShippingAddress.PatchShippingAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/billto.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/billto")]
			public class SetBillingAddress : WebhookPayload<Address, Order, SetBillingAddress.SetBillingAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/billto.</summary>
				public class SetBillingAddressRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/orders/{direction}/{orderID}/billto, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/orders/{direction}/{orderID}/billto")]
			public class SetBillingAddress<TConfigData> : WebhookPayload<Address, Order, SetBillingAddress.SetBillingAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/billto.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/billto")]
			public class PatchBillingAddress : WebhookPayload<Address, Order, PatchBillingAddress.PatchBillingAddressRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/billto.</summary>
				public class PatchBillingAddressRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/billto, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/billto")]
			public class PatchBillingAddress<TConfigData> : WebhookPayload<Address, Order, PatchBillingAddress.PatchBillingAddressRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/fromuser.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/fromuser")]
			public class PatchFromUser : WebhookPayload<User, Order, PatchFromUser.PatchFromUserRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/fromuser.</summary>
				public class PatchFromUserRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/fromuser, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/fromuser")]
			public class PatchFromUser<TConfigData> : WebhookPayload<User, Order, PatchFromUser.PatchFromUserRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class AddPromotion : WebhookPayload<object, OrderPromotion, AddPromotion.AddPromotionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
				public class AddPromotionRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string PromoCode { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/promotions/{promoCode}, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class AddPromotion<TConfigData> : WebhookPayload<object, OrderPromotion, AddPromotion.AddPromotionRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class RemovePromotion : WebhookPayload<object, Order, RemovePromotion.RemovePromotionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/promotions/{promoCode}.</summary>
				public class RemovePromotionRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string PromoCode { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/promotions/{promoCode}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/promotions/{promoCode}")]
			public class RemovePromotion<TConfigData> : WebhookPayload<object, Order, RemovePromotion.RemovePromotionRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/validate.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/validate")]
			public class Validate : WebhookPayload<object, object, Validate.ValidateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/validate.</summary>
				public class ValidateRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/validate, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/validate")]
			public class Validate<TConfigData> : WebhookPayload<object, object, Validate.ValidateRouteParams, TConfigData> { }
		}
		public static class PasswordResets
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/password/reset.</summary>
			[SentOn("POST", "v1/password/reset")]
			public class SendVerificationCode : WebhookPayload<PasswordResetRequest, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/password/reset, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/password/reset")]
			public class SendVerificationCode<TConfigData> : WebhookPayload<PasswordResetRequest, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/password/reset/{verificationCode}.</summary>
			[SentOn("PUT", "v1/password/reset/{verificationCode}")]
			public class ResetPasswordByVerificationCode : WebhookPayload<PasswordReset, object, ResetPasswordByVerificationCode.ResetPasswordByVerificationCodeRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/password/reset/{verificationCode}.</summary>
				public class ResetPasswordByVerificationCodeRouteParams
				{
					public string VerificationCode { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/password/reset/{verificationCode}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/password/reset/{verificationCode}")]
			public class ResetPasswordByVerificationCode<TConfigData> : WebhookPayload<PasswordReset, object, ResetPasswordByVerificationCode.ResetPasswordByVerificationCodeRouteParams, TConfigData> { }
		}
		public static class Payments
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments")]
			public class Create : WebhookPayload<Payment, Payment, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments.</summary>
				public class CreateRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments")]
			public class Create<TConfigData> : WebhookPayload<Payment, Payment, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
				public class DeleteRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string PaymentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Patch : WebhookPayload<Payment, Payment, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}.</summary>
				public class PatchRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string PaymentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/orders/{direction}/{orderID}/payments/{paymentID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/orders/{direction}/{orderID}/payments/{paymentID}")]
			public class Patch<TConfigData> : WebhookPayload<Payment, Payment, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions")]
			public class CreateTransaction : WebhookPayload<PaymentTransaction, Payment, CreateTransaction.CreateTransactionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions.</summary>
				public class CreateTransactionRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string PaymentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions")]
			public class CreateTransaction<TConfigData> : WebhookPayload<PaymentTransaction, Payment, CreateTransaction.CreateTransactionRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}")]
			public class DeleteTransaction : WebhookPayload<object, object, DeleteTransaction.DeleteTransactionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}.</summary>
				public class DeleteTransactionRouteParams
				{
					public OrderDirection Direction { get; set; }
					public string OrderID { get; set; }
					public string PaymentID { get; set; }
					public string TransactionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/orders/{direction}/{orderID}/payments/{paymentID}/transactions/{transactionID}")]
			public class DeleteTransaction<TConfigData> : WebhookPayload<object, object, DeleteTransaction.DeleteTransactionRouteParams, TConfigData> { }
		}
		public static class PriceSchedules
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules.</summary>
			[SentOn("POST", "v1/priceschedules")]
			public class Create : WebhookPayload<PriceSchedule, PriceSchedule, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/priceschedules")]
			public class Create<TConfigData> : WebhookPayload<PriceSchedule, PriceSchedule, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/priceschedules/{priceScheduleID}.</summary>
			[SentOn("PUT", "v1/priceschedules/{priceScheduleID}")]
			public class Save : WebhookPayload<PriceSchedule, PriceSchedule, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}.</summary>
				public class SaveRouteParams
				{
					public string PriceScheduleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/priceschedules/{priceScheduleID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/priceschedules/{priceScheduleID}")]
			public class Save<TConfigData> : WebhookPayload<PriceSchedule, PriceSchedule, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}.</summary>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}.</summary>
				public class DeleteRouteParams
				{
					public string PriceScheduleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/priceschedules/{priceScheduleID}.</summary>
			[SentOn("PATCH", "v1/priceschedules/{priceScheduleID}")]
			public class Patch : WebhookPayload<PriceSchedule, PriceSchedule, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}.</summary>
				public class PatchRouteParams
				{
					public string PriceScheduleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/priceschedules/{priceScheduleID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/priceschedules/{priceScheduleID}")]
			public class Patch<TConfigData> : WebhookPayload<PriceSchedule, PriceSchedule, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			[SentOn("POST", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class SavePriceBreak : WebhookPayload<PriceBreak, PriceSchedule, SavePriceBreak.SavePriceBreakRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
				public class SavePriceBreakRouteParams
				{
					public string PriceScheduleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/priceschedules/{priceScheduleID}/PriceBreaks, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class SavePriceBreak<TConfigData> : WebhookPayload<PriceBreak, PriceSchedule, SavePriceBreak.SavePriceBreakRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class DeletePriceBreak : WebhookPayload<object, object, DeletePriceBreak.DeletePriceBreakRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/priceschedules/{priceScheduleID}/PriceBreaks.</summary>
				public class DeletePriceBreakRouteParams
				{
					public string PriceScheduleID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/priceschedules/{priceScheduleID}/PriceBreaks, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/priceschedules/{priceScheduleID}/PriceBreaks")]
			public class DeletePriceBreak<TConfigData> : WebhookPayload<object, object, DeletePriceBreak.DeletePriceBreakRouteParams, TConfigData> { }
		}
		public static class ProductFacets
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/productfacets.</summary>
			[SentOn("POST", "v1/productfacets")]
			public class Create : WebhookPayload<ProductFacet, ProductFacet, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/productfacets, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/productfacets")]
			public class Create<TConfigData> : WebhookPayload<ProductFacet, ProductFacet, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/productfacets/{productFacetID}.</summary>
			[SentOn("PUT", "v1/productfacets/{productFacetID}")]
			public class Save : WebhookPayload<ProductFacet, ProductFacet, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/productfacets/{productFacetID}.</summary>
				public class SaveRouteParams
				{
					public string ProductFacetID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/productfacets/{productFacetID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/productfacets/{productFacetID}")]
			public class Save<TConfigData> : WebhookPayload<ProductFacet, ProductFacet, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/productfacets/{productFacetID}.</summary>
			[SentOn("DELETE", "v1/productfacets/{productFacetID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/productfacets/{productFacetID}.</summary>
				public class DeleteRouteParams
				{
					public string ProductFacetID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/productfacets/{productFacetID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/productfacets/{productFacetID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/productfacets/{productFacetID}.</summary>
			[SentOn("PATCH", "v1/productfacets/{productFacetID}")]
			public class Patch : WebhookPayload<ProductFacet, ProductFacet, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/productfacets/{productFacetID}.</summary>
				public class PatchRouteParams
				{
					public string ProductFacetID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/productfacets/{productFacetID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/productfacets/{productFacetID}")]
			public class Patch<TConfigData> : WebhookPayload<ProductFacet, ProductFacet, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class Products
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products.</summary>
			[SentOn("POST", "v1/products")]
			public class Create : WebhookPayload<Product, Product, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/products")]
			public class Create<TConfigData> : WebhookPayload<Product, Product, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}.</summary>
			[SentOn("PUT", "v1/products/{productID}")]
			public class Save : WebhookPayload<Product, Product, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}.</summary>
				public class SaveRouteParams
				{
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/products/{productID}")]
			public class Save<TConfigData> : WebhookPayload<Product, Product, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}.</summary>
				public class DeleteRouteParams
				{
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/products/{productID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}.</summary>
			[SentOn("PATCH", "v1/products/{productID}")]
			public class Patch : WebhookPayload<Product, Product, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}.</summary>
				public class PatchRouteParams
				{
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/products/{productID}")]
			public class Patch<TConfigData> : WebhookPayload<Product, Product, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/generate.</summary>
			[SentOn("POST", "v1/products/{productID}/variants/generate")]
			public class GenerateVariants : WebhookPayload<object, Product, GenerateVariants.GenerateVariantsRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/generate.</summary>
				public class GenerateVariantsRouteParams
				{
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/{productID}/variants/generate, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/products/{productID}/variants/generate")]
			public class GenerateVariants<TConfigData> : WebhookPayload<object, Product, GenerateVariants.GenerateVariantsRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/variants/{variantID}.</summary>
			[SentOn("PUT", "v1/products/{productID}/variants/{variantID}")]
			public class SaveVariant : WebhookPayload<Variant, Variant, SaveVariant.SaveVariantRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}.</summary>
				public class SaveVariantRouteParams
				{
					public string ProductID { get; set; }
					public string VariantID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/variants/{variantID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/products/{productID}/variants/{variantID}")]
			public class SaveVariant<TConfigData> : WebhookPayload<Variant, Variant, SaveVariant.SaveVariantRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/variants/{variantID}.</summary>
			[SentOn("PATCH", "v1/products/{productID}/variants/{variantID}")]
			public class PatchVariant : WebhookPayload<Variant, Variant, PatchVariant.PatchVariantRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/variants/{variantID}.</summary>
				public class PatchVariantRouteParams
				{
					public string ProductID { get; set; }
					public string VariantID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/products/{productID}/variants/{variantID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/products/{productID}/variants/{variantID}")]
			public class PatchVariant<TConfigData> : WebhookPayload<Variant, Variant, PatchVariant.PatchVariantRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/suppliers/{supplierID}.</summary>
			[SentOn("PUT", "v1/products/{productID}/suppliers/{supplierID}")]
			public class SaveSupplier : WebhookPayload<object, object, SaveSupplier.SaveSupplierRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/suppliers/{supplierID}.</summary>
				public class SaveSupplierRouteParams
				{
					public string ProductID { get; set; }
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/products/{productID}/suppliers/{supplierID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/products/{productID}/suppliers/{supplierID}")]
			public class SaveSupplier<TConfigData> : WebhookPayload<object, object, SaveSupplier.SaveSupplierRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/suppliers/{supplierID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}/suppliers/{supplierID}")]
			public class RemoveSupplier : WebhookPayload<object, object, RemoveSupplier.RemoveSupplierRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/suppliers/{supplierID}.</summary>
				public class RemoveSupplierRouteParams
				{
					public string ProductID { get; set; }
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/suppliers/{supplierID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/products/{productID}/suppliers/{supplierID}")]
			public class RemoveSupplier<TConfigData> : WebhookPayload<object, object, RemoveSupplier.RemoveSupplierRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/assignments.</summary>
			[SentOn("POST", "v1/products/assignments")]
			public class SaveAssignment : WebhookPayload<ProductAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/products/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/products/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<ProductAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/assignments/{buyerID}.</summary>
			[SentOn("DELETE", "v1/products/{productID}/assignments/{buyerID}")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/products/{productID}/assignments/{buyerID}.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string ProductID { get; set; }
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/products/{productID}/assignments/{buyerID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/products/{productID}/assignments/{buyerID}")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
		}
		public static class Promotions
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions.</summary>
			[SentOn("POST", "v1/promotions")]
			public class Create : WebhookPayload<Promotion, Promotion, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/promotions")]
			public class Create<TConfigData> : WebhookPayload<Promotion, Promotion, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/promotions/{promotionID}.</summary>
			[SentOn("PUT", "v1/promotions/{promotionID}")]
			public class Save : WebhookPayload<Promotion, Promotion, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}.</summary>
				public class SaveRouteParams
				{
					public string PromotionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/promotions/{promotionID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/promotions/{promotionID}")]
			public class Save<TConfigData> : WebhookPayload<Promotion, Promotion, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}.</summary>
			[SentOn("DELETE", "v1/promotions/{promotionID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}.</summary>
				public class DeleteRouteParams
				{
					public string PromotionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/promotions/{promotionID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/promotions/{promotionID}.</summary>
			[SentOn("PATCH", "v1/promotions/{promotionID}")]
			public class Patch : WebhookPayload<Promotion, Promotion, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}.</summary>
				public class PatchRouteParams
				{
					public string PromotionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/promotions/{promotionID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/promotions/{promotionID}")]
			public class Patch<TConfigData> : WebhookPayload<Promotion, Promotion, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions/assignments.</summary>
			[SentOn("POST", "v1/promotions/assignments")]
			public class SaveAssignment : WebhookPayload<PromotionAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/promotions/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/promotions/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<PromotionAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}/assignments.</summary>
			[SentOn("DELETE", "v1/promotions/{promotionID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/promotions/{promotionID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string PromotionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/promotions/{promotionID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/promotions/{promotionID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
		}
		public static class SecurityProfiles
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles.</summary>
			[SentOn("POST", "v1/securityprofiles")]
			public class Create : WebhookPayload<SecurityProfile, SecurityProfile, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/securityprofiles")]
			public class Create<TConfigData> : WebhookPayload<SecurityProfile, SecurityProfile, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/securityprofiles/{securityProfileID}.</summary>
			[SentOn("PUT", "v1/securityprofiles/{securityProfileID}")]
			public class Save : WebhookPayload<SecurityProfile, SecurityProfile, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}.</summary>
				public class SaveRouteParams
				{
					public string SecurityProfileID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/securityprofiles/{securityProfileID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/securityprofiles/{securityProfileID}")]
			public class Save<TConfigData> : WebhookPayload<SecurityProfile, SecurityProfile, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}.</summary>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}.</summary>
				public class DeleteRouteParams
				{
					public string SecurityProfileID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/securityprofiles/{securityProfileID}.</summary>
			[SentOn("PATCH", "v1/securityprofiles/{securityProfileID}")]
			public class Patch : WebhookPayload<SecurityProfile, SecurityProfile, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}.</summary>
				public class PatchRouteParams
				{
					public string SecurityProfileID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/securityprofiles/{securityProfileID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/securityprofiles/{securityProfileID}")]
			public class Patch<TConfigData> : WebhookPayload<SecurityProfile, SecurityProfile, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}/assignments.</summary>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/securityprofiles/{securityProfileID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string SecurityProfileID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/securityprofiles/{securityProfileID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/securityprofiles/{securityProfileID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles/assignments.</summary>
			[SentOn("POST", "v1/securityprofiles/assignments")]
			public class SaveAssignment : WebhookPayload<SecurityProfileAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/securityprofiles/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/securityprofiles/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<SecurityProfileAssignment, object, object, TConfigData> { }
		}
		public static class Shipments
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments.</summary>
			[SentOn("POST", "v1/shipments")]
			public class Create : WebhookPayload<Shipment, Shipment, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/shipments")]
			public class Create<TConfigData> : WebhookPayload<Shipment, Shipment, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}.</summary>
			[SentOn("PUT", "v1/shipments/{shipmentID}")]
			public class Save : WebhookPayload<Shipment, Shipment, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}.</summary>
				public class SaveRouteParams
				{
					public string ShipmentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/shipments/{shipmentID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/shipments/{shipmentID}")]
			public class Save<TConfigData> : WebhookPayload<Shipment, Shipment, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}.</summary>
			[SentOn("DELETE", "v1/shipments/{shipmentID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}.</summary>
				public class DeleteRouteParams
				{
					public string ShipmentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/shipments/{shipmentID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/shipments/{shipmentID}.</summary>
			[SentOn("PATCH", "v1/shipments/{shipmentID}")]
			public class Patch : WebhookPayload<Shipment, Shipment, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}.</summary>
				public class PatchRouteParams
				{
					public string ShipmentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/shipments/{shipmentID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/shipments/{shipmentID}")]
			public class Patch<TConfigData> : WebhookPayload<Shipment, Shipment, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments/{shipmentID}/items.</summary>
			[SentOn("POST", "v1/shipments/{shipmentID}/items")]
			public class SaveItem : WebhookPayload<ShipmentItem, ShipmentItem, SaveItem.SaveItemRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}/items.</summary>
				public class SaveItemRouteParams
				{
					public string ShipmentID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/shipments/{shipmentID}/items, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/shipments/{shipmentID}/items")]
			public class SaveItem<TConfigData> : WebhookPayload<ShipmentItem, ShipmentItem, SaveItem.SaveItemRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}.</summary>
			[SentOn("DELETE", "v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}")]
			public class DeleteItem : WebhookPayload<object, object, DeleteItem.DeleteItemRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}.</summary>
				public class DeleteItemRouteParams
				{
					public string ShipmentID { get; set; }
					public string OrderID { get; set; }
					public string LineItemID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/shipments/{shipmentID}/items/{orderID}/{lineItemID}")]
			public class DeleteItem<TConfigData> : WebhookPayload<object, object, DeleteItem.DeleteItemRouteParams, TConfigData> { }
		}
		public static class Specs
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs.</summary>
			[SentOn("POST", "v1/specs")]
			public class Create : WebhookPayload<Spec, Spec, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/specs")]
			public class Create<TConfigData> : WebhookPayload<Spec, Spec, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}.</summary>
			[SentOn("PUT", "v1/specs/{specID}")]
			public class Save : WebhookPayload<Spec, Spec, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}.</summary>
				public class SaveRouteParams
				{
					public string SpecID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/specs/{specID}")]
			public class Save<TConfigData> : WebhookPayload<Spec, Spec, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}.</summary>
			[SentOn("DELETE", "v1/specs/{specID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}.</summary>
				public class DeleteRouteParams
				{
					public string SpecID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/specs/{specID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}.</summary>
			[SentOn("PATCH", "v1/specs/{specID}")]
			public class Patch : WebhookPayload<Spec, Spec, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}.</summary>
				public class PatchRouteParams
				{
					public string SpecID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/specs/{specID}")]
			public class Patch<TConfigData> : WebhookPayload<Spec, Spec, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/productassignments/{productID}.</summary>
			[SentOn("DELETE", "v1/specs/{specID}/productassignments/{productID}")]
			public class DeleteProductAssignment : WebhookPayload<object, object, DeleteProductAssignment.DeleteProductAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/productassignments/{productID}.</summary>
				public class DeleteProductAssignmentRouteParams
				{
					public string SpecID { get; set; }
					public string ProductID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/productassignments/{productID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/specs/{specID}/productassignments/{productID}")]
			public class DeleteProductAssignment<TConfigData> : WebhookPayload<object, object, DeleteProductAssignment.DeleteProductAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/productassignments.</summary>
			[SentOn("POST", "v1/specs/productassignments")]
			public class SaveProductAssignment : WebhookPayload<SpecProductAssignment, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/productassignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/specs/productassignments")]
			public class SaveProductAssignment<TConfigData> : WebhookPayload<SpecProductAssignment, object, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/{specID}/options.</summary>
			[SentOn("POST", "v1/specs/{specID}/options")]
			public class CreateOption : WebhookPayload<SpecOption, SpecOption, CreateOption.CreateOptionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options.</summary>
				public class CreateOptionRouteParams
				{
					public string SpecID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/specs/{specID}/options, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/specs/{specID}/options")]
			public class CreateOption<TConfigData> : WebhookPayload<SpecOption, SpecOption, CreateOption.CreateOptionRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}/options/{optionID}.</summary>
			[SentOn("PUT", "v1/specs/{specID}/options/{optionID}")]
			public class SaveOption : WebhookPayload<SpecOption, SpecOption, SaveOption.SaveOptionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options/{optionID}.</summary>
				public class SaveOptionRouteParams
				{
					public string SpecID { get; set; }
					public string OptionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/specs/{specID}/options/{optionID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/specs/{specID}/options/{optionID}")]
			public class SaveOption<TConfigData> : WebhookPayload<SpecOption, SpecOption, SaveOption.SaveOptionRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}/options/{optionID}.</summary>
			[SentOn("PATCH", "v1/specs/{specID}/options/{optionID}")]
			public class PatchOption : WebhookPayload<SpecOption, SpecOption, PatchOption.PatchOptionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options/{optionID}.</summary>
				public class PatchOptionRouteParams
				{
					public string SpecID { get; set; }
					public string OptionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/specs/{specID}/options/{optionID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/specs/{specID}/options/{optionID}")]
			public class PatchOption<TConfigData> : WebhookPayload<SpecOption, SpecOption, PatchOption.PatchOptionRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/options/{optionID}.</summary>
			[SentOn("DELETE", "v1/specs/{specID}/options/{optionID}")]
			public class DeleteOption : WebhookPayload<object, object, DeleteOption.DeleteOptionRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/specs/{specID}/options/{optionID}.</summary>
				public class DeleteOptionRouteParams
				{
					public string SpecID { get; set; }
					public string OptionID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/specs/{specID}/options/{optionID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/specs/{specID}/options/{optionID}")]
			public class DeleteOption<TConfigData> : WebhookPayload<object, object, DeleteOption.DeleteOptionRouteParams, TConfigData> { }
		}
		public static class SpendingAccounts
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts")]
			public class Create : WebhookPayload<SpendingAccount, SpendingAccount, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts")]
			public class Create<TConfigData> : WebhookPayload<SpendingAccount, SpendingAccount, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Save : WebhookPayload<SpendingAccount, SpendingAccount, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string SpendingAccountID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Save<TConfigData> : WebhookPayload<SpendingAccount, SpendingAccount, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string SpendingAccountID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Patch : WebhookPayload<SpendingAccount, SpendingAccount, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string SpendingAccountID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}")]
			public class Patch<TConfigData> : WebhookPayload<SpendingAccount, SpendingAccount, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts/assignments")]
			public class SaveAssignment : WebhookPayload<SpendingAccountAssignment, object, SaveAssignment.SaveAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/assignments.</summary>
				public class SaveAssignmentRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/spendingaccounts/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/spendingaccounts/assignments")]
			public class SaveAssignment<TConfigData> : WebhookPayload<SpendingAccountAssignment, object, SaveAssignment.SaveAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments")]
			public class DeleteAssignment : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments.</summary>
				public class DeleteAssignmentRouteParams
				{
					public string BuyerID { get; set; }
					public string SpendingAccountID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/spendingaccounts/{spendingAccountID}/assignments")]
			public class DeleteAssignment<TConfigData> : WebhookPayload<object, object, DeleteAssignment.DeleteAssignmentRouteParams, TConfigData> { }
		}
		public static class SupplierAddresses
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/addresses.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/addresses")]
			public class Create : WebhookPayload<Address, Address, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses.</summary>
				public class CreateRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/addresses, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/addresses")]
			public class Create<TConfigData> : WebhookPayload<Address, Address, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Save : WebhookPayload<Address, Address, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
				public class SaveRouteParams
				{
					public string SupplierID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Save<TConfigData> : WebhookPayload<Address, Address, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
				public class DeleteRouteParams
				{
					public string SupplierID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Patch : WebhookPayload<Address, Address, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/addresses/{addressID}.</summary>
				public class PatchRouteParams
				{
					public string SupplierID { get; set; }
					public string AddressID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/addresses/{addressID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/addresses/{addressID}")]
			public class Patch<TConfigData> : WebhookPayload<Address, Address, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class Suppliers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers.</summary>
			[SentOn("POST", "v1/suppliers")]
			public class Create : WebhookPayload<Supplier, Supplier, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/suppliers")]
			public class Create<TConfigData> : WebhookPayload<Supplier, Supplier, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}.</summary>
				public class DeleteRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}")]
			public class Save : WebhookPayload<Supplier, Supplier, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}.</summary>
				public class SaveRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}")]
			public class Save<TConfigData> : WebhookPayload<Supplier, Supplier, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}")]
			public class Patch : WebhookPayload<Supplier, Supplier, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}.</summary>
				public class PatchRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}")]
			public class Patch<TConfigData> : WebhookPayload<Supplier, Supplier, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class SupplierUserGroups
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups")]
			public class Create : WebhookPayload<UserGroup, UserGroup, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups.</summary>
				public class CreateRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups")]
			public class Create<TConfigData> : WebhookPayload<UserGroup, UserGroup, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Save : WebhookPayload<UserGroup, UserGroup, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
				public class SaveRouteParams
				{
					public string SupplierID { get; set; }
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Save<TConfigData> : WebhookPayload<UserGroup, UserGroup, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
				public class DeleteRouteParams
				{
					public string SupplierID { get; set; }
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Patch : WebhookPayload<UserGroup, UserGroup, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}.</summary>
				public class PatchRouteParams
				{
					public string SupplierID { get; set; }
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/usergroups/{userGroupID}")]
			public class Patch<TConfigData> : WebhookPayload<UserGroup, UserGroup, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment : WebhookPayload<object, object, DeleteUserAssignment.DeleteUserAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
				public class DeleteUserAssignmentRouteParams
				{
					public string SupplierID { get; set; }
					public string UserGroupID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment<TConfigData> : WebhookPayload<object, object, DeleteUserAssignment.DeleteUserAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups/assignments.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups/assignments")]
			public class SaveUserAssignment : WebhookPayload<UserGroupAssignment, object, SaveUserAssignment.SaveUserAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/usergroups/assignments.</summary>
				public class SaveUserAssignmentRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/usergroups/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/usergroups/assignments")]
			public class SaveUserAssignment<TConfigData> : WebhookPayload<UserGroupAssignment, object, SaveUserAssignment.SaveUserAssignmentRouteParams, TConfigData> { }
		}
		public static class SupplierUsers
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/users")]
			public class Create : WebhookPayload<User, User, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users.</summary>
				public class CreateRouteParams
				{
					public string SupplierID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/users")]
			public class Create<TConfigData> : WebhookPayload<User, User, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/users/{userID}.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Save : WebhookPayload<User, User, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}.</summary>
				public class SaveRouteParams
				{
					public string SupplierID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/suppliers/{supplierID}/users/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Save<TConfigData> : WebhookPayload<User, User, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/users/{userID}.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}.</summary>
				public class DeleteRouteParams
				{
					public string SupplierID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/suppliers/{supplierID}/users/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/users/{userID}.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Patch : WebhookPayload<User, User, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}.</summary>
				public class PatchRouteParams
				{
					public string SupplierID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/suppliers/{supplierID}/users/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/suppliers/{supplierID}/users/{userID}")]
			public class Patch<TConfigData> : WebhookPayload<User, User, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users/{userID}/accesstoken.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/users/{userID}/accesstoken")]
			public class GetAccessToken : WebhookPayload<ImpersonateTokenRequest, AccessToken, GetAccessToken.GetAccessTokenRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/suppliers/{supplierID}/users/{userID}/accesstoken.</summary>
				public class GetAccessTokenRouteParams
				{
					public string SupplierID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/suppliers/{supplierID}/users/{userID}/accesstoken, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/suppliers/{supplierID}/users/{userID}/accesstoken")]
			public class GetAccessToken<TConfigData> : WebhookPayload<ImpersonateTokenRequest, AccessToken, GetAccessToken.GetAccessTokenRouteParams, TConfigData> { }
		}
		public static class UserGroups
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups")]
			public class Create : WebhookPayload<UserGroup, UserGroup, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups")]
			public class Create<TConfigData> : WebhookPayload<UserGroup, UserGroup, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Save : WebhookPayload<UserGroup, UserGroup, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Save<TConfigData> : WebhookPayload<UserGroup, UserGroup, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Patch : WebhookPayload<UserGroup, UserGroup, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string UserGroupID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/usergroups/{userGroupID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/usergroups/{userGroupID}")]
			public class Patch<TConfigData> : WebhookPayload<UserGroup, UserGroup, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment : WebhookPayload<object, object, DeleteUserAssignment.DeleteUserAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}.</summary>
				public class DeleteUserAssignmentRouteParams
				{
					public string BuyerID { get; set; }
					public string UserGroupID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/usergroups/{userGroupID}/assignments/{userID}")]
			public class DeleteUserAssignment<TConfigData> : WebhookPayload<object, object, DeleteUserAssignment.DeleteUserAssignmentRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups/assignments.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups/assignments")]
			public class SaveUserAssignment : WebhookPayload<UserGroupAssignment, object, SaveUserAssignment.SaveUserAssignmentRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/usergroups/assignments.</summary>
				public class SaveUserAssignmentRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/usergroups/assignments, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/usergroups/assignments")]
			public class SaveUserAssignment<TConfigData> : WebhookPayload<UserGroupAssignment, object, SaveUserAssignment.SaveUserAssignmentRouteParams, TConfigData> { }
		}
		public static class Users
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users")]
			public class Create : WebhookPayload<User, User, Create.CreateRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users.</summary>
				public class CreateRouteParams
				{
					public string BuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users")]
			public class Create<TConfigData> : WebhookPayload<User, User, Create.CreateRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/users/{userID}.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/users/{userID}")]
			public class Save : WebhookPayload<User, User, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}.</summary>
				public class SaveRouteParams
				{
					public string BuyerID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/buyers/{buyerID}/users/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/buyers/{buyerID}/users/{userID}")]
			public class Save<TConfigData> : WebhookPayload<User, User, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/users/{userID}.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/users/{userID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}.</summary>
				public class DeleteRouteParams
				{
					public string BuyerID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/buyers/{buyerID}/users/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/buyers/{buyerID}/users/{userID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/users/{userID}.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/users/{userID}")]
			public class Patch : WebhookPayload<User, User, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}.</summary>
				public class PatchRouteParams
				{
					public string BuyerID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/buyers/{buyerID}/users/{userID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/buyers/{buyerID}/users/{userID}")]
			public class Patch<TConfigData> : WebhookPayload<User, User, Patch.PatchRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}")]
			public class Move : WebhookPayload<object, User, Move.MoveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}.</summary>
				public class MoveRouteParams
				{
					public string BuyerID { get; set; }
					public string UserID { get; set; }
					public string NewBuyerID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/moveto/{newBuyerID}")]
			public class Move<TConfigData> : WebhookPayload<object, User, Move.MoveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/accesstoken.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/accesstoken")]
			public class GetAccessToken : WebhookPayload<ImpersonateTokenRequest, AccessToken, GetAccessToken.GetAccessTokenRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/buyers/{buyerID}/users/{userID}/accesstoken.</summary>
				public class GetAccessTokenRouteParams
				{
					public string BuyerID { get; set; }
					public string UserID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on POST v1/buyers/{buyerID}/users/{userID}/accesstoken, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/buyers/{buyerID}/users/{userID}/accesstoken")]
			public class GetAccessToken<TConfigData> : WebhookPayload<ImpersonateTokenRequest, AccessToken, GetAccessToken.GetAccessTokenRouteParams, TConfigData> { }
		}
		public static class Webhooks
		{
			/// <summary>Webhook payload sent by OrderCloud on POST v1/webhooks.</summary>
			[SentOn("POST", "v1/webhooks")]
			public class Create : WebhookPayload<Webhook, Webhook, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on POST v1/webhooks, with strongly typed ConfigData.</summary>
			[SentOn("POST", "v1/webhooks")]
			public class Create<TConfigData> : WebhookPayload<Webhook, Webhook, object, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/webhooks/{webhookID}.</summary>
			[SentOn("PUT", "v1/webhooks/{webhookID}")]
			public class Save : WebhookPayload<Webhook, Webhook, Save.SaveRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/webhooks/{webhookID}.</summary>
				public class SaveRouteParams
				{
					public string WebhookID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/webhooks/{webhookID}, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/webhooks/{webhookID}")]
			public class Save<TConfigData> : WebhookPayload<Webhook, Webhook, Save.SaveRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/webhooks/{webhookID}.</summary>
			[SentOn("DELETE", "v1/webhooks/{webhookID}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/webhooks/{webhookID}.</summary>
				public class DeleteRouteParams
				{
					public string WebhookID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/webhooks/{webhookID}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/webhooks/{webhookID}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/webhooks/{webhookID}.</summary>
			[SentOn("PATCH", "v1/webhooks/{webhookID}")]
			public class Patch : WebhookPayload<Webhook, Webhook, Patch.PatchRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/webhooks/{webhookID}.</summary>
				public class PatchRouteParams
				{
					public string WebhookID { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on PATCH v1/webhooks/{webhookID}, with strongly typed ConfigData.</summary>
			[SentOn("PATCH", "v1/webhooks/{webhookID}")]
			public class Patch<TConfigData> : WebhookPayload<Webhook, Webhook, Patch.PatchRouteParams, TConfigData> { }
		}
		public static class XpIndices
		{
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/xpindices/{thingType}/{key}.</summary>
			[SentOn("DELETE", "v1/xpindices/{thingType}/{key}")]
			public class Delete : WebhookPayload<object, object, Delete.DeleteRouteParams, dynamic>
			{
				/// <summary>Type used to represent route parameter name/value pairs for v1/xpindices/{thingType}/{key}.</summary>
				public class DeleteRouteParams
				{
					public XpThingType ThingType { get; set; }
					public string Key { get; set; }
				}
			}
			/// <summary>Webhook payload sent by OrderCloud on DELETE v1/xpindices/{thingType}/{key}, with strongly typed ConfigData.</summary>
			[SentOn("DELETE", "v1/xpindices/{thingType}/{key}")]
			public class Delete<TConfigData> : WebhookPayload<object, object, Delete.DeleteRouteParams, TConfigData> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/xpindices.</summary>
			[SentOn("PUT", "v1/xpindices")]
			public class Put : WebhookPayload<XpIndex, object, object, dynamic> { }
			/// <summary>Webhook payload sent by OrderCloud on PUT v1/xpindices, with strongly typed ConfigData.</summary>
			[SentOn("PUT", "v1/xpindices")]
			public class Put<TConfigData> : WebhookPayload<XpIndex, object, object, TConfigData> { }
		}
	}
}
