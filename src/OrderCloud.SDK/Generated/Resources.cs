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
		IApprovalRulesResource ApprovalRules { get; }
		IBuyersResource Buyers { get; }
		ICatalogsResource Catalogs { get; }
		ICategoriesResource Categories { get; }
		ICostCentersResource CostCenters { get; }
		ICreditCardsResource CreditCards { get; }
		IImpersonationConfigsResource ImpersonationConfigs { get; }
		IIncrementorsResource Incrementors { get; }
		ILineItemsResource LineItems { get; }
		IMeResource Me { get; }
		IMessageSendersResource MessageSenders { get; }
		IOrdersResource Orders { get; }
		IPasswordResetsResource PasswordResets { get; }
		IPaymentsResource Payments { get; }
		IPriceSchedulesResource PriceSchedules { get; }
		IProductsResource Products { get; }
		IPromotionsResource Promotions { get; }
		ISecurityProfilesResource SecurityProfiles { get; }
		IShipmentsResource Shipments { get; }
		ISpecsResource Specs { get; }
		ISpendingAccountsResource SpendingAccounts { get; }
		ISuppliersResource Suppliers { get; }
		ISupplierUserGroupsResource SupplierUserGroups { get; }
		ISupplierUsersResource SupplierUsers { get; }
		IUserGroupsResource UserGroups { get; }
		IUsersResource Users { get; }
	}

	public interface IAddressesResource
	{
		/// <summary>Get a single address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> GetAsync(string buyerID, string addressID, string accessToken = null);
		/// <summary>Get a single address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> GetAsync<Txp>(string buyerID, string addressID, string accessToken = null);
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of addresses.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string buyerID, Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of addresses.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<Address<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> CreateAsync(string buyerID, Address address, string accessToken = null);
		/// <summary>Create a new address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> CreateAsync<Txp>(string buyerID, Address address, string accessToken = null);
		/// <summary>Create or update an address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> SaveAsync(string buyerID, string addressID, Address address, string accessToken = null);
		/// <summary>Create or update an address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> SaveAsync<Txp>(string buyerID, string addressID, Address address, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> PatchAsync<Txp>(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Get a list of address assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the address assignment. Possible values: User, Group, Company.</param>
		/// <param name="isShipping">Is shipping of the address assignment.</param>
		/// <param name="isBilling">Is billing of the address assignment.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> GetAsync<Txp>(string addressID, string accessToken = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address>> ListAsync(Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Address<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Address<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new admin address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> CreateAsync(Address address, string accessToken = null);
		/// <summary>Create a new admin address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> CreateAsync<Txp>(Address address, string accessToken = null);
		/// <summary>Create or update an admin address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address> SaveAsync(string addressID, Address address, string accessToken = null);
		/// <summary>Create or update an admin address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> SaveAsync<Txp>(string addressID, Address address, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Address<Txp>> PatchAsync<Txp>(string addressID, PartialAddress partialAddress, string accessToken = null);
	}

	public interface IAdminUserGroupsResource
	{
		/// <summary>Get a single admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> GetAsync(string userGroupID, string accessToken = null);
		/// <summary>Get a single admin user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> GetAsync<Txp>(string userGroupID, string accessToken = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new admin user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> CreateAsync(UserGroup userGroup, string accessToken = null);
		/// <summary>Create a new admin user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> CreateAsync<Txp>(UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update an admin user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> SaveAsync(string userGroupID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update an admin user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> SaveAsync<Txp>(string userGroupID, UserGroup userGroup, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> PatchAsync<Txp>(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null);
		/// <summary>Get a list of admin user group user assignments.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> GetAsync<Txp>(string userID, string accessToken = null);
		/// <summary>Get a list of admin users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of admin users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of admin users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new admin user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> CreateAsync(User user, string accessToken = null);
		/// <summary>Create a new admin user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> CreateAsync<Txp>(User user, string accessToken = null);
		/// <summary>Create or update an admin user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> SaveAsync(string userID, User user, string accessToken = null);
		/// <summary>Create or update an admin user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> SaveAsync<Txp>(string userID, User user, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> PatchAsync<Txp>(string userID, PartialUser partialUser, string accessToken = null);
	}

	public interface IApprovalRulesResource
	{
		/// <summary>Get a single approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> GetAsync(string buyerID, string approvalRuleID, string accessToken = null);
		/// <summary>Get a single approval rule.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule<Txp>> GetAsync<Txp>(string buyerID, string approvalRuleID, string accessToken = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApprovalRule>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApprovalRule<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApprovalRule>> ListAsync(string buyerID, Action<ListOptionsBuilder<ApprovalRule>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ApprovalRule<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<ApprovalRule<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> CreateAsync(string buyerID, ApprovalRule approvalRule, string accessToken = null);
		/// <summary>Create a new approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule<Txp>> CreateAsync<Txp>(string buyerID, ApprovalRule approvalRule, string accessToken = null);
		/// <summary>Create or update an approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule> SaveAsync(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null);
		/// <summary>Create or update an approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="approvalRule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule<Txp>> SaveAsync<Txp>(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		/// <param name="partialApprovalRule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ApprovalRule<Txp>> PatchAsync<Txp>(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null);
	}

	public interface IBuyersResource
	{
		/// <summary>Get a single buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> GetAsync(string buyerID, string accessToken = null);
		/// <summary>Get a single buyer.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer<Txp>> GetAsync<Txp>(string buyerID, string accessToken = null);
		/// <summary>Get a list of buyers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Buyer>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of buyers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Buyer<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of buyers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Buyer>> ListAsync(Action<ListOptionsBuilder<Buyer>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of buyers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Buyer<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Buyer<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new buyer. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> CreateAsync(Buyer buyer, string accessToken = null);
		/// <summary>Create a new buyer. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer<Txp>> CreateAsync<Txp>(Buyer buyer, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buyer">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer<Txp>> SaveAsync<Txp>(string buyerID, Buyer buyer, string accessToken = null);
		/// <summary>Partially update a buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="partialBuyer">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer> PatchAsync(string buyerID, PartialBuyer partialBuyer, string accessToken = null);
		/// <summary>Partially update a buyer.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="partialBuyer">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Buyer<Txp>> PatchAsync<Txp>(string buyerID, PartialBuyer partialBuyer, string accessToken = null);
	}

	public interface ICatalogsResource
	{
		/// <summary>Get a single catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> GetAsync(string catalogID, string accessToken = null);
		/// <summary>Get a single catalog.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog<Txp>> GetAsync<Txp>(string catalogID, string accessToken = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Catalog<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new catalog. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> CreateAsync(Catalog catalog, string accessToken = null);
		/// <summary>Create a new catalog. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog<Txp>> CreateAsync<Txp>(Catalog catalog, string accessToken = null);
		/// <summary>Create or update a catalog. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> SaveAsync(string catalogID, Catalog catalog, string accessToken = null);
		/// <summary>Create or update a catalog. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="catalog">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog<Txp>> SaveAsync<Txp>(string catalogID, Catalog catalog, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="partialCatalog">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog<Txp>> PatchAsync<Txp>(string catalogID, PartialCatalog partialCatalog, string accessToken = null);
		/// <summary>Get a list of catalog assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <param name="page">Page of results to return. Default: 1</param>
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
	}

	public interface ICategoriesResource
	{
		/// <summary>Get a single category.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> GetAsync(string catalogID, string categoryID, string accessToken = null);
		/// <summary>Get a single category.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category<Txp>> GetAsync<Txp>(string catalogID, string categoryID, string accessToken = null);
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListAsync(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of categories.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category<Txp>>> ListAsync<Txp>(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListAsync(string catalogID, Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string accessToken = null);
		/// <summary>Get a list of categories.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category<Txp>>> ListAsync<Txp>(string catalogID, Action<ListOptionsBuilder<Category<Txp>>> buildListOpts, string depth = "1", string accessToken = null);
		/// <summary>Create a new category. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> CreateAsync(string catalogID, Category category, string accessToken = null);
		/// <summary>Create a new category. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category<Txp>> CreateAsync<Txp>(string catalogID, Category category, string accessToken = null);
		/// <summary>Create or update a category. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> SaveAsync(string catalogID, string categoryID, Category category, string accessToken = null);
		/// <summary>Create or update a category. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="category">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category<Txp>> SaveAsync<Txp>(string catalogID, string categoryID, Category category, string accessToken = null);
		/// <summary>Delete a category. Deleting a parent category will also delete all of that category's children.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string catalogID, string categoryID, string accessToken = null);
		/// <summary>Partially update a category.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="partialCategory">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> PatchAsync(string catalogID, string categoryID, PartialCategory partialCategory, string accessToken = null);
		/// <summary>Partially update a category.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="partialCategory">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category<Txp>> PatchAsync<Txp>(string catalogID, string categoryID, PartialCategory partialCategory, string accessToken = null);
		/// <summary>Get a list of category assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the category assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <param name="page">Page of results to return. Default: 1</param>
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
	}

	public interface ICostCentersResource
	{
		/// <summary>Get a single cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> GetAsync(string buyerID, string costCenterID, string accessToken = null);
		/// <summary>Get a single cost center.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter<Txp>> GetAsync<Txp>(string buyerID, string costCenterID, string accessToken = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListAsync(string buyerID, Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<CostCenter<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new cost center. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> CreateAsync(string buyerID, CostCenter costCenter, string accessToken = null);
		/// <summary>Create a new cost center. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter<Txp>> CreateAsync<Txp>(string buyerID, CostCenter costCenter, string accessToken = null);
		/// <summary>Create or update a cost center. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter> SaveAsync(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null);
		/// <summary>Create or update a cost center. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="costCenter">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter<Txp>> SaveAsync<Txp>(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="partialCostCenter">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CostCenter<Txp>> PatchAsync<Txp>(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null);
		/// <summary>Get a list of cost center assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the cost center assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard<Txp>> GetAsync<Txp>(string buyerID, string creditCardID, string accessToken = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCard>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCard<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCard>> ListAsync(string buyerID, Action<ListOptionsBuilder<CreditCard>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CreditCard<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<CreditCard<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new credit card. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard> CreateAsync(string buyerID, CreditCard creditCard, string accessToken = null);
		/// <summary>Create a new credit card. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard<Txp>> CreateAsync<Txp>(string buyerID, CreditCard creditCard, string accessToken = null);
		/// <summary>Create or update a credit card. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard> SaveAsync(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null);
		/// <summary>Create or update a credit card. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="creditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard<Txp>> SaveAsync<Txp>(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="partialCreditCard">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<CreditCard<Txp>> PatchAsync<Txp>(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null);
		/// <summary>Get a list of credit card assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the credit card assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
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
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
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

	public interface ILineItemsResource
	{
		/// <summary>Get a single line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> GetAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Get a single line item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of line items.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of line items.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<LineItem<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<LineItem<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> CreateAsync(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null);
		/// <summary>Create a new line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null);
		/// <summary>Create or update a line item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SaveAsync(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null);
		/// <summary>Create or update a line item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="lineItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null);
		/// <summary>Delete a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Partially update a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchAsync(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null);
		/// <summary>Partially update a line item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialLineItem">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null);
		/// <summary>Set a shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> SetShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null);
		/// <summary>Set a shipping address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null);
		/// <summary>Partially update a line item shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem> PatchShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update a line item shipping address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<LineItem<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null);
	}

	public interface IMeResource
	{
		/// <summary>Get the Current Authenticated User</summary>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser> GetAsync(string accessToken = null);
		/// <summary>Get the Current Authenticated User</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser<Txp>> GetAsync<Txp>(string accessToken = null);
		/// <summary>Update the Currently Authenticated User If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="meUser">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser> SaveAsync(MeUser meUser, string accessToken = null);
		/// <summary>Update the Currently Authenticated User If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="meUser">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser<Txp>> SaveAsync<Txp>(MeUser meUser, string accessToken = null);
		/// <summary>Patch the Currently Authenticated User.</summary>
		/// <param name="partialMeUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser> PatchAsync(PartialMeUser partialMeUser, string accessToken = null);
		/// <summary>Patch the Currently Authenticated User.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="partialMeUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MeUser<Txp>> PatchAsync<Txp>(PartialMeUser partialMeUser, string accessToken = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListCostCentersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter<Txp>>> ListCostCentersAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter>> ListCostCentersAsync(Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<CostCenter<Txp>>> ListCostCentersAsync<Txp>(Action<ListOptionsBuilder<CostCenter<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListUserGroupsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListUserGroupsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListUserGroupsAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListUserGroupsAsync<Txp>(Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerAddress>> ListAddressesAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerAddress<Txp>>> ListAddressesAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerAddress>> ListAddressesAsync(Action<ListOptionsBuilder<BuyerAddress>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerAddress<Txp>>> ListAddressesAsync<Txp>(Action<ListOptionsBuilder<BuyerAddress<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new address. Only available to Buyer Users.</summary>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress> CreateAddressAsync(BuyerAddress buyerAddress, string accessToken = null);
		/// <summary>Create a new address. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress<Txp>> CreateAddressAsync<Txp>(BuyerAddress buyerAddress, string accessToken = null);
		/// <summary>Get a single address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress> GetAddressAsync(string addressID, string accessToken = null);
		/// <summary>Get a single address. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress<Txp>> GetAddressAsync<Txp>(string addressID, string accessToken = null);
		/// <summary>Create or update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress> SaveAddressAsync(string addressID, BuyerAddress buyerAddress, string accessToken = null);
		/// <summary>Create or update an address. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="buyerAddress">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerAddress<Txp>> SaveAddressAsync<Txp>(string addressID, BuyerAddress buyerAddress, string accessToken = null);
		/// <summary>Partially update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="partialBuyerAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task PatchAddressAsync(string addressID, PartialBuyerAddress partialBuyerAddress, string accessToken = null);
		/// <summary>Delete an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAddressAsync(string addressID, string accessToken = null);
		/// <summary>Create a new credit card. Only available to Buyer Users.</summary>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard> CreateCreditCardAsync(BuyerCreditCard buyerCreditCard, string accessToken = null);
		/// <summary>Create a new credit card. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard<Txp>> CreateCreditCardAsync<Txp>(BuyerCreditCard buyerCreditCard, string accessToken = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerCreditCard<Txp>>> ListCreditCardsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(Action<ListOptionsBuilder<BuyerCreditCard>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerCreditCard<Txp>>> ListCreditCardsAsync<Txp>(Action<ListOptionsBuilder<BuyerCreditCard<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a single credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard> GetCreditCardAsync(string creditcardID, string accessToken = null);
		/// <summary>Get a single credit card. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard<Txp>> GetCreditCardAsync<Txp>(string creditcardID, string accessToken = null);
		/// <summary>Create or update a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard> SaveCreditCardAsync(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null);
		/// <summary>Create or update a credit card. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="creditcardID">ID of the creditcard.</param>
		/// <param name="buyerCreditCard">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerCreditCard<Txp>> SaveCreditCardAsync<Txp>(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null);
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
		/// <param name="depth">Depth of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListCategoriesAsync(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category<Txp>>> ListCategoriesAsync<Txp>(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category>> ListCategoriesAsync(Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null);
		/// <summary>Get a list of categories visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Category<Txp>>> ListCategoriesAsync<Txp>(Action<ListOptionsBuilder<Category<Txp>>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null);
		/// <summary>Get a single category. Only available to Buyer Users.</summary>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category> GetCategoryAsync(string categoryID, string catalogID, string accessToken = null);
		/// <summary>Get a single category. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Category<Txp>> GetCategoryAsync<Txp>(string categoryID, string catalogID, string accessToken = null);
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Depth of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerProduct>> ListProductsAsync(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Depth of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerProduct<Txp>>> ListProductsAsync<Txp>(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Depth of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerProduct>> ListProductsAsync(Action<ListOptionsBuilder<BuyerProduct>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string accessToken = null);
		/// <summary>Get a list of products visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="depth">Depth of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerProduct<Txp>>> ListProductsAsync<Txp>(Action<ListOptionsBuilder<BuyerProduct<Txp>>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string accessToken = null);
		/// <summary>Get a single product. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerProduct> GetProductAsync(string productID, string accessToken = null);
		/// <summary>Get a single product. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerProduct<Txp>> GetProductAsync<Txp>(string productID, string accessToken = null);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSpec>> ListSpecsAsync(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSpec<Txp>>> ListSpecsAsync<Txp>(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSpec>> ListSpecsAsync(string productID, Action<ListOptionsBuilder<BuyerSpec>> buildListOpts, string catalogID = null, string accessToken = null);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<BuyerSpec<Txp>>> ListSpecsAsync<Txp>(string productID, Action<ListOptionsBuilder<BuyerSpec<Txp>>> buildListOpts, string catalogID = null, string accessToken = null);
		/// <summary>Get a single spec. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerSpec> GetSpecAsync(string productID, string specID, string catalogID = null, string accessToken = null);
		/// <summary>Get a single spec. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<BuyerSpec<Txp>> GetSpecAsync<Txp>(string productID, string specID, string catalogID = null, string accessToken = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order<Txp>>> ListOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListOrdersAsync(Action<ListOptionsBuilder<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order<Txp>>> ListOrdersAsync<Txp>(Action<ListOptionsBuilder<Order<Txp>>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListApprovableOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order<Txp>>> ListApprovableOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListApprovableOrdersAsync(Action<ListOptionsBuilder<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order<Txp>>> ListApprovableOrdersAsync<Txp>(Action<ListOptionsBuilder<Order<Txp>>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion<Txp>>> ListPromotionsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListPromotionsAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion<Txp>>> ListPromotionsAsync<Txp>(Action<ListOptionsBuilder<Promotion<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a single promotion. Only available to Buyer Users.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> GetPromotionAsync(string promotionID, string accessToken = null);
		/// <summary>Get a single promotion. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion<Txp>> GetPromotionAsync<Txp>(string promotionID, string accessToken = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount<Txp>>> ListSpendingAccountsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount<Txp>>> ListSpendingAccountsAsync<Txp>(Action<ListOptionsBuilder<SpendingAccount<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a single spending account. Only available to Buyer Users.</summary>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> GetSpendingAccountAsync(string spendingAccountID, string accessToken = null);
		/// <summary>Get a single spending account. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount<Txp>> GetSpendingAccountAsync<Txp>(string spendingAccountID, string accessToken = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment<Txp>>> ListShipmentsAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment<Txp>>> ListShipmentsAsync<Txp>(Action<ListOptionsBuilder<Shipment<Txp>>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a single shipment. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> GetShipmentAsync(string shipmentID, string accessToken = null);
		/// <summary>Get a single shipment. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment<Txp>> GetShipmentAsync<Txp>(string shipmentID, string accessToken = null);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem<Txp>>> ListShipmentItemsAsync<Txp>(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem<Txp>>> ListShipmentItemsAsync<Txp>(string shipmentID, Action<ListOptionsBuilder<ShipmentItem<Txp>>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Register a register.</summary>
		/// <param name="meUser">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="anonUserToken">Anon user token of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<dynamic> RegisterAsync(MeUser meUser, string anonUserToken, string accessToken = null);
		/// <summary>Transfer an anon user order.</summary>
		/// <param name="anonUserToken">Anon user token of the me.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task TransferAnonUserOrderAsync(string anonUserToken, string accessToken = null);
		/// <summary>Reset a password by token.</summary>
		/// <param name="tokenPasswordReset">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ResetPasswordByTokenAsync(TokenPasswordReset tokenPasswordReset, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListCatalogsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog<Txp>>> ListCatalogsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog>> ListCatalogsAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Catalog<Txp>>> ListCatalogsAsync<Txp>(Action<ListOptionsBuilder<Catalog<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a single catalog. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog> GetCatalogAsync(string catalogID, string accessToken = null);
		/// <summary>Get a single catalog. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Catalog<Txp>> GetCatalogAsync<Txp>(string catalogID, string accessToken = null);
	}

	public interface IMessageSendersResource
	{
		/// <summary>Get a single message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<MessageSender> GetAsync(string messageSenderID, string accessToken = null);
		/// <summary>Get a list of message senders.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageSender>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of message senders.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageSender>> ListAsync(Action<ListOptionsBuilder<MessageSender>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of message sender assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the message sender assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<MessageSenderAssignment>> ListAssignmentsAsync(string buyerID = null, string messageSenderID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a message sender assignment.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string messageSenderID, string buyerID = null, string userID = null, string userGroupID = null, string accessToken = null);
		/// <summary>Create or update a message sender assignment.</summary>
		/// <param name="messageSenderAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(MessageSenderAssignment messageSenderAssignment, string accessToken = null);
		/// <summary>Get a list of message sender cc listener assignments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
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

	public interface IOrdersResource
	{
		/// <summary>Get a single order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> GetAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Get a single order.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Get a list of orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order<Txp>>> ListAsync<Txp>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of orders.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order>> ListAsync(OrderDirection direction, Action<ListOptionsBuilder<Order>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Get a list of orders.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="from">Lower bound of date range that the order was created.</param>
		/// <param name="to">Upper bound of date range that the order was created.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Order<Txp>>> ListAsync<Txp>(OrderDirection direction, Action<ListOptionsBuilder<Order<Txp>>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null);
		/// <summary>Create a new order. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> CreateAsync(OrderDirection direction, Order order, string accessToken = null);
		/// <summary>Create a new order. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> CreateAsync<Txp>(OrderDirection direction, Order order, string accessToken = null);
		/// <summary>Create or update an order. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SaveAsync(OrderDirection direction, string orderID, Order order, string accessToken = null);
		/// <summary>Create or update an order. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="order">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, Order order, string accessToken = null);
		/// <summary>Delete an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderApproval>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListEligibleApproversAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListEligibleApproversAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Partially update an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialOrder">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchAsync(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null);
		/// <summary>Partially update an order.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialOrder">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null);
		/// <summary>Submit an order submit.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SubmitAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Submit an order submit.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> SubmitAsync<Txp>(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Approve an order approve.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> ApproveAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null);
		/// <summary>Approve an order approve.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> ApproveAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null);
		/// <summary>Decline an order decline.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> DeclineAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null);
		/// <summary>Decline an order decline.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="orderApprovalInfo">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> DeclineAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null);
		/// <summary>Cancel an order cancel.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> CancelAsync(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Cancel an order cancel.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> CancelAsync<Txp>(OrderDirection direction, string orderID, string accessToken = null);
		/// <summary>Create a new shipment containing all items on an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> ShipAsync(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null);
		/// <summary>Create a new shipment containing all items on an order.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> ShipAsync<Txp>(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null);
		/// <summary>Set a shipping address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's ShippingAddressID property instead.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SetShippingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null);
		/// <summary>Set a shipping address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's ShippingAddressID property instead.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address, string accessToken = null);
		/// <summary>Partially update an order shipping address. Not allowed on unsubmitted orders where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchShippingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update an order shipping address. Not allowed on unsubmitted orders where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> SetBillingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null);
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="address">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> SetBillingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address, string accessToken = null);
		/// <summary>Partially update an order billing address. Not allowed on unsubmitted orders where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchBillingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Partially update an order billing address. Not allowed on unsubmitted orders where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialAddress">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> PatchBillingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null);
		/// <summary>Override order creator details. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> PatchFromUserAsync(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null);
		/// <summary>Override order creator details. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> PatchFromUserAsync<Txp>(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null);
		/// <summary>Add a promotion to an order</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> AddPromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null);
		/// <summary>Add a promotion to an order</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion<Txp>> AddPromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode, string accessToken = null);
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order promotions.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion<Txp>>> ListPromotionsAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderPromotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of order promotions.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<OrderPromotion<Txp>>> ListPromotionsAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderPromotion<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Remove a promotion from an order</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order> RemovePromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null);
		/// <summary>Remove a promotion from an order</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Order<Txp>> RemovePromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode, string accessToken = null);
	}

	public interface IPasswordResetsResource
	{
		/// <summary>Send a verification code. Sends a temporary verification code via email, which must subsequently be passed in a Reset Password call.</summary>
		/// <param name="passwordResetRequest">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SendVerificationCodeAsync(PasswordResetRequest passwordResetRequest, string accessToken = null);
		/// <summary>Reset a password by verification code.</summary>
		/// <param name="verificationCode">Verification code of the password reset.</param>
		/// <param name="passwordReset">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task ResetPasswordByVerificationCodeAsync(string verificationCode, PasswordReset passwordReset, string accessToken = null);
	}

	public interface IPaymentsResource
	{
		/// <summary>Get a single payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> GetAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null);
		/// <summary>Get a single payment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string paymentID, string accessToken = null);
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of payments.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Payment>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of payments.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Payment<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Payment<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new payment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="payment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> CreateAsync(OrderDirection direction, string orderID, Payment payment, string accessToken = null);
		/// <summary>Create a new payment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="payment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, Payment payment, string accessToken = null);
		/// <summary>Delete a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null);
		/// <summary>Partially update a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="partialPayment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> PatchAsync(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null);
		/// <summary>Partially update a payment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="partialPayment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null);
		/// <summary>Create a new payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="paymentTransaction">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment> CreateTransactionAsync(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null);
		/// <summary>Create a new payment transaction.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="paymentTransaction">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Payment<Txp>> CreateTransactionAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null);
		/// <summary>Delete a payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule<Txp>> GetAsync<Txp>(string priceScheduleID, string accessToken = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PriceSchedule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PriceSchedule<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PriceSchedule>> ListAsync(Action<ListOptionsBuilder<PriceSchedule>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<PriceSchedule<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<PriceSchedule<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new price schedule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> CreateAsync(PriceSchedule priceSchedule, string accessToken = null);
		/// <summary>Create a new price schedule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule<Txp>> CreateAsync<Txp>(PriceSchedule priceSchedule, string accessToken = null);
		/// <summary>Create or update a price schedule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> SaveAsync(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null);
		/// <summary>Create or update a price schedule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceSchedule">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule<Txp>> SaveAsync<Txp>(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="partialPriceSchedule">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule<Txp>> PatchAsync<Txp>(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null);
		/// <summary>Create or update a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceBreak">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule> SavePriceBreakAsync(string priceScheduleID, PriceBreak priceBreak, string accessToken = null);
		/// <summary>Create or update a price schedule price break.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="priceBreak">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<PriceSchedule<Txp>> SavePriceBreakAsync<Txp>(string priceScheduleID, PriceBreak priceBreak, string accessToken = null);
		/// <summary>Delete a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="quantity">Quantity of the price schedule.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeletePriceBreakAsync(string priceScheduleID, int quantity, string accessToken = null);
	}

	public interface IProductsResource
	{
		/// <summary>Get a single product.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> GetAsync(string productID, string accessToken = null);
		/// <summary>Get a single product.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product<Txp>> GetAsync<Txp>(string productID, string accessToken = null);
		/// <summary>Get a list of products.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Product>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of products.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Product<Txp>>> ListAsync<Txp>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of products.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Product>> ListAsync(Action<ListOptionsBuilder<Product>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null);
		/// <summary>Get a list of products.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Product<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Product<Txp>>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null);
		/// <summary>Create a new product. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> CreateAsync(Product product, string accessToken = null);
		/// <summary>Create a new product. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product<Txp>> CreateAsync<Txp>(Product product, string accessToken = null);
		/// <summary>Create or update a product. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> SaveAsync(string productID, Product product, string accessToken = null);
		/// <summary>Create or update a product. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="product">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product<Txp>> SaveAsync<Txp>(string productID, Product product, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="partialProduct">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product<Txp>> PatchAsync<Txp>(string productID, PartialProduct partialProduct, string accessToken = null);
		/// <summary>Generate a variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="overwriteExisting">Overwrite existing of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product> GenerateVariantsAsync(string productID, bool overwriteExisting = false, string accessToken = null);
		/// <summary>Generate a variants.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="overwriteExisting">Overwrite existing of the product.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Product<Txp>> GenerateVariantsAsync<Txp>(string productID, bool overwriteExisting = false, string accessToken = null);
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product variants.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant<Txp>>> ListVariantsAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, Action<ListOptionsBuilder<Variant>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product variants.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Variant<Txp>>> ListVariantsAsync<Txp>(string productID, Action<ListOptionsBuilder<Variant<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create or update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="variant">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> SaveVariantAsync(string productID, string variantID, Variant variant, string accessToken = null);
		/// <summary>Create or update a product variant.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="variant">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant<Txp>> SaveVariantAsync<Txp>(string productID, string variantID, Variant variant, string accessToken = null);
		/// <summary>Partially update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="partialVariant">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> PatchVariantAsync(string productID, string variantID, PartialVariant partialVariant, string accessToken = null);
		/// <summary>Partially update a product variant.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="partialVariant">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant<Txp>> PatchVariantAsync<Txp>(string productID, string variantID, PartialVariant partialVariant, string accessToken = null);
		/// <summary>Get a single product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant> GetVariantAsync(string productID, string variantID, string accessToken = null);
		/// <summary>Get a single product variant.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Variant<Txp>> GetVariantAsync<Txp>(string productID, string variantID, string accessToken = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier>> ListSuppliersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier<Txp>>> ListSuppliersAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier>> ListSuppliersAsync(string productID, Action<ListOptionsBuilder<Supplier>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier<Txp>>> ListSuppliersAsync<Txp>(string productID, Action<ListOptionsBuilder<Supplier<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create or update a product supplier.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveSupplierAsync(string productID, string supplierID, string accessToken = null);
		/// <summary>Remove a supplier.</summary>
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
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ProductAssignment>> ListAssignmentsAsync(string productID = null, string priceScheduleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a product assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string productID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null);
	}

	public interface IPromotionsResource
	{
		/// <summary>Get a single promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> GetAsync(string promotionID, string accessToken = null);
		/// <summary>Get a single promotion.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion<Txp>> GetAsync<Txp>(string promotionID, string accessToken = null);
		/// <summary>Get a list of promotions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of promotions.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of promotions.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion>> ListAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of promotions.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Promotion<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Promotion<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new promotion. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> CreateAsync(Promotion promotion, string accessToken = null);
		/// <summary>Create a new promotion. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion<Txp>> CreateAsync<Txp>(Promotion promotion, string accessToken = null);
		/// <summary>Create or update a promotion. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion> SaveAsync(string promotionID, Promotion promotion, string accessToken = null);
		/// <summary>Create or update a promotion. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="promotion">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion<Txp>> SaveAsync<Txp>(string promotionID, Promotion promotion, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="partialPromotion">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Promotion<Txp>> PatchAsync<Txp>(string promotionID, PartialPromotion partialPromotion, string accessToken = null);
		/// <summary>Get a list of promotion assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the promotion assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SecurityProfile>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of security profiles.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SecurityProfile>> ListAsync(Action<ListOptionsBuilder<SecurityProfile>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of security profile assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="commerceRole">Commerce role of the security profile assignment. Possible values: Buyer, Seller, Supplier.</param>
		/// <param name="level">Level of the security profile assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SecurityProfileAssignment>> ListAssignmentsAsync(string buyerID = null, string supplierID = null, string securityProfileID = null, string userID = null, string userGroupID = null, CommerceRole? commerceRole = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null);
		/// <summary>Delete a security profile assignment.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAssignmentAsync(string securityProfileID, string buyerID = null, string userID = null, string userGroupID = null, string accessToken = null);
		/// <summary>Create or update a security profile assignment.</summary>
		/// <param name="securityProfileAssignment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task SaveAssignmentAsync(SecurityProfileAssignment securityProfileAssignment, string accessToken = null);
	}

	public interface IShipmentsResource
	{
		/// <summary>Get a single shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> GetAsync(string shipmentID, string accessToken = null);
		/// <summary>Get a single shipment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment<Txp>> GetAsync<Txp>(string shipmentID, string accessToken = null);
		/// <summary>Get a list of shipments.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipments.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment<Txp>>> ListAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipments.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment>> ListAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Get a list of shipments.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Shipment<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Shipment<Txp>>> buildListOpts, string orderID = null, string accessToken = null);
		/// <summary>Create a new shipment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> CreateAsync(Shipment shipment, string accessToken = null);
		/// <summary>Create a new shipment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment<Txp>> CreateAsync<Txp>(Shipment shipment, string accessToken = null);
		/// <summary>Create or update a shipment. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment> SaveAsync(string shipmentID, Shipment shipment, string accessToken = null);
		/// <summary>Create or update a shipment. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipment">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment<Txp>> SaveAsync<Txp>(string shipmentID, Shipment shipment, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="partialShipment">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Shipment<Txp>> PatchAsync<Txp>(string shipmentID, PartialShipment partialShipment, string accessToken = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem<Txp>>> ListItemsAsync<Txp>(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<ShipmentItem<Txp>>> ListItemsAsync<Txp>(string shipmentID, Action<ListOptionsBuilder<ShipmentItem<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Get a single shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ShipmentItem> GetItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Get a single shipment item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ShipmentItem<Txp>> GetItemAsync<Txp>(string shipmentID, string orderID, string lineItemID, string accessToken = null);
		/// <summary>Create or update a shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipmentItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ShipmentItem> SaveItemAsync(string shipmentID, ShipmentItem shipmentItem, string accessToken = null);
		/// <summary>Create or update a shipment item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="shipmentItem">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ShipmentItem<Txp>> SaveItemAsync<Txp>(string shipmentID, ShipmentItem shipmentItem, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec<Txp>> GetAsync<Txp>(string specID, string accessToken = null);
		/// <summary>Get a list of specs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of specs.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of specs.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec>> ListAsync(Action<ListOptionsBuilder<Spec>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of specs.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Spec<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Spec<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new spec. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> CreateAsync(Spec spec, string accessToken = null);
		/// <summary>Create a new spec. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec<Txp>> CreateAsync<Txp>(Spec spec, string accessToken = null);
		/// <summary>Create or update a spec. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec> SaveAsync(string specID, Spec spec, string accessToken = null);
		/// <summary>Create or update a spec. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="spec">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec<Txp>> SaveAsync<Txp>(string specID, Spec spec, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="partialSpec">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Spec<Txp>> PatchAsync<Txp>(string specID, PartialSpec partialSpec, string accessToken = null);
		/// <summary>Get a list of spec product assignments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption<Txp>> CreateOptionAsync<Txp>(string specID, SpecOption specOption, string accessToken = null);
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecOption>> ListOptionsAsync(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spec options.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecOption<Txp>>> ListOptionsAsync<Txp>(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecOption>> ListOptionsAsync(string specID, Action<ListOptionsBuilder<SpecOption>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of spec options.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpecOption<Txp>>> ListOptionsAsync<Txp>(string specID, Action<ListOptionsBuilder<SpecOption<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create or update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> SaveOptionAsync(string specID, string optionID, SpecOption specOption, string accessToken = null);
		/// <summary>Create or update a spec option.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="specOption">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption<Txp>> SaveOptionAsync<Txp>(string specID, string optionID, SpecOption specOption, string accessToken = null);
		/// <summary>Partially update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="partialSpecOption">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> PatchOptionAsync(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null);
		/// <summary>Partially update a spec option.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="partialSpecOption">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption<Txp>> PatchOptionAsync<Txp>(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null);
		/// <summary>Get a single spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption> GetOptionAsync(string specID, string optionID, string accessToken = null);
		/// <summary>Get a single spec option.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpecOption<Txp>> GetOptionAsync<Txp>(string specID, string optionID, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount<Txp>> GetAsync<Txp>(string buyerID, string spendingAccountID, string accessToken = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount>> ListAsync(string buyerID, Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<SpendingAccount<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<SpendingAccount<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new spending account. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> CreateAsync(string buyerID, SpendingAccount spendingAccount, string accessToken = null);
		/// <summary>Create a new spending account. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount<Txp>> CreateAsync<Txp>(string buyerID, SpendingAccount spendingAccount, string accessToken = null);
		/// <summary>Create or update a spending account. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount> SaveAsync(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null);
		/// <summary>Create or update a spending account. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="spendingAccount">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount<Txp>> SaveAsync<Txp>(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="partialSpendingAccount">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<SpendingAccount<Txp>> PatchAsync<Txp>(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null);
		/// <summary>Get a list of spending account assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the spending account assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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

	public interface ISuppliersResource
	{
		/// <summary>Get a single supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> GetAsync(string supplierID, string accessToken = null);
		/// <summary>Get a single supplier.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier<Txp>> GetAsync<Txp>(string supplierID, string accessToken = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier>> ListAsync(Action<ListOptionsBuilder<Supplier>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<Supplier<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Supplier<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new supplier. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> CreateAsync(Supplier supplier, string accessToken = null);
		/// <summary>Create a new supplier. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier<Txp>> CreateAsync<Txp>(Supplier supplier, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="supplier">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier<Txp>> SaveAsync<Txp>(string supplierID, Supplier supplier, string accessToken = null);
		/// <summary>Partially update a supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="partialSupplier">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier> PatchAsync(string supplierID, PartialSupplier partialSupplier, string accessToken = null);
		/// <summary>Partially update a supplier.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="partialSupplier">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<Supplier<Txp>> PatchAsync<Txp>(string supplierID, PartialSupplier partialSupplier, string accessToken = null);
	}

	public interface ISupplierUserGroupsResource
	{
		/// <summary>Get a single supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> GetAsync(string supplierID, string userGroupID, string accessToken = null);
		/// <summary>Get a single supplier user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> GetAsync<Txp>(string supplierID, string userGroupID, string accessToken = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string supplierID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string supplierID, Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new supplier user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> CreateAsync(string supplierID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create a new supplier user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> CreateAsync<Txp>(string supplierID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update a supplier user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> SaveAsync(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update a supplier user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> SaveAsync<Txp>(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> PatchAsync<Txp>(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null);
		/// <summary>Get a list of supplier user group user assignments.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> GetAsync<Txp>(string supplierID, string userID, string accessToken = null);
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string supplierID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null);
		/// <summary>Get a list of supplier users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string supplierID, Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string userGroupID = null, string accessToken = null);
		/// <summary>Create a new supplier user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> CreateAsync(string supplierID, User user, string accessToken = null);
		/// <summary>Create a new supplier user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> CreateAsync<Txp>(string supplierID, User user, string accessToken = null);
		/// <summary>Create or update a supplier user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> SaveAsync(string supplierID, string userID, User user, string accessToken = null);
		/// <summary>Create or update a supplier user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> SaveAsync<Txp>(string supplierID, string userID, User user, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> PatchAsync<Txp>(string supplierID, string userID, PartialUser partialUser, string accessToken = null);
		/// <summary>Get a single supplier user access token.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="impersonateTokenRequest">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<AccessToken> GetAccessTokenAsync(string supplierID, string userID, ImpersonateTokenRequest impersonateTokenRequest, string accessToken = null);
	}

	public interface IUserGroupsResource
	{
		/// <summary>Get a single user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> GetAsync(string buyerID, string userGroupID, string accessToken = null);
		/// <summary>Get a single user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> GetAsync<Txp>(string buyerID, string userGroupID, string accessToken = null);
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup>> ListAsync(string buyerID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null);
		/// <summary>Get a list of user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null);
		/// <summary>Create a new user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> CreateAsync(string buyerID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create a new user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> CreateAsync<Txp>(string buyerID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update a user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup> SaveAsync(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null);
		/// <summary>Create or update a user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userGroup">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> SaveAsync<Txp>(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null);
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="partialUserGroup">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<UserGroup<Txp>> PatchAsync<Txp>(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null);
		/// <summary>Get a list of user group user assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
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
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> GetAsync<Txp>(string buyerID, string userID, string accessToken = null);
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null);
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User>> ListAsync(string buyerID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null);
		/// <summary>Get a list of users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="buildListOpts">A lambda or function for specifying various list options fluently.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string userGroupID = null, string accessToken = null);
		/// <summary>Create a new user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> CreateAsync(string buyerID, User user, string accessToken = null);
		/// <summary>Create a new user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> CreateAsync<Txp>(string buyerID, User user, string accessToken = null);
		/// <summary>Create or update a user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> SaveAsync(string buyerID, string userID, User user, string accessToken = null);
		/// <summary>Create or update a user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="user">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> SaveAsync<Txp>(string buyerID, string userID, User user, string accessToken = null);
		/// <summary>Delete a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task DeleteAsync(string buyerID, string userID, string accessToken = null);
		/// <summary>Partially update a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> PatchAsync(string buyerID, string userID, PartialUser partialUser, string accessToken = null);
		/// <summary>Partially update a user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="partialUser">The object that will be partially serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> PatchAsync<Txp>(string buyerID, string userID, PartialUser partialUser, string accessToken = null);
		/// <summary>Move a user to a different buyer</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="newBuyerID">ID of the new buyer.</param>
		/// <param name="orders">Orders of the user. Possible values: None, Unsubmitted, All.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User> MoveAsync(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null);
		/// <summary>Move a user to a different buyer</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="newBuyerID">ID of the new buyer.</param>
		/// <param name="orders">Orders of the user. Possible values: None, Unsubmitted, All.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<User<Txp>> MoveAsync<Txp>(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null);
		/// <summary>Get a single user access token.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="impersonateTokenRequest">The object that will be serialized to JSON and sent in the request body.</param>
		/// <param name="accessToken">Optional. Use to provide an existing token instead of authenticating implicitly.</param>
		Task<AccessToken> GetAccessTokenAsync(string buyerID, string userID, ImpersonateTokenRequest impersonateTokenRequest, string accessToken = null);
	}

	public partial class OrderCloudClient : IOrderCloudClient
	{
		private void InitResources() {
			Addresses = new AddressesResource(this);
			AdminAddresses = new AdminAddressesResource(this);
			AdminUserGroups = new AdminUserGroupsResource(this);
			AdminUsers = new AdminUsersResource(this);
			ApprovalRules = new ApprovalRulesResource(this);
			Buyers = new BuyersResource(this);
			Catalogs = new CatalogsResource(this);
			Categories = new CategoriesResource(this);
			CostCenters = new CostCentersResource(this);
			CreditCards = new CreditCardsResource(this);
			ImpersonationConfigs = new ImpersonationConfigsResource(this);
			Incrementors = new IncrementorsResource(this);
			LineItems = new LineItemsResource(this);
			Me = new MeResource(this);
			MessageSenders = new MessageSendersResource(this);
			Orders = new OrdersResource(this);
			PasswordResets = new PasswordResetsResource(this);
			Payments = new PaymentsResource(this);
			PriceSchedules = new PriceSchedulesResource(this);
			Products = new ProductsResource(this);
			Promotions = new PromotionsResource(this);
			SecurityProfiles = new SecurityProfilesResource(this);
			Shipments = new ShipmentsResource(this);
			Specs = new SpecsResource(this);
			SpendingAccounts = new SpendingAccountsResource(this);
			Suppliers = new SuppliersResource(this);
			SupplierUserGroups = new SupplierUserGroupsResource(this);
			SupplierUsers = new SupplierUsersResource(this);
			UserGroups = new UserGroupsResource(this);
			Users = new UsersResource(this);
		}
		
		public IAddressesResource Addresses { get; private set; }
		public IAdminAddressesResource AdminAddresses { get; private set; }
		public IAdminUserGroupsResource AdminUserGroups { get; private set; }
		public IAdminUsersResource AdminUsers { get; private set; }
		public IApprovalRulesResource ApprovalRules { get; private set; }
		public IBuyersResource Buyers { get; private set; }
		public ICatalogsResource Catalogs { get; private set; }
		public ICategoriesResource Categories { get; private set; }
		public ICostCentersResource CostCenters { get; private set; }
		public ICreditCardsResource CreditCards { get; private set; }
		public IImpersonationConfigsResource ImpersonationConfigs { get; private set; }
		public IIncrementorsResource Incrementors { get; private set; }
		public ILineItemsResource LineItems { get; private set; }
		public IMeResource Me { get; private set; }
		public IMessageSendersResource MessageSenders { get; private set; }
		public IOrdersResource Orders { get; private set; }
		public IPasswordResetsResource PasswordResets { get; private set; }
		public IPaymentsResource Payments { get; private set; }
		public IPriceSchedulesResource PriceSchedules { get; private set; }
		public IProductsResource Products { get; private set; }
		public IPromotionsResource Promotions { get; private set; }
		public ISecurityProfilesResource SecurityProfiles { get; private set; }
		public IShipmentsResource Shipments { get; private set; }
		public ISpecsResource Specs { get; private set; }
		public ISpendingAccountsResource SpendingAccounts { get; private set; }
		public ISuppliersResource Suppliers { get; private set; }
		public ISupplierUserGroupsResource SupplierUserGroups { get; private set; }
		public ISupplierUsersResource SupplierUsers { get; private set; }
		public IUserGroupsResource UserGroups { get; private set; }
		public IUsersResource Users { get; private set; }
	}

	public class AddressesResource : OrderCloudResource, IAddressesResource
	{
		internal AddressesResource(OrderCloudClient client) : base(client) { }
		public Task<Address> GetAsync(string buyerID, string addressID, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<Address>();
		public Task<Address<Txp>> GetAsync<Txp>(string buyerID, string addressID, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<Address<Txp>>();
		public Task<ListPage<Address>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address>>();
		public Task<ListPage<Address<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address<Txp>>>();
		public Task<ListPage<Address>> ListAsync(string buyerID, Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Address>>();
		public Task<ListPage<Address<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<Address<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Address<Txp>>>();
		public Task<Address> CreateAsync(string buyerID, Address address, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> CreateAsync<Txp>(string buyerID, Address address, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task<Address> SaveAsync(string buyerID, string addressID, Address address, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> SaveAsync<Txp>(string buyerID, string addressID, Address address, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task DeleteAsync(string buyerID, string addressID, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Address> PatchAsync(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address>();
		public Task<Address<Txp>> PatchAsync<Txp>(string buyerID, string addressID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address<Txp>>();
		public Task<ListPage<AddressAssignment>> ListAssignmentsAsync(string buyerID, string addressID = null, string userID = null, string userGroupID = null, PartyType? level = null, bool? isShipping = null, bool? isBilling = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { addressID, userID, userGroupID, level, isShipping, isBilling, page, pageSize }).GetJsonAsync<ListPage<AddressAssignment>>();
		public Task DeleteAssignmentAsync(string buyerID, string addressID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", addressID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string buyerID, AddressAssignment addressAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "addresses", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(addressAssignment));
	}

	public class AdminAddressesResource : OrderCloudResource, IAdminAddressesResource
	{
		internal AdminAddressesResource(OrderCloudClient client) : base(client) { }
		public Task<Address> GetAsync(string addressID, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<Address>();
		public Task<Address<Txp>> GetAsync<Txp>(string addressID, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<Address<Txp>>();
		public Task<ListPage<Address>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address>>();
		public Task<ListPage<Address<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address<Txp>>>();
		public Task<ListPage<Address>> ListAsync(Action<ListOptionsBuilder<Address>> buildListOpts, string accessToken = null) => Request("v1", "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Address>>();
		public Task<ListPage<Address<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Address<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Address<Txp>>>();
		public Task<Address> CreateAsync(Address address, string accessToken = null) => Request("v1", "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> CreateAsync<Txp>(Address address, string accessToken = null) => Request("v1", "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task<Address> SaveAsync(string addressID, Address address, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> SaveAsync<Txp>(string addressID, Address address, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task DeleteAsync(string addressID, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Address> PatchAsync(string addressID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address>();
		public Task<Address<Txp>> PatchAsync<Txp>(string addressID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address<Txp>>();
	}

	public class AdminUserGroupsResource : OrderCloudResource, IAdminUserGroupsResource
	{
		internal AdminUserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string userGroupID, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<UserGroup>();
		public Task<UserGroup<Txp>> GetAsync<Txp>(string userGroupID, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<UserGroup<Txp>>();
		public Task<ListPage<UserGroup>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<ListPage<UserGroup>> ListAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<UserGroup> CreateAsync(UserGroup userGroup, string accessToken = null) => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> CreateAsync<Txp>(UserGroup userGroup, string accessToken = null) => Request("v1", "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<UserGroup> SaveAsync(string userGroupID, UserGroup userGroup, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> SaveAsync<Txp>(string userGroupID, UserGroup userGroup, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task DeleteAsync(string userGroupID, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<UserGroup> PatchAsync(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> PatchAsync<Txp>(string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => Request("v1", "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "usergroups", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string userGroupID, string userID, string accessToken = null) => Request("v1", "usergroups", userGroupID, "assignments", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveUserAssignmentAsync(UserGroupAssignment userGroupAssignment, string accessToken = null) => Request("v1", "usergroups", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class AdminUsersResource : OrderCloudResource, IAdminUsersResource
	{
		internal AdminUsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string userID, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<User>();
		public Task<User<Txp>> GetAsync<Txp>(string userID, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<User<Txp>>();
		public Task<ListPage<User>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<ListPage<User>> ListAsync(Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null) => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<User> CreateAsync(User user, string accessToken = null) => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> CreateAsync<Txp>(User user, string accessToken = null) => Request("v1", "adminusers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task<User> SaveAsync(string userID, User user, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> SaveAsync<Txp>(string userID, User user, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task DeleteAsync(string userID, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<User> PatchAsync(string userID, PartialUser partialUser, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User>();
		public Task<User<Txp>> PatchAsync<Txp>(string userID, PartialUser partialUser, string accessToken = null) => Request("v1", "adminusers", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User<Txp>>();
	}

	public class ApprovalRulesResource : OrderCloudResource, IApprovalRulesResource
	{
		internal ApprovalRulesResource(OrderCloudClient client) : base(client) { }
		public Task<ApprovalRule> GetAsync(string buyerID, string approvalRuleID, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).GetJsonAsync<ApprovalRule>();
		public Task<ApprovalRule<Txp>> GetAsync<Txp>(string buyerID, string approvalRuleID, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).GetJsonAsync<ApprovalRule<Txp>>();
		public Task<ListPage<ApprovalRule>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ApprovalRule>>();
		public Task<ListPage<ApprovalRule<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ApprovalRule<Txp>>>();
		public Task<ListPage<ApprovalRule>> ListAsync(string buyerID, Action<ListOptionsBuilder<ApprovalRule>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ApprovalRule>>();
		public Task<ListPage<ApprovalRule<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<ApprovalRule<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ApprovalRule<Txp>>>();
		public Task<ApprovalRule> CreateAsync(string buyerID, ApprovalRule approvalRule, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule>();
		public Task<ApprovalRule<Txp>> CreateAsync<Txp>(string buyerID, ApprovalRule approvalRule, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule<Txp>>();
		public Task<ApprovalRule> SaveAsync(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule>();
		public Task<ApprovalRule<Txp>> SaveAsync<Txp>(string buyerID, string approvalRuleID, ApprovalRule approvalRule, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule<Txp>>();
		public Task DeleteAsync(string buyerID, string approvalRuleID, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ApprovalRule> PatchAsync(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialApprovalRule)).ReceiveJson<ApprovalRule>();
		public Task<ApprovalRule<Txp>> PatchAsync<Txp>(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule, string accessToken = null) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialApprovalRule)).ReceiveJson<ApprovalRule<Txp>>();
	}

	public class BuyersResource : OrderCloudResource, IBuyersResource
	{
		internal BuyersResource(OrderCloudClient client) : base(client) { }
		public Task<Buyer> GetAsync(string buyerID, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).GetJsonAsync<Buyer>();
		public Task<Buyer<Txp>> GetAsync<Txp>(string buyerID, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).GetJsonAsync<Buyer<Txp>>();
		public Task<ListPage<Buyer>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Buyer>>();
		public Task<ListPage<Buyer<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Buyer<Txp>>>();
		public Task<ListPage<Buyer>> ListAsync(Action<ListOptionsBuilder<Buyer>> buildListOpts, string accessToken = null) => Request("v1", "buyers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Buyer>>();
		public Task<ListPage<Buyer<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Buyer<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Buyer<Txp>>>();
		public Task<Buyer> CreateAsync(Buyer buyer, string accessToken = null) => Request("v1", "buyers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer>();
		public Task<Buyer<Txp>> CreateAsync<Txp>(Buyer buyer, string accessToken = null) => Request("v1", "buyers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer<Txp>>();
		public Task DeleteAsync(string buyerID, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Buyer> SaveAsync(string buyerID, Buyer buyer, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer>();
		public Task<Buyer<Txp>> SaveAsync<Txp>(string buyerID, Buyer buyer, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer<Txp>>();
		public Task<Buyer> PatchAsync(string buyerID, PartialBuyer partialBuyer, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyer)).ReceiveJson<Buyer>();
		public Task<Buyer<Txp>> PatchAsync<Txp>(string buyerID, PartialBuyer partialBuyer, string accessToken = null) => Request("v1", "buyers", buyerID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyer)).ReceiveJson<Buyer<Txp>>();
	}

	public class CatalogsResource : OrderCloudResource, ICatalogsResource
	{
		internal CatalogsResource(OrderCloudClient client) : base(client) { }
		public Task<Catalog> GetAsync(string catalogID, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).GetJsonAsync<Catalog>();
		public Task<Catalog<Txp>> GetAsync<Txp>(string catalogID, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).GetJsonAsync<Catalog<Txp>>();
		public Task<ListPage<Catalog>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog>>();
		public Task<ListPage<Catalog<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog<Txp>>>();
		public Task<ListPage<Catalog>> ListAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string accessToken = null) => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Catalog>>();
		public Task<ListPage<Catalog<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Catalog<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Catalog<Txp>>>();
		public Task<Catalog> CreateAsync(Catalog catalog, string accessToken = null) => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog>();
		public Task<Catalog<Txp>> CreateAsync<Txp>(Catalog catalog, string accessToken = null) => Request("v1", "catalogs").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog<Txp>>();
		public Task<Catalog> SaveAsync(string catalogID, Catalog catalog, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog>();
		public Task<Catalog<Txp>> SaveAsync<Txp>(string catalogID, Catalog catalog, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog<Txp>>();
		public Task DeleteAsync(string catalogID, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Catalog> PatchAsync(string catalogID, PartialCatalog partialCatalog, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCatalog)).ReceiveJson<Catalog>();
		public Task<Catalog<Txp>> PatchAsync<Txp>(string catalogID, PartialCatalog partialCatalog, string accessToken = null) => Request("v1", "catalogs", catalogID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCatalog)).ReceiveJson<Catalog<Txp>>();
		public Task<ListPage<CatalogAssignment>> ListAssignmentsAsync(string catalogID = null, string buyerID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, buyerID, page, pageSize }).GetJsonAsync<ListPage<CatalogAssignment>>();
		public Task SaveAssignmentAsync(CatalogAssignment catalogAssignment, string accessToken = null) => Request("v1", "catalogs", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(catalogAssignment));
		public Task DeleteAssignmentAsync(string catalogID, string buyerID, string accessToken = null) => Request("v1", "catalogs", catalogID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID }).DeleteAsync();
		public Task<ListPage<ProductCatalogAssignment>> ListProductAssignmentsAsync(string catalogID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, productID, page, pageSize }).GetJsonAsync<ListPage<ProductCatalogAssignment>>();
		public Task SaveProductAssignmentAsync(ProductCatalogAssignment productCatalogAssignment, string accessToken = null) => Request("v1", "catalogs", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productCatalogAssignment));
		public Task DeleteProductAssignmentAsync(string catalogID, string productID, string accessToken = null) => Request("v1", "catalogs", catalogID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class CategoriesResource : OrderCloudResource, ICategoriesResource
	{
		internal CategoriesResource(OrderCloudClient client) : base(client) { }
		public Task<Category> GetAsync(string catalogID, string categoryID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).GetJsonAsync<Category>();
		public Task<Category<Txp>> GetAsync<Txp>(string catalogID, string categoryID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).GetJsonAsync<Category<Txp>>();
		public Task<ListPage<Category>> ListAsync(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category>>();
		public Task<ListPage<Category<Txp>>> ListAsync<Txp>(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category<Txp>>>();
		public Task<ListPage<Category>> ListAsync(string catalogID, Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string accessToken = null) => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Category>>();
		public Task<ListPage<Category<Txp>>> ListAsync<Txp>(string catalogID, Action<ListOptionsBuilder<Category<Txp>>> buildListOpts, string depth = "1", string accessToken = null) => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Category<Txp>>>();
		public Task<Category> CreateAsync(string catalogID, Category category, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(category)).ReceiveJson<Category>();
		public Task<Category<Txp>> CreateAsync<Txp>(string catalogID, Category category, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(category)).ReceiveJson<Category<Txp>>();
		public Task<Category> SaveAsync(string catalogID, string categoryID, Category category, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(category)).ReceiveJson<Category>();
		public Task<Category<Txp>> SaveAsync<Txp>(string catalogID, string categoryID, Category category, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(category)).ReceiveJson<Category<Txp>>();
		public Task DeleteAsync(string catalogID, string categoryID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Category> PatchAsync(string catalogID, string categoryID, PartialCategory partialCategory, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCategory)).ReceiveJson<Category>();
		public Task<Category<Txp>> PatchAsync<Txp>(string catalogID, string categoryID, PartialCategory partialCategory, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCategory)).ReceiveJson<Category<Txp>>();
		public Task<ListPage<CategoryAssignment>> ListAssignmentsAsync(string catalogID, string categoryID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { categoryID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CategoryAssignment>>();
		public Task DeleteAssignmentAsync(string catalogID, string categoryID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string catalogID, CategoryAssignment categoryAssignment, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(categoryAssignment));
		public Task<ListPage<CategoryProductAssignment>> ListProductAssignmentsAsync(string catalogID, string categoryID = null, string productID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { categoryID, productID, page, pageSize }).GetJsonAsync<ListPage<CategoryProductAssignment>>();
		public Task SaveProductAssignmentAsync(string catalogID, CategoryProductAssignment categoryProductAssignment, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(categoryProductAssignment));
		public Task DeleteProductAssignmentAsync(string catalogID, string categoryID, string productID, string accessToken = null) => Request("v1", "catalogs", catalogID, "categories", categoryID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class CostCentersResource : OrderCloudResource, ICostCentersResource
	{
		internal CostCentersResource(OrderCloudClient client) : base(client) { }
		public Task<CostCenter> GetAsync(string buyerID, string costCenterID, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).GetJsonAsync<CostCenter>();
		public Task<CostCenter<Txp>> GetAsync<Txp>(string buyerID, string costCenterID, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).GetJsonAsync<CostCenter<Txp>>();
		public Task<ListPage<CostCenter>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter>>();
		public Task<ListPage<CostCenter<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter<Txp>>>();
		public Task<ListPage<CostCenter>> ListAsync(string buyerID, Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<CostCenter>>();
		public Task<ListPage<CostCenter<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<CostCenter<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<CostCenter<Txp>>>();
		public Task<CostCenter> CreateAsync(string buyerID, CostCenter costCenter, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter>();
		public Task<CostCenter<Txp>> CreateAsync<Txp>(string buyerID, CostCenter costCenter, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter<Txp>>();
		public Task<CostCenter> SaveAsync(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter>();
		public Task<CostCenter<Txp>> SaveAsync<Txp>(string buyerID, string costCenterID, CostCenter costCenter, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter<Txp>>();
		public Task DeleteAsync(string buyerID, string costCenterID, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<CostCenter> PatchAsync(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCostCenter)).ReceiveJson<CostCenter>();
		public Task<CostCenter<Txp>> PatchAsync<Txp>(string buyerID, string costCenterID, PartialCostCenter partialCostCenter, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCostCenter)).ReceiveJson<CostCenter<Txp>>();
		public Task<ListPage<CostCenterAssignment>> ListAssignmentsAsync(string buyerID, string costCenterID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { costCenterID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CostCenterAssignment>>();
		public Task DeleteAssignmentAsync(string buyerID, string costCenterID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string buyerID, CostCenterAssignment costCenterAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "costcenters", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(costCenterAssignment));
	}

	public class CreditCardsResource : OrderCloudResource, ICreditCardsResource
	{
		internal CreditCardsResource(OrderCloudClient client) : base(client) { }
		public Task<CreditCard> GetAsync(string buyerID, string creditCardID, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).GetJsonAsync<CreditCard>();
		public Task<CreditCard<Txp>> GetAsync<Txp>(string buyerID, string creditCardID, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).GetJsonAsync<CreditCard<Txp>>();
		public Task<ListPage<CreditCard>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CreditCard>>();
		public Task<ListPage<CreditCard<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CreditCard<Txp>>>();
		public Task<ListPage<CreditCard>> ListAsync(string buyerID, Action<ListOptionsBuilder<CreditCard>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<CreditCard>>();
		public Task<ListPage<CreditCard<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<CreditCard<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<CreditCard<Txp>>>();
		public Task<CreditCard> CreateAsync(string buyerID, CreditCard creditCard, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard>();
		public Task<CreditCard<Txp>> CreateAsync<Txp>(string buyerID, CreditCard creditCard, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard<Txp>>();
		public Task<CreditCard> SaveAsync(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard>();
		public Task<CreditCard<Txp>> SaveAsync<Txp>(string buyerID, string creditCardID, CreditCard creditCard, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard<Txp>>();
		public Task DeleteAsync(string buyerID, string creditCardID, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<CreditCard> PatchAsync(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCreditCard)).ReceiveJson<CreditCard>();
		public Task<CreditCard<Txp>> PatchAsync<Txp>(string buyerID, string creditCardID, PartialCreditCard partialCreditCard, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialCreditCard)).ReceiveJson<CreditCard<Txp>>();
		public Task<ListPage<CreditCardAssignment>> ListAssignmentsAsync(string buyerID, string creditCardID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { creditCardID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CreditCardAssignment>>();
		public Task SaveAssignmentAsync(string buyerID, CreditCardAssignment creditCardAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(creditCardAssignment));
		public Task DeleteAssignmentAsync(string buyerID, string creditCardID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
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

	public class LineItemsResource : OrderCloudResource, ILineItemsResource
	{
		internal LineItemsResource(OrderCloudClient client) : base(client) { }
		public Task<LineItem> GetAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<LineItem>();
		public Task<LineItem<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<LineItem<Txp>>();
		public Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<LineItem>>();
		public Task<ListPage<LineItem<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<LineItem<Txp>>>();
		public Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<LineItem>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<LineItem>>();
		public Task<ListPage<LineItem<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<LineItem<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<LineItem<Txp>>>();
		public Task<LineItem> CreateAsync(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, LineItem lineItem, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem<Txp>>();
		public Task<LineItem> SaveAsync(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem<Txp>>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string lineItemID, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<LineItem> PatchAsync(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<LineItem<Txp>>();
		public Task<LineItem> SetShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, Address address, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<LineItem<Txp>>();
		public Task<LineItem> PatchShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<LineItem<Txp>>();
	}

	public class MeResource : OrderCloudResource, IMeResource
	{
		internal MeResource(OrderCloudClient client) : base(client) { }
		public Task<MeUser> GetAsync(string accessToken = null) => Request("v1", "me").WithOAuthBearerToken(accessToken).GetJsonAsync<MeUser>();
		public Task<MeUser<Txp>> GetAsync<Txp>(string accessToken = null) => Request("v1", "me").WithOAuthBearerToken(accessToken).GetJsonAsync<MeUser<Txp>>();
		public Task<MeUser> SaveAsync(MeUser meUser, string accessToken = null) => Request("v1", "me").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(meUser)).ReceiveJson<MeUser>();
		public Task<MeUser<Txp>> SaveAsync<Txp>(MeUser meUser, string accessToken = null) => Request("v1", "me").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(meUser)).ReceiveJson<MeUser<Txp>>();
		public Task<MeUser> PatchAsync(PartialMeUser partialMeUser, string accessToken = null) => Request("v1", "me").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialMeUser)).ReceiveJson<MeUser>();
		public Task<MeUser<Txp>> PatchAsync<Txp>(PartialMeUser partialMeUser, string accessToken = null) => Request("v1", "me").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialMeUser)).ReceiveJson<MeUser<Txp>>();
		public Task<ListPage<CostCenter>> ListCostCentersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "costcenters").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter>>();
		public Task<ListPage<CostCenter<Txp>>> ListCostCentersAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "costcenters").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter<Txp>>>();
		public Task<ListPage<CostCenter>> ListCostCentersAsync(Action<ListOptionsBuilder<CostCenter>> buildListOpts, string accessToken = null) => Request("v1", "me", "costcenters").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<CostCenter>>();
		public Task<ListPage<CostCenter<Txp>>> ListCostCentersAsync<Txp>(Action<ListOptionsBuilder<CostCenter<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "costcenters").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<CostCenter<Txp>>>();
		public Task<ListPage<UserGroup>> ListUserGroupsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListUserGroupsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<ListPage<UserGroup>> ListUserGroupsAsync(Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => Request("v1", "me", "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListUserGroupsAsync<Txp>(Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<ListPage<BuyerAddress>> ListAddressesAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerAddress>>();
		public Task<ListPage<BuyerAddress<Txp>>> ListAddressesAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerAddress<Txp>>>();
		public Task<ListPage<BuyerAddress>> ListAddressesAsync(Action<ListOptionsBuilder<BuyerAddress>> buildListOpts, string accessToken = null) => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerAddress>>();
		public Task<ListPage<BuyerAddress<Txp>>> ListAddressesAsync<Txp>(Action<ListOptionsBuilder<BuyerAddress<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerAddress<Txp>>>();
		public Task<BuyerAddress> CreateAddressAsync(BuyerAddress buyerAddress, string accessToken = null) => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress>();
		public Task<BuyerAddress<Txp>> CreateAddressAsync<Txp>(BuyerAddress buyerAddress, string accessToken = null) => Request("v1", "me", "addresses").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress<Txp>>();
		public Task<BuyerAddress> GetAddressAsync(string addressID, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<BuyerAddress>();
		public Task<BuyerAddress<Txp>> GetAddressAsync<Txp>(string addressID, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).GetJsonAsync<BuyerAddress<Txp>>();
		public Task<BuyerAddress> SaveAddressAsync(string addressID, BuyerAddress buyerAddress, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress>();
		public Task<BuyerAddress<Txp>> SaveAddressAsync<Txp>(string addressID, BuyerAddress buyerAddress, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress<Txp>>();
		public Task PatchAddressAsync(string addressID, PartialBuyerAddress partialBuyerAddress, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyerAddress));
		public Task DeleteAddressAsync(string addressID, string accessToken = null) => Request("v1", "me", "addresses", addressID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<BuyerCreditCard> CreateCreditCardAsync(BuyerCreditCard buyerCreditCard, string accessToken = null) => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard>();
		public Task<BuyerCreditCard<Txp>> CreateCreditCardAsync<Txp>(BuyerCreditCard buyerCreditCard, string accessToken = null) => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard<Txp>>();
		public Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerCreditCard>>();
		public Task<ListPage<BuyerCreditCard<Txp>>> ListCreditCardsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerCreditCard<Txp>>>();
		public Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(Action<ListOptionsBuilder<BuyerCreditCard>> buildListOpts, string accessToken = null) => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerCreditCard>>();
		public Task<ListPage<BuyerCreditCard<Txp>>> ListCreditCardsAsync<Txp>(Action<ListOptionsBuilder<BuyerCreditCard<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "creditcards").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerCreditCard<Txp>>>();
		public Task<BuyerCreditCard> GetCreditCardAsync(string creditcardID, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).GetJsonAsync<BuyerCreditCard>();
		public Task<BuyerCreditCard<Txp>> GetCreditCardAsync<Txp>(string creditcardID, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).GetJsonAsync<BuyerCreditCard<Txp>>();
		public Task<BuyerCreditCard> SaveCreditCardAsync(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard>();
		public Task<BuyerCreditCard<Txp>> SaveCreditCardAsync<Txp>(string creditcardID, BuyerCreditCard buyerCreditCard, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard<Txp>>();
		public Task PatchCreditCardAsync(string creditcardID, PartialBuyerCreditCard partialBuyerCreditCard, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialBuyerCreditCard));
		public Task DeleteCreditCardAsync(string creditcardID, string accessToken = null) => Request("v1", "me", "creditcards", creditcardID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<Category>> ListCategoriesAsync(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, catalogID, productID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category>>();
		public Task<ListPage<Category<Txp>>> ListCategoriesAsync<Txp>(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, catalogID, productID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category<Txp>>>();
		public Task<ListPage<Category>> ListCategoriesAsync(Action<ListOptionsBuilder<Category>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null) => Request("v1", "me", "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, catalogID, productID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Category>>();
		public Task<ListPage<Category<Txp>>> ListCategoriesAsync<Txp>(Action<ListOptionsBuilder<Category<Txp>>> buildListOpts, string depth = "1", string catalogID = null, string productID = null, string accessToken = null) => Request("v1", "me", "categories").WithOAuthBearerToken(accessToken).SetQueryParams(new { depth, catalogID, productID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Category<Txp>>>();
		public Task<Category> GetCategoryAsync(string categoryID, string catalogID, string accessToken = null) => Request("v1", "me", "categories", categoryID).WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).GetJsonAsync<Category>();
		public Task<Category<Txp>> GetCategoryAsync<Txp>(string categoryID, string catalogID, string accessToken = null) => Request("v1", "me", "categories", categoryID).WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).GetJsonAsync<Category<Txp>>();
		public Task<ListPage<BuyerProduct>> ListProductsAsync(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerProduct>>();
		public Task<ListPage<BuyerProduct<Txp>>> ListProductsAsync<Txp>(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerProduct<Txp>>>();
		public Task<ListPage<BuyerProduct>> ListProductsAsync(Action<ListOptionsBuilder<BuyerProduct>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string accessToken = null) => Request("v1", "me", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, depth }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerProduct>>();
		public Task<ListPage<BuyerProduct<Txp>>> ListProductsAsync<Txp>(Action<ListOptionsBuilder<BuyerProduct<Txp>>> buildListOpts, string catalogID = null, string categoryID = null, string depth = null, string accessToken = null) => Request("v1", "me", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, depth }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerProduct<Txp>>>();
		public Task<BuyerProduct> GetProductAsync(string productID, string accessToken = null) => Request("v1", "me", "products", productID).WithOAuthBearerToken(accessToken).GetJsonAsync<BuyerProduct>();
		public Task<BuyerProduct<Txp>> GetProductAsync<Txp>(string productID, string accessToken = null) => Request("v1", "me", "products", productID).WithOAuthBearerToken(accessToken).GetJsonAsync<BuyerProduct<Txp>>();
		public Task<ListPage<BuyerSpec>> ListSpecsAsync(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerSpec>>();
		public Task<ListPage<BuyerSpec<Txp>>> ListSpecsAsync<Txp>(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerSpec<Txp>>>();
		public Task<ListPage<BuyerSpec>> ListSpecsAsync(string productID, Action<ListOptionsBuilder<BuyerSpec>> buildListOpts, string catalogID = null, string accessToken = null) => Request("v1", "me", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerSpec>>();
		public Task<ListPage<BuyerSpec<Txp>>> ListSpecsAsync<Txp>(string productID, Action<ListOptionsBuilder<BuyerSpec<Txp>>> buildListOpts, string catalogID = null, string accessToken = null) => Request("v1", "me", "products", productID, "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<BuyerSpec<Txp>>>();
		public Task<BuyerSpec> GetSpecAsync(string productID, string specID, string catalogID = null, string accessToken = null) => Request("v1", "me", "products", productID, "specs", specID).WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).GetJsonAsync<BuyerSpec>();
		public Task<BuyerSpec<Txp>> GetSpecAsync<Txp>(string productID, string specID, string catalogID = null, string accessToken = null) => Request("v1", "me", "products", productID, "specs", specID).WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID }).GetJsonAsync<BuyerSpec<Txp>>();
		public Task<ListPage<Order>> ListOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Order>> ListOrdersAsync(Action<ListOptionsBuilder<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListOrdersAsync<Txp>(Action<ListOptionsBuilder<Order<Txp>>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Order>> ListApprovableOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "orders", "approvable").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListApprovableOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "orders", "approvable").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Order>> ListApprovableOrdersAsync(Action<ListOptionsBuilder<Order>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => Request("v1", "me", "orders", "approvable").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListApprovableOrdersAsync<Txp>(Action<ListOptionsBuilder<Order<Txp>>> buildListOpts, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => Request("v1", "me", "orders", "approvable").WithOAuthBearerToken(accessToken).SetQueryParams(new { from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Promotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion>>();
		public Task<ListPage<Promotion<Txp>>> ListPromotionsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion<Txp>>>();
		public Task<ListPage<Promotion>> ListPromotionsAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null) => Request("v1", "me", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Promotion>>();
		public Task<ListPage<Promotion<Txp>>> ListPromotionsAsync<Txp>(Action<ListOptionsBuilder<Promotion<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Promotion<Txp>>>();
		public Task<Promotion> GetPromotionAsync(string promotionID, string accessToken = null) => Request("v1", "me", "promotions", promotionID).WithOAuthBearerToken(accessToken).GetJsonAsync<Promotion>();
		public Task<Promotion<Txp>> GetPromotionAsync<Txp>(string promotionID, string accessToken = null) => Request("v1", "me", "promotions", promotionID).WithOAuthBearerToken(accessToken).GetJsonAsync<Promotion<Txp>>();
		public Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "spendingAccounts").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount>>();
		public Task<ListPage<SpendingAccount<Txp>>> ListSpendingAccountsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "spendingAccounts").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount<Txp>>>();
		public Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null) => Request("v1", "me", "spendingAccounts").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpendingAccount>>();
		public Task<ListPage<SpendingAccount<Txp>>> ListSpendingAccountsAsync<Txp>(Action<ListOptionsBuilder<SpendingAccount<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "spendingAccounts").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpendingAccount<Txp>>>();
		public Task<SpendingAccount> GetSpendingAccountAsync(string spendingAccountID, string accessToken = null) => Request("v1", "me", "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).GetJsonAsync<SpendingAccount>();
		public Task<SpendingAccount<Txp>> GetSpendingAccountAsync<Txp>(string spendingAccountID, string accessToken = null) => Request("v1", "me", "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).GetJsonAsync<SpendingAccount<Txp>>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment>>();
		public Task<ListPage<Shipment<Txp>>> ListShipmentsAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment<Txp>>>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null) => Request("v1", "me", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Shipment>>();
		public Task<ListPage<Shipment<Txp>>> ListShipmentsAsync<Txp>(Action<ListOptionsBuilder<Shipment<Txp>>> buildListOpts, string orderID = null, string accessToken = null) => Request("v1", "me", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Shipment<Txp>>>();
		public Task<Shipment> GetShipmentAsync(string shipmentID, string accessToken = null) => Request("v1", "me", "shipments", shipmentID).WithOAuthBearerToken(accessToken).GetJsonAsync<Shipment>();
		public Task<Shipment<Txp>> GetShipmentAsync<Txp>(string shipmentID, string accessToken = null) => Request("v1", "me", "shipments", shipmentID).WithOAuthBearerToken(accessToken).GetJsonAsync<Shipment<Txp>>();
		public Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem>>();
		public Task<ListPage<ShipmentItem<Txp>>> ListShipmentItemsAsync<Txp>(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem<Txp>>>();
		public Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string orderID = null, string accessToken = null) => Request("v1", "me", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ShipmentItem>>();
		public Task<ListPage<ShipmentItem<Txp>>> ListShipmentItemsAsync<Txp>(string shipmentID, Action<ListOptionsBuilder<ShipmentItem<Txp>>> buildListOpts, string orderID = null, string accessToken = null) => Request("v1", "me", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ShipmentItem<Txp>>>();
		public Task<dynamic> RegisterAsync(MeUser meUser, string anonUserToken, string accessToken = null) => Request("v1", "me", "register").WithOAuthBearerToken(accessToken).SetQueryParams(new { anonUserToken }).PutJsonAsync(ValidateModel(meUser)).ReceiveJson<object>();
		public Task TransferAnonUserOrderAsync(string anonUserToken, string accessToken = null) => Request("v1", "me", "orders").WithOAuthBearerToken(accessToken).SetQueryParams(new { anonUserToken }).PutAsync(null);
		public Task ResetPasswordByTokenAsync(TokenPasswordReset tokenPasswordReset, string accessToken = null) => Request("v1", "me", "password").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(tokenPasswordReset));
		public Task<ListPage<Catalog>> ListCatalogsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog>>();
		public Task<ListPage<Catalog<Txp>>> ListCatalogsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "me", "catalogs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog<Txp>>>();
		public Task<ListPage<Catalog>> ListCatalogsAsync(Action<ListOptionsBuilder<Catalog>> buildListOpts, string accessToken = null) => Request("v1", "me", "catalogs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Catalog>>();
		public Task<ListPage<Catalog<Txp>>> ListCatalogsAsync<Txp>(Action<ListOptionsBuilder<Catalog<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "me", "catalogs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Catalog<Txp>>>();
		public Task<Catalog> GetCatalogAsync(string catalogID, string accessToken = null) => Request("v1", "me", "catalogs", catalogID).WithOAuthBearerToken(accessToken).GetJsonAsync<Catalog>();
		public Task<Catalog<Txp>> GetCatalogAsync<Txp>(string catalogID, string accessToken = null) => Request("v1", "me", "catalogs", catalogID).WithOAuthBearerToken(accessToken).GetJsonAsync<Catalog<Txp>>();
	}

	public class MessageSendersResource : OrderCloudResource, IMessageSendersResource
	{
		internal MessageSendersResource(OrderCloudClient client) : base(client) { }
		public Task<MessageSender> GetAsync(string messageSenderID, string accessToken = null) => Request("v1", "messagesenders", messageSenderID).WithOAuthBearerToken(accessToken).GetJsonAsync<MessageSender>();
		public Task<ListPage<MessageSender>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "messagesenders").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<MessageSender>>();
		public Task<ListPage<MessageSender>> ListAsync(Action<ListOptionsBuilder<MessageSender>> buildListOpts, string accessToken = null) => Request("v1", "messagesenders").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<MessageSender>>();
		public Task<ListPage<MessageSenderAssignment>> ListAssignmentsAsync(string buyerID = null, string messageSenderID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "messagesenders", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, messageSenderID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<MessageSenderAssignment>>();
		public Task DeleteAssignmentAsync(string messageSenderID, string buyerID = null, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "messagesenders", messageSenderID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(MessageSenderAssignment messageSenderAssignment, string accessToken = null) => Request("v1", "messagesenders", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(messageSenderAssignment));
		public Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "messagesenders", "CCListenerAssignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<MessageCCListenerAssignment>>();
		public Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(Action<ListOptionsBuilder<MessageCCListenerAssignment>> buildListOpts, string accessToken = null) => Request("v1", "messagesenders", "CCListenerAssignments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<MessageCCListenerAssignment>>();
		public Task SaveCCListenerAssignmentAsync(MessageCCListenerAssignment messageCCListenerAssignment, string accessToken = null) => Request("v1", "messagesenders", "CCListenerAssignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(messageCCListenerAssignment));
	}

	public class OrdersResource : OrderCloudResource, IOrdersResource
	{
		internal OrdersResource(OrderCloudClient client) : base(client) { }
		public Task<Order> GetAsync(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).GetJsonAsync<Order>();
		public Task<Order<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).GetJsonAsync<Order<Txp>>();
		public Task<ListPage<Order>> ListAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListAsync<Txp>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Order>> ListAsync(OrderDirection direction, Action<ListOptionsBuilder<Order>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListAsync<Txp>(OrderDirection direction, Action<ListOptionsBuilder<Order<Txp>>> buildListOpts, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string accessToken = null) => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, from, to }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<Order> CreateAsync(OrderDirection direction, Order order, string accessToken = null) => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(order)).ReceiveJson<Order>();
		public Task<Order<Txp>> CreateAsync<Txp>(OrderDirection direction, Order order, string accessToken = null) => Request("v1", "orders", direction).WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(order)).ReceiveJson<Order<Txp>>();
		public Task<Order> SaveAsync(OrderDirection direction, string orderID, Order order, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(order)).ReceiveJson<Order>();
		public Task<Order<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, Order order, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(order)).ReceiveJson<Order<Txp>>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "approvals").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OrderApproval>>();
		public Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderApproval>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "approvals").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<OrderApproval>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListEligibleApproversAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<User>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListEligibleApproversAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "eligibleapprovers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<Order> PatchAsync(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOrder)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, PartialOrder partialOrder, string accessToken = null) => Request("v1", "orders", direction, orderID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialOrder)).ReceiveJson<Order<Txp>>();
		public Task<Order> SubmitAsync(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID, "submit").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<Order>();
		public Task<Order<Txp>> SubmitAsync<Txp>(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID, "submit").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<Order<Txp>>();
		public Task<Order> ApproveAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) => Request("v1", "orders", direction, orderID, "approve").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order>();
		public Task<Order<Txp>> ApproveAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) => Request("v1", "orders", direction, orderID, "approve").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order<Txp>>();
		public Task<Order> DeclineAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) => Request("v1", "orders", direction, orderID, "decline").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order>();
		public Task<Order<Txp>> DeclineAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo, string accessToken = null) => Request("v1", "orders", direction, orderID, "decline").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order<Txp>>();
		public Task<Order> CancelAsync(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID, "cancel").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<Order>();
		public Task<Order<Txp>> CancelAsync<Txp>(OrderDirection direction, string orderID, string accessToken = null) => Request("v1", "orders", direction, orderID, "cancel").WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<Order<Txp>>();
		public Task<Order> ShipAsync(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null) => Request("v1", "orders", direction, orderID, "ship").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Order>();
		public Task<Order<Txp>> ShipAsync<Txp>(OrderDirection direction, string orderID, Shipment shipment, string accessToken = null) => Request("v1", "orders", direction, orderID, "ship").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Order<Txp>>();
		public Task<Order> SetShippingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null) => Request("v1", "orders", direction, orderID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Order>();
		public Task<Order<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address, string accessToken = null) => Request("v1", "orders", direction, orderID, "shipto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Order<Txp>>();
		public Task<Order> PatchShippingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "orders", direction, orderID, "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "orders", direction, orderID, "shipto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order<Txp>>();
		public Task<Order> SetBillingAddressAsync(OrderDirection direction, string orderID, Address address, string accessToken = null) => Request("v1", "orders", direction, orderID, "billto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Order>();
		public Task<Order<Txp>> SetBillingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address, string accessToken = null) => Request("v1", "orders", direction, orderID, "billto").WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(address)).ReceiveJson<Order<Txp>>();
		public Task<Order> PatchBillingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "orders", direction, orderID, "billto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchBillingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress, string accessToken = null) => Request("v1", "orders", direction, orderID, "billto").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order<Txp>>();
		public Task<Order> PatchFromUserAsync(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null) => Request("v1", "orders", direction, orderID, "fromuser").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchFromUserAsync<Txp>(OrderDirection direction, string orderID, PartialUser partialUser, string accessToken = null) => Request("v1", "orders", direction, orderID, "fromuser").WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<Order<Txp>>();
		public Task<Promotion> AddPromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions", promoCode).WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> AddPromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions", promoCode).WithOAuthBearerToken(accessToken).PostAsync(null).ReceiveJson<Promotion<Txp>>();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OrderPromotion>>();
		public Task<ListPage<OrderPromotion<Txp>>> ListPromotionsAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OrderPromotion<Txp>>>();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderPromotion>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<OrderPromotion>>();
		public Task<ListPage<OrderPromotion<Txp>>> ListPromotionsAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<OrderPromotion<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<OrderPromotion<Txp>>>();
		public Task<Order> RemovePromotionAsync(OrderDirection direction, string orderID, string promoCode, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions", promoCode).WithOAuthBearerToken(accessToken).DeleteAsync().ReceiveJson<Order>();
		public Task<Order<Txp>> RemovePromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode, string accessToken = null) => Request("v1", "orders", direction, orderID, "promotions", promoCode).WithOAuthBearerToken(accessToken).DeleteAsync().ReceiveJson<Order<Txp>>();
	}

	public class PasswordResetsResource : OrderCloudResource, IPasswordResetsResource
	{
		internal PasswordResetsResource(OrderCloudClient client) : base(client) { }
		public Task SendVerificationCodeAsync(PasswordResetRequest passwordResetRequest, string accessToken = null) => Request("v1", "password", "reset").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(passwordResetRequest));
		public Task ResetPasswordByVerificationCodeAsync(string verificationCode, PasswordReset passwordReset, string accessToken = null) => Request("v1", "password", "reset", verificationCode).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(passwordReset));
	}

	public class PaymentsResource : OrderCloudResource, IPaymentsResource
	{
		internal PaymentsResource(OrderCloudClient client) : base(client) { }
		public Task<Payment> GetAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).GetJsonAsync<Payment>();
		public Task<Payment<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string paymentID, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).GetJsonAsync<Payment<Txp>>();
		public Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Payment>>();
		public Task<ListPage<Payment<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Payment<Txp>>>();
		public Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Payment>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Payment>>();
		public Task<ListPage<Payment<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, Action<ListOptionsBuilder<Payment<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Payment<Txp>>>();
		public Task<Payment> CreateAsync(OrderDirection direction, string orderID, Payment payment, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(payment)).ReceiveJson<Payment>();
		public Task<Payment<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, Payment payment, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(payment)).ReceiveJson<Payment<Txp>>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string paymentID, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Payment> PatchAsync(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPayment)).ReceiveJson<Payment>();
		public Task<Payment<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPayment)).ReceiveJson<Payment<Txp>>();
		public Task<Payment> CreateTransactionAsync(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(paymentTransaction)).ReceiveJson<Payment>();
		public Task<Payment<Txp>> CreateTransactionAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(paymentTransaction)).ReceiveJson<Payment<Txp>>();
		public Task DeleteTransactionAsync(OrderDirection direction, string orderID, string paymentID, string transactionID, string accessToken = null) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions", transactionID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class PriceSchedulesResource : OrderCloudResource, IPriceSchedulesResource
	{
		internal PriceSchedulesResource(OrderCloudClient client) : base(client) { }
		public Task<PriceSchedule> GetAsync(string priceScheduleID, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).GetJsonAsync<PriceSchedule>();
		public Task<PriceSchedule<Txp>> GetAsync<Txp>(string priceScheduleID, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).GetJsonAsync<PriceSchedule<Txp>>();
		public Task<ListPage<PriceSchedule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<PriceSchedule>>();
		public Task<ListPage<PriceSchedule<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<PriceSchedule<Txp>>>();
		public Task<ListPage<PriceSchedule>> ListAsync(Action<ListOptionsBuilder<PriceSchedule>> buildListOpts, string accessToken = null) => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<PriceSchedule>>();
		public Task<ListPage<PriceSchedule<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<PriceSchedule<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<PriceSchedule<Txp>>>();
		public Task<PriceSchedule> CreateAsync(PriceSchedule priceSchedule, string accessToken = null) => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> CreateAsync<Txp>(PriceSchedule priceSchedule, string accessToken = null) => Request("v1", "priceschedules").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule<Txp>>();
		public Task<PriceSchedule> SaveAsync(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> SaveAsync<Txp>(string priceScheduleID, PriceSchedule priceSchedule, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule<Txp>>();
		public Task DeleteAsync(string priceScheduleID, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<PriceSchedule> PatchAsync(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPriceSchedule)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> PatchAsync<Txp>(string priceScheduleID, PartialPriceSchedule partialPriceSchedule, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPriceSchedule)).ReceiveJson<PriceSchedule<Txp>>();
		public Task<PriceSchedule> SavePriceBreakAsync(string priceScheduleID, PriceBreak priceBreak, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(priceBreak)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> SavePriceBreakAsync<Txp>(string priceScheduleID, PriceBreak priceBreak, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(priceBreak)).ReceiveJson<PriceSchedule<Txp>>();
		public Task DeletePriceBreakAsync(string priceScheduleID, int quantity, string accessToken = null) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").WithOAuthBearerToken(accessToken).SetQueryParams(new { quantity }).DeleteAsync();
	}

	public class ProductsResource : OrderCloudResource, IProductsResource
	{
		internal ProductsResource(OrderCloudClient client) : base(client) { }
		public Task<Product> GetAsync(string productID, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).GetJsonAsync<Product>();
		public Task<Product<Txp>> GetAsync<Txp>(string productID, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).GetJsonAsync<Product<Txp>>();
		public Task<ListPage<Product>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Product>>();
		public Task<ListPage<Product<Txp>>> ListAsync<Txp>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Product<Txp>>>();
		public Task<ListPage<Product>> ListAsync(Action<ListOptionsBuilder<Product>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) => Request("v1", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Product>>();
		public Task<ListPage<Product<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Product<Txp>>> buildListOpts, string catalogID = null, string categoryID = null, string supplierID = null, string accessToken = null) => Request("v1", "products").WithOAuthBearerToken(accessToken).SetQueryParams(new { catalogID, categoryID, supplierID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Product<Txp>>>();
		public Task<Product> CreateAsync(Product product, string accessToken = null) => Request("v1", "products").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(product)).ReceiveJson<Product>();
		public Task<Product<Txp>> CreateAsync<Txp>(Product product, string accessToken = null) => Request("v1", "products").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(product)).ReceiveJson<Product<Txp>>();
		public Task<Product> SaveAsync(string productID, Product product, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(product)).ReceiveJson<Product>();
		public Task<Product<Txp>> SaveAsync<Txp>(string productID, Product product, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(product)).ReceiveJson<Product<Txp>>();
		public Task DeleteAsync(string productID, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Product> PatchAsync(string productID, PartialProduct partialProduct, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProduct)).ReceiveJson<Product>();
		public Task<Product<Txp>> PatchAsync<Txp>(string productID, PartialProduct partialProduct, string accessToken = null) => Request("v1", "products", productID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialProduct)).ReceiveJson<Product<Txp>>();
		public Task<Product> GenerateVariantsAsync(string productID, bool overwriteExisting = false, string accessToken = null) => Request("v1", "products", productID, "variants", "generate").WithOAuthBearerToken(accessToken).SetQueryParams(new { overwriteExisting }).PostAsync(null).ReceiveJson<Product>();
		public Task<Product<Txp>> GenerateVariantsAsync<Txp>(string productID, bool overwriteExisting = false, string accessToken = null) => Request("v1", "products", productID, "variants", "generate").WithOAuthBearerToken(accessToken).SetQueryParams(new { overwriteExisting }).PostAsync(null).ReceiveJson<Product<Txp>>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Variant>>();
		public Task<ListPage<Variant<Txp>>> ListVariantsAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Variant<Txp>>>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, Action<ListOptionsBuilder<Variant>> buildListOpts, string accessToken = null) => Request("v1", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Variant>>();
		public Task<ListPage<Variant<Txp>>> ListVariantsAsync<Txp>(string productID, Action<ListOptionsBuilder<Variant<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "products", productID, "variants").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Variant<Txp>>>();
		public Task<Variant> SaveVariantAsync(string productID, string variantID, Variant variant, string accessToken = null) => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(variant)).ReceiveJson<Variant>();
		public Task<Variant<Txp>> SaveVariantAsync<Txp>(string productID, string variantID, Variant variant, string accessToken = null) => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(variant)).ReceiveJson<Variant<Txp>>();
		public Task<Variant> PatchVariantAsync(string productID, string variantID, PartialVariant partialVariant, string accessToken = null) => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialVariant)).ReceiveJson<Variant>();
		public Task<Variant<Txp>> PatchVariantAsync<Txp>(string productID, string variantID, PartialVariant partialVariant, string accessToken = null) => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialVariant)).ReceiveJson<Variant<Txp>>();
		public Task<Variant> GetVariantAsync(string productID, string variantID, string accessToken = null) => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).GetJsonAsync<Variant>();
		public Task<Variant<Txp>> GetVariantAsync<Txp>(string productID, string variantID, string accessToken = null) => Request("v1", "products", productID, "variants", variantID).WithOAuthBearerToken(accessToken).GetJsonAsync<Variant<Txp>>();
		public Task<ListPage<Supplier>> ListSuppliersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "products", productID, "suppliers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier>>();
		public Task<ListPage<Supplier<Txp>>> ListSuppliersAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "products", productID, "suppliers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier<Txp>>>();
		public Task<ListPage<Supplier>> ListSuppliersAsync(string productID, Action<ListOptionsBuilder<Supplier>> buildListOpts, string accessToken = null) => Request("v1", "products", productID, "suppliers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Supplier>>();
		public Task<ListPage<Supplier<Txp>>> ListSuppliersAsync<Txp>(string productID, Action<ListOptionsBuilder<Supplier<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "products", productID, "suppliers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Supplier<Txp>>>();
		public Task SaveSupplierAsync(string productID, string supplierID, string accessToken = null) => Request("v1", "products", productID, "suppliers", supplierID).WithOAuthBearerToken(accessToken).PutAsync(null);
		public Task RemoveSupplierAsync(string productID, string supplierID, string accessToken = null) => Request("v1", "products", productID, "suppliers", supplierID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveAssignmentAsync(ProductAssignment productAssignment, string accessToken = null) => Request("v1", "products", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(productAssignment));
		public Task<ListPage<ProductAssignment>> ListAssignmentsAsync(string productID = null, string priceScheduleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "products", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { productID, priceScheduleID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<ProductAssignment>>();
		public Task DeleteAssignmentAsync(string productID, string buyerID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "products", productID, "assignments", buyerID).WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class PromotionsResource : OrderCloudResource, IPromotionsResource
	{
		internal PromotionsResource(OrderCloudClient client) : base(client) { }
		public Task<Promotion> GetAsync(string promotionID, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).GetJsonAsync<Promotion>();
		public Task<Promotion<Txp>> GetAsync<Txp>(string promotionID, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).GetJsonAsync<Promotion<Txp>>();
		public Task<ListPage<Promotion>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion>>();
		public Task<ListPage<Promotion<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "promotions").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion<Txp>>>();
		public Task<ListPage<Promotion>> ListAsync(Action<ListOptionsBuilder<Promotion>> buildListOpts, string accessToken = null) => Request("v1", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Promotion>>();
		public Task<ListPage<Promotion<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Promotion<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "promotions").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Promotion<Txp>>>();
		public Task<Promotion> CreateAsync(Promotion promotion, string accessToken = null) => Request("v1", "promotions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> CreateAsync<Txp>(Promotion promotion, string accessToken = null) => Request("v1", "promotions").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion<Txp>>();
		public Task<Promotion> SaveAsync(string promotionID, Promotion promotion, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> SaveAsync<Txp>(string promotionID, Promotion promotion, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion<Txp>>();
		public Task DeleteAsync(string promotionID, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Promotion> PatchAsync(string promotionID, PartialPromotion partialPromotion, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPromotion)).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> PatchAsync<Txp>(string promotionID, PartialPromotion partialPromotion, string accessToken = null) => Request("v1", "promotions", promotionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialPromotion)).ReceiveJson<Promotion<Txp>>();
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
		public Task<ListPage<SecurityProfileAssignment>> ListAssignmentsAsync(string buyerID = null, string supplierID = null, string securityProfileID = null, string userID = null, string userGroupID = null, CommerceRole? commerceRole = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "securityprofiles", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, supplierID, securityProfileID, userID, userGroupID, commerceRole, level, page, pageSize }).GetJsonAsync<ListPage<SecurityProfileAssignment>>();
		public Task DeleteAssignmentAsync(string securityProfileID, string buyerID = null, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "securityprofiles", securityProfileID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(SecurityProfileAssignment securityProfileAssignment, string accessToken = null) => Request("v1", "securityprofiles", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(securityProfileAssignment));
	}

	public class ShipmentsResource : OrderCloudResource, IShipmentsResource
	{
		internal ShipmentsResource(OrderCloudClient client) : base(client) { }
		public Task<Shipment> GetAsync(string shipmentID, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).GetJsonAsync<Shipment>();
		public Task<Shipment<Txp>> GetAsync<Txp>(string shipmentID, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).GetJsonAsync<Shipment<Txp>>();
		public Task<ListPage<Shipment>> ListAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment>>();
		public Task<ListPage<Shipment<Txp>>> ListAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment<Txp>>>();
		public Task<ListPage<Shipment>> ListAsync(Action<ListOptionsBuilder<Shipment>> buildListOpts, string orderID = null, string accessToken = null) => Request("v1", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Shipment>>();
		public Task<ListPage<Shipment<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Shipment<Txp>>> buildListOpts, string orderID = null, string accessToken = null) => Request("v1", "shipments").WithOAuthBearerToken(accessToken).SetQueryParams(new { orderID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Shipment<Txp>>>();
		public Task<Shipment> CreateAsync(Shipment shipment, string accessToken = null) => Request("v1", "shipments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment>();
		public Task<Shipment<Txp>> CreateAsync<Txp>(Shipment shipment, string accessToken = null) => Request("v1", "shipments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment<Txp>>();
		public Task<Shipment> SaveAsync(string shipmentID, Shipment shipment, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment>();
		public Task<Shipment<Txp>> SaveAsync<Txp>(string shipmentID, Shipment shipment, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment<Txp>>();
		public Task DeleteAsync(string shipmentID, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Shipment> PatchAsync(string shipmentID, PartialShipment partialShipment, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialShipment)).ReceiveJson<Shipment>();
		public Task<Shipment<Txp>> PatchAsync<Txp>(string shipmentID, PartialShipment partialShipment, string accessToken = null) => Request("v1", "shipments", shipmentID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialShipment)).ReceiveJson<Shipment<Txp>>();
		public Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem>>();
		public Task<ListPage<ShipmentItem<Txp>>> ListItemsAsync<Txp>(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem<Txp>>>();
		public Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, Action<ListOptionsBuilder<ShipmentItem>> buildListOpts, string accessToken = null) => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ShipmentItem>>();
		public Task<ListPage<ShipmentItem<Txp>>> ListItemsAsync<Txp>(string shipmentID, Action<ListOptionsBuilder<ShipmentItem<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<ShipmentItem<Txp>>>();
		public Task<ShipmentItem> GetItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<ShipmentItem>();
		public Task<ShipmentItem<Txp>> GetItemAsync<Txp>(string shipmentID, string orderID, string lineItemID, string accessToken = null) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).WithOAuthBearerToken(accessToken).GetJsonAsync<ShipmentItem<Txp>>();
		public Task<ShipmentItem> SaveItemAsync(string shipmentID, ShipmentItem shipmentItem, string accessToken = null) => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipmentItem)).ReceiveJson<ShipmentItem>();
		public Task<ShipmentItem<Txp>> SaveItemAsync<Txp>(string shipmentID, ShipmentItem shipmentItem, string accessToken = null) => Request("v1", "shipments", shipmentID, "items").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(shipmentItem)).ReceiveJson<ShipmentItem<Txp>>();
		public Task DeleteItemAsync(string shipmentID, string orderID, string lineItemID, string accessToken = null) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class SpecsResource : OrderCloudResource, ISpecsResource
	{
		internal SpecsResource(OrderCloudClient client) : base(client) { }
		public Task<Spec> GetAsync(string specID, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).GetJsonAsync<Spec>();
		public Task<Spec<Txp>> GetAsync<Txp>(string specID, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).GetJsonAsync<Spec<Txp>>();
		public Task<ListPage<Spec>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Spec>>();
		public Task<ListPage<Spec<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "specs").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Spec<Txp>>>();
		public Task<ListPage<Spec>> ListAsync(Action<ListOptionsBuilder<Spec>> buildListOpts, string accessToken = null) => Request("v1", "specs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Spec>>();
		public Task<ListPage<Spec<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Spec<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "specs").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Spec<Txp>>>();
		public Task<Spec> CreateAsync(Spec spec, string accessToken = null) => Request("v1", "specs").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spec)).ReceiveJson<Spec>();
		public Task<Spec<Txp>> CreateAsync<Txp>(Spec spec, string accessToken = null) => Request("v1", "specs").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spec)).ReceiveJson<Spec<Txp>>();
		public Task<Spec> SaveAsync(string specID, Spec spec, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(spec)).ReceiveJson<Spec>();
		public Task<Spec<Txp>> SaveAsync<Txp>(string specID, Spec spec, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(spec)).ReceiveJson<Spec<Txp>>();
		public Task DeleteAsync(string specID, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Spec> PatchAsync(string specID, PartialSpec partialSpec, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpec)).ReceiveJson<Spec>();
		public Task<Spec<Txp>> PatchAsync<Txp>(string specID, PartialSpec partialSpec, string accessToken = null) => Request("v1", "specs", specID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpec)).ReceiveJson<Spec<Txp>>();
		public Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "specs", "productassignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecProductAssignment>>();
		public Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(Action<ListOptionsBuilder<SpecProductAssignment>> buildListOpts, string accessToken = null) => Request("v1", "specs", "productassignments").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpecProductAssignment>>();
		public Task DeleteProductAssignmentAsync(string specID, string productID, string accessToken = null) => Request("v1", "specs", specID, "productassignments", productID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveProductAssignmentAsync(SpecProductAssignment specProductAssignment, string accessToken = null) => Request("v1", "specs", "productassignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(specProductAssignment));
		public Task<SpecOption> CreateOptionAsync(string specID, SpecOption specOption, string accessToken = null) => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption>();
		public Task<SpecOption<Txp>> CreateOptionAsync<Txp>(string specID, SpecOption specOption, string accessToken = null) => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption<Txp>>();
		public Task<ListPage<SpecOption>> ListOptionsAsync(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecOption>>();
		public Task<ListPage<SpecOption<Txp>>> ListOptionsAsync<Txp>(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecOption<Txp>>>();
		public Task<ListPage<SpecOption>> ListOptionsAsync(string specID, Action<ListOptionsBuilder<SpecOption>> buildListOpts, string accessToken = null) => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpecOption>>();
		public Task<ListPage<SpecOption<Txp>>> ListOptionsAsync<Txp>(string specID, Action<ListOptionsBuilder<SpecOption<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "specs", specID, "options").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpecOption<Txp>>>();
		public Task<SpecOption> SaveOptionAsync(string specID, string optionID, SpecOption specOption, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption>();
		public Task<SpecOption<Txp>> SaveOptionAsync<Txp>(string specID, string optionID, SpecOption specOption, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption<Txp>>();
		public Task<SpecOption> PatchOptionAsync(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpecOption)).ReceiveJson<SpecOption>();
		public Task<SpecOption<Txp>> PatchOptionAsync<Txp>(string specID, string optionID, PartialSpecOption partialSpecOption, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpecOption)).ReceiveJson<SpecOption<Txp>>();
		public Task<SpecOption> GetOptionAsync(string specID, string optionID, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).GetJsonAsync<SpecOption>();
		public Task<SpecOption<Txp>> GetOptionAsync<Txp>(string specID, string optionID, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).GetJsonAsync<SpecOption<Txp>>();
		public Task DeleteOptionAsync(string specID, string optionID, string accessToken = null) => Request("v1", "specs", specID, "options", optionID).WithOAuthBearerToken(accessToken).DeleteAsync();
	}

	public class SpendingAccountsResource : OrderCloudResource, ISpendingAccountsResource
	{
		internal SpendingAccountsResource(OrderCloudClient client) : base(client) { }
		public Task<SpendingAccount> GetAsync(string buyerID, string spendingAccountID, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).GetJsonAsync<SpendingAccount>();
		public Task<SpendingAccount<Txp>> GetAsync<Txp>(string buyerID, string spendingAccountID, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).GetJsonAsync<SpendingAccount<Txp>>();
		public Task<ListPage<SpendingAccount>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount>>();
		public Task<ListPage<SpendingAccount<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount<Txp>>>();
		public Task<ListPage<SpendingAccount>> ListAsync(string buyerID, Action<ListOptionsBuilder<SpendingAccount>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpendingAccount>>();
		public Task<ListPage<SpendingAccount<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<SpendingAccount<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<SpendingAccount<Txp>>>();
		public Task<SpendingAccount> CreateAsync(string buyerID, SpendingAccount spendingAccount, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount>();
		public Task<SpendingAccount<Txp>> CreateAsync<Txp>(string buyerID, SpendingAccount spendingAccount, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount<Txp>>();
		public Task<SpendingAccount> SaveAsync(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount>();
		public Task<SpendingAccount<Txp>> SaveAsync<Txp>(string buyerID, string spendingAccountID, SpendingAccount spendingAccount, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount<Txp>>();
		public Task DeleteAsync(string buyerID, string spendingAccountID, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<SpendingAccount> PatchAsync(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpendingAccount)).ReceiveJson<SpendingAccount>();
		public Task<SpendingAccount<Txp>> PatchAsync<Txp>(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSpendingAccount)).ReceiveJson<SpendingAccount<Txp>>();
		public Task<ListPage<SpendingAccountAssignment>> ListAssignmentsAsync(string buyerID, string spendingAccountID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { spendingAccountID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<SpendingAccountAssignment>>();
		public Task SaveAssignmentAsync(string buyerID, SpendingAccountAssignment spendingAccountAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(spendingAccountAssignment));
		public Task DeleteAssignmentAsync(string buyerID, string spendingAccountID, string userID = null, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID, "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class SuppliersResource : OrderCloudResource, ISuppliersResource
	{
		internal SuppliersResource(OrderCloudClient client) : base(client) { }
		public Task<Supplier> GetAsync(string supplierID, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).GetJsonAsync<Supplier>();
		public Task<Supplier<Txp>> GetAsync<Txp>(string supplierID, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).GetJsonAsync<Supplier<Txp>>();
		public Task<ListPage<Supplier>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier>>();
		public Task<ListPage<Supplier<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier<Txp>>>();
		public Task<ListPage<Supplier>> ListAsync(Action<ListOptionsBuilder<Supplier>> buildListOpts, string accessToken = null) => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Supplier>>();
		public Task<ListPage<Supplier<Txp>>> ListAsync<Txp>(Action<ListOptionsBuilder<Supplier<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<Supplier<Txp>>>();
		public Task<Supplier> CreateAsync(Supplier supplier, string accessToken = null) => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier>();
		public Task<Supplier<Txp>> CreateAsync<Txp>(Supplier supplier, string accessToken = null) => Request("v1", "suppliers").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier<Txp>>();
		public Task DeleteAsync(string supplierID, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<Supplier> SaveAsync(string supplierID, Supplier supplier, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier>();
		public Task<Supplier<Txp>> SaveAsync<Txp>(string supplierID, Supplier supplier, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier<Txp>>();
		public Task<Supplier> PatchAsync(string supplierID, PartialSupplier partialSupplier, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSupplier)).ReceiveJson<Supplier>();
		public Task<Supplier<Txp>> PatchAsync<Txp>(string supplierID, PartialSupplier partialSupplier, string accessToken = null) => Request("v1", "suppliers", supplierID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialSupplier)).ReceiveJson<Supplier<Txp>>();
	}

	public class SupplierUserGroupsResource : OrderCloudResource, ISupplierUserGroupsResource
	{
		internal SupplierUserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string supplierID, string userGroupID, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<UserGroup>();
		public Task<UserGroup<Txp>> GetAsync<Txp>(string supplierID, string userGroupID, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<UserGroup<Txp>>();
		public Task<ListPage<UserGroup>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<ListPage<UserGroup>> ListAsync(string supplierID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string supplierID, Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<UserGroup> CreateAsync(string supplierID, UserGroup userGroup, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> CreateAsync<Txp>(string supplierID, UserGroup userGroup, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<UserGroup> SaveAsync(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> SaveAsync<Txp>(string supplierID, string userGroupID, UserGroup userGroup, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task DeleteAsync(string supplierID, string userGroupID, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<UserGroup> PatchAsync(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> PatchAsync<Txp>(string supplierID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string supplierID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string supplierID, string userGroupID, string userID, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID, "assignments", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveUserAssignmentAsync(string supplierID, UserGroupAssignment userGroupAssignment, string accessToken = null) => Request("v1", "suppliers", supplierID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class SupplierUsersResource : OrderCloudResource, ISupplierUsersResource
	{
		internal SupplierUsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string supplierID, string userID, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<User>();
		public Task<User<Txp>> GetAsync<Txp>(string supplierID, string userID, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<User<Txp>>();
		public Task<ListPage<User>> ListAsync(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<ListPage<User>> ListAsync(string supplierID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string supplierID, Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string userGroupID = null, string accessToken = null) => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<User> CreateAsync(string supplierID, User user, string accessToken = null) => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> CreateAsync<Txp>(string supplierID, User user, string accessToken = null) => Request("v1", "suppliers", supplierID, "users").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task<User> SaveAsync(string supplierID, string userID, User user, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> SaveAsync<Txp>(string supplierID, string userID, User user, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task DeleteAsync(string supplierID, string userID, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<User> PatchAsync(string supplierID, string userID, PartialUser partialUser, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User>();
		public Task<User<Txp>> PatchAsync<Txp>(string supplierID, string userID, PartialUser partialUser, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User<Txp>>();
		public Task<AccessToken> GetAccessTokenAsync(string supplierID, string userID, ImpersonateTokenRequest impersonateTokenRequest, string accessToken = null) => Request("v1", "suppliers", supplierID, "users", userID, "accesstoken").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(impersonateTokenRequest)).ReceiveJson<AccessToken>();
	}

	public class UserGroupsResource : OrderCloudResource, IUserGroupsResource
	{
		internal UserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string buyerID, string userGroupID, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<UserGroup>();
		public Task<UserGroup<Txp>> GetAsync<Txp>(string buyerID, string userGroupID, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).GetJsonAsync<UserGroup<Txp>>();
		public Task<ListPage<UserGroup>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<ListPage<UserGroup>> ListAsync(string buyerID, Action<ListOptionsBuilder<UserGroup>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<UserGroup<Txp>>> buildListOpts, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).SetListOptions(buildListOpts).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<UserGroup> CreateAsync(string buyerID, UserGroup userGroup, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> CreateAsync<Txp>(string buyerID, UserGroup userGroup, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<UserGroup> SaveAsync(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> SaveAsync<Txp>(string buyerID, string userGroupID, UserGroup userGroup, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task DeleteAsync(string buyerID, string userGroupID, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<UserGroup> PatchAsync(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> PatchAsync<Txp>(string buyerID, string userGroupID, PartialUserGroup partialUserGroup, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string buyerID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string buyerID, string userGroupID, string userID, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", userGroupID, "assignments", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task SaveUserAssignmentAsync(string buyerID, UserGroupAssignment userGroupAssignment, string accessToken = null) => Request("v1", "buyers", buyerID, "usergroups", "assignments").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class UsersResource : OrderCloudResource, IUsersResource
	{
		internal UsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string buyerID, string userID, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<User>();
		public Task<User<Txp>> GetAsync<Txp>(string buyerID, string userID, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).GetJsonAsync<User<Txp>>();
		public Task<ListPage<User>> ListAsync(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null, string accessToken = null) => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<ListPage<User>> ListAsync(string buyerID, Action<ListOptionsBuilder<User>> buildListOpts, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string buyerID, Action<ListOptionsBuilder<User<Txp>>> buildListOpts, string userGroupID = null, string accessToken = null) => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).SetQueryParams(new { userGroupID }).SetListOptions(buildListOpts).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<User> CreateAsync(string buyerID, User user, string accessToken = null) => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> CreateAsync<Txp>(string buyerID, User user, string accessToken = null) => Request("v1", "buyers", buyerID, "users").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task<User> SaveAsync(string buyerID, string userID, User user, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> SaveAsync<Txp>(string buyerID, string userID, User user, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).PutJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task DeleteAsync(string buyerID, string userID, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).DeleteAsync();
		public Task<User> PatchAsync(string buyerID, string userID, PartialUser partialUser, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User>();
		public Task<User<Txp>> PatchAsync<Txp>(string buyerID, string userID, PartialUser partialUser, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID).WithOAuthBearerToken(accessToken).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User<Txp>>();
		public Task<User> MoveAsync(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID, "moveto", newBuyerID).WithOAuthBearerToken(accessToken).SetQueryParams(new { orders }).PostAsync(null).ReceiveJson<User>();
		public Task<User<Txp>> MoveAsync<Txp>(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID, "moveto", newBuyerID).WithOAuthBearerToken(accessToken).SetQueryParams(new { orders }).PostAsync(null).ReceiveJson<User<Txp>>();
		public Task<AccessToken> GetAccessTokenAsync(string buyerID, string userID, ImpersonateTokenRequest impersonateTokenRequest, string accessToken = null) => Request("v1", "buyers", buyerID, "users", userID, "accesstoken").WithOAuthBearerToken(accessToken).PostJsonAsync(ValidateModel(impersonateTokenRequest)).ReceiveJson<AccessToken>();
	}
}
