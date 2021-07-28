using System;

namespace OrderCloud.SDK
{
	public static class ErrorCodes
	{
		public static class Address
		{
			/// <summary>This Address is registered as public and cannot be edited by this endpoint.</summary>
			public const string CannotEditPublic = "Address.CannotEditPublic";
			/// <summary>The Order has no Shipping Address to update.</summary>
			public const string CannotUpdateNotFound = "Address.CannotUpdateNotFound";
			/// <summary>This Address is not assigned as a Shipping Address.</summary>
			public const string IsNotShippingAddress = "Address.IsNotShippingAddress";
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
		}
		public static class ApprovalRule
		{
			/// <summary>Cannot delete Approval Rule because it has pending Order Approvals.</summary>
			public const string CannotDeleteIfPending = "ApprovalRule.CannotDeleteIfPending";
		}
		public static class Auth
		{
			/// <summary>Company not active.</summary>
			public const string CompanyNotActive = "Auth.CompanyNotActive";
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
			/// <summary>Seller not active.</summary>
			public const string SellerNotActive = "Auth.SellerNotActive";
			/// <summary>User not active.</summary>
			public const string UserNotActive = "Auth.UserNotActive";
			/// <summary>Reading and/or Administering certain resources is forbidden for all Buyer and Supplier users regardless of role(s).</summary>
			public const string UserNotAuthorizedToAdmin = "Auth.UserNotAuthorizedToAdmin";
			/// <summary>User not found.</summary>
			public const string UserNotFound = "Auth.UserNotFound";
			/// <summary>Due to excessive login failures, this account has been locked out for a period of 30 minutes.</summary>
			public const string LockedOut = "Auth.LockedOut";
			/// <summary>Password does not meet security requirements.</summary>
			public const string InsecurePassword = "Auth.InsecurePassword";
		}
		public static class BillingAddress
		{
			/// <summary>Order does not have billing address to modify. Use PUT to create one.</summary>
			public const string CannotModifyNotFound = "BillingAddress.CannotModifyNotFound";
			/// <summary>Cannot PATCH a billing address that was set by ID. Either PATCH the saved address at /addresses/{{id}}, or PUT a complete address at /billto.</summary>
			public const string CannotPatchSetByID = "BillingAddress.CannotPatchSetByID";
		}
		public static class Buyer
		{
			/// <summary>You must provide the ID of the Buyer User you are creating the order on behalf of.</summary>
			public const string RequiredIDOnBehalf = "Buyer.RequiredIDOnBehalf";
			/// <summary>Buyer ID is require when API Client is for Anonymous Shopping.</summary>
			public const string RequiredIDWhenAnon = "Buyer.RequiredIDWhenAnon";
			/// <summary>User was not found in this Buyer company.</summary>
			public const string UserNotFound = "Buyer.UserNotFound";
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
		}
		public static class Category
		{
			/// <summary>Cannot assign this parent ID. Circular reference detected.</summary>
			public const string CircularReference = "Category.CircularReference";
			/// <summary>Depth must be an integer greater than 0, or 'all'.</summary>
			public const string InvalidDepth = "Category.InvalidDepth";
			/// <summary>Buyer not specified.</summary>
			public const string NoBuyer = "Category.NoBuyer";
		}
		public static class CreditCard
		{
			/// <summary>This Credit Card is registered as public and cannot be edited by this endpoint.</summary>
			public const string CannotEditPublic = "CreditCard.CannotEditPublic";
		}
		public static class Expression
		{
			/// <summary>Function takes exactly one argument.</summary>
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
		}
		public static class Impersonation
		{
			/// <summary>Invalid ApiClient. Not a buyer network and CompanyID is null.</summary>
			public const string BadApiClient = "Impersonation.BadApiClient";
			/// <summary>API client is for a Buyer Network with no default Buyer, and a Buyer ID was not provided.</summary>
			public const string BuyerNetworkBuyerIDRequired = "Impersonation.BuyerNetworkBuyerIDRequired";
			/// <summary>Cannot delete a group or user assigned to an ImpersonationConfig.</summary>
			public const string CannotDeleteImpersonateeParty = "Impersonation.CannotDeleteImpersonateeParty";
			/// <summary>Client ID not found or you do not have access to it.</summary>
			public const string ClientIDNotFound = "Impersonation.ClientIDNotFound";
		}
		public static class IntegrationEvent
		{
			/// <summary>This ApiClient does not have an order calculate event configured.</summary>
			public const string ApiClientNotConfiguredForOrderCalculate = "IntegrationEvent.ApiClientNotConfiguredForOrderCalculate";
			/// <summary>The IntegrationEvent cannot be deleted because it is in use.</summary>
			public const string CannotDeleteInUse = "IntegrationEvent.CannotDeleteInUse";
			/// <summary>The EventType can't be changed once the event is created.</summary>
			public const string CannotEditType = "IntegrationEvent.CannotEditType";
			/// <summary>The referenced IntegrationEvent must reference an IntegrationEvent with the correct EventType</summary>
			public const string IncompatibleEventType = "IntegrationEvent.IncompatibleEventType";
		}
		public static class Inventory
		{
			/// <summary>Insufficient inventory for this product.</summary>
			public const string Insufficient = "Inventory.Insufficient";
			/// <summary>Inventory must be enabled for this product.</summary>
			public const string MustEnable = "Inventory.MustEnable";
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
		public static class Order
		{
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
			/// <summary>The PriceSchedule.OwnerID must match the SellerID.</summary>
			public const string SellerIDMustMatchOwnerID = "PriceSchedule.SellerIDMustMatchOwnerID";
		}
		public static class Product
		{
			/// <summary>Product cache is being built. Please try again later.</summary>
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
			/// <summary>ToCompanyID represents a Supplier. Only promotions with a matching OwnerID may be applied to this order.</summary>
			public const string OwnerIDMustMatchOrderToCompanyID = "Promotion.OwnerIDMustMatchOrderToCompanyID";
		}
		public static class Registration
		{
			/// <summary>Email address or verification code not found.</summary>
			public const string InvalidVerificationCode = "Registration.InvalidVerificationCode";
		}
		public static class Search
		{
			/// <summary>Query is invalid.</summary>
			public const string InvalidQuery = "Search.InvalidQuery";
			/// <summary>The maximum result set is 100,000 items. Narrow your query using filters or use the LastID method as outlined in the Advanced Querying documentation.</summary>
			public const string ResultSetTooLarge = "Search.ResultSetTooLarge";
		}
		public static class SecurityProfile
		{
			/// <summary>Cannot specify both BuyerID non-Buyer CommerceRole.</summary>
			public const string CannotProvideBuyerID = "SecurityProfile.CannotProvideBuyerID";
			/// <summary>Cannot specify both SupplierID and non-Supplier CommerceRole.</summary>
			public const string CannotProvideSupplierID = "SecurityProfile.CannotProvideSupplierID";
		}
		public static class Seller
		{
			/// <summary>AutoForwardingUserID must be set on Seller, or AutoForward cannot be set on any Products.</summary>
			public const string AutoForwardingUserRequired = "Seller.AutoForwardingUserRequired";
			/// <summary>Feature requires subscription to Premium Search. Please contact your sales rep.</summary>
			public const string RequiresPremiumSearch = "Seller.RequiresPremiumSearch";
		}
		public static class ShipmentItem
		{
			/// <summary>The quantity shipped cannot exceed the requested ammount on the order.</summary>
			public const string QuantityExceeded = "ShipmentItem.QuantityExceeded";
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
		public static class SpendingAccount
		{
			/// <summary>The redemption code specified is already in use.</summary>
			public const string InvalidRedemptionCode = "SpendingAccount.InvalidRedemptionCode";
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
			/// <summary>Username already exists in this Buying Network.</summary>
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
	}
}
