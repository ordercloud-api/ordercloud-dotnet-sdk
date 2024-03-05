using System;
using System.Threading.Tasks;
using Flurl.Http;

namespace OrderCloud.SDK
{
	public partial interface IOrderCloudClient
	{
		IAddressesResource Addresses { get; }
		IAdminAddressesResource AdminAddresses { get; }
		IAdminUserGroupsResource AdminUserGroups { get; }
		IAdminUsersResource AdminUsers { get; }
		IApiClientsResource ApiClients { get; }
		IApprovalRulesResource ApprovalRules { get; }
		IBundleLineItemsResource BundleLineItems { get; }
		IBundlesResource Bundles { get; }
		IBundleSubscriptionItemsResource BundleSubscriptionItems { get; }
		IBuyersResource Buyers { get; }
		ICartResource Cart { get; }
		ICatalogsResource Catalogs { get; }
		ICategoriesResource Categories { get; }
		ICertsResource Certs { get; }
		ICostCentersResource CostCenters { get; }
		ICreditCardsResource CreditCards { get; }
		IDeliveryConfigurationsResource DeliveryConfigurations { get; }
		IErrorConfigsResource ErrorConfigs { get; }
		IForgottenCredentialsResource ForgottenCredentials { get; }
		IImpersonationConfigsResource ImpersonationConfigs { get; }
		IIncrementorsResource Incrementors { get; }
		IIntegrationEventsResource IntegrationEvents { get; }
		IInventoryRecordsResource InventoryRecords { get; }
		ILineItemsResource LineItems { get; }
		ILocalesResource Locales { get; }
		IMeResource Me { get; }
		IMessageSendersResource MessageSenders { get; }
		IOpenIdConnectsResource OpenIdConnects { get; }
		IOrderReturnsResource OrderReturns { get; }
		IOrdersResource Orders { get; }
		IOrderSyncsResource OrderSyncs { get; }
		IPaymentsResource Payments { get; }
		IPriceSchedulesResource PriceSchedules { get; }
		IProductCollectionsResource ProductCollections { get; }
		IProductFacetsResource ProductFacets { get; }
		IProductsResource Products { get; }
		IProductSyncsResource ProductSyncs { get; }
		IPromotionsResource Promotions { get; }
		ISecurityProfilesResource SecurityProfiles { get; }
		ISellerApprovalRulesResource SellerApprovalRules { get; }
		IShipmentsResource Shipments { get; }
		ISpecsResource Specs { get; }
		ISpendingAccountsResource SpendingAccounts { get; }
		ISubscriptionIntegrationsResource SubscriptionIntegrations { get; }
		ISubscriptionItemsResource SubscriptionItems { get; }
		ISubscriptionsResource Subscriptions { get; }
		ISupplierAddressesResource SupplierAddresses { get; }
		ISuppliersResource Suppliers { get; }
		ISupplierUserGroupsResource SupplierUserGroups { get; }
		ISupplierUsersResource SupplierUsers { get; }
		ITrackingEventsResource TrackingEvents { get; }
		IUserGroupsResource UserGroups { get; }
		IUsersResource Users { get; }
		IWebhooksResource Webhooks { get; }
		IXpIndicesResource XpIndices { get; }
	}

	public interface IAddressesResource
	{
		/// <summary>Get a single address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> GetAsync(string buyerID, string addressID, string accessToken = null);
		/// <summary>Get a single address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> GetAsync<TAddress>(string buyerID, string addressID, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TAddress>> ListAsync<TAddress>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string buyerID, Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TAddress>> ListAsync<TAddress>(string buyerID, Action<ListOptionsBuilder<TAddress>> buildListOpts, string accessToken = null) where TAddress : Address;
		/// <summary>Create a new address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> CreateAsync(string buyerID, Address address, string accessToken = null);
		/// <summary>Create a new address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> CreateAsync<TAddress>(string buyerID, Address address, string accessToken = null) where TAddress : Address;
		/// <summary>Create or update an address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> SaveAsync(string buyerID, string addressID, Address address, string accessToken = null);
		/// <summary>Create or update an address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> SaveAsync<TAddress>(string buyerID, string addressID, Address address, string accessToken = null) where TAddress : Address;
		/// <summary>Delete an address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string addressID, string accessToken = null);
		/// <summary>Partially update an address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> PatchAsync(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update an address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> PatchAsync<TAddress>(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of address assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the address assignment. Possible values: User, Group, Company.</param>
		/// <param name="isShipping">Is shipping of the address assignment.</param>
		/// <param name="isBilling">Is billing of the address assignment.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<AddressAssignment>> ListAssignmentsAsync(string buyerID, string addressID = null, string userID = null, string userGroupID = null, PartyType? level = null, bool? isShipping = null, bool? isBilling = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete an address assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string buyerID, string addressID, string userID = null, string userGroupID = null, string accessToken = null);
		/// <summary>Create or update an address assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(string buyerID, AddressAssignment addressAssignment, string accessToken = null);
	}

	public interface IAdminAddressesResource
	{
		/// <summary>Get a single admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> GetAsync(string addressID, string accessToken = null);
		/// <summary>Get a single admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> GetAsync<TAddress>(string addressID, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TAddress>> ListAsync<TAddress>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TAddress>> ListAsync<TAddress>(Action<ListOptionsBuilder<TAddress>> buildListOpts, string accessToken = null) where TAddress : Address;
		/// <summary>Create a new admin address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> CreateAsync(Address address, string accessToken = null);
		/// <summary>Create a new admin address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> CreateAsync<TAddress>(Address address, string accessToken = null) where TAddress : Address;
		/// <summary>Create or update an admin address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> SaveAsync(string addressID, Address address, string accessToken = null);
		/// <summary>Create or update an admin address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> SaveAsync<TAddress>(string addressID, Address address, string accessToken = null) where TAddress : Address;
		/// <summary>Delete an admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string addressID, string accessToken = null);
		/// <summary>Partially update an admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> PatchAsync(string addressID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update an admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> PatchAsync<TAddress>(string addressID, PartialAddress partialAddress, string accessToken = null) where TAddress : Address;
	}

	public interface IAdminUserGroupsResource
	{
		/// <summary>Get a single admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> GetAsync(string userGroupID, string accessToken = null);
		/// <summary>Get a single admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> GetAsync<TUserGroup>(string userGroupID, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Create a new admin user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> CreateAsync(UserGroup userGroup, string accessToken = null);
		/// <summary>Create a new admin user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> CreateAsync<TUserGroup>(UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Create or update an admin user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> SaveAsync(string userGroupID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update an admin user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> SaveAsync<TUserGroup>(string userGroupID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Delete an admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string userGroupID, string accessToken = null);
		/// <summary>Partially update an admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> PatchAsync(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null);
		/// <summary>Partially update an admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> PatchAsync<TUserGroup>(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of admin user group user assignments.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Delete an admin user group user assignment.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteUserAssignmentAsync(string userGroupID, string userID, string accessToken = null);
		/// <summary>Create or update an admin user group user assignment.</summary>
		/// <param name="userGroupAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveUserAssignmentAsync(UserGroupAssignment userGroupAssignment, string accessToken = null);
	}

	public interface IAdminUsersResource
	{
		/// <summary>Get a single admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> GetAsync(string userID, string accessToken = null);
		/// <summary>Get a single admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> GetAsync<TUser>(string userID, string accessToken = null) where TUser : User;
		/// <summary>Get a list of admin users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAsync<TUser>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User;
		/// <summary>Get a list of admin users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of admin users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAsync<TUser>(Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User;
		/// <summary>Create a new admin user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> CreateAsync(User user, string accessToken = null);
		/// <summary>Create a new admin user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> CreateAsync<TUser>(User user, string accessToken = null) where TUser : User;
		/// <summary>Create or update an admin user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> SaveAsync(string userID, User user, string accessToken = null);
		/// <summary>Create or update an admin user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> SaveAsync<TUser>(string userID, User user, string accessToken = null) where TUser : User;
		/// <summary>Delete an admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string userID, string accessToken = null);
		/// <summary>Partially update an admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> PatchAsync(string userID, PartialUser partialUser, string accessToken = null);
		/// <summary>Partially update an admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> PatchAsync<TUser>(string userID, PartialUser partialUser, string accessToken = null) where TUser : User;
	}

	public interface IApiClientsResource
	{
		/// <summary>Get a single API client.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApiClient> GetAsync(string apiClientID, string accessToken = null);
		/// <summary>Get a single API client.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApiClient> GetAsync<TApiClient>(string apiClientID, string accessToken = null) where TApiClient : ApiClient;
		/// <summary>Get a list of API clients.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApiClient>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of API clients.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TApiClient>> ListAsync<TApiClient>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TApiClient : ApiClient;
		/// <summary>Get a list of API clients.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApiClient>> ListAsync(Action<ListOptionsBuilder<ApiClient>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of API clients.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TApiClient>> ListAsync<TApiClient>(Action<ListOptionsBuilder<TApiClient>> buildListOpts, string accessToken = null) where TApiClient : ApiClient;
		/// <summary>Create a new API client. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="apiClient">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApiClient> CreateAsync(ApiClient apiClient, string accessToken = null);
		/// <summary>Create a new API client. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="apiClient">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApiClient> CreateAsync<TApiClient>(ApiClient apiClient, string accessToken = null) where TApiClient : ApiClient;
		/// <summary>Update an API client. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="apiClient">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApiClient> SaveAsync(string apiClientID, ApiClient apiClient, string accessToken = null);
		/// <summary>Update an API client. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="apiClient">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApiClient> SaveAsync<TApiClient>(string apiClientID, ApiClient apiClient, string accessToken = null) where TApiClient : ApiClient;
		/// <summary>Delete a API client.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string apiClientID, string accessToken = null);
		/// <summary>Get a list of API client assignments.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApiClientAssignment>> ListAssignmentsAsync(string apiClientID = null, string buyerID = null, string supplierID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Partially update a API client.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="partialApiClient">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApiClient> PatchAsync(string apiClientID, PartialApiClient partialApiClient, string accessToken = null);
		/// <summary>Partially update a API client.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="partialApiClient">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApiClient> PatchAsync<TApiClient>(string apiClientID, PartialApiClient partialApiClient, string accessToken = null) where TApiClient : ApiClient;
		/// <summary>Create or update a API client assignment.</summary>
		/// <param name="apiClientAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(ApiClientAssignment apiClientAssignment, string accessToken = null);
		/// <summary>Delete a API client buyer assignment.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteBuyerAssignmentAsync(string apiClientID, string buyerID, string accessToken = null);
		/// <summary>Delete a API client supplier assignment.</summary>
		/// <param name="apiClientID">ID of the api client.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteSupplierAssignmentAsync(string apiClientID, string supplierID, string accessToken = null);
	}

	public interface IApprovalRulesResource
	{
		/// <summary>Get a single approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> GetAsync(string buyerID, string approvalRuleID, string accessToken = null);
		/// <summary>Get a single approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApprovalRule> GetAsync<TApprovalRule>(string buyerID, string approvalRuleID, string accessToken = null) where TApprovalRule : ApprovalRule;
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApprovalRule>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TApprovalRule>> ListAsync<TApprovalRule>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TApprovalRule : ApprovalRule;
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApprovalRule>> ListAsync(string buyerID, Action<ListOptionsBuilder<ApprovalRule>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TApprovalRule>> ListAsync<TApprovalRule>(string buyerID, Action<ListOptionsBuilder<TApprovalRule>> buildListOpts, string accessToken = null) where TApprovalRule : ApprovalRule;
		/// <summary>Create a new approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> CreateAsync(string buyerID, ApprovalRule approvalRule, string accessToken = null);
		/// <summary>Create a new approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApprovalRule> CreateAsync<TApprovalRule>(string buyerID, ApprovalRule approvalRule, string accessToken = null) where TApprovalRule : ApprovalRule;
		/// <summary>Create or update an approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> SaveAsync(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null);
		/// <summary>Create or update an approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApprovalRule> SaveAsync<TApprovalRule>(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null) where TApprovalRule : ApprovalRule;
		/// <summary>Delete an approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string approvalRuleID, string accessToken = null);
		/// <summary>Partially update an approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="partialApprovalRule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> PatchAsync(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null);
		/// <summary>Partially update an approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="partialApprovalRule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TApprovalRule> PatchAsync<TApprovalRule>(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null) where TApprovalRule : ApprovalRule;
	}

	public interface IBundleLineItemsResource
	{
		/// <summary>Create a new bundle line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateAsync(OrderDirection direction, string orderID, string bundleID, BundleItems bundleItems, string accessToken = null);
		/// <summary>Create a new bundle line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateAsync<TLineItem>(OrderDirection direction, string orderID, string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a bundle line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItemID">ID of the bundle item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string bundleID, string bundleItemID, string accessToken = null);
	}

	public interface IBundlesResource
	{
		/// <summary>Get a single bundle.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Bundle> GetAsync(string bundleID, string accessToken = null);
		/// <summary>Get a single bundle.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBundle> GetAsync<TBundle>(string bundleID, string accessToken = null) where TBundle : Bundle;
		/// <summary>Get a list of bundles.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<Bundle>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of bundles.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TBundle>> ListAsync<TBundle>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBundle : Bundle;
		/// <summary>Get a list of bundles.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<Bundle>> ListAsync(Action<ListOptionsBuilder2<Bundle>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null);
		/// <summary>Get a list of bundles.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TBundle>> ListAsync<TBundle>(Action<ListOptionsBuilder2<TBundle>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) where TBundle : Bundle;
		/// <summary>Create a new bundle. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="bundle">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Bundle> CreateAsync(Bundle bundle, string accessToken = null);
		/// <summary>Create a new bundle. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="bundle">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBundle> CreateAsync<TBundle>(Bundle bundle, string accessToken = null) where TBundle : Bundle;
		/// <summary>Create or update a bundle. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundle">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Bundle> SaveAsync(string bundleID, Bundle bundle, string accessToken = null);
		/// <summary>Create or update a bundle. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundle">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBundle> SaveAsync<TBundle>(string bundleID, Bundle bundle, string accessToken = null) where TBundle : Bundle;
		/// <summary>Delete a bundle.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string bundleID, string accessToken = null);
		/// <summary>Partially update a bundle.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="partialBundle">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Bundle> PatchAsync(string bundleID, PartialBundle partialBundle, string accessToken = null);
		/// <summary>Partially update a bundle.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="partialBundle">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBundle> PatchAsync<TBundle>(string bundleID, PartialBundle partialBundle, string accessToken = null) where TBundle : Bundle;
		/// <summary>Create or update a bundle product assignment.</summary>
		/// <param name="bundleProductAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveProductAssignmentAsync(BundleProductAssignment bundleProductAssignment, string accessToken = null);
		/// <summary>Get a list of bundle product assignments.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BundleProductAssignment>> ListProductAssignmentsAsync(string bundleID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Delete a bundle product assignment.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductAssignmentAsync(string bundleID, string productID, string accessToken = null);
		/// <summary>Get a list of bundle assignments.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the bundle assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BundleAssignment>> ListAssignmentsAsync(string bundleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update a bundle assignment.</summary>
		/// <param name="bundleAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(BundleAssignment bundleAssignment, string accessToken = null);
		/// <summary>Delete a bundle assignment.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string bundleID, string buyerID, string userID = null, string userGroupID = null, string sellerID = null, string accessToken = null);
	}

	public interface IBundleSubscriptionItemsResource
	{
		/// <summary>Create a new bundle subscription item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateAsync(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null);
		/// <summary>Create a new bundle subscription item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateAsync<TLineItem>(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a bundle subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItemID">ID of the bundle item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string subscriptionID, string bundleID, string bundleItemID, string accessToken = null);
	}

	public interface IBuyersResource
	{
		/// <summary>Get a single buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> GetAsync(string buyerID, string accessToken = null);
		/// <summary>Get a single buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyer> GetAsync<TBuyer>(string buyerID, string accessToken = null) where TBuyer : Buyer;
		/// <summary>Get a list of buyers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Buyer>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of buyers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TBuyer>> ListAsync<TBuyer>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyer : Buyer;
		/// <summary>Get a list of buyers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Buyer>> ListAsync(Action<ListOptionsBuilder<Buyer>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of buyers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TBuyer>> ListAsync<TBuyer>(Action<ListOptionsBuilder<TBuyer>> buildListOpts, string accessToken = null) where TBuyer : Buyer;
		/// <summary>Create a new buyer. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> CreateAsync(Buyer buyer, string accessToken = null);
		/// <summary>Create a new buyer. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyer> CreateAsync<TBuyer>(Buyer buyer, string accessToken = null) where TBuyer : Buyer;
		/// <summary>Delete a buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string accessToken = null);
		/// <summary>Create or update a buyer. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> SaveAsync(string buyerID, Buyer buyer, string accessToken = null);
		/// <summary>Create or update a buyer. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyer> SaveAsync<TBuyer>(string buyerID, Buyer buyer, string accessToken = null) where TBuyer : Buyer;
		/// <summary>Partially update a buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="partialBuyer">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> PatchAsync(string buyerID, PartialBuyer partialBuyer, string accessToken = null);
		/// <summary>Partially update a buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="partialBuyer">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyer> PatchAsync<TBuyer>(string buyerID, PartialBuyer partialBuyer, string accessToken = null) where TBuyer : Buyer;
		/// <summary>Get a list of buyer buyer sellers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of buyer buyer sellers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(string buyerID, Action<ListOptionsBuilder<BuyerSupplier>> buildListOpts, string accessToken = null);
	}

	public interface ICartResource
	{
		/// <summary>Get a single cart. If the ID of the Order returned is null, the cart has not yet been interacted with. Once an item is added, the Order.ID will be populated.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> GetAsync(string accessToken = null);
		/// <summary>Get a single cart. If the ID of the Order returned is null, the cart has not yet been interacted with. Once an item is added, the Order.ID will be populated.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> GetAsync<TOrder>(string accessToken = null) where TOrder : Order;
		/// <summary>Create or update a cart. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SaveAsync(Order order, string accessToken = null);
		/// <summary>Create or update a cart. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SaveAsync<TOrder>(Order order, string accessToken = null) where TOrder : Order;
		/// <summary>Delete a cart. Empties the cart. Any promotions, payments or other items associated with the cart will also be removed.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string accessToken = null);
		/// <summary>Set an active cart.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SetActiveCartAsync(string orderID, string accessToken = null);
		/// <summary>Partially update a cart.</summary>
		/// <param name="partialOrder">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchAsync(PartialOrder partialOrder, string accessToken = null);
		/// <summary>Partially update a cart.</summary>
		/// <param name="partialOrder">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchAsync<TOrder>(PartialOrder partialOrder, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of cart line items.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListLineItemsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cart line items.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListLineItemsAsync<TLineItem>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of cart line items.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListLineItemsAsync(Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cart line items.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListLineItemsAsync<TLineItem>(Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a single cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> GetLineItemAsync(string lineItemID, string accessToken = null);
		/// <summary>Get a single cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> GetLineItemAsync<TLineItem>(string lineItemID, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create a new cart line item. Adds a line item to the cart</summary>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateLineItemAsync(LineItem lineItem, string accessToken = null);
		/// <summary>Create a new cart line item. Adds a line item to the cart</summary>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateLineItemAsync<TLineItem>(LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create or update a cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SaveLineItemAsync(string lineItemID, LineItem lineItem, string accessToken = null);
		/// <summary>Create or update a cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> SaveLineItemAsync<TLineItem>(string lineItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Partially update a cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchLineItemAsync(string lineItemID, PartialLineItem partialLineItem, string accessToken = null);
		/// <summary>Partially update a cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> PatchLineItemAsync<TLineItem>(string lineItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a cart line item.</summary>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteLineItemAsync(string lineItemID, string accessToken = null);
		/// <summary>Create a new cart bundle item. Adds bundle line items to the cart</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateBundleItemAsync(string bundleID, BundleItems bundleItems, string accessToken = null);
		/// <summary>Create a new cart bundle item. Adds bundle line items to the cart</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateBundleItemAsync<TLineItem>(string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a cart bundle item.</summary>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItemID">ID of the bundle item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteBundleItemAsync(string bundleID, string bundleItemID, string accessToken = null);
		/// <summary>Get a list of cart promotions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cart promotions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderPromotion : OrderPromotion;
		/// <summary>Get a list of cart promotions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(Action<ListOptionsBuilder<OrderPromotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cart promotions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(Action<ListOptionsBuilder<TOrderPromotion>> buildListOpts, string accessToken = null) where TOrderPromotion : OrderPromotion;
		/// <summary>List eligible promotions. Get a list of promotions eligible for the cart.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListEligiblePromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>List eligible promotions. Get a list of promotions eligible for the cart.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion;
		/// <summary>List eligible promotions. Get a list of promotions eligible for the cart.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListEligiblePromotionsAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null);
		/// <summary>List eligible promotions. Get a list of promotions eligible for the cart.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Add a promotion.</summary>
		/// <param name="promoCode">Promo code of the order promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderPromotion> AddPromotionAsync(string promoCode, string accessToken = null);
		/// <summary>Add a promotion.</summary>
		/// <param name="promoCode">Promo code of the order promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderPromotion> AddPromotionAsync<TOrderPromotion>(string promoCode, string accessToken = null) where TOrderPromotion : OrderPromotion;
		/// <summary>Delete a cart promotion.</summary>
		/// <param name="promoCode">Promo code of the cart.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeletePromotionAsync(string promoCode, string accessToken = null);
		/// <summary>AutoApply eligible promotions. Apply up to 100 eligible promotions to the cart.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> ApplyPromotionsAsync(string accessToken = null);
		/// <summary>AutoApply eligible promotions. Apply up to 100 eligible promotions to the cart.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> ApplyPromotionsAsync<TOrder>(string accessToken = null) where TOrder : Order;
		/// <summary>Update cart FromUser. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchFromUserAsync(PartialUser partialUser, string accessToken = null);
		/// <summary>Update cart FromUser. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchFromUserAsync<TOrder>(PartialUser partialUser, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of cart payments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment>> ListPaymentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cart payments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPayment>> ListPaymentsAsync<TPayment>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPayment : Payment;
		/// <summary>Get a list of cart payments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment>> ListPaymentsAsync(Action<ListOptionsBuilder<Payment>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cart payments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPayment>> ListPaymentsAsync<TPayment>(Action<ListOptionsBuilder<TPayment>> buildListOpts, string accessToken = null) where TPayment : Payment;
		/// <summary>Get a single cart payment.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> GetPaymentAsync(string paymentID, string accessToken = null);
		/// <summary>Get a single cart payment.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> GetPaymentAsync<TPayment>(string paymentID, string accessToken = null) where TPayment : Payment;
		/// <summary>Create a new cart payment.</summary>
		/// <param name="payment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> CreatePaymentAsync(Payment payment, string accessToken = null);
		/// <summary>Create a new cart payment.</summary>
		/// <param name="payment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> CreatePaymentAsync<TPayment>(Payment payment, string accessToken = null) where TPayment : Payment;
		/// <summary>Partially update a cart payment.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="partialPayment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> PatchPaymentAsync(string paymentID, PartialPayment partialPayment, string accessToken = null);
		/// <summary>Partially update a cart payment.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="partialPayment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> PatchPaymentAsync<TPayment>(string paymentID, PartialPayment partialPayment, string accessToken = null) where TPayment : Payment;
		/// <summary>Delete a cart payment.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeletePaymentAsync(string paymentID, string accessToken = null);
		/// <summary>Create a new cart payment transaction.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="paymentTransaction">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PaymentTransaction> CreatePaymentTransactionAsync(string paymentID, PaymentTransaction paymentTransaction, string accessToken = null);
		/// <summary>Create a new cart payment transaction.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="paymentTransaction">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPaymentTransaction> CreatePaymentTransactionAsync<TPaymentTransaction>(string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) where TPaymentTransaction : PaymentTransaction;
		/// <summary>Delete a cart payment transaction.</summary>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="transactionID">ID of the transaction.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeletePaymentTransactionAsync(string paymentID, string transactionID, string accessToken = null);
		/// <summary>Submit the cart.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SubmitAsync(string accessToken = null);
		/// <summary>Submit the cart.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SubmitAsync<TOrder>(string accessToken = null) where TOrder : Order;
		/// <summary>Validate the cart in it's current state.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ValidateAsync(string accessToken = null);
		/// <summary>Calculate the cart.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> CalculateAsync(string accessToken = null);
		/// <summary>Calculate the cart.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> CalculateAsync<TOrderWorksheet>(string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Get a single cart order worksheet.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> GetOrderWorksheetAsync(string accessToken = null);
		/// <summary>Get a single cart order worksheet.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> GetOrderWorksheetAsync<TOrderWorksheet>(string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Estimate shipping cost.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> EstimateShippingAsync(string accessToken = null);
		/// <summary>Estimate shipping cost.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> EstimateShippingAsync<TOrderWorksheet>(string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Select a ship method.</summary>
		/// <param name="orderShipMethodSelection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> SelectShipMethodsAsync(OrderShipMethodSelection orderShipMethodSelection, string accessToken = null);
		/// <summary>Select a ship method.</summary>
		/// <param name="orderShipMethodSelection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> SelectShipMethodsAsync<TOrderWorksheet>(OrderShipMethodSelection orderShipMethodSelection, string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Set a shipping address.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SetShippingAddressAsync(Address address, string accessToken = null);
		/// <summary>Set a shipping address.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SetShippingAddressAsync<TOrder>(Address address, string accessToken = null) where TOrder : Order;
		/// <summary>Partially update a cart shipping address. Not allowed on carts where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchShippingAddressAsync(PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update a cart shipping address. Not allowed on carts where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchShippingAddressAsync<TOrder>(PartialAddress partialAddress, string accessToken = null) where TOrder : Order;
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SetBillingAddressAsync(Address address, string accessToken = null);
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SetBillingAddressAsync<TOrder>(Address address, string accessToken = null) where TOrder : Order;
		/// <summary>Partially update a cart billing address. Not allowed on carts where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchBillingAddressAsync(PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update a cart billing address. Not allowed on carts where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchBillingAddressAsync<TOrder>(PartialAddress partialAddress, string accessToken = null) where TOrder : Order;
	}

	public interface ICatalogsResource
	{
		/// <summary>Get a single catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> GetAsync(string catalogID, string accessToken = null);
		/// <summary>Get a single catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCatalog> GetAsync<TCatalog>(string catalogID, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCatalog>> ListAsync<TCatalog>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCatalog>> ListAsync<TCatalog>(Action<ListOptionsBuilder<TCatalog>> buildListOpts, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Create a new catalog. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> CreateAsync(Catalog catalog, string accessToken = null);
		/// <summary>Create a new catalog. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCatalog> CreateAsync<TCatalog>(Catalog catalog, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Create or update a catalog. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> SaveAsync(string catalogID, Catalog catalog, string accessToken = null);
		/// <summary>Create or update a catalog. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCatalog> SaveAsync<TCatalog>(string catalogID, Catalog catalog, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Delete a catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string catalogID, string accessToken = null);
		/// <summary>Partially update a catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="partialCatalog">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> PatchAsync(string catalogID, PartialCatalog partialCatalog, string accessToken = null);
		/// <summary>Partially update a catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="partialCatalog">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCatalog> PatchAsync<TCatalog>(string catalogID, PartialCatalog partialCatalog, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Get a list of catalog assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CatalogAssignment>> ListAssignmentsAsync(string catalogID = null, string buyerID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Create or update a catalog assignment.</summary>
		/// <param name="catalogAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(CatalogAssignment catalogAssignment, string accessToken = null);
		/// <summary>Delete a catalog assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string catalogID, string buyerID, string accessToken = null);
		/// <summary>Get a list of catalog product assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCatalogAssignment>> ListProductAssignmentsAsync(string catalogID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Create or update a catalog product assignment.</summary>
		/// <param name="productCatalogAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveProductAssignmentAsync(ProductCatalogAssignment productCatalogAssignment, string accessToken = null);
		/// <summary>Delete a catalog product assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductAssignmentAsync(string catalogID, string productID, string accessToken = null);
		/// <summary>Get a list of catalog bundle assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BundleCatalogAssignment>> ListBundleAssignmentsAsync(string catalogID = null, string bundleID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Create or update a catalog bundle assignment.</summary>
		/// <param name="bundleCatalogAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveBundleAssignmentAsync(BundleCatalogAssignment bundleCatalogAssignment, string accessToken = null);
		/// <summary>Delete a catalog bundle assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteBundleAssignmentAsync(string catalogID, string bundleID, string accessToken = null);
	}

	public interface ICategoriesResource
	{
		/// <summary>Get a single category.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> GetAsync(string catalogID, string categoryID, string accessToken = null);
		/// <summary>Get a single category.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCategory> GetAsync<TCategory>(string catalogID, string categoryID, string accessToken = null) where TCategory : Category;
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListAsync(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCategory>> ListAsync<TCategory>(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCategory : Category;
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListAsync(string catalogID, Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string accessToken = null);
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCategory>> ListAsync<TCategory>(string catalogID, Action<ListOptionsBuilder<TCategory>> buildListOpts, string depth = "1", string accessToken = null) where TCategory : Category;
		/// <summary>Create a new category. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="adjustListOrders">Adjust list orders of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> CreateAsync(string catalogID, Category category, bool adjustListOrders = false, string accessToken = null);
		/// <summary>Create a new category. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="adjustListOrders">Adjust list orders of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCategory> CreateAsync<TCategory>(string catalogID, Category category, bool adjustListOrders = false, string accessToken = null) where TCategory : Category;
		/// <summary>Create or update a category. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="adjustListOrders">Adjust list orders of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> SaveAsync(string catalogID, string categoryID, Category category, bool adjustListOrders = false, string accessToken = null);
		/// <summary>Create or update a category. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="adjustListOrders">Adjust list orders of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCategory> SaveAsync<TCategory>(string catalogID, string categoryID, Category category, bool adjustListOrders = false, string accessToken = null) where TCategory : Category;
		/// <summary>Delete a category. Deleting a parent category will also delete all of that category's children.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string catalogID, string categoryID, string accessToken = null);
		/// <summary>Partially update a category. Setting adjustListOrders to true will increase ListOrder for all categories with the same or higher ListOrder.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="partialCategory">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="adjustListOrders">Adjust list orders of the partial 1.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> PatchAsync(string catalogID, string categoryID, PartialCategory partialCategory, bool adjustListOrders = false, string accessToken = null);
		/// <summary>Partially update a category. Setting adjustListOrders to true will increase ListOrder for all categories with the same or higher ListOrder.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="partialCategory">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="adjustListOrders">Adjust list orders of the partial 1.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCategory> PatchAsync<TCategory>(string catalogID, string categoryID, PartialCategory partialCategory, bool adjustListOrders = false, string accessToken = null) where TCategory : Category;
		/// <summary>Get a list of category assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the category assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CategoryAssignment>> ListAssignmentsAsync(string catalogID, string categoryID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a category assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string catalogID, string categoryID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null);
		/// <summary>Create or update a category assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(string catalogID, CategoryAssignment categoryAssignment, string accessToken = null);
		/// <summary>Get a list of category product assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CategoryProductAssignment>> ListProductAssignmentsAsync(string catalogID, string categoryID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Create or update a category product assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryProductAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveProductAssignmentAsync(string catalogID, CategoryProductAssignment categoryProductAssignment, string accessToken = null);
		/// <summary>Delete a category product assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductAssignmentAsync(string catalogID, string categoryID, string productID, string accessToken = null);
		/// <summary>Get a list of category bundle assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CategoryBundleAssignment>> ListBundleAssignmentsAsync(string catalogID, string categoryID = null, string bundleID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Create or update a category bundle assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryBundleAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveBundleAssignmentAsync(string catalogID, CategoryBundleAssignment categoryBundleAssignment, string accessToken = null);
		/// <summary>Delete a category bundle assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteBundleAssignmentAsync(string catalogID, string categoryID, string bundleID, string accessToken = null);
	}

	public interface ICertsResource
	{
		/// <summary>Get a single cert public key. Returns a JSON Web Key (JWK). Can be used for validating the token was signed by OrderCloud.</summary>
		/// <param name="ID">ID of the public key.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PublicKey> GetPublicKeyAsync(string ID, string accessToken = null);
	}

	public interface ICostCentersResource
	{
		/// <summary>Get a single cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> GetAsync(string buyerID, string costCenterID, string accessToken = null);
		/// <summary>Get a single cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCostCenter> GetAsync<TCostCenter>(string buyerID, string costCenterID, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCostCenter>> ListAsync<TCostCenter>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListAsync(string buyerID, Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCostCenter>> ListAsync<TCostCenter>(string buyerID, Action<ListOptionsBuilder<TCostCenter>> buildListOpts, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Create a new cost center. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> CreateAsync(string buyerID, CostCenter costCenter, string accessToken = null);
		/// <summary>Create a new cost center. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCostCenter> CreateAsync<TCostCenter>(string buyerID, CostCenter costCenter, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Create or update a cost center. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> SaveAsync(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null);
		/// <summary>Create or update a cost center. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCostCenter> SaveAsync<TCostCenter>(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Delete a cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string costCenterID, string accessToken = null);
		/// <summary>Partially update a cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="partialCostCenter">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> PatchAsync(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null);
		/// <summary>Partially update a cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="partialCostCenter">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCostCenter> PatchAsync<TCostCenter>(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Get a list of cost center assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the cost center assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenterAssignment>> ListAssignmentsAsync(string buyerID, string costCenterID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a cost center assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string buyerID, string costCenterID, string userID = null, string userGroupID = null, string accessToken = null);
		/// <summary>Create or update a cost center assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(string buyerID, CostCenterAssignment costCenterAssignment, string accessToken = null);
	}

	public interface ICreditCardsResource
	{
		/// <summary>Get a single credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard> GetAsync(string buyerID, string creditCardID, string accessToken = null);
		/// <summary>Get a single credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCreditCard> GetAsync<TCreditCard>(string buyerID, string creditCardID, string accessToken = null) where TCreditCard : CreditCard;
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCard>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCreditCard>> ListAsync<TCreditCard>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCreditCard : CreditCard;
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCard>> ListAsync(string buyerID, Action<ListOptionsBuilder<CreditCard>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCreditCard>> ListAsync<TCreditCard>(string buyerID, Action<ListOptionsBuilder<TCreditCard>> buildListOpts, string accessToken = null) where TCreditCard : CreditCard;
		/// <summary>Create a new credit card. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard> CreateAsync(string buyerID, CreditCard creditCard, string accessToken = null);
		/// <summary>Create a new credit card. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCreditCard> CreateAsync<TCreditCard>(string buyerID, CreditCard creditCard, string accessToken = null) where TCreditCard : CreditCard;
		/// <summary>Create or update a credit card. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard> SaveAsync(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null);
		/// <summary>Create or update a credit card. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCreditCard> SaveAsync<TCreditCard>(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null) where TCreditCard : CreditCard;
		/// <summary>Delete a credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string creditCardID, string accessToken = null);
		/// <summary>Partially update a credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="partialCreditCard">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard> PatchAsync(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null);
		/// <summary>Partially update a credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="partialCreditCard">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCreditCard> PatchAsync<TCreditCard>(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null) where TCreditCard : CreditCard;
		/// <summary>Get a list of credit card assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the credit card assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCardAssignment>> ListAssignmentsAsync(string buyerID, string creditCardID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update a credit card assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(string buyerID, CreditCardAssignment creditCardAssignment, string accessToken = null);
		/// <summary>Delete a credit card assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string buyerID, string creditCardID, string userID = null, string userGroupID = null, string accessToken = null);
	}

	public interface IDeliveryConfigurationsResource
	{
		/// <summary>Get a single delivery configuration.</summary>
		/// <param name="deliveryConfigID">ID of the delivery config.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<DeliveryConfig> GetAsync(string deliveryConfigID, string accessToken = null);
		/// <summary>Get a list of delivery configurations.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<DeliveryConfig>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of delivery configurations.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<DeliveryConfig>> ListAsync(Action<ListOptionsBuilder<DeliveryConfig>> buildListOpts, string accessToken = null);
		/// <summary>Create a new delivery configuration. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="deliveryConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<DeliveryConfig> CreateAsync(DeliveryConfig deliveryConfig, string accessToken = null);
		/// <summary>Create or update a delivery configuration. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="deliveryConfigID">ID of the delivery config.</param>
		/// <param name="deliveryConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<DeliveryConfig> SaveAsync(string deliveryConfigID, DeliveryConfig deliveryConfig, string accessToken = null);
		/// <summary>Delete a delivery configuration.</summary>
		/// <param name="deliveryConfigID">ID of the delivery config.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string deliveryConfigID, string accessToken = null);
		/// <summary>Partially update a delivery configuration.</summary>
		/// <param name="deliveryConfigID">ID of the delivery config. Required.</param>
		/// <param name="partialDeliveryConfig">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<DeliveryConfig> PatchAsync(string deliveryConfigID, PartialDeliveryConfig partialDeliveryConfig, string accessToken = null);
	}

	public interface IErrorConfigsResource
	{
		/// <summary>Get a single error config.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ErrorConfig> GetAsync(string accessToken = null);
		/// <summary>Delete an error config.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string accessToken = null);
		/// <summary>Create or update an error config. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="errorConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ErrorConfig> SaveAsync(ErrorConfig errorConfig, string accessToken = null);
		/// <summary>Partially update an error config.</summary>
		/// <param name="partialErrorConfig">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ErrorConfig> PatchAsync(PartialErrorConfig partialErrorConfig, string accessToken = null);
		/// <summary>Validates an error config.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ValidateAsync(string accessToken = null);
	}

	public interface IForgottenCredentialsResource
	{
		/// <summary>Send a verification code. Sends a temporary verification code via email, which must subsequently be passed in a Reset Password call. The verification code expires in 120 minutes.</summary>
		/// <param name="passwordResetRequest">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SendVerificationCodeAsync(PasswordResetRequest passwordResetRequest, string accessToken = null);
		/// <summary>Reset a password by verification code.</summary>
		/// <param name="verificationCode">Verification code of the password reset.</param>
		/// <param name="passwordReset">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ResetPasswordByVerificationCodeAsync(string verificationCode, PasswordReset passwordReset, string accessToken = null);
		/// <summary>Retrieve a username. Sends an email with username for every username associated with an email. Always returns a 200 success regardless of if email doesn’t exist in the clientID.</summary>
		/// <param name="clientID">ID of the client.</param>
		/// <param name="email">Email of the forgotten credentials.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task RetrieveUsernameAsync(string clientID, string email, string accessToken = null);
	}

	public interface IImpersonationConfigsResource
	{
		/// <summary>Get a single impersonation config.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ImpersonationConfig> GetAsync(string impersonationConfigID, string accessToken = null);
		/// <summary>Get a list of impersonation configs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ImpersonationConfig>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of impersonation configs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ImpersonationConfig>> ListAsync(Action<ListOptionsBuilder<ImpersonationConfig>> buildListOpts, string accessToken = null);
		/// <summary>Create a new impersonation config. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="impersonationConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ImpersonationConfig> CreateAsync(ImpersonationConfig impersonationConfig, string accessToken = null);
		/// <summary>Delete an impersonation config.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string impersonationConfigID, string accessToken = null);
		/// <summary>Create or update an impersonation config. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		/// <param name="impersonationConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ImpersonationConfig> SaveAsync(string impersonationConfigID, ImpersonationConfig impersonationConfig, string accessToken = null);
		/// <summary>Partially update an impersonation config.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		/// <param name="partialImpersonationConfig">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ImpersonationConfig> PatchAsync(string impersonationConfigID, PartialImpersonationConfig partialImpersonationConfig, string accessToken = null);
	}

	public interface IIncrementorsResource
	{
		/// <summary>Get a single incrementor.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Incrementor> GetAsync(string incrementorID, string accessToken = null);
		/// <summary>Get a list of incrementors.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Incrementor>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of incrementors.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Incrementor>> ListAsync(Action<ListOptionsBuilder<Incrementor>> buildListOpts, string accessToken = null);
		/// <summary>Create a new incrementor. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="incrementor">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Incrementor> CreateAsync(Incrementor incrementor, string accessToken = null);
		/// <summary>Create or update an incrementor. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		/// <param name="incrementor">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Incrementor> SaveAsync(string incrementorID, Incrementor incrementor, string accessToken = null);
		/// <summary>Delete an incrementor.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string incrementorID, string accessToken = null);
		/// <summary>Partially update an incrementor.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		/// <param name="partialIncrementor">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Incrementor> PatchAsync(string incrementorID, PartialIncrementor partialIncrementor, string accessToken = null);
	}

	public interface IIntegrationEventsResource
	{
		/// <summary>Get a single integration event.</summary>
		/// <param name="integrationEventID">ID of the integration event.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<IntegrationEvent> GetAsync(string integrationEventID, string accessToken = null);
		/// <summary>Get a list of integration events.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<IntegrationEvent>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of integration events.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<IntegrationEvent>> ListAsync(Action<ListOptionsBuilder<IntegrationEvent>> buildListOpts, string accessToken = null);
		/// <summary>Create a new integration event. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="integrationEvent">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<IntegrationEvent> CreateAsync(IntegrationEvent integrationEvent, string accessToken = null);
		/// <summary>Create or update an integration event. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="integrationEventID">ID of the integration event.</param>
		/// <param name="integrationEvent">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<IntegrationEvent> SaveAsync(string integrationEventID, IntegrationEvent integrationEvent, string accessToken = null);
		/// <summary>Delete an integration event.</summary>
		/// <param name="integrationEventID">ID of the integration event.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string integrationEventID, string accessToken = null);
		/// <summary>Partially update an integration event.</summary>
		/// <param name="integrationEventID">ID of the integration event.</param>
		/// <param name="partialIntegrationEvent">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<IntegrationEvent> PatchAsync(string integrationEventID, PartialIntegrationEvent partialIntegrationEvent, string accessToken = null);
		/// <summary>Estimate shipping cost.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> EstimateShippingAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Estimate shipping cost.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> EstimateShippingAsync<TOrderWorksheet>(OrderDirection direction, string orderID, string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Select a ship method.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderShipMethodSelection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> SelectShipmethodsAsync(OrderDirection direction, string orderID, OrderShipMethodSelection orderShipMethodSelection, string accessToken = null);
		/// <summary>Select a ship method.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderShipMethodSelection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> SelectShipmethodsAsync<TOrderWorksheet>(OrderDirection direction, string orderID, OrderShipMethodSelection orderShipMethodSelection, string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Get a single order worksheet.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> GetWorksheetAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Get a single order worksheet.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> GetWorksheetAsync<TOrderWorksheet>(OrderDirection direction, string orderID, string accessToken = null) where TOrderWorksheet : OrderWorksheet;
		/// <summary>Calculate an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderWorksheet> CalculateAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Calculate an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderWorksheet> CalculateAsync<TOrderWorksheet>(OrderDirection direction, string orderID, string accessToken = null) where TOrderWorksheet : OrderWorksheet;
	}

	public interface IInventoryRecordsResource
	{
		/// <summary>Get a single inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> GetAsync(string productID, string inventoryRecordID, string accessToken = null);
		/// <summary>Get a single inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> GetAsync<TInventoryRecord>(string productID, string inventoryRecordID, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListAsync<TInventoryRecord>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListAsync(string productID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListAsync<TInventoryRecord>(string productID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Create a new inventory record. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> CreateAsync(string productID, InventoryRecord inventoryRecord, string accessToken = null);
		/// <summary>Create a new inventory record. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> CreateAsync<TInventoryRecord>(string productID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Delete an inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string productID, string inventoryRecordID, string accessToken = null);
		/// <summary>Create or update an inventory record. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> SaveAsync(string productID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null);
		/// <summary>Create or update an inventory record. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> SaveAsync<TInventoryRecord>(string productID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Partially update an inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="partialInventoryRecord">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> PatchAsync(string productID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null);
		/// <summary>Partially update an inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="partialInventoryRecord">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> PatchAsync<TInventoryRecord>(string productID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of variant inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListVariantAsync(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of variant inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListVariantAsync<TInventoryRecord>(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of variant inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListVariantAsync(string productID, string variantID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of variant inventory records.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListVariantAsync<TInventoryRecord>(string productID, string variantID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a single variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> GetVariantAsync(string productID, string variantID, string inventoryRecordID, string accessToken = null);
		/// <summary>Get a single variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> GetVariantAsync<TInventoryRecord>(string productID, string variantID, string inventoryRecordID, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Create a new variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> CreateVariantAsync(string productID, string variantID, InventoryRecord inventoryRecord, string accessToken = null);
		/// <summary>Create a new variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> CreateVariantAsync<TInventoryRecord>(string productID, string variantID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Create or update a variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> SaveVariantAsync(string productID, string variantID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null);
		/// <summary>Create or update a variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="inventoryRecord">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> SaveVariantAsync<TInventoryRecord>(string productID, string variantID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Partially update a variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="partialInventoryRecord">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<InventoryRecord> PatchVariantAsync(string productID, string variantID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null);
		/// <summary>Partially update a variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="partialInventoryRecord">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TInventoryRecord> PatchVariantAsync<TInventoryRecord>(string productID, string variantID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Delete a variant inventory record.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteVariantAsync(string productID, string variantID, string inventoryRecordID, string accessToken = null);
		/// <summary>Get a list of inventory record assignments.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the inventory record assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecordAssignment>> ListAssignmentsAsync(string productID, string buyerID = null, string inventoryRecordID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update an inventory record assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(string productID, InventoryRecordAssignment inventoryRecordAssignment, string accessToken = null);
		/// <summary>Delete an inventory record assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string productID, string inventoryRecordID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null);
		/// <summary>Get a list of inventory record variant assignments.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the inventory record assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecordAssignment>> ListVariantAssignmentsAsync(string productID, string variantID, string buyerID = null, string inventoryRecordID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update an inventory record variant assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveVariantAssignmentAsync(string productID, string variantID, InventoryRecordAssignment inventoryRecordAssignment, string accessToken = null);
		/// <summary>Delete an inventory record variant assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="inventoryRecordID">ID of the inventory record.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteVariantAssignmentAsync(string productID, string variantID, string inventoryRecordID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null);
	}

	public interface ILineItemsResource
	{
		/// <summary>Get a single line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> GetAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Get a single line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> GetAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListAsync<TLineItem>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListAsync<TLineItem>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create a new line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateAsync(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null);
		/// <summary>Create a new line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateAsync<TLineItem>(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create or update a line item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SaveAsync(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null);
		/// <summary>Create or update a line item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> SaveAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Partially update a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchAsync(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null);
		/// <summary>Partially update a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> PatchAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Set a shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SetShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null);
		/// <summary>Set a shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> SetShippingAddressAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Partially update a line item shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update a line item shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> PatchShippingAddressAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of line item across orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ExtendedLineItem>> ListAcrossOrdersAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of line item across orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TExtendedLineItem>> ListAcrossOrdersAsync<TExtendedLineItem>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TExtendedLineItem : ExtendedLineItem;
		/// <summary>Get a list of line item across orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ExtendedLineItem>> ListAcrossOrdersAsync(OrderDirection direction, Action<ListOptionsBuilder2<ExtendedLineItem>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of line item across orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TExtendedLineItem>> ListAcrossOrdersAsync<TExtendedLineItem>(OrderDirection direction, Action<ListOptionsBuilder2<TExtendedLineItem>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TExtendedLineItem : ExtendedLineItem;
	}

	public interface ILocalesResource
	{
		/// <summary>Get a single locale.</summary>
		/// <param name="localeID">ID of the locale.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Locale> GetAsync(string localeID, string accessToken = null);
		/// <summary>Get a list of locales.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Locale>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of locales.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Locale>> ListAsync(Action<ListOptionsBuilder<Locale>> buildListOpts, string accessToken = null);
		/// <summary>Create a new locale. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="locale">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Locale> CreateAsync(Locale locale, string accessToken = null);
		/// <summary>Create or update a locale. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="localeID">ID of the locale.</param>
		/// <param name="locale">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Locale> SaveAsync(string localeID, Locale locale, string accessToken = null);
		/// <summary>Delete a locale.</summary>
		/// <param name="localeID">ID of the locale.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string localeID, string accessToken = null);
		/// <summary>Partially update a locale.</summary>
		/// <param name="localeID">ID of the locale.</param>
		/// <param name="partialLocale">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Locale> PatchAsync(string localeID, PartialLocale partialLocale, string accessToken = null);
		/// <summary>Get a list of locale assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="localeID">ID of the locale.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the locale assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LocaleAssignment>> ListAssignmentsAsync(string buyerID = null, string localeID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update a locale assignment. Do not assign a user multiple groups with different assigned locales. That is considered a misconfiguration, and will yield unexpected results.</summary>
		/// <param name="localeAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(LocaleAssignment localeAssignment, string accessToken = null);
		/// <summary>Delete a locale assignment.</summary>
		/// <param name="localeID">ID of the locale.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string localeID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null);
	}

	public interface IMeResource
	{
		/// <summary>Get the Current Authenticated User</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser> GetAsync(string accessToken = null);
		/// <summary>Get the Current Authenticated User</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMeUser> GetAsync<TMeUser>(string accessToken = null) where TMeUser : MeUser;
		/// <summary>Update the Currently Authenticated User If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="meUser">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser> SaveAsync(MeUser meUser, string accessToken = null);
		/// <summary>Update the Currently Authenticated User If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="meUser">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMeUser> SaveAsync<TMeUser>(MeUser meUser, string accessToken = null) where TMeUser : MeUser;
		/// <summary>Patch the Currently Authenticated User.</summary>
		/// <param name="partialMeUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser> PatchAsync(PartialMeUser partialMeUser, string accessToken = null);
		/// <summary>Patch the Currently Authenticated User.</summary>
		/// <param name="partialMeUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMeUser> PatchAsync<TMeUser>(PartialMeUser partialMeUser, string accessToken = null) where TMeUser : MeUser;
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListCostCentersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCostCenter>> ListCostCentersAsync<TCostCenter>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListCostCentersAsync(Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCostCenter>> ListCostCentersAsync<TCostCenter>(Action<ListOptionsBuilder<TCostCenter>> buildListOpts, string accessToken = null) where TCostCenter : CostCenter;
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListUserGroupsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListUserGroupsAsync<TUserGroup>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListUserGroupsAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListUserGroupsAsync<TUserGroup>(Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerAddress>> ListAddressesAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TBuyerAddress>> ListAddressesAsync<TBuyerAddress>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyerAddress : BuyerAddress;
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerAddress>> ListAddressesAsync(Action<ListOptionsBuilder<BuyerAddress>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TBuyerAddress>> ListAddressesAsync<TBuyerAddress>(Action<ListOptionsBuilder<TBuyerAddress>> buildListOpts, string accessToken = null) where TBuyerAddress : BuyerAddress;
		/// <summary>Create a new address. Only available to Buyer Users. Addresses created using this endpoint are considered private, and only accessible to the user who created them.</summary>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress> CreateAddressAsync(BuyerAddress buyerAddress, string accessToken = null);
		/// <summary>Create a new address. Only available to Buyer Users. Addresses created using this endpoint are considered private, and only accessible to the user who created them.</summary>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerAddress> CreateAddressAsync<TBuyerAddress>(BuyerAddress buyerAddress, string accessToken = null) where TBuyerAddress : BuyerAddress;
		/// <summary>Get a single address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress> GetAddressAsync(string addressID, string accessToken = null);
		/// <summary>Get a single address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerAddress> GetAddressAsync<TBuyerAddress>(string addressID, string accessToken = null) where TBuyerAddress : BuyerAddress;
		/// <summary>Update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress> SaveAddressAsync(string addressID, BuyerAddress buyerAddress, string accessToken = null);
		/// <summary>Update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerAddress> SaveAddressAsync<TBuyerAddress>(string addressID, BuyerAddress buyerAddress, string accessToken = null) where TBuyerAddress : BuyerAddress;
		/// <summary>Partially update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialBuyerAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task PatchAddressAsync(string addressID, PartialBuyerAddress partialBuyerAddress, string accessToken = null);
		/// <summary>Delete an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAddressAsync(string addressID, string accessToken = null);
		/// <summary>Create a new credit card. Only available to Buyer Users. Credit Cards created using this endpoint are considered private, and only accessible to the user who created them.</summary>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard> CreateCreditCardAsync(BuyerCreditCard buyerCreditCard, string accessToken = null);
		/// <summary>Create a new credit card. Only available to Buyer Users. Credit Cards created using this endpoint are considered private, and only accessible to the user who created them.</summary>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerCreditCard> CreateCreditCardAsync<TBuyerCreditCard>(BuyerCreditCard buyerCreditCard, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard;
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TBuyerCreditCard>> ListCreditCardsAsync<TBuyerCreditCard>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard;
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(Action<ListOptionsBuilder<BuyerCreditCard>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TBuyerCreditCard>> ListCreditCardsAsync<TBuyerCreditCard>(Action<ListOptionsBuilder<TBuyerCreditCard>> buildListOpts, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard;
		/// <summary>Get a single credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard> GetCreditCardAsync(string creditcardID, string accessToken = null);
		/// <summary>Get a single credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerCreditCard> GetCreditCardAsync<TBuyerCreditCard>(string creditcardID, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard;
		/// <summary>Update a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard> SaveCreditCardAsync(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null);
		/// <summary>Update a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerCreditCard> SaveCreditCardAsync<TBuyerCreditCard>(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard;
		/// <summary>Partially update a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="partialBuyerCreditCard">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task PatchCreditCardAsync(string creditcardID, PartialBuyerCreditCard partialBuyerCreditCard, string accessToken = null);
		/// <summary>Delete a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteCreditCardAsync(string creditcardID, string accessToken = null);
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <param name="depth">Indicates how deep down the hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to ParentID if specified. Default is 1.</param>
		/// <param name="catalogID">The user’s default CatalogID will be used to return categories if you do not pass another CatalogID explicitly. Listing categories across multiple catalogs is not supported.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListCategoriesAsync(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <param name="depth">Indicates how deep down the hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to ParentID if specified. Default is 1.</param>
		/// <param name="catalogID">The user’s default CatalogID will be used to return categories if you do not pass another CatalogID explicitly. Listing categories across multiple catalogs is not supported.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCategory>> ListCategoriesAsync<TCategory>(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCategory : Category;
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Indicates how deep down the hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to ParentID if specified. Default is 1.</param>
		/// <param name="catalogID">The user’s default CatalogID will be used to return categories if you do not pass another CatalogID explicitly. Listing categories across multiple catalogs is not supported.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListCategoriesAsync(Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null);
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Indicates how deep down the hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to ParentID if specified. Default is 1.</param>
		/// <param name="catalogID">The user’s default CatalogID will be used to return categories if you do not pass another CatalogID explicitly. Listing categories across multiple catalogs is not supported.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCategory>> ListCategoriesAsync<TCategory>(Action<ListOptionsBuilder<TCategory>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null) where TCategory : Category;
		/// <summary>Get a single category. Only available to Buyer Users.</summary>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> GetCategoryAsync(string categoryID, string catalogID, string accessToken = null);
		/// <summary>Get a single category. Only available to Buyer Users.</summary>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCategory> GetCategoryAsync<TCategory>(string categoryID, string catalogID, string accessToken = null) where TCategory : Category;
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Indicates how deep down the category hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to CategoryID if specified, otherwise top level of the Catalog. Default is 'all'.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<BuyerProduct>> ListProductsAsync(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null);
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Indicates how deep down the category hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to CategoryID if specified, otherwise top level of the Catalog. Default is 'all'.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TBuyerProduct>> ListProductsAsync<TBuyerProduct>(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null) where TBuyerProduct : BuyerProduct;
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Indicates how deep down the category hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to CategoryID if specified, otherwise top level of the Catalog. Default is 'all'.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<BuyerProduct>> ListProductsAsync(Action<ListOptionsBuilder2<BuyerProduct>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string sellerID = null, string accessToken = null);
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Indicates how deep down the category hierarchy to return results. Valid values are a number of 1 or greater, or 'all'. Relative to CategoryID if specified, otherwise top level of the Catalog. Default is 'all'.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TBuyerProduct>> ListProductsAsync<TBuyerProduct>(Action<ListOptionsBuilder2<TBuyerProduct>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string sellerID = null, string accessToken = null) where TBuyerProduct : BuyerProduct;
		/// <summary>Get a single product. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerProduct> GetProductAsync(string productID, string sellerID = null, string accessToken = null);
		/// <summary>Get a single product. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TBuyerProduct> GetProductAsync<TBuyerProduct>(string productID, string sellerID = null, string accessToken = null) where TBuyerProduct : BuyerProduct;
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListSpecsAsync(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListSpecsAsync(string productID, Action<ListOptionsBuilder<Spec>> buildListOpts, string catalogID = null, string accessToken = null);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, Action<ListOptionsBuilder<TSpec>> buildListOpts, string catalogID = null, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a single spec. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> GetSpecAsync(string productID, string specID, string catalogID = null, string accessToken = null);
		/// <summary>Get a single spec. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpec> GetSpecAsync<TSpec>(string productID, string specID, string catalogID = null, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of variants visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of variants visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TVariant : Variant;
		/// <summary>Get a list of variants visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, Action<ListOptionsBuilder<Variant>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of variants visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, Action<ListOptionsBuilder<TVariant>> buildListOpts, string accessToken = null) where TVariant : Variant;
		/// <summary>Get a single variant. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> GetVariantAsync(string productID, string variantID, string accessToken = null);
		/// <summary>Get a single variant. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TVariant> GetVariantAsync<TVariant>(string productID, string variantID, string accessToken = null) where TVariant : Variant;
		/// <summary>Get a list of product inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListProductInventoryRecordsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListProductInventoryRecordsAsync<TInventoryRecord>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of product inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListProductInventoryRecordsAsync(string productID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListProductInventoryRecordsAsync<TInventoryRecord>(string productID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of variant inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListVariantInventoryRecordsAsync(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of variant inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListVariantInventoryRecordsAsync<TInventoryRecord>(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of variant inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<InventoryRecord>> ListVariantInventoryRecordsAsync(string productID, string variantID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of variant inventory records visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TInventoryRecord>> ListVariantInventoryRecordsAsync<TInventoryRecord>(string productID, string variantID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord;
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrder>> ListOrdersAsync<TOrder>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListOrdersAsync(Action<ListOptionsBuilder2<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrder>> ListOrdersAsync<TOrder>(Action<ListOptionsBuilder2<TOrder>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListApprovableOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrder>> ListApprovableOrdersAsync<TOrder>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListApprovableOrdersAsync(Action<ListOptionsBuilder<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrder>> ListApprovableOrdersAsync<TOrder>(Action<ListOptionsBuilder<TOrder>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TOrder : Order;
		/// <summary>Transfer an order. If a user begins an order as the anonymous shopper and later logs in, use this endpoint to transfer that order to them.</summary>
		/// <param name="anonUserToken">Anon user token of the me.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task TransferAnonUserOrderAsync(string anonUserToken, string accessToken = null);
		/// <summary>Reset a password by token.</summary>
		/// <param name="tokenPasswordReset">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ResetPasswordByTokenAsync(TokenPasswordReset tokenPasswordReset, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListPromotionsAsync<TPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListPromotionsAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListPromotionsAsync<TPromotion>(Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Get a single promotion. Only available to Buyer Users.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> GetPromotionAsync(string promotionID, string accessToken = null);
		/// <summary>Get a single promotion. Only available to Buyer Users.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPromotion> GetPromotionAsync<TPromotion>(string promotionID, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpendingAccount>> ListSpendingAccountsAsync<TSpendingAccount>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpendingAccount>> ListSpendingAccountsAsync<TSpendingAccount>(Action<ListOptionsBuilder<TSpendingAccount>> buildListOpts, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Get a single spending account. Only available to Buyer Users.</summary>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> GetSpendingAccountAsync(string spendingAccountID, string accessToken = null);
		/// <summary>Get a single spending account. Only available to Buyer Users.</summary>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpendingAccount> GetSpendingAccountAsync<TSpendingAccount>(string spendingAccountID, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipment : Shipment;
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(Action<ListOptionsBuilder<TShipment>> buildListOpts, string orderID = null, string accessToken = null) where TShipment : Shipment;
		/// <summary>Get a single shipment. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> GetShipmentAsync(string shipmentID, string accessToken = null);
		/// <summary>Get a single shipment. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> GetShipmentAsync<TShipment>(string shipmentID, string accessToken = null) where TShipment : Shipment;
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipmentItem>> ListShipmentItemsAsync<TShipmentItem>(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipmentItem : ShipmentItem;
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipmentItem>> ListShipmentItemsAsync<TShipmentItem>(string shipmentID, Action<ListOptionsBuilder<TShipmentItem>> buildListOpts, string orderID = null, string accessToken = null) where TShipmentItem : ShipmentItem;
		/// <summary>Register a User.</summary>
		/// <param name="meUser">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="anonUserToken">Anon user token of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<AccessTokenBasic> RegisterAsync(MeUser meUser, string anonUserToken, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListCatalogsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCatalog>> ListCatalogsAsync<TCatalog>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListCatalogsAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string sellerID = null, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TCatalog>> ListCatalogsAsync<TCatalog>(Action<ListOptionsBuilder<TCatalog>> buildListOpts, string sellerID = null, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Get a single catalog. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> GetCatalogAsync(string catalogID, string accessToken = null);
		/// <summary>Get a single catalog. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TCatalog> GetCatalogAsync<TCatalog>(string catalogID, string accessToken = null) where TCatalog : Catalog;
		/// <summary>Get a list of sellers this user can purchase from. Organizations you can place orders directly to.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of sellers this user can purchase from. Organizations you can place orders directly to.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(Action<ListOptionsBuilder<BuyerSupplier>> buildListOpts, string accessToken = null);
		/// <summary>Create a new product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollection> CreateProductCollectionAsync(ProductCollection productCollection, string accessToken = null);
		/// <summary>Create a new product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollection> CreateProductCollectionAsync<TProductCollection>(ProductCollection productCollection, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Get a single product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollection> GetProductCollectionAsync(string productCollectionID, string accessToken = null);
		/// <summary>Get a single product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollection> GetProductCollectionAsync<TProductCollection>(string productCollectionID, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Get a list of product collections visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCollection>> ListProductCollectionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product collections visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductCollection>> ListProductCollectionsAsync<TProductCollection>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Get a list of product collections visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCollection>> ListProductCollectionsAsync(Action<ListOptionsBuilder<ProductCollection>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product collections visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductCollection>> ListProductCollectionsAsync<TProductCollection>(Action<ListOptionsBuilder<TProductCollection>> buildListOpts, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Partially update a product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="partialProductCollection">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollection> PatchProductCollectionAsync(string productCollectionID, PartialProductCollection partialProductCollection, string accessToken = null);
		/// <summary>Partially update a product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="partialProductCollection">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollection> PatchProductCollectionAsync<TProductCollection>(string productCollectionID, PartialProductCollection partialProductCollection, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Create or update a product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="productCollection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollection> SaveProductCollectionAsync(string productCollectionID, ProductCollection productCollection, string accessToken = null);
		/// <summary>Create or update a product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="productCollection">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollection> SaveProductCollectionAsync<TProductCollection>(string productCollectionID, ProductCollection productCollection, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Delete a product collection. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductCollectionAsync(string productCollectionID, string accessToken = null);
		/// <summary>Get a list of product collection entries visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<BuyerProduct>> ListProductCollectionEntriesAsync(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product collection entries visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TBuyerProduct>> ListProductCollectionEntriesAsync<TBuyerProduct>(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyerProduct : BuyerProduct;
		/// <summary>Get a list of product collection entries visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<BuyerProduct>> ListProductCollectionEntriesAsync(string productCollectionID, Action<ListOptionsBuilder2<BuyerProduct>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product collection entries visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TBuyerProduct>> ListProductCollectionEntriesAsync<TBuyerProduct>(string productCollectionID, Action<ListOptionsBuilder2<TBuyerProduct>> buildListOpts, string accessToken = null) where TBuyerProduct : BuyerProduct;
		/// <summary>Create a new product collection entry. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task CreateProductCollectionEntryAsync(string productCollectionID, string productID, string accessToken = null);
		/// <summary>Delete a product collection entry. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductCollectionEntryAsync(string productCollectionID, string productID, string accessToken = null);
		/// <summary>Create a new product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="productCollectionInvitation">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollectionInvitation> CreateProductCollectionInvitationAsync(string productCollectionID, ProductCollectionInvitation productCollectionInvitation, string accessToken = null);
		/// <summary>Create a new product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="productCollectionInvitation">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollectionInvitation> CreateProductCollectionInvitationAsync<TProductCollectionInvitation>(string productCollectionID, ProductCollectionInvitation productCollectionInvitation, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation;
		/// <summary>Partially update a product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="partialProductCollectionInvitation">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollectionInvitation> PatchProductCollectionInvitationAsync(string productCollectionID, string invitationID, PartialProductCollectionInvitation partialProductCollectionInvitation, string accessToken = null);
		/// <summary>Partially update a product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="partialProductCollectionInvitation">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollectionInvitation> PatchProductCollectionInvitationAsync<TProductCollectionInvitation>(string productCollectionID, string invitationID, PartialProductCollectionInvitation partialProductCollectionInvitation, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation;
		/// <summary>Delete a product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null);
		/// <summary>Get a single product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollectionInvitation> GetProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null);
		/// <summary>Get a single product collection invitation. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollectionInvitation> GetProductCollectionInvitationAsync<TProductCollectionInvitation>(string productCollectionID, string invitationID, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation;
		/// <summary>Get a list of product collection invitations visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCollectionInvitation>> ListProductCollectionInvitationsAsync(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product collection invitations visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductCollectionInvitation>> ListProductCollectionInvitationsAsync<TProductCollectionInvitation>(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation;
		/// <summary>Get a list of product collection invitations visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCollectionInvitation>> ListProductCollectionInvitationsAsync(string productCollectionID, Action<ListOptionsBuilder2<ProductCollectionInvitation>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product collection invitations visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductCollectionInvitation>> ListProductCollectionInvitationsAsync<TProductCollectionInvitation>(string productCollectionID, Action<ListOptionsBuilder2<TProductCollectionInvitation>> buildListOpts, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation;
		/// <summary>Accept a product collection invitation.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task AcceptProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null);
		/// <summary>Decline a product collection invitation.</summary>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="invitationID">ID of the invitation.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeclineProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null);
		/// <summary>Get a list of subscriptions visible to this user.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Subscription>> ListSubscriptionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of subscriptions visible to this user.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSubscription>> ListSubscriptionsAsync<TSubscription>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Get a list of subscriptions visible to this user.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Subscription>> ListSubscriptionsAsync(Action<ListOptionsBuilder<Subscription>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of subscriptions visible to this user.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSubscription>> ListSubscriptionsAsync<TSubscription>(Action<ListOptionsBuilder<TSubscription>> buildListOpts, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Get a single subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> GetSubscriptionAsync(string subscriptionID, string accessToken = null);
		/// <summary>Get a single subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> GetSubscriptionAsync<TSubscription>(string subscriptionID, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Create a new subscription.</summary>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> CreateSubscriptionAsync(Subscription subscription, string accessToken = null);
		/// <summary>Create a new subscription.</summary>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> CreateSubscriptionAsync<TSubscription>(Subscription subscription, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Create or update a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> SaveSubscriptionAsync(string subscriptionID, Subscription subscription, string accessToken = null);
		/// <summary>Create or update a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> SaveSubscriptionAsync<TSubscription>(string subscriptionID, Subscription subscription, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Partially update a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="partialSubscription">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> PatchSubscriptionAsync(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null);
		/// <summary>Partially update a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="partialSubscription">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> PatchSubscriptionAsync<TSubscription>(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Delete a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteSubscriptionAsync(string subscriptionID, string accessToken = null);
		/// <summary>Get a list of subscription items visible to this user.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListSubscriptionItemsAsync(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of subscription items visible to this user.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListSubscriptionItemsAsync<TLineItem>(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of subscription items visible to this user.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListSubscriptionItemsAsync(string subscriptionID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of subscription items visible to this user.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListSubscriptionItemsAsync<TLineItem>(string subscriptionID, Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a single subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> GetSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, string accessToken = null);
		/// <summary>Get a single subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> GetSubscriptionItemAsync<TLineItem>(string subscriptionID, string subscriptionItemID, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create a new subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateSubscriptionItemAsync(string subscriptionID, LineItem lineItem, string accessToken = null);
		/// <summary>Create a new subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateSubscriptionItemAsync<TLineItem>(string subscriptionID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create or update a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SaveSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null);
		/// <summary>Create or update a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> SaveSubscriptionItemAsync<TLineItem>(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Partially update a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null);
		/// <summary>Partially update a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> PatchSubscriptionItemAsync<TLineItem>(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, string accessToken = null);
		/// <summary>Create a new subscription bundle item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateSubscriptionBundleItemAsync(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null);
		/// <summary>Create a new subscription bundle item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItems">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateSubscriptionBundleItemAsync<TLineItem>(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a subscription bundle item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="bundleID">ID of the bundle.</param>
		/// <param name="bundleItemID">ID of the bundle item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteSubscriptionBundleItemAsync(string subscriptionID, string bundleID, string bundleItemID, string accessToken = null);
		/// <summary>Get a list of product sellers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductSeller>> ListProductSellersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product sellers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductSeller>> ListProductSellersAsync<TProductSeller>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductSeller : ProductSeller;
		/// <summary>Get a list of product sellers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductSeller>> ListProductSellersAsync(string productID, Action<ListOptionsBuilder<ProductSeller>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product sellers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductSeller>> ListProductSellersAsync<TProductSeller>(string productID, Action<ListOptionsBuilder<TProductSeller>> buildListOpts, string accessToken = null) where TProductSeller : ProductSeller;
	}

	public interface IMessageSendersResource
	{
		/// <summary>Get a single message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MessageSender> GetAsync(string messageSenderID, string accessToken = null);
		/// <summary>Get a single message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMessageSender> GetAsync<TMessageSender>(string messageSenderID, string accessToken = null) where TMessageSender : MessageSender;
		/// <summary>Get a list of message senders.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageSender>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of message senders.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TMessageSender>> ListAsync<TMessageSender>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TMessageSender : MessageSender;
		/// <summary>Get a list of message senders.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageSender>> ListAsync(Action<ListOptionsBuilder<MessageSender>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of message senders.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TMessageSender>> ListAsync<TMessageSender>(Action<ListOptionsBuilder<TMessageSender>> buildListOpts, string accessToken = null) where TMessageSender : MessageSender;
		/// <summary>Create a new message sender. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="messageSender">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MessageSender> CreateAsync(MessageSender messageSender, string accessToken = null);
		/// <summary>Create a new message sender. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="messageSender">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMessageSender> CreateAsync<TMessageSender>(MessageSender messageSender, string accessToken = null) where TMessageSender : MessageSender;
		/// <summary>Create or update a message sender. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="messageSender">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MessageSender> SaveAsync(string messageSenderID, MessageSender messageSender, string accessToken = null);
		/// <summary>Create or update a message sender. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="messageSender">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMessageSender> SaveAsync<TMessageSender>(string messageSenderID, MessageSender messageSender, string accessToken = null) where TMessageSender : MessageSender;
		/// <summary>Delete a message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string messageSenderID, string accessToken = null);
		/// <summary>Partially update a message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="partialMessageSender">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MessageSender> PatchAsync(string messageSenderID, PartialMessageSender partialMessageSender, string accessToken = null);
		/// <summary>Partially update a message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="partialMessageSender">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TMessageSender> PatchAsync<TMessageSender>(string messageSenderID, PartialMessageSender partialMessageSender, string accessToken = null) where TMessageSender : MessageSender;
		/// <summary>Get a list of message sender assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the message sender assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageSenderAssignment>> ListAssignmentsAsync(string buyerID = null, string messageSenderID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string supplierID = null, string accessToken = null);
		/// <summary>Delete a message sender assignment.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string messageSenderID, string buyerID = null, string userID = null, string userGroupID = null, string supplierID = null, string accessToken = null);
		/// <summary>Create or update a message sender assignment.</summary>
		/// <param name="messageSenderAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(MessageSenderAssignment messageSenderAssignment, string accessToken = null);
		/// <summary>Get a list of message sender cc listener assignments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of message sender cc listener assignments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(Action<ListOptionsBuilder<MessageCCListenerAssignment>> buildListOpts, string accessToken = null);
		/// <summary>Create or update a message sender cc listener assignment.</summary>
		/// <param name="messageCCListenerAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveCCListenerAssignmentAsync(MessageCCListenerAssignment messageCCListenerAssignment, string accessToken = null);
	}

	public interface IOpenIdConnectsResource
	{
		/// <summary>Get a single OpenID Connect.</summary>
		/// <param name="openidconnectID">ID of the openidconnect.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OpenIdConnect> GetAsync(string openidconnectID, string accessToken = null);
		/// <summary>Get a list of OpenID Connects.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OpenIdConnect>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of OpenID Connects.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OpenIdConnect>> ListAsync(Action<ListOptionsBuilder<OpenIdConnect>> buildListOpts, string accessToken = null);
		/// <summary>Create a new OpenID Connect. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="openIdConnect">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OpenIdConnect> CreateAsync(OpenIdConnect openIdConnect, string accessToken = null);
		/// <summary>Create or update a OpenID Connect. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="openidconnectID">ID of the openidconnect.</param>
		/// <param name="openIdConnect">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OpenIdConnect> SaveAsync(string openidconnectID, OpenIdConnect openIdConnect, string accessToken = null);
		/// <summary>Delete a OpenID Connect.</summary>
		/// <param name="openidconnectID">ID of the openidconnect.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string openidconnectID, string accessToken = null);
		/// <summary>Partially update a OpenID Connect.</summary>
		/// <param name="openidconnectID">ID of the openidconnect.</param>
		/// <param name="partialOpenIdConnect">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OpenIdConnect> PatchAsync(string openidconnectID, PartialOpenIdConnect partialOpenIdConnect, string accessToken = null);
	}

	public interface IOrderReturnsResource
	{
		/// <summary>Get a single order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> GetAsync(string returnID, string accessToken = null);
		/// <summary>Get a single order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> GetAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Get a list of order returns.</summary>
		/// <param name="approvable">Only returns orders awaiting the user's approval if true.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderReturn>> ListAsync(bool approvable = false, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order returns.</summary>
		/// <param name="approvable">Only returns orders awaiting the user's approval if true.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderReturn>> ListAsync<TOrderReturn>(bool approvable = false, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Get a list of order returns.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="approvable">Only returns orders awaiting the user's approval if true.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderReturn>> ListAsync(Action<ListOptionsBuilder<OrderReturn>> buildListOpts, bool approvable = false, string accessToken = null);
		/// <summary>Get a list of order returns.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="approvable">Only returns orders awaiting the user's approval if true.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderReturn>> ListAsync<TOrderReturn>(Action<ListOptionsBuilder<TOrderReturn>> buildListOpts, bool approvable = false, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Create a new order return. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="orderReturn">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> CreateAsync(OrderReturn orderReturn, string accessToken = null);
		/// <summary>Create a new order return. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="orderReturn">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> CreateAsync<TOrderReturn>(OrderReturn orderReturn, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Create or update an order return. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="orderReturn">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> SaveAsync(string returnID, OrderReturn orderReturn, string accessToken = null);
		/// <summary>Create or update an order return. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="orderReturn">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> SaveAsync<TOrderReturn>(string returnID, OrderReturn orderReturn, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Delete an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string returnID, string accessToken = null);
		/// <summary>Partially update an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="partialOrderReturn">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> PatchAsync(string returnID, PartialOrderReturn partialOrderReturn, string accessToken = null);
		/// <summary>Partially update an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="partialOrderReturn">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> PatchAsync<TOrderReturn>(string returnID, PartialOrderReturn partialOrderReturn, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Delete an order return item.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> DeleteItemAsync(string returnID, string lineItemID, string accessToken = null);
		/// <summary>Delete an order return item.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> DeleteItemAsync<TOrderReturn>(string returnID, string lineItemID, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Cancel an OrderReturn.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> CancelAsync(string returnID, string accessToken = null);
		/// <summary>Cancel an OrderReturn.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> CancelAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Complete an OrderReturn. Use only when an order return won't have an associated payment. You will not to reopen an order return after completing it.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> CompleteAsync(string returnID, string accessToken = null);
		/// <summary>Complete an OrderReturn. Use only when an order return won't have an associated payment. You will not to reopen an order return after completing it.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> CompleteAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Submit an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> SubmitAsync(string returnID, string accessToken = null);
		/// <summary>Submit an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> SubmitAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Get a list of order return approvals. Returns all Approvals associated with the Order Return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderReturnApproval>> ListApprovalsAsync(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order return approvals. Returns all Approvals associated with the Order Return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderReturnApproval>> ListApprovalsAsync<TOrderReturnApproval>(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderReturnApproval : OrderReturnApproval;
		/// <summary>Get a list of order return approvals. Returns all Approvals associated with the Order Return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderReturnApproval>> ListApprovalsAsync(string returnID, Action<ListOptionsBuilder<OrderReturnApproval>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order return approvals. Returns all Approvals associated with the Order Return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderReturnApproval>> ListApprovalsAsync<TOrderReturnApproval>(string returnID, Action<ListOptionsBuilder<TOrderReturnApproval>> buildListOpts, string accessToken = null) where TOrderReturnApproval : OrderReturnApproval;
		/// <summary>Get a list of order return eligible approvers. Returns all Users who can approve or decline this order return (but have not done so).</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListEligibleApproversAsync(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order return eligible approvers. Returns all Users who can approve or decline this order return (but have not done so).</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User;
		/// <summary>Get a list of order return eligible approvers. Returns all Users who can approve or decline this order return (but have not done so).</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListEligibleApproversAsync(string returnID, Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order return eligible approvers. Returns all Users who can approve or decline this order return (but have not done so).</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(string returnID, Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User;
		/// <summary>Approve an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="approvalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> ApproveAsync(string returnID, ApprovalInfo approvalInfo, string accessToken = null);
		/// <summary>Approve an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="approvalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> ApproveAsync<TOrderReturn>(string returnID, ApprovalInfo approvalInfo, string accessToken = null) where TOrderReturn : OrderReturn;
		/// <summary>Decline an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="approvalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderReturn> DeclineAsync(string returnID, ApprovalInfo approvalInfo, string accessToken = null);
		/// <summary>Decline an order return.</summary>
		/// <param name="returnID">ID of the return.</param>
		/// <param name="approvalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderReturn> DeclineAsync<TOrderReturn>(string returnID, ApprovalInfo approvalInfo, string accessToken = null) where TOrderReturn : OrderReturn;
	}

	public interface IOrdersResource
	{
		/// <summary>Get a single order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> GetAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Get a single order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> GetAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrder>> ListAsync<TOrder>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrder : Order;
		/// <summary>Get a list of orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListAsync(OrderDirection direction, Action<ListOptionsBuilder2<Order>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrder>> ListAsync<TOrder>(OrderDirection direction, Action<ListOptionsBuilder2<TOrder>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TOrder : Order;
		/// <summary>Create a new order. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> CreateAsync(OrderDirection direction, Order order, string accessToken = null);
		/// <summary>Create a new order. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> CreateAsync<TOrder>(OrderDirection direction, Order order, string accessToken = null) where TOrder : Order;
		/// <summary>Create or update an order. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SaveAsync(OrderDirection direction, string orderID, Order order, string accessToken = null);
		/// <summary>Create or update an order. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SaveAsync<TOrder>(OrderDirection direction, string orderID, Order order, string accessToken = null) where TOrder : Order;
		/// <summary>Delete an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderApproval>> ListApprovalsAsync<TOrderApproval>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderApproval : OrderApproval;
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderApproval>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderApproval>> ListApprovalsAsync<TOrderApproval>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TOrderApproval>> buildListOpts, string accessToken = null) where TOrderApproval : OrderApproval;
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User;
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User;
		/// <summary>Partially update an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialOrder">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchAsync(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null);
		/// <summary>Partially update an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialOrder">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchAsync<TOrder>(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null) where TOrder : Order;
		/// <summary>Submit an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SubmitAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Submit an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SubmitAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order;
		/// <summary>Approve an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> ApproveAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null);
		/// <summary>Approve an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> ApproveAsync<TOrder>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) where TOrder : Order;
		/// <summary>Decline an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> DeclineAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null);
		/// <summary>Decline an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> DeclineAsync<TOrder>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) where TOrder : Order;
		/// <summary>Cancel an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> CancelAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Cancel an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> CancelAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order;
		/// <summary>Split an order. Creates, but does not submit, 0 or more outgoing Orders to Suppliers, one for each unique Product.DefaultSupplierID on this Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderSplitResult> SplitAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Split an order. Creates, but does not submit, 0 or more outgoing Orders to Suppliers, one for each unique Product.DefaultSupplierID on this Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderSplitResult> SplitAsync<TOrderSplitResult>(OrderDirection direction, string orderID, string accessToken = null) where TOrderSplitResult : OrderSplitResult;
		/// <summary>Forward an order. Creates and submits 0 or more outgoing Orders to Suppliers, one for each unique Product.DefaultSupplierID on this Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderSplitResult> ForwardAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Forward an order. Creates and submits 0 or more outgoing Orders to Suppliers, one for each unique Product.DefaultSupplierID on this Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderSplitResult> ForwardAsync<TOrderSplitResult>(OrderDirection direction, string orderID, string accessToken = null) where TOrderSplitResult : OrderSplitResult;
		/// <summary>Complete an order. Use only when an order doesn't need a shipment. You will not be able to ship or reopen an order after completing it.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> CompleteAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Complete an order. Use only when an order doesn't need a shipment. You will not be able to ship or reopen an order after completing it.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> CompleteAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order;
		/// <summary>Create a new shipment containing all items on an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> ShipAsync(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null);
		/// <summary>Create a new shipment containing all items on an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> ShipAsync<TOrder>(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null) where TOrder : Order;
		/// <summary>List shipments for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>List shipments for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipment : Shipment;
		/// <summary>List shipments for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Shipment>> buildListOpts, string accessToken = null);
		/// <summary>List shipments for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TShipment>> buildListOpts, string accessToken = null) where TShipment : Shipment;
		/// <summary>Set a shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SetShippingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null);
		/// <summary>Set a shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SetShippingAddressAsync<TOrder>(OrderDirection direction, string orderID, Address address, string accessToken = null) where TOrder : Order;
		/// <summary>Partially update an order shipping address. Not allowed on unsubmitted orders where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchShippingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update an order shipping address. Not allowed on unsubmitted orders where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchShippingAddressAsync<TOrder>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) where TOrder : Order;
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SetBillingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null);
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> SetBillingAddressAsync<TOrder>(OrderDirection direction, string orderID, Address address, string accessToken = null) where TOrder : Order;
		/// <summary>Partially update an order billing address. Not allowed on unsubmitted orders where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchBillingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update an order billing address. Not allowed on unsubmitted orders where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchBillingAddressAsync<TOrder>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) where TOrder : Order;
		/// <summary>Update order FromUser. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchFromUserAsync(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null);
		/// <summary>Update order FromUser. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> PatchFromUserAsync<TOrder>(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null) where TOrder : Order;
		/// <summary>List eligible promotions. Get a list of promotions eligible for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListEligiblePromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>List eligible promotions. Get a list of promotions eligible for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion;
		/// <summary>List eligible promotions. Get a list of promotions eligible for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListEligiblePromotionsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null);
		/// <summary>List eligible promotions. Get a list of promotions eligible for an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Add a promotion to an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderPromotion> AddPromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null);
		/// <summary>Add a promotion to an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrderPromotion> AddPromotionAsync<TOrderPromotion>(OrderDirection direction, string orderID, string promoCode, string accessToken = null) where TOrderPromotion : OrderPromotion;
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderPromotion : OrderPromotion;
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderPromotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TOrderPromotion>> buildListOpts, string accessToken = null) where TOrderPromotion : OrderPromotion;
		/// <summary>Remove a promotion from an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> RemovePromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null);
		/// <summary>Remove a promotion from an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> RemovePromotionAsync<TOrder>(OrderDirection direction, string orderID, string promoCode, string accessToken = null) where TOrder : Order;
		/// <summary>AutoApply eligible promotions. Apply up to 100 eligible promotions to an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> ApplyPromotionsAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>AutoApply eligible promotions. Apply up to 100 eligible promotions to an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TOrder> ApplyPromotionsAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order;
		/// <summary>Validate an order in its current state.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ValidateAsync(OrderDirection direction, string orderID, string accessToken = null);
	}

	public interface IOrderSyncsResource
	{
		/// <summary>Get a single order sync.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderSyncConfig> GetAsync(string accessToken = null);
		/// <summary>Delete an order sync.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string accessToken = null);
		/// <summary>Create or update an order sync. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="orderSyncConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderSyncConfig> SaveAsync(OrderSyncConfig orderSyncConfig, string accessToken = null);
		/// <summary>Partially update an order sync.</summary>
		/// <param name="partialOrderSyncConfig">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<OrderSyncConfig> PatchAsync(PartialOrderSyncConfig partialOrderSyncConfig, string accessToken = null);
	}

	public interface IPaymentsResource
	{
		/// <summary>Get a single payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> GetAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null);
		/// <summary>Get a single payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> GetAsync<TPayment>(OrderDirection direction, string orderID, string paymentID, string accessToken = null) where TPayment : Payment;
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPayment>> ListAsync<TPayment>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPayment : Payment;
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Payment>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPayment>> ListAsync<TPayment>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TPayment>> buildListOpts, string accessToken = null) where TPayment : Payment;
		/// <summary>Create a new payment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="payment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> CreateAsync(OrderDirection direction, string orderID, Payment payment, string accessToken = null);
		/// <summary>Create a new payment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="payment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> CreateAsync<TPayment>(OrderDirection direction, string orderID, Payment payment, string accessToken = null) where TPayment : Payment;
		/// <summary>Delete a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null);
		/// <summary>Partially update a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="partialPayment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> PatchAsync(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null);
		/// <summary>Partially update a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="partialPayment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> PatchAsync<TPayment>(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null) where TPayment : Payment;
		/// <summary>Create a new payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="paymentTransaction">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> CreateTransactionAsync(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null);
		/// <summary>Create a new payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="paymentTransaction">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPayment> CreateTransactionAsync<TPayment>(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) where TPayment : Payment;
		/// <summary>Delete a payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing, all.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="transactionID">ID of the transaction.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteTransactionAsync(OrderDirection direction, string orderID, string paymentID, string transactionID, string accessToken = null);
	}

	public interface IPriceSchedulesResource
	{
		/// <summary>Get a single price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> GetAsync(string priceScheduleID, string accessToken = null);
		/// <summary>Get a single price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPriceSchedule> GetAsync<TPriceSchedule>(string priceScheduleID, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PriceSchedule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPriceSchedule>> ListAsync<TPriceSchedule>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PriceSchedule>> ListAsync(Action<ListOptionsBuilder<PriceSchedule>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPriceSchedule>> ListAsync<TPriceSchedule>(Action<ListOptionsBuilder<TPriceSchedule>> buildListOpts, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Create a new price schedule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> CreateAsync(PriceSchedule priceSchedule, string accessToken = null);
		/// <summary>Create a new price schedule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPriceSchedule> CreateAsync<TPriceSchedule>(PriceSchedule priceSchedule, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Create or update a price schedule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> SaveAsync(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null);
		/// <summary>Create or update a price schedule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPriceSchedule> SaveAsync<TPriceSchedule>(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Delete a price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string priceScheduleID, string accessToken = null);
		/// <summary>Partially update a price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="partialPriceSchedule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> PatchAsync(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null);
		/// <summary>Partially update a price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="partialPriceSchedule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPriceSchedule> PatchAsync<TPriceSchedule>(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Create or update a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceBreak">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> SavePriceBreakAsync(string priceScheduleID, PriceBreak priceBreak, string accessToken = null);
		/// <summary>Create or update a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceBreak">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPriceSchedule> SavePriceBreakAsync<TPriceSchedule>(string priceScheduleID, PriceBreak priceBreak, string accessToken = null) where TPriceSchedule : PriceSchedule;
		/// <summary>Delete a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="quantity">Quantity of the price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeletePriceBreakAsync(string priceScheduleID, int quantity, string accessToken = null);
	}

	public interface IProductCollectionsResource
	{
		/// <summary>Get a single product collection.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductCollection> GetAsync(string buyerID, string productCollectionID, string accessToken = null);
		/// <summary>Get a single product collection.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductCollection> GetAsync<TProductCollection>(string buyerID, string productCollectionID, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Get a list of product collections.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCollection>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product collections.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductCollection>> ListAsync<TProductCollection>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Get a list of product collections.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductCollection>> ListAsync(string buyerID, Action<ListOptionsBuilder<ProductCollection>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product collections.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductCollection>> ListAsync<TProductCollection>(string buyerID, Action<ListOptionsBuilder<TProductCollection>> buildListOpts, string accessToken = null) where TProductCollection : ProductCollection;
		/// <summary>Get a list of product collection entries.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<Product>> ListEntriesAsync(string buyerID, string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product collection entries.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TProduct>> ListEntriesAsync<TProduct>(string buyerID, string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProduct : Product;
		/// <summary>Get a list of product collection entries.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<Product>> ListEntriesAsync(string buyerID, string productCollectionID, Action<ListOptionsBuilder2<Product>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product collection entries.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="productCollectionID">ID of the product collection.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TProduct>> ListEntriesAsync<TProduct>(string buyerID, string productCollectionID, Action<ListOptionsBuilder2<TProduct>> buildListOpts, string accessToken = null) where TProduct : Product;
	}

	public interface IProductFacetsResource
	{
		/// <summary>Get a single product facet.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductFacet> GetAsync(string productFacetID, string accessToken = null);
		/// <summary>Get a single product facet.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductFacet> GetAsync<TProductFacet>(string productFacetID, string accessToken = null) where TProductFacet : ProductFacet;
		/// <summary>Get a list of product facets.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductFacet>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product facets.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductFacet>> ListAsync<TProductFacet>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductFacet : ProductFacet;
		/// <summary>Get a list of product facets.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductFacet>> ListAsync(Action<ListOptionsBuilder<ProductFacet>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product facets.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductFacet>> ListAsync<TProductFacet>(Action<ListOptionsBuilder<TProductFacet>> buildListOpts, string accessToken = null) where TProductFacet : ProductFacet;
		/// <summary>Create a new product facet. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="productFacet">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductFacet> CreateAsync(ProductFacet productFacet, string accessToken = null);
		/// <summary>Create a new product facet. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="productFacet">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductFacet> CreateAsync<TProductFacet>(ProductFacet productFacet, string accessToken = null) where TProductFacet : ProductFacet;
		/// <summary>Create or update a product facet. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="productFacet">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductFacet> SaveAsync(string productFacetID, ProductFacet productFacet, string accessToken = null);
		/// <summary>Create or update a product facet. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="productFacet">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductFacet> SaveAsync<TProductFacet>(string productFacetID, ProductFacet productFacet, string accessToken = null) where TProductFacet : ProductFacet;
		/// <summary>Delete a product facet.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string productFacetID, string accessToken = null);
		/// <summary>Partially update a product facet.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="partialProductFacet">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductFacet> PatchAsync(string productFacetID, PartialProductFacet partialProductFacet, string accessToken = null);
		/// <summary>Partially update a product facet.</summary>
		/// <param name="productFacetID">ID of the product facet.</param>
		/// <param name="partialProductFacet">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProductFacet> PatchAsync<TProductFacet>(string productFacetID, PartialProductFacet partialProductFacet, string accessToken = null) where TProductFacet : ProductFacet;
	}

	public interface IProductsResource
	{
		/// <summary>Get a single product.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> GetAsync(string productID, string accessToken = null);
		/// <summary>Get a single product.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProduct> GetAsync<TProduct>(string productID, string accessToken = null) where TProduct : Product;
		/// <summary>Get a list of products.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<Product>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of products.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="searchType">Type of search to perform. Possible values: AnyTerm (default), AllTermsAnyField, AllTermsSameField, ExactPhrase, ExactPhrasePrefix.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TProduct>> ListAsync<TProduct>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProduct : Product;
		/// <summary>Get a list of products.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<Product>> ListAsync(Action<ListOptionsBuilder2<Product>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null);
		/// <summary>Get a list of products.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPageWithFacets<TProduct>> ListAsync<TProduct>(Action<ListOptionsBuilder2<TProduct>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) where TProduct : Product;
		/// <summary>Create a new product. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> CreateAsync(Product product, string accessToken = null);
		/// <summary>Create a new product. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProduct> CreateAsync<TProduct>(Product product, string accessToken = null) where TProduct : Product;
		/// <summary>Create or update a product. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> SaveAsync(string productID, Product product, string accessToken = null);
		/// <summary>Create or update a product. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProduct> SaveAsync<TProduct>(string productID, Product product, string accessToken = null) where TProduct : Product;
		/// <summary>Delete a product.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string productID, string accessToken = null);
		/// <summary>Partially update a product.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="partialProduct">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> PatchAsync(string productID, PartialProduct partialProduct, string accessToken = null);
		/// <summary>Partially update a product.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="partialProduct">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProduct> PatchAsync<TProduct>(string productID, PartialProduct partialProduct, string accessToken = null) where TProduct : Product;
		/// <summary>Generate variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="overwriteExisting">Overwrite existing of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> GenerateVariantsAsync(string productID, bool overwriteExisting = false, string accessToken = null);
		/// <summary>Generate variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="overwriteExisting">Overwrite existing of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TProduct> GenerateVariantsAsync<TProduct>(string productID, bool overwriteExisting = false, string accessToken = null) where TProduct : Product;
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TVariant : Variant;
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, Action<ListOptionsBuilder<Variant>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, Action<ListOptionsBuilder<TVariant>> buildListOpts, string accessToken = null) where TVariant : Variant;
		/// <summary>Update a product variant. Update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="variant">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> SaveVariantAsync(string productID, string variantID, Variant variant, string accessToken = null);
		/// <summary>Update a product variant. Update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="variant">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TVariant> SaveVariantAsync<TVariant>(string productID, string variantID, Variant variant, string accessToken = null) where TVariant : Variant;
		/// <summary>Partially update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="partialVariant">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> PatchVariantAsync(string productID, string variantID, PartialVariant partialVariant, string accessToken = null);
		/// <summary>Partially update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="partialVariant">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TVariant> PatchVariantAsync<TVariant>(string productID, string variantID, PartialVariant partialVariant, string accessToken = null) where TVariant : Variant;
		/// <summary>Get a single product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> GetVariantAsync(string productID, string variantID, string accessToken = null);
		/// <summary>Get a single product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TVariant> GetVariantAsync<TVariant>(string productID, string variantID, string accessToken = null) where TVariant : Variant;
		/// <summary>Get a list of product specs.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListSpecsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product specs.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of product specs.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListSpecsAsync(string productID, Action<ListOptionsBuilder<Spec>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product specs.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, Action<ListOptionsBuilder<TSpec>> buildListOpts, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductSupplier>> ListSuppliersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductSupplier>> ListSuppliersAsync<TProductSupplier>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductSupplier : ProductSupplier;
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductSupplier>> ListSuppliersAsync(string productID, Action<ListOptionsBuilder<ProductSupplier>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TProductSupplier>> ListSuppliersAsync<TProductSupplier>(string productID, Action<ListOptionsBuilder<TProductSupplier>> buildListOpts, string accessToken = null) where TProductSupplier : ProductSupplier;
		/// <summary>Create or update a product supplier.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="defaultPriceScheduleID">ID of the default price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveSupplierAsync(string productID, string supplierID, string defaultPriceScheduleID = null, string accessToken = null);
		/// <summary>Remove a product supplier.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task RemoveSupplierAsync(string productID, string supplierID, string accessToken = null);
		/// <summary>Create or update a product assignment.</summary>
		/// <param name="productAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(ProductAssignment productAssignment, string accessToken = null);
		/// <summary>Get a list of product assignments.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the product assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductAssignment>> ListAssignmentsAsync(string productID = null, string priceScheduleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a product assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="sellerID">ID of the seller.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string productID, string buyerID, string userID = null, string userGroupID = null, string sellerID = null, string accessToken = null);
	}

	public interface IProductSyncsResource
	{
		/// <summary>Get a single product sync.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductSyncConfig> GetAsync(string accessToken = null);
		/// <summary>Delete a product sync.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string accessToken = null);
		/// <summary>Create or update a product sync. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productSyncConfig">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductSyncConfig> SaveAsync(ProductSyncConfig productSyncConfig, string accessToken = null);
		/// <summary>Partially update a product sync.</summary>
		/// <param name="partialProductSyncConfig">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ProductSyncConfig> PatchAsync(PartialProductSyncConfig partialProductSyncConfig, string accessToken = null);
	}

	public interface IPromotionsResource
	{
		/// <summary>Get a single promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> GetAsync(string promotionID, string accessToken = null);
		/// <summary>Get a single promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPromotion> GetAsync<TPromotion>(string promotionID, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Get a list of promotions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of promotions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListAsync<TPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Get a list of promotions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of promotions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TPromotion>> ListAsync<TPromotion>(Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Create a new promotion. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> CreateAsync(Promotion promotion, string accessToken = null);
		/// <summary>Create a new promotion. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPromotion> CreateAsync<TPromotion>(Promotion promotion, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Create or update a promotion. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> SaveAsync(string promotionID, Promotion promotion, string accessToken = null);
		/// <summary>Create or update a promotion. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPromotion> SaveAsync<TPromotion>(string promotionID, Promotion promotion, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Delete a promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string promotionID, string accessToken = null);
		/// <summary>Partially update a promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="partialPromotion">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> PatchAsync(string promotionID, PartialPromotion partialPromotion, string accessToken = null);
		/// <summary>Partially update a promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="partialPromotion">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TPromotion> PatchAsync<TPromotion>(string promotionID, PartialPromotion partialPromotion, string accessToken = null) where TPromotion : Promotion;
		/// <summary>Get a list of promotion assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the promotion assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PromotionAssignment>> ListAssignmentsAsync(string buyerID = null, string promotionID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update a promotion assignment.</summary>
		/// <param name="promotionAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(PromotionAssignment promotionAssignment, string accessToken = null);
		/// <summary>Delete a promotion assignment.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string promotionID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null);
	}

	public interface ISecurityProfilesResource
	{
		/// <summary>Get a single security profile.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SecurityProfile> GetAsync(string securityProfileID, string accessToken = null);
		/// <summary>Get a list of security profiles.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SecurityProfile>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of security profiles.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SecurityProfile>> ListAsync(Action<ListOptionsBuilder<SecurityProfile>> buildListOpts, string accessToken = null);
		/// <summary>Create a new security profile. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="securityProfile">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SecurityProfile> CreateAsync(SecurityProfile securityProfile, string accessToken = null);
		/// <summary>Create or update a security profile. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="securityProfile">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SecurityProfile> SaveAsync(string securityProfileID, SecurityProfile securityProfile, string accessToken = null);
		/// <summary>Delete a security profile.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string securityProfileID, string accessToken = null);
		/// <summary>Partially update a security profile.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="partialSecurityProfile">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SecurityProfile> PatchAsync(string securityProfileID, PartialSecurityProfile partialSecurityProfile, string accessToken = null);
		/// <summary>Get a list of security profile assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="commerceRole">Commerce role of the security profile assignment. Possible values: Buyer, Seller, Supplier.</param>
		/// <param name="level">Level of the security profile assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SecurityProfileAssignment>> ListAssignmentsAsync(string buyerID = null, string supplierID = null, string securityProfileID = null, string userID = null, string userGroupID = null, CommerceRole? commerceRole = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a security profile assignment.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string securityProfileID, string buyerID = null, string userID = null, string userGroupID = null, string supplierID = null, string accessToken = null);
		/// <summary>Create or update a security profile assignment.</summary>
		/// <param name="securityProfileAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(SecurityProfileAssignment securityProfileAssignment, string accessToken = null);
	}

	public interface ISellerApprovalRulesResource
	{
		/// <summary>Get a single seller approval rule.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SellerApprovalRule> GetAsync(string approvalRuleID, string accessToken = null);
		/// <summary>Get a single seller approval rule.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSellerApprovalRule> GetAsync<TSellerApprovalRule>(string approvalRuleID, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule;
		/// <summary>Get a list of seller approval rules.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SellerApprovalRule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of seller approval rules.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSellerApprovalRule>> ListAsync<TSellerApprovalRule>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule;
		/// <summary>Get a list of seller approval rules.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SellerApprovalRule>> ListAsync(Action<ListOptionsBuilder<SellerApprovalRule>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of seller approval rules.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSellerApprovalRule>> ListAsync<TSellerApprovalRule>(Action<ListOptionsBuilder<TSellerApprovalRule>> buildListOpts, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule;
		/// <summary>Create a new seller approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="sellerApprovalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SellerApprovalRule> CreateAsync(SellerApprovalRule sellerApprovalRule, string accessToken = null);
		/// <summary>Create a new seller approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="sellerApprovalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSellerApprovalRule> CreateAsync<TSellerApprovalRule>(SellerApprovalRule sellerApprovalRule, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule;
		/// <summary>Create or update a seller approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="sellerApprovalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SellerApprovalRule> SaveAsync(string approvalRuleID, SellerApprovalRule sellerApprovalRule, string accessToken = null);
		/// <summary>Create or update a seller approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="sellerApprovalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSellerApprovalRule> SaveAsync<TSellerApprovalRule>(string approvalRuleID, SellerApprovalRule sellerApprovalRule, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule;
		/// <summary>Delete a seller approval rule.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string approvalRuleID, string accessToken = null);
		/// <summary>Partially update a seller approval rule.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="partialSellerApprovalRule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SellerApprovalRule> PatchAsync(string approvalRuleID, PartialSellerApprovalRule partialSellerApprovalRule, string accessToken = null);
		/// <summary>Partially update a seller approval rule.</summary>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="partialSellerApprovalRule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSellerApprovalRule> PatchAsync<TSellerApprovalRule>(string approvalRuleID, PartialSellerApprovalRule partialSellerApprovalRule, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule;
	}

	public interface IShipmentsResource
	{
		/// <summary>Get a single shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> GetAsync(string shipmentID, string accessToken = null);
		/// <summary>Get a single shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> GetAsync<TShipment>(string shipmentID, string accessToken = null) where TShipment : Shipment;
		/// <summary>Get a list of shipments.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipments.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipment>> ListAsync<TShipment>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipment : Shipment;
		/// <summary>Get a list of shipments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a list of shipments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipment>> ListAsync<TShipment>(Action<ListOptionsBuilder<TShipment>> buildListOpts, string orderID = null, string accessToken = null) where TShipment : Shipment;
		/// <summary>Create a new shipment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> CreateAsync(Shipment shipment, string accessToken = null);
		/// <summary>Create a new shipment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> CreateAsync<TShipment>(Shipment shipment, string accessToken = null) where TShipment : Shipment;
		/// <summary>Create or update a shipment. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> SaveAsync(string shipmentID, Shipment shipment, string accessToken = null);
		/// <summary>Create or update a shipment. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> SaveAsync<TShipment>(string shipmentID, Shipment shipment, string accessToken = null) where TShipment : Shipment;
		/// <summary>Delete a shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string shipmentID, string accessToken = null);
		/// <summary>Partially update a shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="partialShipment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> PatchAsync(string shipmentID, PartialShipment partialShipment, string accessToken = null);
		/// <summary>Partially update a shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="partialShipment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> PatchAsync<TShipment>(string shipmentID, PartialShipment partialShipment, string accessToken = null) where TShipment : Shipment;
		/// <summary>Set a ship to address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the shipment's ToAddressID property instead.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> SetShipToAddressAsync(string shipmentID, Address address, string accessToken = null);
		/// <summary>Set a ship to address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the shipment's ToAddressID property instead.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> SetShipToAddressAsync<TShipment>(string shipmentID, Address address, string accessToken = null) where TShipment : Shipment;
		/// <summary>Set a ship from address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the shipment's FromAddressID property instead.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> SetShipFromAddressAsync(string shipmentID, Address address, string accessToken = null);
		/// <summary>Set a ship from address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the shipment's FromAddressID property instead.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipment> SetShipFromAddressAsync<TShipment>(string shipmentID, Address address, string accessToken = null) where TShipment : Shipment;
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipmentItem>> ListItemsAsync<TShipmentItem>(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipmentItem : ShipmentItem;
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TShipmentItem>> ListItemsAsync<TShipmentItem>(string shipmentID, Action<ListOptionsBuilder<TShipmentItem>> buildListOpts, string accessToken = null) where TShipmentItem : ShipmentItem;
		/// <summary>Get a single shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ShipmentItem> GetItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Get a single shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipmentItem> GetItemAsync<TShipmentItem>(string shipmentID, string orderID, string lineItemID, string accessToken = null) where TShipmentItem : ShipmentItem;
		/// <summary>Create or update a shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipmentItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ShipmentItem> SaveItemAsync(string shipmentID, ShipmentItem shipmentItem, string accessToken = null);
		/// <summary>Create or update a shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipmentItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TShipmentItem> SaveItemAsync<TShipmentItem>(string shipmentID, ShipmentItem shipmentItem, string accessToken = null) where TShipmentItem : ShipmentItem;
		/// <summary>Delete a shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null);
	}

	public interface ISpecsResource
	{
		/// <summary>Get a single spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> GetAsync(string specID, string accessToken = null);
		/// <summary>Get a single spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpec> GetAsync<TSpec>(string specID, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of specs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of specs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpec>> ListAsync<TSpec>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of specs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListAsync(Action<ListOptionsBuilder<Spec>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of specs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpec>> ListAsync<TSpec>(Action<ListOptionsBuilder<TSpec>> buildListOpts, string accessToken = null) where TSpec : Spec;
		/// <summary>Create a new spec. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> CreateAsync(Spec spec, string accessToken = null);
		/// <summary>Create a new spec. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpec> CreateAsync<TSpec>(Spec spec, string accessToken = null) where TSpec : Spec;
		/// <summary>Create or update a spec. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> SaveAsync(string specID, Spec spec, string accessToken = null);
		/// <summary>Create or update a spec. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpec> SaveAsync<TSpec>(string specID, Spec spec, string accessToken = null) where TSpec : Spec;
		/// <summary>Delete a spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string specID, string accessToken = null);
		/// <summary>Partially update a spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="partialSpec">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> PatchAsync(string specID, PartialSpec partialSpec, string accessToken = null);
		/// <summary>Partially update a spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="partialSpec">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpec> PatchAsync<TSpec>(string specID, PartialSpec partialSpec, string accessToken = null) where TSpec : Spec;
		/// <summary>Get a list of spec product assignments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spec product assignments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(Action<ListOptionsBuilder<SpecProductAssignment>> buildListOpts, string accessToken = null);
		/// <summary>Delete a spec product assignment.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteProductAssignmentAsync(string specID, string productID, string accessToken = null);
		/// <summary>Create or update a spec product assignment.</summary>
		/// <param name="specProductAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveProductAssignmentAsync(SpecProductAssignment specProductAssignment, string accessToken = null);
		/// <summary>Create a new spec option. A Spec can have multiple Options-- for example, if the spec is called 'Color', the options might be 'Blue', 'Red', and 'Green'. </summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> CreateOptionAsync(string specID, SpecOption specOption, string accessToken = null);
		/// <summary>Create a new spec option. A Spec can have multiple Options-- for example, if the spec is called 'Color', the options might be 'Blue', 'Red', and 'Green'. </summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpecOption> CreateOptionAsync<TSpecOption>(string specID, SpecOption specOption, string accessToken = null) where TSpecOption : SpecOption;
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecOption>> ListOptionsAsync(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpecOption>> ListOptionsAsync<TSpecOption>(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpecOption : SpecOption;
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecOption>> ListOptionsAsync(string specID, Action<ListOptionsBuilder<SpecOption>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpecOption>> ListOptionsAsync<TSpecOption>(string specID, Action<ListOptionsBuilder<TSpecOption>> buildListOpts, string accessToken = null) where TSpecOption : SpecOption;
		/// <summary>Create or update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> SaveOptionAsync(string specID, string optionID, SpecOption specOption, string accessToken = null);
		/// <summary>Create or update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpecOption> SaveOptionAsync<TSpecOption>(string specID, string optionID, SpecOption specOption, string accessToken = null) where TSpecOption : SpecOption;
		/// <summary>Partially update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="partialSpecOption">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> PatchOptionAsync(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null);
		/// <summary>Partially update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="partialSpecOption">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpecOption> PatchOptionAsync<TSpecOption>(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null) where TSpecOption : SpecOption;
		/// <summary>Get a single spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> GetOptionAsync(string specID, string optionID, string accessToken = null);
		/// <summary>Get a single spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpecOption> GetOptionAsync<TSpecOption>(string specID, string optionID, string accessToken = null) where TSpecOption : SpecOption;
		/// <summary>Delete a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteOptionAsync(string specID, string optionID, string accessToken = null);
	}

	public interface ISpendingAccountsResource
	{
		/// <summary>Get a single spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> GetAsync(string buyerID, string spendingAccountID, string accessToken = null);
		/// <summary>Get a single spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpendingAccount> GetAsync<TSpendingAccount>(string buyerID, string spendingAccountID, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpendingAccount>> ListAsync<TSpendingAccount>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListAsync(string buyerID, Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSpendingAccount>> ListAsync<TSpendingAccount>(string buyerID, Action<ListOptionsBuilder<TSpendingAccount>> buildListOpts, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Create a new spending account. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> CreateAsync(string buyerID, SpendingAccount spendingAccount, string accessToken = null);
		/// <summary>Create a new spending account. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpendingAccount> CreateAsync<TSpendingAccount>(string buyerID, SpendingAccount spendingAccount, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Create or update a spending account. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> SaveAsync(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null);
		/// <summary>Create or update a spending account. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpendingAccount> SaveAsync<TSpendingAccount>(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Delete a spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string spendingAccountID, string accessToken = null);
		/// <summary>Partially update a spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="partialSpendingAccount">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> PatchAsync(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null);
		/// <summary>Partially update a spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="partialSpendingAccount">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSpendingAccount> PatchAsync<TSpendingAccount>(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null) where TSpendingAccount : SpendingAccount;
		/// <summary>Get a list of spending account assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the spending account assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccountAssignment>> ListAssignmentsAsync(string buyerID, string spendingAccountID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Create or update a spending account assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(string buyerID, SpendingAccountAssignment spendingAccountAssignment, string accessToken = null);
		/// <summary>Delete a spending account assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string buyerID, string spendingAccountID, string userID = null, string userGroupID = null, string accessToken = null);
	}

	public interface ISubscriptionIntegrationsResource
	{
		/// <summary>Get a single subscription integration.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SubscriptionIntegration> GetAsync(string accessToken = null);
		/// <summary>Get a single subscription integration.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscriptionIntegration> GetAsync<TSubscriptionIntegration>(string accessToken = null) where TSubscriptionIntegration : SubscriptionIntegration;
		/// <summary>Delete a subscription integration.</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string accessToken = null);
		/// <summary>Create or update a subscription integration. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="subscriptionIntegration">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SubscriptionIntegration> SaveAsync(SubscriptionIntegration subscriptionIntegration, string accessToken = null);
		/// <summary>Create or update a subscription integration. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="subscriptionIntegration">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscriptionIntegration> SaveAsync<TSubscriptionIntegration>(SubscriptionIntegration subscriptionIntegration, string accessToken = null) where TSubscriptionIntegration : SubscriptionIntegration;
		/// <summary>Partially update a subscription integration.</summary>
		/// <param name="partialSubscriptionIntegration">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SubscriptionIntegration> PatchAsync(PartialSubscriptionIntegration partialSubscriptionIntegration, string accessToken = null);
		/// <summary>Partially update a subscription integration.</summary>
		/// <param name="partialSubscriptionIntegration">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscriptionIntegration> PatchAsync<TSubscriptionIntegration>(PartialSubscriptionIntegration partialSubscriptionIntegration, string accessToken = null) where TSubscriptionIntegration : SubscriptionIntegration;
	}

	public interface ISubscriptionItemsResource
	{
		/// <summary>Get a single subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> GetAsync(string subscriptionID, string subscriptionItemID, string accessToken = null);
		/// <summary>Get a single subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> GetAsync<TLineItem>(string subscriptionID, string subscriptionItemID, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of subscription items.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListAsync(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of subscription items.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListAsync<TLineItem>(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Get a list of subscription items.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListAsync(string subscriptionID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of subscription items.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TLineItem>> ListAsync<TLineItem>(string subscriptionID, Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create a new subscription item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateAsync(string subscriptionID, LineItem lineItem, string accessToken = null);
		/// <summary>Create a new subscription item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> CreateAsync<TLineItem>(string subscriptionID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Create or update a subscription item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SaveAsync(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null);
		/// <summary>Create or update a subscription item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> SaveAsync<TLineItem>(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem;
		/// <summary>Delete a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string subscriptionID, string subscriptionItemID, string accessToken = null);
		/// <summary>Partially update a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchAsync(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null);
		/// <summary>Partially update a subscription item.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscriptionItemID">ID of the subscription item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TLineItem> PatchAsync<TLineItem>(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem;
	}

	public interface ISubscriptionsResource
	{
		/// <summary>Get a single subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> GetAsync(string subscriptionID, string accessToken = null);
		/// <summary>Get a single subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> GetAsync<TSubscription>(string subscriptionID, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Get a list of subscriptions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Subscription>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of subscriptions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSubscription>> ListAsync<TSubscription>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Get a list of subscriptions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Subscription>> ListAsync(Action<ListOptionsBuilder<Subscription>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of subscriptions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSubscription>> ListAsync<TSubscription>(Action<ListOptionsBuilder<TSubscription>> buildListOpts, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Create a new subscription. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> CreateAsync(Subscription subscription, string accessToken = null);
		/// <summary>Create a new subscription. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> CreateAsync<TSubscription>(Subscription subscription, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Create or update a subscription. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> SaveAsync(string subscriptionID, Subscription subscription, string accessToken = null);
		/// <summary>Create or update a subscription. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="subscription">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> SaveAsync<TSubscription>(string subscriptionID, Subscription subscription, string accessToken = null) where TSubscription : Subscription;
		/// <summary>Delete a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string subscriptionID, string accessToken = null);
		/// <summary>Partially update a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="partialSubscription">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Subscription> PatchAsync(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null);
		/// <summary>Partially update a subscription.</summary>
		/// <param name="subscriptionID">ID of the subscription.</param>
		/// <param name="partialSubscription">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSubscription> PatchAsync<TSubscription>(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null) where TSubscription : Subscription;
	}

	public interface ISupplierAddressesResource
	{
		/// <summary>Get a single supplier address.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> GetAsync(string supplierID, string addressID, string accessToken = null);
		/// <summary>Get a single supplier address.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> GetAsync<TAddress>(string supplierID, string addressID, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of supplier addresses.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier addresses.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TAddress>> ListAsync<TAddress>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TAddress : Address;
		/// <summary>Get a list of supplier addresses.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string supplierID, Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of supplier addresses.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TAddress>> ListAsync<TAddress>(string supplierID, Action<ListOptionsBuilder<TAddress>> buildListOpts, string accessToken = null) where TAddress : Address;
		/// <summary>Create a new supplier address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> CreateAsync(string supplierID, Address address, string accessToken = null);
		/// <summary>Create a new supplier address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> CreateAsync<TAddress>(string supplierID, Address address, string accessToken = null) where TAddress : Address;
		/// <summary>Create or update a supplier address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> SaveAsync(string supplierID, string addressID, Address address, string accessToken = null);
		/// <summary>Create or update a supplier address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> SaveAsync<TAddress>(string supplierID, string addressID, Address address, string accessToken = null) where TAddress : Address;
		/// <summary>Delete a supplier address.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string supplierID, string addressID, string accessToken = null);
		/// <summary>Partially update a supplier address.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> PatchAsync(string supplierID, string addressID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update a supplier address.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TAddress> PatchAsync<TAddress>(string supplierID, string addressID, PartialAddress partialAddress, string accessToken = null) where TAddress : Address;
	}

	public interface ISuppliersResource
	{
		/// <summary>Get a single supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> GetAsync(string supplierID, string accessToken = null);
		/// <summary>Get a single supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSupplier> GetAsync<TSupplier>(string supplierID, string accessToken = null) where TSupplier : Supplier;
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSupplier>> ListAsync<TSupplier>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSupplier : Supplier;
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier>> ListAsync(Action<ListOptionsBuilder<Supplier>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TSupplier>> ListAsync<TSupplier>(Action<ListOptionsBuilder<TSupplier>> buildListOpts, string accessToken = null) where TSupplier : Supplier;
		/// <summary>Create a new supplier. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> CreateAsync(Supplier supplier, string accessToken = null);
		/// <summary>Create a new supplier. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSupplier> CreateAsync<TSupplier>(Supplier supplier, string accessToken = null) where TSupplier : Supplier;
		/// <summary>Delete a supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string supplierID, string accessToken = null);
		/// <summary>Create or update a supplier. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> SaveAsync(string supplierID, Supplier supplier, string accessToken = null);
		/// <summary>Create or update a supplier. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSupplier> SaveAsync<TSupplier>(string supplierID, Supplier supplier, string accessToken = null) where TSupplier : Supplier;
		/// <summary>Partially update a supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="partialSupplier">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> PatchAsync(string supplierID, PartialSupplier partialSupplier, string accessToken = null);
		/// <summary>Partially update a supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="partialSupplier">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TSupplier> PatchAsync<TSupplier>(string supplierID, PartialSupplier partialSupplier, string accessToken = null) where TSupplier : Supplier;
		/// <summary>Get a list of supplier buyers.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SupplierBuyer>> ListBuyersAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier buyers.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SupplierBuyer>> ListBuyersAsync(string supplierID, Action<ListOptionsBuilder<SupplierBuyer>> buildListOpts, string accessToken = null);
		/// <summary>Create or update a supplier buyer.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveBuyerAsync(string supplierID, string buyerID, string accessToken = null);
		/// <summary>Delete a supplier buyer.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteBuyerAsync(string supplierID, string buyerID, string accessToken = null);
	}

	public interface ISupplierUserGroupsResource
	{
		/// <summary>Get a single supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> GetAsync(string supplierID, string userGroupID, string accessToken = null);
		/// <summary>Get a single supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> GetAsync<TUserGroup>(string supplierID, string userGroupID, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string supplierID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string supplierID, Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Create a new supplier user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> CreateAsync(string supplierID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create a new supplier user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> CreateAsync<TUserGroup>(string supplierID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Create or update a supplier user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> SaveAsync(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update a supplier user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> SaveAsync<TUserGroup>(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Delete a supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string supplierID, string userGroupID, string accessToken = null);
		/// <summary>Partially update a supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> PatchAsync(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null);
		/// <summary>Partially update a supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> PatchAsync<TUserGroup>(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of supplier user group user assignments.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string supplierID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Delete a supplier user group user assignment.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteUserAssignmentAsync(string supplierID, string userGroupID, string userID, string accessToken = null);
		/// <summary>Create or update a supplier user group user assignment.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveUserAssignmentAsync(string supplierID, UserGroupAssignment userGroupAssignment, string accessToken = null);
	}

	public interface ISupplierUsersResource
	{
		/// <summary>Get a single supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> GetAsync(string supplierID, string userID, string accessToken = null);
		/// <summary>Get a single supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> GetAsync<TUser>(string supplierID, string userID, string accessToken = null) where TUser : User;
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAsync<TUser>(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User;
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string supplierID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null);
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAsync<TUser>(string supplierID, Action<ListOptionsBuilder<TUser>> buildListOpts, string userGroupID = null, string accessToken = null) where TUser : User;
		/// <summary>Create a new supplier user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> CreateAsync(string supplierID, User user, string accessToken = null);
		/// <summary>Create a new supplier user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> CreateAsync<TUser>(string supplierID, User user, string accessToken = null) where TUser : User;
		/// <summary>Create or update a supplier user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> SaveAsync(string supplierID, string userID, User user, string accessToken = null);
		/// <summary>Create or update a supplier user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> SaveAsync<TUser>(string supplierID, string userID, User user, string accessToken = null) where TUser : User;
		/// <summary>Delete a supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string supplierID, string userID, string accessToken = null);
		/// <summary>Partially update a supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> PatchAsync(string supplierID, string userID, PartialUser partialUser, string accessToken = null);
		/// <summary>Partially update a supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> PatchAsync<TUser>(string supplierID, string userID, PartialUser partialUser, string accessToken = null) where TUser : User;
	}

	public interface ITrackingEventsResource
	{
		/// <summary>Get a single tracking event.</summary>
		/// <param name="eventID">ID of the event.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TrackingEvent> GetAsync(string eventID, string accessToken = null);
		/// <summary>Get a list of tracking events.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TrackingEvent>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of tracking events.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TrackingEvent>> ListAsync(Action<ListOptionsBuilder<TrackingEvent>> buildListOpts, string accessToken = null);
		/// <summary>Create a new tracking event. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="trackingEvent">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TrackingEvent> CreateAsync(TrackingEvent trackingEvent, string accessToken = null);
		/// <summary>Create or update a tracking event. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="eventID">ID of the event.</param>
		/// <param name="trackingEvent">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TrackingEvent> SaveAsync(string eventID, TrackingEvent trackingEvent, string accessToken = null);
		/// <summary>Delete a tracking event.</summary>
		/// <param name="eventID">ID of the event.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string eventID, string accessToken = null);
		/// <summary>Partially update a tracking event.</summary>
		/// <param name="eventID">ID of the event.</param>
		/// <param name="partialTrackingEvent">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TrackingEvent> PatchAsync(string eventID, PartialTrackingEvent partialTrackingEvent, string accessToken = null);
	}

	public interface IUserGroupsResource
	{
		/// <summary>Get a single user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> GetAsync(string buyerID, string userGroupID, string accessToken = null);
		/// <summary>Get a single user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> GetAsync<TUserGroup>(string buyerID, string userGroupID, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string buyerID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string buyerID, Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Create a new user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> CreateAsync(string buyerID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create a new user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> CreateAsync<TUserGroup>(string buyerID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Create or update a user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> SaveAsync(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update a user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> SaveAsync<TUserGroup>(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Delete a user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string userGroupID, string accessToken = null);
		/// <summary>Partially update a user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> PatchAsync(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null);
		/// <summary>Partially update a user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUserGroup> PatchAsync<TUserGroup>(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) where TUserGroup : UserGroup;
		/// <summary>Get a list of user group user assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string buyerID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null);
		/// <summary>Delete a user group user assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteUserAssignmentAsync(string buyerID, string userGroupID, string userID, string accessToken = null);
		/// <summary>Create or update a user group user assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveUserAssignmentAsync(string buyerID, UserGroupAssignment userGroupAssignment, string accessToken = null);
	}

	public interface IUsersResource
	{
		/// <summary>Get a single user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> GetAsync(string buyerID, string userID, string accessToken = null);
		/// <summary>Get a single user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> GetAsync<TUser>(string buyerID, string userID, string accessToken = null) where TUser : User;
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAsync<TUser>(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User;
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string buyerID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null);
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAsync<TUser>(string buyerID, Action<ListOptionsBuilder<TUser>> buildListOpts, string userGroupID = null, string accessToken = null) where TUser : User;
		/// <summary>Create a new user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> CreateAsync(string buyerID, User user, string accessToken = null);
		/// <summary>Create a new user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> CreateAsync<TUser>(string buyerID, User user, string accessToken = null) where TUser : User;
		/// <summary>Create or update a user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> SaveAsync(string buyerID, string userID, User user, string accessToken = null);
		/// <summary>Create or update a user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> SaveAsync<TUser>(string buyerID, string userID, User user, string accessToken = null) where TUser : User;
		/// <summary>Delete a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string userID, string accessToken = null);
		/// <summary>Get a list of user across buyers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAcrossBuyersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user across buyers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAcrossBuyersAsync<TUser>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User;
		/// <summary>Get a list of user across buyers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAcrossBuyersAsync(Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of user across buyers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<TUser>> ListAcrossBuyersAsync<TUser>(Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User;
		/// <summary>Partially update a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> PatchAsync(string buyerID, string userID, PartialUser partialUser, string accessToken = null);
		/// <summary>Partially update a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> PatchAsync<TUser>(string buyerID, string userID, PartialUser partialUser, string accessToken = null) where TUser : User;
		/// <summary>Move a user to a different buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="newBuyerID">ID of the new buyer.</param>
		/// <param name="orders">Orders of the user. Possible values: None, Unsubmitted, All.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> MoveAsync(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null);
		/// <summary>Move a user to a different buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="newBuyerID">ID of the new buyer.</param>
		/// <param name="orders">Orders of the user. Possible values: None, Unsubmitted, All.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<TUser> MoveAsync<TUser>(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null) where TUser : User;
		/// <summary>Get a single user access token.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="impersonateTokenRequest">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<AccessToken> GetAccessTokenAsync(string buyerID, string userID, ImpersonateTokenRequest impersonateTokenRequest, string accessToken = null);
	}

	public interface IWebhooksResource
	{
		/// <summary>Get a single webhook.</summary>
		/// <param name="webhookID">ID of the webhook.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Webhook> GetAsync(string webhookID, string accessToken = null);
		/// <summary>Get a list of webhooks.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Webhook>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of webhooks.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Webhook>> ListAsync(Action<ListOptionsBuilder<Webhook>> buildListOpts, string accessToken = null);
		/// <summary>Create a new webhook. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="webhook">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Webhook> CreateAsync(Webhook webhook, string accessToken = null);
		/// <summary>Create or update a webhook. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="webhookID">ID of the webhook.</param>
		/// <param name="webhook">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Webhook> SaveAsync(string webhookID, Webhook webhook, string accessToken = null);
		/// <summary>Delete a webhook.</summary>
		/// <param name="webhookID">ID of the webhook.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string webhookID, string accessToken = null);
		/// <summary>Partially update a webhook.</summary>
		/// <param name="webhookID">ID of the webhook.</param>
		/// <param name="partialWebhook">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Webhook> PatchAsync(string webhookID, PartialWebhook partialWebhook, string accessToken = null);
	}

	public interface IXpIndicesResource
	{
		/// <summary>Get a list of XP indices.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1. When paginating through many items (> page 30), we recommend the "Last ID" method, as outlined in the Advanced Querying documentation.</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">An object or dictionary representing key/value pairs to apply as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<XpIndex>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of XP indices.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<XpIndex>> ListAsync(Action<ListOptionsBuilder<XpIndex>> buildListOpts, string accessToken = null);
		/// <summary>Delete a XP index.</summary>
		/// <param name="thingType">Thing type of the xp index. Possible values: Address, Variant, Order, OrderReturn, LineItem, CostCenter, CreditCard, Payment, Spec, SpecOption, UserGroup, Company, Category, PriceSchedule, Shipment, SpendingAccount, User, Promotion, ApprovalRule, SellerApprovalRule, Catalog, ProductFacet, MessageSender, InventoryRecord, ProductCollection, Subscription.</param>
		/// <param name="key">Key of the xp index.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(XpThingType thingType, string key, string accessToken = null);
		/// <summary>Create or Update an XP index.</summary>
		/// <param name="xpIndex">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task PutAsync(XpIndex xpIndex, string accessToken = null);
	}

	public partial class OrderCloudClient : IOrderCloudClient
	{
		private void InitResources() {
			Addresses = new AddressesResource(this);
			AdminAddresses = new AdminAddressesResource(this);
			AdminUserGroups = new AdminUserGroupsResource(this);
			AdminUsers = new AdminUsersResource(this);
			ApiClients = new ApiClientsResource(this);
			ApprovalRules = new ApprovalRulesResource(this);
			BundleLineItems = new BundleLineItemsResource(this);
			Bundles = new BundlesResource(this);
			BundleSubscriptionItems = new BundleSubscriptionItemsResource(this);
			Buyers = new BuyersResource(this);
			Cart = new CartResource(this);
			Catalogs = new CatalogsResource(this);
			Categories = new CategoriesResource(this);
			Certs = new CertsResource(this);
			CostCenters = new CostCentersResource(this);
			CreditCards = new CreditCardsResource(this);
			DeliveryConfigurations = new DeliveryConfigurationsResource(this);
			ErrorConfigs = new ErrorConfigsResource(this);
			ForgottenCredentials = new ForgottenCredentialsResource(this);
			ImpersonationConfigs = new ImpersonationConfigsResource(this);
			Incrementors = new IncrementorsResource(this);
			IntegrationEvents = new IntegrationEventsResource(this);
			InventoryRecords = new InventoryRecordsResource(this);
			LineItems = new LineItemsResource(this);
			Locales = new LocalesResource(this);
			Me = new MeResource(this);
			MessageSenders = new MessageSendersResource(this);
			OpenIdConnects = new OpenIdConnectsResource(this);
			OrderReturns = new OrderReturnsResource(this);
			Orders = new OrdersResource(this);
			OrderSyncs = new OrderSyncsResource(this);
			Payments = new PaymentsResource(this);
			PriceSchedules = new PriceSchedulesResource(this);
			ProductCollections = new ProductCollectionsResource(this);
			ProductFacets = new ProductFacetsResource(this);
			Products = new ProductsResource(this);
			ProductSyncs = new ProductSyncsResource(this);
			Promotions = new PromotionsResource(this);
			SecurityProfiles = new SecurityProfilesResource(this);
			SellerApprovalRules = new SellerApprovalRulesResource(this);
			Shipments = new ShipmentsResource(this);
			Specs = new SpecsResource(this);
			SpendingAccounts = new SpendingAccountsResource(this);
			SubscriptionIntegrations = new SubscriptionIntegrationsResource(this);
			SubscriptionItems = new SubscriptionItemsResource(this);
			Subscriptions = new SubscriptionsResource(this);
			SupplierAddresses = new SupplierAddressesResource(this);
			Suppliers = new SuppliersResource(this);
			SupplierUserGroups = new SupplierUserGroupsResource(this);
			SupplierUsers = new SupplierUsersResource(this);
			TrackingEvents = new TrackingEventsResource(this);
			UserGroups = new UserGroupsResource(this);
			Users = new UsersResource(this);
			Webhooks = new WebhooksResource(this);
			XpIndices = new XpIndicesResource(this);
		}
		
		public IAddressesResource Addresses { get; private set; }
		public IAdminAddressesResource AdminAddresses { get; private set; }
		public IAdminUserGroupsResource AdminUserGroups { get; private set; }
		public IAdminUsersResource AdminUsers { get; private set; }
		public IApiClientsResource ApiClients { get; private set; }
		public IApprovalRulesResource ApprovalRules { get; private set; }
		public IBundleLineItemsResource BundleLineItems { get; private set; }
		public IBundlesResource Bundles { get; private set; }
		public IBundleSubscriptionItemsResource BundleSubscriptionItems { get; private set; }
		public IBuyersResource Buyers { get; private set; }
		public ICartResource Cart { get; private set; }
		public ICatalogsResource Catalogs { get; private set; }
		public ICategoriesResource Categories { get; private set; }
		public ICertsResource Certs { get; private set; }
		public ICostCentersResource CostCenters { get; private set; }
		public ICreditCardsResource CreditCards { get; private set; }
		public IDeliveryConfigurationsResource DeliveryConfigurations { get; private set; }
		public IErrorConfigsResource ErrorConfigs { get; private set; }
		public IForgottenCredentialsResource ForgottenCredentials { get; private set; }
		public IImpersonationConfigsResource ImpersonationConfigs { get; private set; }
		public IIncrementorsResource Incrementors { get; private set; }
		public IIntegrationEventsResource IntegrationEvents { get; private set; }
		public IInventoryRecordsResource InventoryRecords { get; private set; }
		public ILineItemsResource LineItems { get; private set; }
		public ILocalesResource Locales { get; private set; }
		public IMeResource Me { get; private set; }
		public IMessageSendersResource MessageSenders { get; private set; }
		public IOpenIdConnectsResource OpenIdConnects { get; private set; }
		public IOrderReturnsResource OrderReturns { get; private set; }
		public IOrdersResource Orders { get; private set; }
		public IOrderSyncsResource OrderSyncs { get; private set; }
		public IPaymentsResource Payments { get; private set; }
		public IPriceSchedulesResource PriceSchedules { get; private set; }
		public IProductCollectionsResource ProductCollections { get; private set; }
		public IProductFacetsResource ProductFacets { get; private set; }
		public IProductsResource Products { get; private set; }
		public IProductSyncsResource ProductSyncs { get; private set; }
		public IPromotionsResource Promotions { get; private set; }
		public ISecurityProfilesResource SecurityProfiles { get; private set; }
		public ISellerApprovalRulesResource SellerApprovalRules { get; private set; }
		public IShipmentsResource Shipments { get; private set; }
		public ISpecsResource Specs { get; private set; }
		public ISpendingAccountsResource SpendingAccounts { get; private set; }
		public ISubscriptionIntegrationsResource SubscriptionIntegrations { get; private set; }
		public ISubscriptionItemsResource SubscriptionItems { get; private set; }
		public ISubscriptionsResource Subscriptions { get; private set; }
		public ISupplierAddressesResource SupplierAddresses { get; private set; }
		public ISuppliersResource Suppliers { get; private set; }
		public ISupplierUserGroupsResource SupplierUserGroups { get; private set; }
		public ISupplierUsersResource SupplierUsers { get; private set; }
		public ITrackingEventsResource TrackingEvents { get; private set; }
		public IUserGroupsResource UserGroups { get; private set; }
		public IUsersResource Users { get; private set; }
		public IWebhooksResource Webhooks { get; private set; }
		public IXpIndicesResource XpIndices { get; private set; }
	}

	public class AddressesResource : OrderCloudResource, IAddressesResource
	{
		internal AddressesResource(OrderCloudClient client) : base(client) { }
		public Task<Address> GetAsync(string buyerID, string addressID, string accessToken = null) => GetAsync<Address>(buyerID, addressID, accessToken);
		public Task<TAddress> GetAsync<TAddress>(string buyerID, string addressID, string accessToken = null) where TAddress : Address => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<TAddress>();
		public Task<ListPage<Address>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Address>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TAddress>> ListAsync<TAddress>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TAddress : Address => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TAddress>>();
		public Task<ListPage<Address>> ListAsync(string buyerID, Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null) => ListAsync<Address>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TAddress>> ListAsync<TAddress>(string buyerID, Action<ListOptionsBuilder<TAddress>> buildListOpts, string accessToken = null) where TAddress : Address => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TAddress>>();
		public Task<Address> CreateAsync(string buyerID, Address address, string accessToken = null) => CreateAsync<Address>(buyerID, address, accessToken);
		public Task<TAddress> CreateAsync<TAddress>(string buyerID, Address address, string accessToken = null) where TAddress : Address => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<TAddress>();
		public Task<Address> SaveAsync(string buyerID, string addressID, Address address, string accessToken = null) => SaveAsync<Address>(buyerID, addressID, address, accessToken);
		public Task<TAddress> SaveAsync<TAddress>(string buyerID, string addressID, Address address, string accessToken = null) where TAddress : Address => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TAddress>();
		public Task DeleteAsync(string buyerID, string addressID, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Address> PatchAsync(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null) => PatchAsync<Address>(buyerID, addressID, partialAddress, accessToken);
		public Task<TAddress> PatchAsync<TAddress>(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null) where TAddress : Address => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TAddress>();
		public Task<ListPage<AddressAssignment>> ListAssignmentsAsync(string buyerID, string addressID = null, string userID = null, string userGroupID = null, PartyType? level = null, bool? isShipping = null, bool? isBilling = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { addressID, userID, userGroupID, level, isShipping, isBilling, page, pageSize }).GetJsonAsync<ListPage<AddressAssignment>>();
		public Task DeleteAssignmentAsync(string buyerID, string addressID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string buyerID, AddressAssignment addressAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(addressAssignment));
	}

	public class AdminAddressesResource : OrderCloudResource, IAdminAddressesResource
	{
		internal AdminAddressesResource(OrderCloudClient client) : base(client) { }
		public Task<Address> GetAsync(string addressID, string accessToken = null) => GetAsync<Address>(addressID, accessToken);
		public Task<TAddress> GetAsync<TAddress>(string addressID, string accessToken = null) where TAddress : Address => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<TAddress>();
		public Task<ListPage<Address>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Address>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TAddress>> ListAsync<TAddress>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TAddress : Address => Request("v1", "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TAddress>>();
		public Task<ListPage<Address>> ListAsync(Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null) => ListAsync<Address>(buildListOpts, accessToken);
		public Task<ListPage<TAddress>> ListAsync<TAddress>(Action<ListOptionsBuilder<TAddress>> buildListOpts, string accessToken = null) where TAddress : Address => Request("v1", "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TAddress>>();
		public Task<Address> CreateAsync(Address address, string accessToken = null) => CreateAsync<Address>(address, accessToken);
		public Task<TAddress> CreateAsync<TAddress>(Address address, string accessToken = null) where TAddress : Address => Request("v1", "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<TAddress>();
		public Task<Address> SaveAsync(string addressID, Address address, string accessToken = null) => SaveAsync<Address>(addressID, address, accessToken);
		public Task<TAddress> SaveAsync<TAddress>(string addressID, Address address, string accessToken = null) where TAddress : Address => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TAddress>();
		public Task DeleteAsync(string addressID, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Address> PatchAsync(string addressID, PartialAddress partialAddress, string accessToken = null) => PatchAsync<Address>(addressID, partialAddress, accessToken);
		public Task<TAddress> PatchAsync<TAddress>(string addressID, PartialAddress partialAddress, string accessToken = null) where TAddress : Address => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TAddress>();
	}

	public class AdminUserGroupsResource : OrderCloudResource, IAdminUserGroupsResource
	{
		internal AdminUserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string userGroupID, string accessToken = null) => GetAsync<UserGroup>(userGroupID, accessToken);
		public Task<TUserGroup> GetAsync<TUserGroup>(string userGroupID, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<TUserGroup>();
		public Task<ListPage<UserGroup>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<UserGroup>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<ListPage<UserGroup>> ListAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => ListAsync<UserGroup>(buildListOpts, accessToken);
		public Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<UserGroup> CreateAsync(UserGroup userGroup, string accessToken = null) => CreateAsync<UserGroup>(userGroup, accessToken);
		public Task<TUserGroup> CreateAsync<TUserGroup>(UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<TUserGroup>();
		public Task<UserGroup> SaveAsync(string userGroupID, UserGroup userGroup, string accessToken = null) => SaveAsync<UserGroup>(userGroupID, userGroup, accessToken);
		public Task<TUserGroup> SaveAsync<TUserGroup>(string userGroupID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<TUserGroup>();
		public Task DeleteAsync(string userGroupID, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<UserGroup> PatchAsync(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => PatchAsync<UserGroup>(userGroupID, partialUserGroup, accessToken);
		public Task<TUserGroup> PatchAsync<TUserGroup>(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<TUserGroup>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "usergroups", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string userGroupID, string userID, string accessToken = null) => Request("v1", "usergroups", userGroupID, "assignments", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveUserAssignmentAsync(UserGroupAssignment userGroupAssignment, string accessToken = null) => Request("v1", "usergroups", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class AdminUsersResource : OrderCloudResource, IAdminUsersResource
	{
		internal AdminUsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string userID, string accessToken = null) => GetAsync<User>(userID, accessToken);
		public Task<TUser> GetAsync<TUser>(string userID, string accessToken = null) where TUser : User => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<TUser>();
		public Task<ListPage<User>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<User>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUser>> ListAsync<TUser>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUser>>();
		public Task<ListPage<User>> ListAsync(Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null) => ListAsync<User>(buildListOpts, accessToken);
		public Task<ListPage<TUser>> ListAsync<TUser>(Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUser>>();
		public Task<User> CreateAsync(User user, string accessToken = null) => CreateAsync<User>(user, accessToken);
		public Task<TUser> CreateAsync<TUser>(User user, string accessToken = null) where TUser : User => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<TUser>();
		public Task<User> SaveAsync(string userID, User user, string accessToken = null) => SaveAsync<User>(userID, user, accessToken);
		public Task<TUser> SaveAsync<TUser>(string userID, User user, string accessToken = null) where TUser : User => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<TUser>();
		public Task DeleteAsync(string userID, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<User> PatchAsync(string userID, PartialUser partialUser, string accessToken = null) => PatchAsync<User>(userID, partialUser, accessToken);
		public Task<TUser> PatchAsync<TUser>(string userID, PartialUser partialUser, string accessToken = null) where TUser : User => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<TUser>();
	}

	public class ApiClientsResource : OrderCloudResource, IApiClientsResource
	{
		internal ApiClientsResource(OrderCloudClient client) : base(client) { }
		public Task<ApiClient> GetAsync(string apiClientID, string accessToken = null) => GetAsync<ApiClient>(apiClientID, accessToken);
		public Task<TApiClient> GetAsync<TApiClient>(string apiClientID, string accessToken = null) where TApiClient : ApiClient => Request("v1", "apiclients", apiClientID).WithOAuthBearerToken(accessToken).GetJsonAsync<TApiClient>();
		public Task<ListPage<ApiClient>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<ApiClient>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TApiClient>> ListAsync<TApiClient>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TApiClient : ApiClient => Request("v1", "apiclients").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TApiClient>>();
		public Task<ListPage<ApiClient>> ListAsync(Action<ListOptionsBuilder<ApiClient>> buildListOpts, string accessToken = null) => ListAsync<ApiClient>(buildListOpts, accessToken);
		public Task<ListPage<TApiClient>> ListAsync<TApiClient>(Action<ListOptionsBuilder<TApiClient>> buildListOpts, string accessToken = null) where TApiClient : ApiClient => Request("v1", "apiclients").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TApiClient>>();
		public Task<ApiClient> CreateAsync(ApiClient apiClient, string accessToken = null) => CreateAsync<ApiClient>(apiClient, accessToken);
		public Task<TApiClient> CreateAsync<TApiClient>(ApiClient apiClient, string accessToken = null) where TApiClient : ApiClient => Request("v1", "apiclients").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(apiClient)).ReceiveJson<TApiClient>();
		public Task<ApiClient> SaveAsync(string apiClientID, ApiClient apiClient, string accessToken = null) => SaveAsync<ApiClient>(apiClientID, apiClient, accessToken);
		public Task<TApiClient> SaveAsync<TApiClient>(string apiClientID, ApiClient apiClient, string accessToken = null) where TApiClient : ApiClient => Request("v1", "apiclients", apiClientID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(apiClient)).ReceiveJson<TApiClient>();
		public Task DeleteAsync(string apiClientID, string accessToken = null) => Request("v1", "apiclients", apiClientID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<ApiClientAssignment>> ListAssignmentsAsync(string apiClientID = null, string buyerID = null, string supplierID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "apiclients", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { apiClientID, buyerID, supplierID, page, pageSize }).GetJsonAsync<ListPage<ApiClientAssignment>>();
		public Task<ApiClient> PatchAsync(string apiClientID, PartialApiClient partialApiClient, string accessToken = null) => PatchAsync<ApiClient>(apiClientID, partialApiClient, accessToken);
		public Task<TApiClient> PatchAsync<TApiClient>(string apiClientID, PartialApiClient partialApiClient, string accessToken = null) where TApiClient : ApiClient => Request("v1", "apiclients", apiClientID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialApiClient)).ReceiveJson<TApiClient>();
		public Task SaveAssignmentAsync(ApiClientAssignment apiClientAssignment, string accessToken = null) => Request("v1", "apiclients", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(apiClientAssignment));
		public Task DeleteBuyerAssignmentAsync(string apiClientID, string buyerID, string accessToken = null) => Request("v1", "buyers", buyerID, "ApiClients", "Assignments", apiClientID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task DeleteSupplierAssignmentAsync(string apiClientID, string supplierID, string accessToken = null) => Request("v1", "suppliers", supplierID, "ApiClients", "Assignments", apiClientID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class ApprovalRulesResource : OrderCloudResource, IApprovalRulesResource
	{
		internal ApprovalRulesResource(OrderCloudClient client) : base(client) { }
		public Task<ApprovalRule> GetAsync(string buyerID, string approvalRuleID, string accessToken = null) => GetAsync<ApprovalRule>(buyerID, approvalRuleID, accessToken);
		public Task<TApprovalRule> GetAsync<TApprovalRule>(string buyerID, string approvalRuleID, string accessToken = null) where TApprovalRule : ApprovalRule => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).GetJsonAsync<TApprovalRule>();
		public Task<ListPage<ApprovalRule>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<ApprovalRule>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TApprovalRule>> ListAsync<TApprovalRule>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TApprovalRule : ApprovalRule => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TApprovalRule>>();
		public Task<ListPage<ApprovalRule>> ListAsync(string buyerID, Action<ListOptionsBuilder<ApprovalRule>> buildListOpts, string accessToken = null) => ListAsync<ApprovalRule>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TApprovalRule>> ListAsync<TApprovalRule>(string buyerID, Action<ListOptionsBuilder<TApprovalRule>> buildListOpts, string accessToken = null) where TApprovalRule : ApprovalRule => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TApprovalRule>>();
		public Task<ApprovalRule> CreateAsync(string buyerID, ApprovalRule approvalRule, string accessToken = null) => CreateAsync<ApprovalRule>(buyerID, approvalRule, accessToken);
		public Task<TApprovalRule> CreateAsync<TApprovalRule>(string buyerID, ApprovalRule approvalRule, string accessToken = null) where TApprovalRule : ApprovalRule => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(approvalRule)).ReceiveJson<TApprovalRule>();
		public Task<ApprovalRule> SaveAsync(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null) => SaveAsync<ApprovalRule>(buyerID, approvalRuleID, approvalRule, accessToken);
		public Task<TApprovalRule> SaveAsync<TApprovalRule>(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null) where TApprovalRule : ApprovalRule => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(approvalRule)).ReceiveJson<TApprovalRule>();
		public Task DeleteAsync(string buyerID, string approvalRuleID, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ApprovalRule> PatchAsync(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null) => PatchAsync<ApprovalRule>(buyerID, approvalRuleID, partialApprovalRule, accessToken);
		public Task<TApprovalRule> PatchAsync<TApprovalRule>(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null) where TApprovalRule : ApprovalRule => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialApprovalRule)).ReceiveJson<TApprovalRule>();
	}

	public class BundleLineItemsResource : OrderCloudResource, IBundleLineItemsResource
	{
		internal BundleLineItemsResource(OrderCloudClient client) : base(client) { }
		public Task<LineItem> CreateAsync(OrderDirection direction, string orderID, string bundleID, BundleItems bundleItems, string accessToken = null) => CreateAsync<LineItem>(direction, orderID, bundleID, bundleItems, accessToken);
		public Task<TLineItem> CreateAsync<TLineItem>(OrderDirection direction, string orderID, string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "bundles", bundleID).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleItems)).ReceiveJson<TLineItem>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string bundleID, string bundleItemID, string accessToken = null) => Request("v1", "orders", direction, orderID, "bundles", bundleID, bundleItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class BundlesResource : OrderCloudResource, IBundlesResource
	{
		internal BundlesResource(OrderCloudClient client) : base(client) { }
		public Task<Bundle> GetAsync(string bundleID, string accessToken = null) => GetAsync<Bundle>(bundleID, accessToken);
		public Task<TBundle> GetAsync<TBundle>(string bundleID, string accessToken = null) where TBundle : Bundle => Request("v1", "bundles", bundleID).WithOAuthBearerToken(accessToken).GetJsonAsync<TBundle>();
		public Task<ListPageWithFacets<Bundle>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Bundle>(catalogID, categoryID, supplierID, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPageWithFacets<TBundle>> ListAsync<TBundle>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBundle : Bundle => Request("v1", "bundles").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID, search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPageWithFacets<TBundle>>();
		public Task<ListPageWithFacets<Bundle>> ListAsync(Action<ListOptionsBuilder2<Bundle>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) => ListAsync<Bundle>(buildListOpts, catalogID, categoryID, supplierID, accessToken);
		public Task<ListPageWithFacets<TBundle>> ListAsync<TBundle>(Action<ListOptionsBuilder2<TBundle>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) where TBundle : Bundle => Request("v1", "bundles").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID }).SetListOptions(buildListOpts).GetJsonAsync<ListPageWithFacets<TBundle>>();
		public Task<Bundle> CreateAsync(Bundle bundle, string accessToken = null) => CreateAsync<Bundle>(bundle, accessToken);
		public Task<TBundle> CreateAsync<TBundle>(Bundle bundle, string accessToken = null) where TBundle : Bundle => Request("v1", "bundles").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundle)).ReceiveJson<TBundle>();
		public Task<Bundle> SaveAsync(string bundleID, Bundle bundle, string accessToken = null) => SaveAsync<Bundle>(bundleID, bundle, accessToken);
		public Task<TBundle> SaveAsync<TBundle>(string bundleID, Bundle bundle, string accessToken = null) where TBundle : Bundle => Request("v1", "bundles", bundleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(bundle)).ReceiveJson<TBundle>();
		public Task DeleteAsync(string bundleID, string accessToken = null) => Request("v1", "bundles", bundleID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Bundle> PatchAsync(string bundleID, PartialBundle partialBundle, string accessToken = null) => PatchAsync<Bundle>(bundleID, partialBundle, accessToken);
		public Task<TBundle> PatchAsync<TBundle>(string bundleID, PartialBundle partialBundle, string accessToken = null) where TBundle : Bundle => Request("v1", "bundles", bundleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBundle)).ReceiveJson<TBundle>();
		public Task SaveProductAssignmentAsync(BundleProductAssignment bundleProductAssignment, string accessToken = null) => Request("v1", "bundles", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleProductAssignment));
		public Task<ListPage<BundleProductAssignment>> ListProductAssignmentsAsync(string bundleID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "bundles", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { bundleID, productID, page, pageSize }).GetJsonAsync<ListPage<BundleProductAssignment>>();
		public Task DeleteProductAssignmentAsync(string bundleID, string productID, string accessToken = null) => Request("v1", "bundles", bundleID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<BundleAssignment>> ListAssignmentsAsync(string bundleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "bundles", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { bundleID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<BundleAssignment>>();
		public Task SaveAssignmentAsync(BundleAssignment bundleAssignment, string accessToken = null) => Request("v1", "bundles", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleAssignment));
		public Task DeleteAssignmentAsync(string bundleID, string buyerID, string userID = null, string userGroupID = null, string sellerID = null, string accessToken = null) => Request("v1", "bundles", bundleID, "assignments", buyerID).WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID, sellerID }).DeleteAsync();
	}

	public class BundleSubscriptionItemsResource : OrderCloudResource, IBundleSubscriptionItemsResource
	{
		internal BundleSubscriptionItemsResource(OrderCloudClient client) : base(client) { }
		public Task<LineItem> CreateAsync(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null) => CreateAsync<LineItem>(subscriptionID, bundleID, bundleItems, accessToken);
		public Task<TLineItem> CreateAsync<TLineItem>(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "bundles", bundleID).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleItems)).ReceiveJson<TLineItem>();
		public Task DeleteAsync(string subscriptionID, string bundleID, string bundleItemID, string accessToken = null) => Request("v1", "subscriptions", subscriptionID, "bundles", bundleID, bundleItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class BuyersResource : OrderCloudResource, IBuyersResource
	{
		internal BuyersResource(OrderCloudClient client) : base(client) { }
		public Task<Buyer> GetAsync(string buyerID, string accessToken = null) => GetAsync<Buyer>(buyerID, accessToken);
		public Task<TBuyer> GetAsync<TBuyer>(string buyerID, string accessToken = null) where TBuyer : Buyer => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).GetJsonAsync<TBuyer>();
		public Task<ListPage<Buyer>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Buyer>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TBuyer>> ListAsync<TBuyer>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyer : Buyer => Request("v1", "buyers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TBuyer>>();
		public Task<ListPage<Buyer>> ListAsync(Action<ListOptionsBuilder<Buyer>> buildListOpts, string accessToken = null) => ListAsync<Buyer>(buildListOpts, accessToken);
		public Task<ListPage<TBuyer>> ListAsync<TBuyer>(Action<ListOptionsBuilder<TBuyer>> buildListOpts, string accessToken = null) where TBuyer : Buyer => Request("v1", "buyers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TBuyer>>();
		public Task<Buyer> CreateAsync(Buyer buyer, string accessToken = null) => CreateAsync<Buyer>(buyer, accessToken);
		public Task<TBuyer> CreateAsync<TBuyer>(Buyer buyer, string accessToken = null) where TBuyer : Buyer => Request("v1", "buyers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyer)).ReceiveJson<TBuyer>();
		public Task DeleteAsync(string buyerID, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Buyer> SaveAsync(string buyerID, Buyer buyer, string accessToken = null) => SaveAsync<Buyer>(buyerID, buyer, accessToken);
		public Task<TBuyer> SaveAsync<TBuyer>(string buyerID, Buyer buyer, string accessToken = null) where TBuyer : Buyer => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyer)).ReceiveJson<TBuyer>();
		public Task<Buyer> PatchAsync(string buyerID, PartialBuyer partialBuyer, string accessToken = null) => PatchAsync<Buyer>(buyerID, partialBuyer, accessToken);
		public Task<TBuyer> PatchAsync<TBuyer>(string buyerID, PartialBuyer partialBuyer, string accessToken = null) where TBuyer : Buyer => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyer)).ReceiveJson<TBuyer>();
		public Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "sellers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerSupplier>>();
		public Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(string buyerID, Action<ListOptionsBuilder<BuyerSupplier>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "sellers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerSupplier>>();
	}

	public class CartResource : OrderCloudResource, ICartResource
	{
		internal CartResource(OrderCloudClient client) : base(client) { }
		public Task<Order> GetAsync(string accessToken = null) => GetAsync<Order>(accessToken);
		public Task<TOrder> GetAsync<TOrder>(string accessToken = null) where TOrder : Order => Request("v1", "cart").WithOAuthBearerToken(accessToken).GetJsonAsync<TOrder>();
		public Task<Order> SaveAsync(Order order, string accessToken = null) => SaveAsync<Order>(order, accessToken);
		public Task<TOrder> SaveAsync<TOrder>(Order order, string accessToken = null) where TOrder : Order => Request("v1", "cart").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(order)).ReceiveJson<TOrder>();
		public Task DeleteAsync(string accessToken = null) => Request("v1", "cart").WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SetActiveCartAsync(string orderID, string accessToken = null) => Request("v1", "cart", orderID).WithOAuthBearerToken(accessToken).PutAsync(null);
		public Task<Order> PatchAsync(PartialOrder partialOrder, string accessToken = null) => PatchAsync<Order>(partialOrder, accessToken);
		public Task<TOrder> PatchAsync<TOrder>(PartialOrder partialOrder, string accessToken = null) where TOrder : Order => Request("v1", "cart").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOrder)).ReceiveJson<TOrder>();
		public Task<ListPage<LineItem>> ListLineItemsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListLineItemsAsync<LineItem>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TLineItem>> ListLineItemsAsync<TLineItem>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "lineitems").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TLineItem>>();
		public Task<ListPage<LineItem>> ListLineItemsAsync(Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null) => ListLineItemsAsync<LineItem>(buildListOpts, accessToken);
		public Task<ListPage<TLineItem>> ListLineItemsAsync<TLineItem>(Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "lineitems").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TLineItem>>();
		public Task<LineItem> GetLineItemAsync(string lineItemID, string accessToken = null) => GetLineItemAsync<LineItem>(lineItemID, accessToken);
		public Task<TLineItem> GetLineItemAsync<TLineItem>(string lineItemID, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "lineitems", lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<TLineItem>();
		public Task<LineItem> CreateLineItemAsync(LineItem lineItem, string accessToken = null) => CreateLineItemAsync<LineItem>(lineItem, accessToken);
		public Task<TLineItem> CreateLineItemAsync<TLineItem>(LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "lineitems").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> SaveLineItemAsync(string lineItemID, LineItem lineItem, string accessToken = null) => SaveLineItemAsync<LineItem>(lineItemID, lineItem, accessToken);
		public Task<TLineItem> SaveLineItemAsync<TLineItem>(string lineItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> PatchLineItemAsync(string lineItemID, PartialLineItem partialLineItem, string accessToken = null) => PatchLineItemAsync<LineItem>(lineItemID, partialLineItem, accessToken);
		public Task<TLineItem> PatchLineItemAsync<TLineItem>(string lineItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<TLineItem>();
		public Task DeleteLineItemAsync(string lineItemID, string accessToken = null) => Request("v1", "cart", "lineitems", lineItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<LineItem> CreateBundleItemAsync(string bundleID, BundleItems bundleItems, string accessToken = null) => CreateBundleItemAsync<LineItem>(bundleID, bundleItems, accessToken);
		public Task<TLineItem> CreateBundleItemAsync<TLineItem>(string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem => Request("v1", "cart", "bundles", bundleID).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleItems)).ReceiveJson<TLineItem>();
		public Task DeleteBundleItemAsync(string bundleID, string bundleItemID, string accessToken = null) => Request("v1", "cart", "bundles", bundleID, bundleItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListPromotionsAsync<OrderPromotion>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderPromotion : OrderPromotion => Request("v1", "cart", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrderPromotion>>();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(Action<ListOptionsBuilder<OrderPromotion>> buildListOpts, string accessToken = null) => ListPromotionsAsync<OrderPromotion>(buildListOpts, accessToken);
		public Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(Action<ListOptionsBuilder<TOrderPromotion>> buildListOpts, string accessToken = null) where TOrderPromotion : OrderPromotion => Request("v1", "cart", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrderPromotion>>();
		public Task<ListPage<Promotion>> ListEligiblePromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListEligiblePromotionsAsync<Promotion>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion => Request("v1", "cart", "eligiblepromotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPromotion>>();
		public Task<ListPage<Promotion>> ListEligiblePromotionsAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null) => ListEligiblePromotionsAsync<Promotion>(buildListOpts, accessToken);
		public Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion => Request("v1", "cart", "eligiblepromotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPromotion>>();
		public Task<OrderPromotion> AddPromotionAsync(string promoCode, string accessToken = null) => AddPromotionAsync<OrderPromotion>(promoCode, accessToken);
		public Task<TOrderPromotion> AddPromotionAsync<TOrderPromotion>(string promoCode, string accessToken = null) where TOrderPromotion : OrderPromotion => Request("v1", "cart", "promotions", promoCode).WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderPromotion>();
		public Task DeletePromotionAsync(string promoCode, string accessToken = null) => Request("v1", "cart", "promotions", promoCode).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Order> ApplyPromotionsAsync(string accessToken = null) => ApplyPromotionsAsync<Order>(accessToken);
		public Task<TOrder> ApplyPromotionsAsync<TOrder>(string accessToken = null) where TOrder : Order => Request("v1", "cart", "applypromotions").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrder>();
		public Task<Order> PatchFromUserAsync(PartialUser partialUser, string accessToken = null) => PatchFromUserAsync<Order>(partialUser, accessToken);
		public Task<TOrder> PatchFromUserAsync<TOrder>(PartialUser partialUser, string accessToken = null) where TOrder : Order => Request("v1", "cart", "fromuser").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<TOrder>();
		public Task<ListPage<Payment>> ListPaymentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListPaymentsAsync<Payment>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPayment>> ListPaymentsAsync<TPayment>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPayment : Payment => Request("v1", "cart", "payments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPayment>>();
		public Task<ListPage<Payment>> ListPaymentsAsync(Action<ListOptionsBuilder<Payment>> buildListOpts, string accessToken = null) => ListPaymentsAsync<Payment>(buildListOpts, accessToken);
		public Task<ListPage<TPayment>> ListPaymentsAsync<TPayment>(Action<ListOptionsBuilder<TPayment>> buildListOpts, string accessToken = null) where TPayment : Payment => Request("v1", "cart", "payments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPayment>>();
		public Task<Payment> GetPaymentAsync(string paymentID, string accessToken = null) => GetPaymentAsync<Payment>(paymentID, accessToken);
		public Task<TPayment> GetPaymentAsync<TPayment>(string paymentID, string accessToken = null) where TPayment : Payment => Request("v1", "cart", "payments", paymentID).WithOAuthBearerToken(accessToken).GetJsonAsync<TPayment>();
		public Task<Payment> CreatePaymentAsync(Payment payment, string accessToken = null) => CreatePaymentAsync<Payment>(payment, accessToken);
		public Task<TPayment> CreatePaymentAsync<TPayment>(Payment payment, string accessToken = null) where TPayment : Payment => Request("v1", "cart", "payments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(payment)).ReceiveJson<TPayment>();
		public Task<Payment> PatchPaymentAsync(string paymentID, PartialPayment partialPayment, string accessToken = null) => PatchPaymentAsync<Payment>(paymentID, partialPayment, accessToken);
		public Task<TPayment> PatchPaymentAsync<TPayment>(string paymentID, PartialPayment partialPayment, string accessToken = null) where TPayment : Payment => Request("v1", "cart", "payments", paymentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPayment)).ReceiveJson<TPayment>();
		public Task DeletePaymentAsync(string paymentID, string accessToken = null) => Request("v1", "cart", "payments", paymentID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<PaymentTransaction> CreatePaymentTransactionAsync(string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) => CreatePaymentTransactionAsync<PaymentTransaction>(paymentID, paymentTransaction, accessToken);
		public Task<TPaymentTransaction> CreatePaymentTransactionAsync<TPaymentTransaction>(string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) where TPaymentTransaction : PaymentTransaction => Request("v1", "cart", "payments", paymentID, "transactions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(paymentTransaction)).ReceiveJson<TPaymentTransaction>();
		public Task DeletePaymentTransactionAsync(string paymentID, string transactionID, string accessToken = null) => Request("v1", "cart", "payments", paymentID, "transactions", transactionID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Order> SubmitAsync(string accessToken = null) => SubmitAsync<Order>(accessToken);
		public Task<TOrder> SubmitAsync<TOrder>(string accessToken = null) where TOrder : Order => Request("v1", "cart", "submit").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrder>();
		public Task ValidateAsync(string accessToken = null) => Request("v1", "cart", "validate").WithOAuthBearerToken(accessToken).PostAsync(null);
		public Task<OrderWorksheet> CalculateAsync(string accessToken = null) => CalculateAsync<OrderWorksheet>(accessToken);
		public Task<TOrderWorksheet> CalculateAsync<TOrderWorksheet>(string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "cart", "calculate").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderWorksheet>();
		public Task<OrderWorksheet> GetOrderWorksheetAsync(string accessToken = null) => GetOrderWorksheetAsync<OrderWorksheet>(accessToken);
		public Task<TOrderWorksheet> GetOrderWorksheetAsync<TOrderWorksheet>(string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "cart", "worksheet").WithOAuthBearerToken(accessToken).GetJsonAsync<TOrderWorksheet>();
		public Task<OrderWorksheet> EstimateShippingAsync(string accessToken = null) => EstimateShippingAsync<OrderWorksheet>(accessToken);
		public Task<TOrderWorksheet> EstimateShippingAsync<TOrderWorksheet>(string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "cart", "estimateshipping").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderWorksheet>();
		public Task<OrderWorksheet> SelectShipMethodsAsync(OrderShipMethodSelection orderShipMethodSelection, string accessToken = null) => SelectShipMethodsAsync<OrderWorksheet>(orderShipMethodSelection, accessToken);
		public Task<TOrderWorksheet> SelectShipMethodsAsync<TOrderWorksheet>(OrderShipMethodSelection orderShipMethodSelection, string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "cart", "shipmethods").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderShipMethodSelection)).ReceiveJson<TOrderWorksheet>();
		public Task<Order> SetShippingAddressAsync(Address address, string accessToken = null) => SetShippingAddressAsync<Order>(address, accessToken);
		public Task<TOrder> SetShippingAddressAsync<TOrder>(Address address, string accessToken = null) where TOrder : Order => Request("v1", "cart", "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TOrder>();
		public Task<Order> PatchShippingAddressAsync(PartialAddress partialAddress, string accessToken = null) => PatchShippingAddressAsync<Order>(partialAddress, accessToken);
		public Task<TOrder> PatchShippingAddressAsync<TOrder>(PartialAddress partialAddress, string accessToken = null) where TOrder : Order => Request("v1", "cart", "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TOrder>();
		public Task<Order> SetBillingAddressAsync(Address address, string accessToken = null) => SetBillingAddressAsync<Order>(address, accessToken);
		public Task<TOrder> SetBillingAddressAsync<TOrder>(Address address, string accessToken = null) where TOrder : Order => Request("v1", "cart", "billto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TOrder>();
		public Task<Order> PatchBillingAddressAsync(PartialAddress partialAddress, string accessToken = null) => PatchBillingAddressAsync<Order>(partialAddress, accessToken);
		public Task<TOrder> PatchBillingAddressAsync<TOrder>(PartialAddress partialAddress, string accessToken = null) where TOrder : Order => Request("v1", "cart", "billto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TOrder>();
	}

	public class CatalogsResource : OrderCloudResource, ICatalogsResource
	{
		internal CatalogsResource(OrderCloudClient client) : base(client) { }
		public Task<Catalog> GetAsync(string catalogID, string accessToken = null) => GetAsync<Catalog>(catalogID, accessToken);
		public Task<TCatalog> GetAsync<TCatalog>(string catalogID, string accessToken = null) where TCatalog : Catalog => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).GetJsonAsync<TCatalog>();
		public Task<ListPage<Catalog>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Catalog>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TCatalog>> ListAsync<TCatalog>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCatalog : Catalog => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TCatalog>>();
		public Task<ListPage<Catalog>> ListAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string accessToken = null) => ListAsync<Catalog>(buildListOpts, accessToken);
		public Task<ListPage<TCatalog>> ListAsync<TCatalog>(Action<ListOptionsBuilder<TCatalog>> buildListOpts, string accessToken = null) where TCatalog : Catalog => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCatalog>>();
		public Task<Catalog> CreateAsync(Catalog catalog, string accessToken = null) => CreateAsync<Catalog>(catalog, accessToken);
		public Task<TCatalog> CreateAsync<TCatalog>(Catalog catalog, string accessToken = null) where TCatalog : Catalog => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(catalog)).ReceiveJson<TCatalog>();
		public Task<Catalog> SaveAsync(string catalogID, Catalog catalog, string accessToken = null) => SaveAsync<Catalog>(catalogID, catalog, accessToken);
		public Task<TCatalog> SaveAsync<TCatalog>(string catalogID, Catalog catalog, string accessToken = null) where TCatalog : Catalog => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(catalog)).ReceiveJson<TCatalog>();
		public Task DeleteAsync(string catalogID, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Catalog> PatchAsync(string catalogID, PartialCatalog partialCatalog, string accessToken = null) => PatchAsync<Catalog>(catalogID, partialCatalog, accessToken);
		public Task<TCatalog> PatchAsync<TCatalog>(string catalogID, PartialCatalog partialCatalog, string accessToken = null) where TCatalog : Catalog => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCatalog)).ReceiveJson<TCatalog>();
		public Task<ListPage<CatalogAssignment>> ListAssignmentsAsync(string catalogID = null, string buyerID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, buyerID, page, pageSize }).GetJsonAsync<ListPage<CatalogAssignment>>();
		public Task SaveAssignmentAsync(CatalogAssignment catalogAssignment, string accessToken = null) => Request("v1", "catalogs", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(catalogAssignment));
		public Task DeleteAssignmentAsync(string catalogID, string buyerID, string accessToken = null) => Request("v1", "catalogs", catalogID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID }).DeleteAsync();
		public Task<ListPage<ProductCatalogAssignment>> ListProductAssignmentsAsync(string catalogID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, productID, page, pageSize }).GetJsonAsync<ListPage<ProductCatalogAssignment>>();
		public Task SaveProductAssignmentAsync(ProductCatalogAssignment productCatalogAssignment, string accessToken = null) => Request("v1", "catalogs", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productCatalogAssignment));
		public Task DeleteProductAssignmentAsync(string catalogID, string productID, string accessToken = null) => Request("v1", "catalogs", catalogID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<BundleCatalogAssignment>> ListBundleAssignmentsAsync(string catalogID = null, string bundleID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", "bundleassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, bundleID, page, pageSize }).GetJsonAsync<ListPage<BundleCatalogAssignment>>();
		public Task SaveBundleAssignmentAsync(BundleCatalogAssignment bundleCatalogAssignment, string accessToken = null) => Request("v1", "catalogs", "bundleassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleCatalogAssignment));
		public Task DeleteBundleAssignmentAsync(string catalogID, string bundleID, string accessToken = null) => Request("v1", "catalogs", catalogID, "bundleassignments", bundleID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class CategoriesResource : OrderCloudResource, ICategoriesResource
	{
		internal CategoriesResource(OrderCloudClient client) : base(client) { }
		public Task<Category> GetAsync(string catalogID, string categoryID, string accessToken = null) => GetAsync<Category>(catalogID, categoryID, accessToken);
		public Task<TCategory> GetAsync<TCategory>(string catalogID, string categoryID, string accessToken = null) where TCategory : Category => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).GetJsonAsync<TCategory>();
		public Task<ListPage<Category>> ListAsync(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Category>(catalogID, depth, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TCategory>> ListAsync<TCategory>(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCategory : Category => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TCategory>>();
		public Task<ListPage<Category>> ListAsync(string catalogID, Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string accessToken = null) => ListAsync<Category>(catalogID, buildListOpts, depth, accessToken);
		public Task<ListPage<TCategory>> ListAsync<TCategory>(string catalogID, Action<ListOptionsBuilder<TCategory>> buildListOpts, string depth = "1", string accessToken = null) where TCategory : Category => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCategory>>();
		public Task<Category> CreateAsync(string catalogID, Category category, bool adjustListOrders = false, string accessToken = null) => CreateAsync<Category>(catalogID, category, adjustListOrders, accessToken);
		public Task<TCategory> CreateAsync<TCategory>(string catalogID, Category category, bool adjustListOrders = false, string accessToken = null) where TCategory : Category => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { adjustListOrders }).PostJsonAsync(ValidateModel(category)).ReceiveJson<TCategory>();
		public Task<Category> SaveAsync(string catalogID, string categoryID, Category category, bool adjustListOrders = false, string accessToken = null) => SaveAsync<Category>(catalogID, categoryID, category, adjustListOrders, accessToken);
		public Task<TCategory> SaveAsync<TCategory>(string catalogID, string categoryID, Category category, bool adjustListOrders = false, string accessToken = null) where TCategory : Category => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).SetQueryParams(new { adjustListOrders }).PutJsonAsync(ValidateModel(category)).ReceiveJson<TCategory>();
		public Task DeleteAsync(string catalogID, string categoryID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Category> PatchAsync(string catalogID, string categoryID, PartialCategory partialCategory, bool adjustListOrders = false, string accessToken = null) => PatchAsync<Category>(catalogID, categoryID, partialCategory, adjustListOrders, accessToken);
		public Task<TCategory> PatchAsync<TCategory>(string catalogID, string categoryID, PartialCategory partialCategory, bool adjustListOrders = false, string accessToken = null) where TCategory : Category => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).SetQueryParams(new { adjustListOrders }).PatchJsonAsync(ValidateModel(partialCategory)).ReceiveJson<TCategory>();
		public Task<ListPage<CategoryAssignment>> ListAssignmentsAsync(string catalogID, string categoryID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { categoryID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CategoryAssignment>>();
		public Task DeleteAssignmentAsync(string catalogID, string categoryID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string catalogID, CategoryAssignment categoryAssignment, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(categoryAssignment));
		public Task<ListPage<CategoryProductAssignment>> ListProductAssignmentsAsync(string catalogID, string categoryID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { categoryID, productID, page, pageSize }).GetJsonAsync<ListPage<CategoryProductAssignment>>();
		public Task SaveProductAssignmentAsync(string catalogID, CategoryProductAssignment categoryProductAssignment, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(categoryProductAssignment));
		public Task DeleteProductAssignmentAsync(string catalogID, string categoryID, string productID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<CategoryBundleAssignment>> ListBundleAssignmentsAsync(string catalogID, string categoryID = null, string bundleID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "bundleassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { categoryID, bundleID, page, pageSize }).GetJsonAsync<ListPage<CategoryBundleAssignment>>();
		public Task SaveBundleAssignmentAsync(string catalogID, CategoryBundleAssignment categoryBundleAssignment, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "bundleassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(categoryBundleAssignment));
		public Task DeleteBundleAssignmentAsync(string catalogID, string categoryID, string bundleID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID, "bundleassignments", bundleID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class CertsResource : OrderCloudResource, ICertsResource
	{
		internal CertsResource(OrderCloudClient client) : base(client) { }
		public Task<PublicKey> GetPublicKeyAsync(string ID, string accessToken = null) => Request("oauth", "certs", ID).WithOAuthBearerToken(accessToken).GetJsonAsync<PublicKey>();
	}

	public class CostCentersResource : OrderCloudResource, ICostCentersResource
	{
		internal CostCentersResource(OrderCloudClient client) : base(client) { }
		public Task<CostCenter> GetAsync(string buyerID, string costCenterID, string accessToken = null) => GetAsync<CostCenter>(buyerID, costCenterID, accessToken);
		public Task<TCostCenter> GetAsync<TCostCenter>(string buyerID, string costCenterID, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).GetJsonAsync<TCostCenter>();
		public Task<ListPage<CostCenter>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<CostCenter>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TCostCenter>> ListAsync<TCostCenter>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TCostCenter>>();
		public Task<ListPage<CostCenter>> ListAsync(string buyerID, Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null) => ListAsync<CostCenter>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TCostCenter>> ListAsync<TCostCenter>(string buyerID, Action<ListOptionsBuilder<TCostCenter>> buildListOpts, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCostCenter>>();
		public Task<CostCenter> CreateAsync(string buyerID, CostCenter costCenter, string accessToken = null) => CreateAsync<CostCenter>(buyerID, costCenter, accessToken);
		public Task<TCostCenter> CreateAsync<TCostCenter>(string buyerID, CostCenter costCenter, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(costCenter)).ReceiveJson<TCostCenter>();
		public Task<CostCenter> SaveAsync(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null) => SaveAsync<CostCenter>(buyerID, costCenterID, costCenter, accessToken);
		public Task<TCostCenter> SaveAsync<TCostCenter>(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(costCenter)).ReceiveJson<TCostCenter>();
		public Task DeleteAsync(string buyerID, string costCenterID, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<CostCenter> PatchAsync(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null) => PatchAsync<CostCenter>(buyerID, costCenterID, partialCostCenter, accessToken);
		public Task<TCostCenter> PatchAsync<TCostCenter>(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCostCenter)).ReceiveJson<TCostCenter>();
		public Task<ListPage<CostCenterAssignment>> ListAssignmentsAsync(string buyerID, string costCenterID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { costCenterID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CostCenterAssignment>>();
		public Task DeleteAssignmentAsync(string buyerID, string costCenterID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string buyerID, CostCenterAssignment costCenterAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(costCenterAssignment));
	}

	public class CreditCardsResource : OrderCloudResource, ICreditCardsResource
	{
		internal CreditCardsResource(OrderCloudClient client) : base(client) { }
		public Task<CreditCard> GetAsync(string buyerID, string creditCardID, string accessToken = null) => GetAsync<CreditCard>(buyerID, creditCardID, accessToken);
		public Task<TCreditCard> GetAsync<TCreditCard>(string buyerID, string creditCardID, string accessToken = null) where TCreditCard : CreditCard => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).GetJsonAsync<TCreditCard>();
		public Task<ListPage<CreditCard>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<CreditCard>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TCreditCard>> ListAsync<TCreditCard>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCreditCard : CreditCard => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TCreditCard>>();
		public Task<ListPage<CreditCard>> ListAsync(string buyerID, Action<ListOptionsBuilder<CreditCard>> buildListOpts, string accessToken = null) => ListAsync<CreditCard>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TCreditCard>> ListAsync<TCreditCard>(string buyerID, Action<ListOptionsBuilder<TCreditCard>> buildListOpts, string accessToken = null) where TCreditCard : CreditCard => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCreditCard>>();
		public Task<CreditCard> CreateAsync(string buyerID, CreditCard creditCard, string accessToken = null) => CreateAsync<CreditCard>(buyerID, creditCard, accessToken);
		public Task<TCreditCard> CreateAsync<TCreditCard>(string buyerID, CreditCard creditCard, string accessToken = null) where TCreditCard : CreditCard => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(creditCard)).ReceiveJson<TCreditCard>();
		public Task<CreditCard> SaveAsync(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null) => SaveAsync<CreditCard>(buyerID, creditCardID, creditCard, accessToken);
		public Task<TCreditCard> SaveAsync<TCreditCard>(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null) where TCreditCard : CreditCard => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(creditCard)).ReceiveJson<TCreditCard>();
		public Task DeleteAsync(string buyerID, string creditCardID, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<CreditCard> PatchAsync(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null) => PatchAsync<CreditCard>(buyerID, creditCardID, partialCreditCard, accessToken);
		public Task<TCreditCard> PatchAsync<TCreditCard>(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null) where TCreditCard : CreditCard => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCreditCard)).ReceiveJson<TCreditCard>();
		public Task<ListPage<CreditCardAssignment>> ListAssignmentsAsync(string buyerID, string creditCardID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { creditCardID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CreditCardAssignment>>();
		public Task SaveAssignmentAsync(string buyerID, CreditCardAssignment creditCardAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(creditCardAssignment));
		public Task DeleteAssignmentAsync(string buyerID, string creditCardID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class DeliveryConfigurationsResource : OrderCloudResource, IDeliveryConfigurationsResource
	{
		internal DeliveryConfigurationsResource(OrderCloudClient client) : base(client) { }
		public Task<DeliveryConfig> GetAsync(string deliveryConfigID, string accessToken = null) => Request("v1", "integrations", "deliveryconfig", deliveryConfigID).WithOAuthBearerToken(accessToken).GetJsonAsync<DeliveryConfig>();
		public Task<ListPage<DeliveryConfig>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "integrations", "deliveryconfig").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<DeliveryConfig>>();
		public Task<ListPage<DeliveryConfig>> ListAsync(Action<ListOptionsBuilder<DeliveryConfig>> buildListOpts, string accessToken = null) => Request("v1", "integrations", "deliveryconfig").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<DeliveryConfig>>();
		public Task<DeliveryConfig> CreateAsync(DeliveryConfig deliveryConfig, string accessToken = null) => Request("v1", "integrations", "deliveryconfig").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(deliveryConfig)).ReceiveJson<DeliveryConfig>();
		public Task<DeliveryConfig> SaveAsync(string deliveryConfigID, DeliveryConfig deliveryConfig, string accessToken = null) => Request("v1", "integrations", "deliveryconfig", deliveryConfigID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(deliveryConfig)).ReceiveJson<DeliveryConfig>();
		public Task DeleteAsync(string deliveryConfigID, string accessToken = null) => Request("v1", "integrations", "deliveryconfig", deliveryConfigID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<DeliveryConfig> PatchAsync(string deliveryConfigID, PartialDeliveryConfig partialDeliveryConfig, string accessToken = null) => Request("v1", "integrations", "deliveryconfig", deliveryConfigID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialDeliveryConfig)).ReceiveJson<DeliveryConfig>();
	}

	public class ErrorConfigsResource : OrderCloudResource, IErrorConfigsResource
	{
		internal ErrorConfigsResource(OrderCloudClient client) : base(client) { }
		public Task<ErrorConfig> GetAsync(string accessToken = null) => Request("v1", "integrations", "ErrorConfig").WithOAuthBearerToken(accessToken).GetJsonAsync<ErrorConfig>();
		public Task DeleteAsync(string accessToken = null) => Request("v1", "integrations", "ErrorConfig").WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ErrorConfig> SaveAsync(ErrorConfig errorConfig, string accessToken = null) => Request("v1", "integrations", "ErrorConfig").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(errorConfig)).ReceiveJson<ErrorConfig>();
		public Task<ErrorConfig> PatchAsync(PartialErrorConfig partialErrorConfig, string accessToken = null) => Request("v1", "integrations", "ErrorConfig").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialErrorConfig)).ReceiveJson<ErrorConfig>();
		public Task ValidateAsync(string accessToken = null) => Request("v1", "integrations", "ErrorConfig", "validate").WithOAuthBearerToken(accessToken).PostAsync(null);
	}

	public class ForgottenCredentialsResource : OrderCloudResource, IForgottenCredentialsResource
	{
		internal ForgottenCredentialsResource(OrderCloudClient client) : base(client) { }
		public Task SendVerificationCodeAsync(PasswordResetRequest passwordResetRequest, string accessToken = null) => Request("v1", "password", "reset").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(passwordResetRequest));
		public Task ResetPasswordByVerificationCodeAsync(string verificationCode, PasswordReset passwordReset, string accessToken = null) => Request("v1", "password", "reset", verificationCode).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(passwordReset));
		public Task RetrieveUsernameAsync(string clientID, string email, string accessToken = null) => Request("v1", "username", "retrieve").WithOAuthBearerToken(accessToken).SetQueryParams(new { clientID, email }).PostAsync(null);
	}

	public class ImpersonationConfigsResource : OrderCloudResource, IImpersonationConfigsResource
	{
		internal ImpersonationConfigsResource(OrderCloudClient client) : base(client) { }
		public Task<ImpersonationConfig> GetAsync(string impersonationConfigID, string accessToken = null) => Request("v1", "impersonationconfig", impersonationConfigID).WithOAuthBearerToken(accessToken).GetJsonAsync<ImpersonationConfig>();
		public Task<ListPage<ImpersonationConfig>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "impersonationconfig").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ImpersonationConfig>>();
		public Task<ListPage<ImpersonationConfig>> ListAsync(Action<ListOptionsBuilder<ImpersonationConfig>> buildListOpts, string accessToken = null) => Request("v1", "impersonationconfig").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ImpersonationConfig>>();
		public Task<ImpersonationConfig> CreateAsync(ImpersonationConfig impersonationConfig, string accessToken = null) => Request("v1", "impersonationconfig").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(impersonationConfig)).ReceiveJson<ImpersonationConfig>();
		public Task DeleteAsync(string impersonationConfigID, string accessToken = null) => Request("v1", "impersonationconfig", impersonationConfigID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ImpersonationConfig> SaveAsync(string impersonationConfigID, ImpersonationConfig impersonationConfig, string accessToken = null) => Request("v1", "impersonationconfig", impersonationConfigID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(impersonationConfig)).ReceiveJson<ImpersonationConfig>();
		public Task<ImpersonationConfig> PatchAsync(string impersonationConfigID, PartialImpersonationConfig partialImpersonationConfig, string accessToken = null) => Request("v1", "impersonationconfig", impersonationConfigID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialImpersonationConfig)).ReceiveJson<ImpersonationConfig>();
	}

	public class IncrementorsResource : OrderCloudResource, IIncrementorsResource
	{
		internal IncrementorsResource(OrderCloudClient client) : base(client) { }
		public Task<Incrementor> GetAsync(string incrementorID, string accessToken = null) => Request("v1", "incrementors", incrementorID).WithOAuthBearerToken(accessToken).GetJsonAsync<Incrementor>();
		public Task<ListPage<Incrementor>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "incrementors").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Incrementor>>();
		public Task<ListPage<Incrementor>> ListAsync(Action<ListOptionsBuilder<Incrementor>> buildListOpts, string accessToken = null) => Request("v1", "incrementors").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Incrementor>>();
		public Task<Incrementor> CreateAsync(Incrementor incrementor, string accessToken = null) => Request("v1", "incrementors").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(incrementor)).ReceiveJson<Incrementor>();
		public Task<Incrementor> SaveAsync(string incrementorID, Incrementor incrementor, string accessToken = null) => Request("v1", "incrementors", incrementorID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(incrementor)).ReceiveJson<Incrementor>();
		public Task DeleteAsync(string incrementorID, string accessToken = null) => Request("v1", "incrementors", incrementorID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Incrementor> PatchAsync(string incrementorID, PartialIncrementor partialIncrementor, string accessToken = null) => Request("v1", "incrementors", incrementorID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialIncrementor)).ReceiveJson<Incrementor>();
	}

	public class IntegrationEventsResource : OrderCloudResource, IIntegrationEventsResource
	{
		internal IntegrationEventsResource(OrderCloudClient client) : base(client) { }
		public Task<IntegrationEvent> GetAsync(string integrationEventID, string accessToken = null) => Request("v1", "integrationEvents", integrationEventID).WithOAuthBearerToken(accessToken).GetJsonAsync<IntegrationEvent>();
		public Task<ListPage<IntegrationEvent>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "integrationEvents").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<IntegrationEvent>>();
		public Task<ListPage<IntegrationEvent>> ListAsync(Action<ListOptionsBuilder<IntegrationEvent>> buildListOpts, string accessToken = null) => Request("v1", "integrationEvents").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<IntegrationEvent>>();
		public Task<IntegrationEvent> CreateAsync(IntegrationEvent integrationEvent, string accessToken = null) => Request("v1", "integrationEvents").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(integrationEvent)).ReceiveJson<IntegrationEvent>();
		public Task<IntegrationEvent> SaveAsync(string integrationEventID, IntegrationEvent integrationEvent, string accessToken = null) => Request("v1", "integrationEvents", integrationEventID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(integrationEvent)).ReceiveJson<IntegrationEvent>();
		public Task DeleteAsync(string integrationEventID, string accessToken = null) => Request("v1", "integrationEvents", integrationEventID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<IntegrationEvent> PatchAsync(string integrationEventID, PartialIntegrationEvent partialIntegrationEvent, string accessToken = null) => Request("v1", "integrationEvents", integrationEventID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialIntegrationEvent)).ReceiveJson<IntegrationEvent>();
		public Task<OrderWorksheet> EstimateShippingAsync(OrderDirection direction, string orderID, string accessToken = null) => EstimateShippingAsync<OrderWorksheet>(direction, orderID, accessToken);
		public Task<TOrderWorksheet> EstimateShippingAsync<TOrderWorksheet>(OrderDirection direction, string orderID, string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "orders", direction, orderID, "estimateshipping").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderWorksheet>();
		public Task<OrderWorksheet> SelectShipmethodsAsync(OrderDirection direction, string orderID, OrderShipMethodSelection orderShipMethodSelection, string accessToken = null) => SelectShipmethodsAsync<OrderWorksheet>(direction, orderID, orderShipMethodSelection, accessToken);
		public Task<TOrderWorksheet> SelectShipmethodsAsync<TOrderWorksheet>(OrderDirection direction, string orderID, OrderShipMethodSelection orderShipMethodSelection, string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "orders", direction, orderID, "shipmethods").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderShipMethodSelection)).ReceiveJson<TOrderWorksheet>();
		public Task<OrderWorksheet> GetWorksheetAsync(OrderDirection direction, string orderID, string accessToken = null) => GetWorksheetAsync<OrderWorksheet>(direction, orderID, accessToken);
		public Task<TOrderWorksheet> GetWorksheetAsync<TOrderWorksheet>(OrderDirection direction, string orderID, string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "orders", direction, orderID, "worksheet").WithOAuthBearerToken(accessToken).GetJsonAsync<TOrderWorksheet>();
		public Task<OrderWorksheet> CalculateAsync(OrderDirection direction, string orderID, string accessToken = null) => CalculateAsync<OrderWorksheet>(direction, orderID, accessToken);
		public Task<TOrderWorksheet> CalculateAsync<TOrderWorksheet>(OrderDirection direction, string orderID, string accessToken = null) where TOrderWorksheet : OrderWorksheet => Request("v1", "orders", direction, orderID, "calculate").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderWorksheet>();
	}

	public class InventoryRecordsResource : OrderCloudResource, IInventoryRecordsResource
	{
		internal InventoryRecordsResource(OrderCloudClient client) : base(client) { }
		public Task<InventoryRecord> GetAsync(string productID, string inventoryRecordID, string accessToken = null) => GetAsync<InventoryRecord>(productID, inventoryRecordID, accessToken);
		public Task<TInventoryRecord> GetAsync<TInventoryRecord>(string productID, string inventoryRecordID, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).GetJsonAsync<TInventoryRecord>();
		public Task<ListPage<InventoryRecord>> ListAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<InventoryRecord>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TInventoryRecord>> ListAsync<TInventoryRecord>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<ListPage<InventoryRecord>> ListAsync(string productID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null) => ListAsync<InventoryRecord>(productID, buildListOpts, accessToken);
		public Task<ListPage<TInventoryRecord>> ListAsync<TInventoryRecord>(string productID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<InventoryRecord> CreateAsync(string productID, InventoryRecord inventoryRecord, string accessToken = null) => CreateAsync<InventoryRecord>(productID, inventoryRecord, accessToken);
		public Task<TInventoryRecord> CreateAsync<TInventoryRecord>(string productID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "inventoryrecords").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(inventoryRecord)).ReceiveJson<TInventoryRecord>();
		public Task DeleteAsync(string productID, string inventoryRecordID, string accessToken = null) => Request("v1", "products", productID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<InventoryRecord> SaveAsync(string productID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null) => SaveAsync<InventoryRecord>(productID, inventoryRecordID, inventoryRecord, accessToken);
		public Task<TInventoryRecord> SaveAsync<TInventoryRecord>(string productID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(inventoryRecord)).ReceiveJson<TInventoryRecord>();
		public Task<InventoryRecord> PatchAsync(string productID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null) => PatchAsync<InventoryRecord>(productID, inventoryRecordID, partialInventoryRecord, accessToken);
		public Task<TInventoryRecord> PatchAsync<TInventoryRecord>(string productID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialInventoryRecord)).ReceiveJson<TInventoryRecord>();
		public Task<ListPage<InventoryRecord>> ListVariantAsync(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListVariantAsync<InventoryRecord>(productID, variantID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TInventoryRecord>> ListVariantAsync<TInventoryRecord>(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "variants", variantID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<ListPage<InventoryRecord>> ListVariantAsync(string productID, string variantID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null) => ListVariantAsync<InventoryRecord>(productID, variantID, buildListOpts, accessToken);
		public Task<ListPage<TInventoryRecord>> ListVariantAsync<TInventoryRecord>(string productID, string variantID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "variants", variantID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<InventoryRecord> GetVariantAsync(string productID, string variantID, string inventoryRecordID, string accessToken = null) => GetVariantAsync<InventoryRecord>(productID, variantID, inventoryRecordID, accessToken);
		public Task<TInventoryRecord> GetVariantAsync<TInventoryRecord>(string productID, string variantID, string inventoryRecordID, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).GetJsonAsync<TInventoryRecord>();
		public Task<InventoryRecord> CreateVariantAsync(string productID, string variantID, InventoryRecord inventoryRecord, string accessToken = null) => CreateVariantAsync<InventoryRecord>(productID, variantID, inventoryRecord, accessToken);
		public Task<TInventoryRecord> CreateVariantAsync<TInventoryRecord>(string productID, string variantID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "variants", variantID, "inventoryrecords").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(inventoryRecord)).ReceiveJson<TInventoryRecord>();
		public Task<InventoryRecord> SaveVariantAsync(string productID, string variantID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null) => SaveVariantAsync<InventoryRecord>(productID, variantID, inventoryRecordID, inventoryRecord, accessToken);
		public Task<TInventoryRecord> SaveVariantAsync<TInventoryRecord>(string productID, string variantID, string inventoryRecordID, InventoryRecord inventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(inventoryRecord)).ReceiveJson<TInventoryRecord>();
		public Task<InventoryRecord> PatchVariantAsync(string productID, string variantID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null) => PatchVariantAsync<InventoryRecord>(productID, variantID, inventoryRecordID, partialInventoryRecord, accessToken);
		public Task<TInventoryRecord> PatchVariantAsync<TInventoryRecord>(string productID, string variantID, string inventoryRecordID, PartialInventoryRecord partialInventoryRecord, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialInventoryRecord)).ReceiveJson<TInventoryRecord>();
		public Task DeleteVariantAsync(string productID, string variantID, string inventoryRecordID, string accessToken = null) => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", inventoryRecordID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<InventoryRecordAssignment>> ListAssignmentsAsync(string productID, string buyerID = null, string inventoryRecordID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "products", productID, "inventoryrecords", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, inventoryRecordID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<InventoryRecordAssignment>>();
		public Task SaveAssignmentAsync(string productID, InventoryRecordAssignment inventoryRecordAssignment, string accessToken = null) => Request("v1", "products", productID, "inventoryrecords", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(inventoryRecordAssignment));
		public Task DeleteAssignmentAsync(string productID, string inventoryRecordID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "products", productID, "inventoryrecords", inventoryRecordID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task<ListPage<InventoryRecordAssignment>> ListVariantAssignmentsAsync(string productID, string variantID, string buyerID = null, string inventoryRecordID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, inventoryRecordID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<InventoryRecordAssignment>>();
		public Task SaveVariantAssignmentAsync(string productID, string variantID, InventoryRecordAssignment inventoryRecordAssignment, string accessToken = null) => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(inventoryRecordAssignment));
		public Task DeleteVariantAssignmentAsync(string productID, string variantID, string inventoryRecordID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "products", productID, "variants", variantID, "inventoryrecords", inventoryRecordID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
	}

	public class LineItemsResource : OrderCloudResource, ILineItemsResource
	{
		internal LineItemsResource(OrderCloudClient client) : base(client) { }
		public Task<LineItem> GetAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) => GetAsync<LineItem>(direction, orderID, lineItemID, accessToken);
		public Task<TLineItem> GetAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<TLineItem>();
		public Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<LineItem>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TLineItem>> ListAsync<TLineItem>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TLineItem>>();
		public Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null) => ListAsync<LineItem>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TLineItem>> ListAsync<TLineItem>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TLineItem>>();
		public Task<LineItem> CreateAsync(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null) => CreateAsync<LineItem>(direction, orderID, lineItem, accessToken);
		public Task<TLineItem> CreateAsync<TLineItem>(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> SaveAsync(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null) => SaveAsync<LineItem>(direction, orderID, lineItemID, lineItem, accessToken);
		public Task<TLineItem> SaveAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<LineItem> PatchAsync(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null) => PatchAsync<LineItem>(direction, orderID, lineItemID, partialLineItem, accessToken);
		public Task<TLineItem> PatchAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> SetShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null) => SetShippingAddressAsync<LineItem>(direction, orderID, lineItemID, address, accessToken);
		public Task<TLineItem> SetShippingAddressAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TLineItem>();
		public Task<LineItem> PatchShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null) => PatchShippingAddressAsync<LineItem>(direction, orderID, lineItemID, partialAddress, accessToken);
		public Task<TLineItem> PatchShippingAddressAsync<TLineItem>(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null) where TLineItem : LineItem => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TLineItem>();
		public Task<ListPage<ExtendedLineItem>> ListAcrossOrdersAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAcrossOrdersAsync<ExtendedLineItem>(direction, buyerID, supplierID, from, to, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TExtendedLineItem>> ListAcrossOrdersAsync<TExtendedLineItem>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TExtendedLineItem : ExtendedLineItem => Request("v1", "lineitems", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to, search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TExtendedLineItem>>();
		public Task<ListPage<ExtendedLineItem>> ListAcrossOrdersAsync(OrderDirection direction, Action<ListOptionsBuilder2<ExtendedLineItem>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => ListAcrossOrdersAsync<ExtendedLineItem>(direction, buildListOpts, buyerID, supplierID, from, to, accessToken);
		public Task<ListPage<TExtendedLineItem>> ListAcrossOrdersAsync<TExtendedLineItem>(OrderDirection direction, Action<ListOptionsBuilder2<TExtendedLineItem>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TExtendedLineItem : ExtendedLineItem => Request("v1", "lineitems", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TExtendedLineItem>>();
	}

	public class LocalesResource : OrderCloudResource, ILocalesResource
	{
		internal LocalesResource(OrderCloudClient client) : base(client) { }
		public Task<Locale> GetAsync(string localeID, string accessToken = null) => Request("v1", "locales", localeID).WithOAuthBearerToken(accessToken).GetJsonAsync<Locale>();
		public Task<ListPage<Locale>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "locales").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Locale>>();
		public Task<ListPage<Locale>> ListAsync(Action<ListOptionsBuilder<Locale>> buildListOpts, string accessToken = null) => Request("v1", "locales").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Locale>>();
		public Task<Locale> CreateAsync(Locale locale, string accessToken = null) => Request("v1", "locales").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(locale)).ReceiveJson<Locale>();
		public Task<Locale> SaveAsync(string localeID, Locale locale, string accessToken = null) => Request("v1", "locales", localeID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(locale)).ReceiveJson<Locale>();
		public Task DeleteAsync(string localeID, string accessToken = null) => Request("v1", "locales", localeID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Locale> PatchAsync(string localeID, PartialLocale partialLocale, string accessToken = null) => Request("v1", "locales", localeID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLocale)).ReceiveJson<Locale>();
		public Task<ListPage<LocaleAssignment>> ListAssignmentsAsync(string buyerID = null, string localeID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "locales", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, localeID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<LocaleAssignment>>();
		public Task SaveAssignmentAsync(LocaleAssignment localeAssignment, string accessToken = null) => Request("v1", "locales", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(localeAssignment));
		public Task DeleteAssignmentAsync(string localeID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "locales", localeID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
	}

	public class MeResource : OrderCloudResource, IMeResource
	{
		internal MeResource(OrderCloudClient client) : base(client) { }
		public Task<MeUser> GetAsync(string accessToken = null) => GetAsync<MeUser>(accessToken);
		public Task<TMeUser> GetAsync<TMeUser>(string accessToken = null) where TMeUser : MeUser => Request("v1", "me").WithOAuthBearerToken(accessToken).GetJsonAsync<TMeUser>();
		public Task<MeUser> SaveAsync(MeUser meUser, string accessToken = null) => SaveAsync<MeUser>(meUser, accessToken);
		public Task<TMeUser> SaveAsync<TMeUser>(MeUser meUser, string accessToken = null) where TMeUser : MeUser => Request("v1", "me").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(meUser)).ReceiveJson<TMeUser>();
		public Task<MeUser> PatchAsync(PartialMeUser partialMeUser, string accessToken = null) => PatchAsync<MeUser>(partialMeUser, accessToken);
		public Task<TMeUser> PatchAsync<TMeUser>(PartialMeUser partialMeUser, string accessToken = null) where TMeUser : MeUser => Request("v1", "me").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialMeUser)).ReceiveJson<TMeUser>();
		public Task<ListPage<CostCenter>> ListCostCentersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListCostCentersAsync<CostCenter>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TCostCenter>> ListCostCentersAsync<TCostCenter>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "me", "costcenters").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TCostCenter>>();
		public Task<ListPage<CostCenter>> ListCostCentersAsync(Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null) => ListCostCentersAsync<CostCenter>(buildListOpts, accessToken);
		public Task<ListPage<TCostCenter>> ListCostCentersAsync<TCostCenter>(Action<ListOptionsBuilder<TCostCenter>> buildListOpts, string accessToken = null) where TCostCenter : CostCenter => Request("v1", "me", "costcenters").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCostCenter>>();
		public Task<ListPage<UserGroup>> ListUserGroupsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListUserGroupsAsync<UserGroup>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUserGroup>> ListUserGroupsAsync<TUserGroup>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "me", "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<ListPage<UserGroup>> ListUserGroupsAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => ListUserGroupsAsync<UserGroup>(buildListOpts, accessToken);
		public Task<ListPage<TUserGroup>> ListUserGroupsAsync<TUserGroup>(Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "me", "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<ListPage<BuyerAddress>> ListAddressesAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAddressesAsync<BuyerAddress>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TBuyerAddress>> ListAddressesAsync<TBuyerAddress>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyerAddress : BuyerAddress => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TBuyerAddress>>();
		public Task<ListPage<BuyerAddress>> ListAddressesAsync(Action<ListOptionsBuilder<BuyerAddress>> buildListOpts, string accessToken = null) => ListAddressesAsync<BuyerAddress>(buildListOpts, accessToken);
		public Task<ListPage<TBuyerAddress>> ListAddressesAsync<TBuyerAddress>(Action<ListOptionsBuilder<TBuyerAddress>> buildListOpts, string accessToken = null) where TBuyerAddress : BuyerAddress => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TBuyerAddress>>();
		public Task<BuyerAddress> CreateAddressAsync(BuyerAddress buyerAddress, string accessToken = null) => CreateAddressAsync<BuyerAddress>(buyerAddress, accessToken);
		public Task<TBuyerAddress> CreateAddressAsync<TBuyerAddress>(BuyerAddress buyerAddress, string accessToken = null) where TBuyerAddress : BuyerAddress => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<TBuyerAddress>();
		public Task<BuyerAddress> GetAddressAsync(string addressID, string accessToken = null) => GetAddressAsync<BuyerAddress>(addressID, accessToken);
		public Task<TBuyerAddress> GetAddressAsync<TBuyerAddress>(string addressID, string accessToken = null) where TBuyerAddress : BuyerAddress => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<TBuyerAddress>();
		public Task<BuyerAddress> SaveAddressAsync(string addressID, BuyerAddress buyerAddress, string accessToken = null) => SaveAddressAsync<BuyerAddress>(addressID, buyerAddress, accessToken);
		public Task<TBuyerAddress> SaveAddressAsync<TBuyerAddress>(string addressID, BuyerAddress buyerAddress, string accessToken = null) where TBuyerAddress : BuyerAddress => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<TBuyerAddress>();
		public Task PatchAddressAsync(string addressID, PartialBuyerAddress partialBuyerAddress, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyerAddress));
		public Task DeleteAddressAsync(string addressID, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<BuyerCreditCard> CreateCreditCardAsync(BuyerCreditCard buyerCreditCard, string accessToken = null) => CreateCreditCardAsync<BuyerCreditCard>(buyerCreditCard, accessToken);
		public Task<TBuyerCreditCard> CreateCreditCardAsync<TBuyerCreditCard>(BuyerCreditCard buyerCreditCard, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<TBuyerCreditCard>();
		public Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListCreditCardsAsync<BuyerCreditCard>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TBuyerCreditCard>> ListCreditCardsAsync<TBuyerCreditCard>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TBuyerCreditCard>>();
		public Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(Action<ListOptionsBuilder<BuyerCreditCard>> buildListOpts, string accessToken = null) => ListCreditCardsAsync<BuyerCreditCard>(buildListOpts, accessToken);
		public Task<ListPage<TBuyerCreditCard>> ListCreditCardsAsync<TBuyerCreditCard>(Action<ListOptionsBuilder<TBuyerCreditCard>> buildListOpts, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TBuyerCreditCard>>();
		public Task<BuyerCreditCard> GetCreditCardAsync(string creditcardID, string accessToken = null) => GetCreditCardAsync<BuyerCreditCard>(creditcardID, accessToken);
		public Task<TBuyerCreditCard> GetCreditCardAsync<TBuyerCreditCard>(string creditcardID, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).GetJsonAsync<TBuyerCreditCard>();
		public Task<BuyerCreditCard> SaveCreditCardAsync(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null) => SaveCreditCardAsync<BuyerCreditCard>(creditcardID, buyerCreditCard, accessToken);
		public Task<TBuyerCreditCard> SaveCreditCardAsync<TBuyerCreditCard>(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null) where TBuyerCreditCard : BuyerCreditCard => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<TBuyerCreditCard>();
		public Task PatchCreditCardAsync(string creditcardID, PartialBuyerCreditCard partialBuyerCreditCard, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyerCreditCard));
		public Task DeleteCreditCardAsync(string creditcardID, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<Category>> ListCategoriesAsync(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListCategoriesAsync<Category>(depth, catalogID, productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TCategory>> ListCategoriesAsync<TCategory>(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TCategory : Category => Request("v1", "me", "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, catalogID, productID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TCategory>>();
		public Task<ListPage<Category>> ListCategoriesAsync(Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null) => ListCategoriesAsync<Category>(buildListOpts, depth, catalogID, productID, accessToken);
		public Task<ListPage<TCategory>> ListCategoriesAsync<TCategory>(Action<ListOptionsBuilder<TCategory>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null) where TCategory : Category => Request("v1", "me", "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, catalogID, productID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCategory>>();
		public Task<Category> GetCategoryAsync(string categoryID, string catalogID, string accessToken = null) => GetCategoryAsync<Category>(categoryID, catalogID, accessToken);
		public Task<TCategory> GetCategoryAsync<TCategory>(string categoryID, string catalogID, string accessToken = null) where TCategory : Category => Request("v1", "me", "categories", categoryID).WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).GetJsonAsync<TCategory>();
		public Task<ListPageWithFacets<BuyerProduct>> ListProductsAsync(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null) => ListProductsAsync<BuyerProduct>(catalogID, categoryID, depth, search, searchOn, searchType, sortBy, page, pageSize, filters, sellerID, accessToken);
		public Task<ListPageWithFacets<TBuyerProduct>> ListProductsAsync<TBuyerProduct>(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null) where TBuyerProduct : BuyerProduct => Request("v1", "me", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, depth, search, searchOn, searchType, sortBy, page, pageSize, sellerID }).SetQueryParams(filters).GetJsonAsync<ListPageWithFacets<TBuyerProduct>>();
		public Task<ListPageWithFacets<BuyerProduct>> ListProductsAsync(Action<ListOptionsBuilder2<BuyerProduct>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string sellerID = null, string accessToken = null) => ListProductsAsync<BuyerProduct>(buildListOpts, catalogID, categoryID, depth, sellerID, accessToken);
		public Task<ListPageWithFacets<TBuyerProduct>> ListProductsAsync<TBuyerProduct>(Action<ListOptionsBuilder2<TBuyerProduct>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string sellerID = null, string accessToken = null) where TBuyerProduct : BuyerProduct => Request("v1", "me", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, depth, sellerID }).SetListOptions(buildListOpts).GetJsonAsync<ListPageWithFacets<TBuyerProduct>>();
		public Task<BuyerProduct> GetProductAsync(string productID, string sellerID = null, string accessToken = null) => GetProductAsync<BuyerProduct>(productID, sellerID, accessToken);
		public Task<TBuyerProduct> GetProductAsync<TBuyerProduct>(string productID, string sellerID = null, string accessToken = null) where TBuyerProduct : BuyerProduct => Request("v1", "me", "products", productID).WithOAuthBearerToken(accessToken).SetQueryParams(new { sellerID }).GetJsonAsync<TBuyerProduct>();
		public Task<ListPage<Spec>> ListSpecsAsync(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListSpecsAsync<Spec>(productID, catalogID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpec : Spec => Request("v1", "me", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSpec>>();
		public Task<ListPage<Spec>> ListSpecsAsync(string productID, Action<ListOptionsBuilder<Spec>> buildListOpts, string catalogID = null, string accessToken = null) => ListSpecsAsync<Spec>(productID, buildListOpts, catalogID, accessToken);
		public Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, Action<ListOptionsBuilder<TSpec>> buildListOpts, string catalogID = null, string accessToken = null) where TSpec : Spec => Request("v1", "me", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSpec>>();
		public Task<Spec> GetSpecAsync(string productID, string specID, string catalogID = null, string accessToken = null) => GetSpecAsync<Spec>(productID, specID, catalogID, accessToken);
		public Task<TSpec> GetSpecAsync<TSpec>(string productID, string specID, string catalogID = null, string accessToken = null) where TSpec : Spec => Request("v1", "me", "products", productID, "specs", specID).WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).GetJsonAsync<TSpec>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListVariantsAsync<Variant>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TVariant : Variant => Request("v1", "me", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TVariant>>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, Action<ListOptionsBuilder<Variant>> buildListOpts, string accessToken = null) => ListVariantsAsync<Variant>(productID, buildListOpts, accessToken);
		public Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, Action<ListOptionsBuilder<TVariant>> buildListOpts, string accessToken = null) where TVariant : Variant => Request("v1", "me", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TVariant>>();
		public Task<Variant> GetVariantAsync(string productID, string variantID, string accessToken = null) => GetVariantAsync<Variant>(productID, variantID, accessToken);
		public Task<TVariant> GetVariantAsync<TVariant>(string productID, string variantID, string accessToken = null) where TVariant : Variant => Request("v1", "me", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).GetJsonAsync<TVariant>();
		public Task<ListPage<InventoryRecord>> ListProductInventoryRecordsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListProductInventoryRecordsAsync<InventoryRecord>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TInventoryRecord>> ListProductInventoryRecordsAsync<TInventoryRecord>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "me", "products", productID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<ListPage<InventoryRecord>> ListProductInventoryRecordsAsync(string productID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null) => ListProductInventoryRecordsAsync<InventoryRecord>(productID, buildListOpts, accessToken);
		public Task<ListPage<TInventoryRecord>> ListProductInventoryRecordsAsync<TInventoryRecord>(string productID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "me", "products", productID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<ListPage<InventoryRecord>> ListVariantInventoryRecordsAsync(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListVariantInventoryRecordsAsync<InventoryRecord>(productID, variantID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TInventoryRecord>> ListVariantInventoryRecordsAsync<TInventoryRecord>(string productID, string variantID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "me", "products", productID, "variants", variantID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<ListPage<InventoryRecord>> ListVariantInventoryRecordsAsync(string productID, string variantID, Action<ListOptionsBuilder<InventoryRecord>> buildListOpts, string accessToken = null) => ListVariantInventoryRecordsAsync<InventoryRecord>(productID, variantID, buildListOpts, accessToken);
		public Task<ListPage<TInventoryRecord>> ListVariantInventoryRecordsAsync<TInventoryRecord>(string productID, string variantID, Action<ListOptionsBuilder<TInventoryRecord>> buildListOpts, string accessToken = null) where TInventoryRecord : InventoryRecord => Request("v1", "me", "products", productID, "variants", variantID, "inventoryrecords").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TInventoryRecord>>();
		public Task<ListPage<Order>> ListOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListOrdersAsync<Order>(from, to, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrder>> ListOrdersAsync<TOrder>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrder : Order => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to, search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrder>>();
		public Task<ListPage<Order>> ListOrdersAsync(Action<ListOptionsBuilder2<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => ListOrdersAsync<Order>(buildListOpts, from, to, accessToken);
		public Task<ListPage<TOrder>> ListOrdersAsync<TOrder>(Action<ListOptionsBuilder2<TOrder>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TOrder : Order => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrder>>();
		public Task<ListPage<Order>> ListApprovableOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListApprovableOrdersAsync<Order>(from, to, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrder>> ListApprovableOrdersAsync<TOrder>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrder : Order => Request("v1", "me", "orders", "approvable").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrder>>();
		public Task<ListPage<Order>> ListApprovableOrdersAsync(Action<ListOptionsBuilder<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => ListApprovableOrdersAsync<Order>(buildListOpts, from, to, accessToken);
		public Task<ListPage<TOrder>> ListApprovableOrdersAsync<TOrder>(Action<ListOptionsBuilder<TOrder>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TOrder : Order => Request("v1", "me", "orders", "approvable").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrder>>();
		public Task TransferAnonUserOrderAsync(string anonUserToken, string accessToken = null) => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { anonUserToken }).PutAsync(null);
		public Task ResetPasswordByTokenAsync(TokenPasswordReset tokenPasswordReset, string accessToken = null) => Request("v1", "me", "password").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(tokenPasswordReset));
		public Task<ListPage<Promotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListPromotionsAsync<Promotion>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPromotion>> ListPromotionsAsync<TPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion => Request("v1", "me", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPromotion>>();
		public Task<ListPage<Promotion>> ListPromotionsAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null) => ListPromotionsAsync<Promotion>(buildListOpts, accessToken);
		public Task<ListPage<TPromotion>> ListPromotionsAsync<TPromotion>(Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion => Request("v1", "me", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPromotion>>();
		public Task<Promotion> GetPromotionAsync(string promotionID, string accessToken = null) => GetPromotionAsync<Promotion>(promotionID, accessToken);
		public Task<TPromotion> GetPromotionAsync<TPromotion>(string promotionID, string accessToken = null) where TPromotion : Promotion => Request("v1", "me", "promotions", promotionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TPromotion>();
		public Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListSpendingAccountsAsync<SpendingAccount>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSpendingAccount>> ListSpendingAccountsAsync<TSpendingAccount>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "me", "spendingAccounts").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSpendingAccount>>();
		public Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null) => ListSpendingAccountsAsync<SpendingAccount>(buildListOpts, accessToken);
		public Task<ListPage<TSpendingAccount>> ListSpendingAccountsAsync<TSpendingAccount>(Action<ListOptionsBuilder<TSpendingAccount>> buildListOpts, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "me", "spendingAccounts").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSpendingAccount>>();
		public Task<SpendingAccount> GetSpendingAccountAsync(string spendingAccountID, string accessToken = null) => GetSpendingAccountAsync<SpendingAccount>(spendingAccountID, accessToken);
		public Task<TSpendingAccount> GetSpendingAccountAsync<TSpendingAccount>(string spendingAccountID, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "me", "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSpendingAccount>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListShipmentsAsync<Shipment>(orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipment : Shipment => Request("v1", "me", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TShipment>>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null) => ListShipmentsAsync<Shipment>(buildListOpts, orderID, accessToken);
		public Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(Action<ListOptionsBuilder<TShipment>> buildListOpts, string orderID = null, string accessToken = null) where TShipment : Shipment => Request("v1", "me", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TShipment>>();
		public Task<Shipment> GetShipmentAsync(string shipmentID, string accessToken = null) => GetShipmentAsync<Shipment>(shipmentID, accessToken);
		public Task<TShipment> GetShipmentAsync<TShipment>(string shipmentID, string accessToken = null) where TShipment : Shipment => Request("v1", "me", "shipments", shipmentID).WithOAuthBearerToken(accessToken).GetJsonAsync<TShipment>();
		public Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListShipmentItemsAsync<ShipmentItem>(shipmentID, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TShipmentItem>> ListShipmentItemsAsync<TShipmentItem>(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipmentItem : ShipmentItem => Request("v1", "me", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TShipmentItem>>();
		public Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string orderID = null, string accessToken = null) => ListShipmentItemsAsync<ShipmentItem>(shipmentID, buildListOpts, orderID, accessToken);
		public Task<ListPage<TShipmentItem>> ListShipmentItemsAsync<TShipmentItem>(string shipmentID, Action<ListOptionsBuilder<TShipmentItem>> buildListOpts, string orderID = null, string accessToken = null) where TShipmentItem : ShipmentItem => Request("v1", "me", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TShipmentItem>>();
		public Task<AccessTokenBasic> RegisterAsync(MeUser meUser, string anonUserToken, string accessToken = null) => Request("v1", "me", "register").WithOAuthBearerToken(accessToken).SetQueryParams(new { anonUserToken }).PutJsonAsync(ValidateModel(meUser)).ReceiveJson<AccessTokenBasic>();
		public Task<ListPage<Catalog>> ListCatalogsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null) => ListCatalogsAsync<Catalog>(search, searchOn, sortBy, page, pageSize, filters, sellerID, accessToken);
		public Task<ListPage<TCatalog>> ListCatalogsAsync<TCatalog>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string sellerID = null, string accessToken = null) where TCatalog : Catalog => Request("v1", "me", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize, sellerID }).SetQueryParams(filters).GetJsonAsync<ListPage<TCatalog>>();
		public Task<ListPage<Catalog>> ListCatalogsAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string sellerID = null, string accessToken = null) => ListCatalogsAsync<Catalog>(buildListOpts, sellerID, accessToken);
		public Task<ListPage<TCatalog>> ListCatalogsAsync<TCatalog>(Action<ListOptionsBuilder<TCatalog>> buildListOpts, string sellerID = null, string accessToken = null) where TCatalog : Catalog => Request("v1", "me", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { sellerID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TCatalog>>();
		public Task<Catalog> GetCatalogAsync(string catalogID, string accessToken = null) => GetCatalogAsync<Catalog>(catalogID, accessToken);
		public Task<TCatalog> GetCatalogAsync<TCatalog>(string catalogID, string accessToken = null) where TCatalog : Catalog => Request("v1", "me", "catalogs", catalogID).WithOAuthBearerToken(accessToken).GetJsonAsync<TCatalog>();
		public Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "sellers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerSupplier>>();
		public Task<ListPage<BuyerSupplier>> ListBuyerSellersAsync(Action<ListOptionsBuilder<BuyerSupplier>> buildListOpts, string accessToken = null) => Request("v1", "me", "sellers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerSupplier>>();
		public Task<ProductCollection> CreateProductCollectionAsync(ProductCollection productCollection, string accessToken = null) => CreateProductCollectionAsync<ProductCollection>(productCollection, accessToken);
		public Task<TProductCollection> CreateProductCollectionAsync<TProductCollection>(ProductCollection productCollection, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "me", "productcollections").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productCollection)).ReceiveJson<TProductCollection>();
		public Task<ProductCollection> GetProductCollectionAsync(string productCollectionID, string accessToken = null) => GetProductCollectionAsync<ProductCollection>(productCollectionID, accessToken);
		public Task<TProductCollection> GetProductCollectionAsync<TProductCollection>(string productCollectionID, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "me", "productcollections", productCollectionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TProductCollection>();
		public Task<ListPage<ProductCollection>> ListProductCollectionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListProductCollectionsAsync<ProductCollection>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TProductCollection>> ListProductCollectionsAsync<TProductCollection>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "me", "productcollections").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TProductCollection>>();
		public Task<ListPage<ProductCollection>> ListProductCollectionsAsync(Action<ListOptionsBuilder<ProductCollection>> buildListOpts, string accessToken = null) => ListProductCollectionsAsync<ProductCollection>(buildListOpts, accessToken);
		public Task<ListPage<TProductCollection>> ListProductCollectionsAsync<TProductCollection>(Action<ListOptionsBuilder<TProductCollection>> buildListOpts, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "me", "productcollections").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TProductCollection>>();
		public Task<ProductCollection> PatchProductCollectionAsync(string productCollectionID, PartialProductCollection partialProductCollection, string accessToken = null) => PatchProductCollectionAsync<ProductCollection>(productCollectionID, partialProductCollection, accessToken);
		public Task<TProductCollection> PatchProductCollectionAsync<TProductCollection>(string productCollectionID, PartialProductCollection partialProductCollection, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "me", "productcollections", productCollectionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProductCollection)).ReceiveJson<TProductCollection>();
		public Task<ProductCollection> SaveProductCollectionAsync(string productCollectionID, ProductCollection productCollection, string accessToken = null) => SaveProductCollectionAsync<ProductCollection>(productCollectionID, productCollection, accessToken);
		public Task<TProductCollection> SaveProductCollectionAsync<TProductCollection>(string productCollectionID, ProductCollection productCollection, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "me", "productcollections", productCollectionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(productCollection)).ReceiveJson<TProductCollection>();
		public Task DeleteProductCollectionAsync(string productCollectionID, string accessToken = null) => Request("v1", "me", "productcollections", productCollectionID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPageWithFacets<BuyerProduct>> ListProductCollectionEntriesAsync(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListProductCollectionEntriesAsync<BuyerProduct>(productCollectionID, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPageWithFacets<TBuyerProduct>> ListProductCollectionEntriesAsync<TBuyerProduct>(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TBuyerProduct : BuyerProduct => Request("v1", "me", "productcollections", productCollectionID, "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPageWithFacets<TBuyerProduct>>();
		public Task<ListPageWithFacets<BuyerProduct>> ListProductCollectionEntriesAsync(string productCollectionID, Action<ListOptionsBuilder2<BuyerProduct>> buildListOpts, string accessToken = null) => ListProductCollectionEntriesAsync<BuyerProduct>(productCollectionID, buildListOpts, accessToken);
		public Task<ListPageWithFacets<TBuyerProduct>> ListProductCollectionEntriesAsync<TBuyerProduct>(string productCollectionID, Action<ListOptionsBuilder2<TBuyerProduct>> buildListOpts, string accessToken = null) where TBuyerProduct : BuyerProduct => Request("v1", "me", "productcollections", productCollectionID, "products").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPageWithFacets<TBuyerProduct>>();
		public Task CreateProductCollectionEntryAsync(string productCollectionID, string productID, string accessToken = null) => Request("v1", "me", "productcollections", productCollectionID, productID).WithOAuthBearerToken(accessToken).PutAsync(null);
		public Task DeleteProductCollectionEntryAsync(string productCollectionID, string productID, string accessToken = null) => Request("v1", "me", "productcollections", productCollectionID, productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ProductCollectionInvitation> CreateProductCollectionInvitationAsync(string productCollectionID, ProductCollectionInvitation productCollectionInvitation, string accessToken = null) => CreateProductCollectionInvitationAsync<ProductCollectionInvitation>(productCollectionID, productCollectionInvitation, accessToken);
		public Task<TProductCollectionInvitation> CreateProductCollectionInvitationAsync<TProductCollectionInvitation>(string productCollectionID, ProductCollectionInvitation productCollectionInvitation, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation => Request("v1", "me", "productcollections", productCollectionID, "invitations").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productCollectionInvitation)).ReceiveJson<TProductCollectionInvitation>();
		public Task<ProductCollectionInvitation> PatchProductCollectionInvitationAsync(string productCollectionID, string invitationID, PartialProductCollectionInvitation partialProductCollectionInvitation, string accessToken = null) => PatchProductCollectionInvitationAsync<ProductCollectionInvitation>(productCollectionID, invitationID, partialProductCollectionInvitation, accessToken);
		public Task<TProductCollectionInvitation> PatchProductCollectionInvitationAsync<TProductCollectionInvitation>(string productCollectionID, string invitationID, PartialProductCollectionInvitation partialProductCollectionInvitation, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation => Request("v1", "me", "productcollections", productCollectionID, "invitations", invitationID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProductCollectionInvitation)).ReceiveJson<TProductCollectionInvitation>();
		public Task DeleteProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null) => Request("v1", "me", "productcollections", productCollectionID, "invitations", invitationID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ProductCollectionInvitation> GetProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null) => GetProductCollectionInvitationAsync<ProductCollectionInvitation>(productCollectionID, invitationID, accessToken);
		public Task<TProductCollectionInvitation> GetProductCollectionInvitationAsync<TProductCollectionInvitation>(string productCollectionID, string invitationID, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation => Request("v1", "me", "productcollections", productCollectionID, "invitations", invitationID).WithOAuthBearerToken(accessToken).GetJsonAsync<TProductCollectionInvitation>();
		public Task<ListPage<ProductCollectionInvitation>> ListProductCollectionInvitationsAsync(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListProductCollectionInvitationsAsync<ProductCollectionInvitation>(productCollectionID, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TProductCollectionInvitation>> ListProductCollectionInvitationsAsync<TProductCollectionInvitation>(string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation => Request("v1", "me", "productcollections", productCollectionID, "invitations").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TProductCollectionInvitation>>();
		public Task<ListPage<ProductCollectionInvitation>> ListProductCollectionInvitationsAsync(string productCollectionID, Action<ListOptionsBuilder2<ProductCollectionInvitation>> buildListOpts, string accessToken = null) => ListProductCollectionInvitationsAsync<ProductCollectionInvitation>(productCollectionID, buildListOpts, accessToken);
		public Task<ListPage<TProductCollectionInvitation>> ListProductCollectionInvitationsAsync<TProductCollectionInvitation>(string productCollectionID, Action<ListOptionsBuilder2<TProductCollectionInvitation>> buildListOpts, string accessToken = null) where TProductCollectionInvitation : ProductCollectionInvitation => Request("v1", "me", "productcollections", productCollectionID, "invitations").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TProductCollectionInvitation>>();
		public Task AcceptProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null) => Request("v1", "me", "productcollections", productCollectionID, "invitations", "accept", invitationID).WithOAuthBearerToken(accessToken).PostAsync(null);
		public Task DeclineProductCollectionInvitationAsync(string productCollectionID, string invitationID, string accessToken = null) => Request("v1", "me", "productcollections", productCollectionID, "invitations", "decline", invitationID).WithOAuthBearerToken(accessToken).PostAsync(null);
		public Task<ListPage<Subscription>> ListSubscriptionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListSubscriptionsAsync<Subscription>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSubscription>> ListSubscriptionsAsync<TSubscription>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSubscription : Subscription => Request("v1", "me", "subscriptions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSubscription>>();
		public Task<ListPage<Subscription>> ListSubscriptionsAsync(Action<ListOptionsBuilder<Subscription>> buildListOpts, string accessToken = null) => ListSubscriptionsAsync<Subscription>(buildListOpts, accessToken);
		public Task<ListPage<TSubscription>> ListSubscriptionsAsync<TSubscription>(Action<ListOptionsBuilder<TSubscription>> buildListOpts, string accessToken = null) where TSubscription : Subscription => Request("v1", "me", "subscriptions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSubscription>>();
		public Task<Subscription> GetSubscriptionAsync(string subscriptionID, string accessToken = null) => GetSubscriptionAsync<Subscription>(subscriptionID, accessToken);
		public Task<TSubscription> GetSubscriptionAsync<TSubscription>(string subscriptionID, string accessToken = null) where TSubscription : Subscription => Request("v1", "me", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSubscription>();
		public Task<Subscription> CreateSubscriptionAsync(Subscription subscription, string accessToken = null) => CreateSubscriptionAsync<Subscription>(subscription, accessToken);
		public Task<TSubscription> CreateSubscriptionAsync<TSubscription>(Subscription subscription, string accessToken = null) where TSubscription : Subscription => Request("v1", "me", "subscriptions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(subscription)).ReceiveJson<TSubscription>();
		public Task<Subscription> SaveSubscriptionAsync(string subscriptionID, Subscription subscription, string accessToken = null) => SaveSubscriptionAsync<Subscription>(subscriptionID, subscription, accessToken);
		public Task<TSubscription> SaveSubscriptionAsync<TSubscription>(string subscriptionID, Subscription subscription, string accessToken = null) where TSubscription : Subscription => Request("v1", "me", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(subscription)).ReceiveJson<TSubscription>();
		public Task<Subscription> PatchSubscriptionAsync(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null) => PatchSubscriptionAsync<Subscription>(subscriptionID, partialSubscription, accessToken);
		public Task<TSubscription> PatchSubscriptionAsync<TSubscription>(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null) where TSubscription : Subscription => Request("v1", "me", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSubscription)).ReceiveJson<TSubscription>();
		public Task DeleteSubscriptionAsync(string subscriptionID, string accessToken = null) => Request("v1", "me", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<LineItem>> ListSubscriptionItemsAsync(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListSubscriptionItemsAsync<LineItem>(subscriptionID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TLineItem>> ListSubscriptionItemsAsync<TLineItem>(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TLineItem>>();
		public Task<ListPage<LineItem>> ListSubscriptionItemsAsync(string subscriptionID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null) => ListSubscriptionItemsAsync<LineItem>(subscriptionID, buildListOpts, accessToken);
		public Task<ListPage<TLineItem>> ListSubscriptionItemsAsync<TLineItem>(string subscriptionID, Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TLineItem>>();
		public Task<LineItem> GetSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, string accessToken = null) => GetSubscriptionItemAsync<LineItem>(subscriptionID, subscriptionItemID, accessToken);
		public Task<TLineItem> GetSubscriptionItemAsync<TLineItem>(string subscriptionID, string subscriptionItemID, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<TLineItem>();
		public Task<LineItem> CreateSubscriptionItemAsync(string subscriptionID, LineItem lineItem, string accessToken = null) => CreateSubscriptionItemAsync<LineItem>(subscriptionID, lineItem, accessToken);
		public Task<TLineItem> CreateSubscriptionItemAsync<TLineItem>(string subscriptionID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> SaveSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null) => SaveSubscriptionItemAsync<LineItem>(subscriptionID, subscriptionItemID, lineItem, accessToken);
		public Task<TLineItem> SaveSubscriptionItemAsync<TLineItem>(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> PatchSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null) => PatchSubscriptionItemAsync<LineItem>(subscriptionID, subscriptionItemID, partialLineItem, accessToken);
		public Task<TLineItem> PatchSubscriptionItemAsync<TLineItem>(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<TLineItem>();
		public Task DeleteSubscriptionItemAsync(string subscriptionID, string subscriptionItemID, string accessToken = null) => Request("v1", "me", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<LineItem> CreateSubscriptionBundleItemAsync(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null) => CreateSubscriptionBundleItemAsync<LineItem>(subscriptionID, bundleID, bundleItems, accessToken);
		public Task<TLineItem> CreateSubscriptionBundleItemAsync<TLineItem>(string subscriptionID, string bundleID, BundleItems bundleItems, string accessToken = null) where TLineItem : LineItem => Request("v1", "me", "subscriptions", subscriptionID, "items", "bundles", bundleID).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(bundleItems)).ReceiveJson<TLineItem>();
		public Task DeleteSubscriptionBundleItemAsync(string subscriptionID, string bundleID, string bundleItemID, string accessToken = null) => Request("v1", "me", "subscriptions", subscriptionID, "items", "bundles", bundleID, bundleItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<ProductSeller>> ListProductSellersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListProductSellersAsync<ProductSeller>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TProductSeller>> ListProductSellersAsync<TProductSeller>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductSeller : ProductSeller => Request("v1", "me", "products", productID, "sellers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TProductSeller>>();
		public Task<ListPage<ProductSeller>> ListProductSellersAsync(string productID, Action<ListOptionsBuilder<ProductSeller>> buildListOpts, string accessToken = null) => ListProductSellersAsync<ProductSeller>(productID, buildListOpts, accessToken);
		public Task<ListPage<TProductSeller>> ListProductSellersAsync<TProductSeller>(string productID, Action<ListOptionsBuilder<TProductSeller>> buildListOpts, string accessToken = null) where TProductSeller : ProductSeller => Request("v1", "me", "products", productID, "sellers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TProductSeller>>();
	}

	public class MessageSendersResource : OrderCloudResource, IMessageSendersResource
	{
		internal MessageSendersResource(OrderCloudClient client) : base(client) { }
		public Task<MessageSender> GetAsync(string messageSenderID, string accessToken = null) => GetAsync<MessageSender>(messageSenderID, accessToken);
		public Task<TMessageSender> GetAsync<TMessageSender>(string messageSenderID, string accessToken = null) where TMessageSender : MessageSender => Request("v1", "messagesenders", messageSenderID).WithOAuthBearerToken(accessToken).GetJsonAsync<TMessageSender>();
		public Task<ListPage<MessageSender>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<MessageSender>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TMessageSender>> ListAsync<TMessageSender>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TMessageSender : MessageSender => Request("v1", "messagesenders").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TMessageSender>>();
		public Task<ListPage<MessageSender>> ListAsync(Action<ListOptionsBuilder<MessageSender>> buildListOpts, string accessToken = null) => ListAsync<MessageSender>(buildListOpts, accessToken);
		public Task<ListPage<TMessageSender>> ListAsync<TMessageSender>(Action<ListOptionsBuilder<TMessageSender>> buildListOpts, string accessToken = null) where TMessageSender : MessageSender => Request("v1", "messagesenders").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TMessageSender>>();
		public Task<MessageSender> CreateAsync(MessageSender messageSender, string accessToken = null) => CreateAsync<MessageSender>(messageSender, accessToken);
		public Task<TMessageSender> CreateAsync<TMessageSender>(MessageSender messageSender, string accessToken = null) where TMessageSender : MessageSender => Request("v1", "messagesenders").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(messageSender)).ReceiveJson<TMessageSender>();
		public Task<MessageSender> SaveAsync(string messageSenderID, MessageSender messageSender, string accessToken = null) => SaveAsync<MessageSender>(messageSenderID, messageSender, accessToken);
		public Task<TMessageSender> SaveAsync<TMessageSender>(string messageSenderID, MessageSender messageSender, string accessToken = null) where TMessageSender : MessageSender => Request("v1", "messagesenders", messageSenderID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(messageSender)).ReceiveJson<TMessageSender>();
		public Task DeleteAsync(string messageSenderID, string accessToken = null) => Request("v1", "messagesenders", messageSenderID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<MessageSender> PatchAsync(string messageSenderID, PartialMessageSender partialMessageSender, string accessToken = null) => PatchAsync<MessageSender>(messageSenderID, partialMessageSender, accessToken);
		public Task<TMessageSender> PatchAsync<TMessageSender>(string messageSenderID, PartialMessageSender partialMessageSender, string accessToken = null) where TMessageSender : MessageSender => Request("v1", "messagesenders", messageSenderID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialMessageSender)).ReceiveJson<TMessageSender>();
		public Task<ListPage<MessageSenderAssignment>> ListAssignmentsAsync(string buyerID = null, string messageSenderID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string supplierID = null, string accessToken = null) => Request("v1", "messagesenders", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, messageSenderID, userID, userGroupID, level, page, pageSize, supplierID }).GetJsonAsync<ListPage<MessageSenderAssignment>>();
		public Task DeleteAssignmentAsync(string messageSenderID, string buyerID = null, string userID = null, string userGroupID = null, string supplierID = null, string accessToken = null) => Request("v1", "messagesenders", messageSenderID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID, supplierID }).DeleteAsync();
		public Task SaveAssignmentAsync(MessageSenderAssignment messageSenderAssignment, string accessToken = null) => Request("v1", "messagesenders", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(messageSenderAssignment));
		public Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "messagesenders", "CCListenerAssignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<MessageCCListenerAssignment>>();
		public Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(Action<ListOptionsBuilder<MessageCCListenerAssignment>> buildListOpts, string accessToken = null) => Request("v1", "messagesenders", "CCListenerAssignments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<MessageCCListenerAssignment>>();
		public Task SaveCCListenerAssignmentAsync(MessageCCListenerAssignment messageCCListenerAssignment, string accessToken = null) => Request("v1", "messagesenders", "CCListenerAssignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(messageCCListenerAssignment));
	}

	public class OpenIdConnectsResource : OrderCloudResource, IOpenIdConnectsResource
	{
		internal OpenIdConnectsResource(OrderCloudClient client) : base(client) { }
		public Task<OpenIdConnect> GetAsync(string openidconnectID, string accessToken = null) => Request("v1", "openidconnects", openidconnectID).WithOAuthBearerToken(accessToken).GetJsonAsync<OpenIdConnect>();
		public Task<ListPage<OpenIdConnect>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "openidconnects").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OpenIdConnect>>();
		public Task<ListPage<OpenIdConnect>> ListAsync(Action<ListOptionsBuilder<OpenIdConnect>> buildListOpts, string accessToken = null) => Request("v1", "openidconnects").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<OpenIdConnect>>();
		public Task<OpenIdConnect> CreateAsync(OpenIdConnect openIdConnect, string accessToken = null) => Request("v1", "openidconnects").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(openIdConnect)).ReceiveJson<OpenIdConnect>();
		public Task<OpenIdConnect> SaveAsync(string openidconnectID, OpenIdConnect openIdConnect, string accessToken = null) => Request("v1", "openidconnects", openidconnectID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(openIdConnect)).ReceiveJson<OpenIdConnect>();
		public Task DeleteAsync(string openidconnectID, string accessToken = null) => Request("v1", "openidconnects", openidconnectID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<OpenIdConnect> PatchAsync(string openidconnectID, PartialOpenIdConnect partialOpenIdConnect, string accessToken = null) => Request("v1", "openidconnects", openidconnectID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOpenIdConnect)).ReceiveJson<OpenIdConnect>();
	}

	public class OrderReturnsResource : OrderCloudResource, IOrderReturnsResource
	{
		internal OrderReturnsResource(OrderCloudClient client) : base(client) { }
		public Task<OrderReturn> GetAsync(string returnID, string accessToken = null) => GetAsync<OrderReturn>(returnID, accessToken);
		public Task<TOrderReturn> GetAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID).WithOAuthBearerToken(accessToken).GetJsonAsync<TOrderReturn>();
		public Task<ListPage<OrderReturn>> ListAsync(bool approvable = false, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<OrderReturn>(approvable, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrderReturn>> ListAsync<TOrderReturn>(bool approvable = false, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns").WithOAuthBearerToken(accessToken).SetQueryParams(new { approvable, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrderReturn>>();
		public Task<ListPage<OrderReturn>> ListAsync(Action<ListOptionsBuilder<OrderReturn>> buildListOpts, bool approvable = false, string accessToken = null) => ListAsync<OrderReturn>(buildListOpts, approvable, accessToken);
		public Task<ListPage<TOrderReturn>> ListAsync<TOrderReturn>(Action<ListOptionsBuilder<TOrderReturn>> buildListOpts, bool approvable = false, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns").WithOAuthBearerToken(accessToken).SetQueryParams(new { approvable }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrderReturn>>();
		public Task<OrderReturn> CreateAsync(OrderReturn orderReturn, string accessToken = null) => CreateAsync<OrderReturn>(orderReturn, accessToken);
		public Task<TOrderReturn> CreateAsync<TOrderReturn>(OrderReturn orderReturn, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderReturn)).ReceiveJson<TOrderReturn>();
		public Task<OrderReturn> SaveAsync(string returnID, OrderReturn orderReturn, string accessToken = null) => SaveAsync<OrderReturn>(returnID, orderReturn, accessToken);
		public Task<TOrderReturn> SaveAsync<TOrderReturn>(string returnID, OrderReturn orderReturn, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(orderReturn)).ReceiveJson<TOrderReturn>();
		public Task DeleteAsync(string returnID, string accessToken = null) => Request("v1", "orderreturns", returnID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<OrderReturn> PatchAsync(string returnID, PartialOrderReturn partialOrderReturn, string accessToken = null) => PatchAsync<OrderReturn>(returnID, partialOrderReturn, accessToken);
		public Task<TOrderReturn> PatchAsync<TOrderReturn>(string returnID, PartialOrderReturn partialOrderReturn, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOrderReturn)).ReceiveJson<TOrderReturn>();
		public Task<OrderReturn> DeleteItemAsync(string returnID, string lineItemID, string accessToken = null) => DeleteItemAsync<OrderReturn>(returnID, lineItemID, accessToken);
		public Task<TOrderReturn> DeleteItemAsync<TOrderReturn>(string returnID, string lineItemID, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID, "items", lineItemID).WithOAuthBearerToken(accessToken).DeleteAsync().ReceiveJson<TOrderReturn>();
		public Task<OrderReturn> CancelAsync(string returnID, string accessToken = null) => CancelAsync<OrderReturn>(returnID, accessToken);
		public Task<TOrderReturn> CancelAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID, "cancel").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderReturn>();
		public Task<OrderReturn> CompleteAsync(string returnID, string accessToken = null) => CompleteAsync<OrderReturn>(returnID, accessToken);
		public Task<TOrderReturn> CompleteAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID, "complete").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderReturn>();
		public Task<OrderReturn> SubmitAsync(string returnID, string accessToken = null) => SubmitAsync<OrderReturn>(returnID, accessToken);
		public Task<TOrderReturn> SubmitAsync<TOrderReturn>(string returnID, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID, "submit").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderReturn>();
		public Task<ListPage<OrderReturnApproval>> ListApprovalsAsync(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListApprovalsAsync<OrderReturnApproval>(returnID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrderReturnApproval>> ListApprovalsAsync<TOrderReturnApproval>(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderReturnApproval : OrderReturnApproval => Request("v1", "orderreturns", returnID, "approvals").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrderReturnApproval>>();
		public Task<ListPage<OrderReturnApproval>> ListApprovalsAsync(string returnID, Action<ListOptionsBuilder<OrderReturnApproval>> buildListOpts, string accessToken = null) => ListApprovalsAsync<OrderReturnApproval>(returnID, buildListOpts, accessToken);
		public Task<ListPage<TOrderReturnApproval>> ListApprovalsAsync<TOrderReturnApproval>(string returnID, Action<ListOptionsBuilder<TOrderReturnApproval>> buildListOpts, string accessToken = null) where TOrderReturnApproval : OrderReturnApproval => Request("v1", "orderreturns", returnID, "approvals").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrderReturnApproval>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListEligibleApproversAsync<User>(returnID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(string returnID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User => Request("v1", "orderreturns", returnID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUser>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(string returnID, Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null) => ListEligibleApproversAsync<User>(returnID, buildListOpts, accessToken);
		public Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(string returnID, Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User => Request("v1", "orderreturns", returnID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUser>>();
		public Task<OrderReturn> ApproveAsync(string returnID, ApprovalInfo approvalInfo, string accessToken = null) => ApproveAsync<OrderReturn>(returnID, approvalInfo, accessToken);
		public Task<TOrderReturn> ApproveAsync<TOrderReturn>(string returnID, ApprovalInfo approvalInfo, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID, "approve").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(approvalInfo)).ReceiveJson<TOrderReturn>();
		public Task<OrderReturn> DeclineAsync(string returnID, ApprovalInfo approvalInfo, string accessToken = null) => DeclineAsync<OrderReturn>(returnID, approvalInfo, accessToken);
		public Task<TOrderReturn> DeclineAsync<TOrderReturn>(string returnID, ApprovalInfo approvalInfo, string accessToken = null) where TOrderReturn : OrderReturn => Request("v1", "orderreturns", returnID, "decline").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(approvalInfo)).ReceiveJson<TOrderReturn>();
	}

	public class OrdersResource : OrderCloudResource, IOrdersResource
	{
		internal OrdersResource(OrderCloudClient client) : base(client) { }
		public Task<Order> GetAsync(OrderDirection direction, string orderID, string accessToken = null) => GetAsync<Order>(direction, orderID, accessToken);
		public Task<TOrder> GetAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).GetJsonAsync<TOrder>();
		public Task<ListPage<Order>> ListAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Order>(direction, buyerID, supplierID, from, to, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrder>> ListAsync<TOrder>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to, search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrder>>();
		public Task<ListPage<Order>> ListAsync(OrderDirection direction, Action<ListOptionsBuilder2<Order>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => ListAsync<Order>(direction, buildListOpts, buyerID, supplierID, from, to, accessToken);
		public Task<ListPage<TOrder>> ListAsync<TOrder>(OrderDirection direction, Action<ListOptionsBuilder2<TOrder>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrder>>();
		public Task<Order> CreateAsync(OrderDirection direction, Order order, string accessToken = null) => CreateAsync<Order>(direction, order, accessToken);
		public Task<TOrder> CreateAsync<TOrder>(OrderDirection direction, Order order, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(order)).ReceiveJson<TOrder>();
		public Task<Order> SaveAsync(OrderDirection direction, string orderID, Order order, string accessToken = null) => SaveAsync<Order>(direction, orderID, order, accessToken);
		public Task<TOrder> SaveAsync<TOrder>(OrderDirection direction, string orderID, Order order, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(order)).ReceiveJson<TOrder>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListApprovalsAsync<OrderApproval>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrderApproval>> ListApprovalsAsync<TOrderApproval>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderApproval : OrderApproval => Request("v1", "orders", direction, orderID, "approvals").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrderApproval>>();
		public Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderApproval>> buildListOpts, string accessToken = null) => ListApprovalsAsync<OrderApproval>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TOrderApproval>> ListApprovalsAsync<TOrderApproval>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TOrderApproval>> buildListOpts, string accessToken = null) where TOrderApproval : OrderApproval => Request("v1", "orders", direction, orderID, "approvals").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrderApproval>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListEligibleApproversAsync<User>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User => Request("v1", "orders", direction, orderID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUser>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null) => ListEligibleApproversAsync<User>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TUser>> ListEligibleApproversAsync<TUser>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User => Request("v1", "orders", direction, orderID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUser>>();
		public Task<Order> PatchAsync(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null) => PatchAsync<Order>(direction, orderID, partialOrder, accessToken);
		public Task<TOrder> PatchAsync<TOrder>(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOrder)).ReceiveJson<TOrder>();
		public Task<Order> SubmitAsync(OrderDirection direction, string orderID, string accessToken = null) => SubmitAsync<Order>(direction, orderID, accessToken);
		public Task<TOrder> SubmitAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "submit").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrder>();
		public Task<Order> ApproveAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) => ApproveAsync<Order>(direction, orderID, orderApprovalInfo, accessToken);
		public Task<TOrder> ApproveAsync<TOrder>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "approve").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<TOrder>();
		public Task<Order> DeclineAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) => DeclineAsync<Order>(direction, orderID, orderApprovalInfo, accessToken);
		public Task<TOrder> DeclineAsync<TOrder>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "decline").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<TOrder>();
		public Task<Order> CancelAsync(OrderDirection direction, string orderID, string accessToken = null) => CancelAsync<Order>(direction, orderID, accessToken);
		public Task<TOrder> CancelAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "cancel").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrder>();
		public Task<OrderSplitResult> SplitAsync(OrderDirection direction, string orderID, string accessToken = null) => SplitAsync<OrderSplitResult>(direction, orderID, accessToken);
		public Task<TOrderSplitResult> SplitAsync<TOrderSplitResult>(OrderDirection direction, string orderID, string accessToken = null) where TOrderSplitResult : OrderSplitResult => Request("v1", "orders", direction, orderID, "split").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderSplitResult>();
		public Task<OrderSplitResult> ForwardAsync(OrderDirection direction, string orderID, string accessToken = null) => ForwardAsync<OrderSplitResult>(direction, orderID, accessToken);
		public Task<TOrderSplitResult> ForwardAsync<TOrderSplitResult>(OrderDirection direction, string orderID, string accessToken = null) where TOrderSplitResult : OrderSplitResult => Request("v1", "orders", direction, orderID, "forward").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderSplitResult>();
		public Task<Order> CompleteAsync(OrderDirection direction, string orderID, string accessToken = null) => CompleteAsync<Order>(direction, orderID, accessToken);
		public Task<TOrder> CompleteAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "complete").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrder>();
		public Task<Order> ShipAsync(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null) => ShipAsync<Order>(direction, orderID, shipment, accessToken);
		public Task<TOrder> ShipAsync<TOrder>(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "ship").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipment)).ReceiveJson<TOrder>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListShipmentsAsync<Shipment>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipment : Shipment => Request("v1", "orders", direction, orderID, "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TShipment>>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Shipment>> buildListOpts, string accessToken = null) => ListShipmentsAsync<Shipment>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TShipment>> ListShipmentsAsync<TShipment>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TShipment>> buildListOpts, string accessToken = null) where TShipment : Shipment => Request("v1", "orders", direction, orderID, "shipments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TShipment>>();
		public Task<Order> SetShippingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null) => SetShippingAddressAsync<Order>(direction, orderID, address, accessToken);
		public Task<TOrder> SetShippingAddressAsync<TOrder>(OrderDirection direction, string orderID, Address address, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TOrder>();
		public Task<Order> PatchShippingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) => PatchShippingAddressAsync<Order>(direction, orderID, partialAddress, accessToken);
		public Task<TOrder> PatchShippingAddressAsync<TOrder>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TOrder>();
		public Task<Order> SetBillingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null) => SetBillingAddressAsync<Order>(direction, orderID, address, accessToken);
		public Task<TOrder> SetBillingAddressAsync<TOrder>(OrderDirection direction, string orderID, Address address, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "billto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TOrder>();
		public Task<Order> PatchBillingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) => PatchBillingAddressAsync<Order>(direction, orderID, partialAddress, accessToken);
		public Task<TOrder> PatchBillingAddressAsync<TOrder>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "billto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TOrder>();
		public Task<Order> PatchFromUserAsync(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null) => PatchFromUserAsync<Order>(direction, orderID, partialUser, accessToken);
		public Task<TOrder> PatchFromUserAsync<TOrder>(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "fromuser").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<TOrder>();
		public Task<ListPage<Promotion>> ListEligiblePromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListEligiblePromotionsAsync<Promotion>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion => Request("v1", "orders", direction, orderID, "eligiblepromotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPromotion>>();
		public Task<ListPage<Promotion>> ListEligiblePromotionsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null) => ListEligiblePromotionsAsync<Promotion>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TPromotion>> ListEligiblePromotionsAsync<TPromotion>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion => Request("v1", "orders", direction, orderID, "eligiblepromotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPromotion>>();
		public Task<OrderPromotion> AddPromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null) => AddPromotionAsync<OrderPromotion>(direction, orderID, promoCode, accessToken);
		public Task<TOrderPromotion> AddPromotionAsync<TOrderPromotion>(OrderDirection direction, string orderID, string promoCode, string accessToken = null) where TOrderPromotion : OrderPromotion => Request("v1", "orders", direction, orderID, "promotions", promoCode).WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrderPromotion>();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListPromotionsAsync<OrderPromotion>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TOrderPromotion : OrderPromotion => Request("v1", "orders", direction, orderID, "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TOrderPromotion>>();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderPromotion>> buildListOpts, string accessToken = null) => ListPromotionsAsync<OrderPromotion>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TOrderPromotion>> ListPromotionsAsync<TOrderPromotion>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TOrderPromotion>> buildListOpts, string accessToken = null) where TOrderPromotion : OrderPromotion => Request("v1", "orders", direction, orderID, "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TOrderPromotion>>();
		public Task<Order> RemovePromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null) => RemovePromotionAsync<Order>(direction, orderID, promoCode, accessToken);
		public Task<TOrder> RemovePromotionAsync<TOrder>(OrderDirection direction, string orderID, string promoCode, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "promotions", promoCode).WithOAuthBearerToken(accessToken).DeleteAsync().ReceiveJson<TOrder>();
		public Task<Order> ApplyPromotionsAsync(OrderDirection direction, string orderID, string accessToken = null) => ApplyPromotionsAsync<Order>(direction, orderID, accessToken);
		public Task<TOrder> ApplyPromotionsAsync<TOrder>(OrderDirection direction, string orderID, string accessToken = null) where TOrder : Order => Request("v1", "orders", direction, orderID, "applypromotions").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<TOrder>();
		public Task ValidateAsync(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID, "validate").WithOAuthBearerToken(accessToken).PostAsync(null);
	}

	public class OrderSyncsResource : OrderCloudResource, IOrderSyncsResource
	{
		internal OrderSyncsResource(OrderCloudClient client) : base(client) { }
		public Task<OrderSyncConfig> GetAsync(string accessToken = null) => Request("v1", "integrations", "OrderSync").WithOAuthBearerToken(accessToken).GetJsonAsync<OrderSyncConfig>();
		public Task DeleteAsync(string accessToken = null) => Request("v1", "integrations", "OrderSync").WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<OrderSyncConfig> SaveAsync(OrderSyncConfig orderSyncConfig, string accessToken = null) => Request("v1", "integrations", "OrderSync").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(orderSyncConfig)).ReceiveJson<OrderSyncConfig>();
		public Task<OrderSyncConfig> PatchAsync(PartialOrderSyncConfig partialOrderSyncConfig, string accessToken = null) => Request("v1", "integrations", "OrderSync").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOrderSyncConfig)).ReceiveJson<OrderSyncConfig>();
	}

	public class PaymentsResource : OrderCloudResource, IPaymentsResource
	{
		internal PaymentsResource(OrderCloudClient client) : base(client) { }
		public Task<Payment> GetAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null) => GetAsync<Payment>(direction, orderID, paymentID, accessToken);
		public Task<TPayment> GetAsync<TPayment>(OrderDirection direction, string orderID, string paymentID, string accessToken = null) where TPayment : Payment => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).GetJsonAsync<TPayment>();
		public Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Payment>(direction, orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPayment>> ListAsync<TPayment>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPayment : Payment => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPayment>>();
		public Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Payment>> buildListOpts, string accessToken = null) => ListAsync<Payment>(direction, orderID, buildListOpts, accessToken);
		public Task<ListPage<TPayment>> ListAsync<TPayment>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<TPayment>> buildListOpts, string accessToken = null) where TPayment : Payment => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPayment>>();
		public Task<Payment> CreateAsync(OrderDirection direction, string orderID, Payment payment, string accessToken = null) => CreateAsync<Payment>(direction, orderID, payment, accessToken);
		public Task<TPayment> CreateAsync<TPayment>(OrderDirection direction, string orderID, Payment payment, string accessToken = null) where TPayment : Payment => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(payment)).ReceiveJson<TPayment>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Payment> PatchAsync(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null) => PatchAsync<Payment>(direction, orderID, paymentID, partialPayment, accessToken);
		public Task<TPayment> PatchAsync<TPayment>(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null) where TPayment : Payment => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPayment)).ReceiveJson<TPayment>();
		public Task<Payment> CreateTransactionAsync(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) => CreateTransactionAsync<Payment>(direction, orderID, paymentID, paymentTransaction, accessToken);
		public Task<TPayment> CreateTransactionAsync<TPayment>(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) where TPayment : Payment => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(paymentTransaction)).ReceiveJson<TPayment>();
		public Task DeleteTransactionAsync(OrderDirection direction, string orderID, string paymentID, string transactionID, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions", transactionID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class PriceSchedulesResource : OrderCloudResource, IPriceSchedulesResource
	{
		internal PriceSchedulesResource(OrderCloudClient client) : base(client) { }
		public Task<PriceSchedule> GetAsync(string priceScheduleID, string accessToken = null) => GetAsync<PriceSchedule>(priceScheduleID, accessToken);
		public Task<TPriceSchedule> GetAsync<TPriceSchedule>(string priceScheduleID, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).GetJsonAsync<TPriceSchedule>();
		public Task<ListPage<PriceSchedule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<PriceSchedule>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPriceSchedule>> ListAsync<TPriceSchedule>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPriceSchedule>>();
		public Task<ListPage<PriceSchedule>> ListAsync(Action<ListOptionsBuilder<PriceSchedule>> buildListOpts, string accessToken = null) => ListAsync<PriceSchedule>(buildListOpts, accessToken);
		public Task<ListPage<TPriceSchedule>> ListAsync<TPriceSchedule>(Action<ListOptionsBuilder<TPriceSchedule>> buildListOpts, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPriceSchedule>>();
		public Task<PriceSchedule> CreateAsync(PriceSchedule priceSchedule, string accessToken = null) => CreateAsync<PriceSchedule>(priceSchedule, accessToken);
		public Task<TPriceSchedule> CreateAsync<TPriceSchedule>(PriceSchedule priceSchedule, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<TPriceSchedule>();
		public Task<PriceSchedule> SaveAsync(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null) => SaveAsync<PriceSchedule>(priceScheduleID, priceSchedule, accessToken);
		public Task<TPriceSchedule> SaveAsync<TPriceSchedule>(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<TPriceSchedule>();
		public Task DeleteAsync(string priceScheduleID, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<PriceSchedule> PatchAsync(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null) => PatchAsync<PriceSchedule>(priceScheduleID, partialPriceSchedule, accessToken);
		public Task<TPriceSchedule> PatchAsync<TPriceSchedule>(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPriceSchedule)).ReceiveJson<TPriceSchedule>();
		public Task<PriceSchedule> SavePriceBreakAsync(string priceScheduleID, PriceBreak priceBreak, string accessToken = null) => SavePriceBreakAsync<PriceSchedule>(priceScheduleID, priceBreak, accessToken);
		public Task<TPriceSchedule> SavePriceBreakAsync<TPriceSchedule>(string priceScheduleID, PriceBreak priceBreak, string accessToken = null) where TPriceSchedule : PriceSchedule => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(priceBreak)).ReceiveJson<TPriceSchedule>();
		public Task DeletePriceBreakAsync(string priceScheduleID, int quantity, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").WithOAuthBearerToken(accessToken).SetQueryParams(new { quantity }).DeleteAsync();
	}

	public class ProductCollectionsResource : OrderCloudResource, IProductCollectionsResource
	{
		internal ProductCollectionsResource(OrderCloudClient client) : base(client) { }
		public Task<ProductCollection> GetAsync(string buyerID, string productCollectionID, string accessToken = null) => GetAsync<ProductCollection>(buyerID, productCollectionID, accessToken);
		public Task<TProductCollection> GetAsync<TProductCollection>(string buyerID, string productCollectionID, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "buyers", buyerID, "productcollections", productCollectionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TProductCollection>();
		public Task<ListPage<ProductCollection>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<ProductCollection>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TProductCollection>> ListAsync<TProductCollection>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "buyers", buyerID, "productcollections").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TProductCollection>>();
		public Task<ListPage<ProductCollection>> ListAsync(string buyerID, Action<ListOptionsBuilder<ProductCollection>> buildListOpts, string accessToken = null) => ListAsync<ProductCollection>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TProductCollection>> ListAsync<TProductCollection>(string buyerID, Action<ListOptionsBuilder<TProductCollection>> buildListOpts, string accessToken = null) where TProductCollection : ProductCollection => Request("v1", "buyers", buyerID, "productcollections").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TProductCollection>>();
		public Task<ListPageWithFacets<Product>> ListEntriesAsync(string buyerID, string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListEntriesAsync<Product>(buyerID, productCollectionID, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPageWithFacets<TProduct>> ListEntriesAsync<TProduct>(string buyerID, string productCollectionID, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProduct : Product => Request("v1", "buyers", buyerID, "productcollections", productCollectionID, "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPageWithFacets<TProduct>>();
		public Task<ListPageWithFacets<Product>> ListEntriesAsync(string buyerID, string productCollectionID, Action<ListOptionsBuilder2<Product>> buildListOpts, string accessToken = null) => ListEntriesAsync<Product>(buyerID, productCollectionID, buildListOpts, accessToken);
		public Task<ListPageWithFacets<TProduct>> ListEntriesAsync<TProduct>(string buyerID, string productCollectionID, Action<ListOptionsBuilder2<TProduct>> buildListOpts, string accessToken = null) where TProduct : Product => Request("v1", "buyers", buyerID, "productcollections", productCollectionID, "products").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPageWithFacets<TProduct>>();
	}

	public class ProductFacetsResource : OrderCloudResource, IProductFacetsResource
	{
		internal ProductFacetsResource(OrderCloudClient client) : base(client) { }
		public Task<ProductFacet> GetAsync(string productFacetID, string accessToken = null) => GetAsync<ProductFacet>(productFacetID, accessToken);
		public Task<TProductFacet> GetAsync<TProductFacet>(string productFacetID, string accessToken = null) where TProductFacet : ProductFacet => Request("v1", "productfacets", productFacetID).WithOAuthBearerToken(accessToken).GetJsonAsync<TProductFacet>();
		public Task<ListPage<ProductFacet>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<ProductFacet>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TProductFacet>> ListAsync<TProductFacet>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductFacet : ProductFacet => Request("v1", "productfacets").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TProductFacet>>();
		public Task<ListPage<ProductFacet>> ListAsync(Action<ListOptionsBuilder<ProductFacet>> buildListOpts, string accessToken = null) => ListAsync<ProductFacet>(buildListOpts, accessToken);
		public Task<ListPage<TProductFacet>> ListAsync<TProductFacet>(Action<ListOptionsBuilder<TProductFacet>> buildListOpts, string accessToken = null) where TProductFacet : ProductFacet => Request("v1", "productfacets").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TProductFacet>>();
		public Task<ProductFacet> CreateAsync(ProductFacet productFacet, string accessToken = null) => CreateAsync<ProductFacet>(productFacet, accessToken);
		public Task<TProductFacet> CreateAsync<TProductFacet>(ProductFacet productFacet, string accessToken = null) where TProductFacet : ProductFacet => Request("v1", "productfacets").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productFacet)).ReceiveJson<TProductFacet>();
		public Task<ProductFacet> SaveAsync(string productFacetID, ProductFacet productFacet, string accessToken = null) => SaveAsync<ProductFacet>(productFacetID, productFacet, accessToken);
		public Task<TProductFacet> SaveAsync<TProductFacet>(string productFacetID, ProductFacet productFacet, string accessToken = null) where TProductFacet : ProductFacet => Request("v1", "productfacets", productFacetID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(productFacet)).ReceiveJson<TProductFacet>();
		public Task DeleteAsync(string productFacetID, string accessToken = null) => Request("v1", "productfacets", productFacetID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ProductFacet> PatchAsync(string productFacetID, PartialProductFacet partialProductFacet, string accessToken = null) => PatchAsync<ProductFacet>(productFacetID, partialProductFacet, accessToken);
		public Task<TProductFacet> PatchAsync<TProductFacet>(string productFacetID, PartialProductFacet partialProductFacet, string accessToken = null) where TProductFacet : ProductFacet => Request("v1", "productfacets", productFacetID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProductFacet)).ReceiveJson<TProductFacet>();
	}

	public class ProductsResource : OrderCloudResource, IProductsResource
	{
		internal ProductsResource(OrderCloudClient client) : base(client) { }
		public Task<Product> GetAsync(string productID, string accessToken = null) => GetAsync<Product>(productID, accessToken);
		public Task<TProduct> GetAsync<TProduct>(string productID, string accessToken = null) where TProduct : Product => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).GetJsonAsync<TProduct>();
		public Task<ListPageWithFacets<Product>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Product>(catalogID, categoryID, supplierID, search, searchOn, searchType, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPageWithFacets<TProduct>> ListAsync<TProduct>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, SearchType searchType = SearchType.AnyTerm, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProduct : Product => Request("v1", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID, search, searchOn, searchType, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPageWithFacets<TProduct>>();
		public Task<ListPageWithFacets<Product>> ListAsync(Action<ListOptionsBuilder2<Product>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) => ListAsync<Product>(buildListOpts, catalogID, categoryID, supplierID, accessToken);
		public Task<ListPageWithFacets<TProduct>> ListAsync<TProduct>(Action<ListOptionsBuilder2<TProduct>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) where TProduct : Product => Request("v1", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID }).SetListOptions(buildListOpts).GetJsonAsync<ListPageWithFacets<TProduct>>();
		public Task<Product> CreateAsync(Product product, string accessToken = null) => CreateAsync<Product>(product, accessToken);
		public Task<TProduct> CreateAsync<TProduct>(Product product, string accessToken = null) where TProduct : Product => Request("v1", "products").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(product)).ReceiveJson<TProduct>();
		public Task<Product> SaveAsync(string productID, Product product, string accessToken = null) => SaveAsync<Product>(productID, product, accessToken);
		public Task<TProduct> SaveAsync<TProduct>(string productID, Product product, string accessToken = null) where TProduct : Product => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(product)).ReceiveJson<TProduct>();
		public Task DeleteAsync(string productID, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Product> PatchAsync(string productID, PartialProduct partialProduct, string accessToken = null) => PatchAsync<Product>(productID, partialProduct, accessToken);
		public Task<TProduct> PatchAsync<TProduct>(string productID, PartialProduct partialProduct, string accessToken = null) where TProduct : Product => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProduct)).ReceiveJson<TProduct>();
		public Task<Product> GenerateVariantsAsync(string productID, bool overwriteExisting = false, string accessToken = null) => GenerateVariantsAsync<Product>(productID, overwriteExisting, accessToken);
		public Task<TProduct> GenerateVariantsAsync<TProduct>(string productID, bool overwriteExisting = false, string accessToken = null) where TProduct : Product => Request("v1", "products", productID, "variants", "generate").WithOAuthBearerToken(accessToken).SetQueryParams(new { overwriteExisting }).PostAsync(null).ReceiveJson<TProduct>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListVariantsAsync<Variant>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TVariant : Variant => Request("v1", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TVariant>>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, Action<ListOptionsBuilder<Variant>> buildListOpts, string accessToken = null) => ListVariantsAsync<Variant>(productID, buildListOpts, accessToken);
		public Task<ListPage<TVariant>> ListVariantsAsync<TVariant>(string productID, Action<ListOptionsBuilder<TVariant>> buildListOpts, string accessToken = null) where TVariant : Variant => Request("v1", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TVariant>>();
		public Task<Variant> SaveVariantAsync(string productID, string variantID, Variant variant, string accessToken = null) => SaveVariantAsync<Variant>(productID, variantID, variant, accessToken);
		public Task<TVariant> SaveVariantAsync<TVariant>(string productID, string variantID, Variant variant, string accessToken = null) where TVariant : Variant => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(variant)).ReceiveJson<TVariant>();
		public Task<Variant> PatchVariantAsync(string productID, string variantID, PartialVariant partialVariant, string accessToken = null) => PatchVariantAsync<Variant>(productID, variantID, partialVariant, accessToken);
		public Task<TVariant> PatchVariantAsync<TVariant>(string productID, string variantID, PartialVariant partialVariant, string accessToken = null) where TVariant : Variant => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialVariant)).ReceiveJson<TVariant>();
		public Task<Variant> GetVariantAsync(string productID, string variantID, string accessToken = null) => GetVariantAsync<Variant>(productID, variantID, accessToken);
		public Task<TVariant> GetVariantAsync<TVariant>(string productID, string variantID, string accessToken = null) where TVariant : Variant => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).GetJsonAsync<TVariant>();
		public Task<ListPage<Spec>> ListSpecsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListSpecsAsync<Spec>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpec : Spec => Request("v1", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSpec>>();
		public Task<ListPage<Spec>> ListSpecsAsync(string productID, Action<ListOptionsBuilder<Spec>> buildListOpts, string accessToken = null) => ListSpecsAsync<Spec>(productID, buildListOpts, accessToken);
		public Task<ListPage<TSpec>> ListSpecsAsync<TSpec>(string productID, Action<ListOptionsBuilder<TSpec>> buildListOpts, string accessToken = null) where TSpec : Spec => Request("v1", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSpec>>();
		public Task<ListPage<ProductSupplier>> ListSuppliersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListSuppliersAsync<ProductSupplier>(productID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TProductSupplier>> ListSuppliersAsync<TProductSupplier>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TProductSupplier : ProductSupplier => Request("v1", "products", productID, "suppliers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TProductSupplier>>();
		public Task<ListPage<ProductSupplier>> ListSuppliersAsync(string productID, Action<ListOptionsBuilder<ProductSupplier>> buildListOpts, string accessToken = null) => ListSuppliersAsync<ProductSupplier>(productID, buildListOpts, accessToken);
		public Task<ListPage<TProductSupplier>> ListSuppliersAsync<TProductSupplier>(string productID, Action<ListOptionsBuilder<TProductSupplier>> buildListOpts, string accessToken = null) where TProductSupplier : ProductSupplier => Request("v1", "products", productID, "suppliers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TProductSupplier>>();
		public Task SaveSupplierAsync(string productID, string supplierID, string defaultPriceScheduleID = null, string accessToken = null) => Request("v1", "products", productID, "suppliers", supplierID).WithOAuthBearerToken(accessToken).SetQueryParams(new { defaultPriceScheduleID }).PutAsync(null);
		public Task RemoveSupplierAsync(string productID, string supplierID, string accessToken = null) => Request("v1", "products", productID, "suppliers", supplierID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveAssignmentAsync(ProductAssignment productAssignment, string accessToken = null) => Request("v1", "products", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productAssignment));
		public Task<ListPage<ProductAssignment>> ListAssignmentsAsync(string productID = null, string priceScheduleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "products", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { productID, priceScheduleID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<ProductAssignment>>();
		public Task DeleteAssignmentAsync(string productID, string buyerID, string userID = null, string userGroupID = null, string sellerID = null, string accessToken = null) => Request("v1", "products", productID, "assignments", buyerID).WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID, sellerID }).DeleteAsync();
	}

	public class ProductSyncsResource : OrderCloudResource, IProductSyncsResource
	{
		internal ProductSyncsResource(OrderCloudClient client) : base(client) { }
		public Task<ProductSyncConfig> GetAsync(string accessToken = null) => Request("v1", "integrations", "productsync").WithOAuthBearerToken(accessToken).GetJsonAsync<ProductSyncConfig>();
		public Task DeleteAsync(string accessToken = null) => Request("v1", "integrations", "productsync").WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ProductSyncConfig> SaveAsync(ProductSyncConfig productSyncConfig, string accessToken = null) => Request("v1", "integrations", "productsync").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(productSyncConfig)).ReceiveJson<ProductSyncConfig>();
		public Task<ProductSyncConfig> PatchAsync(PartialProductSyncConfig partialProductSyncConfig, string accessToken = null) => Request("v1", "integrations", "productsync").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProductSyncConfig)).ReceiveJson<ProductSyncConfig>();
	}

	public class PromotionsResource : OrderCloudResource, IPromotionsResource
	{
		internal PromotionsResource(OrderCloudClient client) : base(client) { }
		public Task<Promotion> GetAsync(string promotionID, string accessToken = null) => GetAsync<Promotion>(promotionID, accessToken);
		public Task<TPromotion> GetAsync<TPromotion>(string promotionID, string accessToken = null) where TPromotion : Promotion => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TPromotion>();
		public Task<ListPage<Promotion>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Promotion>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TPromotion>> ListAsync<TPromotion>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TPromotion : Promotion => Request("v1", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TPromotion>>();
		public Task<ListPage<Promotion>> ListAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null) => ListAsync<Promotion>(buildListOpts, accessToken);
		public Task<ListPage<TPromotion>> ListAsync<TPromotion>(Action<ListOptionsBuilder<TPromotion>> buildListOpts, string accessToken = null) where TPromotion : Promotion => Request("v1", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TPromotion>>();
		public Task<Promotion> CreateAsync(Promotion promotion, string accessToken = null) => CreateAsync<Promotion>(promotion, accessToken);
		public Task<TPromotion> CreateAsync<TPromotion>(Promotion promotion, string accessToken = null) where TPromotion : Promotion => Request("v1", "promotions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(promotion)).ReceiveJson<TPromotion>();
		public Task<Promotion> SaveAsync(string promotionID, Promotion promotion, string accessToken = null) => SaveAsync<Promotion>(promotionID, promotion, accessToken);
		public Task<TPromotion> SaveAsync<TPromotion>(string promotionID, Promotion promotion, string accessToken = null) where TPromotion : Promotion => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(promotion)).ReceiveJson<TPromotion>();
		public Task DeleteAsync(string promotionID, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Promotion> PatchAsync(string promotionID, PartialPromotion partialPromotion, string accessToken = null) => PatchAsync<Promotion>(promotionID, partialPromotion, accessToken);
		public Task<TPromotion> PatchAsync<TPromotion>(string promotionID, PartialPromotion partialPromotion, string accessToken = null) where TPromotion : Promotion => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPromotion)).ReceiveJson<TPromotion>();
		public Task<ListPage<PromotionAssignment>> ListAssignmentsAsync(string buyerID = null, string promotionID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "promotions", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, promotionID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<PromotionAssignment>>();
		public Task SaveAssignmentAsync(PromotionAssignment promotionAssignment, string accessToken = null) => Request("v1", "promotions", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(promotionAssignment));
		public Task DeleteAssignmentAsync(string promotionID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "promotions", promotionID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
	}

	public class SecurityProfilesResource : OrderCloudResource, ISecurityProfilesResource
	{
		internal SecurityProfilesResource(OrderCloudClient client) : base(client) { }
		public Task<SecurityProfile> GetAsync(string securityProfileID, string accessToken = null) => Request("v1", "securityprofiles", securityProfileID).WithOAuthBearerToken(accessToken).GetJsonAsync<SecurityProfile>();
		public Task<ListPage<SecurityProfile>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "securityprofiles").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SecurityProfile>>();
		public Task<ListPage<SecurityProfile>> ListAsync(Action<ListOptionsBuilder<SecurityProfile>> buildListOpts, string accessToken = null) => Request("v1", "securityprofiles").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SecurityProfile>>();
		public Task<SecurityProfile> CreateAsync(SecurityProfile securityProfile, string accessToken = null) => Request("v1", "securityprofiles").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(securityProfile)).ReceiveJson<SecurityProfile>();
		public Task<SecurityProfile> SaveAsync(string securityProfileID, SecurityProfile securityProfile, string accessToken = null) => Request("v1", "securityprofiles", securityProfileID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(securityProfile)).ReceiveJson<SecurityProfile>();
		public Task DeleteAsync(string securityProfileID, string accessToken = null) => Request("v1", "securityprofiles", securityProfileID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<SecurityProfile> PatchAsync(string securityProfileID, PartialSecurityProfile partialSecurityProfile, string accessToken = null) => Request("v1", "securityprofiles", securityProfileID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSecurityProfile)).ReceiveJson<SecurityProfile>();
		public Task<ListPage<SecurityProfileAssignment>> ListAssignmentsAsync(string buyerID = null, string supplierID = null, string securityProfileID = null, string userID = null, string userGroupID = null, CommerceRole? commerceRole = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "securityprofiles", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, securityProfileID, userID, userGroupID, commerceRole, level, page, pageSize }).GetJsonAsync<ListPage<SecurityProfileAssignment>>();
		public Task DeleteAssignmentAsync(string securityProfileID, string buyerID = null, string userID = null, string userGroupID = null, string supplierID = null, string accessToken = null) => Request("v1", "securityprofiles", securityProfileID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID, supplierID }).DeleteAsync();
		public Task SaveAssignmentAsync(SecurityProfileAssignment securityProfileAssignment, string accessToken = null) => Request("v1", "securityprofiles", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(securityProfileAssignment));
	}

	public class SellerApprovalRulesResource : OrderCloudResource, ISellerApprovalRulesResource
	{
		internal SellerApprovalRulesResource(OrderCloudClient client) : base(client) { }
		public Task<SellerApprovalRule> GetAsync(string approvalRuleID, string accessToken = null) => GetAsync<SellerApprovalRule>(approvalRuleID, accessToken);
		public Task<TSellerApprovalRule> GetAsync<TSellerApprovalRule>(string approvalRuleID, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule => Request("v1", "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSellerApprovalRule>();
		public Task<ListPage<SellerApprovalRule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<SellerApprovalRule>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSellerApprovalRule>> ListAsync<TSellerApprovalRule>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule => Request("v1", "approvalrules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSellerApprovalRule>>();
		public Task<ListPage<SellerApprovalRule>> ListAsync(Action<ListOptionsBuilder<SellerApprovalRule>> buildListOpts, string accessToken = null) => ListAsync<SellerApprovalRule>(buildListOpts, accessToken);
		public Task<ListPage<TSellerApprovalRule>> ListAsync<TSellerApprovalRule>(Action<ListOptionsBuilder<TSellerApprovalRule>> buildListOpts, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule => Request("v1", "approvalrules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSellerApprovalRule>>();
		public Task<SellerApprovalRule> CreateAsync(SellerApprovalRule sellerApprovalRule, string accessToken = null) => CreateAsync<SellerApprovalRule>(sellerApprovalRule, accessToken);
		public Task<TSellerApprovalRule> CreateAsync<TSellerApprovalRule>(SellerApprovalRule sellerApprovalRule, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule => Request("v1", "approvalrules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(sellerApprovalRule)).ReceiveJson<TSellerApprovalRule>();
		public Task<SellerApprovalRule> SaveAsync(string approvalRuleID, SellerApprovalRule sellerApprovalRule, string accessToken = null) => SaveAsync<SellerApprovalRule>(approvalRuleID, sellerApprovalRule, accessToken);
		public Task<TSellerApprovalRule> SaveAsync<TSellerApprovalRule>(string approvalRuleID, SellerApprovalRule sellerApprovalRule, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule => Request("v1", "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(sellerApprovalRule)).ReceiveJson<TSellerApprovalRule>();
		public Task DeleteAsync(string approvalRuleID, string accessToken = null) => Request("v1", "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<SellerApprovalRule> PatchAsync(string approvalRuleID, PartialSellerApprovalRule partialSellerApprovalRule, string accessToken = null) => PatchAsync<SellerApprovalRule>(approvalRuleID, partialSellerApprovalRule, accessToken);
		public Task<TSellerApprovalRule> PatchAsync<TSellerApprovalRule>(string approvalRuleID, PartialSellerApprovalRule partialSellerApprovalRule, string accessToken = null) where TSellerApprovalRule : SellerApprovalRule => Request("v1", "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSellerApprovalRule)).ReceiveJson<TSellerApprovalRule>();
	}

	public class ShipmentsResource : OrderCloudResource, IShipmentsResource
	{
		internal ShipmentsResource(OrderCloudClient client) : base(client) { }
		public Task<Shipment> GetAsync(string shipmentID, string accessToken = null) => GetAsync<Shipment>(shipmentID, accessToken);
		public Task<TShipment> GetAsync<TShipment>(string shipmentID, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).GetJsonAsync<TShipment>();
		public Task<ListPage<Shipment>> ListAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Shipment>(orderID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TShipment>> ListAsync<TShipment>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TShipment>>();
		public Task<ListPage<Shipment>> ListAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null) => ListAsync<Shipment>(buildListOpts, orderID, accessToken);
		public Task<ListPage<TShipment>> ListAsync<TShipment>(Action<ListOptionsBuilder<TShipment>> buildListOpts, string orderID = null, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TShipment>>();
		public Task<Shipment> CreateAsync(Shipment shipment, string accessToken = null) => CreateAsync<Shipment>(shipment, accessToken);
		public Task<TShipment> CreateAsync<TShipment>(Shipment shipment, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipment)).ReceiveJson<TShipment>();
		public Task<Shipment> SaveAsync(string shipmentID, Shipment shipment, string accessToken = null) => SaveAsync<Shipment>(shipmentID, shipment, accessToken);
		public Task<TShipment> SaveAsync<TShipment>(string shipmentID, Shipment shipment, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(shipment)).ReceiveJson<TShipment>();
		public Task DeleteAsync(string shipmentID, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Shipment> PatchAsync(string shipmentID, PartialShipment partialShipment, string accessToken = null) => PatchAsync<Shipment>(shipmentID, partialShipment, accessToken);
		public Task<TShipment> PatchAsync<TShipment>(string shipmentID, PartialShipment partialShipment, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialShipment)).ReceiveJson<TShipment>();
		public Task<Shipment> SetShipToAddressAsync(string shipmentID, Address address, string accessToken = null) => SetShipToAddressAsync<Shipment>(shipmentID, address, accessToken);
		public Task<TShipment> SetShipToAddressAsync<TShipment>(string shipmentID, Address address, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments", shipmentID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TShipment>();
		public Task<Shipment> SetShipFromAddressAsync(string shipmentID, Address address, string accessToken = null) => SetShipFromAddressAsync<Shipment>(shipmentID, address, accessToken);
		public Task<TShipment> SetShipFromAddressAsync<TShipment>(string shipmentID, Address address, string accessToken = null) where TShipment : Shipment => Request("v1", "shipments", shipmentID, "shipfrom").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TShipment>();
		public Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListItemsAsync<ShipmentItem>(shipmentID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TShipmentItem>> ListItemsAsync<TShipmentItem>(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TShipmentItem : ShipmentItem => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TShipmentItem>>();
		public Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string accessToken = null) => ListItemsAsync<ShipmentItem>(shipmentID, buildListOpts, accessToken);
		public Task<ListPage<TShipmentItem>> ListItemsAsync<TShipmentItem>(string shipmentID, Action<ListOptionsBuilder<TShipmentItem>> buildListOpts, string accessToken = null) where TShipmentItem : ShipmentItem => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TShipmentItem>>();
		public Task<ShipmentItem> GetItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null) => GetItemAsync<ShipmentItem>(shipmentID, orderID, lineItemID, accessToken);
		public Task<TShipmentItem> GetItemAsync<TShipmentItem>(string shipmentID, string orderID, string lineItemID, string accessToken = null) where TShipmentItem : ShipmentItem => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<TShipmentItem>();
		public Task<ShipmentItem> SaveItemAsync(string shipmentID, ShipmentItem shipmentItem, string accessToken = null) => SaveItemAsync<ShipmentItem>(shipmentID, shipmentItem, accessToken);
		public Task<TShipmentItem> SaveItemAsync<TShipmentItem>(string shipmentID, ShipmentItem shipmentItem, string accessToken = null) where TShipmentItem : ShipmentItem => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipmentItem)).ReceiveJson<TShipmentItem>();
		public Task DeleteItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class SpecsResource : OrderCloudResource, ISpecsResource
	{
		internal SpecsResource(OrderCloudClient client) : base(client) { }
		public Task<Spec> GetAsync(string specID, string accessToken = null) => GetAsync<Spec>(specID, accessToken);
		public Task<TSpec> GetAsync<TSpec>(string specID, string accessToken = null) where TSpec : Spec => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSpec>();
		public Task<ListPage<Spec>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Spec>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSpec>> ListAsync<TSpec>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpec : Spec => Request("v1", "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSpec>>();
		public Task<ListPage<Spec>> ListAsync(Action<ListOptionsBuilder<Spec>> buildListOpts, string accessToken = null) => ListAsync<Spec>(buildListOpts, accessToken);
		public Task<ListPage<TSpec>> ListAsync<TSpec>(Action<ListOptionsBuilder<TSpec>> buildListOpts, string accessToken = null) where TSpec : Spec => Request("v1", "specs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSpec>>();
		public Task<Spec> CreateAsync(Spec spec, string accessToken = null) => CreateAsync<Spec>(spec, accessToken);
		public Task<TSpec> CreateAsync<TSpec>(Spec spec, string accessToken = null) where TSpec : Spec => Request("v1", "specs").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spec)).ReceiveJson<TSpec>();
		public Task<Spec> SaveAsync(string specID, Spec spec, string accessToken = null) => SaveAsync<Spec>(specID, spec, accessToken);
		public Task<TSpec> SaveAsync<TSpec>(string specID, Spec spec, string accessToken = null) where TSpec : Spec => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(spec)).ReceiveJson<TSpec>();
		public Task DeleteAsync(string specID, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Spec> PatchAsync(string specID, PartialSpec partialSpec, string accessToken = null) => PatchAsync<Spec>(specID, partialSpec, accessToken);
		public Task<TSpec> PatchAsync<TSpec>(string specID, PartialSpec partialSpec, string accessToken = null) where TSpec : Spec => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpec)).ReceiveJson<TSpec>();
		public Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "specs", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecProductAssignment>>();
		public Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(Action<ListOptionsBuilder<SpecProductAssignment>> buildListOpts, string accessToken = null) => Request("v1", "specs", "productassignments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpecProductAssignment>>();
		public Task DeleteProductAssignmentAsync(string specID, string productID, string accessToken = null) => Request("v1", "specs", specID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveProductAssignmentAsync(SpecProductAssignment specProductAssignment, string accessToken = null) => Request("v1", "specs", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(specProductAssignment));
		public Task<SpecOption> CreateOptionAsync(string specID, SpecOption specOption, string accessToken = null) => CreateOptionAsync<SpecOption>(specID, specOption, accessToken);
		public Task<TSpecOption> CreateOptionAsync<TSpecOption>(string specID, SpecOption specOption, string accessToken = null) where TSpecOption : SpecOption => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(specOption)).ReceiveJson<TSpecOption>();
		public Task<ListPage<SpecOption>> ListOptionsAsync(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListOptionsAsync<SpecOption>(specID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSpecOption>> ListOptionsAsync<TSpecOption>(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpecOption : SpecOption => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSpecOption>>();
		public Task<ListPage<SpecOption>> ListOptionsAsync(string specID, Action<ListOptionsBuilder<SpecOption>> buildListOpts, string accessToken = null) => ListOptionsAsync<SpecOption>(specID, buildListOpts, accessToken);
		public Task<ListPage<TSpecOption>> ListOptionsAsync<TSpecOption>(string specID, Action<ListOptionsBuilder<TSpecOption>> buildListOpts, string accessToken = null) where TSpecOption : SpecOption => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSpecOption>>();
		public Task<SpecOption> SaveOptionAsync(string specID, string optionID, SpecOption specOption, string accessToken = null) => SaveOptionAsync<SpecOption>(specID, optionID, specOption, accessToken);
		public Task<TSpecOption> SaveOptionAsync<TSpecOption>(string specID, string optionID, SpecOption specOption, string accessToken = null) where TSpecOption : SpecOption => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(specOption)).ReceiveJson<TSpecOption>();
		public Task<SpecOption> PatchOptionAsync(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null) => PatchOptionAsync<SpecOption>(specID, optionID, partialSpecOption, accessToken);
		public Task<TSpecOption> PatchOptionAsync<TSpecOption>(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null) where TSpecOption : SpecOption => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpecOption)).ReceiveJson<TSpecOption>();
		public Task<SpecOption> GetOptionAsync(string specID, string optionID, string accessToken = null) => GetOptionAsync<SpecOption>(specID, optionID, accessToken);
		public Task<TSpecOption> GetOptionAsync<TSpecOption>(string specID, string optionID, string accessToken = null) where TSpecOption : SpecOption => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSpecOption>();
		public Task DeleteOptionAsync(string specID, string optionID, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class SpendingAccountsResource : OrderCloudResource, ISpendingAccountsResource
	{
		internal SpendingAccountsResource(OrderCloudClient client) : base(client) { }
		public Task<SpendingAccount> GetAsync(string buyerID, string spendingAccountID, string accessToken = null) => GetAsync<SpendingAccount>(buyerID, spendingAccountID, accessToken);
		public Task<TSpendingAccount> GetAsync<TSpendingAccount>(string buyerID, string spendingAccountID, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSpendingAccount>();
		public Task<ListPage<SpendingAccount>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<SpendingAccount>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSpendingAccount>> ListAsync<TSpendingAccount>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSpendingAccount>>();
		public Task<ListPage<SpendingAccount>> ListAsync(string buyerID, Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null) => ListAsync<SpendingAccount>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TSpendingAccount>> ListAsync<TSpendingAccount>(string buyerID, Action<ListOptionsBuilder<TSpendingAccount>> buildListOpts, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSpendingAccount>>();
		public Task<SpendingAccount> CreateAsync(string buyerID, SpendingAccount spendingAccount, string accessToken = null) => CreateAsync<SpendingAccount>(buyerID, spendingAccount, accessToken);
		public Task<TSpendingAccount> CreateAsync<TSpendingAccount>(string buyerID, SpendingAccount spendingAccount, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<TSpendingAccount>();
		public Task<SpendingAccount> SaveAsync(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null) => SaveAsync<SpendingAccount>(buyerID, spendingAccountID, spendingAccount, accessToken);
		public Task<TSpendingAccount> SaveAsync<TSpendingAccount>(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<TSpendingAccount>();
		public Task DeleteAsync(string buyerID, string spendingAccountID, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<SpendingAccount> PatchAsync(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null) => PatchAsync<SpendingAccount>(buyerID, spendingAccountID, partialSpendingAccount, accessToken);
		public Task<TSpendingAccount> PatchAsync<TSpendingAccount>(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null) where TSpendingAccount : SpendingAccount => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpendingAccount)).ReceiveJson<TSpendingAccount>();
		public Task<ListPage<SpendingAccountAssignment>> ListAssignmentsAsync(string buyerID, string spendingAccountID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { spendingAccountID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<SpendingAccountAssignment>>();
		public Task SaveAssignmentAsync(string buyerID, SpendingAccountAssignment spendingAccountAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spendingAccountAssignment));
		public Task DeleteAssignmentAsync(string buyerID, string spendingAccountID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class SubscriptionIntegrationsResource : OrderCloudResource, ISubscriptionIntegrationsResource
	{
		internal SubscriptionIntegrationsResource(OrderCloudClient client) : base(client) { }
		public Task<SubscriptionIntegration> GetAsync(string accessToken = null) => GetAsync<SubscriptionIntegration>(accessToken);
		public Task<TSubscriptionIntegration> GetAsync<TSubscriptionIntegration>(string accessToken = null) where TSubscriptionIntegration : SubscriptionIntegration => Request("v1", "integrations", "subscription").WithOAuthBearerToken(accessToken).GetJsonAsync<TSubscriptionIntegration>();
		public Task DeleteAsync(string accessToken = null) => Request("v1", "integrations", "subscription").WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<SubscriptionIntegration> SaveAsync(SubscriptionIntegration subscriptionIntegration, string accessToken = null) => SaveAsync<SubscriptionIntegration>(subscriptionIntegration, accessToken);
		public Task<TSubscriptionIntegration> SaveAsync<TSubscriptionIntegration>(SubscriptionIntegration subscriptionIntegration, string accessToken = null) where TSubscriptionIntegration : SubscriptionIntegration => Request("v1", "integrations", "subscription").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(subscriptionIntegration)).ReceiveJson<TSubscriptionIntegration>();
		public Task<SubscriptionIntegration> PatchAsync(PartialSubscriptionIntegration partialSubscriptionIntegration, string accessToken = null) => PatchAsync<SubscriptionIntegration>(partialSubscriptionIntegration, accessToken);
		public Task<TSubscriptionIntegration> PatchAsync<TSubscriptionIntegration>(PartialSubscriptionIntegration partialSubscriptionIntegration, string accessToken = null) where TSubscriptionIntegration : SubscriptionIntegration => Request("v1", "integrations", "subscription").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSubscriptionIntegration)).ReceiveJson<TSubscriptionIntegration>();
	}

	public class SubscriptionItemsResource : OrderCloudResource, ISubscriptionItemsResource
	{
		internal SubscriptionItemsResource(OrderCloudClient client) : base(client) { }
		public Task<LineItem> GetAsync(string subscriptionID, string subscriptionItemID, string accessToken = null) => GetAsync<LineItem>(subscriptionID, subscriptionItemID, accessToken);
		public Task<TLineItem> GetAsync<TLineItem>(string subscriptionID, string subscriptionItemID, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<TLineItem>();
		public Task<ListPage<LineItem>> ListAsync(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<LineItem>(subscriptionID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TLineItem>> ListAsync<TLineItem>(string subscriptionID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TLineItem>>();
		public Task<ListPage<LineItem>> ListAsync(string subscriptionID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null) => ListAsync<LineItem>(subscriptionID, buildListOpts, accessToken);
		public Task<ListPage<TLineItem>> ListAsync<TLineItem>(string subscriptionID, Action<ListOptionsBuilder<TLineItem>> buildListOpts, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "items").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TLineItem>>();
		public Task<LineItem> CreateAsync(string subscriptionID, LineItem lineItem, string accessToken = null) => CreateAsync<LineItem>(subscriptionID, lineItem, accessToken);
		public Task<TLineItem> CreateAsync<TLineItem>(string subscriptionID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "items").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task<LineItem> SaveAsync(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null) => SaveAsync<LineItem>(subscriptionID, subscriptionItemID, lineItem, accessToken);
		public Task<TLineItem> SaveAsync<TLineItem>(string subscriptionID, string subscriptionItemID, LineItem lineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<TLineItem>();
		public Task DeleteAsync(string subscriptionID, string subscriptionItemID, string accessToken = null) => Request("v1", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<LineItem> PatchAsync(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null) => PatchAsync<LineItem>(subscriptionID, subscriptionItemID, partialLineItem, accessToken);
		public Task<TLineItem> PatchAsync<TLineItem>(string subscriptionID, string subscriptionItemID, PartialLineItem partialLineItem, string accessToken = null) where TLineItem : LineItem => Request("v1", "subscriptions", subscriptionID, "items", subscriptionItemID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<TLineItem>();
	}

	public class SubscriptionsResource : OrderCloudResource, ISubscriptionsResource
	{
		internal SubscriptionsResource(OrderCloudClient client) : base(client) { }
		public Task<Subscription> GetAsync(string subscriptionID, string accessToken = null) => GetAsync<Subscription>(subscriptionID, accessToken);
		public Task<TSubscription> GetAsync<TSubscription>(string subscriptionID, string accessToken = null) where TSubscription : Subscription => Request("v1", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSubscription>();
		public Task<ListPage<Subscription>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Subscription>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSubscription>> ListAsync<TSubscription>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSubscription : Subscription => Request("v1", "subscriptions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSubscription>>();
		public Task<ListPage<Subscription>> ListAsync(Action<ListOptionsBuilder<Subscription>> buildListOpts, string accessToken = null) => ListAsync<Subscription>(buildListOpts, accessToken);
		public Task<ListPage<TSubscription>> ListAsync<TSubscription>(Action<ListOptionsBuilder<TSubscription>> buildListOpts, string accessToken = null) where TSubscription : Subscription => Request("v1", "subscriptions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSubscription>>();
		public Task<Subscription> CreateAsync(Subscription subscription, string accessToken = null) => CreateAsync<Subscription>(subscription, accessToken);
		public Task<TSubscription> CreateAsync<TSubscription>(Subscription subscription, string accessToken = null) where TSubscription : Subscription => Request("v1", "subscriptions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(subscription)).ReceiveJson<TSubscription>();
		public Task<Subscription> SaveAsync(string subscriptionID, Subscription subscription, string accessToken = null) => SaveAsync<Subscription>(subscriptionID, subscription, accessToken);
		public Task<TSubscription> SaveAsync<TSubscription>(string subscriptionID, Subscription subscription, string accessToken = null) where TSubscription : Subscription => Request("v1", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(subscription)).ReceiveJson<TSubscription>();
		public Task DeleteAsync(string subscriptionID, string accessToken = null) => Request("v1", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Subscription> PatchAsync(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null) => PatchAsync<Subscription>(subscriptionID, partialSubscription, accessToken);
		public Task<TSubscription> PatchAsync<TSubscription>(string subscriptionID, PartialSubscription partialSubscription, string accessToken = null) where TSubscription : Subscription => Request("v1", "subscriptions", subscriptionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSubscription)).ReceiveJson<TSubscription>();
	}

	public class SupplierAddressesResource : OrderCloudResource, ISupplierAddressesResource
	{
		internal SupplierAddressesResource(OrderCloudClient client) : base(client) { }
		public Task<Address> GetAsync(string supplierID, string addressID, string accessToken = null) => GetAsync<Address>(supplierID, addressID, accessToken);
		public Task<TAddress> GetAsync<TAddress>(string supplierID, string addressID, string accessToken = null) where TAddress : Address => Request("v1", "suppliers", supplierID, "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<TAddress>();
		public Task<ListPage<Address>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Address>(supplierID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TAddress>> ListAsync<TAddress>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TAddress : Address => Request("v1", "suppliers", supplierID, "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TAddress>>();
		public Task<ListPage<Address>> ListAsync(string supplierID, Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null) => ListAsync<Address>(supplierID, buildListOpts, accessToken);
		public Task<ListPage<TAddress>> ListAsync<TAddress>(string supplierID, Action<ListOptionsBuilder<TAddress>> buildListOpts, string accessToken = null) where TAddress : Address => Request("v1", "suppliers", supplierID, "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TAddress>>();
		public Task<Address> CreateAsync(string supplierID, Address address, string accessToken = null) => CreateAsync<Address>(supplierID, address, accessToken);
		public Task<TAddress> CreateAsync<TAddress>(string supplierID, Address address, string accessToken = null) where TAddress : Address => Request("v1", "suppliers", supplierID, "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<TAddress>();
		public Task<Address> SaveAsync(string supplierID, string addressID, Address address, string accessToken = null) => SaveAsync<Address>(supplierID, addressID, address, accessToken);
		public Task<TAddress> SaveAsync<TAddress>(string supplierID, string addressID, Address address, string accessToken = null) where TAddress : Address => Request("v1", "suppliers", supplierID, "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<TAddress>();
		public Task DeleteAsync(string supplierID, string addressID, string accessToken = null) => Request("v1", "suppliers", supplierID, "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Address> PatchAsync(string supplierID, string addressID, PartialAddress partialAddress, string accessToken = null) => PatchAsync<Address>(supplierID, addressID, partialAddress, accessToken);
		public Task<TAddress> PatchAsync<TAddress>(string supplierID, string addressID, PartialAddress partialAddress, string accessToken = null) where TAddress : Address => Request("v1", "suppliers", supplierID, "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<TAddress>();
	}

	public class SuppliersResource : OrderCloudResource, ISuppliersResource
	{
		internal SuppliersResource(OrderCloudClient client) : base(client) { }
		public Task<Supplier> GetAsync(string supplierID, string accessToken = null) => GetAsync<Supplier>(supplierID, accessToken);
		public Task<TSupplier> GetAsync<TSupplier>(string supplierID, string accessToken = null) where TSupplier : Supplier => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).GetJsonAsync<TSupplier>();
		public Task<ListPage<Supplier>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<Supplier>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TSupplier>> ListAsync<TSupplier>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TSupplier : Supplier => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TSupplier>>();
		public Task<ListPage<Supplier>> ListAsync(Action<ListOptionsBuilder<Supplier>> buildListOpts, string accessToken = null) => ListAsync<Supplier>(buildListOpts, accessToken);
		public Task<ListPage<TSupplier>> ListAsync<TSupplier>(Action<ListOptionsBuilder<TSupplier>> buildListOpts, string accessToken = null) where TSupplier : Supplier => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TSupplier>>();
		public Task<Supplier> CreateAsync(Supplier supplier, string accessToken = null) => CreateAsync<Supplier>(supplier, accessToken);
		public Task<TSupplier> CreateAsync<TSupplier>(Supplier supplier, string accessToken = null) where TSupplier : Supplier => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(supplier)).ReceiveJson<TSupplier>();
		public Task DeleteAsync(string supplierID, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Supplier> SaveAsync(string supplierID, Supplier supplier, string accessToken = null) => SaveAsync<Supplier>(supplierID, supplier, accessToken);
		public Task<TSupplier> SaveAsync<TSupplier>(string supplierID, Supplier supplier, string accessToken = null) where TSupplier : Supplier => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(supplier)).ReceiveJson<TSupplier>();
		public Task<Supplier> PatchAsync(string supplierID, PartialSupplier partialSupplier, string accessToken = null) => PatchAsync<Supplier>(supplierID, partialSupplier, accessToken);
		public Task<TSupplier> PatchAsync<TSupplier>(string supplierID, PartialSupplier partialSupplier, string accessToken = null) where TSupplier : Supplier => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSupplier)).ReceiveJson<TSupplier>();
		public Task<ListPage<SupplierBuyer>> ListBuyersAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "buyers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SupplierBuyer>>();
		public Task<ListPage<SupplierBuyer>> ListBuyersAsync(string supplierID, Action<ListOptionsBuilder<SupplierBuyer>> buildListOpts, string accessToken = null) => Request("v1", "suppliers", supplierID, "buyers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SupplierBuyer>>();
		public Task SaveBuyerAsync(string supplierID, string buyerID, string accessToken = null) => Request("v1", "suppliers", supplierID, "buyers", buyerID).WithOAuthBearerToken(accessToken).PutAsync(null);
		public Task DeleteBuyerAsync(string supplierID, string buyerID, string accessToken = null) => Request("v1", "suppliers", supplierID, "buyers", buyerID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class SupplierUserGroupsResource : OrderCloudResource, ISupplierUserGroupsResource
	{
		internal SupplierUserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string supplierID, string userGroupID, string accessToken = null) => GetAsync<UserGroup>(supplierID, userGroupID, accessToken);
		public Task<TUserGroup> GetAsync<TUserGroup>(string supplierID, string userGroupID, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<TUserGroup>();
		public Task<ListPage<UserGroup>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<UserGroup>(supplierID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<ListPage<UserGroup>> ListAsync(string supplierID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => ListAsync<UserGroup>(supplierID, buildListOpts, accessToken);
		public Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string supplierID, Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<UserGroup> CreateAsync(string supplierID, UserGroup userGroup, string accessToken = null) => CreateAsync<UserGroup>(supplierID, userGroup, accessToken);
		public Task<TUserGroup> CreateAsync<TUserGroup>(string supplierID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<TUserGroup>();
		public Task<UserGroup> SaveAsync(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null) => SaveAsync<UserGroup>(supplierID, userGroupID, userGroup, accessToken);
		public Task<TUserGroup> SaveAsync<TUserGroup>(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<TUserGroup>();
		public Task DeleteAsync(string supplierID, string userGroupID, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<UserGroup> PatchAsync(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => PatchAsync<UserGroup>(supplierID, userGroupID, partialUserGroup, accessToken);
		public Task<TUserGroup> PatchAsync<TUserGroup>(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<TUserGroup>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string supplierID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string supplierID, string userGroupID, string userID, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID, "assignments", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveUserAssignmentAsync(string supplierID, UserGroupAssignment userGroupAssignment, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class SupplierUsersResource : OrderCloudResource, ISupplierUsersResource
	{
		internal SupplierUsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string supplierID, string userID, string accessToken = null) => GetAsync<User>(supplierID, userID, accessToken);
		public Task<TUser> GetAsync<TUser>(string supplierID, string userID, string accessToken = null) where TUser : User => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<TUser>();
		public Task<ListPage<User>> ListAsync(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<User>(supplierID, userGroupID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUser>> ListAsync<TUser>(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUser>>();
		public Task<ListPage<User>> ListAsync(string supplierID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null) => ListAsync<User>(supplierID, buildListOpts, userGroupID, accessToken);
		public Task<ListPage<TUser>> ListAsync<TUser>(string supplierID, Action<ListOptionsBuilder<TUser>> buildListOpts, string userGroupID = null, string accessToken = null) where TUser : User => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUser>>();
		public Task<User> CreateAsync(string supplierID, User user, string accessToken = null) => CreateAsync<User>(supplierID, user, accessToken);
		public Task<TUser> CreateAsync<TUser>(string supplierID, User user, string accessToken = null) where TUser : User => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<TUser>();
		public Task<User> SaveAsync(string supplierID, string userID, User user, string accessToken = null) => SaveAsync<User>(supplierID, userID, user, accessToken);
		public Task<TUser> SaveAsync<TUser>(string supplierID, string userID, User user, string accessToken = null) where TUser : User => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<TUser>();
		public Task DeleteAsync(string supplierID, string userID, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<User> PatchAsync(string supplierID, string userID, PartialUser partialUser, string accessToken = null) => PatchAsync<User>(supplierID, userID, partialUser, accessToken);
		public Task<TUser> PatchAsync<TUser>(string supplierID, string userID, PartialUser partialUser, string accessToken = null) where TUser : User => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<TUser>();
	}

	public class TrackingEventsResource : OrderCloudResource, ITrackingEventsResource
	{
		internal TrackingEventsResource(OrderCloudClient client) : base(client) { }
		public Task<TrackingEvent> GetAsync(string eventID, string accessToken = null) => Request("v1", "integrations", "trackingEvents", eventID).WithOAuthBearerToken(accessToken).GetJsonAsync<TrackingEvent>();
		public Task<ListPage<TrackingEvent>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "integrations", "trackingEvents").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TrackingEvent>>();
		public Task<ListPage<TrackingEvent>> ListAsync(Action<ListOptionsBuilder<TrackingEvent>> buildListOpts, string accessToken = null) => Request("v1", "integrations", "trackingEvents").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TrackingEvent>>();
		public Task<TrackingEvent> CreateAsync(TrackingEvent trackingEvent, string accessToken = null) => Request("v1", "integrations", "trackingEvents").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(trackingEvent)).ReceiveJson<TrackingEvent>();
		public Task<TrackingEvent> SaveAsync(string eventID, TrackingEvent trackingEvent, string accessToken = null) => Request("v1", "integrations", "trackingEvents", eventID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(trackingEvent)).ReceiveJson<TrackingEvent>();
		public Task DeleteAsync(string eventID, string accessToken = null) => Request("v1", "integrations", "trackingEvents", eventID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<TrackingEvent> PatchAsync(string eventID, PartialTrackingEvent partialTrackingEvent, string accessToken = null) => Request("v1", "integrations", "trackingEvents", eventID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialTrackingEvent)).ReceiveJson<TrackingEvent>();
	}

	public class UserGroupsResource : OrderCloudResource, IUserGroupsResource
	{
		internal UserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string buyerID, string userGroupID, string accessToken = null) => GetAsync<UserGroup>(buyerID, userGroupID, accessToken);
		public Task<TUserGroup> GetAsync<TUserGroup>(string buyerID, string userGroupID, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<TUserGroup>();
		public Task<ListPage<UserGroup>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<UserGroup>(buyerID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<ListPage<UserGroup>> ListAsync(string buyerID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => ListAsync<UserGroup>(buyerID, buildListOpts, accessToken);
		public Task<ListPage<TUserGroup>> ListAsync<TUserGroup>(string buyerID, Action<ListOptionsBuilder<TUserGroup>> buildListOpts, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUserGroup>>();
		public Task<UserGroup> CreateAsync(string buyerID, UserGroup userGroup, string accessToken = null) => CreateAsync<UserGroup>(buyerID, userGroup, accessToken);
		public Task<TUserGroup> CreateAsync<TUserGroup>(string buyerID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<TUserGroup>();
		public Task<UserGroup> SaveAsync(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null) => SaveAsync<UserGroup>(buyerID, userGroupID, userGroup, accessToken);
		public Task<TUserGroup> SaveAsync<TUserGroup>(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<TUserGroup>();
		public Task DeleteAsync(string buyerID, string userGroupID, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<UserGroup> PatchAsync(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => PatchAsync<UserGroup>(buyerID, userGroupID, partialUserGroup, accessToken);
		public Task<TUserGroup> PatchAsync<TUserGroup>(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) where TUserGroup : UserGroup => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<TUserGroup>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string buyerID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string buyerID, string userGroupID, string userID, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID, "assignments", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveUserAssignmentAsync(string buyerID, UserGroupAssignment userGroupAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class UsersResource : OrderCloudResource, IUsersResource
	{
		internal UsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string buyerID, string userID, string accessToken = null) => GetAsync<User>(buyerID, userID, accessToken);
		public Task<TUser> GetAsync<TUser>(string buyerID, string userID, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<TUser>();
		public Task<ListPage<User>> ListAsync(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAsync<User>(buyerID, userGroupID, search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUser>> ListAsync<TUser>(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUser>>();
		public Task<ListPage<User>> ListAsync(string buyerID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null) => ListAsync<User>(buyerID, buildListOpts, userGroupID, accessToken);
		public Task<ListPage<TUser>> ListAsync<TUser>(string buyerID, Action<ListOptionsBuilder<TUser>> buildListOpts, string userGroupID = null, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUser>>();
		public Task<User> CreateAsync(string buyerID, User user, string accessToken = null) => CreateAsync<User>(buyerID, user, accessToken);
		public Task<TUser> CreateAsync<TUser>(string buyerID, User user, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<TUser>();
		public Task<User> SaveAsync(string buyerID, string userID, User user, string accessToken = null) => SaveAsync<User>(buyerID, userID, user, accessToken);
		public Task<TUser> SaveAsync<TUser>(string buyerID, string userID, User user, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<TUser>();
		public Task DeleteAsync(string buyerID, string userID, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<User>> ListAcrossBuyersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => ListAcrossBuyersAsync<User>(search, searchOn, sortBy, page, pageSize, filters, accessToken);
		public Task<ListPage<TUser>> ListAcrossBuyersAsync<TUser>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) where TUser : User => Request("v1", "buyerusers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<TUser>>();
		public Task<ListPage<User>> ListAcrossBuyersAsync(Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null) => ListAcrossBuyersAsync<User>(buildListOpts, accessToken);
		public Task<ListPage<TUser>> ListAcrossBuyersAsync<TUser>(Action<ListOptionsBuilder<TUser>> buildListOpts, string accessToken = null) where TUser : User => Request("v1", "buyerusers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<TUser>>();
		public Task<User> PatchAsync(string buyerID, string userID, PartialUser partialUser, string accessToken = null) => PatchAsync<User>(buyerID, userID, partialUser, accessToken);
		public Task<TUser> PatchAsync<TUser>(string buyerID, string userID, PartialUser partialUser, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<TUser>();
		public Task<User> MoveAsync(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null) => MoveAsync<User>(buyerID, userID, newBuyerID, orders, accessToken);
		public Task<TUser> MoveAsync<TUser>(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null) where TUser : User => Request("v1", "buyers", buyerID, "users", userID, "moveto", newBuyerID).WithOAuthBearerToken(accessToken).SetQueryParams(new { orders }).PostAsync(null).ReceiveJson<TUser>();
		public Task<AccessToken> GetAccessTokenAsync(string buyerID, string userID, ImpersonateTokenRequest impersonateTokenRequest, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID, "accesstoken").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(impersonateTokenRequest)).ReceiveJson<AccessToken>();
	}

	public class WebhooksResource : OrderCloudResource, IWebhooksResource
	{
		internal WebhooksResource(OrderCloudClient client) : base(client) { }
		public Task<Webhook> GetAsync(string webhookID, string accessToken = null) => Request("v1", "webhooks", webhookID).WithOAuthBearerToken(accessToken).GetJsonAsync<Webhook>();
		public Task<ListPage<Webhook>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "webhooks").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Webhook>>();
		public Task<ListPage<Webhook>> ListAsync(Action<ListOptionsBuilder<Webhook>> buildListOpts, string accessToken = null) => Request("v1", "webhooks").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Webhook>>();
		public Task<Webhook> CreateAsync(Webhook webhook, string accessToken = null) => Request("v1", "webhooks").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(webhook)).ReceiveJson<Webhook>();
		public Task<Webhook> SaveAsync(string webhookID, Webhook webhook, string accessToken = null) => Request("v1", "webhooks", webhookID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(webhook)).ReceiveJson<Webhook>();
		public Task DeleteAsync(string webhookID, string accessToken = null) => Request("v1", "webhooks", webhookID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Webhook> PatchAsync(string webhookID, PartialWebhook partialWebhook, string accessToken = null) => Request("v1", "webhooks", webhookID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialWebhook)).ReceiveJson<Webhook>();
	}

	public class XpIndicesResource : OrderCloudResource, IXpIndicesResource
	{
		internal XpIndicesResource(OrderCloudClient client) : base(client) { }
		public Task<ListPage<XpIndex>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "xpindices").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<XpIndex>>();
		public Task<ListPage<XpIndex>> ListAsync(Action<ListOptionsBuilder<XpIndex>> buildListOpts, string accessToken = null) => Request("v1", "xpindices").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<XpIndex>>();
		public Task DeleteAsync(XpThingType thingType, string key, string accessToken = null) => Request("v1", "xpindices", thingType, key).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task PutAsync(XpIndex xpIndex, string accessToken = null) => Request("v1", "xpindices").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(xpIndex));
	}
}
