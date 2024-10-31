using System;

namespace OrderCloud.SDK
{
	public static class ErrorCodes
	{
		/// <summary>Object not found.</summary>
		public const string NotFound = "NotFound";
		/// <summary>Model or property was invalid.</summary>
		public const string ValidationFailure = "ValidationFailure";
		/// <summary>An unknown error has occurred on the server.</summary>
		public const string ServerError = "ServerError";
		public static class Address
		{
			/// <summary>This Address is registered as public and cannot be edited by this endpoint.</summary>
			public const string CannotEditPublic = "Address.CannotEditPublic";
			/// <summary>The Order has no Shipping Address to update.</summary>
			public const string CannotUpdateNotFound = "Address.CannotUpdateNotFound";
			/// <summary>This Address is not assigned as a Shipping Address.</summary>
			public const string IsNotShippingAddress = "Address.IsNotShippingAddress";
			/// <summary>This Address is referenced on 1 or more InventoryRecords, you must delete or modify the InventoryRecords prior to deleting the address.</summary>
			public const string CannotDeleteInventoryRecordAddress = "Address.CannotDeleteInventoryRecordAddress";
		}
		public static class AddressAssignment
		{
			/// <summary>Cannot assign address without defining it as either a billing or a shipping address.</summary>
			public const string MustBeBillingOrShipping = "AddressAssignment.MustBeBillingOrShipping";
		}
		public static class Api
		{
			/// <summary>The API is down briefly for maintenance. Please try again in a few seconds.</summary>
			public const string Offline = "Api.Offline";
		}
		public static class ApiClient
		{
			/// <summary>The last full access client cannot be deleted.</summary>
			public const string CannotDeleteLastFullAccess = "ApiClient.CannotDeleteLastFullAccess";
			/// <summary>Invalid Client ID.</summary>
			public const string InvalidClientID = "ApiClient.InvalidClientID";
			/// <summary>Cannot delete API Client used by a Subscription Integration.</summary>
			public const string UsedByIntegration = "ApiClient.UsedByIntegration";
			/// <summary>Cannot delete API Client used by an impersonation config.</summary>
			public const string UsedByImpersonationConfig = "ApiClient.UsedByImpersonationConfig";
			/// <summary>IsAnonBuyer can be true only when a buyer user is set as the Default Context User.</summary>
			public const string RequiredNotAnonBuyer = "ApiClient.RequiredNotAnonBuyer";
		}
		public static class ApprovalRule
		{
			/// <summary>Cannot delete Approval Rule because it has pending Approvals.</summary>
			public const string CannotDeleteIfPending = "ApprovalRule.CannotDeleteIfPending";
			/// <summary>Not authorized to modify this Approval Rule.</summary>
			public const string CannotModify = "ApprovalRule.CannotModify";
		}
		public static class Auth
		{
			/// <summary>User's organization is not active.</summary>
			public const string CompanyNotActive = "Auth.CompanyNotActive";
			/// <summary>Client ID is not active.</summary>
			public const string ClientNotActive = "Auth.ClientNotActive";
			/// <summary>Invalid username or password.</summary>
			public const string InvalidUsernameOrPassword = "Auth.InvalidUsernameOrPassword";
			/// <summary>Both username and password are required.</summary>
			public const string UsernameAndPasswordRequired = "Auth.UsernameAndPasswordRequired";
			/// <summary>User does not have role(s) required to perform this action.</summary>
			public const string InsufficientRoles = "Auth.InsufficientRoles";
			/// <summary>invalid</summary>
			public const string OauthError = "Auth.OauthError";
			/// <summary>Expired Password.</summary>
			public const string PasswordExpired = "Auth.PasswordExpired";
			/// <summary>Marketplace is not active.</summary>
			public const string SellerNotActive = "Auth.SellerNotActive";
			/// <summary>User is not active.</summary>
			public const string UserNotActive = "Auth.UserNotActive";
			/// <summary>Reading and/or Administering certain resources is forbidden for certain user types regardless of role(s).</summary>
			public const string UserNotAuthorizedToAdmin = "Auth.UserNotAuthorizedToAdmin";
			/// <summary>User not found.</summary>
			public const string UserNotFound = "Auth.UserNotFound";
			/// <summary>Due to excessive login failures, this account has been locked.</summary>
			public const string LockedOut = "Auth.LockedOut";
			/// <summary>Password does not meet security requirements.</summary>
			public const string InsecurePassword = "Auth.InsecurePassword";
			/// <summary>Anonymous users are prohibited from performing these actions.</summary>
			public const string AnonUserProhibited = "Auth.AnonUserProhibited";
			/// <summary>The token provided is invalid. Please provide an anonymous user token and try again.</summary>
			public const string MustPassAnonUserToken = "Auth.MustPassAnonUserToken";
			/// <summary>Both clientID and email are required.</summary>
			public const string ClientIDAndEmailRequired = "Auth.ClientIDAndEmailRequired";
			/// <summary>The provided token has been revoked. Please re-authenticate.</summary>
			public const string TokenRevoked = "Auth.TokenRevoked";
		}
		public static class BillingAddress
		{
			/// <summary>Order does not have billing address to modify. Use PUT to create one.</summary>
			public const string CannotModifyNotFound = "BillingAddress.CannotModifyNotFound";
			/// <summary>Cannot PATCH a billing address that was set by ID. Either PATCH the saved address at /addresses/{{id}}, or PUT a complete address at /billto.</summary>
			public const string CannotPatchSetByID = "BillingAddress.CannotPatchSetByID";
		}
		public static class Bundle
		{
			/// <summary>Cannot assign a product to a bundle with a different OwnerID.</summary>
			public const string OwnerIDMustMatch = "Bundle.OwnerIDMustMatch";
			/// <summary>Cannot assign a child product to a bundle the parent proudct is already assigned to. Delete the parent product assignment to the bundle first.</summary>
			public const string ParentProductAssigned = "Bundle.ParentProductAssigned";
			/// <summary>Cannot assign a parent product to a bundle that child products are already assigned to. Delete the child product assignments to the bundle first.</summary>
			public const string ChildProductsAssigned = "Bundle.ChildProductsAssigned";
			/// <summary>This product is not assigned to the specified bundle.</summary>
			public const string ProductNotAssigned = "Bundle.ProductNotAssigned";
			/// <summary>One or more required bundle items is missing.</summary>
			public const string RequiredBundleItemMissing = "Bundle.RequiredBundleItemMissing";
			/// <summary>Default quantity is not specified for one or more required bundle items.</summary>
			public const string DefaultQuantityMissing = "Bundle.DefaultQuantityMissing";
		}
		public static class Buyer
		{
			/// <summary>You must provide the ID of the Buyer User you are creating the order on behalf of.</summary>
			public const string RequiredIDOnBehalf = "Buyer.RequiredIDOnBehalf";
			/// <summary>Buyer ID is require when API Client is for Anonymous Shopping.</summary>
			public const string RequiredIDWhenAnon = "Buyer.RequiredIDWhenAnon";
			/// <summary>User was not found in this Buyer company.</summary>
			public const string UserNotFound = "Buyer.UserNotFound";
			/// <summary>A Catalog with this ID already exists. Please either delete that catalog, or specify it as the DefaultCatalogID of this new Buyer in the request body.</summary>
			public const string DefaultCatalogAlreadyExists = "Buyer.DefaultCatalogAlreadyExists";
		}
		public static class BuyerAddress
		{
			/// <summary>Address must be defined as either a billing or a shipping address.</summary>
			public const string MustBeBillingOrShipping = "BuyerAddress.MustBeBillingOrShipping";
		}
		public static class Catalog
		{
			/// <summary>This catalog is a default catalog for one or more buyers and cannot currently be deleted.</summary>
			public const string CannotDelete = "Catalog.CannotDelete";
			/// <summary>Cannot edit this catalog.</summary>
			public const string CannotEdit = "Catalog.CannotEdit";
			/// <summary>The Catalog is not active.</summary>
			public const string NotActive = "Catalog.NotActive";
			/// <summary>Cannot assign product to this catalog. Product must be owned by the Marketplace Owner or the Catalog owner.</summary>
			public const string CannotAssignProduct = "Catalog.CannotAssignProduct";
			/// <summary>Cannot assign a child product to a catalog.</summary>
			public const string CannotAssignChildProduct = "Catalog.CannotAssignChildProduct";
		}
		public static class Category
		{
			/// <summary>Cannot assign this parent ID. Circular reference detected.</summary>
			public const string CircularReference = "Category.CircularReference";
			/// <summary>Depth must be an integer greater than 0, or 'all'.</summary>
			public const string InvalidDepth = "Category.InvalidDepth";
			/// <summary>Buyer not specified.</summary>
			public const string NoBuyer = "Category.NoBuyer";
			/// <summary>Cannot assign a child product to a category in a catalog different from parent one.</summary>
			public const string CannotAssignChildProduct = "Category.CannotAssignChildProduct";
		}
		public static class CreditCard
		{
			/// <summary>This Credit Card is registered as public and cannot be edited by this endpoint.</summary>
			public const string CannotEditPublic = "CreditCard.CannotEditPublic";
		}
		public static class DeliveryConfig
		{
			/// <summary>This Delivery Configuration cannot be deleted because it is in use.</summary>
			public const string CannotDeleteConfigInUse = "DeliveryConfig.CannotDeleteConfigInUse";
			/// <summary>The requested synchronization cannot be performed because the associated delivery configuration is disabled.</summary>
			public const string ConfigurationDisabled = "DeliveryConfig.ConfigurationDisabled";
		}
		public static class EntitySyncConfig
		{
			/// <summary>Only one entity sync per entity type can be configured for a marketplace.</summary>
			public const string OnlyOneConfigPerMarketplace = "EntitySyncConfig.OnlyOneConfigPerMarketplace";
		}
		public static class ErrorConfig
		{
			/// <summary>The error or validation message cannot be sent because the associated delivery configuration is disabled.</summary>
			public const string DeliveryConfigDisabled = "ErrorConfig.DeliveryConfigDisabled";
		}
		public static class Expression
		{
			/// <summary>Function has invalid number of arguments.</summary>
			public const string InvalidArguments = "Expression.InvalidArguments";
			/// <summary>Expression contains unknown function.</summary>
			public const string InvalidFunction = "Expression.InvalidFunction";
			/// <summary>Expression syntax is not valid.</summary>
			public const string InvalidSyntax = "Expression.InvalidSyntax";
			/// <summary>Expression contains invalid token.</summary>
			public const string InvalidToken = "Expression.InvalidToken";
			/// <summary>Order-level rule cannot contain 'item' token.</summary>
			public const string ItemNotAllowed = "Expression.ItemNotAllowed";
			/// <summary>This expression must contain 'item' token.</summary>
			public const string ItemRequired = "Expression.ItemRequired";
			/// <summary>Using order history in expressions requires premium order search to be enabled.</summary>
			public const string OrderHistoryCannotBeUsed = "Expression.OrderHistoryCannotBeUsed";
		}
		public static class Impersonation
		{
			/// <summary>Invalid ApiClient. Not a buyer network and CompanyID is null.</summary>
			public const string BadApiClient = "Impersonation.BadApiClient";
			/// <summary>API client is for a Buyer Network with no default Buyer, and a Buyer ID was not provided.</summary>
			public const string BuyerNetworkBuyerIDRequired = "Impersonation.BuyerNetworkBuyerIDRequired";
			/// <summary>Cannot delete a group or user assigned to an ImpersonationConfig.</summary>
			public const string CannotDeleteImpersonateeParty = "Impersonation.CannotDeleteImpersonateeParty";
			/// <summary>Cannot delete a security profile assigned to an ImpersonationConfig.</summary>
			public const string CannotDeleteSecurityProfile = "Impersonation.CannotDeleteSecurityProfile";
			/// <summary>Client ID not found or you do not have access to it.</summary>
			public const string ClientIDNotFound = "Impersonation.ClientIDNotFound";
			/// <summary>Buyer is not assigned to the API client.</summary>
			public const string BuyerNotAssigned = "Impersonation.BuyerNotAssigned";
			/// <summary>No Impersonation Config exists for the requested Buyer ID and API client ID or there are no roles assigned to the SecurityProfile. Check your configuration and try again.</summary>
			public const string ConfigError = "Impersonation.ConfigError";
		}
		public static class ImpersonationConfig
		{
			/// <summary>An ImpersonationConfig already exists for this combination of ApiClient, SecurityProfile, Impersonator, and Impersonatee.</summary>
			public const string ConflictingImpersonationConfigExists = "ImpersonationConfig.ConflictingImpersonationConfigExists";
		}
		public static class IntegrationEvent
		{
			/// <summary>This ApiClient does not have an order calculate event configured.</summary>
			public const string ApiClientNotConfiguredForOrderCalculate = "IntegrationEvent.ApiClientNotConfiguredForOrderCalculate";
			/// <summary>The IntegrationEvent cannot be deleted because it is in use.</summary>
			public const string CannotDeleteInUse = "IntegrationEvent.CannotDeleteInUse";
			/// <summary>The EventType can't be changed once the event is created.</summary>
			public const string CannotEditType = "IntegrationEvent.CannotEditType";
			/// <summary>The referenced IntegrationEvent must reference an IntegrationEvent with the correct EventType.</summary>
			public const string IncompatibleEventType = "IntegrationEvent.IncompatibleEventType";
			/// <summary>Something went wrong when we called your integration event, check your custom code and try again.</summary>
			public const string BadRequest = "IntegrationEvent.BadRequest";
			/// <summary>IntegrationEvents require at least one ApiClient to be configured with AllowSeller = true in order to generate an elevated role token.</summary>
			public const string AllowSellerApiClientRequired = "IntegrationEvent.AllowSellerApiClientRequired";
			/// <summary>You must estimate shipping costs prior to setting your shipping method.</summary>
			public const string MustCalculateShipping = "IntegrationEvent.MustCalculateShipping";
			/// <summary>There are no ShipEstimates in your ShipEstimateResponse. Estimate Shipping needs to return at least one ShipEstimate before saving a shipping method.</summary>
			public const string MustHaveShipEstimates = "IntegrationEvent.MustHaveShipEstimates";
		}
		public static class Inventory
		{
			/// <summary>Insufficient inventory for this product.</summary>
			public const string Insufficient = "Inventory.Insufficient";
			/// <summary>Inventory must be enabled for this product.</summary>
			public const string MustEnable = "Inventory.MustEnable";
		}
		public static class InventoryConfiguration
		{
			/// <summary>Cannot change VariantLevelTracking when InventoryRecords exist for the product.</summary>
			public const string CannotChangeVariantLevelTracking = "InventoryConfiguration.CannotChangeVariantLevelTracking";
			/// <summary>Cannot set VariantLevelTracking for parent or child products.</summary>
			public const string CannotSetVariantLevelTracking = "InventoryConfiguration.CannotSetVariantLevelTracking";
			/// <summary>Conflicting InventoryRecords exist for the product. You can only have product InventoryRecords, or variant InventoryRecords.</summary>
			public const string CannotCreateInventoryRecord = "InventoryConfiguration.CannotCreateInventoryRecord";
			/// <summary>This product does not have inventory configured. Please add inventory to the product and try again.</summary>
			public const string ProductInventoryMustExist = "InventoryConfiguration.ProductInventoryMustExist";
			/// <summary>Product.Inventory.VariantLevelTracking must be false in order to create InventoryRecords at the product level, and true in order to create InventoryRecords at the variant level.</summary>
			public const string InvalidVariantLevelTracking = "InventoryConfiguration.InvalidVariantLevelTracking";
		}
		public static class InventoryRecord
		{
			/// <summary>Cannot delete an InventoryRecord referenced on a line item from an open order, or an order pending approval.</summary>
			public const string OpenOrdersExist = "InventoryRecord.OpenOrdersExist";
		}
		public static class LineItem
		{
			/// <summary>Cannot change the Product ID of an existing Line Item.</summary>
			public const string CannotChangeProductID = "LineItem.CannotChangeProductID";
			/// <summary>Line Item does not have a Shipping Address to modify. Use PUT to create one.</summary>
			public const string CannotPatchShippingAddressIfMissing = "LineItem.CannotPatchShippingAddressIfMissing";
			/// <summary>DateNeeded must be greater than DateAdded.</summary>
			public const string DateNeededMustBeGreaterThanDateAdded = "LineItem.DateNeededMustBeGreaterThanDateAdded";
			/// <summary>Line Item's Quantity must be greater than 0.</summary>
			public const string QuantityMustBePositive = "LineItem.QuantityMustBePositive";
			/// <summary>Variant not found based on Specs provided.</summary>
			public const string VariantNotFound = "LineItem.VariantNotFound";
			/// <summary>This Seller (Order.ToCompanyID) does not supply this product.</summary>
			public const string ProductNotAvailableFromSeller = "LineItem.ProductNotAvailableFromSeller";
			/// <summary>Sorting by line item across orders is not currently supported. First sort field must be at the order level, such as Order.ID or Order.DateSubmitted.</summary>
			public const string MustSortByOrderFirst = "LineItem.MustSortByOrderFirst";
			/// <summary>Filtering by an order field OR line item field is not currently supported. You may only AND them together.</summary>
			public const string CannotFilterByOrderOrLineItem = "LineItem.CannotFilterByOrderOrLineItem";
			/// <summary>Searching by both order field(s) and a line item field(s) is not currently supported.</summary>
			public const string CannotSearchByOrderOrLineItem = "LineItem.CannotSearchByOrderOrLineItem";
			/// <summary>Parent product is not purchasable.</summary>
			public const string CannotPurchaseParentProduct = "LineItem.CannotPurchaseParentProduct";
			/// <summary>Bundle is not purchasable.</summary>
			public const string CannotPurchaseBundleProduct = "LineItem.CannotPurchaseBundleProduct";
			/// <summary>Cannot delete a bundle using this endpoint.</summary>
			public const string CannotRemoveBundle = "LineItem.CannotRemoveBundle";
			/// <summary>Cannot delete a bundle item using this endpoint.</summary>
			public const string CannotRemoveBundleItem = "LineItem.CannotRemoveBundleItem";
			/// <summary>Required bundle item cannot be removed.</summary>
			public const string CannotRemoveRequiredBundleItem = "LineItem.CannotRemoveRequiredBundleItem";
		}
		public static class List
		{
			/// <summary>pageSize is not valid.</summary>
			public const string InvalidPageSize = "List.InvalidPageSize";
			/// <summary>Property does not exist.</summary>
			public const string InvalidProperty = "List.InvalidProperty";
			/// <summary>Property is not searchable.</summary>
			public const string InvalidSearchProperty = "List.InvalidSearchProperty";
			/// <summary>Property is not sortable.</summary>
			public const string InvalidSortProperty = "List.InvalidSortProperty";
			/// <summary>Value passed is not valid for property type.</summary>
			public const string InvalidType = "List.InvalidType";
		}
		public static class Locale
		{
			/// <summary>You are allowed only a single language/currency combination per marketplace.</summary>
			public const string DuplicateLanguageAndCurrency = "Locale.DuplicateLanguageAndCurrency";
		}
		public static class MessageSenders
		{
			/// <summary>Url is required when no delivery configuration is specified.</summary>
			public const string UrlRequired = "MessageSenders.UrlRequired";
			/// <summary>SharedKey is required when no delivery configuration is specified.</summary>
			public const string SharedKeyRequired = "MessageSenders.SharedKeyRequired";
		}
		public static class Order
		{
			/// <summary>Order search index is being built. Please try again later.</summary>
			public const string CacheBuilding = "Order.CacheBuilding";
			/// <summary>Cannot cancel an order with the status of Open or Completed.</summary>
			public const string CannotCancelInCurrentStatus = "Order.CannotCancelInCurrentStatus";
			/// <summary>Cannot complete an order with this status. Order status must be Open.</summary>
			public const string CannotCompleteBadStatus = "Order.CannotCompleteBadStatus";
			/// <summary>Cannot create order. Invalid or missing JSON body.</summary>
			public const string CannotCreateInvalid = "Order.CannotCreateInvalid";
			/// <summary>Cannot ship order with this status. Order status must be Open.</summary>
			public const string CannotShipBadStatus = "Order.CannotShipBadStatus";
			/// <summary>Cannot ship an order without any line items.</summary>
			public const string CannotShipWithNoLineItems = "Order.CannotShipWithNoLineItems";
			/// <summary>Can only split and forward incoming orders.</summary>
			public const string CannotSplitOutgoing = "Order.CannotSplitOutgoing";
			/// <summary>Only Seller users can split and forward orders.</summary>
			public const string CannotSplitWrongUserType = "Order.CannotSplitWrongUserType";
			/// <summary>Cannot submit order with this status. Order status must be Unsubmitted.</summary>
			public const string CannotSubmitBadStatus = "Order.CannotSubmitBadStatus";
			/// <summary>Cannot submit an order that has not called the OrderCalculate step of the checkout integration.</summary>
			public const string CannotSubmitUncalculatedOrder = "Order.CannotSubmitUncalculatedOrder";
			/// <summary>Cannot submit an order without any line items.</summary>
			public const string CannotSubmitWithNoLineItems = "Order.CannotSubmitWithNoLineItems";
			/// <summary>Cannot submit an order with payments that have not been Accepted.</summary>
			public const string CannotSubmitWithUnaccceptedPayments = "Order.CannotSubmitWithUnaccceptedPayments";
			/// <summary>Cannot submit an order with not purchasable parent product.</summary>
			public const string CannotSubmitWithParentProduct = "Order.CannotSubmitWithParentProduct";
			/// <summary>Cannot submit an order with an inactive product.</summary>
			public const string CannotSubmitWithInactiveProduct = "Order.CannotSubmitWithInactiveProduct";
			/// <summary>Cannot submit an order because the following products are not accessible any more.</summary>
			public const string ProductsNotFound = "Order.ProductsNotFound";
			/// <summary>Cannot ship full order because it contains line items that are on other shipments. The returned data contains these conflicting line items.</summary>
			public const string ConflictsWithOtherShipments = "Order.ConflictsWithOtherShipments";
			/// <summary>To create an incoming order, you must provide both FromCompanyID and FromUserID.</summary>
			public const string CreateIncomingRequiresFromUser = "Order.CreateIncomingRequiresFromUser";
			/// <summary>Cannot process order with given status. Order status must be AwaitingApproval.</summary>
			public const string MustBeAwaitingApproval = "Order.MustBeAwaitingApproval";
			/// <summary>You are not eligible to approve this order.</summary>
			public const string NotEligibleToApprove = "Order.NotEligibleToApprove";
			/// <summary>User must have OverrideShipping permission to change shipping cost. Either PATCH the user's assigned SecurityProfile or assign them to a new one to give them the required permissions.</summary>
			public const string OverrideShippingPermission = "Order.OverrideShippingPermission";
			/// <summary>User must have OverrideTax permission to change tax cost. Either PATCH the user's assigned SecurityProfile or assign them to a new one to give them the required permissions.</summary>
			public const string OverrideTaxPermission = "Order.OverrideTaxPermission";
			/// <summary>Cannot delete an order that has been forwarded without first deleting the associated outgoing orders.</summary>
			public const string CannotDeleteForwardedOrder = "Order.CannotDeleteForwardedOrder";
			/// <summary>The user's assigned Locale Currency must match the Order's Currency.</summary>
			public const string CurrencyMismatch = "Order.CurrencyMismatch";
			/// <summary>This beta feature is available for enabled marketplaces only. Please contact your Sitecore OrderCloud sales or support rep.</summary>
			public const string SearchNotEnabled = "Order.SearchNotEnabled";
			/// <summary>This feature is not available for unsubmitted orders.</summary>
			public const string AllowedOnSubmittedOnly = "Order.AllowedOnSubmittedOnly";
			/// <summary>You cannot request both submitted and unsubmitted orders in the same list.</summary>
			public const string CannotMixSubmittedAndUnsubmitted = "Order.CannotMixSubmittedAndUnsubmitted";
			/// <summary>Order status must be Unsubmitted or Awaiting Approval to apply a promotion.</summary>
			public const string CannotApplyPromoBadStatus = "Order.CannotApplyPromoBadStatus";
		}
		public static class OrderReturn
		{
			/// <summary>The quantity requested exceeds the quantity eligible to return.</summary>
			public const string ItemQuantityExceeded = "OrderReturn.ItemQuantityExceeded";
			/// <summary>Cannot create an OrderReturn for an order with this status. Order status must be Open or Complete.</summary>
			public const string CannotCreateBadOrderStatus = "OrderReturn.CannotCreateBadOrderStatus";
			/// <summary>Only OrderAdmins are authorized to delete or cancel completed OrderReturns.</summary>
			public const string NotAuthorizedToDelete = "OrderReturn.NotAuthorizedToDelete";
			/// <summary>Cannot cancel an unsubmitted OrderReturn, please delete instead.</summary>
			public const string CannotCancelUnsubmitted = "OrderReturn.CannotCancelUnsubmitted";
			/// <summary>Cannot complete an order return with this status. OrderReturn status must be Open.</summary>
			public const string CannotCompleteBadStatus = "OrderReturn.CannotCompleteBadStatus";
			/// <summary>Cannot submit an order return with no refund amount.</summary>
			public const string CannotCompleteNoRefund = "OrderReturn.CannotCompleteNoRefund";
			/// <summary>Product is not eligible to return.</summary>
			public const string ProductNotEligibleToReturn = "OrderReturn.ProductNotEligibleToReturn";
			/// <summary>OrderReturn payment value must be negative.</summary>
			public const string PaymentValueMustBeNegative = "OrderReturn.PaymentValueMustBeNegative";
			/// <summary>The total of the refunds for this OrderReturn cannot exceed the RefundAmount.</summary>
			public const string TotalRefundsExceedRefundAmount = "OrderReturn.TotalRefundsExceedRefundAmount";
			/// <summary>Cannot create a payment for an OrderReturn with this status. OrderReturn Status must be Open.</summary>
			public const string CannotCreatePaymentBadStatus = "OrderReturn.CannotCreatePaymentBadStatus";
			/// <summary>You are not eligible to approve or decline this order return.</summary>
			public const string NotEligibleToApproveOrDecline = "OrderReturn.NotEligibleToApproveOrDecline";
			/// <summary>LineItemID must be unique across ItemsToReturn.</summary>
			public const string CannotCreateDuplicateItemToReturn = "OrderReturn.CannotCreateDuplicateItemToReturn";
			/// <summary>RefundAmount must not be negative.</summary>
			public const string RefundAmountMustNotBeNegative = "OrderReturn.RefundAmountMustNotBeNegative";
		}
		public static class OrderSync
		{
			/// <summary>The supplied date range was invalid.</summary>
			public const string InvalidDateRangeForSyncOperation = "OrderSync.InvalidDateRangeForSyncOperation";
		}
		public static class OrderSyncConfig
		{
			/// <summary>Only one order sync can be configured for a marketplace.</summary>
			public const string OnlyOneConfigPerMarketplace = "OrderSyncConfig.OnlyOneConfigPerMarketplace";
		}
		public static class PartyAssignment
		{
			/// <summary>Cannot provide both a BuyerID and SupplierID.</summary>
			public const string CannotProvideBuyerAndSupplier = "PartyAssignment.CannotProvideBuyerAndSupplier";
			/// <summary>Cannot specify both a BuyerID and a SupplierID.</summary>
			public const string CannotSpecifyBuyerAndSupplier = "PartyAssignment.CannotSpecifyBuyerAndSupplier";
			/// <summary>Cannot specify both a UserID and a GroupID.</summary>
			public const string CannotSpecifyGroupAndUser = "PartyAssignment.CannotSpecifyGroupAndUser";
			/// <summary>Group-level assignments not allowed for this object.</summary>
			public const string GroupLevelNotAllowed = "PartyAssignment.GroupLevelNotAllowed";
			/// <summary>Bad parameters. Do not provide a Group ID with this Level.</summary>
			public const string InvalidGroupLevel = "PartyAssignment.InvalidGroupLevel";
			/// <summary>Bad parameters. Do not provide a User ID with this Level.</summary>
			public const string InvalidUserLevel = "PartyAssignment.InvalidUserLevel";
			/// <summary>Must specify Buyer ID with this assignment.</summary>
			public const string RequiresBuyer = "PartyAssignment.RequiresBuyer";
			/// <summary>User-level assignments not allowed for this object.</summary>
			public const string UserLevelNotAllowed = "PartyAssignment.UserLevelNotAllowed";
		}
		public static class PasswordReset
		{
			/// <summary>The supplied password is one of the previous passwords used by this account and may not be reused.</summary>
			public const string CannotReusePassword = "PasswordReset.CannotReusePassword";
			/// <summary>Password does not meet security requirements.</summary>
			public const string InsecurePassword = "PasswordReset.InsecurePassword";
			/// <summary>Incorrect verification code or username.</summary>
			public const string InvalidVerification = "PasswordReset.InvalidVerification";
			/// <summary>Due to excessive login failures, this account has been locked.</summary>
			public const string LockedOut = "PasswordReset.LockedOut";
			/// <summary>ClientID is missing or invalid.</summary>
			public const string MissingOrInvalidClientID = "PasswordReset.MissingOrInvalidClientID";
			/// <summary>Username is required.</summary>
			public const string MissingUsername = "PasswordReset.MissingUsername";
			/// <summary>Username or Email is required.</summary>
			public const string MissingUsernameOrEmail = "PasswordReset.MissingUsernameOrEmail";
			/// <summary>The password cannot be changed until MinimumPasswordAge has expired since the password was last changed.</summary>
			public const string TooSoonToChange = "PasswordReset.TooSoonToChange";
		}
		public static class Payment
		{
			/// <summary>Cannot create Payment. Order is already fully paid.</summary>
			public const string AlreadyPaid = "Payment.AlreadyPaid";
			/// <summary>Cannot add or edit a payment on a canceled order.</summary>
			public const string CannotEditCancelled = "Payment.CannotEditCancelled";
			/// <summary>You are not authorized to modify the Accepted property.</summary>
			public const string CannotPatchAccepted = "Payment.CannotPatchAccepted";
			/// <summary>Payment Type, SpendingAccountID, and CreditCardID are not modifiable properties on a payment.</summary>
			public const string CannotPatchProperty = "Payment.CannotPatchProperty";
			/// <summary>Cannot have CreditCardID set on Payment of of this type. If you are trying to assign a CreditCard, make sure the Payment's Type is "CreditCard".</summary>
			public const string CannotSetCreditCard = "Payment.CannotSetCreditCard";
			/// <summary>Cannot have SpendingAccountID set on Payment of of this type. If you are trying to assign a SpendingAccount, make sure the Payment's Type is "SpendingAccount".</summary>
			public const string CannotSetSpendingAccount = "Payment.CannotSetSpendingAccount";
			/// <summary>Cannot use an expired spending account for payments.</summary>
			public const string CannotUseExpiredSpendingAccount = "Payment.CannotUseExpiredSpendingAccount";
			/// <summary>Payment exceeds Spending Account balance.</summary>
			public const string ExceedsBalance = "Payment.ExceedsBalance";
			/// <summary>Invalid SpendingAccountID.</summary>
			public const string InvalidSpendingAccountID = "Payment.InvalidSpendingAccountID";
			/// <summary>You are not authorized to modify Accepted payments on submitted orders, or payments with the type of CreditCard.</summary>
			public const string NotAuthorizedToPatch = "Payment.NotAuthorizedToPatch";
			/// <summary>You must include a corresponding ID when creating a payment of type SpendingAccount.</summary>
			public const string SpendingAccountIdMissing = "Payment.SpendingAccountIdMissing";
			/// <summary>You cannot delete a Spending Account that has been used as a Payment.</summary>
			public const string CannotDeleteSpendingAccount = "Payment.CannotDeleteSpendingAccount";
			/// <summary>When creating a payment Amount must be null or greater than zero.</summary>
			public const string AmountGreaterThanZero = "Payment.AmountGreaterThanZero";
		}
		public static class PriceSchedule
		{
			/// <summary>Quantity given cannot be lower than the minimum as per price schedule restrictions.</summary>
			public const string CannotBeLessThanMin = "PriceSchedule.CannotBeLessThanMin";
			/// <summary>Cannot clear all price breaks on this price schedule because it has assignments. This would lead to a user seeing a product with an invalid price. Instead, try deleting the whole price schedule.</summary>
			public const string CannotClearPriceBreaks = "PriceSchedule.CannotClearPriceBreaks";
			/// <summary>Cannot delete the last price break because this price schedule has assignments. Otherwise this would lead to a user seeing a product with an invalid or non-existing price.</summary>
			public const string CannotDeleteLastPriceBreak = "PriceSchedule.CannotDeleteLastPriceBreak";
			/// <summary>Quantity given cannot exceed the maximum as per price schedule restrictions.</summary>
			public const string CannotExceedMax = "PriceSchedule.CannotExceedMax";
			/// <summary>Cannot modify Currency of a Price Schedule that has assignments.</summary>
			public const string CannotModifyCurrency = "PriceSchedule.CannotModifyCurrency";
			/// <summary>Price breaks array cannot contain duplicate quantity values.</summary>
			public const string DuplicatePriceBreaks = "PriceSchedule.DuplicatePriceBreaks";
			/// <summary>Max Quantity must be greater than or equal to min quantity.</summary>
			public const string MinGreaterThanMax = "PriceSchedule.MinGreaterThanMax";
			/// <summary>Price schedule needs to have a price break with quantity of one or greater.</summary>
			public const string MinQtyMustBePositive = "PriceSchedule.MinQtyMustBePositive";
			/// <summary>You cannot add this Product to this Order. Price Schedule assigment is missing or associated with a conflicting order type.</summary>
			public const string MissingOrConflicting = "PriceSchedule.MissingOrConflicting";
			/// <summary>This Price Schedule must have at least one price break before it can be assigned to a product.</summary>
			public const string NoPriceBreaks = "PriceSchedule.NoPriceBreaks";
			/// <summary>The price schedule does not contain a price break with the given quantity.</summary>
			public const string QtyNotFound = "PriceSchedule.QtyNotFound";
			/// <summary>Quantity not allowed as per price schedule restrictions.</summary>
			public const string QuantityNotAllowed = "PriceSchedule.QuantityNotAllowed";
			/// <summary>Cumulative quantity given cannot be lower than the minimum as per price schedule restrictions.</summary>
			public const string CumulativeCannotBeLessThanMin = "PriceSchedule.CumulativeCannotBeLessThanMin";
			/// <summary>Cumulative quantity given cannot exceed the maximum as per price schedule restrictions.</summary>
			public const string CumulativeCannotExceedMax = "PriceSchedule.CumulativeCannotExceedMax";
			/// <summary>Cumulative quantity not allowed as per price schedule restrictions.</summary>
			public const string CumulativeQuantityNotAllowed = "PriceSchedule.CumulativeQuantityNotAllowed";
			/// <summary>Not authorized to modify this PriceSchedule.</summary>
			public const string CannotModify = "PriceSchedule.CannotModify";
			/// <summary>The DefaultPriceScheduleID for a given product supplier must be owned by the Marketplace Owner or the Supplier.</summary>
			public const string InvalidDefaultPriceScheduleID = "PriceSchedule.InvalidDefaultPriceScheduleID";
			/// <summary>The party's assigned Locale must match the Price Schedule's Currency.</summary>
			public const string CurrencyMismatch = "PriceSchedule.CurrencyMismatch";
			/// <summary>The SaleStart DateTime must be before the SaleEnd DateTime.</summary>
			public const string InvalidSaleStartOrSaleEnd = "PriceSchedule.InvalidSaleStartOrSaleEnd";
		}
		public static class Product
		{
			/// <summary>Product search index is being built. Please try again later.</summary>
			public const string CacheBuilding = "Product.CacheBuilding";
			/// <summary>Product cannot be assigned directly to Buyer (or User or Group) because it is not in a Catalog that the Buyer can access.</summary>
			public const string CannotAssignNotInBuyerCatalog = "Product.CannotAssignNotInBuyerCatalog";
			/// <summary>Not authorized to modify this Product.</summary>
			public const string CannotModify = "Product.CannotModify";
			/// <summary>Filtering products on a CategoryID requires a corresponding non-negated CatalogID.</summary>
			public const string CategoryFilterRequiresCatalogID = "Product.CategoryFilterRequiresCatalogID";
			/// <summary>Cannot set inventory. Inventory tracking for this product is not enabled.</summary>
			public const string InventoryDisabled = "Product.InventoryDisabled";
			/// <summary>Product assignment must include a Price Schedule or a Buyer/User/Group.</summary>
			public const string RequiresPriceScheduleOrBuyer = "Product.RequiresPriceScheduleOrBuyer";
			/// <summary>Only the Marketplace Owner can modify AllSuppliersCanSell on their owned products.</summary>
			public const string CannotModifyAllSuppliersCanSell = "Product.CannotModifyAllSuppliersCanSell";
			/// <summary>IsParent cannot be set to false if a child product exists.</summary>
			public const string CannotModifyIsParent = "Product.CannotModifyIsParent";
			/// <summary>IsParent cannot be set to true for a variant product.</summary>
			public const string CannotModifyIsParentForVariant = "Product.CannotModifyIsParentForVariant";
			/// <summary>ParentID cannot be set for a variant product.</summary>
			public const string CannotModifyParentIDForVariant = "Product.CannotModifyParentIDForVariant";
			/// <summary>Parent product ParentID is not null or IsParent false.</summary>
			public const string IsNotParent = "Product.IsNotParent";
			/// <summary>Parent product cannot have a parent.</summary>
			public const string ParentProductCannotHaveParent = "Product.ParentProductCannotHaveParent";
			/// <summary>Parent product cannot be deleted if a child product exists.</summary>
			public const string CannotDeleteParentProduct = "Product.CannotDeleteParentProduct";
			/// <summary>Parent and child products should have the same owner.</summary>
			public const string ParentChildProductOwnersShouldMatch = "Product.ParentChildProductOwnersShouldMatch";
			/// <summary>Parent and child products cannot have variants.</summary>
			public const string ParentChildProductsCannotHaveVariants = "Product.ParentChildProductsCannotHaveVariants";
			/// <summary>Bundle cannot have variants.</summary>
			public const string BundleProductCannotHaveVariants = "Product.BundleProductCannotHaveVariants";
			/// <summary>Parent product cannot be a bundle.</summary>
			public const string ParentProductCannotBeABundle = "Product.ParentProductCannotBeABundle";
			/// <summary>Cannot delete a product assigned to bundle.</summary>
			public const string CannotDeleteProductAssingedToBundle = "Product.CannotDeleteProductAssingedToBundle";
		}
		public static class ProductAssigment
		{
			/// <summary>The marketplace owner can create product assignments and designate a SellerID, but only when a PriceScheduleID is also provided. Use the designated endpoints to create a relationship between a Seller and a Product or a Seller and a Buyer.</summary>
			public const string MustSpecifyPriceScheduleID = "ProductAssigment.MustSpecifyPriceScheduleID";
			/// <summary>Spec that defines a variant cannot be assigned to a parent/child product.</summary>
			public const string ParentChildProductCannotBeAssignedToVariantSpec = "ProductAssigment.ParentChildProductCannotBeAssignedToVariantSpec";
			/// <summary>Spec that defines a variant cannot be assigned to a bundle.</summary>
			public const string BundleProductCannotBeAssignedToVariantSpec = "ProductAssigment.BundleProductCannotBeAssignedToVariantSpec";
		}
		public static class ProductCollection
		{
			/// <summary>Cannot exceed 500 product entries per Product Collection.</summary>
			public const string ProductEntryLimit = "ProductCollection.ProductEntryLimit";
			/// <summary>You cannot accept or decline an invitation to a ProductCollection you own.</summary>
			public const string CannotAcceptOrDeclineOwnInvitation = "ProductCollection.CannotAcceptOrDeclineOwnInvitation";
			/// <summary>You have already accepted an invitation to this product collection.</summary>
			public const string AlreadyAcceptedInvitation = "ProductCollection.AlreadyAcceptedInvitation";
			/// <summary>Not authorized to modify this Product Collection.</summary>
			public const string CannotModify = "ProductCollection.CannotModify";
		}
		public static class ProductFacet
		{
			/// <summary>This XpPath is already in use on another facet, it needs to be unique across a marketplace.</summary>
			public const string XpPathInUse = "ProductFacet.XpPathInUse";
		}
		public static class ProductSyncConfig
		{
			/// <summary>Only one product sync can be configured for a marketplace.</summary>
			public const string OnlyOneConfigPerMarketplace = "ProductSyncConfig.OnlyOneConfigPerMarketplace";
			/// <summary>The requested operation is not available because an administrative lock has been placed on product synchronization for this marketplace. Please contact support.</summary>
			public const string AdminLockout = "ProductSyncConfig.AdminLockout";
		}
		public static class Promotion
		{
			/// <summary>Promotion has already been added to this order.</summary>
			public const string AlreadyAdded = "Promotion.AlreadyAdded";
			/// <summary>Promotion cannot be combined with any other promo on the same order.</summary>
			public const string CannotCombine = "Promotion.CannotCombine";
			/// <summary>This code is already in use on another promotion.</summary>
			public const string CodeInUse = "Promotion.CodeInUse";
			/// <summary>Promotion code has already been used.</summary>
			public const string ExceedsUsageLimit = "Promotion.ExceedsUsageLimit";
			/// <summary>Promotion ExpirationDate cannot be earlier than StartDate.</summary>
			public const string ExpirationPrecedsStart = "Promotion.ExpirationPrecedsStart";
			/// <summary>Promotion is expired.</summary>
			public const string Expired = "Promotion.Expired";
			/// <summary>Promotion cannot be used on this order.</summary>
			public const string NotEligible = "Promotion.NotEligible";
			/// <summary>Promotion is not yet valid.</summary>
			public const string NotYetValid = "Promotion.NotYetValid";
			/// <summary>ToCompanyID represents a Supplier. Only promotions with a matching OwnerID or owned by the marketplace owner may be applied to this order.</summary>
			public const string OwnerIDMustMatchOrderToCompanyID = "Promotion.OwnerIDMustMatchOrderToCompanyID";
			/// <summary>Promotion is not active.</summary>
			public const string NotActive = "Promotion.NotActive";
			/// <summary>LineItemLevel must be true in order to use ItemLimitPerOrder.</summary>
			public const string CannotSetItemLimitPerOrder = "Promotion.CannotSetItemLimitPerOrder";
			/// <summary>LineItemLevel must be true in order to use QuantityLimitPerOrder.</summary>
			public const string CannotSetQuantityLimitPerOrder = "Promotion.CannotSetQuantityLimitPerOrder";
			/// <summary>QuantityLimitPerOrder is not supported in conjuction with ItemLimitPerOrder.</summary>
			public const string CannotSetQuantityAndItemLimitPerOrder = "Promotion.CannotSetQuantityAndItemLimitPerOrder";
			/// <summary>LineItemLevel must be true and ItemLimitPerOrder must have a value in order to use ItemSortBy.</summary>
			public const string CannotSetItemSortBy = "Promotion.CannotSetItemSortBy";
			/// <summary>Either set a ValueExpression, or define ValidatePromotion event for your client.</summary>
			public const string ValueExpressionCannotBeNull = "Promotion.ValueExpressionCannotBeNull";
			/// <summary>ValueExpression can be null only if UseIntegration is true.</summary>
			public const string ValueExpressionCanBeNullIfUseIntegration = "Promotion.ValueExpressionCanBeNullIfUseIntegration";
			/// <summary>UseIntegration must be false if ValueExpression is not null.</summary>
			public const string UseIntegrationMustBeFalse = "Promotion.UseIntegrationMustBeFalse";
		}
		public static class PromotionIntegration
		{
			/// <summary>Failed to evaluate integration promotion.</summary>
			public const string FailedToEvaluate = "PromotionIntegration.FailedToEvaluate";
			/// <summary>Promotion integration returned the error.</summary>
			public const string EvaluationErrorReturned = "PromotionIntegration.EvaluationErrorReturned";
			/// <summary>Cannot delete a promotion integration if promotions exist where ValueExpression = null.</summary>
			public const string CannotDeletePromotionIntegration = "PromotionIntegration.CannotDeletePromotionIntegration";
			/// <summary>PromotionID in the response does not match any PromosRequested ID in the Promotion Integration payload.</summary>
			public const string PromotionIDMismatch = "PromotionIntegration.PromotionIDMismatch";
			/// <summary>LineItemId is required for LineItemLevel promotion.</summary>
			public const string LineItemIdRequired = "PromotionIntegration.LineItemIdRequired";
			/// <summary>LineItemId must be null for not LineItemLevel promotion.</summary>
			public const string LineItemIdMustBeNull = "PromotionIntegration.LineItemIdMustBeNull";
			/// <summary>Promotion cannot be used on this order.</summary>
			public const string NotEligible = "PromotionIntegration.NotEligible";
		}
		public static class Registration
		{
			/// <summary>Email address or verification code not found.</summary>
			public const string InvalidVerificationCode = "Registration.InvalidVerificationCode";
		}
		public static class Request
		{
			/// <summary>Invalid content type. Please use x-www-form-urlencoded.</summary>
			public const string InvalidContentType = "Request.InvalidContentType";
			/// <summary>Request body is invalid or null.</summary>
			public const string InvalidRequestBody = "Request.InvalidRequestBody";
		}
		public static class Search
		{
			/// <summary>Query is invalid.</summary>
			public const string InvalidQuery = "Search.InvalidQuery";
			/// <summary>The maximum result set is 100,000 items. Narrow your query using filters or use the LastID method as outlined in the Advanced Querying documentation.</summary>
			public const string ResultSetTooLarge = "Search.ResultSetTooLarge";
			/// <summary>The maximum number of rebuilds for this index type has been exceeded.</summary>
			public const string ExceedsRebuildLimit = "Search.ExceedsRebuildLimit";
		}
		public static class SecurityProfile
		{
			/// <summary>Cannot specify both BuyerID non-Buyer CommerceRole.</summary>
			public const string CannotProvideBuyerID = "SecurityProfile.CannotProvideBuyerID";
			/// <summary>Cannot specify both SupplierID and non-Supplier CommerceRole.</summary>
			public const string CannotProvideSupplierID = "SecurityProfile.CannotProvideSupplierID";
			/// <summary>Cannot specify MinimumCharacterCount of less than 10.</summary>
			public const string InvalidPasswordConfiguration = "SecurityProfile.InvalidPasswordConfiguration";
		}
		public static class Seller
		{
			/// <summary>AutoForwardingUserID must be set on Seller, or AutoForward cannot be set on any Products.</summary>
			public const string AutoForwardingUserRequired = "Seller.AutoForwardingUserRequired";
		}
		public static class ShipmentItem
		{
			/// <summary>The quantity shipped cannot exceed the requested ammount on the order.</summary>
			public const string QuantityExceeded = "ShipmentItem.QuantityExceeded";
			/// <summary>Cannot create a shipment item for a line item where IsBundle = true. This line item is excluded from determining if an order is completed.</summary>
			public const string CannotBeBundle = "ShipmentItem.CannotBeBundle";
		}
		public static class ShippingAddress
		{
			/// <summary>Order does not have shipping address to modify. Use PUT to create one.</summary>
			public const string CannotModifyNotFound = "ShippingAddress.CannotModifyNotFound";
			/// <summary>Cannot PATCH a shipping address that was set by ID. Either PATCH the saved address at /addresses/{{id}}, or PUT a complete address at /shipto.</summary>
			public const string CannotPatchSetByID = "ShippingAddress.CannotPatchSetByID";
		}
		public static class Spec
		{
			/// <summary>Any spec where DefinesVariant = true must have AllowOpenText = false.</summary>
			public const string CannotAllowOpenText = "Spec.CannotAllowOpenText";
			/// <summary>To assign this spec to a product you must either update the default value, allow open text, or assign some spec options to it.</summary>
			public const string InvalidSpecConfiguration = "Spec.InvalidSpecConfiguration";
			/// <summary>Any spec where DefinesVariant = true must also have Required = true.</summary>
			public const string MustBeRequired = "Spec.MustBeRequired";
			/// <summary>One or more required specs is missing a value.</summary>
			public const string OneOrMoreRequiresValue = "Spec.OneOrMoreRequiresValue";
			/// <summary>Spec Option not found for the given ID.</summary>
			public const string OptionNotFound = "Spec.OptionNotFound";
			/// <summary>This spec requires a selection.</summary>
			public const string RequiresSelection = "Spec.RequiresSelection";
			/// <summary>This spec requires a value.</summary>
			public const string RequiresValue = "Spec.RequiresValue";
			/// <summary>Cannot assign spec to this product. Product must be owned by the Spec owner.</summary>
			public const string CannotAssignProduct = "Spec.CannotAssignProduct";
		}
		public static class Subscription
		{
			/// <summary>To create a subscription, you must provide both FromCompanyID and FromUserID.</summary>
			public const string CreateRequiresFromUser = "Subscription.CreateRequiresFromUser";
		}
		public static class SubscriptionIntegration
		{
			/// <summary>Cannot use API Client that has OrderCheckoutIntegrationEventID populated.</summary>
			public const string CannotUseApiClient = "SubscriptionIntegration.CannotUseApiClient";
			/// <summary>DefaultContextUser must be defined to use this API Client ID.</summary>
			public const string DefaultContextUser = "SubscriptionIntegration.DefaultContextUser";
			/// <summary>You have exceeded the maximum number of subscription integration runs per hour.</summary>
			public const string ExceedsSelfServiceLimit = "SubscriptionIntegration.ExceedsSelfServiceLimit";
		}
		public static class TrackingEvent
		{
			/// <summary>Only one TrackingEvent of a given type is permitted for the same ApiClient.</summary>
			public const string CannotCreateMultipleEventsOfSameType = "TrackingEvent.CannotCreateMultipleEventsOfSameType";
			/// <summary>The properties ClientID and EventType cannot be updated.</summary>
			public const string CannotUpdateProperty = "TrackingEvent.CannotUpdateProperty";
			/// <summary>The ApiClient specified by ClientID in the request does not exist.</summary>
			public const string InvalidClientID = "TrackingEvent.InvalidClientID";
			/// <summary>The specified delivery configuration (DeliveryConfigID) in the request does not exist.</summary>
			public const string InvalidDeliveryConfigID = "TrackingEvent.InvalidDeliveryConfigID";
		}
		public static class User
		{
			/// <summary>Cannot delete a user currently set as the Default Context User (back office user).</summary>
			public const string CannotDeleteDefaultContextUser = "User.CannotDeleteDefaultContextUser";
			/// <summary>Cannot delete the Dev impersonation user.</summary>
			public const string CannotDeleteDevImpersonationUser = "User.CannotDeleteDevImpersonationUser";
			/// <summary>Cannot delete a user with an open order, or an order pending approval.</summary>
			public const string CannotDeleteWithOpenOrder = "User.CannotDeleteWithOpenOrder";
			/// <summary>Cannot move a user currently set as the Default Context User (back office user).</summary>
			public const string CannotMoveDefaultContextUser = "User.CannotMoveDefaultContextUser";
			/// <summary>Cannot move the Dev impersonation user.</summary>
			public const string CannotMoveDevImpersonationUser = "User.CannotMoveDevImpersonationUser";
			/// <summary>Cannot move a user with an open order, or an order pending approval.</summary>
			public const string CannotMoveeWithOpenOrder = "User.CannotMoveeWithOpenOrder";
			/// <summary>The current user is not a temp user. If you are trying to allow anonymous access to your app, see our guide on Anonymous Shopping.</summary>
			public const string IsNotTemp = "User.IsNotTemp";
			/// <summary>User not found.</summary>
			public const string NotFound = "User.NotFound";
			/// <summary>Username already exists in this Marketplace.</summary>
			public const string UsernameMustBeUnique = "User.UsernameMustBeUnique";
			/// <summary>You do not have permission to access your extended properties.</summary>
			public const string XPNotAllowed = "User.XPNotAllowed";
		}
		public static class UserGroup
		{
			/// <summary>Cannot delete this User Group because it is the designated Approving Group for the given Approval Rule(s). You must either delete the Approval Rule(s) or change the Rules' ApprovingGroupID.</summary>
			public const string CannotDeleteApprovingGroup = "UserGroup.CannotDeleteApprovingGroup";
		}
		public static class Variant
		{
			/// <summary>Attempting to create more variants than is allowed.</summary>
			public const string ExceededLimit = "Variant.ExceededLimit";
			/// <summary>Inventory must be enabled for this variant.</summary>
			public const string MustEnableInventory = "Variant.MustEnableInventory";
			/// <summary>At least one price schedule ID must be non-null.</summary>
			public const string MustHavePriceSchedule = "Variant.MustHavePriceSchedule";
		}
		public static class Webhook
		{
			/// <summary>Webhook URL must be well-formed and secure scheme https is required.</summary>
			public const string UrlSchemeHttps = "Webhook.UrlSchemeHttps";
			/// <summary>Delivery Configuration is not valid for PreHooks.</summary>
			public const string InvalidDeliveryConfig = "Webhook.InvalidDeliveryConfig";
			/// <summary>HashKey is required for this webhook.</summary>
			public const string MissingHashKey = "Webhook.MissingHashKey";
		}
	}
}
