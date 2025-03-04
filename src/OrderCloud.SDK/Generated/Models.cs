using System;
using System.Collections.Generic;
using System.Dynamic;

namespace OrderCloud.SDK
{
	public enum AccessLevel { Private, Public, Shareable }
	public enum ApiRole { ApiClientAdmin, ApiClientReader, AddressAdmin, AddressReader, AdminAddressAdmin, AdminAddressReader, AdminUserAdmin, AdminUserGroupAdmin, AdminUserGroupReader, AdminUserReader, ApprovalRuleAdmin, ApprovalRuleReader, BundleAdmin, BundleAssignmentAdmin, BundleReader, BuyerAdmin, BuyerImpersonation, BuyerReader, BuyerUserAdmin, BuyerUserReader, CatalogAdmin, CatalogReader, CategoryAdmin, CategoryReader, CostCenterAdmin, CostCenterReader, CreditCardAdmin, CreditCardReader, EntitySyncConfigAdmin, FullAccess, IncrementorAdmin, IncrementorReader, LocaleReader, LocaleAdmin, MeAddressAdmin, MeAdmin, MeCreditCardAdmin, MessageConfigAssignmentAdmin, MeSubscriptionAdmin, MeXpAdmin, OrderAdmin, OrderReader, OverrideShipping, OverrideTax, OverrideUnitPrice, PasswordReset, PriceScheduleAdmin, PriceScheduleReader, ProductAdmin, ProductAssignmentAdmin, ProductCollectionReader, ProductFacetAdmin, ProductFacetReader, ProductReader, ProductSyncConfigAdmin, PromotionAdmin, PromotionReader, SecurityProfileAdmin, SecurityProfileReader, SetSecurityProfile, ShipmentAdmin, ShipmentReader, Shopper, SpendingAccountAdmin, SpendingAccountReader, SubscriptionAdmin, SubscriptionReader, SupplierAddressAdmin, SupplierAddressReader, SupplierAdmin, SupplierReader, SupplierUserAdmin, SupplierUserGroupAdmin, SupplierUserGroupReader, SupplierUserReader, UnsubmittedOrderReader, UserGroupAdmin, UserGroupReader, OpenIDConnectReader, OpenIDConnectAdmin, MessageSenderReader, MessageSenderAdmin, XpIndexAdmin, WebhookReader, WebhookAdmin, IntegrationEventReader, IntegrationEventAdmin, TrackingEventReader, TrackingEventAdmin, DeliveryConfigAdmin, OrderSyncConfigAdmin, ErrorConfigAdmin }
	public enum ApprovalStatus { Pending, Approved, Declined }
	public enum ApprovalType { Order, OrderReturn }
	public enum CommerceRole { Buyer, Seller, Supplier }
	public enum IntegrationEventType { OrderCheckout, OpenIDConnect, OrderReturn, AddToCart }
	public enum MessageType { OrderDeclined, OrderSubmitted, ShipmentCreated, ForgottenPassword, ForgottenUsername, OrderSubmittedForYourApproval, OrderSubmittedForApproval, OrderApproved, OrderSubmittedForYourApprovalHasBeenApproved, OrderSubmittedForYourApprovalHasBeenDeclined, NewUserInvitation, OrderReturnDeclined, OrderReturnSubmitted, OrderReturnSubmittedForYourApproval, OrderReturnSubmittedForApproval, OrderReturnApproved, OrderReturnSubmittedForYourApprovalHasBeenApproved, OrderReturnSubmittedForYourApprovalHasBeenDeclined, OrderReturnCompleted, SubscriptionReminder, ProductCollectionInvitationAccepted, ProductCollectionInvitationDeclined }
	public enum OrderDirection { Incoming, Outgoing, All }
	public enum OrderStatus { Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled }
	public enum PartyType { User, Group, Company }
	public enum PaymentType { PurchaseOrder, CreditCard, SpendingAccount }
	public enum PriceMarkupType { NoMarkup, AmountPerQuantity, AmountTotal, Percentage }
	public enum SearchType { AnyTerm, AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix }
	public enum SubscriptionInterval { Days, Weeks, Months }
	public enum TrackingEventType { UserLoggedIn, LineItemAdded, LineItemUpdated, OrderSubmitted }
	public enum UserOrderMoveOption { None, Unsubmitted, All }
	public enum XpThingType { Address, Variant, Order, OrderReturn, LineItem, CostCenter, CreditCard, Payment, Spec, SpecOption, UserGroup, Company, Category, PriceSchedule, Shipment, SpendingAccount, User, Promotion, ApprovalRule, SellerApprovalRule, Catalog, ProductFacet, MessageSender, InventoryRecord, ProductCollection, Subscription, GroupOrderInvitation }
	public class AccessToken : OrderCloudModel
	{
		/// <summary>Access token of the access token.</summary>
		public string access_token { get => GetProp<string>("access_token"); set => SetProp<string>("access_token", value); }
		/// <summary>Expires in of the access token.</summary>
		public int expires_in { get => GetProp<int>("expires_in"); set => SetProp<int>("expires_in", value); }
		/// <summary>Token type of the access token.</summary>
		public string token_type { get => GetProp<string>("token_type"); set => SetProp<string>("token_type", value); }
		/// <summary>Refresh token of the access token.</summary>
		public string refresh_token { get => GetProp<string>("refresh_token"); set => SetProp<string>("refresh_token", value); }
	}
	public class AccessTokenBasic : OrderCloudModel
	{
		/// <summary>Access token of the access token basic.</summary>
		public string access_token { get => GetProp<string>("access_token"); set => SetProp<string>("access_token", value); }
	}
	public class Address : OrderCloudModel
	{
		/// <summary>ID of the address. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Date created of the address. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Company name of the address. Max length 100 characters. Searchable: priority level 3. Sortable.</summary>
		public string CompanyName { get => GetProp<string>("CompanyName"); set => SetProp<string>("CompanyName", value); }
		/// <summary>First name of the address. Max length 100 characters. Searchable: priority level 8. Sortable.</summary>
		public string FirstName { get => GetProp<string>("FirstName"); set => SetProp<string>("FirstName", value); }
		/// <summary>Last name of the address. Max length 100 characters. Searchable: priority level 7. Sortable.</summary>
		public string LastName { get => GetProp<string>("LastName"); set => SetProp<string>("LastName", value); }
		/// <summary>Street 1 of the address. Required. Max length 100 characters. Searchable: priority level 5. Sortable.</summary>
		[Required]
		public string Street1 { get => GetProp<string>("Street1"); set => SetProp<string>("Street1", value); }
		/// <summary>Street 2 of the address. Max length 100 characters. Searchable: priority level 6. Sortable.</summary>
		public string Street2 { get => GetProp<string>("Street2"); set => SetProp<string>("Street2", value); }
		/// <summary>City of the address. Required. Max length 100 characters. Searchable: priority level 4. Sortable.</summary>
		[Required]
		public string City { get => GetProp<string>("City"); set => SetProp<string>("City", value); }
		/// <summary>State of the address. Required. Max length 100 characters. Searchable: priority level 9. Sortable.</summary>
		[RequiredForCountries("US","CA")]
		public string State { get => GetProp<string>("State"); set => SetProp<string>("State", value); }
		/// <summary>Zip of the address. Required. Max length 100 characters. Searchable: priority level 10. Sortable.</summary>
		[RequiredForCountries("US","CA")]
		public string Zip { get => GetProp<string>("Zip"); set => SetProp<string>("Zip", value); }
		/// <summary>Country of the address. Required. Max length 2 characters. Sortable.</summary>
		[Required]
		public string Country { get => GetProp<string>("Country"); set => SetProp<string>("Country", value); }
		/// <summary>Phone of the address. Max length 100 characters. Sortable.</summary>
		public string Phone { get => GetProp<string>("Phone"); set => SetProp<string>("Phone", value); }
		/// <summary>Address name of the address. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string AddressName { get => GetProp<string>("AddressName"); set => SetProp<string>("AddressName", value); }
		/// <summary>Container for extended (custom) properties of the address.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Address class instead.</typeparam>
	public class Address<Txp> : Address
	{
		/// <summary>Container for extended (custom) properties of the address.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class AddressAssignment : OrderCloudModel
	{
		/// <summary>ID of the address. Required. Sortable: priority level 1.</summary>
		[Required]
		public string AddressID { get => GetProp<string>("AddressID"); set => SetProp<string>("AddressID", value); }
		/// <summary>ID of the user. Sortable: priority level 2.</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>Is shipping of the address assignment.</summary>
		public bool IsShipping { get => GetProp<bool>("IsShipping"); set => SetProp<bool>("IsShipping", value); }
		/// <summary>Is billing of the address assignment.</summary>
		public bool IsBilling { get => GetProp<bool>("IsBilling"); set => SetProp<bool>("IsBilling", value); }
	}
	public class AdHocProduct : OrderCloudModel
	{
		/// <summary>ID of the ad hoc product. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the ad hoc product. Required. Max length 100 characters.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the ad hoc product. Max length 2000 characters.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Informational only, does not influence any OrderCloud behavior. Used to indicate an amount per Quantity.</summary>
		public int? QuantityMultiplier { get => GetProp<int?>("QuantityMultiplier", 1); set => SetProp<int?>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the ad hoc product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the ad hoc product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the ad hoc product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the ad hoc product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>If this property has a value and a SupplierID isn't explicitly passed when creating a LineItem, this SupplierID will be used.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>If true, all suppliers are eligible to opt into selling this product.</summary>
		public bool Returnable { get => GetProp<bool>("Returnable"); set => SetProp<bool>("Returnable", value); }
		/// <summary>Container for extended (custom) properties of the ad hoc product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic AdHocProduct class instead.</typeparam>
	public class AdHocProduct<Txp> : AdHocProduct
	{
		/// <summary>Container for extended (custom) properties of the ad hoc product.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ApiClient : OrderCloudModel
	{
		/// <summary>Used for OAuth 2.0 workflows and OrderCloud impersonation to represent this Client Application.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Enables the OAuth 2.0 Client Credentials grant type. Required on all OAuth workflows when present.</summary>
		public string ClientSecret { get => GetProp<string>("ClientSecret"); set => SetProp<string>("ClientSecret", value); }
		/// <summary>Access token duration of the api client. Required. Must be between 10 and 600.</summary>
		[Required]
		public int AccessTokenDuration { get => GetProp<int>("AccessTokenDuration"); set => SetProp<int>("AccessTokenDuration", value); }
		/// <summary>All user authentication is prohibited if false.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>App name of the api client. Required. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string AppName { get => GetProp<string>("AppName"); set => SetProp<string>("AppName", value); }
		/// <summary>Refresh token duration of the api client. Must be between 0 and 524160.</summary>
		public int RefreshTokenDuration { get => GetProp<int>("RefreshTokenDuration"); set => SetProp<int>("RefreshTokenDuration", value); }
		/// <summary>Optionally set a user that will be used when authenticating with a Client Credentials grant type flow. This grant type is often used for anonymous browsing on buyer applications and authentication on server integration layers.</summary>
		public string DefaultContextUserName { get => GetProp<string>("DefaultContextUserName"); set => SetProp<string>("DefaultContextUserName", value); }
		/// <summary>Container for extended (custom) properties of the api client.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Allow all buyer users in your organization access to authenticate using this ApiClient.</summary>
		public bool AllowAnyBuyer { get => GetProp<bool>("AllowAnyBuyer"); set => SetProp<bool>("AllowAnyBuyer", value); }
		/// <summary>Allow all supplier users in your organization access to authenticate using this ApiClient.</summary>
		public bool AllowAnySupplier { get => GetProp<bool>("AllowAnySupplier"); set => SetProp<bool>("AllowAnySupplier", value); }
		/// <summary>Allow all marketplace owner users in your organization access to authenticate using this ApiClient.</summary>
		public bool AllowSeller { get => GetProp<bool>("AllowSeller"); set => SetProp<bool>("AllowSeller", value); }
		/// <summary>Enables anonymous shopping. It only works when a Buyer User is the Default Context User.</summary>
		public bool IsAnonBuyer { get => GetProp<bool>("IsAnonBuyer"); set => SetProp<bool>("IsAnonBuyer", value); }
		/// <summary>Assigned buyer count of the api client.</summary>
		[ApiReadOnly]
		public int AssignedBuyerCount { get => GetProp<int>("AssignedBuyerCount"); set => SetProp<int>("AssignedBuyerCount", value); }
		/// <summary>Assigned supplier count of the api client.</summary>
		[ApiReadOnly]
		public int AssignedSupplierCount { get => GetProp<int>("AssignedSupplierCount"); set => SetProp<int>("AssignedSupplierCount", value); }
		/// <summary>If populated, an error will be thrown when attempting to submit an order that has not been processed through the OrderCheckout Integration.</summary>
		public string OrderCheckoutIntegrationEventID { get => GetProp<string>("OrderCheckoutIntegrationEventID"); set => SetProp<string>("OrderCheckoutIntegrationEventID", value); }
		/// <summary>Order checkout integration event name of the api client.</summary>
		[ApiReadOnly]
		public string OrderCheckoutIntegrationEventName { get => GetProp<string>("OrderCheckoutIntegrationEventName"); set => SetProp<string>("OrderCheckoutIntegrationEventName", value); }
		/// <summary>If populated, and not overriden by an OrderAdmin, the integration event will be used to calculate ReturnAmount on the Order Return or each individual return item.</summary>
		public string OrderReturnIntegrationEventID { get => GetProp<string>("OrderReturnIntegrationEventID"); set => SetProp<string>("OrderReturnIntegrationEventID", value); }
		/// <summary>Order return integration event name of the api client.</summary>
		[ApiReadOnly]
		public string OrderReturnIntegrationEventName { get => GetProp<string>("OrderReturnIntegrationEventName"); set => SetProp<string>("OrderReturnIntegrationEventName", value); }
		/// <summary>If populated, the integration event will be used to fetch product information from an external system, instead of an OrderCloud catalog, when a line item is added to an unsubmitted order.</summary>
		public string AddToCartIntegrationEventID { get => GetProp<string>("AddToCartIntegrationEventID"); set => SetProp<string>("AddToCartIntegrationEventID", value); }
		/// <summary>Add to cart integration event name of the api client.</summary>
		[ApiReadOnly]
		public string AddToCartIntegrationEventName { get => GetProp<string>("AddToCartIntegrationEventName"); set => SetProp<string>("AddToCartIntegrationEventName", value); }
		/// <summary>Minimum required roles of the api client.</summary>
		public IList<ApiRole> MinimumRequiredRoles { get => GetProp<IList<ApiRole>>("MinimumRequiredRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("MinimumRequiredRoles", value); }
		/// <summary>Minimum required custom roles of the api client.</summary>
		public IList<string> MinimumRequiredCustomRoles { get => GetProp<IList<string>>("MinimumRequiredCustomRoles", new List<string>()); set => SetProp<IList<string>>("MinimumRequiredCustomRoles", value); }
		/// <summary>Maximum granted roles of the api client.</summary>
		public IList<ApiRole> MaximumGrantedRoles { get => GetProp<IList<ApiRole>>("MaximumGrantedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("MaximumGrantedRoles", value); }
		/// <summary>Maximum granted custom roles of the api client.</summary>
		public IList<string> MaximumGrantedCustomRoles { get => GetProp<IList<string>>("MaximumGrantedCustomRoles", new List<string>()); set => SetProp<IList<string>>("MaximumGrantedCustomRoles", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ApiClient class instead.</typeparam>
	public class ApiClient<Txp> : ApiClient
	{
		/// <summary>Container for extended (custom) properties of the api client.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ApiClientAssignment : OrderCloudModel
	{
		/// <summary>ID of the api client. Required.</summary>
		[Required]
		public string ApiClientID { get => GetProp<string>("ApiClientID"); set => SetProp<string>("ApiClientID", value); }
		/// <summary>ID of the buyer. Sortable: priority level 0.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the supplier. Sortable: priority level 1.</summary>
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
	}
	public class ApiClientSecret : OrderCloudModel
	{
		/// <summary>ID of the api client secret. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the api client secret. Required.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Expiration of the api client secret.</summary>
		public DateTimeOffset? Expiration { get => GetProp<DateTimeOffset?>("Expiration"); set => SetProp<DateTimeOffset?>("Expiration", value); }
	}
	public class ApiClientSecretCreateResponse : OrderCloudModel
	{
		/// <summary>Client secret of the api client secret create response.</summary>
		[ApiReadOnly]
		public string ClientSecret { get => GetProp<string>("ClientSecret"); set => SetProp<string>("ClientSecret", value); }
		/// <summary>ID of the api client secret create response. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the api client secret create response. Required.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Expiration of the api client secret create response.</summary>
		public DateTimeOffset? Expiration { get => GetProp<DateTimeOffset?>("Expiration"); set => SetProp<DateTimeOffset?>("Expiration", value); }
	}
	public class ApprovalInfo : OrderCloudModel
	{
		/// <summary>Comments to be saved with the order approval or denial.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
	}
	public class ApprovalRule : OrderCloudModel
	{
		/// <summary>ID of the approval rule. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the approval rule. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the approval rule. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>ID of the approving group. Required. Sortable.</summary>
		[Required]
		public string ApprovingGroupID { get => GetProp<string>("ApprovingGroupID"); set => SetProp<string>("ApprovingGroupID", value); }
		/// <summary>The expression evaluated to determine an order requires approval. See Rules Engine documentation for formatting details.</summary>
		[Required]
		public string RuleExpression { get => GetProp<string>("RuleExpression"); set => SetProp<string>("RuleExpression", value); }
		/// <summary>Container for extended (custom) properties of the approval rule.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ApprovalRule class instead.</typeparam>
	public class ApprovalRule<Txp> : ApprovalRule
	{
		/// <summary>Container for extended (custom) properties of the approval rule.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class AzureBlobConfig : OrderCloudModel
	{
		/// <summary>Storage account connection string.</summary>
		[Required]
		[ApiWriteOnly]
		public string ConnectionString { get => GetProp<string>("ConnectionString"); set => SetProp<string>("ConnectionString", value); }
		/// <summary>Override container name of the azure blob config.</summary>
		public string OverrideContainerName { get => GetProp<string>("OverrideContainerName"); set => SetProp<string>("OverrideContainerName", value); }
	}
	public class AzureTableConfig : OrderCloudModel
	{
		/// <summary>Storage account connection string.</summary>
		[Required]
		[ApiWriteOnly]
		public string ConnectionString { get => GetProp<string>("ConnectionString"); set => SetProp<string>("ConnectionString", value); }
		/// <summary>Override table name of the azure table config.</summary>
		public string OverrideTableName { get => GetProp<string>("OverrideTableName"); set => SetProp<string>("OverrideTableName", value); }
	}
	public class Bundle : OrderCloudModel
	{
		/// <summary>ID of the bundle. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the organization that owns the Bundle. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Name of the bundle. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the bundle. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>If false, bundle is not visible or purchasable from the Shopper perspective.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Consider keeping bundle and product xp schemas consistent. Defining conflicting xp types will result in indexing problems.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Bundle class instead.</typeparam>
	public class Bundle<Txp> : Bundle
	{
		/// <summary>Consider keeping bundle and product xp schemas consistent. Defining conflicting xp types will result in indexing problems.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class BundleAssignment : OrderCloudModel
	{
		/// <summary>Marketplace owner can write to this property when creating bundle assignments for other sellers.</summary>
		public string SellerID { get => GetProp<string>("SellerID"); set => SetProp<string>("SellerID", value); }
		/// <summary>ID of the bundle. Required.</summary>
		[Required]
		public string BundleID { get => GetProp<string>("BundleID"); set => SetProp<string>("BundleID", value); }
		/// <summary>ID of the buyer. Required.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the user group.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class BundleCatalogAssignment : OrderCloudModel
	{
		/// <summary>ID of the catalog. Required.</summary>
		[Required]
		public string CatalogID { get => GetProp<string>("CatalogID"); set => SetProp<string>("CatalogID", value); }
		/// <summary>ID of the bundle. Required.</summary>
		[Required]
		public string BundleID { get => GetProp<string>("BundleID"); set => SetProp<string>("BundleID", value); }
	}
	public class BundleItems : OrderCloudModel
	{
		/// <summary>Line items of the bundle item.</summary>
		public IList<LineItem> LineItems { get => GetProp<IList<LineItem>>("LineItems", new List<LineItem>()); set => SetProp<IList<LineItem>>("LineItems", value); }
	}
	/// <typeparam name="TLineItems">Specific type of the LineItems property. If not using a custom type, use the non-generic BundleItems class instead.</typeparam>
	public class BundleItems<TLineItems> : BundleItems
		where TLineItems : LineItem
	{
		/// <summary>Line items of the bundle item.</summary>
		public new IList<TLineItems> LineItems { get => GetProp<IList<TLineItems>>("LineItems", new List<TLineItems>()); set => SetProp<IList<TLineItems>>("LineItems", value); }
	}
	public class BundleProductAssignment : OrderCloudModel
	{
		/// <summary>ID of the product. Required.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>ID of the bundle. Required.</summary>
		[Required]
		public string BundleID { get => GetProp<string>("BundleID"); set => SetProp<string>("BundleID", value); }
		/// <summary>Required of the bundle product assignment. Required.</summary>
		[Required]
		public bool Required { get => GetProp<bool>("Required"); set => SetProp<bool>("Required", value); }
		/// <summary>Default quantity of the bundle product assignment.</summary>
		public int? DefaultQuantity { get => GetProp<int?>("DefaultQuantity"); set => SetProp<int?>("DefaultQuantity", value); }
	}
	public class Buyer : OrderCloudModel
	{
		/// <summary>ID of the buyer. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the buyer. Required. Max length 100 characters. Searchable: priority level 1. Sortable.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>If null on POST a new default catalog will be created for the buyer. Used in buyer product queries to allow filtering on categories without explicitly providing a CatalogID.</summary>
		public string DefaultCatalogID { get => GetProp<string>("DefaultCatalogID"); set => SetProp<string>("DefaultCatalogID", value); }
		/// <summary>If false, all authentication is prohibited.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Date created of the buyer. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get => GetProp<DateTimeOffset>("DateCreated"); set => SetProp<DateTimeOffset>("DateCreated", value); }
		/// <summary>Container for extended (custom) properties of the buyer.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Buyer class instead.</typeparam>
	public class Buyer<Txp> : Buyer
	{
		/// <summary>Container for extended (custom) properties of the buyer.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class BuyerAddress : OrderCloudModel
	{
		/// <summary>ID of the address. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Indicates whether this Address can be used as a Shipping Address on an Order or Line Item.</summary>
		public bool Shipping { get => GetProp<bool>("Shipping"); set => SetProp<bool>("Shipping", value); }
		/// <summary>Indicates whether this Address can be used as a Billing Address on an Order.</summary>
		public bool Billing { get => GetProp<bool>("Billing"); set => SetProp<bool>("Billing", value); }
		/// <summary>Indicates whether this Address can be edited by the current User.</summary>
		[ApiReadOnly]
		public bool Editable { get => GetProp<bool>("Editable"); set => SetProp<bool>("Editable", value); }
		/// <summary>Date created of the address. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Company name of the address. Max length 100 characters. Searchable: priority level 3. Sortable.</summary>
		public string CompanyName { get => GetProp<string>("CompanyName"); set => SetProp<string>("CompanyName", value); }
		/// <summary>First name of the address. Max length 100 characters. Searchable: priority level 8. Sortable.</summary>
		public string FirstName { get => GetProp<string>("FirstName"); set => SetProp<string>("FirstName", value); }
		/// <summary>Last name of the address. Max length 100 characters. Searchable: priority level 7. Sortable.</summary>
		public string LastName { get => GetProp<string>("LastName"); set => SetProp<string>("LastName", value); }
		/// <summary>Street 1 of the address. Required. Max length 100 characters. Searchable: priority level 5. Sortable.</summary>
		[Required]
		public string Street1 { get => GetProp<string>("Street1"); set => SetProp<string>("Street1", value); }
		/// <summary>Street 2 of the address. Max length 100 characters. Searchable: priority level 6. Sortable.</summary>
		public string Street2 { get => GetProp<string>("Street2"); set => SetProp<string>("Street2", value); }
		/// <summary>City of the address. Required. Max length 100 characters. Searchable: priority level 4. Sortable.</summary>
		[Required]
		public string City { get => GetProp<string>("City"); set => SetProp<string>("City", value); }
		/// <summary>State of the address. Required. Max length 100 characters. Searchable: priority level 9. Sortable.</summary>
		[RequiredForCountries("US","CA")]
		public string State { get => GetProp<string>("State"); set => SetProp<string>("State", value); }
		/// <summary>Zip of the address. Required. Max length 100 characters. Searchable: priority level 10. Sortable.</summary>
		[RequiredForCountries("US","CA")]
		public string Zip { get => GetProp<string>("Zip"); set => SetProp<string>("Zip", value); }
		/// <summary>Country of the address. Required. Max length 2 characters. Sortable.</summary>
		[Required]
		public string Country { get => GetProp<string>("Country"); set => SetProp<string>("Country", value); }
		/// <summary>Phone of the address. Max length 100 characters. Sortable.</summary>
		public string Phone { get => GetProp<string>("Phone"); set => SetProp<string>("Phone", value); }
		/// <summary>Address name of the address. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string AddressName { get => GetProp<string>("AddressName"); set => SetProp<string>("AddressName", value); }
		/// <summary>Container for extended (custom) properties of the address.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic BuyerAddress class instead.</typeparam>
	public class BuyerAddress<Txp> : BuyerAddress
	{
		/// <summary>Container for extended (custom) properties of the address.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class BuyerCreditCard : OrderCloudModel
	{
		/// <summary>ID of the credit card. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Editable of the credit card. Searchable: priority level 5.</summary>
		[ApiReadOnly]
		public bool Editable { get => GetProp<bool>("Editable"); set => SetProp<bool>("Editable", value); }
		/// <summary>Token provided by the credit card processor used to reference the card with that processor.</summary>
		public string Token { get => GetProp<string>("Token"); set => SetProp<string>("Token", value); }
		/// <summary>Date created of the credit card. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Card type of the credit card. Searchable: priority level 3. Sortable: priority level 3.</summary>
		public string CardType { get => GetProp<string>("CardType"); set => SetProp<string>("CardType", value); }
		/// <summary>Partial account number of the credit card. Max length 5 characters.</summary>
		public string PartialAccountNumber { get => GetProp<string>("PartialAccountNumber"); set => SetProp<string>("PartialAccountNumber", value); }
		/// <summary>Cardholder name of the credit card. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string CardholderName { get => GetProp<string>("CardholderName"); set => SetProp<string>("CardholderName", value); }
		/// <summary>Expiration date of the credit card. Searchable: priority level 4. Sortable: priority level 4.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>Container for extended (custom) properties of the credit card.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic BuyerCreditCard class instead.</typeparam>
	public class BuyerCreditCard<Txp> : BuyerCreditCard
	{
		/// <summary>Container for extended (custom) properties of the credit card.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class BuyerProduct : OrderCloudModel
	{
		/// <summary>Price schedule of the product.</summary>
		[ApiReadOnly]
		public PriceSchedule PriceSchedule { get => GetProp<PriceSchedule>("PriceSchedule"); set => SetProp<PriceSchedule>("PriceSchedule", value); }
		/// <summary>ID of the product. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the parent product. If not null, IsParent should be false</summary>
		public string ParentID { get => GetProp<string>("ParentID"); set => SetProp<string>("ParentID", value); }
		/// <summary>If true, ParentID must be null, as a parent product cannot have a parent itself.</summary>
		public bool IsParent { get => GetProp<bool>("IsParent"); set => SetProp<bool>("IsParent", value); }
		/// <summary>If true, IsParent must be false, as a parent product cannot be a bundle.</summary>
		[ApiReadOnly]
		public bool IsBundle { get => GetProp<bool>("IsBundle"); set => SetProp<bool>("IsBundle", value); }
		/// <summary>Name of the product. Required. Max length 100 characters. Searchable: priority level 3. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the product. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior. Used to indicate an amount per Quantity.</summary>
		public int? QuantityMultiplier { get => GetProp<int?>("QuantityMultiplier", 1); set => SetProp<int?>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>If false, product is not visible or purchasable from the Shopper perspective.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Count of Specs assigned to the product.</summary>
		[ApiReadOnly]
		public int SpecCount { get => GetProp<int>("SpecCount"); set => SetProp<int>("SpecCount", value); }
		/// <summary>Count of Variants generated from the product/spec combinations.</summary>
		[ApiReadOnly]
		public int VariantCount { get => GetProp<int>("VariantCount"); set => SetProp<int>("VariantCount", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from. Can be used to calculate shipping costs.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Inventory of the product.</summary>
		public Inventory Inventory { get => GetProp<Inventory>("Inventory"); set => SetProp<Inventory>("Inventory", value); }
		/// <summary>If this property has a value and a SupplierID isn't explicitly passed when creating a LineItem, this SupplierID will be used.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>If true, all suppliers are eligible to opt into selling this product.</summary>
		public bool AllSuppliersCanSell { get => GetProp<bool>("AllSuppliersCanSell"); set => SetProp<bool>("AllSuppliersCanSell", value); }
		/// <summary>Returnable of the product.</summary>
		public bool Returnable { get => GetProp<bool>("Returnable"); set => SetProp<bool>("Returnable", value); }
		/// <summary>Date created of the product.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Container for extended (custom) properties of the product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule property. If not using a custom type, specify PriceSchedule.</typeparam>
	public class BuyerProduct<Txp, TPriceSchedule> : BuyerProduct
		where TPriceSchedule : PriceSchedule
	{
		/// <summary>Container for extended (custom) properties of the product.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Price schedule of the product.</summary>
		[ApiReadOnly]
		public new TPriceSchedule PriceSchedule { get => GetProp<TPriceSchedule>("PriceSchedule"); set => SetProp<TPriceSchedule>("PriceSchedule", value); }
	}
	public class BuyerSupplier : OrderCloudModel
	{
		/// <summary>ID of the supplier. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the supplier. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
	}
	public class Catalog : OrderCloudModel
	{
		/// <summary>ID of the catalog. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the organization that owns the Catalog. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Name of the catalog. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the catalog. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Categories and Products within to this catalog will not be visible to buyer users if false.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Category count of the catalog.</summary>
		[ApiReadOnly]
		public int CategoryCount { get => GetProp<int>("CategoryCount"); set => SetProp<int>("CategoryCount", value); }
		/// <summary>Container for extended (custom) properties of the catalog.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Catalog class instead.</typeparam>
	public class Catalog<Txp> : Catalog
	{
		/// <summary>Container for extended (custom) properties of the catalog.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class CatalogAssignment : OrderCloudModel
	{
		/// <summary>ID of the catalog. Required. Sortable: priority level 1.</summary>
		[Required]
		public string CatalogID { get => GetProp<string>("CatalogID"); set => SetProp<string>("CatalogID", value); }
		/// <summary>ID of the buyer. Required.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>View all categories of the catalog assignment.</summary>
		public bool ViewAllCategories { get => GetProp<bool>("ViewAllCategories"); set => SetProp<bool>("ViewAllCategories", value); }
		/// <summary>View all products of the catalog assignment.</summary>
		public bool ViewAllProducts { get => GetProp<bool>("ViewAllProducts"); set => SetProp<bool>("ViewAllProducts", value); }
	}
	public class Category : OrderCloudModel
	{
		/// <summary>ID of the category. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the category. Required. Max length 100 characters. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the category. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Order that the category appears within its parent or catalog (if root level).</summary>
		public int? ListOrder { get => GetProp<int?>("ListOrder"); set => SetProp<int?>("ListOrder", value); }
		/// <summary>If false, buyers cannot see this Category or any Categories or Products under it.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>ID of the parent category.</summary>
		public string ParentID { get => GetProp<string>("ParentID"); set => SetProp<string>("ParentID", value); }
		/// <summary>Number of categories that are *immediate* children of this category.</summary>
		[ApiReadOnly]
		public int ChildCount { get => GetProp<int>("ChildCount"); set => SetProp<int>("ChildCount", value); }
		/// <summary>Container for extended (custom) properties of the category.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Category class instead.</typeparam>
	public class Category<Txp> : Category
	{
		/// <summary>Container for extended (custom) properties of the category.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class CategoryAssignment : OrderCloudModel
	{
		/// <summary>ID of the category. Required. Sortable: priority level 1.</summary>
		[Required]
		public string CategoryID { get => GetProp<string>("CategoryID"); set => SetProp<string>("CategoryID", value); }
		/// <summary>ID of the buyer. Required. Sortable: priority level 2.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the user group.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>Optional. Set to null to inherit from parent category or catalog level.</summary>
		public bool? Visible { get => GetProp<bool?>("Visible"); set => SetProp<bool?>("Visible", value); }
		/// <summary>Optional. Set to null to inherit from parent category or catalog level.</summary>
		public bool? ViewAllProducts { get => GetProp<bool?>("ViewAllProducts"); set => SetProp<bool?>("ViewAllProducts", value); }
	}
	public class CategoryBundleAssignment : OrderCloudModel
	{
		/// <summary>ID of the category. Required.</summary>
		[Required]
		public string CategoryID { get => GetProp<string>("CategoryID"); set => SetProp<string>("CategoryID", value); }
		/// <summary>ID of the bundle. Required.</summary>
		[Required]
		public string BundleID { get => GetProp<string>("BundleID"); set => SetProp<string>("BundleID", value); }
		/// <summary>List order of the category bundle assignment.</summary>
		public int? ListOrder { get => GetProp<int?>("ListOrder"); set => SetProp<int?>("ListOrder", value); }
	}
	public class CategoryProductAssignment : OrderCloudModel
	{
		/// <summary>ID of the category. Required.</summary>
		[Required]
		public string CategoryID { get => GetProp<string>("CategoryID"); set => SetProp<string>("CategoryID", value); }
		/// <summary>ID of the product. Required.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>List order of the category product assignment.</summary>
		public int? ListOrder { get => GetProp<int?>("ListOrder"); set => SetProp<int?>("ListOrder", value); }
	}
	public class ContentHubConfig : OrderCloudModel
	{
		/// <summary>Api key of the content hub config. Required. Max length 50 characters.</summary>
		[Required]
		[ApiWriteOnly]
		public string ApiKey { get => GetProp<string>("ApiKey"); set => SetProp<string>("ApiKey", value); }
		/// <summary>Endpoint of the content hub config. Required.</summary>
		[Required]
		public string Endpoint { get => GetProp<string>("Endpoint"); set => SetProp<string>("Endpoint", value); }
		/// <summary>Target schema name of the content hub config. Required.</summary>
		[Required]
		public string TargetSchemaName { get => GetProp<string>("TargetSchemaName"); set => SetProp<string>("TargetSchemaName", value); }
		/// <summary>Any custom property mapping should be included here.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
	}
	public class CosmosDbConfig : OrderCloudModel
	{
		/// <summary>Storage account connection string.</summary>
		[Required]
		[ApiWriteOnly]
		public string ConnectionString { get => GetProp<string>("ConnectionString"); set => SetProp<string>("ConnectionString", value); }
		/// <summary>Override database name of the cosmos db config.</summary>
		public string OverrideDatabaseName { get => GetProp<string>("OverrideDatabaseName"); set => SetProp<string>("OverrideDatabaseName", value); }
	}
	public class CostCenter : OrderCloudModel
	{
		/// <summary>ID of the cost center. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the cost center. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the cost center. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Container for extended (custom) properties of the cost center.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic CostCenter class instead.</typeparam>
	public class CostCenter<Txp> : CostCenter
	{
		/// <summary>Container for extended (custom) properties of the cost center.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class CostCenterAssignment : OrderCloudModel
	{
		/// <summary>ID of the cost center. Required. Sortable: priority level 1.</summary>
		[Required]
		public string CostCenterID { get => GetProp<string>("CostCenterID"); set => SetProp<string>("CostCenterID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class CreditCard : OrderCloudModel
	{
		/// <summary>ID of the credit card. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Token provided by the credit card processor used to reference the card with that processor.</summary>
		public string Token { get => GetProp<string>("Token"); set => SetProp<string>("Token", value); }
		/// <summary>Date created of the credit card. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Card type of the credit card. Searchable: priority level 3. Sortable: priority level 3.</summary>
		public string CardType { get => GetProp<string>("CardType"); set => SetProp<string>("CardType", value); }
		/// <summary>Partial account number of the credit card. Max length 5 characters.</summary>
		public string PartialAccountNumber { get => GetProp<string>("PartialAccountNumber"); set => SetProp<string>("PartialAccountNumber", value); }
		/// <summary>Cardholder name of the credit card. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string CardholderName { get => GetProp<string>("CardholderName"); set => SetProp<string>("CardholderName", value); }
		/// <summary>Expiration date of the credit card. Searchable: priority level 4. Sortable: priority level 4.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>Container for extended (custom) properties of the credit card.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic CreditCard class instead.</typeparam>
	public class CreditCard<Txp> : CreditCard
	{
		/// <summary>Container for extended (custom) properties of the credit card.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class CreditCardAssignment : OrderCloudModel
	{
		/// <summary>ID of the credit card. Required. Sortable: priority level 1.</summary>
		[Required]
		public string CreditCardID { get => GetProp<string>("CreditCardID"); set => SetProp<string>("CreditCardID", value); }
		/// <summary>ID of the user. Sortable: priority level 2.</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class DeliveryConfig : OrderCloudModel
	{
		/// <summary>ID of the delivery config. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the delivery config. Required. Max length 128 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Enabled of the delivery config.</summary>
		public bool Enabled { get => GetProp<bool>("Enabled"); set => SetProp<bool>("Enabled", value); }
		/// <summary>Delivery targets of the delivery config. Required.</summary>
		[Required]
		public DeliveryTargets DeliveryTargets { get => GetProp<DeliveryTargets>("DeliveryTargets"); set => SetProp<DeliveryTargets>("DeliveryTargets", value); }
	}
	public class DeliveryTargets : OrderCloudModel
	{
		/// <summary>Kafka of the delivery target.</summary>
		public KafkaConfig Kafka { get => GetProp<KafkaConfig>("Kafka"); set => SetProp<KafkaConfig>("Kafka", value); }
		/// <summary>Http of the delivery target.</summary>
		public HttpConfig Http { get => GetProp<HttpConfig>("Http"); set => SetProp<HttpConfig>("Http", value); }
		/// <summary>Search ingestion of the delivery target.</summary>
		public SearchIngestion SearchIngestion { get => GetProp<SearchIngestion>("SearchIngestion"); set => SetProp<SearchIngestion>("SearchIngestion", value); }
		/// <summary>Send event of the delivery target.</summary>
		public SendEvent SendEvent { get => GetProp<SendEvent>("SendEvent"); set => SetProp<SendEvent>("SendEvent", value); }
		/// <summary>Discover event of the delivery target.</summary>
		public DiscoverEvent DiscoverEvent { get => GetProp<DiscoverEvent>("DiscoverEvent"); set => SetProp<DiscoverEvent>("DiscoverEvent", value); }
		/// <summary>Event hub of the delivery target.</summary>
		public EventHubConfig EventHub { get => GetProp<EventHubConfig>("EventHub"); set => SetProp<EventHubConfig>("EventHub", value); }
		/// <summary>Azure blob of the delivery target.</summary>
		public AzureBlobConfig AzureBlob { get => GetProp<AzureBlobConfig>("AzureBlob"); set => SetProp<AzureBlobConfig>("AzureBlob", value); }
		/// <summary>Azure table of the delivery target.</summary>
		public AzureTableConfig AzureTable { get => GetProp<AzureTableConfig>("AzureTable"); set => SetProp<AzureTableConfig>("AzureTable", value); }
		/// <summary>Cosmos db of the delivery target.</summary>
		public CosmosDbConfig CosmosDb { get => GetProp<CosmosDbConfig>("CosmosDb"); set => SetProp<CosmosDbConfig>("CosmosDb", value); }
		/// <summary>Mandrill of the delivery target.</summary>
		public MandrillConfig Mandrill { get => GetProp<MandrillConfig>("Mandrill"); set => SetProp<MandrillConfig>("Mandrill", value); }
		/// <summary>Message sender of the delivery target.</summary>
		public MessageSenderConfig MessageSender { get => GetProp<MessageSenderConfig>("MessageSender"); set => SetProp<MessageSenderConfig>("MessageSender", value); }
		/// <summary>This feature is in preview and functionality is subject to change.</summary>
		public ContentHubConfig ContentHub { get => GetProp<ContentHubConfig>("ContentHub"); set => SetProp<ContentHubConfig>("ContentHub", value); }
	}
	public class DiscoverEvent : OrderCloudModel
	{
		/// <summary>ID of the client. Required.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
		/// <summary>Api key of the discover event. Required.</summary>
		[Required]
		[ApiWriteOnly]
		public string ApiKey { get => GetProp<string>("ApiKey"); set => SetProp<string>("ApiKey", value); }
		/// <summary>Service endpoint of the discover event. Required.</summary>
		[Required]
		public string ServiceEndpoint { get => GetProp<string>("ServiceEndpoint"); set => SetProp<string>("ServiceEndpoint", value); }
	}
	public class EligiblePromotion : OrderCloudModel
	{
		/// <summary>Amount of the eligible promotion.</summary>
		[ApiReadOnly]
		public decimal Amount { get => GetProp<decimal>("Amount"); set => SetProp<decimal>("Amount", value); }
		/// <summary>ID of the eligible promotion. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>If true, certain eligible expression requirements must be met, and the PromotionDiscount will be applied at the line item level.</summary>
		public bool LineItemLevel { get => GetProp<bool>("LineItemLevel"); set => SetProp<bool>("LineItemLevel", value); }
		/// <summary>Must be unique. Entered by buyer when adding promo to order.</summary>
		[Required]
		public string Code { get => GetProp<string>("Code"); set => SetProp<string>("Code", value); }
		/// <summary>Name of the eligible promotion. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Limit the total number of orders this promotion can be applied to across all users.</summary>
		public int? RedemptionLimit { get => GetProp<int?>("RedemptionLimit"); set => SetProp<int?>("RedemptionLimit", value); }
		/// <summary>Limit the total number of orders this promotion can be applied to per user.</summary>
		public int? RedemptionLimitPerUser { get => GetProp<int?>("RedemptionLimitPerUser"); set => SetProp<int?>("RedemptionLimitPerUser", value); }
		/// <summary>The number of times this promotion has been applied to an order.</summary>
		[ApiReadOnly]
		public int RedemptionCount { get => GetProp<int>("RedemptionCount"); set => SetProp<int>("RedemptionCount", value); }
		/// <summary>Can only be used when LineItemLevel is true and ItemLimitPerOrder does not have a value. When defined the ValueExpression will be the discount applied to each qualifying quantity of eligible items. When no ItemSortBy is defined, items will be sorted by DateAdded ascending.</summary>
		public int? QuantityLimitPerOrder { get => GetProp<int?>("QuantityLimitPerOrder"); set => SetProp<int?>("QuantityLimitPerOrder", value); }
		/// <summary>Can only be used when LineItemLevel is true and QuantityLimitPerOrder does not have a value. Limits the number of items the promotion will apply to when eligible. When no ItemSortBy is defined, items will be sorted by DateAdded ascending.</summary>
		public int? ItemLimitPerOrder { get => GetProp<int?>("ItemLimitPerOrder"); set => SetProp<int?>("ItemLimitPerOrder", value); }
		/// <summary>Comma delimited list of properties to sort by. Can only be used when ItemLimitPerOrder is true. Used to determine the order in which the promotion is applied to the specified limit of items. Use ! to reverse sort order on a property.</summary>
		public string ItemSortBy { get => GetProp<string>("ItemSortBy"); set => SetProp<string>("ItemSortBy", value); }
		/// <summary>Description of the eligible promotion. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Terms, conditions, and other legal jargon.</summary>
		public string FinePrint { get => GetProp<string>("FinePrint"); set => SetProp<string>("FinePrint", value); }
		/// <summary>Start date of the eligible promotion. Sortable.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>Expiration date of the eligible promotion. Sortable.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>The expression evaluated to determine if an item or order is eligible for a promotion. See Rules Engine documentation for formatting details.</summary>
		[Required]
		public string EligibleExpression { get => GetProp<string>("EligibleExpression"); set => SetProp<string>("EligibleExpression", value); }
		/// <summary>The expression evaluated to determine the discount amount of an eligible promotion. See Rules Engine documentation for formatting details.</summary>
		public string ValueExpression { get => GetProp<string>("ValueExpression"); set => SetProp<string>("ValueExpression", value); }
		/// <summary>If true, the promotion can be applied to an order that already other promotions applied, as long as they can also be combined.</summary>
		public bool CanCombine { get => GetProp<bool>("CanCombine"); set => SetProp<bool>("CanCombine", value); }
		/// <summary>Allow promo to be used by all buyers in your Marketplace without creating explicit assignments.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers"); set => SetProp<bool>("AllowAllBuyers", value); }
		/// <summary>ID of the organization that owns the Promotion. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Auto apply of the eligible promotion. Sortable.</summary>
		public bool AutoApply { get => GetProp<bool>("AutoApply", false); set => SetProp<bool>("AutoApply", value); }
		/// <summary>Active of the eligible promotion. Sortable.</summary>
		public bool Active { get => GetProp<bool>("Active", true); set => SetProp<bool>("Active", value); }
		/// <summary>Use integration of the eligible promotion.</summary>
		public bool UseIntegration { get => GetProp<bool>("UseIntegration"); set => SetProp<bool>("UseIntegration", value); }
		/// <summary>Used to control the order in which promotions are applied when calling the auto apply endpoint.</summary>
		public int? Priority { get => GetProp<int?>("Priority"); set => SetProp<int?>("Priority", value); }
		/// <summary>Container for extended (custom) properties of the eligible promotion.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic EligiblePromotion class instead.</typeparam>
	public class EligiblePromotion<Txp> : EligiblePromotion
	{
		/// <summary>Container for extended (custom) properties of the eligible promotion.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class EntitySyncConfig : OrderCloudModel
	{
		/// <summary>ID of the delivery config. Required.</summary>
		[Required]
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
		/// <summary>Sync entity changed of the entity sync config. Required.</summary>
		[Required]
		public bool SyncEntityChanged { get => GetProp<bool>("SyncEntityChanged"); set => SetProp<bool>("SyncEntityChanged", value); }
		/// <summary>Sync entity deleted of the entity sync config. Required.</summary>
		[Required]
		public bool SyncEntityDeleted { get => GetProp<bool>("SyncEntityDeleted"); set => SetProp<bool>("SyncEntityDeleted", value); }
	}
	public class ErrorConfig : OrderCloudModel
	{
		/// <summary>ID of the delivery config. Required.</summary>
		[Required]
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
	}
	public class EventHubConfig : OrderCloudModel
	{
		/// <summary>Event hub name of the event hub config. Required.</summary>
		[Required]
		public string EventHubName { get => GetProp<string>("EventHubName"); set => SetProp<string>("EventHubName", value); }
		/// <summary>Connection string of the event hub config. Required.</summary>
		[Required]
		[ApiWriteOnly]
		public string ConnectionString { get => GetProp<string>("ConnectionString"); set => SetProp<string>("ConnectionString", value); }
	}
	public class ExtendedLineItem : OrderCloudModel
	{
		/// <summary>ID of the order.</summary>
		public string OrderID { get => GetProp<string>("OrderID"); set => SetProp<string>("OrderID", value); }
		/// <summary>Currently unused.</summary>
		public Order Order { get => GetProp<Order>("Order"); set => SetProp<Order>("Order", value); }
		/// <summary>ID of the extended line item. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the product. Required. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>Quantity of the extended line item. Must be at least 1.</summary>
		public int Quantity { get => GetProp<int>("Quantity", 1); set => SetProp<int>("Quantity", value); }
		/// <summary>The ID of the Line Item that represents the bundle. Signifies that the Product is being purchased as part of a Bundle.</summary>
		[ApiReadOnly]
		public string BundleItemID { get => GetProp<string>("BundleItemID"); set => SetProp<string>("BundleItemID", value); }
		/// <summary>When true, this item represents a Bundle being purchased.</summary>
		[ApiReadOnly]
		public bool IsBundle { get => GetProp<bool>("IsBundle"); set => SetProp<bool>("IsBundle", value); }
		/// <summary>Date added of the extended line item. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateAdded { get => GetProp<DateTimeOffset>("DateAdded"); set => SetProp<DateTimeOffset>("DateAdded", value); }
		/// <summary>Sum of QuantityShipped from all shipment items.</summary>
		[ApiReadOnly]
		public int QuantityShipped { get => GetProp<int>("QuantityShipped"); set => SetProp<int>("QuantityShipped", value); }
		/// <summary>Auto calculated Price per Quantity. Modification requires OverrideUnitPrice Role.</summary>
		public decimal? UnitPrice { get => GetProp<decimal?>("UnitPrice"); set => SetProp<decimal?>("UnitPrice", value); }
		/// <summary>Sum of all line item level promotion discount amounts applied.</summary>
		[ApiReadOnly]
		public decimal PromotionDiscount { get => GetProp<decimal>("PromotionDiscount"); set => SetProp<decimal>("PromotionDiscount", value); }
		/// <summary>LineSubtotal - PromotionDiscount</summary>
		[ApiReadOnly]
		public decimal LineTotal { get => GetProp<decimal>("LineTotal"); set => SetProp<decimal>("LineTotal", value); }
		/// <summary>UnitPrice x Quantity</summary>
		[ApiReadOnly]
		public decimal LineSubtotal { get => GetProp<decimal>("LineSubtotal"); set => SetProp<decimal>("LineSubtotal", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior.</summary>
		public string CostCenter { get => GetProp<string>("CostCenter"); set => SetProp<string>("CostCenter", value); }
		/// <summary>Date needed of the extended line item.</summary>
		public DateTimeOffset? DateNeeded { get => GetProp<DateTimeOffset?>("DateNeeded"); set => SetProp<DateTimeOffset?>("DateNeeded", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior.</summary>
		public string ShippingAccount { get => GetProp<string>("ShippingAccount"); set => SetProp<string>("ShippingAccount", value); }
		/// <summary>ID of the shipping address.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from. Can be used to calculate shipping costs.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Product of the extended line item.</summary>
		[ApiReadOnly]
		public LineItemProduct Product { get => GetProp<LineItemProduct>("Product"); set => SetProp<LineItemProduct>("Product", value); }
		/// <summary>Variant of the extended line item.</summary>
		[ApiReadOnly]
		public LineItemVariant Variant { get => GetProp<LineItemVariant>("Variant"); set => SetProp<LineItemVariant>("Variant", value); }
		/// <summary>Shipping address of the extended line item.</summary>
		[ApiReadOnly]
		public Address ShippingAddress { get => GetProp<Address>("ShippingAddress"); set => SetProp<Address>("ShippingAddress", value); }
		/// <summary>Ship from address of the extended line item.</summary>
		[ApiReadOnly]
		public Address ShipFromAddress { get => GetProp<Address>("ShipFromAddress"); set => SetProp<Address>("ShipFromAddress", value); }
		/// <summary>ID of the supplier.</summary>
		[ApiReadOnly]
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
		/// <summary>Inventory Record ID of which product inventory location to use. The Inventory Record ID cannot be modified once an order is submitted.</summary>
		public string InventoryRecordID { get => GetProp<string>("InventoryRecordID"); set => SetProp<string>("InventoryRecordID", value); }
		/// <summary>ID of the Price Schedule used to determine Unit price.</summary>
		[ApiReadOnly]
		public string PriceScheduleID { get => GetProp<string>("PriceScheduleID"); set => SetProp<string>("PriceScheduleID", value); }
		/// <summary>True when the price schedule and price break has an active SalePrice.</summary>
		[ApiReadOnly]
		public bool IsOnSale { get => GetProp<bool>("IsOnSale"); set => SetProp<bool>("IsOnSale", value); }
		/// <summary>If true, UnitPrice was overwritten.</summary>
		[ApiReadOnly]
		public bool PriceOverridden { get => GetProp<bool>("PriceOverridden"); set => SetProp<bool>("PriceOverridden", value); }
		/// <summary>Specs of the extended line item.</summary>
		public IList<LineItemSpec> Specs { get => GetProp<IList<LineItemSpec>>("Specs", new List<LineItemSpec>()); set => SetProp<IList<LineItemSpec>>("Specs", value); }
		/// <summary>ID of the original order. Only returns a value for the Marketplace Owner.</summary>
		[ApiReadOnly]
		public string IncomingOrderID { get => GetProp<string>("IncomingOrderID"); set => SetProp<string>("IncomingOrderID", value); }
		/// <summary>ID of the split or forwarded order. Only returns a value for the Marketplace Owner.</summary>
		[ApiReadOnly]
		public string OutgoingOrderID { get => GetProp<string>("OutgoingOrderID"); set => SetProp<string>("OutgoingOrderID", value); }
		/// <summary>Features in beta are subject to change and are not available in production. ID of the invitation.</summary>
		[ApiReadOnly]
		public string InvitationID { get => GetProp<string>("InvitationID"); set => SetProp<string>("InvitationID", value); }
		/// <summary>Container for extended (custom) properties of the extended line item.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TOrder">Specific type of the Order property. If not using a custom type, specify Order.</typeparam>
	/// <typeparam name="TProduct">Specific type of the Product property. If not using a custom type, specify LineItemProduct.</typeparam>
	/// <typeparam name="TVariant">Specific type of the Variant property. If not using a custom type, specify LineItemVariant.</typeparam>
	/// <typeparam name="TShippingAddress">Specific type of the ShippingAddress property. If not using a custom type, specify Address.</typeparam>
	/// <typeparam name="TShipFromAddress">Specific type of the ShipFromAddress property. If not using a custom type, specify Address.</typeparam>
	public class ExtendedLineItem<Txp, TOrder, TProduct, TVariant, TShippingAddress, TShipFromAddress> : ExtendedLineItem
		where TOrder : Order
		where TProduct : LineItemProduct
		where TVariant : LineItemVariant
		where TShippingAddress : Address
		where TShipFromAddress : Address
	{
		/// <summary>Container for extended (custom) properties of the extended line item.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Currently unused.</summary>
		public new TOrder Order { get => GetProp<TOrder>("Order"); set => SetProp<TOrder>("Order", value); }
		/// <summary>Product of the extended line item.</summary>
		[ApiReadOnly]
		public new TProduct Product { get => GetProp<TProduct>("Product"); set => SetProp<TProduct>("Product", value); }
		/// <summary>Variant of the extended line item.</summary>
		[ApiReadOnly]
		public new TVariant Variant { get => GetProp<TVariant>("Variant"); set => SetProp<TVariant>("Variant", value); }
		/// <summary>Shipping address of the extended line item.</summary>
		[ApiReadOnly]
		public new TShippingAddress ShippingAddress { get => GetProp<TShippingAddress>("ShippingAddress"); set => SetProp<TShippingAddress>("ShippingAddress", value); }
		/// <summary>Ship from address of the extended line item.</summary>
		[ApiReadOnly]
		public new TShipFromAddress ShipFromAddress { get => GetProp<TShipFromAddress>("ShipFromAddress"); set => SetProp<TShipFromAddress>("ShipFromAddress", value); }
	}
	public class ExtendedOrder : OrderCloudModel
	{
		/// <summary>Line items of the extended order.</summary>
		public IList<LineItem> LineItems { get => GetProp<IList<LineItem>>("LineItems", new List<LineItem>()); set => SetProp<IList<LineItem>>("LineItems", value); }
		/// <summary>ID of the extended order. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>User placing the order.</summary>
		[ApiReadOnly]
		public User FromUser { get => GetProp<User>("FromUser"); set => SetProp<User>("FromUser", value); }
		/// <summary>ID of the Buyer or Marketplace Owner placing the order. Mainly useful to the Marketplace Owner or Supplier receiving it.</summary>
		public string FromCompanyID { get => GetProp<string>("FromCompanyID"); set => SetProp<string>("FromCompanyID", value); }
		/// <summary>ID of the Marketplace Owner or Supplier receiving the order, only writable on create. Mainly useful to the user placing it.</summary>
		public string ToCompanyID { get => GetProp<string>("ToCompanyID"); set => SetProp<string>("ToCompanyID", value); }
		/// <summary>This property is only writable when creating an order on behalf of a buyer user.</summary>
		public string FromUserID { get => GetProp<string>("FromUserID"); set => SetProp<string>("FromUserID", value); }
		/// <summary>ID of the billing address.</summary>
		public string BillingAddressID { get => GetProp<string>("BillingAddressID"); set => SetProp<string>("BillingAddressID", value); }
		/// <summary>Billing address of the extended order.</summary>
		[ApiReadOnly]
		public Address BillingAddress { get => GetProp<Address>("BillingAddress"); set => SetProp<Address>("BillingAddress", value); }
		/// <summary>ID of the Shipping Address for all LineItems on the Order. Null when there are multiple Shipping Addresses involved.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>Comments of the extended order. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
		/// <summary>Line item count of the extended order.</summary>
		[ApiReadOnly]
		public int LineItemCount { get => GetProp<int>("LineItemCount"); set => SetProp<int>("LineItemCount", value); }
		/// <summary>Status of the extended order. Sortable. Possible values: Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled.</summary>
		[ApiReadOnly]
		public OrderStatus Status { get => GetProp<OrderStatus>("Status"); set => SetProp<OrderStatus>("Status", value); }
		/// <summary>Date created of the extended order. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>NULL until the order passes from the buyer to the Marketplace Owner, including when Status is PendingApproval.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateSubmitted { get => GetProp<DateTimeOffset?>("DateSubmitted"); set => SetProp<DateTimeOffset?>("DateSubmitted", value); }
		/// <summary>Date approved of the extended order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateApproved { get => GetProp<DateTimeOffset?>("DateApproved"); set => SetProp<DateTimeOffset?>("DateApproved", value); }
		/// <summary>Date declined of the extended order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateDeclined { get => GetProp<DateTimeOffset?>("DateDeclined"); set => SetProp<DateTimeOffset?>("DateDeclined", value); }
		/// <summary>Date canceled of the extended order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCanceled { get => GetProp<DateTimeOffset?>("DateCanceled"); set => SetProp<DateTimeOffset?>("DateCanceled", value); }
		/// <summary>Populated when all items on an order have shipped, or the order is explicitly completed.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get => GetProp<DateTimeOffset?>("DateCompleted"); set => SetProp<DateTimeOffset?>("DateCompleted", value); }
		/// <summary>Last updated of the extended order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset LastUpdated { get => GetProp<DateTimeOffset>("LastUpdated"); set => SetProp<DateTimeOffset>("LastUpdated", value); }
		/// <summary>Sum of all LineItem.LineSubtotals.</summary>
		[ApiReadOnly]
		public decimal Subtotal { get => GetProp<decimal>("Subtotal"); set => SetProp<decimal>("Subtotal", value); }
		/// <summary>Modifying requires OverrideShipping Role.</summary>
		public decimal ShippingCost { get => GetProp<decimal>("ShippingCost"); set => SetProp<decimal>("ShippingCost", value); }
		/// <summary>Modifying requires TaxOverride Role.</summary>
		public decimal TaxCost { get => GetProp<decimal>("TaxCost"); set => SetProp<decimal>("TaxCost", value); }
		/// <summary>Gratuity of the extended order. Must be at least 0. Sortable.</summary>
		public decimal Gratuity { get => GetProp<decimal>("Gratuity", 0); set => SetProp<decimal>("Gratuity", value); }
		/// <summary>Sum of all Promotion.Amounts applied to the order.</summary>
		[ApiReadOnly]
		public decimal PromotionDiscount { get => GetProp<decimal>("PromotionDiscount"); set => SetProp<decimal>("PromotionDiscount", value); }
		/// <summary>Inherited from the user placing the order.</summary>
		[ApiReadOnly]
		public string Currency { get => GetProp<string>("Currency"); set => SetProp<string>("Currency", value); }
		/// <summary>Subtotal + TaxCost + ShippingCost + Gratuity - PromotionDiscount</summary>
		[ApiReadOnly]
		public decimal Total { get => GetProp<decimal>("Total"); set => SetProp<decimal>("Total", value); }
		/// <summary>True if this Order has been passed from the Buyer to the Marketplace Owner.</summary>
		[ApiReadOnly]
		public bool IsSubmitted { get => GetProp<bool>("IsSubmitted"); set => SetProp<bool>("IsSubmitted", value); }
		/// <summary>ID of the subscription used to create an order in an automated process.</summary>
		[ApiReadOnly]
		public string SubscriptionID { get => GetProp<string>("SubscriptionID"); set => SetProp<string>("SubscriptionID", value); }
		/// <summary>Container for extended (custom) properties of the extended order.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TLineItems">Specific type of the LineItems property. If not using a custom type, specify LineItem.</typeparam>
	/// <typeparam name="TFromUser">Specific type of the FromUser property. If not using a custom type, specify User.</typeparam>
	/// <typeparam name="TBillingAddress">Specific type of the BillingAddress property. If not using a custom type, specify Address.</typeparam>
	public class ExtendedOrder<Txp, TLineItems, TFromUser, TBillingAddress> : ExtendedOrder
		where TLineItems : LineItem
		where TFromUser : User
		where TBillingAddress : Address
	{
		/// <summary>Container for extended (custom) properties of the extended order.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Line items of the extended order.</summary>
		public new IList<TLineItems> LineItems { get => GetProp<IList<TLineItems>>("LineItems", new List<TLineItems>()); set => SetProp<IList<TLineItems>>("LineItems", value); }
		/// <summary>User placing the order.</summary>
		[ApiReadOnly]
		public new TFromUser FromUser { get => GetProp<TFromUser>("FromUser"); set => SetProp<TFromUser>("FromUser", value); }
		/// <summary>Billing address of the extended order.</summary>
		[ApiReadOnly]
		public new TBillingAddress BillingAddress { get => GetProp<TBillingAddress>("BillingAddress"); set => SetProp<TBillingAddress>("BillingAddress", value); }
	}
	/// <summary>Features in beta are subject to change and are not available in production.</summary>
	public class GroupOrderInvitation : OrderCloudModel
	{
		/// <summary>ID of the group order invitation. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>maximum 1 year.</summary>
		[Required]
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>Name of the group order invitation. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>ID of the order. Required. Searchable: priority level 3. Sortable: priority level 3.</summary>
		[Required]
		public string OrderID { get => GetProp<string>("OrderID"); set => SetProp<string>("OrderID", value); }
		/// <summary>Order status of the group order invitation. Searchable: priority level 4. Sortable: priority level 4. Possible values: Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled.</summary>
		[ApiReadOnly]
		public OrderStatus OrderStatus { get => GetProp<OrderStatus>("OrderStatus"); set => SetProp<OrderStatus>("OrderStatus", value); }
		/// <summary>Container for extended (custom) properties of the group order invitation.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <summary>Features in beta are subject to change and are not available in production.</summary>
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic GroupOrderInvitation class instead.</typeparam>
	public class GroupOrderInvitation<Txp> : GroupOrderInvitation
	{
		/// <summary>Container for extended (custom) properties of the group order invitation.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class HttpConfig : OrderCloudModel
	{
		/// <summary>Endpoint of the http config. Required.</summary>
		[Required]
		public string Endpoint { get => GetProp<string>("Endpoint"); set => SetProp<string>("Endpoint", value); }
		/// <summary>Secret of the http config. Required. Max length 50 characters.</summary>
		[Required]
		[ApiWriteOnly]
		public string Secret { get => GetProp<string>("Secret"); set => SetProp<string>("Secret", value); }
		/// <summary>Custom auth header name of the http config.</summary>
		public string CustomAuthHeaderName { get => GetProp<string>("CustomAuthHeaderName"); set => SetProp<string>("CustomAuthHeaderName", value); }
		/// <summary>Custom auth header value of the http config. Max length 50 characters.</summary>
		[ApiWriteOnly]
		public string CustomAuthHeaderValue { get => GetProp<string>("CustomAuthHeaderValue"); set => SetProp<string>("CustomAuthHeaderValue", value); }
	}
	public class ImpersonateTokenRequest : OrderCloudModel
	{
		/// <summary>ID of the client. Required.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
		/// <summary>Roles of the impersonate token request. Required.</summary>
		[Required]
		public IList<ApiRole> Roles { get => GetProp<IList<ApiRole>>("Roles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("Roles", value); }
		/// <summary>Custom roles of the impersonate token request.</summary>
		public IList<string> CustomRoles { get => GetProp<IList<string>>("CustomRoles", new List<string>()); set => SetProp<IList<string>>("CustomRoles", value); }
	}
	public class ImpersonationConfig : OrderCloudModel
	{
		/// <summary>ID of the impersonation config. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 8. Sortable: priority level 8.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>The Buyer ID of the impersonator group or user (party doing the impersonating)</summary>
		public string ImpersonationBuyerID { get => GetProp<string>("ImpersonationBuyerID"); set => SetProp<string>("ImpersonationBuyerID", value); }
		/// <summary>The UserGroupID of the impersonator (party doing the impersonating)</summary>
		public string ImpersonationGroupID { get => GetProp<string>("ImpersonationGroupID"); set => SetProp<string>("ImpersonationGroupID", value); }
		/// <summary>The UserID of the impersonator (party doing the impersonating)</summary>
		public string ImpersonationUserID { get => GetProp<string>("ImpersonationUserID"); set => SetProp<string>("ImpersonationUserID", value); }
		/// <summary>The BuyerID of the impersonatee (party being impersonated). If null, the config can be used to impersonate users in any buyer in the marketplace that is able to access the specified ClientID.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>The UserGroupID of the impersonatee (party being impersonated)</summary>
		public string GroupID { get => GetProp<string>("GroupID"); set => SetProp<string>("GroupID", value); }
		/// <summary>The UserID of the impersonatee (party being impersonated)</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
		/// <summary>ID of the security profile. Required. Searchable: priority level 6. Sortable: priority level 6.</summary>
		[Required]
		public string SecurityProfileID { get => GetProp<string>("SecurityProfileID"); set => SetProp<string>("SecurityProfileID", value); }
		/// <summary>ID of the client. Required. Searchable: priority level 7. Sortable: priority level 7.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
	}
	public class Incrementor : OrderCloudModel
	{
		/// <summary>The string "{replace-with-incrementor-ID}" can be passed into any ID field to populate the next ID in the sequence. It can also be prefixed with other ID safe characters.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the incrementor. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Increments as IDs are generated.</summary>
		[Required]
		public int LastNumber { get => GetProp<int>("LastNumber"); set => SetProp<int>("LastNumber", value); }
		/// <summary>Use to enforce a minimum incrementor ID length. For example if your LastNumber is 0 and LeftPaddingCount is 4, your first generated ID will be 0001.</summary>
		[Required]
		public int LeftPaddingCount { get => GetProp<int>("LeftPaddingCount"); set => SetProp<int>("LeftPaddingCount", value); }
	}
	public class IntegrationEvent : OrderCloudModel
	{
		/// <summary>Elevated roles of the integration event.</summary>
		public IList<ApiRole> ElevatedRoles { get => GetProp<IList<ApiRole>>("ElevatedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("ElevatedRoles", value); }
		/// <summary>ID of the integration event. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Any additional data needed for your Integration Event should be included here.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
		/// <summary>Event type of the integration event. Searchable: priority level 2. Sortable: priority level 2. Possible values: OrderCheckout, OpenIDConnect, OrderReturn, AddToCart.</summary>
		public IntegrationEventType EventType { get => GetProp<IntegrationEventType>("EventType"); set => SetProp<IntegrationEventType>("EventType", value); }
		/// <summary>URL the IntegrationEvent will POST data to, likely a route within your middleware.</summary>
		[Required]
		public string CustomImplementationUrl { get => GetProp<string>("CustomImplementationUrl"); set => SetProp<string>("CustomImplementationUrl", value); }
		/// <summary>The header name that can be passed to your middleware.</summary>
		public string CustomAuthHeaderName { get => GetProp<string>("CustomAuthHeaderName"); set => SetProp<string>("CustomAuthHeaderName", value); }
		/// <summary>The header value that can be passed to your middleware.</summary>
		[ApiWriteOnly]
		public string CustomAuthHeaderValue { get => GetProp<string>("CustomAuthHeaderValue"); set => SetProp<string>("CustomAuthHeaderValue", value); }
		/// <summary>Name of the integration event. Required. Searchable: priority level 3. Sortable: priority level 3.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Security feature that allows your middleware to verify the digital signature in the request header to ensure you only accept trusted data.</summary>
		[Required]
		public string HashKey { get => GetProp<string>("HashKey"); set => SetProp<string>("HashKey", value); }
	}
	public class Inventory : OrderCloudModel
	{
		/// <summary>If true, inventory will be tracked and enforced.</summary>
		public bool Enabled { get => GetProp<bool>("Enabled"); set => SetProp<bool>("Enabled", value); }
		/// <summary>Notification point of the inventory.</summary>
		public int? NotificationPoint { get => GetProp<int?>("NotificationPoint"); set => SetProp<int?>("NotificationPoint", value); }
		/// <summary>If true, QuantityAvailable will be determined at the Variant level.</summary>
		public bool VariantLevelTracking { get => GetProp<bool>("VariantLevelTracking"); set => SetProp<bool>("VariantLevelTracking", value); }
		/// <summary>If true, a user can create line items and place orders for the product even if there is insufficient QuantityAvailable.</summary>
		public bool OrderCanExceed { get => GetProp<bool>("OrderCanExceed"); set => SetProp<bool>("OrderCanExceed", value); }
		/// <summary>Automatically decrements on order submit. If you utilize InventoryRecords either at the product or variant level, this property becomes readonly, and is derived from the sum of all QuantityAvailable of each InventoryRecord. If VariantLevelTracking is enabled, this is the sum of all variant quantities, so the value may not be very useful beyond using it to filter out products with no variant level inventory available.</summary>
		public int? QuantityAvailable { get => GetProp<int?>("QuantityAvailable"); set => SetProp<int?>("QuantityAvailable", value); }
		/// <summary>Last updated of the inventory.</summary>
		[ApiReadOnly]
		public DateTimeOffset? LastUpdated { get => GetProp<DateTimeOffset?>("LastUpdated"); set => SetProp<DateTimeOffset?>("LastUpdated", value); }
	}
	public class InventoryIntegration : OrderCloudModel
	{
		/// <summary>ID of the delivery config. Required.</summary>
		[Required]
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
		/// <summary>When true, events will only fire when QuantityAvailable changes in the following ways: is equal to or less than 0, increases from 0 or less than 0 to a positive number, is equal to or less than NotificationPoint, increases from a number equal to or less than the NotificationPoint to a number greater than the NotificationPoint.</summary>
		public bool LimitNotifications { get => GetProp<bool>("LimitNotifications"); set => SetProp<bool>("LimitNotifications", value); }
	}
	public class InventoryRecord : OrderCloudModel
	{
		/// <summary>ID of the inventory record. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the owner.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Allow inventory record to be used by all buyers in your Marketplace without creating explicit assignments, defaults to true.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers", true); set => SetProp<bool>("AllowAllBuyers", value); }
		/// <summary>Address of the inventory record.</summary>
		[ApiReadOnly]
		public Address Address { get => GetProp<Address>("Address"); set => SetProp<Address>("Address", value); }
		/// <summary>Since an InventoryRecord represents a physical location where inventory for a given product exists, AddressID is required.</summary>
		[Required]
		public string AddressID { get => GetProp<string>("AddressID"); set => SetProp<string>("AddressID", value); }
		/// <summary>Order can exceed of the inventory record.</summary>
		public bool OrderCanExceed { get => GetProp<bool>("OrderCanExceed"); set => SetProp<bool>("OrderCanExceed", value); }
		/// <summary>Quantity available of the inventory record.</summary>
		public int QuantityAvailable { get => GetProp<int>("QuantityAvailable"); set => SetProp<int>("QuantityAvailable", value); }
		/// <summary>Notification point of the inventory record.</summary>
		public int? NotificationPoint { get => GetProp<int?>("NotificationPoint"); set => SetProp<int?>("NotificationPoint", value); }
		/// <summary>Last updated of the inventory record.</summary>
		[ApiReadOnly]
		public DateTimeOffset LastUpdated { get => GetProp<DateTimeOffset>("LastUpdated"); set => SetProp<DateTimeOffset>("LastUpdated", value); }
		/// <summary>Container for extended (custom) properties of the inventory record.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TAddress">Specific type of the Address property. If not using a custom type, specify Address.</typeparam>
	public class InventoryRecord<Txp, TAddress> : InventoryRecord
		where TAddress : Address
	{
		/// <summary>Container for extended (custom) properties of the inventory record.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Address of the inventory record.</summary>
		[ApiReadOnly]
		public new TAddress Address { get => GetProp<TAddress>("Address"); set => SetProp<TAddress>("Address", value); }
	}
	public class InventoryRecordAssignment : OrderCloudModel
	{
		/// <summary>ID of the inventory record. Required. Sortable: priority level 1.</summary>
		[Required]
		public string InventoryRecordID { get => GetProp<string>("InventoryRecordID"); set => SetProp<string>("InventoryRecordID", value); }
		/// <summary>ID of the buyer. Required. Sortable: priority level 2.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class KafkaConfig : OrderCloudModel
	{
		/// <summary>Bootstrap servers of the kafka config. Required.</summary>
		[Required]
		public string BootstrapServers { get => GetProp<string>("BootstrapServers"); set => SetProp<string>("BootstrapServers", value); }
		/// <summary>Sasl username of the kafka config. Required.</summary>
		[Required]
		public string SaslUsername { get => GetProp<string>("SaslUsername"); set => SetProp<string>("SaslUsername", value); }
		/// <summary>Sasl password of the kafka config. Required.</summary>
		[Required]
		[ApiWriteOnly]
		public string SaslPassword { get => GetProp<string>("SaslPassword"); set => SetProp<string>("SaslPassword", value); }
		/// <summary>Topic of the kafka config. Required.</summary>
		[Required]
		public string Topic { get => GetProp<string>("Topic"); set => SetProp<string>("Topic", value); }
	}
	public class LineItem : OrderCloudModel
	{
		/// <summary>ID of the line item. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the product. Required. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>Quantity of the line item. Must be at least 1.</summary>
		public int Quantity { get => GetProp<int>("Quantity", 1); set => SetProp<int>("Quantity", value); }
		/// <summary>The ID of the Line Item that represents the bundle. Signifies that the Product is being purchased as part of a Bundle.</summary>
		[ApiReadOnly]
		public string BundleItemID { get => GetProp<string>("BundleItemID"); set => SetProp<string>("BundleItemID", value); }
		/// <summary>When true, this item represents a Bundle being purchased.</summary>
		[ApiReadOnly]
		public bool IsBundle { get => GetProp<bool>("IsBundle"); set => SetProp<bool>("IsBundle", value); }
		/// <summary>Date added of the line item. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateAdded { get => GetProp<DateTimeOffset>("DateAdded"); set => SetProp<DateTimeOffset>("DateAdded", value); }
		/// <summary>Sum of QuantityShipped from all shipment items.</summary>
		[ApiReadOnly]
		public int QuantityShipped { get => GetProp<int>("QuantityShipped"); set => SetProp<int>("QuantityShipped", value); }
		/// <summary>Auto calculated Price per Quantity. Modification requires OverrideUnitPrice Role.</summary>
		public decimal? UnitPrice { get => GetProp<decimal?>("UnitPrice"); set => SetProp<decimal?>("UnitPrice", value); }
		/// <summary>Sum of all line item level promotion discount amounts applied.</summary>
		[ApiReadOnly]
		public decimal PromotionDiscount { get => GetProp<decimal>("PromotionDiscount"); set => SetProp<decimal>("PromotionDiscount", value); }
		/// <summary>LineSubtotal - PromotionDiscount</summary>
		[ApiReadOnly]
		public decimal LineTotal { get => GetProp<decimal>("LineTotal"); set => SetProp<decimal>("LineTotal", value); }
		/// <summary>UnitPrice x Quantity</summary>
		[ApiReadOnly]
		public decimal LineSubtotal { get => GetProp<decimal>("LineSubtotal"); set => SetProp<decimal>("LineSubtotal", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior.</summary>
		public string CostCenter { get => GetProp<string>("CostCenter"); set => SetProp<string>("CostCenter", value); }
		/// <summary>Date needed of the line item.</summary>
		public DateTimeOffset? DateNeeded { get => GetProp<DateTimeOffset?>("DateNeeded"); set => SetProp<DateTimeOffset?>("DateNeeded", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior.</summary>
		public string ShippingAccount { get => GetProp<string>("ShippingAccount"); set => SetProp<string>("ShippingAccount", value); }
		/// <summary>ID of the shipping address.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from. Can be used to calculate shipping costs.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Product of the line item.</summary>
		[ApiReadOnly]
		public LineItemProduct Product { get => GetProp<LineItemProduct>("Product"); set => SetProp<LineItemProduct>("Product", value); }
		/// <summary>Variant of the line item.</summary>
		[ApiReadOnly]
		public LineItemVariant Variant { get => GetProp<LineItemVariant>("Variant"); set => SetProp<LineItemVariant>("Variant", value); }
		/// <summary>Shipping address of the line item.</summary>
		[ApiReadOnly]
		public Address ShippingAddress { get => GetProp<Address>("ShippingAddress"); set => SetProp<Address>("ShippingAddress", value); }
		/// <summary>Ship from address of the line item.</summary>
		[ApiReadOnly]
		public Address ShipFromAddress { get => GetProp<Address>("ShipFromAddress"); set => SetProp<Address>("ShipFromAddress", value); }
		/// <summary>ID of the supplier.</summary>
		[ApiReadOnly]
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
		/// <summary>Inventory Record ID of which product inventory location to use. The Inventory Record ID cannot be modified once an order is submitted.</summary>
		public string InventoryRecordID { get => GetProp<string>("InventoryRecordID"); set => SetProp<string>("InventoryRecordID", value); }
		/// <summary>ID of the Price Schedule used to determine Unit price.</summary>
		[ApiReadOnly]
		public string PriceScheduleID { get => GetProp<string>("PriceScheduleID"); set => SetProp<string>("PriceScheduleID", value); }
		/// <summary>True when the price schedule and price break has an active SalePrice.</summary>
		[ApiReadOnly]
		public bool IsOnSale { get => GetProp<bool>("IsOnSale"); set => SetProp<bool>("IsOnSale", value); }
		/// <summary>If true, UnitPrice was overwritten.</summary>
		[ApiReadOnly]
		public bool PriceOverridden { get => GetProp<bool>("PriceOverridden"); set => SetProp<bool>("PriceOverridden", value); }
		/// <summary>Specs of the line item.</summary>
		public IList<LineItemSpec> Specs { get => GetProp<IList<LineItemSpec>>("Specs", new List<LineItemSpec>()); set => SetProp<IList<LineItemSpec>>("Specs", value); }
		/// <summary>ID of the original order. Only returns a value for the Marketplace Owner.</summary>
		[ApiReadOnly]
		public string IncomingOrderID { get => GetProp<string>("IncomingOrderID"); set => SetProp<string>("IncomingOrderID", value); }
		/// <summary>ID of the split or forwarded order. Only returns a value for the Marketplace Owner.</summary>
		[ApiReadOnly]
		public string OutgoingOrderID { get => GetProp<string>("OutgoingOrderID"); set => SetProp<string>("OutgoingOrderID", value); }
		/// <summary>Features in beta are subject to change and are not available in production. ID of the invitation.</summary>
		[ApiReadOnly]
		public string InvitationID { get => GetProp<string>("InvitationID"); set => SetProp<string>("InvitationID", value); }
		/// <summary>Container for extended (custom) properties of the line item.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TProduct">Specific type of the Product property. If not using a custom type, specify LineItemProduct.</typeparam>
	/// <typeparam name="TVariant">Specific type of the Variant property. If not using a custom type, specify LineItemVariant.</typeparam>
	/// <typeparam name="TShippingAddress">Specific type of the ShippingAddress property. If not using a custom type, specify Address.</typeparam>
	/// <typeparam name="TShipFromAddress">Specific type of the ShipFromAddress property. If not using a custom type, specify Address.</typeparam>
	public class LineItem<Txp, TProduct, TVariant, TShippingAddress, TShipFromAddress> : LineItem
		where TProduct : LineItemProduct
		where TVariant : LineItemVariant
		where TShippingAddress : Address
		where TShipFromAddress : Address
	{
		/// <summary>Container for extended (custom) properties of the line item.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Product of the line item.</summary>
		[ApiReadOnly]
		public new TProduct Product { get => GetProp<TProduct>("Product"); set => SetProp<TProduct>("Product", value); }
		/// <summary>Variant of the line item.</summary>
		[ApiReadOnly]
		public new TVariant Variant { get => GetProp<TVariant>("Variant"); set => SetProp<TVariant>("Variant", value); }
		/// <summary>Shipping address of the line item.</summary>
		[ApiReadOnly]
		public new TShippingAddress ShippingAddress { get => GetProp<TShippingAddress>("ShippingAddress"); set => SetProp<TShippingAddress>("ShippingAddress", value); }
		/// <summary>Ship from address of the line item.</summary>
		[ApiReadOnly]
		public new TShipFromAddress ShipFromAddress { get => GetProp<TShipFromAddress>("ShipFromAddress"); set => SetProp<TShipFromAddress>("ShipFromAddress", value); }
	}
	public class LineItemOverride : OrderCloudModel
	{
		/// <summary>ID of the line item.</summary>
		public string LineItemID { get => GetProp<string>("LineItemID"); set => SetProp<string>("LineItemID", value); }
		/// <summary>Unit price of the line item override.</summary>
		public decimal? UnitPrice { get => GetProp<decimal?>("UnitPrice"); set => SetProp<decimal?>("UnitPrice", value); }
		/// <summary>Product of the line item override.</summary>
		public PartialAdHocProduct Product { get => GetProp<PartialAdHocProduct>("Product"); set => SetProp<PartialAdHocProduct>("Product", value); }
		/// <summary>Promotion overrides of the line item override.</summary>
		public IList<PromotionOverride> PromotionOverrides { get => GetProp<IList<PromotionOverride>>("PromotionOverrides", new List<PromotionOverride>()); set => SetProp<IList<PromotionOverride>>("PromotionOverrides", value); }
		/// <summary>ID of the inventory record.</summary>
		public string InventoryRecordID { get => GetProp<string>("InventoryRecordID"); set => SetProp<string>("InventoryRecordID", value); }
		/// <summary>Remove of the line item override.</summary>
		public bool? Remove { get => GetProp<bool?>("Remove"); set => SetProp<bool?>("Remove", value); }
	}
	/// <typeparam name="TProduct">Specific type of the Product property. If not using a custom type, use the non-generic LineItemOverride class instead.</typeparam>
	public class LineItemOverride<TProduct> : LineItemOverride
		where TProduct : AdHocProduct
	{
		/// <summary>Product of the line item override.</summary>
		public new PartialAdHocProduct Product { get => GetProp<PartialAdHocProduct>("Product"); set => SetProp<PartialAdHocProduct>("Product", value); }
	}
	public class LineItemProduct : OrderCloudModel
	{
		/// <summary>ID of the line item product. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the line item product.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the line item product.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Returnable of the line item product.</summary>
		public bool Returnable { get => GetProp<bool>("Returnable"); set => SetProp<bool>("Returnable", value); }
		/// <summary>Quantity multiplier of the line item product.</summary>
		public int QuantityMultiplier { get => GetProp<int>("QuantityMultiplier"); set => SetProp<int>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the line item product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the line item product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the line item product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the line item product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>ID of the default supplier.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>ID of the parent.</summary>
		public string ParentID { get => GetProp<string>("ParentID"); set => SetProp<string>("ParentID", value); }
		/// <summary>Container for extended (custom) properties of the line item product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic LineItemProduct class instead.</typeparam>
	public class LineItemProduct<Txp> : LineItemProduct
	{
		/// <summary>Container for extended (custom) properties of the line item product.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class LineItemSpec : OrderCloudModel
	{
		/// <summary>ID of the spec. Required.</summary>
		[Required]
		public string SpecID { get => GetProp<string>("SpecID"); set => SetProp<string>("SpecID", value); }
		/// <summary>Name of the line item spec.</summary>
		[ApiReadOnly]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>ID of the option.</summary>
		public string OptionID { get => GetProp<string>("OptionID"); set => SetProp<string>("OptionID", value); }
		/// <summary>Value of the line item spec. Max length 2000 characters.</summary>
		public string Value { get => GetProp<string>("Value"); set => SetProp<string>("Value", value); }
		/// <summary>Price markup type of the line item spec. Possible values: NoMarkup, AmountPerQuantity, AmountTotal, Percentage.</summary>
		public PriceMarkupType? PriceMarkupType { get => GetProp<PriceMarkupType?>("PriceMarkupType"); set => SetProp<PriceMarkupType?>("PriceMarkupType", value); }
		/// <summary>Price markup of the line item spec.</summary>
		public decimal? PriceMarkup { get => GetProp<decimal?>("PriceMarkup"); set => SetProp<decimal?>("PriceMarkup", value); }
	}
	public class LineItemVariant : OrderCloudModel
	{
		/// <summary>ID of the line item variant. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the line item variant.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the line item variant.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Ship weight of the line item variant.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the line item variant.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the line item variant.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the line item variant.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>Container for extended (custom) properties of the line item variant.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic LineItemVariant class instead.</typeparam>
	public class LineItemVariant<Txp> : LineItemVariant
	{
		/// <summary>Container for extended (custom) properties of the line item variant.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class Locale : OrderCloudModel
	{
		/// <summary>ID of the locale. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the organization that owns the Locale. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>We recommend using ISO-4217 Currency Codes for compatibility with tax and payment processors.</summary>
		[Required]
		public string Currency { get => GetProp<string>("Currency"); set => SetProp<string>("Currency", value); }
		/// <summary>We recommend using ISO-639 Language code - ISO-3166 Country code (e.g. en-US).</summary>
		public string Language { get => GetProp<string>("Language"); set => SetProp<string>("Language", value); }
	}
	public class LocaleAssignment : OrderCloudModel
	{
		/// <summary>ID of the locale. Required. Sortable: priority level 1.</summary>
		[Required]
		public string LocaleID { get => GetProp<string>("LocaleID"); set => SetProp<string>("LocaleID", value); }
		/// <summary>ID of the buyer. Required. Sortable: priority level 2.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class MandrillConfig : OrderCloudModel
	{
		/// <summary>Api key of the mandrill config. Required. Max length 50 characters.</summary>
		[Required]
		[ApiWriteOnly]
		public string ApiKey { get => GetProp<string>("ApiKey"); set => SetProp<string>("ApiKey", value); }
	}
	public class MeBuyer : OrderCloudModel
	{
		/// <summary>ID of the buyer. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the default catalog.</summary>
		[ApiReadOnly]
		public string DefaultCatalogID { get => GetProp<string>("DefaultCatalogID"); set => SetProp<string>("DefaultCatalogID", value); }
	}
	public class MeSeller : OrderCloudModel
	{
		/// <summary>ID of the seller. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
	}
	public class MessageCCListenerAssignment : OrderCloudModel
	{
		/// <summary>Message sender assignment of the message cc listener assignment. Required.</summary>
		[Required]
		public MessageSenderAssignment MessageSenderAssignment { get => GetProp<MessageSenderAssignment>("MessageSenderAssignment"); set => SetProp<MessageSenderAssignment>("MessageSenderAssignment", value); }
		/// <summary>Message config name of the message cc listener assignment. Searchable: priority level 3. Sortable: priority level 3.</summary>
		[ApiReadOnly]
		public string MessageConfigName { get => GetProp<string>("MessageConfigName"); set => SetProp<string>("MessageConfigName", value); }
		/// <summary>Message config description of the message cc listener assignment.</summary>
		[ApiReadOnly]
		public string MessageConfigDescription { get => GetProp<string>("MessageConfigDescription"); set => SetProp<string>("MessageConfigDescription", value); }
		/// <summary>Message type of the message cc listener assignment. Required. Possible values: OrderDeclined, OrderSubmitted, ShipmentCreated, ForgottenPassword, ForgottenUsername, OrderSubmittedForYourApproval, OrderSubmittedForApproval, OrderApproved, OrderSubmittedForYourApprovalHasBeenApproved, OrderSubmittedForYourApprovalHasBeenDeclined, NewUserInvitation, OrderReturnDeclined, OrderReturnSubmitted, OrderReturnSubmittedForYourApproval, OrderReturnSubmittedForApproval, OrderReturnApproved, OrderReturnSubmittedForYourApprovalHasBeenApproved, OrderReturnSubmittedForYourApprovalHasBeenDeclined, OrderReturnCompleted, SubscriptionReminder, ProductCollectionInvitationAccepted, ProductCollectionInvitationDeclined.</summary>
		[Required]
		public MessageType MessageType { get => GetProp<MessageType>("MessageType"); set => SetProp<MessageType>("MessageType", value); }
		/// <summary>ID of the buyer. Searchable: priority level 0. Sortable: priority level 0.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the supplier. Searchable: priority level 4. Sortable: priority level 4.</summary>
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
		/// <summary>ID of the user group. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>ID of the user. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
	}
	public class MessageSender : OrderCloudModel
	{
		/// <summary>ID of the message sender. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 0. Sortable: priority level 0.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the message sender. Required. Searchable: priority level 1. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Message types of the message sender. Required.</summary>
		[Required]
		public IList<MessageType> MessageTypes { get => GetProp<IList<MessageType>>("MessageTypes", new List<MessageType>()); set => SetProp<IList<MessageType>>("MessageTypes", value); }
		/// <summary>Description of the message sender.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>URL the MessageSender will POST data to, likely a route within your middleware.</summary>
		public string URL { get => GetProp<string>("URL"); set => SetProp<string>("URL", value); }
		/// <summary>If additional data not provided by the message sender is needed, provide any elevated roles needed to make additional calls.</summary>
		public IList<ApiRole> ElevatedRoles { get => GetProp<IList<ApiRole>>("ElevatedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("ElevatedRoles", value); }
		/// <summary>Security feature that allows your middleware to verify the digital signature in the request header to ensure you only accept trusted data.</summary>
		public string SharedKey { get => GetProp<string>("SharedKey"); set => SetProp<string>("SharedKey", value); }
		/// <summary>Container for extended (custom) properties of the message sender.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>ID of the delivery config.</summary>
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
		/// <summary>Allow MessageSender to send to all buyers in your marketplace without creating explicit assignments, defaults to false.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers"); set => SetProp<bool>("AllowAllBuyers", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic MessageSender class instead.</typeparam>
	public class MessageSender<Txp> : MessageSender
	{
		/// <summary>Container for extended (custom) properties of the message sender.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class MessageSenderAssignment : OrderCloudModel
	{
		/// <summary>ID of the message sender. Required. Sortable: priority level 1.</summary>
		[Required]
		public string MessageSenderID { get => GetProp<string>("MessageSenderID"); set => SetProp<string>("MessageSenderID", value); }
		/// <summary>ID of the buyer. Sortable: priority level 2.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the supplier. Sortable: priority level 4.</summary>
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>Message config name of the message sender assignment. Searchable: priority level 1. Sortable: priority level 4.</summary>
		[ApiReadOnly]
		public string MessageConfigName { get => GetProp<string>("MessageConfigName"); set => SetProp<string>("MessageConfigName", value); }
		/// <summary>Message config description of the message sender assignment.</summary>
		[ApiReadOnly]
		public string MessageConfigDescription { get => GetProp<string>("MessageConfigDescription"); set => SetProp<string>("MessageConfigDescription", value); }
	}
	public class MessageSenderConfig : OrderCloudModel
	{
		/// <summary>Secret of the message sender config. Required. Max length 50 characters.</summary>
		[Required]
		[ApiWriteOnly]
		public string Secret { get => GetProp<string>("Secret"); set => SetProp<string>("Secret", value); }
		/// <summary>Endpoint of the message sender config. Required.</summary>
		[Required]
		public string Endpoint { get => GetProp<string>("Endpoint"); set => SetProp<string>("Endpoint", value); }
	}
	public class MeSupplier : OrderCloudModel
	{
		/// <summary>ID of the supplier. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
	}
	public class MeUser : OrderCloudModel
	{
		/// <summary>Buyer of the user.</summary>
		[ApiReadOnly]
		public MeBuyer Buyer { get => GetProp<MeBuyer>("Buyer"); set => SetProp<MeBuyer>("Buyer", value); }
		/// <summary>Supplier of the user.</summary>
		[ApiReadOnly]
		public MeSupplier Supplier { get => GetProp<MeSupplier>("Supplier"); set => SetProp<MeSupplier>("Supplier", value); }
		/// <summary>Seller of the user.</summary>
		[ApiReadOnly]
		public MeSeller Seller { get => GetProp<MeSeller>("Seller"); set => SetProp<MeSeller>("Seller", value); }
		/// <summary>ID of the user. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the company.</summary>
		[ApiReadOnly]
		public string CompanyID { get => GetProp<string>("CompanyID"); set => SetProp<string>("CompanyID", value); }
		/// <summary>Must be unique across the Marketplace.</summary>
		[Required]
		public string Username { get => GetProp<string>("Username"); set => SetProp<string>("Username", value); }
		/// <summary>Password of the user.</summary>
		[ApiWriteOnly]
		public string Password { get => GetProp<string>("Password"); set => SetProp<string>("Password", value); }
		/// <summary>First name of the user. Required. Max length 100 characters. Searchable: priority level 4. Sortable: priority level 2.</summary>
		[Required]
		public string FirstName { get => GetProp<string>("FirstName"); set => SetProp<string>("FirstName", value); }
		/// <summary>Last name of the user. Required. Max length 100 characters. Searchable: priority level 3. Sortable: priority level 1.</summary>
		[Required]
		public string LastName { get => GetProp<string>("LastName"); set => SetProp<string>("LastName", value); }
		/// <summary>Email of the user. Required. Max length 200 characters. Searchable: priority level 5. Sortable.</summary>
		[Required]
		public string Email { get => GetProp<string>("Email"); set => SetProp<string>("Email", value); }
		/// <summary>Phone of the user. Max length 100 characters.</summary>
		public string Phone { get => GetProp<string>("Phone"); set => SetProp<string>("Phone", value); }
		/// <summary>Terms accepted of the user.</summary>
		public DateTimeOffset? TermsAccepted { get => GetProp<DateTimeOffset?>("TermsAccepted"); set => SetProp<DateTimeOffset?>("TermsAccepted", value); }
		/// <summary>If false, authentication is prohibited.</summary>
		[Required]
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Container for extended (custom) properties of the user.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>List of Roles currently available to the user via all SecurityProfile Assignments.</summary>
		[ApiReadOnly]
		public IReadOnlyList<string> AvailableRoles { get => GetProp<IReadOnlyList<string>>("AvailableRoles"); set => SetProp<IReadOnlyList<string>>("AvailableRoles", value); }
		/// <summary>Most specific Locale assigned to the user, if any.</summary>
		[ApiReadOnly]
		public Locale Locale { get => GetProp<Locale>("Locale"); set => SetProp<Locale>("Locale", value); }
		/// <summary>Date created of the user. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Can be used in conjunction with SecurityProfile.PasswordConfig to enforce password reset schedules.</summary>
		[ApiReadOnly]
		public DateTimeOffset? PasswordLastSetDate { get => GetProp<DateTimeOffset?>("PasswordLastSetDate"); set => SetProp<DateTimeOffset?>("PasswordLastSetDate", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic MeUser class instead.</typeparam>
	public class MeUser<Txp> : MeUser
	{
		/// <summary>Container for extended (custom) properties of the user.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class OpenIdConnect : OrderCloudModel
	{
		/// <summary>ID of this OpenID Connect configuration object. Each object allows authentication to one OrderCloud ApiClient through one Identity Providing Party.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>An ID that references an OrderCloud ApiClient.</summary>
		[Required]
		public string OrderCloudApiClientID { get => GetProp<string>("OrderCloudApiClientID"); set => SetProp<string>("OrderCloudApiClientID", value); }
		/// <summary>An app ID from the Identity Provider that is required to get JWT tokens.</summary>
		[Required]
		public string ConnectClientID { get => GetProp<string>("ConnectClientID"); set => SetProp<string>("ConnectClientID", value); }
		/// <summary>A secret string from the Identity Provider that grants access to get JWT tokens.</summary>
		[Required]
		public string ConnectClientSecret { get => GetProp<string>("ConnectClientSecret"); set => SetProp<string>("ConnectClientSecret", value); }
		/// <summary>A URL on your front-end ordering site where users will be redirected after they authenticate through the Identity Provider. The string "{token}" will be replaced with a valid OrderCloud JWT.</summary>
		[Required]
		public string AppStartUrl { get => GetProp<string>("AppStartUrl"); set => SetProp<string>("AppStartUrl", value); }
		/// <summary>A publicly known URL from the Identity Provider that redirects to a resource where users enter personal credentials.</summary>
		[Required]
		public string AuthorizationEndpoint { get => GetProp<string>("AuthorizationEndpoint"); set => SetProp<string>("AuthorizationEndpoint", value); }
		/// <summary>A publicly known URL from the Identity Provider where agents can get JWT tokens.</summary>
		[Required]
		public string TokenEndpoint { get => GetProp<string>("TokenEndpoint"); set => SetProp<string>("TokenEndpoint", value); }
		/// <summary>If true, uses a url encoded form post with all auth values. Otherwise, an Authorization header with basic auth is passed with a JSON object in the body.</summary>
		public bool UrlEncoded { get => GetProp<bool>("UrlEncoded"); set => SetProp<bool>("UrlEncoded", value); }
		/// <summary>ID of the IntegrationEvent to call upon authorization request. Used when you haven't pre-populated users into OrderCloud, or need to sync user data.</summary>
		public string IntegrationEventID { get => GetProp<string>("IntegrationEventID"); set => SetProp<string>("IntegrationEventID", value); }
		/// <summary>If true, the integration event is always triggered regardless of if the user already exists in OrderCloud.</summary>
		public bool CallSyncUserIntegrationEvent { get => GetProp<bool>("CallSyncUserIntegrationEvent"); set => SetProp<bool>("CallSyncUserIntegrationEvent", value); }
		/// <summary>Integration event name of the open id connect.</summary>
		[ApiReadOnly]
		public string IntegrationEventName { get => GetProp<string>("IntegrationEventName"); set => SetProp<string>("IntegrationEventName", value); }
		/// <summary>Any additional scopes needed by the IDP.</summary>
		public IList<string> AdditionalIdpScopes { get => GetProp<IList<string>>("AdditionalIdpScopes", new List<string>()); set => SetProp<IList<string>>("AdditionalIdpScopes", value); }
		/// <summary>A URL on your front-end ordering site where users will be redirected if an error occurs while trying to authenticate.</summary>
		public string CustomErrorUrl { get => GetProp<string>("CustomErrorUrl"); set => SetProp<string>("CustomErrorUrl", value); }
	}
	public class Order : OrderCloudModel
	{
		/// <summary>ID of the order. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>User placing the order.</summary>
		[ApiReadOnly]
		public User FromUser { get => GetProp<User>("FromUser"); set => SetProp<User>("FromUser", value); }
		/// <summary>ID of the Buyer or Marketplace Owner placing the order. Mainly useful to the Marketplace Owner or Supplier receiving it.</summary>
		public string FromCompanyID { get => GetProp<string>("FromCompanyID"); set => SetProp<string>("FromCompanyID", value); }
		/// <summary>ID of the Marketplace Owner or Supplier receiving the order, only writable on create. Mainly useful to the user placing it.</summary>
		public string ToCompanyID { get => GetProp<string>("ToCompanyID"); set => SetProp<string>("ToCompanyID", value); }
		/// <summary>This property is only writable when creating an order on behalf of a buyer user.</summary>
		public string FromUserID { get => GetProp<string>("FromUserID"); set => SetProp<string>("FromUserID", value); }
		/// <summary>ID of the billing address.</summary>
		public string BillingAddressID { get => GetProp<string>("BillingAddressID"); set => SetProp<string>("BillingAddressID", value); }
		/// <summary>Billing address of the order.</summary>
		[ApiReadOnly]
		public Address BillingAddress { get => GetProp<Address>("BillingAddress"); set => SetProp<Address>("BillingAddress", value); }
		/// <summary>ID of the Shipping Address for all LineItems on the Order. Null when there are multiple Shipping Addresses involved.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>Comments of the order. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
		/// <summary>Line item count of the order.</summary>
		[ApiReadOnly]
		public int LineItemCount { get => GetProp<int>("LineItemCount"); set => SetProp<int>("LineItemCount", value); }
		/// <summary>Status of the order. Sortable. Possible values: Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled.</summary>
		[ApiReadOnly]
		public OrderStatus Status { get => GetProp<OrderStatus>("Status"); set => SetProp<OrderStatus>("Status", value); }
		/// <summary>Date created of the order. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>NULL until the order passes from the buyer to the Marketplace Owner, including when Status is PendingApproval.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateSubmitted { get => GetProp<DateTimeOffset?>("DateSubmitted"); set => SetProp<DateTimeOffset?>("DateSubmitted", value); }
		/// <summary>Date approved of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateApproved { get => GetProp<DateTimeOffset?>("DateApproved"); set => SetProp<DateTimeOffset?>("DateApproved", value); }
		/// <summary>Date declined of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateDeclined { get => GetProp<DateTimeOffset?>("DateDeclined"); set => SetProp<DateTimeOffset?>("DateDeclined", value); }
		/// <summary>Date canceled of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCanceled { get => GetProp<DateTimeOffset?>("DateCanceled"); set => SetProp<DateTimeOffset?>("DateCanceled", value); }
		/// <summary>Populated when all items on an order have shipped, or the order is explicitly completed.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get => GetProp<DateTimeOffset?>("DateCompleted"); set => SetProp<DateTimeOffset?>("DateCompleted", value); }
		/// <summary>Last updated of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset LastUpdated { get => GetProp<DateTimeOffset>("LastUpdated"); set => SetProp<DateTimeOffset>("LastUpdated", value); }
		/// <summary>Sum of all LineItem.LineSubtotals.</summary>
		[ApiReadOnly]
		public decimal Subtotal { get => GetProp<decimal>("Subtotal"); set => SetProp<decimal>("Subtotal", value); }
		/// <summary>Modifying requires OverrideShipping Role.</summary>
		public decimal ShippingCost { get => GetProp<decimal>("ShippingCost"); set => SetProp<decimal>("ShippingCost", value); }
		/// <summary>Modifying requires TaxOverride Role.</summary>
		public decimal TaxCost { get => GetProp<decimal>("TaxCost"); set => SetProp<decimal>("TaxCost", value); }
		/// <summary>Gratuity of the order. Must be at least 0. Sortable.</summary>
		public decimal Gratuity { get => GetProp<decimal>("Gratuity", 0); set => SetProp<decimal>("Gratuity", value); }
		/// <summary>Sum of all Promotion.Amounts applied to the order.</summary>
		[ApiReadOnly]
		public decimal PromotionDiscount { get => GetProp<decimal>("PromotionDiscount"); set => SetProp<decimal>("PromotionDiscount", value); }
		/// <summary>Inherited from the user placing the order.</summary>
		[ApiReadOnly]
		public string Currency { get => GetProp<string>("Currency"); set => SetProp<string>("Currency", value); }
		/// <summary>Subtotal + TaxCost + ShippingCost + Gratuity - PromotionDiscount</summary>
		[ApiReadOnly]
		public decimal Total { get => GetProp<decimal>("Total"); set => SetProp<decimal>("Total", value); }
		/// <summary>True if this Order has been passed from the Buyer to the Marketplace Owner.</summary>
		[ApiReadOnly]
		public bool IsSubmitted { get => GetProp<bool>("IsSubmitted"); set => SetProp<bool>("IsSubmitted", value); }
		/// <summary>ID of the subscription used to create an order in an automated process.</summary>
		[ApiReadOnly]
		public string SubscriptionID { get => GetProp<string>("SubscriptionID"); set => SetProp<string>("SubscriptionID", value); }
		/// <summary>Container for extended (custom) properties of the order.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TFromUser">Specific type of the FromUser property. If not using a custom type, specify User.</typeparam>
	/// <typeparam name="TBillingAddress">Specific type of the BillingAddress property. If not using a custom type, specify Address.</typeparam>
	public class Order<Txp, TFromUser, TBillingAddress> : Order
		where TFromUser : User
		where TBillingAddress : Address
	{
		/// <summary>Container for extended (custom) properties of the order.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>User placing the order.</summary>
		[ApiReadOnly]
		public new TFromUser FromUser { get => GetProp<TFromUser>("FromUser"); set => SetProp<TFromUser>("FromUser", value); }
		/// <summary>Billing address of the order.</summary>
		[ApiReadOnly]
		public new TBillingAddress BillingAddress { get => GetProp<TBillingAddress>("BillingAddress"); set => SetProp<TBillingAddress>("BillingAddress", value); }
	}
	public class OrderApproval : OrderCloudModel
	{
		/// <summary>If true, the submitting user will be able to modify the order and resubmit for approval.</summary>
		[ApiReadOnly]
		public bool AllowResubmit { get => GetProp<bool>("AllowResubmit"); set => SetProp<bool>("AllowResubmit", value); }
		/// <summary>ID of the approval rule. Searchable: priority level 1. Sortable.</summary>
		[ApiReadOnly]
		public string ApprovalRuleID { get => GetProp<string>("ApprovalRuleID"); set => SetProp<string>("ApprovalRuleID", value); }
		/// <summary>ID of the approving group. Searchable: priority level 2. Sortable.</summary>
		[ApiReadOnly]
		public string ApprovingGroupID { get => GetProp<string>("ApprovingGroupID"); set => SetProp<string>("ApprovingGroupID", value); }
		/// <summary>Status of the order approval. Sortable. Possible values: Pending, Approved, Declined.</summary>
		[ApiReadOnly]
		public ApprovalStatus Status { get => GetProp<ApprovalStatus>("Status"); set => SetProp<ApprovalStatus>("Status", value); }
		/// <summary>Date created of the order approval. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get => GetProp<DateTimeOffset>("DateCreated"); set => SetProp<DateTimeOffset>("DateCreated", value); }
		/// <summary>Date completed of the order approval. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get => GetProp<DateTimeOffset?>("DateCompleted"); set => SetProp<DateTimeOffset?>("DateCompleted", value); }
		/// <summary>Approver of the order approval. Searchable: priority level 3. Sortable.</summary>
		[ApiReadOnly]
		public User Approver { get => GetProp<User>("Approver"); set => SetProp<User>("Approver", value); }
		/// <summary>Comments of the order approval. Searchable: priority level 4.</summary>
		[ApiReadOnly]
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
	}
	/// <typeparam name="TApprover">Specific type of the Approver property. If not using a custom type, use the non-generic OrderApproval class instead.</typeparam>
	public class OrderApproval<TApprover> : OrderApproval
		where TApprover : User
	{
		/// <summary>Approver of the order approval. Searchable: priority level 3. Sortable.</summary>
		[ApiReadOnly]
		public new TApprover Approver { get => GetProp<TApprover>("Approver"); set => SetProp<TApprover>("Approver", value); }
	}
	public class OrderApprovalInfo : OrderCloudModel
	{
		/// <summary>Only relevant when declining an order. Changes the Order Status back to Unsubmitted and allows the user to make changes and resubmit.</summary>
		public bool AllowResubmit { get => GetProp<bool>("AllowResubmit"); set => SetProp<bool>("AllowResubmit", value); }
		/// <summary>Comments to be saved with the order approval or denial.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
	}
	public class OrderApprovedResponse : OrderCloudModel
	{
		/// <summary>Http status code of the order approved response.</summary>
		public int? HttpStatusCode { get => GetProp<int?>("HttpStatusCode"); set => SetProp<int?>("HttpStatusCode", value); }
		/// <summary>Unhandled error body of the order approved response.</summary>
		public string UnhandledErrorBody { get => GetProp<string>("UnhandledErrorBody"); set => SetProp<string>("UnhandledErrorBody", value); }
		/// <summary>Container for extended (custom) properties of the order approved response.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Succeeded of the order approved response.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic OrderApprovedResponse class instead.</typeparam>
	public class OrderApprovedResponse<Txp> : OrderApprovedResponse
	{
		/// <summary>Container for extended (custom) properties of the order approved response.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class OrderCalculateResponse : OrderCloudModel
	{
		/// <summary>Line item overrides of the order calculate response.</summary>
		public IList<LineItemOverride> LineItemOverrides { get => GetProp<IList<LineItemOverride>>("LineItemOverrides", new List<LineItemOverride>()); set => SetProp<IList<LineItemOverride>>("LineItemOverrides", value); }
		/// <summary>Shipping total of the order calculate response.</summary>
		public decimal? ShippingTotal { get => GetProp<decimal?>("ShippingTotal"); set => SetProp<decimal?>("ShippingTotal", value); }
		/// <summary>Tax total of the order calculate response.</summary>
		public decimal? TaxTotal { get => GetProp<decimal?>("TaxTotal"); set => SetProp<decimal?>("TaxTotal", value); }
		/// <summary>Http status code of the order calculate response.</summary>
		public int? HttpStatusCode { get => GetProp<int?>("HttpStatusCode"); set => SetProp<int?>("HttpStatusCode", value); }
		/// <summary>Unhandled error body of the order calculate response.</summary>
		public string UnhandledErrorBody { get => GetProp<string>("UnhandledErrorBody"); set => SetProp<string>("UnhandledErrorBody", value); }
		/// <summary>Container for extended (custom) properties of the order calculate response.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Succeeded of the order calculate response.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TLineItemOverrides">Specific type of the LineItemOverrides property. If not using a custom type, specify LineItemOverride.</typeparam>
	public class OrderCalculateResponse<Txp, TLineItemOverrides> : OrderCalculateResponse
		where TLineItemOverrides : LineItemOverride
	{
		/// <summary>Container for extended (custom) properties of the order calculate response.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Line item overrides of the order calculate response.</summary>
		public new IList<TLineItemOverrides> LineItemOverrides { get => GetProp<IList<TLineItemOverrides>>("LineItemOverrides", new List<TLineItemOverrides>()); set => SetProp<IList<TLineItemOverrides>>("LineItemOverrides", value); }
	}
	public class OrderPromotion : OrderCloudModel
	{
		/// <summary>Amount of the order promotion.</summary>
		[ApiReadOnly]
		public decimal Amount { get => GetProp<decimal>("Amount"); set => SetProp<decimal>("Amount", value); }
		/// <summary>ID of the line item.</summary>
		[ApiReadOnly]
		public string LineItemID { get => GetProp<string>("LineItemID"); set => SetProp<string>("LineItemID", value); }
		/// <summary>True when the Amount has been set via PromotionOverrides.</summary>
		[ApiReadOnly]
		public bool AmountOverridden { get => GetProp<bool>("AmountOverridden"); set => SetProp<bool>("AmountOverridden", value); }
		/// <summary>Date applied of the order promotion. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateApplied { get => GetProp<DateTimeOffset?>("DateApplied"); set => SetProp<DateTimeOffset?>("DateApplied", value); }
		/// <summary>ID of the order promotion. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>If true, certain eligible expression requirements must be met, and the PromotionDiscount will be applied at the line item level.</summary>
		public bool LineItemLevel { get => GetProp<bool>("LineItemLevel"); set => SetProp<bool>("LineItemLevel", value); }
		/// <summary>Must be unique. Entered by buyer when adding promo to order.</summary>
		[Required]
		public string Code { get => GetProp<string>("Code"); set => SetProp<string>("Code", value); }
		/// <summary>Name of the order promotion. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Limit the total number of orders this promotion can be applied to across all users.</summary>
		public int? RedemptionLimit { get => GetProp<int?>("RedemptionLimit"); set => SetProp<int?>("RedemptionLimit", value); }
		/// <summary>Limit the total number of orders this promotion can be applied to per user.</summary>
		public int? RedemptionLimitPerUser { get => GetProp<int?>("RedemptionLimitPerUser"); set => SetProp<int?>("RedemptionLimitPerUser", value); }
		/// <summary>The number of times this promotion has been applied to an order.</summary>
		[ApiReadOnly]
		public int RedemptionCount { get => GetProp<int>("RedemptionCount"); set => SetProp<int>("RedemptionCount", value); }
		/// <summary>Can only be used when LineItemLevel is true and ItemLimitPerOrder does not have a value. When defined the ValueExpression will be the discount applied to each qualifying quantity of eligible items. When no ItemSortBy is defined, items will be sorted by DateAdded ascending.</summary>
		public int? QuantityLimitPerOrder { get => GetProp<int?>("QuantityLimitPerOrder"); set => SetProp<int?>("QuantityLimitPerOrder", value); }
		/// <summary>Can only be used when LineItemLevel is true and QuantityLimitPerOrder does not have a value. Limits the number of items the promotion will apply to when eligible. When no ItemSortBy is defined, items will be sorted by DateAdded ascending.</summary>
		public int? ItemLimitPerOrder { get => GetProp<int?>("ItemLimitPerOrder"); set => SetProp<int?>("ItemLimitPerOrder", value); }
		/// <summary>Comma delimited list of properties to sort by. Can only be used when ItemLimitPerOrder is true. Used to determine the order in which the promotion is applied to the specified limit of items. Use ! to reverse sort order on a property.</summary>
		public string ItemSortBy { get => GetProp<string>("ItemSortBy"); set => SetProp<string>("ItemSortBy", value); }
		/// <summary>Description of the order promotion. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Terms, conditions, and other legal jargon.</summary>
		public string FinePrint { get => GetProp<string>("FinePrint"); set => SetProp<string>("FinePrint", value); }
		/// <summary>Start date of the order promotion. Sortable.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>Expiration date of the order promotion. Sortable.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>The expression evaluated to determine if an item or order is eligible for a promotion. See Rules Engine documentation for formatting details.</summary>
		[Required]
		public string EligibleExpression { get => GetProp<string>("EligibleExpression"); set => SetProp<string>("EligibleExpression", value); }
		/// <summary>The expression evaluated to determine the discount amount of an eligible promotion. See Rules Engine documentation for formatting details.</summary>
		public string ValueExpression { get => GetProp<string>("ValueExpression"); set => SetProp<string>("ValueExpression", value); }
		/// <summary>If true, the promotion can be applied to an order that already other promotions applied, as long as they can also be combined.</summary>
		public bool CanCombine { get => GetProp<bool>("CanCombine"); set => SetProp<bool>("CanCombine", value); }
		/// <summary>Allow promo to be used by all buyers in your Marketplace without creating explicit assignments.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers"); set => SetProp<bool>("AllowAllBuyers", value); }
		/// <summary>ID of the organization that owns the Promotion. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Auto apply of the order promotion. Sortable.</summary>
		public bool AutoApply { get => GetProp<bool>("AutoApply", false); set => SetProp<bool>("AutoApply", value); }
		/// <summary>Active of the order promotion. Sortable.</summary>
		public bool Active { get => GetProp<bool>("Active", true); set => SetProp<bool>("Active", value); }
		/// <summary>Use integration of the order promotion.</summary>
		public bool UseIntegration { get => GetProp<bool>("UseIntegration"); set => SetProp<bool>("UseIntegration", value); }
		/// <summary>Used to control the order in which promotions are applied when calling the auto apply endpoint.</summary>
		public int? Priority { get => GetProp<int?>("Priority"); set => SetProp<int?>("Priority", value); }
		/// <summary>Container for extended (custom) properties of the order promotion.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic OrderPromotion class instead.</typeparam>
	public class OrderPromotion<Txp> : OrderPromotion
	{
		/// <summary>Container for extended (custom) properties of the order promotion.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class OrderReturn : OrderCloudModel
	{
		/// <summary>ID of the order return. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the order. Required. Searchable: priority level 2. Sortable: priority level 4.</summary>
		[Required]
		public string OrderID { get => GetProp<string>("OrderID"); set => SetProp<string>("OrderID", value); }
		/// <summary>IDs of Payments associated with this OrderReturn.</summary>
		[ApiReadOnly]
		public IReadOnlyList<string> PaymentIDs { get => GetProp<IReadOnlyList<string>>("PaymentIDs"); set => SetProp<IReadOnlyList<string>>("PaymentIDs", value); }
		/// <summary>Status of the order return. Possible values: Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled.</summary>
		[ApiReadOnly]
		public OrderStatus Status { get => GetProp<OrderStatus>("Status"); set => SetProp<OrderStatus>("Status", value); }
		/// <summary>Date created of the order return. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>NULL until the order return passes from the buyer to the Marketplace Owner, including when Status is PendingApproval.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateSubmitted { get => GetProp<DateTimeOffset?>("DateSubmitted"); set => SetProp<DateTimeOffset?>("DateSubmitted", value); }
		/// <summary>Date approved of the order return. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateApproved { get => GetProp<DateTimeOffset?>("DateApproved"); set => SetProp<DateTimeOffset?>("DateApproved", value); }
		/// <summary>Date declined of the order return. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateDeclined { get => GetProp<DateTimeOffset?>("DateDeclined"); set => SetProp<DateTimeOffset?>("DateDeclined", value); }
		/// <summary>Date canceled of the order return. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCanceled { get => GetProp<DateTimeOffset?>("DateCanceled"); set => SetProp<DateTimeOffset?>("DateCanceled", value); }
		/// <summary>Populated when payment to customer has been completed.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get => GetProp<DateTimeOffset?>("DateCompleted"); set => SetProp<DateTimeOffset?>("DateCompleted", value); }
		/// <summary>Last updated of the order return. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset LastUpdated { get => GetProp<DateTimeOffset>("LastUpdated"); set => SetProp<DateTimeOffset>("LastUpdated", value); }
		/// <summary>Refund amount of the order return.</summary>
		public decimal? RefundAmount { get => GetProp<decimal?>("RefundAmount"); set => SetProp<decimal?>("RefundAmount", value); }
		/// <summary>Comments of the order return. Max length 2000 characters.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
		/// <summary>Items to return of the order return.</summary>
		public IList<OrderReturnItem> ItemsToReturn { get => GetProp<IList<OrderReturnItem>>("ItemsToReturn", new List<OrderReturnItem>()); set => SetProp<IList<OrderReturnItem>>("ItemsToReturn", value); }
		/// <summary>Container for extended (custom) properties of the order return.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic OrderReturn class instead.</typeparam>
	public class OrderReturn<Txp> : OrderReturn
	{
		/// <summary>Container for extended (custom) properties of the order return.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class OrderReturnApproval : OrderCloudModel
	{
		/// <summary>ID of the order return.</summary>
		public string OrderReturnID { get => GetProp<string>("OrderReturnID"); set => SetProp<string>("OrderReturnID", value); }
		/// <summary>ID of the approval rule. Searchable: priority level 1. Sortable.</summary>
		[ApiReadOnly]
		public string ApprovalRuleID { get => GetProp<string>("ApprovalRuleID"); set => SetProp<string>("ApprovalRuleID", value); }
		/// <summary>ID of the approving group. Searchable: priority level 2. Sortable.</summary>
		[ApiReadOnly]
		public string ApprovingGroupID { get => GetProp<string>("ApprovingGroupID"); set => SetProp<string>("ApprovingGroupID", value); }
		/// <summary>Status of the order return approval. Sortable. Possible values: Pending, Approved, Declined.</summary>
		[ApiReadOnly]
		public ApprovalStatus Status { get => GetProp<ApprovalStatus>("Status"); set => SetProp<ApprovalStatus>("Status", value); }
		/// <summary>Date created of the order return approval. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get => GetProp<DateTimeOffset>("DateCreated"); set => SetProp<DateTimeOffset>("DateCreated", value); }
		/// <summary>Date completed of the order return approval. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get => GetProp<DateTimeOffset?>("DateCompleted"); set => SetProp<DateTimeOffset?>("DateCompleted", value); }
		/// <summary>Approver of the order return approval. Searchable: priority level 3. Sortable.</summary>
		[ApiReadOnly]
		public User Approver { get => GetProp<User>("Approver"); set => SetProp<User>("Approver", value); }
		/// <summary>Comments of the order return approval. Searchable: priority level 4.</summary>
		[ApiReadOnly]
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
	}
	/// <typeparam name="TApprover">Specific type of the Approver property. If not using a custom type, use the non-generic OrderReturnApproval class instead.</typeparam>
	public class OrderReturnApproval<TApprover> : OrderReturnApproval
		where TApprover : User
	{
		/// <summary>Approver of the order return approval. Searchable: priority level 3. Sortable.</summary>
		[ApiReadOnly]
		public new TApprover Approver { get => GetProp<TApprover>("Approver"); set => SetProp<TApprover>("Approver", value); }
	}
	public class OrderReturnItem : OrderCloudModel
	{
		/// <summary>ID of the line item. Required.</summary>
		[Required]
		public string LineItemID { get => GetProp<string>("LineItemID"); set => SetProp<string>("LineItemID", value); }
		/// <summary>Quantity of the order return item. Must be at least 0.</summary>
		public int Quantity { get => GetProp<int>("Quantity", 0); set => SetProp<int>("Quantity", value); }
		/// <summary>Refund amount of the order return item.</summary>
		public decimal? RefundAmount { get => GetProp<decimal?>("RefundAmount"); set => SetProp<decimal?>("RefundAmount", value); }
		/// <summary>Comments of the order return item. Max length 500 characters.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
	}
	public class OrderShipMethodSelection : OrderCloudModel
	{
		/// <summary>Ship method selections of the order ship method selection.</summary>
		public IList<ShipMethodSelection> ShipMethodSelections { get => GetProp<IList<ShipMethodSelection>>("ShipMethodSelections", new List<ShipMethodSelection>()); set => SetProp<IList<ShipMethodSelection>>("ShipMethodSelections", value); }
	}
	public class OrderSplitResult : OrderCloudModel
	{
		/// <summary>The outgoing Orders created, one for each unique Product.DefaultSupplierID on the original Order.</summary>
		public IList<Order> OutgoingOrders { get => GetProp<IList<Order>>("OutgoingOrders", new List<Order>()); set => SetProp<IList<Order>>("OutgoingOrders", value); }
		/// <summary>IDs of Line Items not added to an outgoing Order, most likely because Product.DefaultSupplierID is not set.</summary>
		public IList<string> RemainingLineItemIDs { get => GetProp<IList<string>>("RemainingLineItemIDs", new List<string>()); set => SetProp<IList<string>>("RemainingLineItemIDs", value); }
	}
	/// <typeparam name="TOutgoingOrders">Specific type of the OutgoingOrders property. If not using a custom type, use the non-generic OrderSplitResult class instead.</typeparam>
	public class OrderSplitResult<TOutgoingOrders> : OrderSplitResult
		where TOutgoingOrders : Order
	{
		/// <summary>The outgoing Orders created, one for each unique Product.DefaultSupplierID on the original Order.</summary>
		public new IList<TOutgoingOrders> OutgoingOrders { get => GetProp<IList<TOutgoingOrders>>("OutgoingOrders", new List<TOutgoingOrders>()); set => SetProp<IList<TOutgoingOrders>>("OutgoingOrders", value); }
	}
	public class OrderSubmitForApprovalResponse : OrderCloudModel
	{
		/// <summary>Http status code of the order submit for approval response.</summary>
		public int? HttpStatusCode { get => GetProp<int?>("HttpStatusCode"); set => SetProp<int?>("HttpStatusCode", value); }
		/// <summary>Unhandled error body of the order submit for approval response.</summary>
		public string UnhandledErrorBody { get => GetProp<string>("UnhandledErrorBody"); set => SetProp<string>("UnhandledErrorBody", value); }
		/// <summary>Container for extended (custom) properties of the order submit for approval response.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Succeeded of the order submit for approval response.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic OrderSubmitForApprovalResponse class instead.</typeparam>
	public class OrderSubmitForApprovalResponse<Txp> : OrderSubmitForApprovalResponse
	{
		/// <summary>Container for extended (custom) properties of the order submit for approval response.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class OrderSubmitResponse : OrderCloudModel
	{
		/// <summary>Http status code of the order submit response.</summary>
		public int? HttpStatusCode { get => GetProp<int?>("HttpStatusCode"); set => SetProp<int?>("HttpStatusCode", value); }
		/// <summary>Unhandled error body of the order submit response.</summary>
		public string UnhandledErrorBody { get => GetProp<string>("UnhandledErrorBody"); set => SetProp<string>("UnhandledErrorBody", value); }
		/// <summary>Container for extended (custom) properties of the order submit response.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Succeeded of the order submit response.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic OrderSubmitResponse class instead.</typeparam>
	public class OrderSubmitResponse<Txp> : OrderSubmitResponse
	{
		/// <summary>Container for extended (custom) properties of the order submit response.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class OrderSyncConfig : OrderCloudModel
	{
		/// <summary>ID of the delivery config. Required.</summary>
		[Required]
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
		/// <summary>Config data of the order sync config.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
	}
	public class OrderWorksheet : OrderCloudModel
	{
		/// <summary>Order of the order worksheet.</summary>
		public Order Order { get => GetProp<Order>("Order"); set => SetProp<Order>("Order", value); }
		/// <summary>Line items of the order worksheet.</summary>
		public IList<LineItem> LineItems { get => GetProp<IList<LineItem>>("LineItems", new List<LineItem>()); set => SetProp<IList<LineItem>>("LineItems", value); }
		/// <summary>Order promotions of the order worksheet.</summary>
		public IList<OrderPromotion> OrderPromotions { get => GetProp<IList<OrderPromotion>>("OrderPromotions", new List<OrderPromotion>()); set => SetProp<IList<OrderPromotion>>("OrderPromotions", value); }
		/// <summary>Subscription of the order worksheet.</summary>
		public Subscription Subscription { get => GetProp<Subscription>("Subscription"); set => SetProp<Subscription>("Subscription", value); }
		/// <summary>Ship estimate response of the order worksheet.</summary>
		public ShipEstimateResponse ShipEstimateResponse { get => GetProp<ShipEstimateResponse>("ShipEstimateResponse"); set => SetProp<ShipEstimateResponse>("ShipEstimateResponse", value); }
		/// <summary>Order calculate response of the order worksheet.</summary>
		public OrderCalculateResponse OrderCalculateResponse { get => GetProp<OrderCalculateResponse>("OrderCalculateResponse"); set => SetProp<OrderCalculateResponse>("OrderCalculateResponse", value); }
		/// <summary>Order submit response of the order worksheet.</summary>
		public OrderSubmitResponse OrderSubmitResponse { get => GetProp<OrderSubmitResponse>("OrderSubmitResponse"); set => SetProp<OrderSubmitResponse>("OrderSubmitResponse", value); }
		/// <summary>Order submit for approval response of the order worksheet.</summary>
		public OrderSubmitForApprovalResponse OrderSubmitForApprovalResponse { get => GetProp<OrderSubmitForApprovalResponse>("OrderSubmitForApprovalResponse"); set => SetProp<OrderSubmitForApprovalResponse>("OrderSubmitForApprovalResponse", value); }
		/// <summary>Order approved response of the order worksheet.</summary>
		public OrderApprovedResponse OrderApprovedResponse { get => GetProp<OrderApprovedResponse>("OrderApprovedResponse"); set => SetProp<OrderApprovedResponse>("OrderApprovedResponse", value); }
		/// <summary>Subscription integration response of the order worksheet.</summary>
		public SubscriptionIntegrationResponse SubscriptionIntegrationResponse { get => GetProp<SubscriptionIntegrationResponse>("SubscriptionIntegrationResponse"); set => SetProp<SubscriptionIntegrationResponse>("SubscriptionIntegrationResponse", value); }
	}
	/// <typeparam name="TOrder">Specific type of the Order property. If not using a custom type, specify Order.</typeparam>
	/// <typeparam name="TLineItems">Specific type of the LineItems property. If not using a custom type, specify LineItem.</typeparam>
	/// <typeparam name="TOrderPromotions">Specific type of the OrderPromotions property. If not using a custom type, specify OrderPromotion.</typeparam>
	/// <typeparam name="TSubscription">Specific type of the Subscription property. If not using a custom type, specify Subscription.</typeparam>
	/// <typeparam name="TShipEstimateResponse">Specific type of the ShipEstimateResponse property. If not using a custom type, specify ShipEstimateResponse.</typeparam>
	/// <typeparam name="TOrderCalculateResponse">Specific type of the OrderCalculateResponse property. If not using a custom type, specify OrderCalculateResponse.</typeparam>
	/// <typeparam name="TOrderSubmitResponse">Specific type of the OrderSubmitResponse property. If not using a custom type, specify OrderSubmitResponse.</typeparam>
	/// <typeparam name="TOrderSubmitForApprovalResponse">Specific type of the OrderSubmitForApprovalResponse property. If not using a custom type, specify OrderSubmitForApprovalResponse.</typeparam>
	/// <typeparam name="TOrderApprovedResponse">Specific type of the OrderApprovedResponse property. If not using a custom type, specify OrderApprovedResponse.</typeparam>
	/// <typeparam name="TSubscriptionIntegrationResponse">Specific type of the SubscriptionIntegrationResponse property. If not using a custom type, specify SubscriptionIntegrationResponse.</typeparam>
	public class OrderWorksheet<TOrder, TLineItems, TOrderPromotions, TSubscription, TShipEstimateResponse, TOrderCalculateResponse, TOrderSubmitResponse, TOrderSubmitForApprovalResponse, TOrderApprovedResponse, TSubscriptionIntegrationResponse> : OrderWorksheet
		where TOrder : Order
		where TLineItems : LineItem
		where TOrderPromotions : OrderPromotion
		where TSubscription : Subscription
		where TShipEstimateResponse : ShipEstimateResponse
		where TOrderCalculateResponse : OrderCalculateResponse
		where TOrderSubmitResponse : OrderSubmitResponse
		where TOrderSubmitForApprovalResponse : OrderSubmitForApprovalResponse
		where TOrderApprovedResponse : OrderApprovedResponse
		where TSubscriptionIntegrationResponse : SubscriptionIntegrationResponse
	{
		/// <summary>Order of the order worksheet.</summary>
		public new TOrder Order { get => GetProp<TOrder>("Order"); set => SetProp<TOrder>("Order", value); }
		/// <summary>Line items of the order worksheet.</summary>
		public new IList<TLineItems> LineItems { get => GetProp<IList<TLineItems>>("LineItems", new List<TLineItems>()); set => SetProp<IList<TLineItems>>("LineItems", value); }
		/// <summary>Order promotions of the order worksheet.</summary>
		public new IList<TOrderPromotions> OrderPromotions { get => GetProp<IList<TOrderPromotions>>("OrderPromotions", new List<TOrderPromotions>()); set => SetProp<IList<TOrderPromotions>>("OrderPromotions", value); }
		/// <summary>Subscription of the order worksheet.</summary>
		public new TSubscription Subscription { get => GetProp<TSubscription>("Subscription"); set => SetProp<TSubscription>("Subscription", value); }
		/// <summary>Ship estimate response of the order worksheet.</summary>
		public new TShipEstimateResponse ShipEstimateResponse { get => GetProp<TShipEstimateResponse>("ShipEstimateResponse"); set => SetProp<TShipEstimateResponse>("ShipEstimateResponse", value); }
		/// <summary>Order calculate response of the order worksheet.</summary>
		public new TOrderCalculateResponse OrderCalculateResponse { get => GetProp<TOrderCalculateResponse>("OrderCalculateResponse"); set => SetProp<TOrderCalculateResponse>("OrderCalculateResponse", value); }
		/// <summary>Order submit response of the order worksheet.</summary>
		public new TOrderSubmitResponse OrderSubmitResponse { get => GetProp<TOrderSubmitResponse>("OrderSubmitResponse"); set => SetProp<TOrderSubmitResponse>("OrderSubmitResponse", value); }
		/// <summary>Order submit for approval response of the order worksheet.</summary>
		public new TOrderSubmitForApprovalResponse OrderSubmitForApprovalResponse { get => GetProp<TOrderSubmitForApprovalResponse>("OrderSubmitForApprovalResponse"); set => SetProp<TOrderSubmitForApprovalResponse>("OrderSubmitForApprovalResponse", value); }
		/// <summary>Order approved response of the order worksheet.</summary>
		public new TOrderApprovedResponse OrderApprovedResponse { get => GetProp<TOrderApprovedResponse>("OrderApprovedResponse"); set => SetProp<TOrderApprovedResponse>("OrderApprovedResponse", value); }
		/// <summary>Subscription integration response of the order worksheet.</summary>
		public new TSubscriptionIntegrationResponse SubscriptionIntegrationResponse { get => GetProp<TSubscriptionIntegrationResponse>("SubscriptionIntegrationResponse"); set => SetProp<TSubscriptionIntegrationResponse>("SubscriptionIntegrationResponse", value); }
	}
	public class PasswordConfig : OrderCloudModel
	{
		/// <summary>The number of passwords, including the current password, that are blocked from reuse. For example, if set to 1, any password except the current one can be reused.</summary>
		public int? LimitPasswordReuse { get => GetProp<int?>("LimitPasswordReuse"); set => SetProp<int?>("LimitPasswordReuse", value); }
		/// <summary>The maximum number of consecutive repeating characters in a password.</summary>
		public int? MaxConsecutiveDupeChars { get => GetProp<int?>("MaxConsecutiveDupeChars"); set => SetProp<int?>("MaxConsecutiveDupeChars", value); }
		/// <summary>The password expires after MaximumPasswordAge in days.</summary>
		public int? MaximumPasswordAge { get => GetProp<int?>("MaximumPasswordAge"); set => SetProp<int?>("MaximumPasswordAge", value); }
		/// <summary>The password may not be changed again until this number of minutes has passed.</summary>
		public int? MinimumPasswordAge { get => GetProp<int?>("MinimumPasswordAge"); set => SetProp<int?>("MinimumPasswordAge", value); }
		/// <summary>The number of failed attempts before the account is Locked for the LockoutDuration.</summary>
		public int? AllowedFailedAttempts { get => GetProp<int?>("AllowedFailedAttempts"); set => SetProp<int?>("AllowedFailedAttempts", value); }
		/// <summary>The number of minutes an account is locked when the AllowedFailedAttempts is reached. Use 0 to indicate that lockout should be indefinite (i.e. require the intervention of a user admininstrator).</summary>
		public int? LockoutDuration { get => GetProp<int?>("LockoutDuration"); set => SetProp<int?>("LockoutDuration", value); }
		/// <summary>At least one upper case character is required.</summary>
		public bool UpperCaseRequired { get => GetProp<bool>("UpperCaseRequired"); set => SetProp<bool>("UpperCaseRequired", value); }
		/// <summary>At least one lower case character is required.</summary>
		public bool LowerCaseRequired { get => GetProp<bool>("LowerCaseRequired"); set => SetProp<bool>("LowerCaseRequired", value); }
		/// <summary>At least one special character is required.</summary>
		public bool SpecialCharacterRequired { get => GetProp<bool>("SpecialCharacterRequired"); set => SetProp<bool>("SpecialCharacterRequired", value); }
		/// <summary>At least one number is required.</summary>
		public bool NumericRequired { get => GetProp<bool>("NumericRequired"); set => SetProp<bool>("NumericRequired", value); }
		/// <summary>The minimum length of a password.</summary>
		public int? MinimumCharacterCount { get => GetProp<int?>("MinimumCharacterCount"); set => SetProp<int?>("MinimumCharacterCount", value); }
	}
	public class PasswordReset : OrderCloudModel
	{
		/// <summary>ID of the client. Required.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
		/// <summary>Username of the password reset. Required.</summary>
		[Required]
		public string Username { get => GetProp<string>("Username"); set => SetProp<string>("Username", value); }
		/// <summary>Password of the password reset.</summary>
		public string Password { get => GetProp<string>("Password"); set => SetProp<string>("Password", value); }
	}
	public class PasswordResetRequest : OrderCloudModel
	{
		/// <summary>ID of the client. Required.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
		/// <summary>Email of the password reset request.</summary>
		public string Email { get => GetProp<string>("Email"); set => SetProp<string>("Email", value); }
		/// <summary>Username of the password reset request.</summary>
		public string Username { get => GetProp<string>("Username"); set => SetProp<string>("Username", value); }
		/// <summary>URL of the password reset request.</summary>
		public string URL { get => GetProp<string>("URL"); set => SetProp<string>("URL", value); }
	}
	public class Payment : OrderCloudModel
	{
		/// <summary>ID of the payment. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Type of the payment. Sortable. Possible values: PurchaseOrder, CreditCard, SpendingAccount.</summary>
		public PaymentType? Type { get => GetProp<PaymentType?>("Type"); set => SetProp<PaymentType?>("Type", value); }
		/// <summary>Date created of the payment. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get => GetProp<DateTimeOffset>("DateCreated"); set => SetProp<DateTimeOffset>("DateCreated", value); }
		/// <summary>Only writeable on POST.</summary>
		public string CreditCardID { get => GetProp<string>("CreditCardID"); set => SetProp<string>("CreditCardID", value); }
		/// <summary>Only writeable on POST.</summary>
		public string SpendingAccountID { get => GetProp<string>("SpendingAccountID"); set => SetProp<string>("SpendingAccountID", value); }
		/// <summary>Description of the payment. Max length 2000 characters. Searchable: priority level 2.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Inherited from Order.</summary>
		[ApiReadOnly]
		public string Currency { get => GetProp<string>("Currency"); set => SetProp<string>("Currency", value); }
		/// <summary>If null, Payment applies to order total (or total of specific Line Items, if set), minus any other Payments where Amount is set. Value can only be negative if processing a payment for an OrderReturn.</summary>
		public decimal? Amount { get => GetProp<decimal?>("Amount"); set => SetProp<decimal?>("Amount", value); }
		/// <summary>All payments must be Accepted to submit an order. This property should be updated after authorizing or capturing the payment in your middleware by a user with the elevated OrderAdmin role.</summary>
		public bool? Accepted { get => GetProp<bool?>("Accepted"); set => SetProp<bool?>("Accepted", value); }
		/// <summary>Used to indicate this payment is associated with an Order Return.</summary>
		public string OrderReturnID { get => GetProp<string>("OrderReturnID"); set => SetProp<string>("OrderReturnID", value); }
		/// <summary>Container for extended (custom) properties of the payment.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Transactions of the payment.</summary>
		[ApiReadOnly]
		public IReadOnlyList<PaymentTransaction> Transactions { get => GetProp<IReadOnlyList<PaymentTransaction>>("Transactions"); set => SetProp<IReadOnlyList<PaymentTransaction>>("Transactions", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TTransactions">Specific type of the Transactions property. If not using a custom type, specify PaymentTransaction.</typeparam>
	public class Payment<Txp, TTransactions> : Payment
		where TTransactions : PaymentTransaction
	{
		/// <summary>Container for extended (custom) properties of the payment.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Transactions of the payment.</summary>
		[ApiReadOnly]
		public new IReadOnlyList<TTransactions> Transactions { get => GetProp<IReadOnlyList<TTransactions>>("Transactions"); set => SetProp<IReadOnlyList<TTransactions>>("Transactions", value); }
	}
	public class PaymentTransaction : OrderCloudModel
	{
		/// <summary>ID of the payment transaction. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Type of the payment transaction. Required. Sortable.</summary>
		[Required]
		public string Type { get => GetProp<string>("Type"); set => SetProp<string>("Type", value); }
		/// <summary>Date executed of the payment transaction. Required. Sortable: priority level 1.</summary>
		[Required]
		public DateTimeOffset DateExecuted { get => GetProp<DateTimeOffset>("DateExecuted"); set => SetProp<DateTimeOffset>("DateExecuted", value); }
		/// <summary>Usually the same as Payment Currency, but can be different. A marketplace may capture funds from the buyer user in one currency and process a payout to the seller in another.</summary>
		public string Currency { get => GetProp<string>("Currency"); set => SetProp<string>("Currency", value); }
		/// <summary>Usually the same as Payment Amount, but can be different. A charge might have a subsequent partial credit, for example.</summary>
		public decimal? Amount { get => GetProp<decimal?>("Amount"); set => SetProp<decimal?>("Amount", value); }
		/// <summary>Succeeded of the payment transaction. Sortable.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
		/// <summary>Result code of the payment transaction. Sortable.</summary>
		public string ResultCode { get => GetProp<string>("ResultCode"); set => SetProp<string>("ResultCode", value); }
		/// <summary>Result message of the payment transaction. Sortable.</summary>
		public string ResultMessage { get => GetProp<string>("ResultMessage"); set => SetProp<string>("ResultMessage", value); }
		/// <summary>Container for extended (custom) properties of the payment transaction.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PaymentTransaction class instead.</typeparam>
	public class PaymentTransaction<Txp> : PaymentTransaction
	{
		/// <summary>Container for extended (custom) properties of the payment transaction.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class PriceBreak : OrderCloudModel
	{
		/// <summary>Most commonly 1, except when offering tiered/bulk pricing.</summary>
		[Required]
		public int Quantity { get => GetProp<int>("Quantity"); set => SetProp<int>("Quantity", value); }
		/// <summary>Price per unit.</summary>
		[Required]
		public decimal Price { get => GetProp<decimal>("Price"); set => SetProp<decimal>("Price", value); }
		/// <summary>Optional. Sale Price per unit. If the current date/time is within the PriceSchedule SaleStart and SaleEnd, this SalePrice will be used.</summary>
		public decimal? SalePrice { get => GetProp<decimal?>("SalePrice"); set => SetProp<decimal?>("SalePrice", value); }
		/// <summary>Optional. Subscription Price per unit. If set, this price is used when a subscription order is created.</summary>
		public decimal? SubscriptionPrice { get => GetProp<decimal?>("SubscriptionPrice"); set => SetProp<decimal?>("SubscriptionPrice", value); }
		/// <summary>Optional. Bundle Price per unit. If set, this price is used when an item being added to an order is part of a bundle.</summary>
		public decimal? BundlePrice { get => GetProp<decimal?>("BundlePrice"); set => SetProp<decimal?>("BundlePrice", value); }
	}
	public class PriceSchedule : OrderCloudModel
	{
		/// <summary>ID of the organization that owns the PriceSchedule. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>ID of the price schedule. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the price schedule. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>For reference only for calculating tax, does not influence any OrderCloud behavior.</summary>
		public bool ApplyTax { get => GetProp<bool>("ApplyTax"); set => SetProp<bool>("ApplyTax", value); }
		/// <summary>For reference only for calculating shipping cost, does not influence any OrderCloud behavior.</summary>
		public bool ApplyShipping { get => GetProp<bool>("ApplyShipping"); set => SetProp<bool>("ApplyShipping", value); }
		/// <summary>The minimum quantity allowed per order.</summary>
		public int? MinQuantity { get => GetProp<int?>("MinQuantity", 1); set => SetProp<int?>("MinQuantity", value); }
		/// <summary>The maximum quantity allowed per order.</summary>
		public int? MaxQuantity { get => GetProp<int?>("MaxQuantity"); set => SetProp<int?>("MaxQuantity", value); }
		/// <summary>If true, LineItem quantities will be aggregated by productID when determining which price break applies, and when Min/Max quantities are met. Else, each LineItem is treated separately.</summary>
		public bool UseCumulativeQuantity { get => GetProp<bool>("UseCumulativeQuantity"); set => SetProp<bool>("UseCumulativeQuantity", value); }
		/// <summary>If true, this product can only be ordered in quantities that exactly match one of the price breaks on this schedule.</summary>
		public bool RestrictedQuantity { get => GetProp<bool>("RestrictedQuantity"); set => SetProp<bool>("RestrictedQuantity", value); }
		/// <summary>Price breaks of the price schedule.</summary>
		public IList<PriceBreak> PriceBreaks { get => GetProp<IList<PriceBreak>>("PriceBreaks", new List<PriceBreak>()); set => SetProp<IList<PriceBreak>>("PriceBreaks", value); }
		/// <summary>We recommend using ISO-4217 Currency Codes for compatibility with tax and payment processors.</summary>
		public string Currency { get => GetProp<string>("Currency"); set => SetProp<string>("Currency", value); }
		/// <summary>Optional. Starting date/time for PriceBreak.SalePrice to be used as the price for the LineItem. Requires that the PriceBreak.SalePrice value is set.</summary>
		public DateTimeOffset? SaleStart { get => GetProp<DateTimeOffset?>("SaleStart", null); set => SetProp<DateTimeOffset?>("SaleStart", value); }
		/// <summary>Optional. Ending date/time for PriceBreak.SalePrice to be used as the price for the LineItem. Requires that the PriceBreak.SalePrice value is set.</summary>
		public DateTimeOffset? SaleEnd { get => GetProp<DateTimeOffset?>("SaleEnd", null); set => SetProp<DateTimeOffset?>("SaleEnd", value); }
		/// <summary>True when at least one PriceBreak has a SalePrice defined, and it falls between the SaleStart and SaleEnd date, if applicable.</summary>
		[ApiReadOnly]
		public bool IsOnSale { get => GetProp<bool>("IsOnSale"); set => SetProp<bool>("IsOnSale", value); }
		/// <summary>Container for extended (custom) properties of the price schedule.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PriceSchedule class instead.</typeparam>
	public class PriceSchedule<Txp> : PriceSchedule
	{
		/// <summary>Container for extended (custom) properties of the price schedule.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class Product : OrderCloudModel
	{
		/// <summary>ID of the organization that owns the Product. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>When provided, no explicit PriceSchedule assignment is required. When a PriceSchedule assignment exists, it will override any default provided.</summary>
		public string DefaultPriceScheduleID { get => GetProp<string>("DefaultPriceScheduleID"); set => SetProp<string>("DefaultPriceScheduleID", value); }
		/// <summary>If true, when this product is ordered by a Buyer, it will automatically be added to a new Order from the Marketplace Owner to the Default Supplier and submitted. Requires a valid DefaultSupplierID.</summary>
		public bool AutoForward { get => GetProp<bool>("AutoForward"); set => SetProp<bool>("AutoForward", value); }
		/// <summary>ID of the product. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the parent product. If not null, IsParent should be false</summary>
		public string ParentID { get => GetProp<string>("ParentID"); set => SetProp<string>("ParentID", value); }
		/// <summary>If true, ParentID must be null, as a parent product cannot have a parent itself.</summary>
		public bool IsParent { get => GetProp<bool>("IsParent"); set => SetProp<bool>("IsParent", value); }
		/// <summary>If true, IsParent must be false, as a parent product cannot be a bundle.</summary>
		[ApiReadOnly]
		public bool IsBundle { get => GetProp<bool>("IsBundle"); set => SetProp<bool>("IsBundle", value); }
		/// <summary>Name of the product. Required. Max length 100 characters. Searchable: priority level 3. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the product. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior. Used to indicate an amount per Quantity.</summary>
		public int? QuantityMultiplier { get => GetProp<int?>("QuantityMultiplier", 1); set => SetProp<int?>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>If false, product is not visible or purchasable from the Shopper perspective.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Count of Specs assigned to the product.</summary>
		[ApiReadOnly]
		public int SpecCount { get => GetProp<int>("SpecCount"); set => SetProp<int>("SpecCount", value); }
		/// <summary>Count of Variants generated from the product/spec combinations.</summary>
		[ApiReadOnly]
		public int VariantCount { get => GetProp<int>("VariantCount"); set => SetProp<int>("VariantCount", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from. Can be used to calculate shipping costs.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Inventory of the product.</summary>
		public Inventory Inventory { get => GetProp<Inventory>("Inventory"); set => SetProp<Inventory>("Inventory", value); }
		/// <summary>If this property has a value and a SupplierID isn't explicitly passed when creating a LineItem, this SupplierID will be used.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>If true, all suppliers are eligible to opt into selling this product.</summary>
		public bool AllSuppliersCanSell { get => GetProp<bool>("AllSuppliersCanSell"); set => SetProp<bool>("AllSuppliersCanSell", value); }
		/// <summary>Returnable of the product.</summary>
		public bool Returnable { get => GetProp<bool>("Returnable"); set => SetProp<bool>("Returnable", value); }
		/// <summary>Date created of the product.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Container for extended (custom) properties of the product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Product class instead.</typeparam>
	public class Product<Txp> : Product
	{
		/// <summary>Container for extended (custom) properties of the product.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ProductAssignment : OrderCloudModel
	{
		/// <summary>Marketplace owner can write to this property when creating product assignments for other sellers. A PriceScheduleID owned by the SellerID is required in order to write to this property.</summary>
		public string SellerID { get => GetProp<string>("SellerID"); set => SetProp<string>("SellerID", value); }
		/// <summary>ID of the product. Required.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>ID of the buyer. Required.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the user group.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>ID of the price schedule.</summary>
		public string PriceScheduleID { get => GetProp<string>("PriceScheduleID"); set => SetProp<string>("PriceScheduleID", value); }
	}
	public class ProductCatalogAssignment : OrderCloudModel
	{
		/// <summary>ID of the catalog. Required.</summary>
		[Required]
		public string CatalogID { get => GetProp<string>("CatalogID"); set => SetProp<string>("CatalogID", value); }
		/// <summary>ID of the product. Required.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
	}
	public class ProductCollection : OrderCloudModel
	{
		/// <summary>ID of the product collection. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product collection. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Container for extended (custom) properties of the product collection.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Access level of the product collection. Possible values: Private, Public, Shareable.</summary>
		public AccessLevel AccessLevel { get => GetProp<AccessLevel>("AccessLevel"); set => SetProp<AccessLevel>("AccessLevel", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ProductCollection class instead.</typeparam>
	public class ProductCollection<Txp> : ProductCollection
	{
		/// <summary>Container for extended (custom) properties of the product collection.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ProductCollectionBuyerProduct : OrderCloudModel
	{
		/// <summary>List order of the product collection buyer product.</summary>
		public int? ListOrder { get => GetProp<int?>("ListOrder"); set => SetProp<int?>("ListOrder", value); }
		/// <summary>Date added of the product collection buyer product.</summary>
		public DateTimeOffset? DateAdded { get => GetProp<DateTimeOffset?>("DateAdded"); set => SetProp<DateTimeOffset?>("DateAdded", value); }
		/// <summary>Price schedule of the product collection buyer product.</summary>
		[ApiReadOnly]
		public PriceSchedule PriceSchedule { get => GetProp<PriceSchedule>("PriceSchedule"); set => SetProp<PriceSchedule>("PriceSchedule", value); }
		/// <summary>ID of the product collection buyer product. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the parent product. If not null, IsParent should be false</summary>
		public string ParentID { get => GetProp<string>("ParentID"); set => SetProp<string>("ParentID", value); }
		/// <summary>If true, ParentID must be null, as a parent product cannot have a parent itself.</summary>
		public bool IsParent { get => GetProp<bool>("IsParent"); set => SetProp<bool>("IsParent", value); }
		/// <summary>If true, IsParent must be false, as a parent product cannot be a bundle.</summary>
		[ApiReadOnly]
		public bool IsBundle { get => GetProp<bool>("IsBundle"); set => SetProp<bool>("IsBundle", value); }
		/// <summary>Name of the product collection buyer product. Required. Max length 100 characters. Searchable: priority level 3. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the product collection buyer product. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior. Used to indicate an amount per Quantity.</summary>
		public int? QuantityMultiplier { get => GetProp<int?>("QuantityMultiplier", 1); set => SetProp<int?>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the product collection buyer product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the product collection buyer product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the product collection buyer product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the product collection buyer product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>If false, product is not visible or purchasable from the Shopper perspective.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Count of Specs assigned to the product.</summary>
		[ApiReadOnly]
		public int SpecCount { get => GetProp<int>("SpecCount"); set => SetProp<int>("SpecCount", value); }
		/// <summary>Count of Variants generated from the product/spec combinations.</summary>
		[ApiReadOnly]
		public int VariantCount { get => GetProp<int>("VariantCount"); set => SetProp<int>("VariantCount", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from. Can be used to calculate shipping costs.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Inventory of the product collection buyer product.</summary>
		public Inventory Inventory { get => GetProp<Inventory>("Inventory"); set => SetProp<Inventory>("Inventory", value); }
		/// <summary>If this property has a value and a SupplierID isn't explicitly passed when creating a LineItem, this SupplierID will be used.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>If true, all suppliers are eligible to opt into selling this product.</summary>
		public bool AllSuppliersCanSell { get => GetProp<bool>("AllSuppliersCanSell"); set => SetProp<bool>("AllSuppliersCanSell", value); }
		/// <summary>Returnable of the product collection buyer product.</summary>
		public bool Returnable { get => GetProp<bool>("Returnable"); set => SetProp<bool>("Returnable", value); }
		/// <summary>Date created of the product collection buyer product.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Container for extended (custom) properties of the product collection buyer product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule property. If not using a custom type, specify PriceSchedule.</typeparam>
	public class ProductCollectionBuyerProduct<Txp, TPriceSchedule> : ProductCollectionBuyerProduct
		where TPriceSchedule : PriceSchedule
	{
		/// <summary>Container for extended (custom) properties of the product collection buyer product.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Price schedule of the product collection buyer product.</summary>
		[ApiReadOnly]
		public new TPriceSchedule PriceSchedule { get => GetProp<TPriceSchedule>("PriceSchedule"); set => SetProp<TPriceSchedule>("PriceSchedule", value); }
	}
	public class ProductCollectionEntry : OrderCloudModel
	{
		/// <summary>ID of the product. Required.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>List order of the product collection entry.</summary>
		public int? ListOrder { get => GetProp<int?>("ListOrder"); set => SetProp<int?>("ListOrder", value); }
	}
	public class ProductCollectionInvitation : OrderCloudModel
	{
		/// <summary>ID of the product collection invitation. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product collection invitation. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Admin of the product collection invitation.</summary>
		public bool Admin { get => GetProp<bool>("Admin", false); set => SetProp<bool>("Admin", value); }
		/// <summary>Updated when accepted.</summary>
		[ApiReadOnly]
		public bool Accepted { get => GetProp<bool>("Accepted", false); set => SetProp<bool>("Accepted", value); }
		/// <summary>Invitation Expiration Date defaults to 30 days from create, maximum 1 year.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>Container for extended (custom) properties of the product collection invitation.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ProductCollectionInvitation class instead.</typeparam>
	public class ProductCollectionInvitation<Txp> : ProductCollectionInvitation
	{
		/// <summary>Container for extended (custom) properties of the product collection invitation.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ProductCollectionProduct : OrderCloudModel
	{
		/// <summary>List order of the product collection product.</summary>
		public int? ListOrder { get => GetProp<int?>("ListOrder"); set => SetProp<int?>("ListOrder", value); }
		/// <summary>Date added of the product collection product.</summary>
		public DateTimeOffset? DateAdded { get => GetProp<DateTimeOffset?>("DateAdded"); set => SetProp<DateTimeOffset?>("DateAdded", value); }
		/// <summary>ID of the organization that owns the Product. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>When provided, no explicit PriceSchedule assignment is required. When a PriceSchedule assignment exists, it will override any default provided.</summary>
		public string DefaultPriceScheduleID { get => GetProp<string>("DefaultPriceScheduleID"); set => SetProp<string>("DefaultPriceScheduleID", value); }
		/// <summary>If true, when this product is ordered by a Buyer, it will automatically be added to a new Order from the Marketplace Owner to the Default Supplier and submitted. Requires a valid DefaultSupplierID.</summary>
		public bool AutoForward { get => GetProp<bool>("AutoForward"); set => SetProp<bool>("AutoForward", value); }
		/// <summary>ID of the product collection product. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the parent product. If not null, IsParent should be false</summary>
		public string ParentID { get => GetProp<string>("ParentID"); set => SetProp<string>("ParentID", value); }
		/// <summary>If true, ParentID must be null, as a parent product cannot have a parent itself.</summary>
		public bool IsParent { get => GetProp<bool>("IsParent"); set => SetProp<bool>("IsParent", value); }
		/// <summary>If true, IsParent must be false, as a parent product cannot be a bundle.</summary>
		[ApiReadOnly]
		public bool IsBundle { get => GetProp<bool>("IsBundle"); set => SetProp<bool>("IsBundle", value); }
		/// <summary>Name of the product collection product. Required. Max length 100 characters. Searchable: priority level 3. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the product collection product. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior. Used to indicate an amount per Quantity.</summary>
		public int? QuantityMultiplier { get => GetProp<int?>("QuantityMultiplier", 1); set => SetProp<int?>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the product collection product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the product collection product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the product collection product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the product collection product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>If false, product is not visible or purchasable from the Shopper perspective.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Count of Specs assigned to the product.</summary>
		[ApiReadOnly]
		public int SpecCount { get => GetProp<int>("SpecCount"); set => SetProp<int>("SpecCount", value); }
		/// <summary>Count of Variants generated from the product/spec combinations.</summary>
		[ApiReadOnly]
		public int VariantCount { get => GetProp<int>("VariantCount"); set => SetProp<int>("VariantCount", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from. Can be used to calculate shipping costs.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Inventory of the product collection product.</summary>
		public Inventory Inventory { get => GetProp<Inventory>("Inventory"); set => SetProp<Inventory>("Inventory", value); }
		/// <summary>If this property has a value and a SupplierID isn't explicitly passed when creating a LineItem, this SupplierID will be used.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>If true, all suppliers are eligible to opt into selling this product.</summary>
		public bool AllSuppliersCanSell { get => GetProp<bool>("AllSuppliersCanSell"); set => SetProp<bool>("AllSuppliersCanSell", value); }
		/// <summary>Returnable of the product collection product.</summary>
		public bool Returnable { get => GetProp<bool>("Returnable"); set => SetProp<bool>("Returnable", value); }
		/// <summary>Date created of the product collection product.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Container for extended (custom) properties of the product collection product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ProductCollectionProduct class instead.</typeparam>
	public class ProductCollectionProduct<Txp> : ProductCollectionProduct
	{
		/// <summary>Container for extended (custom) properties of the product collection product.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ProductFacet : OrderCloudModel
	{
		/// <summary>ID of the product facet. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product facet. Required. Max length 100 characters. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Optional. Identifies full path to xp field used for this facet. If not provided, facet value assumed to be stored at product.xp.{facet ID}.</summary>
		public string XpPath { get => GetProp<string>("XpPath"); set => SetProp<string>("XpPath", value); }
		/// <summary>List order of the product facet. Sortable: priority level 1.</summary>
		public int ListOrder { get => GetProp<int>("ListOrder"); set => SetProp<int>("ListOrder", value); }
		/// <summary>Minimum count required or a facet value to be returned in list metadata. Default is 1. If you want zero-count values returned, set this to 0.</summary>
		public int MinCount { get => GetProp<int>("MinCount", 1); set => SetProp<int>("MinCount", value); }
		/// <summary>Container for extended (custom) properties of the product facet.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ProductFacet class instead.</typeparam>
	public class ProductFacet<Txp> : ProductFacet
	{
		/// <summary>Container for extended (custom) properties of the product facet.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ProductSeller : OrderCloudModel
	{
		/// <summary>Price schedule of the product seller.</summary>
		public PriceSchedule PriceSchedule { get => GetProp<PriceSchedule>("PriceSchedule"); set => SetProp<PriceSchedule>("PriceSchedule", value); }
		/// <summary>ID of the product seller. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product seller. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
	}
	/// <typeparam name="TPriceSchedule">Specific type of the PriceSchedule property. If not using a custom type, use the non-generic ProductSeller class instead.</typeparam>
	public class ProductSeller<TPriceSchedule> : ProductSeller
		where TPriceSchedule : PriceSchedule
	{
		/// <summary>Price schedule of the product seller.</summary>
		public new TPriceSchedule PriceSchedule { get => GetProp<TPriceSchedule>("PriceSchedule"); set => SetProp<TPriceSchedule>("PriceSchedule", value); }
	}
	public class ProductSupplier : OrderCloudModel
	{
		/// <summary>ID of the default price schedule.</summary>
		public string DefaultPriceScheduleID { get => GetProp<string>("DefaultPriceScheduleID"); set => SetProp<string>("DefaultPriceScheduleID", value); }
		/// <summary>ID of the product supplier. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product supplier. Required. Max length 100 characters. Searchable: priority level 1. Sortable.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>If false, all authentication is prohibited.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Date created of the product supplier. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get => GetProp<DateTimeOffset>("DateCreated"); set => SetProp<DateTimeOffset>("DateCreated", value); }
		/// <summary>If false, buyers will only be able to set ToCompanyID on an order to the Marketplace Owner, or suppliers they have an explicit relationship to.</summary>
		public bool AllBuyersCanOrder { get => GetProp<bool>("AllBuyersCanOrder"); set => SetProp<bool>("AllBuyersCanOrder", value); }
		/// <summary>Container for extended (custom) properties of the product supplier.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ProductSupplier class instead.</typeparam>
	public class ProductSupplier<Txp> : ProductSupplier
	{
		/// <summary>Container for extended (custom) properties of the product supplier.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ProductSyncConfig : OrderCloudModel
	{
		/// <summary>Sync product changed of the product sync config. Required.</summary>
		[Required]
		public bool SyncProductChanged { get => GetProp<bool>("SyncProductChanged"); set => SetProp<bool>("SyncProductChanged", value); }
		/// <summary>Sync product deleted of the product sync config. Required.</summary>
		[Required]
		public bool SyncProductDeleted { get => GetProp<bool>("SyncProductDeleted"); set => SetProp<bool>("SyncProductDeleted", value); }
		/// <summary>ID of the delivery config. Required.</summary>
		[Required]
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
		/// <summary>Config data of the product sync config.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
	}
	public class Promotion : OrderCloudModel
	{
		/// <summary>ID of the promotion. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>If true, certain eligible expression requirements must be met, and the PromotionDiscount will be applied at the line item level.</summary>
		public bool LineItemLevel { get => GetProp<bool>("LineItemLevel"); set => SetProp<bool>("LineItemLevel", value); }
		/// <summary>Must be unique. Entered by buyer when adding promo to order.</summary>
		[Required]
		public string Code { get => GetProp<string>("Code"); set => SetProp<string>("Code", value); }
		/// <summary>Name of the promotion. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Limit the total number of orders this promotion can be applied to across all users.</summary>
		public int? RedemptionLimit { get => GetProp<int?>("RedemptionLimit"); set => SetProp<int?>("RedemptionLimit", value); }
		/// <summary>Limit the total number of orders this promotion can be applied to per user.</summary>
		public int? RedemptionLimitPerUser { get => GetProp<int?>("RedemptionLimitPerUser"); set => SetProp<int?>("RedemptionLimitPerUser", value); }
		/// <summary>The number of times this promotion has been applied to an order.</summary>
		[ApiReadOnly]
		public int RedemptionCount { get => GetProp<int>("RedemptionCount"); set => SetProp<int>("RedemptionCount", value); }
		/// <summary>Can only be used when LineItemLevel is true and ItemLimitPerOrder does not have a value. When defined the ValueExpression will be the discount applied to each qualifying quantity of eligible items. When no ItemSortBy is defined, items will be sorted by DateAdded ascending.</summary>
		public int? QuantityLimitPerOrder { get => GetProp<int?>("QuantityLimitPerOrder"); set => SetProp<int?>("QuantityLimitPerOrder", value); }
		/// <summary>Can only be used when LineItemLevel is true and QuantityLimitPerOrder does not have a value. Limits the number of items the promotion will apply to when eligible. When no ItemSortBy is defined, items will be sorted by DateAdded ascending.</summary>
		public int? ItemLimitPerOrder { get => GetProp<int?>("ItemLimitPerOrder"); set => SetProp<int?>("ItemLimitPerOrder", value); }
		/// <summary>Comma delimited list of properties to sort by. Can only be used when ItemLimitPerOrder is true. Used to determine the order in which the promotion is applied to the specified limit of items. Use ! to reverse sort order on a property.</summary>
		public string ItemSortBy { get => GetProp<string>("ItemSortBy"); set => SetProp<string>("ItemSortBy", value); }
		/// <summary>Description of the promotion. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Terms, conditions, and other legal jargon.</summary>
		public string FinePrint { get => GetProp<string>("FinePrint"); set => SetProp<string>("FinePrint", value); }
		/// <summary>Start date of the promotion. Sortable.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>Expiration date of the promotion. Sortable.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>The expression evaluated to determine if an item or order is eligible for a promotion. See Rules Engine documentation for formatting details.</summary>
		[Required]
		public string EligibleExpression { get => GetProp<string>("EligibleExpression"); set => SetProp<string>("EligibleExpression", value); }
		/// <summary>The expression evaluated to determine the discount amount of an eligible promotion. See Rules Engine documentation for formatting details.</summary>
		public string ValueExpression { get => GetProp<string>("ValueExpression"); set => SetProp<string>("ValueExpression", value); }
		/// <summary>If true, the promotion can be applied to an order that already other promotions applied, as long as they can also be combined.</summary>
		public bool CanCombine { get => GetProp<bool>("CanCombine"); set => SetProp<bool>("CanCombine", value); }
		/// <summary>Allow promo to be used by all buyers in your Marketplace without creating explicit assignments.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers"); set => SetProp<bool>("AllowAllBuyers", value); }
		/// <summary>ID of the organization that owns the Promotion. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Auto apply of the promotion. Sortable.</summary>
		public bool AutoApply { get => GetProp<bool>("AutoApply", false); set => SetProp<bool>("AutoApply", value); }
		/// <summary>Active of the promotion. Sortable.</summary>
		public bool Active { get => GetProp<bool>("Active", true); set => SetProp<bool>("Active", value); }
		/// <summary>Use integration of the promotion.</summary>
		public bool UseIntegration { get => GetProp<bool>("UseIntegration"); set => SetProp<bool>("UseIntegration", value); }
		/// <summary>Used to control the order in which promotions are applied when calling the auto apply endpoint.</summary>
		public int? Priority { get => GetProp<int?>("Priority"); set => SetProp<int?>("Priority", value); }
		/// <summary>Container for extended (custom) properties of the promotion.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Promotion class instead.</typeparam>
	public class Promotion<Txp> : Promotion
	{
		/// <summary>Container for extended (custom) properties of the promotion.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class PromotionAssignment : OrderCloudModel
	{
		/// <summary>ID of the promotion. Required. Sortable: priority level 1.</summary>
		[Required]
		public string PromotionID { get => GetProp<string>("PromotionID"); set => SetProp<string>("PromotionID", value); }
		/// <summary>ID of the buyer. Required. Sortable: priority level 2.</summary>
		[Required]
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the user group. Sortable: priority level 4.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class PromotionIntegration : OrderCloudModel
	{
		/// <summary>Security feature that allows your middleware to verify the digital signature in the request header to ensure you only accept trusted data.</summary>
		[Required]
		public string HashKey { get => GetProp<string>("HashKey"); set => SetProp<string>("HashKey", value); }
		/// <summary>Url of the promotion integration.</summary>
		public string Url { get => GetProp<string>("Url"); set => SetProp<string>("Url", value); }
		/// <summary>The header name that can be passed to your middleware.</summary>
		public string CustomAuthHeaderName { get => GetProp<string>("CustomAuthHeaderName"); set => SetProp<string>("CustomAuthHeaderName", value); }
		/// <summary>The header value that can be passed to your middleware.</summary>
		[ApiWriteOnly]
		public string CustomAuthHeaderValue { get => GetProp<string>("CustomAuthHeaderValue"); set => SetProp<string>("CustomAuthHeaderValue", value); }
	}
	public class PromotionOverride : OrderCloudModel
	{
		/// <summary>ID of the promotion.</summary>
		public string PromotionID { get => GetProp<string>("PromotionID"); set => SetProp<string>("PromotionID", value); }
		/// <summary>Overrides the promotion's calculated discount to this amount.</summary>
		public decimal Amount { get => GetProp<decimal>("Amount"); set => SetProp<decimal>("Amount", value); }
	}
	public class SearchIngestion : OrderCloudModel
	{
		/// <summary>Domain of the search ingestion. Required.</summary>
		[Required]
		public string Domain { get => GetProp<string>("Domain"); set => SetProp<string>("Domain", value); }
		/// <summary>Source of the search ingestion. Required.</summary>
		[Required]
		public string Source { get => GetProp<string>("Source"); set => SetProp<string>("Source", value); }
		/// <summary>Endpoint of the search ingestion. Required.</summary>
		[Required]
		public string Endpoint { get => GetProp<string>("Endpoint"); set => SetProp<string>("Endpoint", value); }
		/// <summary>Entity of the search ingestion. Required.</summary>
		[Required]
		public string Entity { get => GetProp<string>("Entity"); set => SetProp<string>("Entity", value); }
		/// <summary>Api key of the search ingestion. Required.</summary>
		[Required]
		[ApiWriteOnly]
		public string ApiKey { get => GetProp<string>("ApiKey"); set => SetProp<string>("ApiKey", value); }
	}
	public class SecurityProfile : OrderCloudModel
	{
		/// <summary>ID of the security profile. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the security profile. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Roles of the security profile.</summary>
		public IList<ApiRole> Roles { get => GetProp<IList<ApiRole>>("Roles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("Roles", value); }
		/// <summary>Custom roles of the security profile.</summary>
		public IList<string> CustomRoles { get => GetProp<IList<string>>("CustomRoles", new List<string>()); set => SetProp<IList<string>>("CustomRoles", value); }
		/// <summary>When PasswordConfig.ExpireInDays has a value, the user will be required to go through the PW reset flow once that number of days has passed.</summary>
		public PasswordConfig PasswordConfig { get => GetProp<PasswordConfig>("PasswordConfig"); set => SetProp<PasswordConfig>("PasswordConfig", value); }
	}
	public class SecurityProfileAssignment : OrderCloudModel
	{
		/// <summary>ID of the security profile. Required. Sortable: priority level 1.</summary>
		[Required]
		public string SecurityProfileID { get => GetProp<string>("SecurityProfileID"); set => SetProp<string>("SecurityProfileID", value); }
		/// <summary>ID of the buyer.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the supplier.</summary>
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
		/// <summary>ID of the user. Sortable: priority level 2.</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
		/// <summary>ID of the user group.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
	}
	public class SellerApprovalRule : OrderCloudModel
	{
		/// <summary>ID of the organization who owns the rule. Only the MPO can write a value other than their own organization ID. The value is used to look up the ApprovingGroupID.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>OrderReturn is the only Type supported currently. We plan to expand to Orders in the future.</summary>
		[Required]
		public ApprovalType ApprovalType { get => GetProp<ApprovalType>("ApprovalType"); set => SetProp<ApprovalType>("ApprovalType", value); }
		/// <summary>ID of the seller approval rule. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the seller approval rule. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the seller approval rule. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>ID of the approving group. Required. Sortable.</summary>
		[Required]
		public string ApprovingGroupID { get => GetProp<string>("ApprovingGroupID"); set => SetProp<string>("ApprovingGroupID", value); }
		/// <summary>The expression evaluated to determine an order requires approval. See Rules Engine documentation for formatting details.</summary>
		[Required]
		public string RuleExpression { get => GetProp<string>("RuleExpression"); set => SetProp<string>("RuleExpression", value); }
		/// <summary>Container for extended (custom) properties of the seller approval rule.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic SellerApprovalRule class instead.</typeparam>
	public class SellerApprovalRule<Txp> : SellerApprovalRule
	{
		/// <summary>Container for extended (custom) properties of the seller approval rule.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SendEvent : OrderCloudModel
	{
		/// <summary>ID of the site. Required.</summary>
		[Required]
		public string SiteID { get => GetProp<string>("SiteID"); set => SetProp<string>("SiteID", value); }
		/// <summary>Service endpoint of the send event. Required.</summary>
		[Required]
		public string ServiceEndpoint { get => GetProp<string>("ServiceEndpoint"); set => SetProp<string>("ServiceEndpoint", value); }
	}
	public class ShipEstimate : OrderCloudModel
	{
		/// <summary>ID of the ship estimate.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Container for extended (custom) properties of the ship estimate.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>ID of the selected ship method.</summary>
		public string SelectedShipMethodID { get => GetProp<string>("SelectedShipMethodID"); set => SetProp<string>("SelectedShipMethodID", value); }
		/// <summary>Ship estimate items of the ship estimate.</summary>
		public IList<ShipEstimateItem> ShipEstimateItems { get => GetProp<IList<ShipEstimateItem>>("ShipEstimateItems", new List<ShipEstimateItem>()); set => SetProp<IList<ShipEstimateItem>>("ShipEstimateItems", value); }
		/// <summary>Ship methods of the ship estimate.</summary>
		public IList<ShipMethod> ShipMethods { get => GetProp<IList<ShipMethod>>("ShipMethods", new List<ShipMethod>()); set => SetProp<IList<ShipMethod>>("ShipMethods", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TShipMethods">Specific type of the ShipMethods property. If not using a custom type, specify ShipMethod.</typeparam>
	public class ShipEstimate<Txp, TShipMethods> : ShipEstimate
		where TShipMethods : ShipMethod
	{
		/// <summary>Container for extended (custom) properties of the ship estimate.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Ship methods of the ship estimate.</summary>
		public new IList<TShipMethods> ShipMethods { get => GetProp<IList<TShipMethods>>("ShipMethods", new List<TShipMethods>()); set => SetProp<IList<TShipMethods>>("ShipMethods", value); }
	}
	public class ShipEstimateItem : OrderCloudModel
	{
		/// <summary>ID of the line item.</summary>
		public string LineItemID { get => GetProp<string>("LineItemID"); set => SetProp<string>("LineItemID", value); }
		/// <summary>Quantity of the ship estimate item.</summary>
		public int Quantity { get => GetProp<int>("Quantity"); set => SetProp<int>("Quantity", value); }
	}
	public class ShipEstimateResponse : OrderCloudModel
	{
		/// <summary>Ship estimates of the ship estimate response.</summary>
		public IList<ShipEstimate> ShipEstimates { get => GetProp<IList<ShipEstimate>>("ShipEstimates", new List<ShipEstimate>()); set => SetProp<IList<ShipEstimate>>("ShipEstimates", value); }
		/// <summary>Http status code of the ship estimate response.</summary>
		public int? HttpStatusCode { get => GetProp<int?>("HttpStatusCode"); set => SetProp<int?>("HttpStatusCode", value); }
		/// <summary>Unhandled error body of the ship estimate response.</summary>
		public string UnhandledErrorBody { get => GetProp<string>("UnhandledErrorBody"); set => SetProp<string>("UnhandledErrorBody", value); }
		/// <summary>Container for extended (custom) properties of the ship estimate response.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Succeeded of the ship estimate response.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TShipEstimates">Specific type of the ShipEstimates property. If not using a custom type, specify ShipEstimate.</typeparam>
	public class ShipEstimateResponse<Txp, TShipEstimates> : ShipEstimateResponse
		where TShipEstimates : ShipEstimate
	{
		/// <summary>Container for extended (custom) properties of the ship estimate response.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Ship estimates of the ship estimate response.</summary>
		public new IList<TShipEstimates> ShipEstimates { get => GetProp<IList<TShipEstimates>>("ShipEstimates", new List<TShipEstimates>()); set => SetProp<IList<TShipEstimates>>("ShipEstimates", value); }
	}
	public class Shipment : OrderCloudModel
	{
		/// <summary>ID of the shipment. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the buyer. Searchable: priority level 1. Sortable.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior.</summary>
		public string Shipper { get => GetProp<string>("Shipper"); set => SetProp<string>("Shipper", value); }
		/// <summary>In order to properly trigger OrderShipped emails, this date must be NULL on initial POST. Update with the date only when all of the Shipment items have been created. Once all of an order's items exist on a shipment that has a DateShipped the OrderShipped email will trigger and Order.Status will be updated to Complete.</summary>
		public DateTimeOffset? DateShipped { get => GetProp<DateTimeOffset?>("DateShipped"); set => SetProp<DateTimeOffset?>("DateShipped", value); }
		/// <summary>Date delivered of the shipment. Searchable: priority level 4. Sortable.</summary>
		public DateTimeOffset? DateDelivered { get => GetProp<DateTimeOffset?>("DateDelivered"); set => SetProp<DateTimeOffset?>("DateDelivered", value); }
		/// <summary>Tracking number of the shipment. Max length 3000 characters. Searchable: priority level 4.</summary>
		public string TrackingNumber { get => GetProp<string>("TrackingNumber"); set => SetProp<string>("TrackingNumber", value); }
		/// <summary>For reference only, does not influence any OrderCloud behavior.</summary>
		public decimal? Cost { get => GetProp<decimal?>("Cost"); set => SetProp<decimal?>("Cost", value); }
		/// <summary>ID of the organization that owns the Shipment. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>Container for extended (custom) properties of the shipment.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Account of the shipment.</summary>
		public string Account { get => GetProp<string>("Account"); set => SetProp<string>("Account", value); }
		/// <summary>Marketplace Owner or Supplier AddressID where the product will be shipped from.</summary>
		public string FromAddressID { get => GetProp<string>("FromAddressID"); set => SetProp<string>("FromAddressID", value); }
		/// <summary>ID of the to address.</summary>
		public string ToAddressID { get => GetProp<string>("ToAddressID"); set => SetProp<string>("ToAddressID", value); }
		/// <summary>From address of the shipment.</summary>
		[ApiReadOnly]
		public Address FromAddress { get => GetProp<Address>("FromAddress"); set => SetProp<Address>("FromAddress", value); }
		/// <summary>To address of the shipment.</summary>
		[ApiReadOnly]
		public Address ToAddress { get => GetProp<Address>("ToAddress"); set => SetProp<Address>("ToAddress", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TFromAddress">Specific type of the FromAddress property. If not using a custom type, specify Address.</typeparam>
	/// <typeparam name="TToAddress">Specific type of the ToAddress property. If not using a custom type, specify Address.</typeparam>
	public class Shipment<Txp, TFromAddress, TToAddress> : Shipment
		where TFromAddress : Address
		where TToAddress : Address
	{
		/// <summary>Container for extended (custom) properties of the shipment.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>From address of the shipment.</summary>
		[ApiReadOnly]
		public new TFromAddress FromAddress { get => GetProp<TFromAddress>("FromAddress"); set => SetProp<TFromAddress>("FromAddress", value); }
		/// <summary>To address of the shipment.</summary>
		[ApiReadOnly]
		public new TToAddress ToAddress { get => GetProp<TToAddress>("ToAddress"); set => SetProp<TToAddress>("ToAddress", value); }
	}
	public class ShipmentItem : OrderCloudModel
	{
		/// <summary>ID of the order. Required.</summary>
		[Required]
		public string OrderID { get => GetProp<string>("OrderID"); set => SetProp<string>("OrderID", value); }
		/// <summary>ID of the line item. Required.</summary>
		[Required]
		public string LineItemID { get => GetProp<string>("LineItemID"); set => SetProp<string>("LineItemID", value); }
		/// <summary>Quantity shipped of the shipment item. Required.</summary>
		[Required]
		public int QuantityShipped { get => GetProp<int>("QuantityShipped"); set => SetProp<int>("QuantityShipped", value); }
		/// <summary>Unit price of the shipment item.</summary>
		[ApiReadOnly]
		public decimal? UnitPrice { get => GetProp<decimal?>("UnitPrice"); set => SetProp<decimal?>("UnitPrice", value); }
		/// <summary>Cost center of the shipment item.</summary>
		[ApiReadOnly]
		public string CostCenter { get => GetProp<string>("CostCenter"); set => SetProp<string>("CostCenter", value); }
		/// <summary>Date needed of the shipment item.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateNeeded { get => GetProp<DateTimeOffset?>("DateNeeded"); set => SetProp<DateTimeOffset?>("DateNeeded", value); }
		/// <summary>Product of the shipment item.</summary>
		[ApiReadOnly]
		public LineItemProduct Product { get => GetProp<LineItemProduct>("Product"); set => SetProp<LineItemProduct>("Product", value); }
		/// <summary>Variant of the shipment item.</summary>
		[ApiReadOnly]
		public LineItemVariant Variant { get => GetProp<LineItemVariant>("Variant"); set => SetProp<LineItemVariant>("Variant", value); }
		/// <summary>Specs of the shipment item.</summary>
		[ApiReadOnly]
		public IReadOnlyList<LineItemSpec> Specs { get => GetProp<IReadOnlyList<LineItemSpec>>("Specs"); set => SetProp<IReadOnlyList<LineItemSpec>>("Specs", value); }
		/// <summary>For reference only, represents LineItem XP from the given LineItem ID</summary>
		[ApiReadOnly]
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TProduct">Specific type of the Product property. If not using a custom type, specify LineItemProduct.</typeparam>
	/// <typeparam name="TVariant">Specific type of the Variant property. If not using a custom type, specify LineItemVariant.</typeparam>
	public class ShipmentItem<Txp, TProduct, TVariant> : ShipmentItem
		where TProduct : LineItemProduct
		where TVariant : LineItemVariant
	{
		/// <summary>For reference only, represents LineItem XP from the given LineItem ID</summary>
		[ApiReadOnly]
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Product of the shipment item.</summary>
		[ApiReadOnly]
		public new TProduct Product { get => GetProp<TProduct>("Product"); set => SetProp<TProduct>("Product", value); }
		/// <summary>Variant of the shipment item.</summary>
		[ApiReadOnly]
		public new TVariant Variant { get => GetProp<TVariant>("Variant"); set => SetProp<TVariant>("Variant", value); }
	}
	public class ShipMethod : OrderCloudModel
	{
		/// <summary>ID of the ship method.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the ship method.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Cost of the ship method.</summary>
		public decimal Cost { get => GetProp<decimal>("Cost"); set => SetProp<decimal>("Cost", value); }
		/// <summary>Estimated transit days of the ship method.</summary>
		public int EstimatedTransitDays { get => GetProp<int>("EstimatedTransitDays"); set => SetProp<int>("EstimatedTransitDays", value); }
		/// <summary>Container for extended (custom) properties of the ship method.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic ShipMethod class instead.</typeparam>
	public class ShipMethod<Txp> : ShipMethod
	{
		/// <summary>Container for extended (custom) properties of the ship method.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class ShipMethodSelection : OrderCloudModel
	{
		/// <summary>ID of the ship estimate. Required.</summary>
		[Required]
		public string ShipEstimateID { get => GetProp<string>("ShipEstimateID"); set => SetProp<string>("ShipEstimateID", value); }
		/// <summary>ID of the ship method. Required.</summary>
		[Required]
		public string ShipMethodID { get => GetProp<string>("ShipMethodID"); set => SetProp<string>("ShipMethodID", value); }
	}
	public class Spec : OrderCloudModel
	{
		/// <summary>ID of the organization that owns the Spec. Only the Marketplace Owner can override the OwnerID on create.</summary>
		public string OwnerID { get => GetProp<string>("OwnerID"); set => SetProp<string>("OwnerID", value); }
		/// <summary>ID of the spec. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>List order of the spec. Sortable: priority level 1.</summary>
		public int ListOrder { get => GetProp<int>("ListOrder"); set => SetProp<int>("ListOrder", value); }
		/// <summary>Name of the spec. Required. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>If no Spec.Value is passed in the LineItemSpec, this value will be used.</summary>
		public string DefaultValue { get => GetProp<string>("DefaultValue"); set => SetProp<string>("DefaultValue", value); }
		/// <summary>Required of the spec.</summary>
		public bool Required { get => GetProp<bool>("Required"); set => SetProp<bool>("Required", value); }
		/// <summary>For Spec options that are not pre-defined, such as FirstName for a business card.</summary>
		public bool AllowOpenText { get => GetProp<bool>("AllowOpenText"); set => SetProp<bool>("AllowOpenText", value); }
		/// <summary>This property can only be written to after both the Spec and Option have been created. If no Spec.OptionID is passed in the LineItemSpec, this option will be used.</summary>
		public string DefaultOptionID { get => GetProp<string>("DefaultOptionID"); set => SetProp<string>("DefaultOptionID", value); }
		/// <summary>If true, each unique combinations of this Spec's Options should map to a unique Product Variant.</summary>
		public bool DefinesVariant { get => GetProp<bool>("DefinesVariant"); set => SetProp<bool>("DefinesVariant", value); }
		/// <summary>Container for extended (custom) properties of the spec.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Option count of the spec.</summary>
		[ApiReadOnly]
		public int OptionCount { get => GetProp<int>("OptionCount"); set => SetProp<int>("OptionCount", value); }
		/// <summary>Options of the spec.</summary>
		[ApiReadOnly]
		public IReadOnlyList<SpecOption> Options { get => GetProp<IReadOnlyList<SpecOption>>("Options"); set => SetProp<IReadOnlyList<SpecOption>>("Options", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TOptions">Specific type of the Options property. If not using a custom type, specify SpecOption.</typeparam>
	public class Spec<Txp, TOptions> : Spec
		where TOptions : SpecOption
	{
		/// <summary>Container for extended (custom) properties of the spec.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
		/// <summary>Options of the spec.</summary>
		[ApiReadOnly]
		public new IReadOnlyList<TOptions> Options { get => GetProp<IReadOnlyList<TOptions>>("Options"); set => SetProp<IReadOnlyList<TOptions>>("Options", value); }
	}
	public class SpecOption : OrderCloudModel
	{
		/// <summary>ID of the spec option. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Value of the spec option. Required. Max length 2000 characters. Searchable: priority level 1.</summary>
		[Required]
		public string Value { get => GetProp<string>("Value"); set => SetProp<string>("Value", value); }
		/// <summary>List order of the spec option. Sortable: priority level 1.</summary>
		public int ListOrder { get => GetProp<int>("ListOrder"); set => SetProp<int>("ListOrder", value); }
		/// <summary>Is open text of the spec option.</summary>
		public bool IsOpenText { get => GetProp<bool>("IsOpenText"); set => SetProp<bool>("IsOpenText", value); }
		/// <summary>Used to change the price of a product when a specific Spec Option is selected.</summary>
		public PriceMarkupType? PriceMarkupType { get => GetProp<PriceMarkupType?>("PriceMarkupType"); set => SetProp<PriceMarkupType?>("PriceMarkupType", value); }
		/// <summary>Price markup of the spec option.</summary>
		public decimal? PriceMarkup { get => GetProp<decimal?>("PriceMarkup"); set => SetProp<decimal?>("PriceMarkup", value); }
		/// <summary>Container for extended (custom) properties of the spec option.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic SpecOption class instead.</typeparam>
	public class SpecOption<Txp> : SpecOption
	{
		/// <summary>Container for extended (custom) properties of the spec option.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SpecProductAssignment : OrderCloudModel
	{
		/// <summary>ID of the spec. Required. Searchable: priority level 1. Sortable: priority level 1.</summary>
		[Required]
		public string SpecID { get => GetProp<string>("SpecID"); set => SetProp<string>("SpecID", value); }
		/// <summary>ID of the product. Required. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>Optional. When defined, overrides the DefaultValue set on the Spec for just this Product.</summary>
		public string DefaultValue { get => GetProp<string>("DefaultValue"); set => SetProp<string>("DefaultValue", value); }
		/// <summary>Optional. When defined, overrides the DefaultOptionID set on the Spec for just this Product.</summary>
		public string DefaultOptionID { get => GetProp<string>("DefaultOptionID"); set => SetProp<string>("DefaultOptionID", value); }
	}
	public class SpendingAccount : OrderCloudModel
	{
		/// <summary>ID of the spending account. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the spending account. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Balance of the spending account. Required.</summary>
		[Required]
		public decimal Balance { get => GetProp<decimal>("Balance"); set => SetProp<decimal>("Balance", value); }
		/// <summary>If true, a Payment can be created referencing the SpendingAccountID.</summary>
		public bool AllowAsPaymentMethod { get => GetProp<bool>("AllowAsPaymentMethod"); set => SetProp<bool>("AllowAsPaymentMethod", value); }
		/// <summary>Start date of the spending account.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>End date of the spending account.</summary>
		public DateTimeOffset? EndDate { get => GetProp<DateTimeOffset?>("EndDate"); set => SetProp<DateTimeOffset?>("EndDate", value); }
		/// <summary>Container for extended (custom) properties of the spending account.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic SpendingAccount class instead.</typeparam>
	public class SpendingAccount<Txp> : SpendingAccount
	{
		/// <summary>Container for extended (custom) properties of the spending account.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SpendingAccountAssignment : OrderCloudModel
	{
		/// <summary>ID of the spending account. Required. Sortable: priority level 1.</summary>
		[Required]
		public string SpendingAccountID { get => GetProp<string>("SpendingAccountID"); set => SetProp<string>("SpendingAccountID", value); }
		/// <summary>ID of the user. Sortable: priority level 2.</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
		/// <summary>ID of the user group. Sortable: priority level 3.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>If true, a user can place an order for an amount greater than the available balance, causing the balance to go negative.</summary>
		public bool AllowExceed { get => GetProp<bool>("AllowExceed"); set => SetProp<bool>("AllowExceed", value); }
	}
	public class Subscription : OrderCloudModel
	{
		/// <summary>ID of the subscription. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Used to define how often to process the subscription. The subscription will process once every {Frequency} {Interval}.</summary>
		[Required]
		public int Frequency { get => GetProp<int>("Frequency"); set => SetProp<int>("Frequency", value); }
		/// <summary>Used to define how often to process the subscription. The subscription will process once every {Frequency} {Interval}.</summary>
		[Required]
		public SubscriptionInterval Interval { get => GetProp<SubscriptionInterval>("Interval"); set => SetProp<SubscriptionInterval>("Interval", value); }
		/// <summary>Next order date of the subscription. The hourly process that creates subscription orders will query for subscriptions with a NextOrderDate between now and five hours ago.</summary>
		[Required]
		public DateTimeOffset? NextOrderDate { get => GetProp<DateTimeOffset?>("NextOrderDate"); set => SetProp<DateTimeOffset?>("NextOrderDate", value); }
		/// <summary>Last order date of the subscription. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public DateTimeOffset? LastOrderDate { get => GetProp<DateTimeOffset?>("LastOrderDate"); set => SetProp<DateTimeOffset?>("LastOrderDate", value); }
		/// <summary>Date that Subscription Order reminder email message sender will be sent if used. Value is the result of NextOrderDate minus NotificationDays on SubscriptionIntegration.</summary>
		[ApiReadOnly]
		public DateTimeOffset? NotificationDate { get => GetProp<DateTimeOffset?>("NotificationDate"); set => SetProp<DateTimeOffset?>("NotificationDate", value); }
		/// <summary>Date created of the subscription. Sortable: priority level 3.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>End date of the subscription. Sortable.</summary>
		public DateTimeOffset? EndDate { get => GetProp<DateTimeOffset?>("EndDate"); set => SetProp<DateTimeOffset?>("EndDate", value); }
		/// <summary>Active of the subscription.</summary>
		public bool Active { get => GetProp<bool>("Active", true); set => SetProp<bool>("Active", value); }
		/// <summary>Only use when creating a subscription on behalf of another user. ID of the Buyer or Marketplace Owner placing the order.</summary>
		public string FromCompanyID { get => GetProp<string>("FromCompanyID"); set => SetProp<string>("FromCompanyID", value); }
		/// <summary>Only use when creating a subscription on behalf of a another user.</summary>
		public string FromUserID { get => GetProp<string>("FromUserID"); set => SetProp<string>("FromUserID", value); }
		/// <summary>ID of the Marketplace Owner or Supplier receiving the order created by this subscription, only writable on create. Mainly useful to the user placing it.</summary>
		public string ToCompanyID { get => GetProp<string>("ToCompanyID"); set => SetProp<string>("ToCompanyID", value); }
		/// <summary>Payment of the subscription.</summary>
		public SubscriptionPayment Payment { get => GetProp<SubscriptionPayment>("Payment"); set => SetProp<SubscriptionPayment>("Payment", value); }
		/// <summary>ID of the billing address.</summary>
		public string BillingAddressID { get => GetProp<string>("BillingAddressID"); set => SetProp<string>("BillingAddressID", value); }
		/// <summary>ID of the shipping address.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>Container for extended (custom) properties of the subscription.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Subscription class instead.</typeparam>
	public class Subscription<Txp> : Subscription
	{
		/// <summary>Container for extended (custom) properties of the subscription.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SubscriptionIntegration : OrderCloudModel
	{
		/// <summary>ID of the API Client that will be used to generate the token passed to your hosted application via SubscriptionIntegrationPayload.OrderCloudAccessToken.</summary>
		[Required]
		public string ApiClientID { get => GetProp<string>("ApiClientID"); set => SetProp<string>("ApiClientID", value); }
		/// <summary>Security feature that allows your middleware to verify the digital signature in the request header to ensure you only accept trusted data.</summary>
		[Required]
		public string HashKey { get => GetProp<string>("HashKey"); set => SetProp<string>("HashKey", value); }
		/// <summary>Elevated roles of the subscription integration.</summary>
		public IList<ApiRole> ElevatedRoles { get => GetProp<IList<ApiRole>>("ElevatedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("ElevatedRoles", value); }
		/// <summary>Active of the subscription integration.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Notification days of the subscription integration. Must be at least 1.</summary>
		public int? NotificationDays { get => GetProp<int?>("NotificationDays"); set => SetProp<int?>("NotificationDays", value); }
		/// <summary>Url of the subscription integration.</summary>
		public string Url { get => GetProp<string>("Url"); set => SetProp<string>("Url", value); }
		/// <summary>Container for extended (custom) properties of the subscription integration.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>The header name that can be passed to your middleware.</summary>
		public string CustomAuthHeaderName { get => GetProp<string>("CustomAuthHeaderName"); set => SetProp<string>("CustomAuthHeaderName", value); }
		/// <summary>The header value that can be passed to your middleware.</summary>
		[ApiWriteOnly]
		public string CustomAuthHeaderValue { get => GetProp<string>("CustomAuthHeaderValue"); set => SetProp<string>("CustomAuthHeaderValue", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic SubscriptionIntegration class instead.</typeparam>
	public class SubscriptionIntegration<Txp> : SubscriptionIntegration
	{
		/// <summary>Container for extended (custom) properties of the subscription integration.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SubscriptionIntegrationResponse : OrderCloudModel
	{
		/// <summary>Http status code of the subscription integration response.</summary>
		public int? HttpStatusCode { get => GetProp<int?>("HttpStatusCode"); set => SetProp<int?>("HttpStatusCode", value); }
		/// <summary>Unhandled error body of the subscription integration response.</summary>
		public string UnhandledErrorBody { get => GetProp<string>("UnhandledErrorBody"); set => SetProp<string>("UnhandledErrorBody", value); }
		/// <summary>Container for extended (custom) properties of the subscription integration response.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Succeeded of the subscription integration response.</summary>
		public bool Succeeded { get => GetProp<bool>("Succeeded"); set => SetProp<bool>("Succeeded", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic SubscriptionIntegrationResponse class instead.</typeparam>
	public class SubscriptionIntegrationResponse<Txp> : SubscriptionIntegrationResponse
	{
		/// <summary>Container for extended (custom) properties of the subscription integration response.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SubscriptionPayment : OrderCloudModel
	{
		/// <summary>Type of the subscription payment. Possible values: PurchaseOrder, CreditCard, SpendingAccount.</summary>
		public PaymentType? Type { get => GetProp<PaymentType?>("Type"); set => SetProp<PaymentType?>("Type", value); }
		/// <summary>ID of the credit card.</summary>
		public string CreditCardID { get => GetProp<string>("CreditCardID"); set => SetProp<string>("CreditCardID", value); }
		/// <summary>ID of the spending account.</summary>
		public string SpendingAccountID { get => GetProp<string>("SpendingAccountID"); set => SetProp<string>("SpendingAccountID", value); }
	}
	public class Supplier : OrderCloudModel
	{
		/// <summary>ID of the supplier. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the supplier. Required. Max length 100 characters. Searchable: priority level 1. Sortable.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>If false, all authentication is prohibited.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Date created of the supplier. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get => GetProp<DateTimeOffset>("DateCreated"); set => SetProp<DateTimeOffset>("DateCreated", value); }
		/// <summary>If false, buyers will only be able to set ToCompanyID on an order to the Marketplace Owner, or suppliers they have an explicit relationship to.</summary>
		public bool AllBuyersCanOrder { get => GetProp<bool>("AllBuyersCanOrder"); set => SetProp<bool>("AllBuyersCanOrder", value); }
		/// <summary>Container for extended (custom) properties of the supplier.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Supplier class instead.</typeparam>
	public class Supplier<Txp> : Supplier
	{
		/// <summary>Container for extended (custom) properties of the supplier.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class SupplierBuyer : OrderCloudModel
	{
		/// <summary>ID of the buyer. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the buyer. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
	}
	public class TokenPasswordReset : OrderCloudModel
	{
		/// <summary>New password of the token password reset. Required.</summary>
		[Required]
		public string NewPassword { get => GetProp<string>("NewPassword"); set => SetProp<string>("NewPassword", value); }
	}
	public class TrackingEvent : OrderCloudModel
	{
		/// <summary>ID of the tracking event. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Event type of the tracking event. Required. Searchable: priority level 2. Sortable: priority level 2. Possible values: UserLoggedIn, LineItemAdded, LineItemUpdated, OrderSubmitted.</summary>
		[Required]
		public TrackingEventType EventType { get => GetProp<TrackingEventType>("EventType"); set => SetProp<TrackingEventType>("EventType", value); }
		/// <summary>ID of the client. Required.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
		/// <summary>Name of the tracking event. Required.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Config data of the tracking event.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
		/// <summary>ID of the delivery config. Required.</summary>
		[Required]
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
	}
	public class User : OrderCloudModel
	{
		/// <summary>ID of the user. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the company.</summary>
		[ApiReadOnly]
		public string CompanyID { get => GetProp<string>("CompanyID"); set => SetProp<string>("CompanyID", value); }
		/// <summary>Must be unique across the Marketplace.</summary>
		[Required]
		public string Username { get => GetProp<string>("Username"); set => SetProp<string>("Username", value); }
		/// <summary>Password of the user.</summary>
		[ApiWriteOnly]
		public string Password { get => GetProp<string>("Password"); set => SetProp<string>("Password", value); }
		/// <summary>First name of the user. Required. Max length 100 characters. Searchable: priority level 4. Sortable: priority level 2.</summary>
		[Required]
		public string FirstName { get => GetProp<string>("FirstName"); set => SetProp<string>("FirstName", value); }
		/// <summary>Last name of the user. Required. Max length 100 characters. Searchable: priority level 3. Sortable: priority level 1.</summary>
		[Required]
		public string LastName { get => GetProp<string>("LastName"); set => SetProp<string>("LastName", value); }
		/// <summary>Email of the user. Required. Max length 200 characters. Searchable: priority level 5. Sortable.</summary>
		[Required]
		public string Email { get => GetProp<string>("Email"); set => SetProp<string>("Email", value); }
		/// <summary>Phone of the user. Max length 100 characters.</summary>
		public string Phone { get => GetProp<string>("Phone"); set => SetProp<string>("Phone", value); }
		/// <summary>Terms accepted of the user.</summary>
		public DateTimeOffset? TermsAccepted { get => GetProp<DateTimeOffset?>("TermsAccepted"); set => SetProp<DateTimeOffset?>("TermsAccepted", value); }
		/// <summary>If false, authentication is prohibited.</summary>
		[Required]
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Container for extended (custom) properties of the user.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>List of Roles currently available to the user via all SecurityProfile Assignments.</summary>
		[ApiReadOnly]
		public IReadOnlyList<string> AvailableRoles { get => GetProp<IReadOnlyList<string>>("AvailableRoles"); set => SetProp<IReadOnlyList<string>>("AvailableRoles", value); }
		/// <summary>Most specific Locale assigned to the user, if any.</summary>
		[ApiReadOnly]
		public Locale Locale { get => GetProp<Locale>("Locale"); set => SetProp<Locale>("Locale", value); }
		/// <summary>Date created of the user. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get => GetProp<DateTimeOffset?>("DateCreated"); set => SetProp<DateTimeOffset?>("DateCreated", value); }
		/// <summary>Can be used in conjunction with SecurityProfile.PasswordConfig to enforce password reset schedules.</summary>
		[ApiReadOnly]
		public DateTimeOffset? PasswordLastSetDate { get => GetProp<DateTimeOffset?>("PasswordLastSetDate"); set => SetProp<DateTimeOffset?>("PasswordLastSetDate", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic User class instead.</typeparam>
	public class User<Txp> : User
	{
		/// <summary>Container for extended (custom) properties of the user.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class UserGroup : OrderCloudModel
	{
		/// <summary>ID of the user group. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the user group. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the user group. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Container for extended (custom) properties of the user group.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic UserGroup class instead.</typeparam>
	public class UserGroup<Txp> : UserGroup
	{
		/// <summary>Container for extended (custom) properties of the user group.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class UserGroupAssignment : OrderCloudModel
	{
		/// <summary>ID of the user group. Required.</summary>
		[Required]
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>ID of the user. Required.</summary>
		[Required]
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
	}
	public class Variant : OrderCloudModel
	{
		/// <summary>ID of the variant. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the variant. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the variant. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>If false, variant is not visible or purchasable from the Shopper perspective.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Ship weight of the variant.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the variant.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the variant.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the variant.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>Inventory of the variant.</summary>
		public VariantInventory Inventory { get => GetProp<VariantInventory>("Inventory"); set => SetProp<VariantInventory>("Inventory", value); }
		/// <summary>Specs of the variant.</summary>
		[ApiReadOnly]
		public IReadOnlyList<VariantSpec> Specs { get => GetProp<IReadOnlyList<VariantSpec>>("Specs"); set => SetProp<IReadOnlyList<VariantSpec>>("Specs", value); }
		/// <summary>Container for extended (custom) properties of the variant.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic Variant class instead.</typeparam>
	public class Variant<Txp> : Variant
	{
		/// <summary>Container for extended (custom) properties of the variant.</summary>
		public new Txp xp { get => GetProp<Txp>("xp"); set => SetProp<Txp>("xp", value); }
	}
	public class VariantInventory : OrderCloudModel
	{
		/// <summary>Quantity available of the variant inventory.</summary>
		public int? QuantityAvailable { get => GetProp<int?>("QuantityAvailable"); set => SetProp<int?>("QuantityAvailable", value); }
		/// <summary>Notification point of the variant inventory.</summary>
		public int? NotificationPoint { get => GetProp<int?>("NotificationPoint"); set => SetProp<int?>("NotificationPoint", value); }
		/// <summary>Last updated of the variant inventory.</summary>
		[ApiReadOnly]
		public DateTimeOffset LastUpdated { get => GetProp<DateTimeOffset>("LastUpdated"); set => SetProp<DateTimeOffset>("LastUpdated", value); }
	}
	public class VariantSpec : OrderCloudModel
	{
		/// <summary>ID of the spec. Required.</summary>
		[Required]
		public string SpecID { get => GetProp<string>("SpecID"); set => SetProp<string>("SpecID", value); }
		/// <summary>Name of the variant spec.</summary>
		[ApiReadOnly]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>ID of the option.</summary>
		public string OptionID { get => GetProp<string>("OptionID"); set => SetProp<string>("OptionID", value); }
		/// <summary>Value of the variant spec. Max length 2000 characters.</summary>
		public string Value { get => GetProp<string>("Value"); set => SetProp<string>("Value", value); }
		/// <summary>Price markup type of the variant spec. Possible values: NoMarkup, AmountPerQuantity, AmountTotal, Percentage.</summary>
		public PriceMarkupType? PriceMarkupType { get => GetProp<PriceMarkupType?>("PriceMarkupType"); set => SetProp<PriceMarkupType?>("PriceMarkupType", value); }
		/// <summary>Price markup of the variant spec.</summary>
		public decimal? PriceMarkup { get => GetProp<decimal?>("PriceMarkup"); set => SetProp<decimal?>("PriceMarkup", value); }
	}
	public class Webhook : OrderCloudModel
	{
		/// <summary>ID of the webhook. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the webhook. Required. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the webhook. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>URL the WebHook will POST data to, likely a route within your middleware and required unless there is a valid deliveryConfig.</summary>
		public string Url { get => GetProp<string>("Url"); set => SetProp<string>("Url", value); }
		/// <summary>Security feature that allows your middleware to verify the digital signature in the request header to ensure you only accept trusted data.</summary>
		public string HashKey { get => GetProp<string>("HashKey"); set => SetProp<string>("HashKey", value); }
		/// <summary>If you need additional data not provided by the WebHook payload, you can request any elevated roles needed to make additional calls.</summary>
		public IList<ApiRole> ElevatedRoles { get => GetProp<IList<ApiRole>>("ElevatedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("ElevatedRoles", value); }
		/// <summary>Config data of the webhook.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
		/// <summary>If true, the Webhook is processed prior to the call being made and OrderCloud waits for a response before proceeding.</summary>
		public bool BeforeProcessRequest { get => GetProp<bool>("BeforeProcessRequest"); set => SetProp<bool>("BeforeProcessRequest", value); }
		/// <summary>List of API ClientIDs the WebHook will be triggered for.</summary>
		public IList<string> ApiClientIDs { get => GetProp<IList<string>>("ApiClientIDs", new List<string>()); set => SetProp<IList<string>>("ApiClientIDs", value); }
		/// <summary>List of routes the WebHook will be triggered for.</summary>
		public IList<WebhookRoute> WebhookRoutes { get => GetProp<IList<WebhookRoute>>("WebhookRoutes", new List<WebhookRoute>()); set => SetProp<IList<WebhookRoute>>("WebhookRoutes", value); }
		/// <summary>ID of the delivery config.</summary>
		public string DeliveryConfigID { get => GetProp<string>("DeliveryConfigID"); set => SetProp<string>("DeliveryConfigID", value); }
		/// <summary>The header name that can be passed to your middleware.</summary>
		public string CustomAuthHeaderName { get => GetProp<string>("CustomAuthHeaderName"); set => SetProp<string>("CustomAuthHeaderName", value); }
		/// <summary>The header value that can be passed to your middleware.</summary>
		[ApiWriteOnly]
		public string CustomAuthHeaderValue { get => GetProp<string>("CustomAuthHeaderValue"); set => SetProp<string>("CustomAuthHeaderValue", value); }
	}
	public class WebhookRoute : OrderCloudModel
	{
		/// <summary>Route of the webhook route. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string Route { get => GetProp<string>("Route"); set => SetProp<string>("Route", value); }
		/// <summary>Verb of the webhook route. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string Verb { get => GetProp<string>("Verb"); set => SetProp<string>("Verb", value); }
	}
	public class XpIndex : OrderCloudModel
	{
		/// <summary>Thing type of the xp index. Searchable: priority level 0. Sortable: priority level 0. Possible values: Address, Variant, Order, OrderReturn, LineItem, CostCenter, CreditCard, Payment, Spec, SpecOption, UserGroup, Company, Category, PriceSchedule, Shipment, SpendingAccount, User, Promotion, ApprovalRule, SellerApprovalRule, Catalog, ProductFacet, MessageSender, InventoryRecord, ProductCollection, Subscription, GroupOrderInvitation.</summary>
		public XpThingType ThingType { get => GetProp<XpThingType>("ThingType"); set => SetProp<XpThingType>("ThingType", value); }
		/// <summary>Key of the xp index. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string Key { get => GetProp<string>("Key"); set => SetProp<string>("Key", value); }
	}
	public class PartialAddress : Address, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialAddress class instead.</typeparam>
	public class PartialAddress<Txp> : PartialAddress
	{ }
	public class PartialAdHocProduct : AdHocProduct, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialAdHocProduct class instead.</typeparam>
	public class PartialAdHocProduct<Txp> : PartialAdHocProduct
	{ }
	public class PartialApiClient : ApiClient, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialApiClient class instead.</typeparam>
	public class PartialApiClient<Txp> : PartialApiClient
	{ }
	public class PartialApiClientSecret : ApiClientSecret, IPartial { }
	public class PartialApprovalRule : ApprovalRule, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialApprovalRule class instead.</typeparam>
	public class PartialApprovalRule<Txp> : PartialApprovalRule
	{ }
	public class PartialAzureBlobConfig : AzureBlobConfig, IPartial { }
	public class PartialAzureTableConfig : AzureTableConfig, IPartial { }
	public class PartialBundle : Bundle, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialBundle class instead.</typeparam>
	public class PartialBundle<Txp> : PartialBundle
	{ }
	public class PartialBuyer : Buyer, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialBuyer class instead.</typeparam>
	public class PartialBuyer<Txp> : PartialBuyer
	{ }
	public class PartialBuyerAddress : BuyerAddress, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialBuyerAddress class instead.</typeparam>
	public class PartialBuyerAddress<Txp> : PartialBuyerAddress
	{ }
	public class PartialBuyerCreditCard : BuyerCreditCard, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialBuyerCreditCard class instead.</typeparam>
	public class PartialBuyerCreditCard<Txp> : PartialBuyerCreditCard
	{ }
	public class PartialCatalog : Catalog, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialCatalog class instead.</typeparam>
	public class PartialCatalog<Txp> : PartialCatalog
	{ }
	public class PartialCategory : Category, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialCategory class instead.</typeparam>
	public class PartialCategory<Txp> : PartialCategory
	{ }
	public class PartialContentHubConfig : ContentHubConfig, IPartial { }
	public class PartialCosmosDbConfig : CosmosDbConfig, IPartial { }
	public class PartialCostCenter : CostCenter, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialCostCenter class instead.</typeparam>
	public class PartialCostCenter<Txp> : PartialCostCenter
	{ }
	public class PartialCreditCard : CreditCard, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialCreditCard class instead.</typeparam>
	public class PartialCreditCard<Txp> : PartialCreditCard
	{ }
	public class PartialDeliveryConfig : DeliveryConfig, IPartial { }
	public class PartialDeliveryTargets : DeliveryTargets, IPartial { }
	public class PartialDiscoverEvent : DiscoverEvent, IPartial { }
	public class PartialErrorConfig : ErrorConfig, IPartial { }
	public class PartialEventHubConfig : EventHubConfig, IPartial { }
	/// <summary>Features in beta are subject to change and are not available in production.</summary>
	public class PartialGroupOrderInvitation : GroupOrderInvitation, IPartial { }
	/// <summary>Features in beta are subject to change and are not available in production.</summary>
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialGroupOrderInvitation class instead.</typeparam>
	public class PartialGroupOrderInvitation<Txp> : PartialGroupOrderInvitation
	{ }
	public class PartialHttpConfig : HttpConfig, IPartial { }
	public class PartialImpersonationConfig : ImpersonationConfig, IPartial { }
	public class PartialIncrementor : Incrementor, IPartial { }
	public class PartialIntegrationEvent : IntegrationEvent, IPartial { }
	public class PartialInventory : Inventory, IPartial { }
	public class PartialInventoryIntegration : InventoryIntegration, IPartial { }
	public class PartialInventoryRecord : InventoryRecord, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TAddress">Specific type of the Address property. If not using a custom type, specify Address.</typeparam>
	public class PartialInventoryRecord<Txp, TAddress> : PartialInventoryRecord
		where TAddress : Address
	{ }
	public class PartialKafkaConfig : KafkaConfig, IPartial { }
	public class PartialLineItem : LineItem, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TProduct">Specific type of the Product property. If not using a custom type, specify LineItemProduct.</typeparam>
	/// <typeparam name="TVariant">Specific type of the Variant property. If not using a custom type, specify LineItemVariant.</typeparam>
	/// <typeparam name="TShippingAddress">Specific type of the ShippingAddress property. If not using a custom type, specify Address.</typeparam>
	/// <typeparam name="TShipFromAddress">Specific type of the ShipFromAddress property. If not using a custom type, specify Address.</typeparam>
	public class PartialLineItem<Txp, TProduct, TVariant, TShippingAddress, TShipFromAddress> : PartialLineItem
		where TProduct : LineItemProduct
		where TVariant : LineItemVariant
		where TShippingAddress : Address
		where TShipFromAddress : Address
	{ }
	public class PartialLineItemProduct : LineItemProduct, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialLineItemProduct class instead.</typeparam>
	public class PartialLineItemProduct<Txp> : PartialLineItemProduct
	{ }
	public class PartialLineItemSpec : LineItemSpec, IPartial { }
	public class PartialLineItemVariant : LineItemVariant, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialLineItemVariant class instead.</typeparam>
	public class PartialLineItemVariant<Txp> : PartialLineItemVariant
	{ }
	public class PartialLocale : Locale, IPartial { }
	public class PartialMandrillConfig : MandrillConfig, IPartial { }
	public class PartialMeBuyer : MeBuyer, IPartial { }
	public class PartialMeSeller : MeSeller, IPartial { }
	public class PartialMessageSender : MessageSender, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialMessageSender class instead.</typeparam>
	public class PartialMessageSender<Txp> : PartialMessageSender
	{ }
	public class PartialMessageSenderConfig : MessageSenderConfig, IPartial { }
	public class PartialMeSupplier : MeSupplier, IPartial { }
	public class PartialMeUser : MeUser, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialMeUser class instead.</typeparam>
	public class PartialMeUser<Txp> : PartialMeUser
	{ }
	public class PartialOpenIdConnect : OpenIdConnect, IPartial { }
	public class PartialOrder : Order, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TFromUser">Specific type of the FromUser property. If not using a custom type, specify User.</typeparam>
	/// <typeparam name="TBillingAddress">Specific type of the BillingAddress property. If not using a custom type, specify Address.</typeparam>
	public class PartialOrder<Txp, TFromUser, TBillingAddress> : PartialOrder
		where TFromUser : User
		where TBillingAddress : Address
	{ }
	public class PartialOrderReturn : OrderReturn, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialOrderReturn class instead.</typeparam>
	public class PartialOrderReturn<Txp> : PartialOrderReturn
	{ }
	public class PartialOrderReturnItem : OrderReturnItem, IPartial { }
	public class PartialOrderSyncConfig : OrderSyncConfig, IPartial { }
	public class PartialPasswordConfig : PasswordConfig, IPartial { }
	public class PartialPayment : Payment, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TTransactions">Specific type of the Transactions property. If not using a custom type, specify PaymentTransaction.</typeparam>
	public class PartialPayment<Txp, TTransactions> : PartialPayment
		where TTransactions : PaymentTransaction
	{ }
	public class PartialPaymentTransaction : PaymentTransaction, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialPaymentTransaction class instead.</typeparam>
	public class PartialPaymentTransaction<Txp> : PartialPaymentTransaction
	{ }
	public class PartialPriceBreak : PriceBreak, IPartial { }
	public class PartialPriceSchedule : PriceSchedule, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialPriceSchedule class instead.</typeparam>
	public class PartialPriceSchedule<Txp> : PartialPriceSchedule
	{ }
	public class PartialProduct : Product, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialProduct class instead.</typeparam>
	public class PartialProduct<Txp> : PartialProduct
	{ }
	public class PartialProductCollection : ProductCollection, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialProductCollection class instead.</typeparam>
	public class PartialProductCollection<Txp> : PartialProductCollection
	{ }
	public class PartialProductCollectionInvitation : ProductCollectionInvitation, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialProductCollectionInvitation class instead.</typeparam>
	public class PartialProductCollectionInvitation<Txp> : PartialProductCollectionInvitation
	{ }
	public class PartialProductFacet : ProductFacet, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialProductFacet class instead.</typeparam>
	public class PartialProductFacet<Txp> : PartialProductFacet
	{ }
	public class PartialProductSyncConfig : ProductSyncConfig, IPartial { }
	public class PartialPromotion : Promotion, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialPromotion class instead.</typeparam>
	public class PartialPromotion<Txp> : PartialPromotion
	{ }
	public class PartialPromotionIntegration : PromotionIntegration, IPartial { }
	public class PartialSearchIngestion : SearchIngestion, IPartial { }
	public class PartialSecurityProfile : SecurityProfile, IPartial { }
	public class PartialSellerApprovalRule : SellerApprovalRule, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialSellerApprovalRule class instead.</typeparam>
	public class PartialSellerApprovalRule<Txp> : PartialSellerApprovalRule
	{ }
	public class PartialSendEvent : SendEvent, IPartial { }
	public class PartialShipment : Shipment, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TFromAddress">Specific type of the FromAddress property. If not using a custom type, specify Address.</typeparam>
	/// <typeparam name="TToAddress">Specific type of the ToAddress property. If not using a custom type, specify Address.</typeparam>
	public class PartialShipment<Txp, TFromAddress, TToAddress> : PartialShipment
		where TFromAddress : Address
		where TToAddress : Address
	{ }
	public class PartialSpec : Spec, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, specify dynamic.</typeparam>
	/// <typeparam name="TOptions">Specific type of the Options property. If not using a custom type, specify SpecOption.</typeparam>
	public class PartialSpec<Txp, TOptions> : PartialSpec
		where TOptions : SpecOption
	{ }
	public class PartialSpecOption : SpecOption, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialSpecOption class instead.</typeparam>
	public class PartialSpecOption<Txp> : PartialSpecOption
	{ }
	public class PartialSpendingAccount : SpendingAccount, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialSpendingAccount class instead.</typeparam>
	public class PartialSpendingAccount<Txp> : PartialSpendingAccount
	{ }
	public class PartialSubscription : Subscription, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialSubscription class instead.</typeparam>
	public class PartialSubscription<Txp> : PartialSubscription
	{ }
	public class PartialSubscriptionIntegration : SubscriptionIntegration, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialSubscriptionIntegration class instead.</typeparam>
	public class PartialSubscriptionIntegration<Txp> : PartialSubscriptionIntegration
	{ }
	public class PartialSubscriptionPayment : SubscriptionPayment, IPartial { }
	public class PartialSupplier : Supplier, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialSupplier class instead.</typeparam>
	public class PartialSupplier<Txp> : PartialSupplier
	{ }
	public class PartialTrackingEvent : TrackingEvent, IPartial { }
	public class PartialUser : User, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialUser class instead.</typeparam>
	public class PartialUser<Txp> : PartialUser
	{ }
	public class PartialUserGroup : UserGroup, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialUserGroup class instead.</typeparam>
	public class PartialUserGroup<Txp> : PartialUserGroup
	{ }
	public class PartialVariant : Variant, IPartial { }
	/// <typeparam name="Txp">Specific type of the xp property. If not using a custom type, use the non-generic PartialVariant class instead.</typeparam>
	public class PartialVariant<Txp> : PartialVariant
	{ }
	public class PartialVariantInventory : VariantInventory, IPartial { }
	public class PartialVariantSpec : VariantSpec, IPartial { }
	public class PartialWebhook : Webhook, IPartial { }
	public class PartialWebhookRoute : WebhookRoute, IPartial { }
}
