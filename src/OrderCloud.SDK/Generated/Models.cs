using System;
using System.Collections.Generic;
using System.Dynamic;

namespace OrderCloud.SDK
{
	public enum ApiRole { ApiClientAdmin, ApiClientReader, AddressAdmin, AddressReader, AdminAddressAdmin, AdminAddressReader, AdminUserAdmin, AdminUserGroupAdmin, AdminUserGroupReader, AdminUserReader, ApprovalRuleAdmin, ApprovalRuleReader, BuyerAdmin, BuyerImpersonation, BuyerReader, BuyerUserAdmin, BuyerUserReader, CatalogAdmin, CatalogReader, CategoryAdmin, CategoryReader, CostCenterAdmin, CostCenterReader, CreditCardAdmin, CreditCardReader, FullAccess, IncrementorAdmin, IncrementorReader, InventoryAdmin, MeAddressAdmin, MeAdmin, MeCreditCardAdmin, MessageConfigAssignmentAdmin, MeXpAdmin, OrderAdmin, OrderReader, OverrideShipping, OverrideTax, OverrideUnitPrice, PasswordReset, PriceScheduleAdmin, PriceScheduleReader, ProductAdmin, ProductAssignmentAdmin, ProductFacetAdmin, ProductFacetReader, ProductReader, PromotionAdmin, PromotionReader, SecurityProfileAdmin, SecurityProfileReader, SetSecurityProfile, ShipmentAdmin, ShipmentReader, Shopper, SpendingAccountAdmin, SpendingAccountReader, SupplierAddressAdmin, SupplierAddressReader, SupplierAdmin, SupplierReader, SupplierUserAdmin, SupplierUserGroupAdmin, SupplierUserGroupReader, SupplierUserReader, UnsubmittedOrderReader, UserGroupAdmin, UserGroupReader, OpenIDConnectReader, OpenIDConnectAdmin, MessageSenderReader, MessageSenderAdmin, XpIndexAdmin, WebhookReader, WebhookAdmin }
	public enum ApprovalStatus { Pending, Approved, Declined }
	public enum CommerceRole { Buyer, Seller, Supplier }
	public enum MessageType { OrderDeclined, OrderSubmitted, ShipmentCreated, ForgottenPassword, OrderSubmittedForYourApproval, OrderSubmittedForApproval, OrderApproved, OrderSubmittedForYourApprovalHasBeenApproved, OrderSubmittedForYourApprovalHasBeenDeclined, NewUserInvitation }
	public enum OrderDirection { Incoming, Outgoing }
	public enum OrderStatus { Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled }
	public enum PartyType { User, Group, Company }
	public enum PaymentType { PurchaseOrder, CreditCard, SpendingAccount }
	public enum PriceMarkupType { NoMarkup, AmountPerQuantity, AmountTotal, Percentage }
	public enum UserOrderMoveOption { None, Unsubmitted, All }
	public enum XpThingType { Product, Variant, Order, LineItem, Address, CostCenter, CreditCard, Payment, Spec, SpecOption, UserGroup, Company, Category, PriceSchedule, Shipment, SpendingAccount, User, Promotion, ApprovalRule, Catalog, ProductFacet, MessageSender }

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
		public DateTimeOffset? DateCreated { get; set; }
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
		[Required]
		public string State { get => GetProp<string>("State"); set => SetProp<string>("State", value); }
		/// <summary>Zip of the address. Required. Max length 100 characters. Searchable: priority level 10. Sortable.</summary>
		[Required]
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Address.</typeparam>
	public class Address<Txp> : Address
	{
		public new Txp xp { get; set; }
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

	public class ApiClient : OrderCloudModel
	{
		/// <summary>ID of the api client. Searchable: priority level 1. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public string ID { get; set; }
		/// <summary>Client secret of the api client.</summary>
		public string ClientSecret { get => GetProp<string>("ClientSecret"); set => SetProp<string>("ClientSecret", value); }
		/// <summary>Access token duration of the api client. Required. Must be between 10 and 600.</summary>
		[Required]
		public int AccessTokenDuration { get => GetProp<int>("AccessTokenDuration"); set => SetProp<int>("AccessTokenDuration", value); }
		/// <summary>Active of the api client.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>App name of the api client. Required. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string AppName { get => GetProp<string>("AppName"); set => SetProp<string>("AppName", value); }
		/// <summary>Refresh token duration of the api client. Must be between 0 and 43200.</summary>
		public int RefreshTokenDuration { get => GetProp<int>("RefreshTokenDuration"); set => SetProp<int>("RefreshTokenDuration", value); }
		/// <summary>Default context user name of the api client. Searchable: priority level 3. Sortable.</summary>
		public string DefaultContextUserName { get => GetProp<string>("DefaultContextUserName"); set => SetProp<string>("DefaultContextUserName", value); }
		/// <summary>Container for extended (custom) properties of the api client.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Allow any buyer of the api client.</summary>
		public bool AllowAnyBuyer { get => GetProp<bool>("AllowAnyBuyer"); set => SetProp<bool>("AllowAnyBuyer", value); }
		/// <summary>Allow any supplier of the api client.</summary>
		public bool AllowAnySupplier { get => GetProp<bool>("AllowAnySupplier"); set => SetProp<bool>("AllowAnySupplier", value); }
		/// <summary>Allow seller of the api client.</summary>
		public bool AllowSeller { get => GetProp<bool>("AllowSeller"); set => SetProp<bool>("AllowSeller", value); }
		/// <summary>Is anon buyer of the api client.</summary>
		public bool IsAnonBuyer { get => GetProp<bool>("IsAnonBuyer"); set => SetProp<bool>("IsAnonBuyer", value); }
		/// <summary>Assigned buyer count of the api client.</summary>
		[ApiReadOnly]
		public int AssignedBuyerCount { get; set; }
		/// <summary>Assigned supplier count of the api client.</summary>
		[ApiReadOnly]
		public int AssignedSupplierCount { get; set; }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the ApiClient.</typeparam>
	public class ApiClient<Txp> : ApiClient
	{
		public new Txp xp { get; set; }
	}

	public class ApiClientAssignment : OrderCloudModel
	{
		/// <summary>ID of the api client.</summary>
		public string ApiClientID { get => GetProp<string>("ApiClientID"); set => SetProp<string>("ApiClientID", value); }
		/// <summary>ID of the buyer. Sortable: priority level 0.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>ID of the supplier. Sortable: priority level 1.</summary>
		public string SupplierID { get => GetProp<string>("SupplierID"); set => SetProp<string>("SupplierID", value); }
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
		/// <summary>Rule expression of the approval rule. Required. Max length 400 characters. Searchable: priority level 4. Sortable.</summary>
		[Required]
		public string RuleExpression { get => GetProp<string>("RuleExpression"); set => SetProp<string>("RuleExpression", value); }
		/// <summary>Container for extended (custom) properties of the approval rule.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the ApprovalRule.</typeparam>
	public class ApprovalRule<Txp> : ApprovalRule
	{
		public new Txp xp { get; set; }
	}

	public class Buyer : OrderCloudModel
	{
		/// <summary>ID of the buyer. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the buyer. Required. Max length 100 characters. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>ID of the default catalog.</summary>
		public string DefaultCatalogID { get => GetProp<string>("DefaultCatalogID"); set => SetProp<string>("DefaultCatalogID", value); }
		/// <summary>Active of the buyer.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Container for extended (custom) properties of the buyer.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Buyer.</typeparam>
	public class Buyer<Txp> : Buyer
	{
		public new Txp xp { get; set; }
	}

	public class BuyerAddress : OrderCloudModel
	{
		/// <summary>ID of the address. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public string ID { get; set; }
		/// <summary>Shipping of the address. Searchable: priority level 6.</summary>
		public bool Shipping { get => GetProp<bool>("Shipping"); set => SetProp<bool>("Shipping", value); }
		/// <summary>Billing of the address. Searchable: priority level 7.</summary>
		public bool Billing { get => GetProp<bool>("Billing"); set => SetProp<bool>("Billing", value); }
		/// <summary>Editable of the address. Searchable: priority level 8.</summary>
		[ApiReadOnly]
		public bool Editable { get; set; }
		/// <summary>Date created of the address. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get; set; }
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
		[Required]
		public string State { get => GetProp<string>("State"); set => SetProp<string>("State", value); }
		/// <summary>Zip of the address. Required. Max length 100 characters. Searchable: priority level 10. Sortable.</summary>
		[Required]
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the BuyerAddress.</typeparam>
	public class BuyerAddress<Txp> : BuyerAddress
	{
		public new Txp xp { get; set; }
	}

	public class BuyerCreditCard : OrderCloudModel
	{
		/// <summary>ID of the credit card. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public string ID { get; set; }
		/// <summary>Editable of the credit card. Searchable: priority level 5.</summary>
		[ApiReadOnly]
		public bool Editable { get; set; }
		/// <summary>Token of the credit card.</summary>
		public string Token { get => GetProp<string>("Token"); set => SetProp<string>("Token", value); }
		/// <summary>Date created of the credit card. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get; set; }
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the BuyerCreditCard.</typeparam>
	public class BuyerCreditCard<Txp> : BuyerCreditCard
	{
		public new Txp xp { get; set; }
	}

	public class BuyerProduct : OrderCloudModel
	{
		/// <summary>Price schedule of the product.</summary>
		[ApiReadOnly]
		public PriceSchedule PriceSchedule { get; set; }
		/// <summary>ID of the product. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the product. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Quantity multiplier of the product. Required. Must be at least 1.</summary>
		[Required]
		public int QuantityMultiplier { get => GetProp<int>("QuantityMultiplier", 1); set => SetProp<int>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>Active of the product.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Spec count of the product.</summary>
		[ApiReadOnly]
		public int SpecCount { get; set; }
		/// <summary>Variant count of the product.</summary>
		[ApiReadOnly]
		public int VariantCount { get; set; }
		/// <summary>ID of the ship from address.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Inventory of the product.</summary>
		public Inventory Inventory { get => GetProp<Inventory>("Inventory"); set => SetProp<Inventory>("Inventory", value); }
		/// <summary>ID of the default supplier.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>Container for extended (custom) properties of the product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the BuyerProduct.</typeparam>
	/// <typeparam name="TPriceScheduleXP">Type used as a container for xp of the nested PriceSchedule. If weakly typed or unneeded, specify dynamic.</typeparam>
	public class BuyerProduct<Txp, TPriceScheduleXP> : BuyerProduct
	{
		public new Txp xp { get; set; }
		public new PriceSchedule<TPriceScheduleXP> PriceSchedule { get; set; }
	}

	public class Catalog : OrderCloudModel
	{
		/// <summary>ID of the catalog. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the Seller or Supplier org that created the Catalog.</summary>
		[ApiReadOnly]
		public string OwnerID { get; set; }
		/// <summary>Name of the catalog. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the catalog. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Active of the catalog.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Category count of the catalog.</summary>
		[ApiReadOnly]
		public int CategoryCount { get; set; }
		/// <summary>Container for extended (custom) properties of the catalog.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Catalog.</typeparam>
	public class Catalog<Txp> : Catalog
	{
		public new Txp xp { get; set; }
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
		public int ChildCount { get; set; }
		/// <summary>Container for extended (custom) properties of the category.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Category.</typeparam>
	public class Category<Txp> : Category
	{
		public new Txp xp { get; set; }
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the CostCenter.</typeparam>
	public class CostCenter<Txp> : CostCenter
	{
		public new Txp xp { get; set; }
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
		/// <summary>Token of the credit card.</summary>
		public string Token { get => GetProp<string>("Token"); set => SetProp<string>("Token", value); }
		/// <summary>Date created of the credit card. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get; set; }
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the CreditCard.</typeparam>
	public class CreditCard<Txp> : CreditCard
	{
		public new Txp xp { get; set; }
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
		/// <summary>The BuyerID of the impersonatee (party being impersonated)</summary>
		[Required]
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
		/// <summary>ID of the incrementor. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the incrementor. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Last number of the incrementor. Required. Must be between 0 and 2147483647.</summary>
		[Required]
		public int LastNumber { get => GetProp<int>("LastNumber"); set => SetProp<int>("LastNumber", value); }
		/// <summary>Left padding count of the incrementor. Required. Must be between 0 and 25.</summary>
		[Required]
		public int LeftPaddingCount { get => GetProp<int>("LeftPaddingCount"); set => SetProp<int>("LeftPaddingCount", value); }
	}

	public class Inventory : OrderCloudModel
	{
		/// <summary>Enabled of the inventory.</summary>
		public bool Enabled { get => GetProp<bool>("Enabled"); set => SetProp<bool>("Enabled", value); }
		/// <summary>Notification point of the inventory.</summary>
		public int? NotificationPoint { get => GetProp<int?>("NotificationPoint"); set => SetProp<int?>("NotificationPoint", value); }
		/// <summary>Variant level tracking of the inventory.</summary>
		public bool VariantLevelTracking { get => GetProp<bool>("VariantLevelTracking"); set => SetProp<bool>("VariantLevelTracking", value); }
		/// <summary>Order can exceed of the inventory.</summary>
		public bool OrderCanExceed { get => GetProp<bool>("OrderCanExceed"); set => SetProp<bool>("OrderCanExceed", value); }
		/// <summary>Automatically decrements on order submit.</summary>
		public int? QuantityAvailable { get => GetProp<int?>("QuantityAvailable"); set => SetProp<int?>("QuantityAvailable", value); }
		/// <summary>Last updated of the inventory.</summary>
		[ApiReadOnly]
		public DateTimeOffset? LastUpdated { get; set; }
	}

	public class LineItem : OrderCloudModel
	{
		/// <summary>ID of the line item. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the product. Required. Searchable: priority level 2. Sortable.</summary>
		[Required]
		public string ProductID { get => GetProp<string>("ProductID"); set => SetProp<string>("ProductID", value); }
		/// <summary>Quantity of the line item. Required. Must be at least 1.</summary>
		[Required]
		public int Quantity { get => GetProp<int>("Quantity", 1); set => SetProp<int>("Quantity", value); }
		/// <summary>Date added of the line item. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateAdded { get; set; }
		/// <summary>Quantity shipped of the line item.</summary>
		[ApiReadOnly]
		public int QuantityShipped { get; set; }
		/// <summary>Unit price of the line item. Must be between -9999999999999 and 9999999999999.</summary>
		public decimal? UnitPrice { get => GetProp<decimal?>("UnitPrice"); set => SetProp<decimal?>("UnitPrice", value); }
		/// <summary>Line total of the line item.</summary>
		[ApiReadOnly]
		public decimal LineTotal { get; set; }
		/// <summary>Cost center of the line item.</summary>
		public string CostCenter { get => GetProp<string>("CostCenter"); set => SetProp<string>("CostCenter", value); }
		/// <summary>Date needed of the line item.</summary>
		public DateTimeOffset? DateNeeded { get => GetProp<DateTimeOffset?>("DateNeeded"); set => SetProp<DateTimeOffset?>("DateNeeded", value); }
		/// <summary>Shipping account of the line item.</summary>
		public string ShippingAccount { get => GetProp<string>("ShippingAccount"); set => SetProp<string>("ShippingAccount", value); }
		/// <summary>ID of the shipping address.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>ID of the ship from address.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Product of the line item.</summary>
		[ApiReadOnly]
		public LineItemProduct Product { get; set; }
		/// <summary>Variant of the line item.</summary>
		[ApiReadOnly]
		public LineItemVariant Variant { get; set; }
		/// <summary>Shipping address of the line item.</summary>
		[ApiReadOnly]
		public Address ShippingAddress { get; set; }
		/// <summary>Ship from address of the line item.</summary>
		[ApiReadOnly]
		public Address ShipFromAddress { get; set; }
		/// <summary>ID of the supplier.</summary>
		[ApiReadOnly]
		public string SupplierID { get; set; }
		/// <summary>Specs of the line item.</summary>
		public IList<LineItemSpec> Specs { get => GetProp<IList<LineItemSpec>>("Specs", new List<LineItemSpec>()); set => SetProp<IList<LineItemSpec>>("Specs", value); }
		/// <summary>Container for extended (custom) properties of the line item.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the LineItem.</typeparam>
	/// <typeparam name="TProductXP">Type used as a container for xp of the nested Product. If weakly typed or unneeded, specify dynamic.</typeparam>
	/// <typeparam name="TVariantXP">Type used as a container for xp of the nested Variant. If weakly typed or unneeded, specify dynamic.</typeparam>
	/// <typeparam name="TShippingAddressXP">Type used as a container for xp of the nested ShippingAddress. If weakly typed or unneeded, specify dynamic.</typeparam>
	/// <typeparam name="TShipFromAddressXP">Type used as a container for xp of the nested ShipFromAddress. If weakly typed or unneeded, specify dynamic.</typeparam>
	public class LineItem<Txp, TProductXP, TVariantXP, TShippingAddressXP, TShipFromAddressXP> : LineItem
	{
		public new Txp xp { get; set; }
		public new LineItemProduct<TProductXP> Product { get; set; }
		public new LineItemVariant<TVariantXP> Variant { get; set; }
		public new Address<TShippingAddressXP> ShippingAddress { get; set; }
		public new Address<TShipFromAddressXP> ShipFromAddress { get; set; }
	}

	public class LineItemProduct : OrderCloudModel
	{
		/// <summary>ID of the line item product. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the line item product.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the line item product.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
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
		/// <summary>Container for extended (custom) properties of the line item product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the LineItemProduct.</typeparam>
	public class LineItemProduct<Txp> : LineItemProduct
	{
		public new Txp xp { get; set; }
	}

	public class LineItemSpec : OrderCloudModel
	{
		/// <summary>ID of the spec. Required.</summary>
		[Required]
		public string SpecID { get => GetProp<string>("SpecID"); set => SetProp<string>("SpecID", value); }
		/// <summary>Name of the line item spec.</summary>
		[ApiReadOnly]
		public string Name { get; set; }
		/// <summary>ID of the option.</summary>
		public string OptionID { get => GetProp<string>("OptionID"); set => SetProp<string>("OptionID", value); }
		/// <summary>Value of the line item spec. Max length 2000 characters.</summary>
		public string Value { get => GetProp<string>("Value"); set => SetProp<string>("Value", value); }
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the LineItemVariant.</typeparam>
	public class LineItemVariant<Txp> : LineItemVariant
	{
		public new Txp xp { get; set; }
	}

	public class MeBuyer : OrderCloudModel
	{
		/// <summary>ID of the buyer. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		[ApiReadOnly]
		public string ID { get; set; }
		/// <summary>ID of the default catalog.</summary>
		[ApiReadOnly]
		public string DefaultCatalogID { get; set; }
	}

	public class MessageCCListenerAssignment : OrderCloudModel
	{
		/// <summary>Message sender assignment of the message cc listener assignment.</summary>
		public MessageSenderAssignment MessageSenderAssignment { get => GetProp<MessageSenderAssignment>("MessageSenderAssignment"); set => SetProp<MessageSenderAssignment>("MessageSenderAssignment", value); }
		/// <summary>Message config name of the message cc listener assignment. Searchable: priority level 3. Sortable: priority level 3.</summary>
		[ApiReadOnly]
		public string MessageConfigName { get; set; }
		/// <summary>Message config description of the message cc listener assignment.</summary>
		[ApiReadOnly]
		public string MessageConfigDescription { get; set; }
		/// <summary>Message type of the message cc listener assignment. Possible values: OrderDeclined, OrderSubmitted, ShipmentCreated, ForgottenPassword, OrderSubmittedForYourApproval, OrderSubmittedForApproval, OrderApproved, OrderSubmittedForYourApprovalHasBeenApproved, OrderSubmittedForYourApprovalHasBeenDeclined, NewUserInvitation.</summary>
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
		/// <summary>URL of the message sender. Required. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string URL { get => GetProp<string>("URL"); set => SetProp<string>("URL", value); }
		/// <summary>Elevated roles of the message sender.</summary>
		public IList<ApiRole> ElevatedRoles { get => GetProp<IList<ApiRole>>("ElevatedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("ElevatedRoles", value); }
		/// <summary>Shared key of the message sender. Required.</summary>
		[Required]
		public string SharedKey { get => GetProp<string>("SharedKey"); set => SetProp<string>("SharedKey", value); }
		/// <summary>Container for extended (custom) properties of the message sender.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the MessageSender.</typeparam>
	public class MessageSender<Txp> : MessageSender
	{
		public new Txp xp { get; set; }
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
		public string MessageConfigName { get; set; }
		/// <summary>Message config description of the message sender assignment.</summary>
		[ApiReadOnly]
		public string MessageConfigDescription { get; set; }
	}

	public class MeSupplier : OrderCloudModel
	{
		/// <summary>ID of the supplier. Can only contain characters Aa-Zz, 0-9, -, and _.</summary>
		[ApiReadOnly]
		public string ID { get; set; }
	}

	public class MeUser : OrderCloudModel
	{
		/// <summary>Buyer of the user.</summary>
		[ApiReadOnly]
		public MeBuyer Buyer { get; set; }
		/// <summary>Supplier of the user.</summary>
		[ApiReadOnly]
		public MeSupplier Supplier { get; set; }
		/// <summary>ID of the user. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Username of the user. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 3.</summary>
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
		/// <summary>Active of the user. Required.</summary>
		[Required]
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Container for extended (custom) properties of the user.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Available roles of the user.</summary>
		[ApiReadOnly]
		public IReadOnlyList<string> AvailableRoles { get; set; }
		/// <summary>Date created of the user. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get; set; }
		/// <summary>Password last set date of the user. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? PasswordLastSetDate { get; set; }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the MeUser.</typeparam>
	public class MeUser<Txp> : MeUser
	{
		public new Txp xp { get; set; }
	}

	public class OpenIdConnect : OrderCloudModel
	{
		/// <summary>ID of this OpenID Connect configuration object. Each object allows authentication to one Ordercloud ApiClient through one Identity Providing Party.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>An ID that references an Ordercloud ApiClient.</summary>
		[Required]
		public string OrderCloudApiClientID { get => GetProp<string>("OrderCloudApiClientID"); set => SetProp<string>("OrderCloudApiClientID", value); }
		/// <summary>An app ID from the Identity Provider that is required to get JWT tokens.</summary>
		[Required]
		public string ConnectClientID { get => GetProp<string>("ConnectClientID"); set => SetProp<string>("ConnectClientID", value); }
		/// <summary>A secret string from the Identity Provider that grants access to get JWT tokens.</summary>
		[Required]
		public string ConnectClientSecret { get => GetProp<string>("ConnectClientSecret"); set => SetProp<string>("ConnectClientSecret", value); }
		/// <summary>A URL on your front-end ordering site where users will be redirected after they authenticate through the Identity Provider. The string "{token}" will be replaced with a valid Ordercloud JWT.</summary>
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
	}

	public class Order : OrderCloudModel
	{
		/// <summary>ID of the order. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>From user of the order. Sortable.</summary>
		[ApiReadOnly]
		public User FromUser { get; set; }
		/// <summary>ID of the Buyer or Seller placing the order. Mainly useful to the Seller or Supplier receiving it.</summary>
		public string FromCompanyID { get => GetProp<string>("FromCompanyID"); set => SetProp<string>("FromCompanyID", value); }
		/// <summary>ID of the Seller or Supplier receiving the order. Mainly useful to the Buyer or Seller placing it.</summary>
		public string ToCompanyID { get => GetProp<string>("ToCompanyID"); set => SetProp<string>("ToCompanyID", value); }
		/// <summary>ID of the from user. Sortable.</summary>
		public string FromUserID { get => GetProp<string>("FromUserID"); set => SetProp<string>("FromUserID", value); }
		/// <summary>ID of the billing address.</summary>
		public string BillingAddressID { get => GetProp<string>("BillingAddressID"); set => SetProp<string>("BillingAddressID", value); }
		/// <summary>Billing address of the order.</summary>
		[ApiReadOnly]
		public Address BillingAddress { get; set; }
		/// <summary>ID of the Shipping Address for all LineItems on the Order. Null when there are multiple Shipping Addresses involved.</summary>
		public string ShippingAddressID { get => GetProp<string>("ShippingAddressID"); set => SetProp<string>("ShippingAddressID", value); }
		/// <summary>Comments of the order. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
		/// <summary>Line item count of the order.</summary>
		[ApiReadOnly]
		public int LineItemCount { get; set; }
		/// <summary>Status of the order. Sortable. Possible values: Unsubmitted, AwaitingApproval, Declined, Open, Completed, Canceled.</summary>
		[ApiReadOnly]
		public OrderStatus Status { get; set; }
		/// <summary>Date created of the order. Sortable: priority level 2.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get; set; }
		/// <summary>Date submitted of the order. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateSubmitted { get; set; }
		/// <summary>Date approved of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateApproved { get; set; }
		/// <summary>Date declined of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateDeclined { get; set; }
		/// <summary>Date canceled of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCanceled { get; set; }
		/// <summary>Date completed of the order. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get; set; }
		/// <summary>Subtotal of the order. Sortable.</summary>
		[ApiReadOnly]
		public decimal Subtotal { get; set; }
		/// <summary>Shipping cost of the order. Sortable.</summary>
		public decimal ShippingCost { get => GetProp<decimal>("ShippingCost"); set => SetProp<decimal>("ShippingCost", value); }
		/// <summary>Tax cost of the order. Sortable.</summary>
		public decimal TaxCost { get => GetProp<decimal>("TaxCost"); set => SetProp<decimal>("TaxCost", value); }
		/// <summary>Promotion discount of the order. Sortable.</summary>
		[ApiReadOnly]
		public decimal PromotionDiscount { get; set; }
		/// <summary>Total of the order. Sortable.</summary>
		[ApiReadOnly]
		public decimal Total { get; set; }
		/// <summary>True if this Order has been passed from the Buyer to the Seller.</summary>
		[ApiReadOnly]
		public bool IsSubmitted { get; set; }
		/// <summary>Container for extended (custom) properties of the order.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Order.</typeparam>
	/// <typeparam name="TFromUserXP">Type used as a container for xp of the nested FromUser. If weakly typed or unneeded, specify dynamic.</typeparam>
	/// <typeparam name="TBillingAddressXP">Type used as a container for xp of the nested BillingAddress. If weakly typed or unneeded, specify dynamic.</typeparam>
	public class Order<Txp, TFromUserXP, TBillingAddressXP> : Order
	{
		public new Txp xp { get; set; }
		public new User<TFromUserXP> FromUser { get; set; }
		public new Address<TBillingAddressXP> BillingAddress { get; set; }
	}

	public class OrderApproval : OrderCloudModel
	{
		/// <summary>ID of the approval rule. Searchable: priority level 1. Sortable.</summary>
		[ApiReadOnly]
		public string ApprovalRuleID { get; set; }
		/// <summary>ID of the approving group. Searchable: priority level 2. Sortable.</summary>
		[ApiReadOnly]
		public string ApprovingGroupID { get; set; }
		/// <summary>Status of the order approval. Sortable. Possible values: Pending, Approved, Declined.</summary>
		[ApiReadOnly]
		public ApprovalStatus Status { get; set; }
		/// <summary>Allow resubmit of the order approval. Sortable.</summary>
		[ApiReadOnly]
		public bool AllowResubmit { get; set; }
		/// <summary>Date created of the order approval. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get; set; }
		/// <summary>Date completed of the order approval. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCompleted { get; set; }
		/// <summary>Approver of the order approval. Searchable: priority level 3. Sortable.</summary>
		[ApiReadOnly]
		public User Approver { get; set; }
		/// <summary>Comments of the order approval. Searchable: priority level 4.</summary>
		[ApiReadOnly]
		public string Comments { get; set; }
	}

	public class OrderApprovalInfo : OrderCloudModel
	{
		/// <summary>Comments of the order approval info. Max length 2000 characters.</summary>
		public string Comments { get => GetProp<string>("Comments"); set => SetProp<string>("Comments", value); }
		/// <summary>Allow resubmit of the order approval info.</summary>
		public bool AllowResubmit { get => GetProp<bool>("AllowResubmit"); set => SetProp<bool>("AllowResubmit", value); }
	}

	public class OrderPromotion : OrderCloudModel
	{
		/// <summary>Amount of the order promotion.</summary>
		[ApiReadOnly]
		public decimal Amount { get; set; }
		/// <summary>ID of the order promotion. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Must be unique. Entered by buyer when adding promo to order.</summary>
		[Required]
		public string Code { get => GetProp<string>("Code"); set => SetProp<string>("Code", value); }
		/// <summary>Name of the order promotion. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Redemption limit of the order promotion.</summary>
		public int? RedemptionLimit { get => GetProp<int?>("RedemptionLimit"); set => SetProp<int?>("RedemptionLimit", value); }
		/// <summary>Redemption limit per user of the order promotion.</summary>
		public int? RedemptionLimitPerUser { get => GetProp<int?>("RedemptionLimitPerUser"); set => SetProp<int?>("RedemptionLimitPerUser", value); }
		/// <summary>Redemption count of the order promotion.</summary>
		[ApiReadOnly]
		public int RedemptionCount { get; set; }
		/// <summary>Description of the order promotion. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Terms, conditions, and other legal jargon.</summary>
		public string FinePrint { get => GetProp<string>("FinePrint"); set => SetProp<string>("FinePrint", value); }
		/// <summary>Start date of the order promotion. Sortable.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>Expiration date of the order promotion. Sortable.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>Eligible expression of the order promotion. Required. Max length 400 characters. Searchable: priority level 6. Sortable.</summary>
		[Required]
		public string EligibleExpression { get => GetProp<string>("EligibleExpression"); set => SetProp<string>("EligibleExpression", value); }
		/// <summary>Value expression of the order promotion. Required. Max length 400 characters. Searchable: priority level 7. Sortable.</summary>
		[Required]
		public string ValueExpression { get => GetProp<string>("ValueExpression"); set => SetProp<string>("ValueExpression", value); }
		/// <summary>Can combine of the order promotion. Sortable.</summary>
		public bool CanCombine { get => GetProp<bool>("CanCombine"); set => SetProp<bool>("CanCombine", value); }
		/// <summary>Allow promo to be used by all buyers without creating assignments.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers"); set => SetProp<bool>("AllowAllBuyers", value); }
		/// <summary>Container for extended (custom) properties of the order promotion.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the OrderPromotion.</typeparam>
	public class OrderPromotion<Txp> : OrderPromotion
	{
		public new Txp xp { get; set; }
	}

	public class OrderSplitResult : OrderCloudModel
	{
		/// <summary>The outgoing Orders created, one for each unique Product.DefaultSupplierID on the original Order.</summary>
		public IList<Order> OutgoingOrders { get => GetProp<IList<Order>>("OutgoingOrders", new List<Order>()); set => SetProp<IList<Order>>("OutgoingOrders", value); }
		/// <summary>IDs of Line Items not added to an outgoing Order, most likely because Product.DefaultSupplierID is not set.</summary>
		public IList<string> RemainingLineItemIDs { get => GetProp<IList<string>>("RemainingLineItemIDs", new List<string>()); set => SetProp<IList<string>>("RemainingLineItemIDs", value); }
	}

	public class PasswordConfig : OrderCloudModel
	{
		/// <summary>Expire in days of the password config. Must be at least 1.</summary>
		public int? ExpireInDays { get => GetProp<int?>("ExpireInDays"); set => SetProp<int?>("ExpireInDays", value); }
	}

	public class PasswordReset : OrderCloudModel
	{
		/// <summary>ID of the client. Required.</summary>
		[Required]
		public string ClientID { get => GetProp<string>("ClientID"); set => SetProp<string>("ClientID", value); }
		/// <summary>Username of the password reset.</summary>
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
		public PaymentType Type { get => GetProp<PaymentType>("Type"); set => SetProp<PaymentType>("Type", value); }
		/// <summary>Date created of the payment. Sortable: priority level 1.</summary>
		[ApiReadOnly]
		public DateTimeOffset DateCreated { get; set; }
		/// <summary>ID of the credit card. Sortable.</summary>
		public string CreditCardID { get => GetProp<string>("CreditCardID"); set => SetProp<string>("CreditCardID", value); }
		/// <summary>ID of the spending account. Sortable.</summary>
		public string SpendingAccountID { get => GetProp<string>("SpendingAccountID"); set => SetProp<string>("SpendingAccountID", value); }
		/// <summary>Description of the payment. Max length 2000 characters. Searchable: priority level 2.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>If null, Payment applies to order total (or total of specific Line Items, if set), minus any other Payments where Amount is set.</summary>
		public decimal? Amount { get => GetProp<decimal?>("Amount"); set => SetProp<decimal?>("Amount", value); }
		/// <summary>Accepted of the payment.</summary>
		public bool? Accepted { get => GetProp<bool?>("Accepted"); set => SetProp<bool?>("Accepted", value); }
		/// <summary>Container for extended (custom) properties of the payment.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Transactions of the payment.</summary>
		[ApiReadOnly]
		public IReadOnlyList<PaymentTransaction> Transactions { get; set; }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Payment.</typeparam>
	public class Payment<Txp> : Payment
	{
		public new Txp xp { get; set; }
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the PaymentTransaction.</typeparam>
	public class PaymentTransaction<Txp> : PaymentTransaction
	{
		public new Txp xp { get; set; }
	}

	public class PriceBreak : OrderCloudModel
	{
		/// <summary>Quantity of the price break. Required. Must be at least 0.</summary>
		[Required]
		public int Quantity { get => GetProp<int>("Quantity"); set => SetProp<int>("Quantity", value); }
		/// <summary>Price of the price break. Required.</summary>
		[Required]
		public decimal Price { get => GetProp<decimal>("Price"); set => SetProp<decimal>("Price", value); }
	}

	public class PriceSchedule : OrderCloudModel
	{
		/// <summary>ID of the price schedule. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the price schedule. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Apply tax of the price schedule. Searchable: priority level 3.</summary>
		public bool ApplyTax { get => GetProp<bool>("ApplyTax"); set => SetProp<bool>("ApplyTax", value); }
		/// <summary>Apply shipping of the price schedule.</summary>
		public bool ApplyShipping { get => GetProp<bool>("ApplyShipping"); set => SetProp<bool>("ApplyShipping", value); }
		/// <summary>Min quantity of the price schedule. Must be at least 1.</summary>
		public int? MinQuantity { get => GetProp<int?>("MinQuantity", 1); set => SetProp<int?>("MinQuantity", value); }
		/// <summary>Max quantity of the price schedule.</summary>
		public int? MaxQuantity { get => GetProp<int?>("MaxQuantity"); set => SetProp<int?>("MaxQuantity", value); }
		/// <summary>If true, LineItem quantities will be aggregated by productID when determining which price break applies. Else, each LineItem is treated separately.</summary>
		public bool UseCumulativeQuantity { get => GetProp<bool>("UseCumulativeQuantity"); set => SetProp<bool>("UseCumulativeQuantity", value); }
		/// <summary>If true, this product can only be ordered in quantities that exactly match one of the price breaks on this schedule.</summary>
		public bool RestrictedQuantity { get => GetProp<bool>("RestrictedQuantity"); set => SetProp<bool>("RestrictedQuantity", value); }
		/// <summary>Price breaks of the price schedule.</summary>
		public IList<PriceBreak> PriceBreaks { get => GetProp<IList<PriceBreak>>("PriceBreaks", new List<PriceBreak>()); set => SetProp<IList<PriceBreak>>("PriceBreaks", value); }
		/// <summary>Container for extended (custom) properties of the price schedule.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the PriceSchedule.</typeparam>
	public class PriceSchedule<Txp> : PriceSchedule
	{
		public new Txp xp { get; set; }
	}

	public class Product : OrderCloudModel
	{
		/// <summary>ID of the Seller or Supplier org that created the Product.</summary>
		[ApiReadOnly]
		public string OwnerID { get; set; }
		/// <summary>ID of the default price schedule.</summary>
		public string DefaultPriceScheduleID { get => GetProp<string>("DefaultPriceScheduleID"); set => SetProp<string>("DefaultPriceScheduleID", value); }
		/// <summary>If true, when this product is ordered by a Buyer, it will automatically be added to a new Order from the Seller to the Default Supplier and submitted. Requires a valid DefaultSupplierID.</summary>
		public bool AutoForward { get => GetProp<bool>("AutoForward"); set => SetProp<bool>("AutoForward", value); }
		/// <summary>ID of the product. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the product. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the product. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Quantity multiplier of the product. Required. Must be at least 1.</summary>
		[Required]
		public int QuantityMultiplier { get => GetProp<int>("QuantityMultiplier", 1); set => SetProp<int>("QuantityMultiplier", value); }
		/// <summary>Ship weight of the product.</summary>
		public decimal? ShipWeight { get => GetProp<decimal?>("ShipWeight"); set => SetProp<decimal?>("ShipWeight", value); }
		/// <summary>Ship height of the product.</summary>
		public decimal? ShipHeight { get => GetProp<decimal?>("ShipHeight"); set => SetProp<decimal?>("ShipHeight", value); }
		/// <summary>Ship width of the product.</summary>
		public decimal? ShipWidth { get => GetProp<decimal?>("ShipWidth"); set => SetProp<decimal?>("ShipWidth", value); }
		/// <summary>Ship length of the product.</summary>
		public decimal? ShipLength { get => GetProp<decimal?>("ShipLength"); set => SetProp<decimal?>("ShipLength", value); }
		/// <summary>Active of the product.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Spec count of the product.</summary>
		[ApiReadOnly]
		public int SpecCount { get; set; }
		/// <summary>Variant count of the product.</summary>
		[ApiReadOnly]
		public int VariantCount { get; set; }
		/// <summary>ID of the ship from address.</summary>
		public string ShipFromAddressID { get => GetProp<string>("ShipFromAddressID"); set => SetProp<string>("ShipFromAddressID", value); }
		/// <summary>Inventory of the product.</summary>
		public Inventory Inventory { get => GetProp<Inventory>("Inventory"); set => SetProp<Inventory>("Inventory", value); }
		/// <summary>ID of the default supplier.</summary>
		public string DefaultSupplierID { get => GetProp<string>("DefaultSupplierID"); set => SetProp<string>("DefaultSupplierID", value); }
		/// <summary>Container for extended (custom) properties of the product.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Product.</typeparam>
	public class Product<Txp> : Product
	{
		public new Txp xp { get; set; }
	}

	public class ProductAssignment : OrderCloudModel
	{
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
		[Required]
		public int MinCount { get => GetProp<int>("MinCount", 1); set => SetProp<int>("MinCount", value); }
		/// <summary>Container for extended (custom) properties of the product facet.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the ProductFacet.</typeparam>
	public class ProductFacet<Txp> : ProductFacet
	{
		public new Txp xp { get; set; }
	}

	public class Promotion : OrderCloudModel
	{
		/// <summary>ID of the promotion. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Must be unique. Entered by buyer when adding promo to order.</summary>
		[Required]
		public string Code { get => GetProp<string>("Code"); set => SetProp<string>("Code", value); }
		/// <summary>Name of the promotion. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Redemption limit of the promotion.</summary>
		public int? RedemptionLimit { get => GetProp<int?>("RedemptionLimit"); set => SetProp<int?>("RedemptionLimit", value); }
		/// <summary>Redemption limit per user of the promotion.</summary>
		public int? RedemptionLimitPerUser { get => GetProp<int?>("RedemptionLimitPerUser"); set => SetProp<int?>("RedemptionLimitPerUser", value); }
		/// <summary>Redemption count of the promotion.</summary>
		[ApiReadOnly]
		public int RedemptionCount { get; set; }
		/// <summary>Description of the promotion. Max length 2000 characters. Searchable: priority level 4.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Terms, conditions, and other legal jargon.</summary>
		public string FinePrint { get => GetProp<string>("FinePrint"); set => SetProp<string>("FinePrint", value); }
		/// <summary>Start date of the promotion. Sortable.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>Expiration date of the promotion. Sortable.</summary>
		public DateTimeOffset? ExpirationDate { get => GetProp<DateTimeOffset?>("ExpirationDate"); set => SetProp<DateTimeOffset?>("ExpirationDate", value); }
		/// <summary>Eligible expression of the promotion. Required. Max length 400 characters. Searchable: priority level 6. Sortable.</summary>
		[Required]
		public string EligibleExpression { get => GetProp<string>("EligibleExpression"); set => SetProp<string>("EligibleExpression", value); }
		/// <summary>Value expression of the promotion. Required. Max length 400 characters. Searchable: priority level 7. Sortable.</summary>
		[Required]
		public string ValueExpression { get => GetProp<string>("ValueExpression"); set => SetProp<string>("ValueExpression", value); }
		/// <summary>Can combine of the promotion. Sortable.</summary>
		public bool CanCombine { get => GetProp<bool>("CanCombine"); set => SetProp<bool>("CanCombine", value); }
		/// <summary>Allow promo to be used by all buyers without creating assignments.</summary>
		public bool AllowAllBuyers { get => GetProp<bool>("AllowAllBuyers"); set => SetProp<bool>("AllowAllBuyers", value); }
		/// <summary>Container for extended (custom) properties of the promotion.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Promotion.</typeparam>
	public class Promotion<Txp> : Promotion
	{
		public new Txp xp { get; set; }
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
		/// <summary>Password config of the security profile.</summary>
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

	public class Shipment : OrderCloudModel
	{
		/// <summary>ID of the shipment. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>ID of the buyer. Searchable: priority level 1. Sortable.</summary>
		public string BuyerID { get => GetProp<string>("BuyerID"); set => SetProp<string>("BuyerID", value); }
		/// <summary>Shipper of the shipment. Searchable: priority level 2. Sortable.</summary>
		public string Shipper { get => GetProp<string>("Shipper"); set => SetProp<string>("Shipper", value); }
		/// <summary>Date shipped of the shipment. Searchable: priority level 3. Sortable: priority level 1.</summary>
		public DateTimeOffset? DateShipped { get => GetProp<DateTimeOffset?>("DateShipped"); set => SetProp<DateTimeOffset?>("DateShipped", value); }
		/// <summary>Date delivered of the shipment. Searchable: priority level 4. Sortable.</summary>
		public DateTimeOffset? DateDelivered { get => GetProp<DateTimeOffset?>("DateDelivered"); set => SetProp<DateTimeOffset?>("DateDelivered", value); }
		/// <summary>Tracking number of the shipment. Max length 3000 characters. Searchable: priority level 4.</summary>
		public string TrackingNumber { get => GetProp<string>("TrackingNumber"); set => SetProp<string>("TrackingNumber", value); }
		/// <summary>Cost of the shipment. Sortable.</summary>
		public decimal? Cost { get => GetProp<decimal?>("Cost"); set => SetProp<decimal?>("Cost", value); }
		/// <summary>Container for extended (custom) properties of the shipment.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Account of the shipment.</summary>
		public string Account { get => GetProp<string>("Account"); set => SetProp<string>("Account", value); }
		/// <summary>ID of the from address.</summary>
		public string FromAddressID { get => GetProp<string>("FromAddressID"); set => SetProp<string>("FromAddressID", value); }
		/// <summary>ID of the to address.</summary>
		public string ToAddressID { get => GetProp<string>("ToAddressID"); set => SetProp<string>("ToAddressID", value); }
		/// <summary>From address of the shipment.</summary>
		[ApiReadOnly]
		public Address FromAddress { get; set; }
		/// <summary>To address of the shipment.</summary>
		[ApiReadOnly]
		public Address ToAddress { get; set; }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Shipment.</typeparam>
	/// <typeparam name="TFromAddressXP">Type used as a container for xp of the nested FromAddress. If weakly typed or unneeded, specify dynamic.</typeparam>
	/// <typeparam name="TToAddressXP">Type used as a container for xp of the nested ToAddress. If weakly typed or unneeded, specify dynamic.</typeparam>
	public class Shipment<Txp, TFromAddressXP, TToAddressXP> : Shipment
	{
		public new Txp xp { get; set; }
		public new Address<TFromAddressXP> FromAddress { get; set; }
		public new Address<TToAddressXP> ToAddress { get; set; }
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
		public decimal? UnitPrice { get; set; }
		/// <summary>Cost center of the shipment item.</summary>
		[ApiReadOnly]
		public string CostCenter { get; set; }
		/// <summary>Date needed of the shipment item.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateNeeded { get; set; }
		/// <summary>Product of the shipment item.</summary>
		[ApiReadOnly]
		public LineItemProduct Product { get; set; }
		/// <summary>Variant of the shipment item.</summary>
		[ApiReadOnly]
		public LineItemVariant Variant { get; set; }
		/// <summary>Specs of the shipment item.</summary>
		[ApiReadOnly]
		public IReadOnlyList<LineItemSpec> Specs { get; set; }
		/// <summary>Container for extended (custom) properties of the shipment item.</summary>
		[ApiReadOnly]
		public dynamic xp { get; set; } = new ExpandoObject();
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the ShipmentItem.</typeparam>
	/// <typeparam name="TProductXP">Type used as a container for xp of the nested Product. If weakly typed or unneeded, specify dynamic.</typeparam>
	/// <typeparam name="TVariantXP">Type used as a container for xp of the nested Variant. If weakly typed or unneeded, specify dynamic.</typeparam>
	public class ShipmentItem<Txp, TProductXP, TVariantXP> : ShipmentItem
	{
		public new Txp xp { get; set; }
		public new LineItemProduct<TProductXP> Product { get; set; }
		public new LineItemVariant<TVariantXP> Variant { get; set; }
	}

	public class Spec : OrderCloudModel
	{
		/// <summary>ID of the spec. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 3. Sortable: priority level 3.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>List order of the spec. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public int ListOrder { get => GetProp<int>("ListOrder"); set => SetProp<int>("ListOrder", value); }
		/// <summary>Name of the spec. Required. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Default value of the spec. Max length 2000 characters.</summary>
		public string DefaultValue { get => GetProp<string>("DefaultValue"); set => SetProp<string>("DefaultValue", value); }
		/// <summary>Required of the spec. Searchable: priority level 4.</summary>
		public bool Required { get => GetProp<bool>("Required"); set => SetProp<bool>("Required", value); }
		/// <summary>Allow open text of the spec. Searchable: priority level 5.</summary>
		public bool AllowOpenText { get => GetProp<bool>("AllowOpenText"); set => SetProp<bool>("AllowOpenText", value); }
		/// <summary>ID of the default option.</summary>
		public string DefaultOptionID { get => GetProp<string>("DefaultOptionID"); set => SetProp<string>("DefaultOptionID", value); }
		/// <summary>True if each unique combinations of this Spec's Options map to unique Product Variants/SKUs.</summary>
		public bool DefinesVariant { get => GetProp<bool>("DefinesVariant"); set => SetProp<bool>("DefinesVariant", value); }
		/// <summary>Container for extended (custom) properties of the spec.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Option count of the spec.</summary>
		[ApiReadOnly]
		public int OptionCount { get; set; }
		/// <summary>Options of the spec.</summary>
		[ApiReadOnly]
		public IReadOnlyList<SpecOption> Options { get; set; }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Spec.</typeparam>
	public class Spec<Txp> : Spec
	{
		public new Txp xp { get; set; }
	}

	public class SpecOption : OrderCloudModel
	{
		/// <summary>ID of the spec option. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Value of the spec option. Required. Max length 2000 characters. Searchable: priority level 1.</summary>
		[Required]
		public string Value { get => GetProp<string>("Value"); set => SetProp<string>("Value", value); }
		/// <summary>List order of the spec option. Searchable: priority level 4. Sortable: priority level 1.</summary>
		public int ListOrder { get => GetProp<int>("ListOrder"); set => SetProp<int>("ListOrder", value); }
		/// <summary>Is open text of the spec option. Searchable: priority level 3.</summary>
		public bool IsOpenText { get => GetProp<bool>("IsOpenText"); set => SetProp<bool>("IsOpenText", value); }
		/// <summary>Price markup type of the spec option. Searchable: priority level 5. Possible values: NoMarkup, AmountPerQuantity, AmountTotal, Percentage.</summary>
		public PriceMarkupType? PriceMarkupType { get => GetProp<PriceMarkupType?>("PriceMarkupType"); set => SetProp<PriceMarkupType?>("PriceMarkupType", value); }
		/// <summary>Price markup of the spec option. Searchable: priority level 6.</summary>
		public decimal? PriceMarkup { get => GetProp<decimal?>("PriceMarkup"); set => SetProp<decimal?>("PriceMarkup", value); }
		/// <summary>Container for extended (custom) properties of the spec option.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the SpecOption.</typeparam>
	public class SpecOption<Txp> : SpecOption
	{
		public new Txp xp { get; set; }
	}

	public class SpecProductAssignment : OrderCloudModel
	{
		/// <summary>ID of the spec. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string SpecID { get => GetProp<string>("SpecID"); set => SetProp<string>("SpecID", value); }
		/// <summary>ID of the product. Searchable: priority level 2. Sortable: priority level 2.</summary>
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
		/// <summary>Allow as payment method of the spending account.</summary>
		public bool AllowAsPaymentMethod { get => GetProp<bool>("AllowAsPaymentMethod"); set => SetProp<bool>("AllowAsPaymentMethod", value); }
		/// <summary>If specified, matching code must be provided on redemption in order for the transaction to be successful. Most commonly used to implement Gift Cards.</summary>
		public string RedemptionCode { get => GetProp<string>("RedemptionCode"); set => SetProp<string>("RedemptionCode", value); }
		/// <summary>Start date of the spending account.</summary>
		public DateTimeOffset? StartDate { get => GetProp<DateTimeOffset?>("StartDate"); set => SetProp<DateTimeOffset?>("StartDate", value); }
		/// <summary>End date of the spending account.</summary>
		public DateTimeOffset? EndDate { get => GetProp<DateTimeOffset?>("EndDate"); set => SetProp<DateTimeOffset?>("EndDate", value); }
		/// <summary>Container for extended (custom) properties of the spending account.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the SpendingAccount.</typeparam>
	public class SpendingAccount<Txp> : SpendingAccount
	{
		public new Txp xp { get; set; }
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
		/// <summary>Allow exceed of the spending account assignment.</summary>
		public bool AllowExceed { get => GetProp<bool>("AllowExceed"); set => SetProp<bool>("AllowExceed", value); }
	}

	public class Supplier : OrderCloudModel
	{
		/// <summary>ID of the supplier. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 2. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the supplier. Required. Max length 100 characters. Searchable: priority level 1. Sortable: priority level 2.</summary>
		[Required]
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Active of the supplier.</summary>
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Container for extended (custom) properties of the supplier.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Supplier.</typeparam>
	public class Supplier<Txp> : Supplier
	{
		public new Txp xp { get; set; }
	}

	public class TokenPasswordReset : OrderCloudModel
	{
		/// <summary>New password of the token password reset. Required.</summary>
		[Required]
		public string NewPassword { get => GetProp<string>("NewPassword"); set => SetProp<string>("NewPassword", value); }
	}

	public class User : OrderCloudModel
	{
		/// <summary>ID of the user. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Username of the user. Required. Max length 100 characters. Searchable: priority level 2. Sortable: priority level 3.</summary>
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
		/// <summary>Active of the user. Required.</summary>
		[Required]
		public bool Active { get => GetProp<bool>("Active"); set => SetProp<bool>("Active", value); }
		/// <summary>Container for extended (custom) properties of the user.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
		/// <summary>Available roles of the user.</summary>
		[ApiReadOnly]
		public IReadOnlyList<string> AvailableRoles { get; set; }
		/// <summary>Date created of the user. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? DateCreated { get; set; }
		/// <summary>Password last set date of the user. Sortable.</summary>
		[ApiReadOnly]
		public DateTimeOffset? PasswordLastSetDate { get; set; }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the User.</typeparam>
	public class User<Txp> : User
	{
		public new Txp xp { get; set; }
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

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the UserGroup.</typeparam>
	public class UserGroup<Txp> : UserGroup
	{
		public new Txp xp { get; set; }
	}

	public class UserGroupAssignment : OrderCloudModel
	{
		/// <summary>ID of the user group.</summary>
		public string UserGroupID { get => GetProp<string>("UserGroupID"); set => SetProp<string>("UserGroupID", value); }
		/// <summary>ID of the user.</summary>
		public string UserID { get => GetProp<string>("UserID"); set => SetProp<string>("UserID", value); }
	}

	public class Variant : OrderCloudModel
	{
		/// <summary>ID of the variant. Can only contain characters Aa-Zz, 0-9, -, and _. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string ID { get => GetProp<string>("ID"); set => SetProp<string>("ID", value); }
		/// <summary>Name of the variant. Searchable: priority level 2. Sortable: priority level 2.</summary>
		public string Name { get => GetProp<string>("Name"); set => SetProp<string>("Name", value); }
		/// <summary>Description of the variant. Max length 2000 characters. Searchable: priority level 3.</summary>
		public string Description { get => GetProp<string>("Description"); set => SetProp<string>("Description", value); }
		/// <summary>Active of the variant.</summary>
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
		/// <summary>Container for extended (custom) properties of the variant.</summary>
		public dynamic xp { get => GetProp<dynamic>("xp", new ExpandoObject()); set => SetProp<dynamic>("xp", value); }
	}

	/// <typeparam name="Txp">Type used as a container for extended properties (xp) of the Variant.</typeparam>
	public class Variant<Txp> : Variant
	{
		public new Txp xp { get; set; }
	}

	public class VariantInventory : OrderCloudModel
	{
		/// <summary>Quantity available of the variant inventory.</summary>
		public int? QuantityAvailable { get => GetProp<int?>("QuantityAvailable"); set => SetProp<int?>("QuantityAvailable", value); }
		/// <summary>Last updated of the variant inventory.</summary>
		[ApiReadOnly]
		public DateTimeOffset LastUpdated { get; set; }
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
		/// <summary>Url of the webhook. Required. Searchable: priority level 4.</summary>
		[Required]
		public string Url { get => GetProp<string>("Url"); set => SetProp<string>("Url", value); }
		/// <summary>Hash key of the webhook. Required.</summary>
		[Required]
		public string HashKey { get => GetProp<string>("HashKey"); set => SetProp<string>("HashKey", value); }
		/// <summary>Elevated roles of the webhook.</summary>
		public IList<ApiRole> ElevatedRoles { get => GetProp<IList<ApiRole>>("ElevatedRoles", new List<ApiRole>()); set => SetProp<IList<ApiRole>>("ElevatedRoles", value); }
		/// <summary>Config data of the webhook.</summary>
		public object ConfigData { get => GetProp<object>("ConfigData"); set => SetProp<object>("ConfigData", value); }
		/// <summary>Before process request of the webhook.</summary>
		public bool BeforeProcessRequest { get => GetProp<bool>("BeforeProcessRequest"); set => SetProp<bool>("BeforeProcessRequest", value); }
		/// <summary>Api client I ds of the webhook.</summary>
		public IList<string> ApiClientIDs { get => GetProp<IList<string>>("ApiClientIDs", new List<string>()); set => SetProp<IList<string>>("ApiClientIDs", value); }
		/// <summary>Webhook routes of the webhook.</summary>
		public IList<WebhookRoute> WebhookRoutes { get => GetProp<IList<WebhookRoute>>("WebhookRoutes", new List<WebhookRoute>()); set => SetProp<IList<WebhookRoute>>("WebhookRoutes", value); }
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
		/// <summary>Thing type of the xp index. Searchable: priority level 0. Sortable: priority level 0. Possible values: Product, Variant, Order, LineItem, Address, CostCenter, CreditCard, Payment, Spec, SpecOption, UserGroup, Company, Category, PriceSchedule, Shipment, SpendingAccount, User, Promotion, ApprovalRule, Catalog, ProductFacet, MessageSender.</summary>
		public XpThingType ThingType { get => GetProp<XpThingType>("ThingType"); set => SetProp<XpThingType>("ThingType", value); }
		/// <summary>Key of the xp index. Searchable: priority level 1. Sortable: priority level 1.</summary>
		public string Key { get => GetProp<string>("Key"); set => SetProp<string>("Key", value); }
	}
	public class PartialAddress : Address, IPartial { }
	public class PartialAddress<Txp> : PartialAddress { }
	public class PartialApiClient : ApiClient, IPartial { }
	public class PartialApiClient<Txp> : PartialApiClient { }
	public class PartialApprovalRule : ApprovalRule, IPartial { }
	public class PartialApprovalRule<Txp> : PartialApprovalRule { }
	public class PartialBuyer : Buyer, IPartial { }
	public class PartialBuyer<Txp> : PartialBuyer { }
	public class PartialBuyerAddress : BuyerAddress, IPartial { }
	public class PartialBuyerAddress<Txp> : PartialBuyerAddress { }
	public class PartialBuyerCreditCard : BuyerCreditCard, IPartial { }
	public class PartialBuyerCreditCard<Txp> : PartialBuyerCreditCard { }
	public class PartialCatalog : Catalog, IPartial { }
	public class PartialCatalog<Txp> : PartialCatalog { }
	public class PartialCategory : Category, IPartial { }
	public class PartialCategory<Txp> : PartialCategory { }
	public class PartialCostCenter : CostCenter, IPartial { }
	public class PartialCostCenter<Txp> : PartialCostCenter { }
	public class PartialCreditCard : CreditCard, IPartial { }
	public class PartialCreditCard<Txp> : PartialCreditCard { }
	public class PartialImpersonationConfig : ImpersonationConfig, IPartial { }
	public class PartialIncrementor : Incrementor, IPartial { }
	public class PartialInventory : Inventory, IPartial { }
	public class PartialLineItem : LineItem, IPartial { }
	public class PartialLineItem<Txp, TProductXP, TVariantXP, TShippingAddressXP, TShipFromAddressXP> : PartialLineItem { }
	public class PartialLineItemProduct : LineItemProduct, IPartial { }
	public class PartialLineItemProduct<Txp> : PartialLineItemProduct { }
	public class PartialLineItemSpec : LineItemSpec, IPartial { }
	public class PartialLineItemVariant : LineItemVariant, IPartial { }
	public class PartialLineItemVariant<Txp> : PartialLineItemVariant { }
	public class PartialMeBuyer : MeBuyer, IPartial { }
	public class PartialMessageSender : MessageSender, IPartial { }
	public class PartialMessageSender<Txp> : PartialMessageSender { }
	public class PartialMeSupplier : MeSupplier, IPartial { }
	public class PartialMeUser : MeUser, IPartial { }
	public class PartialMeUser<Txp> : PartialMeUser { }
	public class PartialOpenIdConnect : OpenIdConnect, IPartial { }
	public class PartialOrder : Order, IPartial { }
	public class PartialOrder<Txp, TFromUserXP, TBillingAddressXP> : PartialOrder { }
	public class PartialPasswordConfig : PasswordConfig, IPartial { }
	public class PartialPayment : Payment, IPartial { }
	public class PartialPayment<Txp> : PartialPayment { }
	public class PartialPaymentTransaction : PaymentTransaction, IPartial { }
	public class PartialPaymentTransaction<Txp> : PartialPaymentTransaction { }
	public class PartialPriceBreak : PriceBreak, IPartial { }
	public class PartialPriceSchedule : PriceSchedule, IPartial { }
	public class PartialPriceSchedule<Txp> : PartialPriceSchedule { }
	public class PartialProduct : Product, IPartial { }
	public class PartialProduct<Txp> : PartialProduct { }
	public class PartialProductFacet : ProductFacet, IPartial { }
	public class PartialProductFacet<Txp> : PartialProductFacet { }
	public class PartialPromotion : Promotion, IPartial { }
	public class PartialPromotion<Txp> : PartialPromotion { }
	public class PartialSecurityProfile : SecurityProfile, IPartial { }
	public class PartialShipment : Shipment, IPartial { }
	public class PartialShipment<Txp, TFromAddressXP, TToAddressXP> : PartialShipment { }
	public class PartialSpec : Spec, IPartial { }
	public class PartialSpec<Txp> : PartialSpec { }
	public class PartialSpecOption : SpecOption, IPartial { }
	public class PartialSpecOption<Txp> : PartialSpecOption { }
	public class PartialSpendingAccount : SpendingAccount, IPartial { }
	public class PartialSpendingAccount<Txp> : PartialSpendingAccount { }
	public class PartialSupplier : Supplier, IPartial { }
	public class PartialSupplier<Txp> : PartialSupplier { }
	public class PartialUser : User, IPartial { }
	public class PartialUser<Txp> : PartialUser { }
	public class PartialUserGroup : UserGroup, IPartial { }
	public class PartialUserGroup<Txp> : PartialUserGroup { }
	public class PartialVariant : Variant, IPartial { }
	public class PartialVariant<Txp> : PartialVariant { }
	public class PartialVariantInventory : VariantInventory, IPartial { }
	public class PartialWebhook : Webhook, IPartial { }
	public class PartialWebhookRoute : WebhookRoute, IPartial { }
}
