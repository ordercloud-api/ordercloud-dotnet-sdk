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
		Task<Address> GetAsync(string buyerID, string addressID);
		/// <summary>Get a single address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		Task<Address<Txp>> GetAsync<Txp>(string buyerID, string addressID);
		/// <summary>Get a list of addresses.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Address>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of addresses.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Address<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Address> CreateAsync(string buyerID, Address address);
		/// <summary>Create a new address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Address<Txp>> CreateAsync<Txp>(string buyerID, Address address);
		/// <summary>Create or update an address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		Task<Address> SaveAsync(string buyerID, string addressID, Address address);
		/// <summary>Create or update an address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		Task<Address<Txp>> SaveAsync<Txp>(string buyerID, string addressID, Address address);
		/// <summary>Delete an address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		Task DeleteAsync(string buyerID, string addressID);
		/// <summary>Partially update an address.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		Task<Address> PatchAsync(string buyerID, string addressID, PartialAddress partialAddress);
		/// <summary>Partially update an address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		Task<Address<Txp>> PatchAsync<Txp>(string buyerID, string addressID, PartialAddress partialAddress);
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
		Task<ListPage<AddressAssignment>> ListAssignmentsAsync(string buyerID, string addressID = null, string userID = null, string userGroupID = null, PartyType? level = null, bool? isShipping = null, bool? isBilling = null, int? page = null, int? pageSize = null);
		/// <summary>Delete an address assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="addressID">ID of the address.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string buyerID, string addressID, string userID = null, string userGroupID = null);
		/// <summary>Create or update an address assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task SaveAssignmentAsync(string buyerID, AddressAssignment addressAssignment);
	}

	public interface IAdminAddressesResource
	{
		/// <summary>Get a single admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task<Address> GetAsync(string addressID);
		/// <summary>Get a single admin address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		Task<Address<Txp>> GetAsync<Txp>(string addressID);
		/// <summary>Get a list of admin addresses.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Address>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of admin addresses.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Address<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new admin address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Address> CreateAsync(Address address);
		/// <summary>Create a new admin address. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Address<Txp>> CreateAsync<Txp>(Address address);
		/// <summary>Create or update an admin address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task<Address> SaveAsync(string addressID, Address address);
		/// <summary>Create or update an admin address. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		Task<Address<Txp>> SaveAsync<Txp>(string addressID, Address address);
		/// <summary>Delete an admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task DeleteAsync(string addressID);
		/// <summary>Partially update an admin address.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task<Address> PatchAsync(string addressID, PartialAddress partialAddress);
		/// <summary>Partially update an admin address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		Task<Address<Txp>> PatchAsync<Txp>(string addressID, PartialAddress partialAddress);
	}

	public interface IAdminUserGroupsResource
	{
		/// <summary>Get a single admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> GetAsync(string userGroupID);
		/// <summary>Get a single admin user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> GetAsync<Txp>(string userGroupID);
		/// <summary>Get a list of admin user groups.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of admin user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new admin user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<UserGroup> CreateAsync(UserGroup userGroup);
		/// <summary>Create a new admin user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<UserGroup<Txp>> CreateAsync<Txp>(UserGroup userGroup);
		/// <summary>Create or update an admin user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> SaveAsync(string userGroupID, UserGroup userGroup);
		/// <summary>Create or update an admin user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> SaveAsync<Txp>(string userGroupID, UserGroup userGroup);
		/// <summary>Delete an admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAsync(string userGroupID);
		/// <summary>Partially update an admin user group.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> PatchAsync(string userGroupID, PartialUserGroup partialUserGroup);
		/// <summary>Partially update an admin user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> PatchAsync<Txp>(string userGroupID, PartialUserGroup partialUserGroup);
		/// <summary>Get a list of admin user group user assignments.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string userGroupID = null, string userID = null, int page = 1, int pageSize = 20);
		/// <summary>Delete an admin user group user assignment.</summary>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		Task DeleteUserAssignmentAsync(string userGroupID, string userID);
		/// <summary>Create or update an admin user group user assignment.</summary>
		Task SaveUserAssignmentAsync(UserGroupAssignment userGroupAssignment);
	}

	public interface IAdminUsersResource
	{
		/// <summary>Get a single admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		Task<User> GetAsync(string userID);
		/// <summary>Get a single admin user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> GetAsync<Txp>(string userID);
		/// <summary>Get a list of admin users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<User>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of admin users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new admin user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<User> CreateAsync(User user);
		/// <summary>Create a new admin user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<User<Txp>> CreateAsync<Txp>(User user);
		/// <summary>Create or update an admin user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="userID">ID of the user.</param>
		Task<User> SaveAsync(string userID, User user);
		/// <summary>Create or update an admin user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> SaveAsync<Txp>(string userID, User user);
		/// <summary>Delete an admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		Task DeleteAsync(string userID);
		/// <summary>Partially update an admin user.</summary>
		/// <param name="userID">ID of the user.</param>
		Task<User> PatchAsync(string userID, PartialUser partialUser);
		/// <summary>Partially update an admin user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> PatchAsync<Txp>(string userID, PartialUser partialUser);
	}

	public interface IApprovalRulesResource
	{
		/// <summary>Get a single approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task<ApprovalRule> GetAsync(string buyerID, string approvalRuleID);
		/// <summary>Get a single approval rule.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task<ApprovalRule<Txp>> GetAsync<Txp>(string buyerID, string approvalRuleID);
		/// <summary>Get a list of approval rules.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<ApprovalRule>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of approval rules.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<ApprovalRule<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<ApprovalRule> CreateAsync(string buyerID, ApprovalRule approvalRule);
		/// <summary>Create a new approval rule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<ApprovalRule<Txp>> CreateAsync<Txp>(string buyerID, ApprovalRule approvalRule);
		/// <summary>Create or update an approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task<ApprovalRule> SaveAsync(string buyerID, string approvalRuleID, ApprovalRule approvalRule);
		/// <summary>Create or update an approval rule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task<ApprovalRule<Txp>> SaveAsync<Txp>(string buyerID, string approvalRuleID, ApprovalRule approvalRule);
		/// <summary>Delete an approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task DeleteAsync(string buyerID, string approvalRuleID);
		/// <summary>Partially update an approval rule.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task<ApprovalRule> PatchAsync(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule);
		/// <summary>Partially update an approval rule.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="approvalRuleID">ID of the approval rule.</param>
		Task<ApprovalRule<Txp>> PatchAsync<Txp>(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule);
	}

	public interface IBuyersResource
	{
		/// <summary>Get a single buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Buyer> GetAsync(string buyerID);
		/// <summary>Get a single buyer.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Buyer<Txp>> GetAsync<Txp>(string buyerID);
		/// <summary>Get a list of buyers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Buyer>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of buyers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Buyer<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new buyer. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Buyer> CreateAsync(Buyer buyer);
		/// <summary>Create a new buyer. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Buyer<Txp>> CreateAsync<Txp>(Buyer buyer);
		/// <summary>Delete a buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task DeleteAsync(string buyerID);
		/// <summary>Create or update a buyer. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Buyer> SaveAsync(string buyerID, Buyer buyer);
		/// <summary>Create or update a buyer. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Buyer<Txp>> SaveAsync<Txp>(string buyerID, Buyer buyer);
		/// <summary>Partially update a buyer.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Buyer> PatchAsync(string buyerID, PartialBuyer partialBuyer);
		/// <summary>Partially update a buyer.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<Buyer<Txp>> PatchAsync<Txp>(string buyerID, PartialBuyer partialBuyer);
	}

	public interface ICatalogsResource
	{
		/// <summary>Get a single catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog> GetAsync(string catalogID);
		/// <summary>Get a single catalog.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog<Txp>> GetAsync<Txp>(string catalogID);
		/// <summary>Get a list of catalogs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Catalog>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of catalogs.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Catalog<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new catalog. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Catalog> CreateAsync(Catalog catalog);
		/// <summary>Create a new catalog. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Catalog<Txp>> CreateAsync<Txp>(Catalog catalog);
		/// <summary>Create or update a catalog. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog> SaveAsync(string catalogID, Catalog catalog);
		/// <summary>Create or update a catalog. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog<Txp>> SaveAsync<Txp>(string catalogID, Catalog catalog);
		/// <summary>Delete a catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task DeleteAsync(string catalogID);
		/// <summary>Partially update a catalog.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog> PatchAsync(string catalogID, PartialCatalog partialCatalog);
		/// <summary>Partially update a catalog.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog<Txp>> PatchAsync<Txp>(string catalogID, PartialCatalog partialCatalog);
		/// <summary>Get a list of catalog assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<CatalogAssignment>> ListAssignmentsAsync(string catalogID = null, string buyerID = null, int page = 1, int pageSize = 20);
		/// <summary>Create or update a catalog assignment.</summary>
		Task SaveAssignmentAsync(CatalogAssignment catalogAssignment);
		/// <summary>Delete a catalog assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		Task DeleteAssignmentAsync(string catalogID, string buyerID);
		/// <summary>Get a list of catalog product assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<ProductCatalogAssignment>> ListProductAssignmentsAsync(string catalogID = null, string productID = null, int page = 1, int pageSize = 20);
		/// <summary>Create or update a catalog product assignment.</summary>
		Task SaveProductAssignmentAsync(ProductCatalogAssignment productCatalogAssignment);
		/// <summary>Delete a catalog product assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="productID">ID of the product.</param>
		Task DeleteProductAssignmentAsync(string catalogID, string productID);
	}

	public interface ICategoriesResource
	{
		/// <summary>Get a single category.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task<Category> GetAsync(string catalogID, string categoryID);
		/// <summary>Get a single category.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task<Category<Txp>> GetAsync<Txp>(string catalogID, string categoryID);
		/// <summary>Get a list of categories.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="depth">Depth of the category.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Category>> ListAsync(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<Category<Txp>>> ListAsync<Txp>(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new category. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Category> CreateAsync(string catalogID, Category category);
		/// <summary>Create a new category. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Category<Txp>> CreateAsync<Txp>(string catalogID, Category category);
		/// <summary>Create or update a category. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task<Category> SaveAsync(string catalogID, string categoryID, Category category);
		/// <summary>Create or update a category. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task<Category<Txp>> SaveAsync<Txp>(string catalogID, string categoryID, Category category);
		/// <summary>Delete a category. Deleting a parent category will also delete all of that category's children.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task DeleteAsync(string catalogID, string categoryID);
		/// <summary>Partially update a category.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task<Category> PatchAsync(string catalogID, string categoryID, PartialCategory partialCategory);
		/// <summary>Partially update a category.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		Task<Category<Txp>> PatchAsync<Txp>(string catalogID, string categoryID, PartialCategory partialCategory);
		/// <summary>Get a list of category assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the category assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<CategoryAssignment>> ListAssignmentsAsync(string catalogID, string categoryID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Delete a category assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string catalogID, string categoryID, string buyerID, string userID = null, string userGroupID = null);
		/// <summary>Create or update a category assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task SaveAssignmentAsync(string catalogID, CategoryAssignment categoryAssignment);
		/// <summary>Get a list of category product assignments.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="productID">ID of the product.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<CategoryProductAssignment>> ListProductAssignmentsAsync(string catalogID, string categoryID = null, string productID = null, int page = 1, int pageSize = 20);
		/// <summary>Create or update a category product assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task SaveProductAssignmentAsync(string catalogID, CategoryProductAssignment categoryProductAssignment);
		/// <summary>Delete a category product assignment.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="productID">ID of the product.</param>
		Task DeleteProductAssignmentAsync(string catalogID, string categoryID, string productID);
	}

	public interface ICostCentersResource
	{
		/// <summary>Get a single cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task<CostCenter> GetAsync(string buyerID, string costCenterID);
		/// <summary>Get a single cost center.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task<CostCenter<Txp>> GetAsync<Txp>(string buyerID, string costCenterID);
		/// <summary>Get a list of cost centers.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<CostCenter>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of cost centers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<CostCenter<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new cost center. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<CostCenter> CreateAsync(string buyerID, CostCenter costCenter);
		/// <summary>Create a new cost center. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<CostCenter<Txp>> CreateAsync<Txp>(string buyerID, CostCenter costCenter);
		/// <summary>Create or update a cost center. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task<CostCenter> SaveAsync(string buyerID, string costCenterID, CostCenter costCenter);
		/// <summary>Create or update a cost center. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task<CostCenter<Txp>> SaveAsync<Txp>(string buyerID, string costCenterID, CostCenter costCenter);
		/// <summary>Delete a cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task DeleteAsync(string buyerID, string costCenterID);
		/// <summary>Partially update a cost center.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task<CostCenter> PatchAsync(string buyerID, string costCenterID, PartialCostCenter partialCostCenter);
		/// <summary>Partially update a cost center.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		Task<CostCenter<Txp>> PatchAsync<Txp>(string buyerID, string costCenterID, PartialCostCenter partialCostCenter);
		/// <summary>Get a list of cost center assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the cost center assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<CostCenterAssignment>> ListAssignmentsAsync(string buyerID, string costCenterID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Delete a cost center assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="costCenterID">ID of the cost center.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string buyerID, string costCenterID, string userID = null, string userGroupID = null);
		/// <summary>Create or update a cost center assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task SaveAssignmentAsync(string buyerID, CostCenterAssignment costCenterAssignment);
	}

	public interface ICreditCardsResource
	{
		/// <summary>Get a single credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task<CreditCard> GetAsync(string buyerID, string creditCardID);
		/// <summary>Get a single credit card.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task<CreditCard<Txp>> GetAsync<Txp>(string buyerID, string creditCardID);
		/// <summary>Get a list of credit cards.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<CreditCard>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of credit cards.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<CreditCard<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new credit card. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<CreditCard> CreateAsync(string buyerID, CreditCard creditCard);
		/// <summary>Create a new credit card. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<CreditCard<Txp>> CreateAsync<Txp>(string buyerID, CreditCard creditCard);
		/// <summary>Create or update a credit card. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task<CreditCard> SaveAsync(string buyerID, string creditCardID, CreditCard creditCard);
		/// <summary>Create or update a credit card. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task<CreditCard<Txp>> SaveAsync<Txp>(string buyerID, string creditCardID, CreditCard creditCard);
		/// <summary>Delete a credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task DeleteAsync(string buyerID, string creditCardID);
		/// <summary>Partially update a credit card.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task<CreditCard> PatchAsync(string buyerID, string creditCardID, PartialCreditCard partialCreditCard);
		/// <summary>Partially update a credit card.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		Task<CreditCard<Txp>> PatchAsync<Txp>(string buyerID, string creditCardID, PartialCreditCard partialCreditCard);
		/// <summary>Get a list of credit card assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the credit card assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<CreditCardAssignment>> ListAssignmentsAsync(string buyerID, string creditCardID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Create or update a credit card assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task SaveAssignmentAsync(string buyerID, CreditCardAssignment creditCardAssignment);
		/// <summary>Delete a credit card assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="creditCardID">ID of the credit card.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string buyerID, string creditCardID, string userID = null, string userGroupID = null);
	}

	public interface IImpersonationConfigsResource
	{
		/// <summary>Get a single impersonation config.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		Task<ImpersonationConfig> GetAsync(string impersonationConfigID);
		/// <summary>Get a list of impersonation configs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<ImpersonationConfig>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new impersonation config. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<ImpersonationConfig> CreateAsync(ImpersonationConfig impersonationConfig);
		/// <summary>Delete an impersonation config.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		Task DeleteAsync(string impersonationConfigID);
		/// <summary>Create or update an impersonation config. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		Task<ImpersonationConfig> SaveAsync(string impersonationConfigID, ImpersonationConfig impersonationConfig);
		/// <summary>Partially update an impersonation config.</summary>
		/// <param name="impersonationConfigID">ID of the impersonation config.</param>
		Task<ImpersonationConfig> PatchAsync(string impersonationConfigID, PartialImpersonationConfig partialImpersonationConfig);
	}

	public interface IIncrementorsResource
	{
		/// <summary>Get a single incrementor.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		Task<Incrementor> GetAsync(string incrementorID);
		/// <summary>Get a list of incrementors.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Incrementor>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new incrementor. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Incrementor> CreateAsync(Incrementor incrementor);
		/// <summary>Create or update an incrementor. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		Task<Incrementor> SaveAsync(string incrementorID, Incrementor incrementor);
		/// <summary>Delete an incrementor.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		Task DeleteAsync(string incrementorID);
		/// <summary>Partially update an incrementor.</summary>
		/// <param name="incrementorID">ID of the incrementor.</param>
		Task<Incrementor> PatchAsync(string incrementorID, PartialIncrementor partialIncrementor);
	}

	public interface ILineItemsResource
	{
		/// <summary>Get a single line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem> GetAsync(OrderDirection direction, string orderID, string lineItemID);
		/// <summary>Get a single line item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string lineItemID);
		/// <summary>Get a list of line items.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<LineItem<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<LineItem> CreateAsync(OrderDirection direction, string orderID, LineItem lineItem);
		/// <summary>Create a new line item. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<LineItem<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, LineItem lineItem);
		/// <summary>Create or update a line item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem> SaveAsync(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem);
		/// <summary>Create or update a line item. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem);
		/// <summary>Delete a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string lineItemID);
		/// <summary>Partially update a line item.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem> PatchAsync(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem);
		/// <summary>Partially update a line item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem);
		/// <summary>Set a shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem> SetShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, Address address);
		/// <summary>Set a shipping address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, Address address);
		/// <summary>Partially update a line item shipping address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem> PatchShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress);
		/// <summary>Partially update a line item shipping address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<LineItem<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress);
	}

	public interface IMeResource
	{
		/// <summary>Get the Current Authenticated User</summary>
		Task<MeUser> GetAsync();
		/// <summary>Get the Current Authenticated User</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<MeUser<Txp>> GetAsync<Txp>();
		/// <summary>Update the Currently Authenticated User If an object with the same ID already exists, it will be overwritten.</summary>
		Task<MeUser> SaveAsync(MeUser meUser);
		/// <summary>Update the Currently Authenticated User If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<MeUser<Txp>> SaveAsync<Txp>(MeUser meUser);
		/// <summary>Patch the Currently Authenticated User.</summary>
		Task<MeUser> PatchAsync(PartialMeUser partialMeUser);
		/// <summary>Patch the Currently Authenticated User.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<MeUser<Txp>> PatchAsync<Txp>(PartialMeUser partialMeUser);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<CostCenter>> ListCostCentersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of cost centers visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<CostCenter<Txp>>> ListCostCentersAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup>> ListUserGroupsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of user groups visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup<Txp>>> ListUserGroupsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<BuyerAddress>> ListAddressesAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of addresses visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<BuyerAddress<Txp>>> ListAddressesAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new address. Only available to Buyer Users.</summary>
		Task<BuyerAddress> CreateAddressAsync(BuyerAddress buyerAddress);
		/// <summary>Create a new address. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<BuyerAddress<Txp>> CreateAddressAsync<Txp>(BuyerAddress buyerAddress);
		/// <summary>Get a single address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task<BuyerAddress> GetAddressAsync(string addressID);
		/// <summary>Get a single address. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		Task<BuyerAddress<Txp>> GetAddressAsync<Txp>(string addressID);
		/// <summary>Create or update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task<BuyerAddress> SaveAddressAsync(string addressID, BuyerAddress buyerAddress);
		/// <summary>Create or update an address. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="addressID">ID of the address.</param>
		Task<BuyerAddress<Txp>> SaveAddressAsync<Txp>(string addressID, BuyerAddress buyerAddress);
		/// <summary>Partially update an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task PatchAddressAsync(string addressID, PartialBuyerAddress partialBuyerAddress);
		/// <summary>Delete an address. Only available to Buyer Users.</summary>
		/// <param name="addressID">ID of the address.</param>
		Task DeleteAddressAsync(string addressID);
		/// <summary>Create a new credit card. Only available to Buyer Users.</summary>
		Task<BuyerCreditCard> CreateCreditCardAsync(BuyerCreditCard buyerCreditCard);
		/// <summary>Create a new credit card. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<BuyerCreditCard<Txp>> CreateCreditCardAsync<Txp>(BuyerCreditCard buyerCreditCard);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of credit cards visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<BuyerCreditCard<Txp>>> ListCreditCardsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		Task<BuyerCreditCard> GetCreditCardAsync(string creditcardID);
		/// <summary>Get a single credit card. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="creditcardID">ID of the creditcard.</param>
		Task<BuyerCreditCard<Txp>> GetCreditCardAsync<Txp>(string creditcardID);
		/// <summary>Create or update a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		Task<BuyerCreditCard> SaveCreditCardAsync(string creditcardID, BuyerCreditCard buyerCreditCard);
		/// <summary>Create or update a credit card. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="creditcardID">ID of the creditcard.</param>
		Task<BuyerCreditCard<Txp>> SaveCreditCardAsync<Txp>(string creditcardID, BuyerCreditCard buyerCreditCard);
		/// <summary>Partially update a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		Task PatchCreditCardAsync(string creditcardID, PartialBuyerCreditCard partialBuyerCreditCard);
		/// <summary>Delete a credit card. Only available to Buyer Users.</summary>
		/// <param name="creditcardID">ID of the creditcard.</param>
		Task DeleteCreditCardAsync(string creditcardID);
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
		Task<ListPage<Category>> ListCategoriesAsync(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single category. Only available to Buyer Users.</summary>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Category> GetCategoryAsync(string categoryID, string catalogID);
		/// <summary>Get a single category. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="categoryID">ID of the category.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Category<Txp>> GetCategoryAsync<Txp>(string categoryID, string catalogID);
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
		Task<ListPage<BuyerProduct>> ListProductsAsync(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single product. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		Task<BuyerProduct> GetProductAsync(string productID);
		/// <summary>Get a single product. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		Task<BuyerProduct<Txp>> GetProductAsync<Txp>(string productID);
		/// <summary>Get a list of specs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<BuyerSpec>> ListSpecsAsync(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single spec. Only available to Buyer Users.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<BuyerSpec> GetSpecAsync(string productID, string specID, string catalogID = null);
		/// <summary>Get a single spec. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<BuyerSpec<Txp>> GetSpecAsync<Txp>(string productID, string specID, string catalogID = null);
		/// <summary>Get a list of orders visible to this user. List orders created by this user.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Order>> ListOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<Order<Txp>>> ListOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of orders that this user can approve.</summary>
		/// <param name="from">Lower bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="to">Upper bound of date range that the order was created (if outgoing) or submitted (if incoming).</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Order>> ListApprovableOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<Order<Txp>>> ListApprovableOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Promotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of promotions visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Promotion<Txp>>> ListPromotionsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single promotion. Only available to Buyer Users.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion> GetPromotionAsync(string promotionID);
		/// <summary>Get a single promotion. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion<Txp>> GetPromotionAsync<Txp>(string promotionID);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of spending accounts visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpendingAccount<Txp>>> ListSpendingAccountsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single spending account. Only available to Buyer Users.</summary>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount> GetSpendingAccountAsync(string spendingAccountID);
		/// <summary>Get a single spending account. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount<Txp>> GetSpendingAccountAsync<Txp>(string spendingAccountID);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Shipment>> ListShipmentsAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of shipments visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Shipment<Txp>>> ListShipmentsAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single shipment. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment> GetShipmentAsync(string shipmentID);
		/// <summary>Get a single shipment. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment<Txp>> GetShipmentAsync<Txp>(string shipmentID);
		/// <summary>Get a list of shipment items visible to this user. Only available to Buyer Users.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<ShipmentItem<Txp>>> ListShipmentItemsAsync<Txp>(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Register a register.</summary>
		/// <param name="anonUserToken">Anon user token of the user.</param>
		Task<dynamic> RegisterAsync(MeUser meUser, string anonUserToken);
		/// <summary>Transfer an anon user order.</summary>
		/// <param name="anonUserToken">Anon user token of the me.</param>
		Task TransferAnonUserOrderAsync(string anonUserToken);
		/// <summary>Reset a password by token.</summary>
		Task ResetPasswordByTokenAsync(TokenPasswordReset tokenPasswordReset);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Catalog>> ListCatalogsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of catalogs visible to this user. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Catalog<Txp>>> ListCatalogsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single catalog. Only available to Buyer Users.</summary>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog> GetCatalogAsync(string catalogID);
		/// <summary>Get a single catalog. Only available to Buyer Users.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="catalogID">ID of the catalog.</param>
		Task<Catalog<Txp>> GetCatalogAsync<Txp>(string catalogID);
	}

	public interface IMessageSendersResource
	{
		/// <summary>Get a single message sender.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		Task<MessageSender> GetAsync(string messageSenderID);
		/// <summary>Get a list of message senders.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<MessageSender>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of message sender assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the message sender assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<MessageSenderAssignment>> ListAssignmentsAsync(string buyerID = null, string messageSenderID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Delete a message sender assignment.</summary>
		/// <param name="messageSenderID">ID of the message sender.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string messageSenderID, string buyerID = null, string userID = null, string userGroupID = null);
		/// <summary>Create or update a message sender assignment.</summary>
		Task SaveAssignmentAsync(MessageSenderAssignment messageSenderAssignment);
		/// <summary>Get a list of message sender cc listener assignments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create or update a message sender cc listener assignment.</summary>
		Task SaveCCListenerAssignmentAsync(MessageCCListenerAssignment messageCCListenerAssignment);
	}

	public interface IOrdersResource
	{
		/// <summary>Get a single order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> GetAsync(OrderDirection direction, string orderID);
		/// <summary>Get a single order.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID);
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
		Task<ListPage<Order>> ListAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<Order<Txp>>> ListAsync<Txp>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new order. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		Task<Order> CreateAsync(OrderDirection direction, Order order);
		/// <summary>Create a new order. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		Task<Order<Txp>> CreateAsync<Txp>(OrderDirection direction, Order order);
		/// <summary>Create or update an order. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> SaveAsync(OrderDirection direction, string orderID, Order order);
		/// <summary>Create or update an order. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, Order order);
		/// <summary>Delete an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task DeleteAsync(OrderDirection direction, string orderID);
		/// <summary>Get a list of order approvals. Returns all Approvals associated with the Order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of order eligible approvers. Returns all Users who can approve or decline this order (but have not done so).</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<User<Txp>>> ListEligibleApproversAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Partially update an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> PatchAsync(OrderDirection direction, string orderID, PartialOrder partialOrder);
		/// <summary>Partially update an order.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, PartialOrder partialOrder);
		/// <summary>Submit an order submit.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> SubmitAsync(OrderDirection direction, string orderID);
		/// <summary>Submit an order submit.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> SubmitAsync<Txp>(OrderDirection direction, string orderID);
		/// <summary>Approve an order approve.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> ApproveAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo);
		/// <summary>Approve an order approve.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> ApproveAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo);
		/// <summary>Decline an order decline.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> DeclineAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo);
		/// <summary>Decline an order decline.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> DeclineAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo);
		/// <summary>Cancel an order cancel.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> CancelAsync(OrderDirection direction, string orderID);
		/// <summary>Cancel an order cancel.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> CancelAsync<Txp>(OrderDirection direction, string orderID);
		/// <summary>Create a new shipment containing all items on an order.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> ShipAsync(OrderDirection direction, string orderID, Shipment shipment);
		/// <summary>Create a new shipment containing all items on an order.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> ShipAsync<Txp>(OrderDirection direction, string orderID, Shipment shipment);
		/// <summary>Set a shipping address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's ShippingAddressID property instead.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> SetShippingAddressAsync(OrderDirection direction, string orderID, Address address);
		/// <summary>Set a shipping address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's ShippingAddressID property instead.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address);
		/// <summary>Partially update an order shipping address. Not allowed on unsubmitted orders where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> PatchShippingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress);
		/// <summary>Partially update an order shipping address. Not allowed on unsubmitted orders where ShippingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress);
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> SetBillingAddressAsync(OrderDirection direction, string orderID, Address address);
		/// <summary>Set a billing address. Use only when the address is not to be saved/reused. To use a saved address (i.e. from the Addresses resource), PATCH the order's BillingAddressID property instead.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> SetBillingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address);
		/// <summary>Partially update an order billing address. Not allowed on unsubmitted orders where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> PatchBillingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress);
		/// <summary>Partially update an order billing address. Not allowed on unsubmitted orders where BillingAddressID has been set. In that case, use the Addresses resource to update the saved address.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> PatchBillingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress);
		/// <summary>Override order creator details. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order> PatchFromUserAsync(OrderDirection direction, string orderID, PartialUser partialUser);
		/// <summary>Override order creator details. Only FirstName, LastName, and Email can be updated. Primarily used to facilitate guest checkout scenarios.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Order<Txp>> PatchFromUserAsync<Txp>(OrderDirection direction, string orderID, PartialUser partialUser);
		/// <summary>Add a promotion to an order</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the promotion.</param>
		Task<Promotion> AddPromotionAsync(OrderDirection direction, string orderID, string promoCode);
		/// <summary>Add a promotion to an order</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the promotion.</param>
		Task<Promotion<Txp>> AddPromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode);
		/// <summary>Get a list of order promotions.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<OrderPromotion<Txp>>> ListPromotionsAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Remove a promotion from an order</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order.</param>
		Task<Order> RemovePromotionAsync(OrderDirection direction, string orderID, string promoCode);
		/// <summary>Remove a promotion from an order</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="promoCode">Promo code of the order.</param>
		Task<Order<Txp>> RemovePromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode);
	}

	public interface IPasswordResetsResource
	{
		/// <summary>Send a verification code. Sends a temporary verification code via email, which must subsequently be passed in a Reset Password call.</summary>
		Task SendVerificationCodeAsync(PasswordResetRequest passwordResetRequest);
		/// <summary>Reset a password by verification code.</summary>
		/// <param name="verificationCode">Verification code of the password reset.</param>
		Task ResetPasswordByVerificationCodeAsync(string verificationCode, PasswordReset passwordReset);
	}

	public interface IPaymentsResource
	{
		/// <summary>Get a single payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task<Payment> GetAsync(OrderDirection direction, string orderID, string paymentID);
		/// <summary>Get a single payment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task<Payment<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string paymentID);
		/// <summary>Get a list of payments.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<Payment<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new payment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Payment> CreateAsync(OrderDirection direction, string orderID, Payment payment);
		/// <summary>Create a new payment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		Task<Payment<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, Payment payment);
		/// <summary>Delete a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task DeleteAsync(OrderDirection direction, string orderID, string paymentID);
		/// <summary>Partially update a payment.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task<Payment> PatchAsync(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment);
		/// <summary>Partially update a payment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task<Payment<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment);
		/// <summary>Create a new payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task<Payment> CreateTransactionAsync(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction);
		/// <summary>Create a new payment transaction.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		Task<Payment<Txp>> CreateTransactionAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction);
		/// <summary>Delete a payment transaction.</summary>
		/// <param name="direction">Direction of the order, from the current user's perspective. Possible values: incoming, outgoing.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="paymentID">ID of the payment.</param>
		/// <param name="transactionID">ID of the transaction.</param>
		Task DeleteTransactionAsync(OrderDirection direction, string orderID, string paymentID, string transactionID);
	}

	public interface IPriceSchedulesResource
	{
		/// <summary>Get a single price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule> GetAsync(string priceScheduleID);
		/// <summary>Get a single price schedule.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule<Txp>> GetAsync<Txp>(string priceScheduleID);
		/// <summary>Get a list of price schedules.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<PriceSchedule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of price schedules.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<PriceSchedule<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new price schedule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<PriceSchedule> CreateAsync(PriceSchedule priceSchedule);
		/// <summary>Create a new price schedule. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<PriceSchedule<Txp>> CreateAsync<Txp>(PriceSchedule priceSchedule);
		/// <summary>Create or update a price schedule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule> SaveAsync(string priceScheduleID, PriceSchedule priceSchedule);
		/// <summary>Create or update a price schedule. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule<Txp>> SaveAsync<Txp>(string priceScheduleID, PriceSchedule priceSchedule);
		/// <summary>Delete a price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task DeleteAsync(string priceScheduleID);
		/// <summary>Partially update a price schedule.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule> PatchAsync(string priceScheduleID, PartialPriceSchedule partialPriceSchedule);
		/// <summary>Partially update a price schedule.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule<Txp>> PatchAsync<Txp>(string priceScheduleID, PartialPriceSchedule partialPriceSchedule);
		/// <summary>Create or update a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule> SavePriceBreakAsync(string priceScheduleID, PriceBreak priceBreak);
		/// <summary>Create or update a price schedule price break.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		Task<PriceSchedule<Txp>> SavePriceBreakAsync<Txp>(string priceScheduleID, PriceBreak priceBreak);
		/// <summary>Delete a price schedule price break.</summary>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="quantity">Quantity of the price schedule.</param>
		Task DeletePriceBreakAsync(string priceScheduleID, int quantity);
	}

	public interface IProductsResource
	{
		/// <summary>Get a single product.</summary>
		/// <param name="productID">ID of the product.</param>
		Task<Product> GetAsync(string productID);
		/// <summary>Get a single product.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		Task<Product<Txp>> GetAsync<Txp>(string productID);
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
		Task<ListPage<Product>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<Product<Txp>>> ListAsync<Txp>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new product. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Product> CreateAsync(Product product);
		/// <summary>Create a new product. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Product<Txp>> CreateAsync<Txp>(Product product);
		/// <summary>Create or update a product. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="productID">ID of the product.</param>
		Task<Product> SaveAsync(string productID, Product product);
		/// <summary>Create or update a product. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		Task<Product<Txp>> SaveAsync<Txp>(string productID, Product product);
		/// <summary>Delete a product.</summary>
		/// <param name="productID">ID of the product.</param>
		Task DeleteAsync(string productID);
		/// <summary>Partially update a product.</summary>
		/// <param name="productID">ID of the product.</param>
		Task<Product> PatchAsync(string productID, PartialProduct partialProduct);
		/// <summary>Partially update a product.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		Task<Product<Txp>> PatchAsync<Txp>(string productID, PartialProduct partialProduct);
		/// <summary>Generate a variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="overwriteExisting">Overwrite existing of the product.</param>
		Task<Product> GenerateVariantsAsync(string productID, bool overwriteExisting = false);
		/// <summary>Generate a variants.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="overwriteExisting">Overwrite existing of the product.</param>
		Task<Product<Txp>> GenerateVariantsAsync<Txp>(string productID, bool overwriteExisting = false);
		/// <summary>Get a list of product variants.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of product variants.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Variant<Txp>>> ListVariantsAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create or update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		Task<Variant> SaveVariantAsync(string productID, string variantID, Variant variant);
		/// <summary>Create or update a product variant.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		Task<Variant<Txp>> SaveVariantAsync<Txp>(string productID, string variantID, Variant variant);
		/// <summary>Partially update a product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		Task<Variant> PatchVariantAsync(string productID, string variantID, PartialVariant partialVariant);
		/// <summary>Partially update a product variant.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		Task<Variant<Txp>> PatchVariantAsync<Txp>(string productID, string variantID, PartialVariant partialVariant);
		/// <summary>Get a single product variant.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		Task<Variant> GetVariantAsync(string productID, string variantID);
		/// <summary>Get a single product variant.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="variantID">ID of the variant.</param>
		Task<Variant<Txp>> GetVariantAsync<Txp>(string productID, string variantID);
		/// <summary>Get a list of product suppliers.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Supplier>> ListSuppliersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of product suppliers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="productID">ID of the product.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Supplier<Txp>>> ListSuppliersAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create or update a product supplier.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		Task SaveSupplierAsync(string productID, string supplierID);
		/// <summary>Remove a supplier.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="supplierID">ID of the supplier.</param>
		Task RemoveSupplierAsync(string productID, string supplierID);
		/// <summary>Create or update a product assignment.</summary>
		Task SaveAssignmentAsync(ProductAssignment productAssignment);
		/// <summary>Get a list of product assignments.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="priceScheduleID">ID of the price schedule.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the product assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<ProductAssignment>> ListAssignmentsAsync(string productID = null, string priceScheduleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Delete a product assignment.</summary>
		/// <param name="productID">ID of the product.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string productID, string buyerID, string userID = null, string userGroupID = null);
	}

	public interface IPromotionsResource
	{
		/// <summary>Get a single promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion> GetAsync(string promotionID);
		/// <summary>Get a single promotion.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion<Txp>> GetAsync<Txp>(string promotionID);
		/// <summary>Get a list of promotions.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Promotion>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of promotions.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Promotion<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new promotion. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Promotion> CreateAsync(Promotion promotion);
		/// <summary>Create a new promotion. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Promotion<Txp>> CreateAsync<Txp>(Promotion promotion);
		/// <summary>Create or update a promotion. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion> SaveAsync(string promotionID, Promotion promotion);
		/// <summary>Create or update a promotion. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion<Txp>> SaveAsync<Txp>(string promotionID, Promotion promotion);
		/// <summary>Delete a promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		Task DeleteAsync(string promotionID);
		/// <summary>Partially update a promotion.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion> PatchAsync(string promotionID, PartialPromotion partialPromotion);
		/// <summary>Partially update a promotion.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="promotionID">ID of the promotion.</param>
		Task<Promotion<Txp>> PatchAsync<Txp>(string promotionID, PartialPromotion partialPromotion);
		/// <summary>Get a list of promotion assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the promotion assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<PromotionAssignment>> ListAssignmentsAsync(string buyerID = null, string promotionID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Create or update a promotion assignment.</summary>
		Task SaveAssignmentAsync(PromotionAssignment promotionAssignment);
		/// <summary>Delete a promotion assignment.</summary>
		/// <param name="promotionID">ID of the promotion.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string promotionID, string buyerID, string userID = null, string userGroupID = null);
	}

	public interface ISecurityProfilesResource
	{
		/// <summary>Get a single security profile.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		Task<SecurityProfile> GetAsync(string securityProfileID);
		/// <summary>Get a list of security profiles.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SecurityProfile>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<SecurityProfileAssignment>> ListAssignmentsAsync(string buyerID = null, string supplierID = null, string securityProfileID = null, string userID = null, string userGroupID = null, CommerceRole? commerceRole = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Delete a security profile assignment.</summary>
		/// <param name="securityProfileID">ID of the security profile.</param>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string securityProfileID, string buyerID = null, string userID = null, string userGroupID = null);
		/// <summary>Create or update a security profile assignment.</summary>
		Task SaveAssignmentAsync(SecurityProfileAssignment securityProfileAssignment);
	}

	public interface IShipmentsResource
	{
		/// <summary>Get a single shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment> GetAsync(string shipmentID);
		/// <summary>Get a single shipment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment<Txp>> GetAsync<Txp>(string shipmentID);
		/// <summary>Get a list of shipments.</summary>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Shipment>> ListAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of shipments.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Shipment<Txp>>> ListAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new shipment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Shipment> CreateAsync(Shipment shipment);
		/// <summary>Create a new shipment. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Shipment<Txp>> CreateAsync<Txp>(Shipment shipment);
		/// <summary>Create or update a shipment. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment> SaveAsync(string shipmentID, Shipment shipment);
		/// <summary>Create or update a shipment. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment<Txp>> SaveAsync<Txp>(string shipmentID, Shipment shipment);
		/// <summary>Delete a shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task DeleteAsync(string shipmentID);
		/// <summary>Partially update a shipment.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment> PatchAsync(string shipmentID, PartialShipment partialShipment);
		/// <summary>Partially update a shipment.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<Shipment<Txp>> PatchAsync<Txp>(string shipmentID, PartialShipment partialShipment);
		/// <summary>Get a list of shipment items.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of shipment items.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<ShipmentItem<Txp>>> ListItemsAsync<Txp>(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a single shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<ShipmentItem> GetItemAsync(string shipmentID, string orderID, string lineItemID);
		/// <summary>Get a single shipment item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task<ShipmentItem<Txp>> GetItemAsync<Txp>(string shipmentID, string orderID, string lineItemID);
		/// <summary>Create or update a shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<ShipmentItem> SaveItemAsync(string shipmentID, ShipmentItem shipmentItem);
		/// <summary>Create or update a shipment item.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="shipmentID">ID of the shipment.</param>
		Task<ShipmentItem<Txp>> SaveItemAsync<Txp>(string shipmentID, ShipmentItem shipmentItem);
		/// <summary>Delete a shipment item.</summary>
		/// <param name="shipmentID">ID of the shipment.</param>
		/// <param name="orderID">ID of the order.</param>
		/// <param name="lineItemID">ID of the line item.</param>
		Task DeleteItemAsync(string shipmentID, string orderID, string lineItemID);
	}

	public interface ISpecsResource
	{
		/// <summary>Get a single spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		Task<Spec> GetAsync(string specID);
		/// <summary>Get a single spec.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		Task<Spec<Txp>> GetAsync<Txp>(string specID);
		/// <summary>Get a list of specs.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Spec>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of specs.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Spec<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new spec. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Spec> CreateAsync(Spec spec);
		/// <summary>Create a new spec. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Spec<Txp>> CreateAsync<Txp>(Spec spec);
		/// <summary>Create or update a spec. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="specID">ID of the spec.</param>
		Task<Spec> SaveAsync(string specID, Spec spec);
		/// <summary>Create or update a spec. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		Task<Spec<Txp>> SaveAsync<Txp>(string specID, Spec spec);
		/// <summary>Delete a spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		Task DeleteAsync(string specID);
		/// <summary>Partially update a spec.</summary>
		/// <param name="specID">ID of the spec.</param>
		Task<Spec> PatchAsync(string specID, PartialSpec partialSpec);
		/// <summary>Partially update a spec.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		Task<Spec<Txp>> PatchAsync<Txp>(string specID, PartialSpec partialSpec);
		/// <summary>Get a list of spec product assignments.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Delete a spec product assignment.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="productID">ID of the product.</param>
		Task DeleteProductAssignmentAsync(string specID, string productID);
		/// <summary>Create or update a spec product assignment.</summary>
		Task SaveProductAssignmentAsync(SpecProductAssignment specProductAssignment);
		/// <summary>Create a new spec option. A Spec can have multiple Options-- for example, if the spec is called 'Color', the options might be 'Blue', 'Red', and 'Green'. </summary>
		/// <param name="specID">ID of the spec.</param>
		Task<SpecOption> CreateOptionAsync(string specID, SpecOption specOption);
		/// <summary>Create a new spec option. A Spec can have multiple Options-- for example, if the spec is called 'Color', the options might be 'Blue', 'Red', and 'Green'. </summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		Task<SpecOption<Txp>> CreateOptionAsync<Txp>(string specID, SpecOption specOption);
		/// <summary>Get a list of spec options.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpecOption>> ListOptionsAsync(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of spec options.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpecOption<Txp>>> ListOptionsAsync<Txp>(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create or update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task<SpecOption> SaveOptionAsync(string specID, string optionID, SpecOption specOption);
		/// <summary>Create or update a spec option.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task<SpecOption<Txp>> SaveOptionAsync<Txp>(string specID, string optionID, SpecOption specOption);
		/// <summary>Partially update a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task<SpecOption> PatchOptionAsync(string specID, string optionID, PartialSpecOption partialSpecOption);
		/// <summary>Partially update a spec option.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task<SpecOption<Txp>> PatchOptionAsync<Txp>(string specID, string optionID, PartialSpecOption partialSpecOption);
		/// <summary>Get a single spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task<SpecOption> GetOptionAsync(string specID, string optionID);
		/// <summary>Get a single spec option.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task<SpecOption<Txp>> GetOptionAsync<Txp>(string specID, string optionID);
		/// <summary>Delete a spec option.</summary>
		/// <param name="specID">ID of the spec.</param>
		/// <param name="optionID">ID of the option.</param>
		Task DeleteOptionAsync(string specID, string optionID);
	}

	public interface ISpendingAccountsResource
	{
		/// <summary>Get a single spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount> GetAsync(string buyerID, string spendingAccountID);
		/// <summary>Get a single spending account.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount<Txp>> GetAsync<Txp>(string buyerID, string spendingAccountID);
		/// <summary>Get a list of spending accounts.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpendingAccount>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of spending accounts.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<SpendingAccount<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new spending account. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<SpendingAccount> CreateAsync(string buyerID, SpendingAccount spendingAccount);
		/// <summary>Create a new spending account. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<SpendingAccount<Txp>> CreateAsync<Txp>(string buyerID, SpendingAccount spendingAccount);
		/// <summary>Create or update a spending account. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount> SaveAsync(string buyerID, string spendingAccountID, SpendingAccount spendingAccount);
		/// <summary>Create or update a spending account. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount<Txp>> SaveAsync<Txp>(string buyerID, string spendingAccountID, SpendingAccount spendingAccount);
		/// <summary>Delete a spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task DeleteAsync(string buyerID, string spendingAccountID);
		/// <summary>Partially update a spending account.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount> PatchAsync(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount);
		/// <summary>Partially update a spending account.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		Task<SpendingAccount<Txp>> PatchAsync<Txp>(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount);
		/// <summary>Get a list of spending account assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="level">Level of the spending account assignment. Possible values: User, Group, Company.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<SpendingAccountAssignment>> ListAssignmentsAsync(string buyerID, string spendingAccountID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null);
		/// <summary>Create or update a spending account assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task SaveAssignmentAsync(string buyerID, SpendingAccountAssignment spendingAccountAssignment);
		/// <summary>Delete a spending account assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="spendingAccountID">ID of the spending account.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAssignmentAsync(string buyerID, string spendingAccountID, string userID = null, string userGroupID = null);
	}

	public interface ISuppliersResource
	{
		/// <summary>Get a single supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<Supplier> GetAsync(string supplierID);
		/// <summary>Get a single supplier.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<Supplier<Txp>> GetAsync<Txp>(string supplierID);
		/// <summary>Get a list of suppliers.</summary>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Supplier>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of suppliers.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<Supplier<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new supplier. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		Task<Supplier> CreateAsync(Supplier supplier);
		/// <summary>Create a new supplier. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		Task<Supplier<Txp>> CreateAsync<Txp>(Supplier supplier);
		/// <summary>Delete a supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task DeleteAsync(string supplierID);
		/// <summary>Create or update a supplier. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<Supplier> SaveAsync(string supplierID, Supplier supplier);
		/// <summary>Create or update a supplier. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<Supplier<Txp>> SaveAsync<Txp>(string supplierID, Supplier supplier);
		/// <summary>Partially update a supplier.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<Supplier> PatchAsync(string supplierID, PartialSupplier partialSupplier);
		/// <summary>Partially update a supplier.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<Supplier<Txp>> PatchAsync<Txp>(string supplierID, PartialSupplier partialSupplier);
	}

	public interface ISupplierUserGroupsResource
	{
		/// <summary>Get a single supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> GetAsync(string supplierID, string userGroupID);
		/// <summary>Get a single supplier user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> GetAsync<Txp>(string supplierID, string userGroupID);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of supplier user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new supplier user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<UserGroup> CreateAsync(string supplierID, UserGroup userGroup);
		/// <summary>Create a new supplier user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<UserGroup<Txp>> CreateAsync<Txp>(string supplierID, UserGroup userGroup);
		/// <summary>Create or update a supplier user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> SaveAsync(string supplierID, string userGroupID, UserGroup userGroup);
		/// <summary>Create or update a supplier user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> SaveAsync<Txp>(string supplierID, string userGroupID, UserGroup userGroup);
		/// <summary>Delete a supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAsync(string supplierID, string userGroupID);
		/// <summary>Partially update a supplier user group.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> PatchAsync(string supplierID, string userGroupID, PartialUserGroup partialUserGroup);
		/// <summary>Partially update a supplier user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> PatchAsync<Txp>(string supplierID, string userGroupID, PartialUserGroup partialUserGroup);
		/// <summary>Get a list of supplier user group user assignments.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string supplierID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20);
		/// <summary>Delete a supplier user group user assignment.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		Task DeleteUserAssignmentAsync(string supplierID, string userGroupID, string userID);
		/// <summary>Create or update a supplier user group user assignment.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task SaveUserAssignmentAsync(string supplierID, UserGroupAssignment userGroupAssignment);
	}

	public interface ISupplierUsersResource
	{
		/// <summary>Get a single supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User> GetAsync(string supplierID, string userID);
		/// <summary>Get a single supplier user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> GetAsync<Txp>(string supplierID, string userID);
		/// <summary>Get a list of supplier users.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<User>> ListAsync(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new supplier user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<User> CreateAsync(string supplierID, User user);
		/// <summary>Create a new supplier user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		Task<User<Txp>> CreateAsync<Txp>(string supplierID, User user);
		/// <summary>Create or update a supplier user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User> SaveAsync(string supplierID, string userID, User user);
		/// <summary>Create or update a supplier user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> SaveAsync<Txp>(string supplierID, string userID, User user);
		/// <summary>Delete a supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task DeleteAsync(string supplierID, string userID);
		/// <summary>Partially update a supplier user.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User> PatchAsync(string supplierID, string userID, PartialUser partialUser);
		/// <summary>Partially update a supplier user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> PatchAsync<Txp>(string supplierID, string userID, PartialUser partialUser);
		/// <summary>Get a single supplier user access token.</summary>
		/// <param name="supplierID">ID of the supplier.</param>
		/// <param name="userID">ID of the user.</param>
		Task<AccessToken> GetAccessTokenAsync(string supplierID, string userID, ImpersonateTokenRequest impersonateTokenRequest);
	}

	public interface IUserGroupsResource
	{
		/// <summary>Get a single user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> GetAsync(string buyerID, string userGroupID);
		/// <summary>Get a single user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> GetAsync<Txp>(string buyerID, string userGroupID);
		/// <summary>Get a list of user groups.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Get a list of user groups.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<UserGroup> CreateAsync(string buyerID, UserGroup userGroup);
		/// <summary>Create a new user group. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<UserGroup<Txp>> CreateAsync<Txp>(string buyerID, UserGroup userGroup);
		/// <summary>Create or update a user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> SaveAsync(string buyerID, string userGroupID, UserGroup userGroup);
		/// <summary>Create or update a user group. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> SaveAsync<Txp>(string buyerID, string userGroupID, UserGroup userGroup);
		/// <summary>Delete a user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task DeleteAsync(string buyerID, string userGroupID);
		/// <summary>Partially update a user group.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup> PatchAsync(string buyerID, string userGroupID, PartialUserGroup partialUserGroup);
		/// <summary>Partially update a user group.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		Task<UserGroup<Txp>> PatchAsync<Txp>(string buyerID, string userGroupID, PartialUserGroup partialUserGroup);
		/// <summary>Get a list of user group user assignments.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string buyerID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20);
		/// <summary>Delete a user group user assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="userID">ID of the user.</param>
		Task DeleteUserAssignmentAsync(string buyerID, string userGroupID, string userID);
		/// <summary>Create or update a user group user assignment.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task SaveUserAssignmentAsync(string buyerID, UserGroupAssignment userGroupAssignment);
	}

	public interface IUsersResource
	{
		/// <summary>Get a single user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User> GetAsync(string buyerID, string userID);
		/// <summary>Get a single user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> GetAsync<Txp>(string buyerID, string userID);
		/// <summary>Get a list of users.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userGroupID">ID of the user group.</param>
		/// <param name="search">Word or phrase to search for.</param>
		/// <param name="searchOn">Comma-delimited list of fields to search on.</param>
		/// <param name="sortBy">Comma-delimited list of fields to sort by.</param>
		/// <param name="page">Page of results to return. Default: 1</param>
		/// <param name="pageSize">Number of results to return per page. Default: 20, max: 100.</param>
		/// <param name="filters">Any additional key/value pairs passed in the query string are interpretted as filters. Valid keys are top-level properties of the returned model or 'xp.???'</param>
		Task<ListPage<User>> ListAsync(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
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
		Task<ListPage<User<Txp>>> ListAsync<Txp>(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null);
		/// <summary>Create a new user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<User> CreateAsync(string buyerID, User user);
		/// <summary>Create a new user. If ID is provided and an object with that ID already exists, a 409 (conflict) error is returned.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		Task<User<Txp>> CreateAsync<Txp>(string buyerID, User user);
		/// <summary>Create or update a user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User> SaveAsync(string buyerID, string userID, User user);
		/// <summary>Create or update a user. If an object with the same ID already exists, it will be overwritten.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> SaveAsync<Txp>(string buyerID, string userID, User user);
		/// <summary>Delete a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task DeleteAsync(string buyerID, string userID);
		/// <summary>Partially update a user.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User> PatchAsync(string buyerID, string userID, PartialUser partialUser);
		/// <summary>Partially update a user.</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<User<Txp>> PatchAsync<Txp>(string buyerID, string userID, PartialUser partialUser);
		/// <summary>Move a user to a different buyer</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="newBuyerID">ID of the new buyer.</param>
		/// <param name="orders">Orders of the user. Possible values: None, Unsubmitted, All.</param>
		Task<User> MoveAsync(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders);
		/// <summary>Move a user to a different buyer</summary>
		/// <typeparam name="Txp">Type used as a container for extended properties (xp).</typeparam>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		/// <param name="newBuyerID">ID of the new buyer.</param>
		/// <param name="orders">Orders of the user. Possible values: None, Unsubmitted, All.</param>
		Task<User<Txp>> MoveAsync<Txp>(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders);
		/// <summary>Get a single user access token.</summary>
		/// <param name="buyerID">ID of the buyer.</param>
		/// <param name="userID">ID of the user.</param>
		Task<AccessToken> GetAccessTokenAsync(string buyerID, string userID, ImpersonateTokenRequest impersonateTokenRequest);
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
		public Task<Address> GetAsync(string buyerID, string addressID) => Request("v1", "buyers", buyerID, "addresses", addressID).GetJsonAsync<Address>();
		public Task<Address<Txp>> GetAsync<Txp>(string buyerID, string addressID) => Request("v1", "buyers", buyerID, "addresses", addressID).GetJsonAsync<Address<Txp>>();
		public Task<ListPage<Address>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "addresses").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address>>();
		public Task<ListPage<Address<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "addresses").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address<Txp>>>();
		public Task<Address> CreateAsync(string buyerID, Address address) => Request("v1", "buyers", buyerID, "addresses").PostJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> CreateAsync<Txp>(string buyerID, Address address) => Request("v1", "buyers", buyerID, "addresses").PostJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task<Address> SaveAsync(string buyerID, string addressID, Address address) => Request("v1", "buyers", buyerID, "addresses", addressID).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> SaveAsync<Txp>(string buyerID, string addressID, Address address) => Request("v1", "buyers", buyerID, "addresses", addressID).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task DeleteAsync(string buyerID, string addressID) => Request("v1", "buyers", buyerID, "addresses", addressID).DeleteAsync();
		public Task<Address> PatchAsync(string buyerID, string addressID, PartialAddress partialAddress) => Request("v1", "buyers", buyerID, "addresses", addressID).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address>();
		public Task<Address<Txp>> PatchAsync<Txp>(string buyerID, string addressID, PartialAddress partialAddress) => Request("v1", "buyers", buyerID, "addresses", addressID).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address<Txp>>();
		public Task<ListPage<AddressAssignment>> ListAssignmentsAsync(string buyerID, string addressID = null, string userID = null, string userGroupID = null, PartyType? level = null, bool? isShipping = null, bool? isBilling = null, int? page = null, int? pageSize = null) => Request("v1", "buyers", buyerID, "addresses", "assignments").SetQueryParams(new { addressID, userID, userGroupID, level, isShipping, isBilling, page, pageSize }).GetJsonAsync<ListPage<AddressAssignment>>();
		public Task DeleteAssignmentAsync(string buyerID, string addressID, string userID = null, string userGroupID = null) => Request("v1", "buyers", buyerID, "addresses", addressID, "assignments").SetQueryParams(new { userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string buyerID, AddressAssignment addressAssignment) => Request("v1", "buyers", buyerID, "addresses", "assignments").PostJsonAsync(ValidateModel(addressAssignment));
	}

	public class AdminAddressesResource : OrderCloudResource, IAdminAddressesResource
	{
		internal AdminAddressesResource(OrderCloudClient client) : base(client) { }
		public Task<Address> GetAsync(string addressID) => Request("v1", "addresses", addressID).GetJsonAsync<Address>();
		public Task<Address<Txp>> GetAsync<Txp>(string addressID) => Request("v1", "addresses", addressID).GetJsonAsync<Address<Txp>>();
		public Task<ListPage<Address>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "addresses").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address>>();
		public Task<ListPage<Address<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "addresses").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Address<Txp>>>();
		public Task<Address> CreateAsync(Address address) => Request("v1", "addresses").PostJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> CreateAsync<Txp>(Address address) => Request("v1", "addresses").PostJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task<Address> SaveAsync(string addressID, Address address) => Request("v1", "addresses", addressID).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address>();
		public Task<Address<Txp>> SaveAsync<Txp>(string addressID, Address address) => Request("v1", "addresses", addressID).PutJsonAsync(ValidateModel(address)).ReceiveJson<Address<Txp>>();
		public Task DeleteAsync(string addressID) => Request("v1", "addresses", addressID).DeleteAsync();
		public Task<Address> PatchAsync(string addressID, PartialAddress partialAddress) => Request("v1", "addresses", addressID).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address>();
		public Task<Address<Txp>> PatchAsync<Txp>(string addressID, PartialAddress partialAddress) => Request("v1", "addresses", addressID).PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Address<Txp>>();
	}

	public class AdminUserGroupsResource : OrderCloudResource, IAdminUserGroupsResource
	{
		internal AdminUserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string userGroupID) => Request("v1", "usergroups", userGroupID).GetJsonAsync<UserGroup>();
		public Task<UserGroup<Txp>> GetAsync<Txp>(string userGroupID) => Request("v1", "usergroups", userGroupID).GetJsonAsync<UserGroup<Txp>>();
		public Task<ListPage<UserGroup>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<UserGroup> CreateAsync(UserGroup userGroup) => Request("v1", "usergroups").PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> CreateAsync<Txp>(UserGroup userGroup) => Request("v1", "usergroups").PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<UserGroup> SaveAsync(string userGroupID, UserGroup userGroup) => Request("v1", "usergroups", userGroupID).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> SaveAsync<Txp>(string userGroupID, UserGroup userGroup) => Request("v1", "usergroups", userGroupID).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task DeleteAsync(string userGroupID) => Request("v1", "usergroups", userGroupID).DeleteAsync();
		public Task<UserGroup> PatchAsync(string userGroupID, PartialUserGroup partialUserGroup) => Request("v1", "usergroups", userGroupID).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> PatchAsync<Txp>(string userGroupID, PartialUserGroup partialUserGroup) => Request("v1", "usergroups", userGroupID).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string userGroupID = null, string userID = null, int page = 1, int pageSize = 20) => Request("v1", "usergroups", "assignments").SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string userGroupID, string userID) => Request("v1", "usergroups", userGroupID, "assignments", userID).DeleteAsync();
		public Task SaveUserAssignmentAsync(UserGroupAssignment userGroupAssignment) => Request("v1", "usergroups", "assignments").PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class AdminUsersResource : OrderCloudResource, IAdminUsersResource
	{
		internal AdminUsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string userID) => Request("v1", "adminusers", userID).GetJsonAsync<User>();
		public Task<User<Txp>> GetAsync<Txp>(string userID) => Request("v1", "adminusers", userID).GetJsonAsync<User<Txp>>();
		public Task<ListPage<User>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "adminusers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "adminusers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<User> CreateAsync(User user) => Request("v1", "adminusers").PostJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> CreateAsync<Txp>(User user) => Request("v1", "adminusers").PostJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task<User> SaveAsync(string userID, User user) => Request("v1", "adminusers", userID).PutJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> SaveAsync<Txp>(string userID, User user) => Request("v1", "adminusers", userID).PutJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task DeleteAsync(string userID) => Request("v1", "adminusers", userID).DeleteAsync();
		public Task<User> PatchAsync(string userID, PartialUser partialUser) => Request("v1", "adminusers", userID).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User>();
		public Task<User<Txp>> PatchAsync<Txp>(string userID, PartialUser partialUser) => Request("v1", "adminusers", userID).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User<Txp>>();
	}

	public class ApprovalRulesResource : OrderCloudResource, IApprovalRulesResource
	{
		internal ApprovalRulesResource(OrderCloudClient client) : base(client) { }
		public Task<ApprovalRule> GetAsync(string buyerID, string approvalRuleID) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).GetJsonAsync<ApprovalRule>();
		public Task<ApprovalRule<Txp>> GetAsync<Txp>(string buyerID, string approvalRuleID) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).GetJsonAsync<ApprovalRule<Txp>>();
		public Task<ListPage<ApprovalRule>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "approvalrules").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ApprovalRule>>();
		public Task<ListPage<ApprovalRule<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "approvalrules").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ApprovalRule<Txp>>>();
		public Task<ApprovalRule> CreateAsync(string buyerID, ApprovalRule approvalRule) => Request("v1", "buyers", buyerID, "approvalrules").PostJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule>();
		public Task<ApprovalRule<Txp>> CreateAsync<Txp>(string buyerID, ApprovalRule approvalRule) => Request("v1", "buyers", buyerID, "approvalrules").PostJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule<Txp>>();
		public Task<ApprovalRule> SaveAsync(string buyerID, string approvalRuleID, ApprovalRule approvalRule) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).PutJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule>();
		public Task<ApprovalRule<Txp>> SaveAsync<Txp>(string buyerID, string approvalRuleID, ApprovalRule approvalRule) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).PutJsonAsync(ValidateModel(approvalRule)).ReceiveJson<ApprovalRule<Txp>>();
		public Task DeleteAsync(string buyerID, string approvalRuleID) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).DeleteAsync();
		public Task<ApprovalRule> PatchAsync(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).PatchJsonAsync(ValidateModel(partialApprovalRule)).ReceiveJson<ApprovalRule>();
		public Task<ApprovalRule<Txp>> PatchAsync<Txp>(string buyerID, string approvalRuleID, PartialApprovalRule partialApprovalRule) => Request("v1", "buyers", buyerID, "approvalrules", approvalRuleID).PatchJsonAsync(ValidateModel(partialApprovalRule)).ReceiveJson<ApprovalRule<Txp>>();
	}

	public class BuyersResource : OrderCloudResource, IBuyersResource
	{
		internal BuyersResource(OrderCloudClient client) : base(client) { }
		public Task<Buyer> GetAsync(string buyerID) => Request("v1", "buyers", buyerID).GetJsonAsync<Buyer>();
		public Task<Buyer<Txp>> GetAsync<Txp>(string buyerID) => Request("v1", "buyers", buyerID).GetJsonAsync<Buyer<Txp>>();
		public Task<ListPage<Buyer>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Buyer>>();
		public Task<ListPage<Buyer<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Buyer<Txp>>>();
		public Task<Buyer> CreateAsync(Buyer buyer) => Request("v1", "buyers").PostJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer>();
		public Task<Buyer<Txp>> CreateAsync<Txp>(Buyer buyer) => Request("v1", "buyers").PostJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer<Txp>>();
		public Task DeleteAsync(string buyerID) => Request("v1", "buyers", buyerID).DeleteAsync();
		public Task<Buyer> SaveAsync(string buyerID, Buyer buyer) => Request("v1", "buyers", buyerID).PutJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer>();
		public Task<Buyer<Txp>> SaveAsync<Txp>(string buyerID, Buyer buyer) => Request("v1", "buyers", buyerID).PutJsonAsync(ValidateModel(buyer)).ReceiveJson<Buyer<Txp>>();
		public Task<Buyer> PatchAsync(string buyerID, PartialBuyer partialBuyer) => Request("v1", "buyers", buyerID).PatchJsonAsync(ValidateModel(partialBuyer)).ReceiveJson<Buyer>();
		public Task<Buyer<Txp>> PatchAsync<Txp>(string buyerID, PartialBuyer partialBuyer) => Request("v1", "buyers", buyerID).PatchJsonAsync(ValidateModel(partialBuyer)).ReceiveJson<Buyer<Txp>>();
	}

	public class CatalogsResource : OrderCloudResource, ICatalogsResource
	{
		internal CatalogsResource(OrderCloudClient client) : base(client) { }
		public Task<Catalog> GetAsync(string catalogID) => Request("v1", "catalogs", catalogID).GetJsonAsync<Catalog>();
		public Task<Catalog<Txp>> GetAsync<Txp>(string catalogID) => Request("v1", "catalogs", catalogID).GetJsonAsync<Catalog<Txp>>();
		public Task<ListPage<Catalog>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "catalogs").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog>>();
		public Task<ListPage<Catalog<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "catalogs").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog<Txp>>>();
		public Task<Catalog> CreateAsync(Catalog catalog) => Request("v1", "catalogs").PostJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog>();
		public Task<Catalog<Txp>> CreateAsync<Txp>(Catalog catalog) => Request("v1", "catalogs").PostJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog<Txp>>();
		public Task<Catalog> SaveAsync(string catalogID, Catalog catalog) => Request("v1", "catalogs", catalogID).PutJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog>();
		public Task<Catalog<Txp>> SaveAsync<Txp>(string catalogID, Catalog catalog) => Request("v1", "catalogs", catalogID).PutJsonAsync(ValidateModel(catalog)).ReceiveJson<Catalog<Txp>>();
		public Task DeleteAsync(string catalogID) => Request("v1", "catalogs", catalogID).DeleteAsync();
		public Task<Catalog> PatchAsync(string catalogID, PartialCatalog partialCatalog) => Request("v1", "catalogs", catalogID).PatchJsonAsync(ValidateModel(partialCatalog)).ReceiveJson<Catalog>();
		public Task<Catalog<Txp>> PatchAsync<Txp>(string catalogID, PartialCatalog partialCatalog) => Request("v1", "catalogs", catalogID).PatchJsonAsync(ValidateModel(partialCatalog)).ReceiveJson<Catalog<Txp>>();
		public Task<ListPage<CatalogAssignment>> ListAssignmentsAsync(string catalogID = null, string buyerID = null, int page = 1, int pageSize = 20) => Request("v1", "catalogs", "assignments").SetQueryParams(new { catalogID, buyerID, page, pageSize }).GetJsonAsync<ListPage<CatalogAssignment>>();
		public Task SaveAssignmentAsync(CatalogAssignment catalogAssignment) => Request("v1", "catalogs", "assignments").PostJsonAsync(ValidateModel(catalogAssignment));
		public Task DeleteAssignmentAsync(string catalogID, string buyerID) => Request("v1", "catalogs", catalogID, "assignments").SetQueryParams(new { buyerID }).DeleteAsync();
		public Task<ListPage<ProductCatalogAssignment>> ListProductAssignmentsAsync(string catalogID = null, string productID = null, int page = 1, int pageSize = 20) => Request("v1", "catalogs", "productassignments").SetQueryParams(new { catalogID, productID, page, pageSize }).GetJsonAsync<ListPage<ProductCatalogAssignment>>();
		public Task SaveProductAssignmentAsync(ProductCatalogAssignment productCatalogAssignment) => Request("v1", "catalogs", "productassignments").PostJsonAsync(ValidateModel(productCatalogAssignment));
		public Task DeleteProductAssignmentAsync(string catalogID, string productID) => Request("v1", "catalogs", catalogID, "productassignments", productID).DeleteAsync();
	}

	public class CategoriesResource : OrderCloudResource, ICategoriesResource
	{
		internal CategoriesResource(OrderCloudClient client) : base(client) { }
		public Task<Category> GetAsync(string catalogID, string categoryID) => Request("v1", "catalogs", catalogID, "categories", categoryID).GetJsonAsync<Category>();
		public Task<Category<Txp>> GetAsync<Txp>(string catalogID, string categoryID) => Request("v1", "catalogs", catalogID, "categories", categoryID).GetJsonAsync<Category<Txp>>();
		public Task<ListPage<Category>> ListAsync(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "catalogs", catalogID, "categories").SetQueryParams(new { depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category>>();
		public Task<ListPage<Category<Txp>>> ListAsync<Txp>(string catalogID, string depth = "1", string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "catalogs", catalogID, "categories").SetQueryParams(new { depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category<Txp>>>();
		public Task<Category> CreateAsync(string catalogID, Category category) => Request("v1", "catalogs", catalogID, "categories").PostJsonAsync(ValidateModel(category)).ReceiveJson<Category>();
		public Task<Category<Txp>> CreateAsync<Txp>(string catalogID, Category category) => Request("v1", "catalogs", catalogID, "categories").PostJsonAsync(ValidateModel(category)).ReceiveJson<Category<Txp>>();
		public Task<Category> SaveAsync(string catalogID, string categoryID, Category category) => Request("v1", "catalogs", catalogID, "categories", categoryID).PutJsonAsync(ValidateModel(category)).ReceiveJson<Category>();
		public Task<Category<Txp>> SaveAsync<Txp>(string catalogID, string categoryID, Category category) => Request("v1", "catalogs", catalogID, "categories", categoryID).PutJsonAsync(ValidateModel(category)).ReceiveJson<Category<Txp>>();
		public Task DeleteAsync(string catalogID, string categoryID) => Request("v1", "catalogs", catalogID, "categories", categoryID).DeleteAsync();
		public Task<Category> PatchAsync(string catalogID, string categoryID, PartialCategory partialCategory) => Request("v1", "catalogs", catalogID, "categories", categoryID).PatchJsonAsync(ValidateModel(partialCategory)).ReceiveJson<Category>();
		public Task<Category<Txp>> PatchAsync<Txp>(string catalogID, string categoryID, PartialCategory partialCategory) => Request("v1", "catalogs", catalogID, "categories", categoryID).PatchJsonAsync(ValidateModel(partialCategory)).ReceiveJson<Category<Txp>>();
		public Task<ListPage<CategoryAssignment>> ListAssignmentsAsync(string catalogID, string categoryID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "catalogs", catalogID, "categories", "assignments").SetQueryParams(new { categoryID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CategoryAssignment>>();
		public Task DeleteAssignmentAsync(string catalogID, string categoryID, string buyerID, string userID = null, string userGroupID = null) => Request("v1", "catalogs", catalogID, "categories", categoryID, "assignments").SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string catalogID, CategoryAssignment categoryAssignment) => Request("v1", "catalogs", catalogID, "categories", "assignments").PostJsonAsync(ValidateModel(categoryAssignment));
		public Task<ListPage<CategoryProductAssignment>> ListProductAssignmentsAsync(string catalogID, string categoryID = null, string productID = null, int page = 1, int pageSize = 20) => Request("v1", "catalogs", catalogID, "categories", "productassignments").SetQueryParams(new { categoryID, productID, page, pageSize }).GetJsonAsync<ListPage<CategoryProductAssignment>>();
		public Task SaveProductAssignmentAsync(string catalogID, CategoryProductAssignment categoryProductAssignment) => Request("v1", "catalogs", catalogID, "categories", "productassignments").PostJsonAsync(ValidateModel(categoryProductAssignment));
		public Task DeleteProductAssignmentAsync(string catalogID, string categoryID, string productID) => Request("v1", "catalogs", catalogID, "categories", categoryID, "productassignments", productID).DeleteAsync();
	}

	public class CostCentersResource : OrderCloudResource, ICostCentersResource
	{
		internal CostCentersResource(OrderCloudClient client) : base(client) { }
		public Task<CostCenter> GetAsync(string buyerID, string costCenterID) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).GetJsonAsync<CostCenter>();
		public Task<CostCenter<Txp>> GetAsync<Txp>(string buyerID, string costCenterID) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).GetJsonAsync<CostCenter<Txp>>();
		public Task<ListPage<CostCenter>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "costcenters").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter>>();
		public Task<ListPage<CostCenter<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "costcenters").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter<Txp>>>();
		public Task<CostCenter> CreateAsync(string buyerID, CostCenter costCenter) => Request("v1", "buyers", buyerID, "costcenters").PostJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter>();
		public Task<CostCenter<Txp>> CreateAsync<Txp>(string buyerID, CostCenter costCenter) => Request("v1", "buyers", buyerID, "costcenters").PostJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter<Txp>>();
		public Task<CostCenter> SaveAsync(string buyerID, string costCenterID, CostCenter costCenter) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).PutJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter>();
		public Task<CostCenter<Txp>> SaveAsync<Txp>(string buyerID, string costCenterID, CostCenter costCenter) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).PutJsonAsync(ValidateModel(costCenter)).ReceiveJson<CostCenter<Txp>>();
		public Task DeleteAsync(string buyerID, string costCenterID) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).DeleteAsync();
		public Task<CostCenter> PatchAsync(string buyerID, string costCenterID, PartialCostCenter partialCostCenter) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).PatchJsonAsync(ValidateModel(partialCostCenter)).ReceiveJson<CostCenter>();
		public Task<CostCenter<Txp>> PatchAsync<Txp>(string buyerID, string costCenterID, PartialCostCenter partialCostCenter) => Request("v1", "buyers", buyerID, "costcenters", costCenterID).PatchJsonAsync(ValidateModel(partialCostCenter)).ReceiveJson<CostCenter<Txp>>();
		public Task<ListPage<CostCenterAssignment>> ListAssignmentsAsync(string buyerID, string costCenterID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "buyers", buyerID, "costcenters", "assignments").SetQueryParams(new { costCenterID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CostCenterAssignment>>();
		public Task DeleteAssignmentAsync(string buyerID, string costCenterID, string userID = null, string userGroupID = null) => Request("v1", "buyers", buyerID, "costcenters", costCenterID, "assignments").SetQueryParams(new { userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(string buyerID, CostCenterAssignment costCenterAssignment) => Request("v1", "buyers", buyerID, "costcenters", "assignments").PostJsonAsync(ValidateModel(costCenterAssignment));
	}

	public class CreditCardsResource : OrderCloudResource, ICreditCardsResource
	{
		internal CreditCardsResource(OrderCloudClient client) : base(client) { }
		public Task<CreditCard> GetAsync(string buyerID, string creditCardID) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).GetJsonAsync<CreditCard>();
		public Task<CreditCard<Txp>> GetAsync<Txp>(string buyerID, string creditCardID) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).GetJsonAsync<CreditCard<Txp>>();
		public Task<ListPage<CreditCard>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "creditcards").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CreditCard>>();
		public Task<ListPage<CreditCard<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "creditcards").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CreditCard<Txp>>>();
		public Task<CreditCard> CreateAsync(string buyerID, CreditCard creditCard) => Request("v1", "buyers", buyerID, "creditcards").PostJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard>();
		public Task<CreditCard<Txp>> CreateAsync<Txp>(string buyerID, CreditCard creditCard) => Request("v1", "buyers", buyerID, "creditcards").PostJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard<Txp>>();
		public Task<CreditCard> SaveAsync(string buyerID, string creditCardID, CreditCard creditCard) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).PutJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard>();
		public Task<CreditCard<Txp>> SaveAsync<Txp>(string buyerID, string creditCardID, CreditCard creditCard) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).PutJsonAsync(ValidateModel(creditCard)).ReceiveJson<CreditCard<Txp>>();
		public Task DeleteAsync(string buyerID, string creditCardID) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).DeleteAsync();
		public Task<CreditCard> PatchAsync(string buyerID, string creditCardID, PartialCreditCard partialCreditCard) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).PatchJsonAsync(ValidateModel(partialCreditCard)).ReceiveJson<CreditCard>();
		public Task<CreditCard<Txp>> PatchAsync<Txp>(string buyerID, string creditCardID, PartialCreditCard partialCreditCard) => Request("v1", "buyers", buyerID, "creditcards", creditCardID).PatchJsonAsync(ValidateModel(partialCreditCard)).ReceiveJson<CreditCard<Txp>>();
		public Task<ListPage<CreditCardAssignment>> ListAssignmentsAsync(string buyerID, string creditCardID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "buyers", buyerID, "creditcards", "assignments").SetQueryParams(new { creditCardID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<CreditCardAssignment>>();
		public Task SaveAssignmentAsync(string buyerID, CreditCardAssignment creditCardAssignment) => Request("v1", "buyers", buyerID, "creditcards", "assignments").PostJsonAsync(ValidateModel(creditCardAssignment));
		public Task DeleteAssignmentAsync(string buyerID, string creditCardID, string userID = null, string userGroupID = null) => Request("v1", "buyers", buyerID, "creditcards", creditCardID, "assignments").SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class ImpersonationConfigsResource : OrderCloudResource, IImpersonationConfigsResource
	{
		internal ImpersonationConfigsResource(OrderCloudClient client) : base(client) { }
		public Task<ImpersonationConfig> GetAsync(string impersonationConfigID) => Request("v1", "impersonationconfig", impersonationConfigID).GetJsonAsync<ImpersonationConfig>();
		public Task<ListPage<ImpersonationConfig>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "impersonationconfig").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ImpersonationConfig>>();
		public Task<ImpersonationConfig> CreateAsync(ImpersonationConfig impersonationConfig) => Request("v1", "impersonationconfig").PostJsonAsync(ValidateModel(impersonationConfig)).ReceiveJson<ImpersonationConfig>();
		public Task DeleteAsync(string impersonationConfigID) => Request("v1", "impersonationconfig", impersonationConfigID).DeleteAsync();
		public Task<ImpersonationConfig> SaveAsync(string impersonationConfigID, ImpersonationConfig impersonationConfig) => Request("v1", "impersonationconfig", impersonationConfigID).PutJsonAsync(ValidateModel(impersonationConfig)).ReceiveJson<ImpersonationConfig>();
		public Task<ImpersonationConfig> PatchAsync(string impersonationConfigID, PartialImpersonationConfig partialImpersonationConfig) => Request("v1", "impersonationconfig", impersonationConfigID).PatchJsonAsync(ValidateModel(partialImpersonationConfig)).ReceiveJson<ImpersonationConfig>();
	}

	public class IncrementorsResource : OrderCloudResource, IIncrementorsResource
	{
		internal IncrementorsResource(OrderCloudClient client) : base(client) { }
		public Task<Incrementor> GetAsync(string incrementorID) => Request("v1", "incrementors", incrementorID).GetJsonAsync<Incrementor>();
		public Task<ListPage<Incrementor>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "incrementors").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Incrementor>>();
		public Task<Incrementor> CreateAsync(Incrementor incrementor) => Request("v1", "incrementors").PostJsonAsync(ValidateModel(incrementor)).ReceiveJson<Incrementor>();
		public Task<Incrementor> SaveAsync(string incrementorID, Incrementor incrementor) => Request("v1", "incrementors", incrementorID).PutJsonAsync(ValidateModel(incrementor)).ReceiveJson<Incrementor>();
		public Task DeleteAsync(string incrementorID) => Request("v1", "incrementors", incrementorID).DeleteAsync();
		public Task<Incrementor> PatchAsync(string incrementorID, PartialIncrementor partialIncrementor) => Request("v1", "incrementors", incrementorID).PatchJsonAsync(ValidateModel(partialIncrementor)).ReceiveJson<Incrementor>();
	}

	public class LineItemsResource : OrderCloudResource, ILineItemsResource
	{
		internal LineItemsResource(OrderCloudClient client) : base(client) { }
		public Task<LineItem> GetAsync(OrderDirection direction, string orderID, string lineItemID) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).GetJsonAsync<LineItem>();
		public Task<LineItem<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string lineItemID) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).GetJsonAsync<LineItem<Txp>>();
		public Task<ListPage<LineItem>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "lineitems").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<LineItem>>();
		public Task<ListPage<LineItem<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "lineitems").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<LineItem<Txp>>>();
		public Task<LineItem> CreateAsync(OrderDirection direction, string orderID, LineItem lineItem) => Request("v1", "orders", direction, orderID, "lineitems").PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, LineItem lineItem) => Request("v1", "orders", direction, orderID, "lineitems").PostJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem<Txp>>();
		public Task<LineItem> SaveAsync(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, LineItem lineItem) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).PutJsonAsync(ValidateModel(lineItem)).ReceiveJson<LineItem<Txp>>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string lineItemID) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).DeleteAsync();
		public Task<LineItem> PatchAsync(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialLineItem partialLineItem) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID).PatchJsonAsync(ValidateModel(partialLineItem)).ReceiveJson<LineItem<Txp>>();
		public Task<LineItem> SetShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, Address address) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").PutJsonAsync(ValidateModel(address)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, Address address) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").PutJsonAsync(ValidateModel(address)).ReceiveJson<LineItem<Txp>>();
		public Task<LineItem> PatchShippingAddressAsync(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<LineItem>();
		public Task<LineItem<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, string lineItemID, PartialAddress partialAddress) => Request("v1", "orders", direction, orderID, "lineitems", lineItemID, "shipto").PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<LineItem<Txp>>();
	}

	public class MeResource : OrderCloudResource, IMeResource
	{
		internal MeResource(OrderCloudClient client) : base(client) { }
		public Task<MeUser> GetAsync() => Request("v1", "me").GetJsonAsync<MeUser>();
		public Task<MeUser<Txp>> GetAsync<Txp>() => Request("v1", "me").GetJsonAsync<MeUser<Txp>>();
		public Task<MeUser> SaveAsync(MeUser meUser) => Request("v1", "me").PutJsonAsync(ValidateModel(meUser)).ReceiveJson<MeUser>();
		public Task<MeUser<Txp>> SaveAsync<Txp>(MeUser meUser) => Request("v1", "me").PutJsonAsync(ValidateModel(meUser)).ReceiveJson<MeUser<Txp>>();
		public Task<MeUser> PatchAsync(PartialMeUser partialMeUser) => Request("v1", "me").PatchJsonAsync(ValidateModel(partialMeUser)).ReceiveJson<MeUser>();
		public Task<MeUser<Txp>> PatchAsync<Txp>(PartialMeUser partialMeUser) => Request("v1", "me").PatchJsonAsync(ValidateModel(partialMeUser)).ReceiveJson<MeUser<Txp>>();
		public Task<ListPage<CostCenter>> ListCostCentersAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "costcenters").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter>>();
		public Task<ListPage<CostCenter<Txp>>> ListCostCentersAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "costcenters").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<CostCenter<Txp>>>();
		public Task<ListPage<UserGroup>> ListUserGroupsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListUserGroupsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<ListPage<BuyerAddress>> ListAddressesAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "addresses").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerAddress>>();
		public Task<ListPage<BuyerAddress<Txp>>> ListAddressesAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "addresses").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerAddress<Txp>>>();
		public Task<BuyerAddress> CreateAddressAsync(BuyerAddress buyerAddress) => Request("v1", "me", "addresses").PostJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress>();
		public Task<BuyerAddress<Txp>> CreateAddressAsync<Txp>(BuyerAddress buyerAddress) => Request("v1", "me", "addresses").PostJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress<Txp>>();
		public Task<BuyerAddress> GetAddressAsync(string addressID) => Request("v1", "me", "addresses", addressID).GetJsonAsync<BuyerAddress>();
		public Task<BuyerAddress<Txp>> GetAddressAsync<Txp>(string addressID) => Request("v1", "me", "addresses", addressID).GetJsonAsync<BuyerAddress<Txp>>();
		public Task<BuyerAddress> SaveAddressAsync(string addressID, BuyerAddress buyerAddress) => Request("v1", "me", "addresses", addressID).PutJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress>();
		public Task<BuyerAddress<Txp>> SaveAddressAsync<Txp>(string addressID, BuyerAddress buyerAddress) => Request("v1", "me", "addresses", addressID).PutJsonAsync(ValidateModel(buyerAddress)).ReceiveJson<BuyerAddress<Txp>>();
		public Task PatchAddressAsync(string addressID, PartialBuyerAddress partialBuyerAddress) => Request("v1", "me", "addresses", addressID).PatchJsonAsync(ValidateModel(partialBuyerAddress));
		public Task DeleteAddressAsync(string addressID) => Request("v1", "me", "addresses", addressID).DeleteAsync();
		public Task<BuyerCreditCard> CreateCreditCardAsync(BuyerCreditCard buyerCreditCard) => Request("v1", "me", "creditcards").PostJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard>();
		public Task<BuyerCreditCard<Txp>> CreateCreditCardAsync<Txp>(BuyerCreditCard buyerCreditCard) => Request("v1", "me", "creditcards").PostJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard<Txp>>();
		public Task<ListPage<BuyerCreditCard>> ListCreditCardsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "creditcards").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerCreditCard>>();
		public Task<ListPage<BuyerCreditCard<Txp>>> ListCreditCardsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "creditcards").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerCreditCard<Txp>>>();
		public Task<BuyerCreditCard> GetCreditCardAsync(string creditcardID) => Request("v1", "me", "creditcards", creditcardID).GetJsonAsync<BuyerCreditCard>();
		public Task<BuyerCreditCard<Txp>> GetCreditCardAsync<Txp>(string creditcardID) => Request("v1", "me", "creditcards", creditcardID).GetJsonAsync<BuyerCreditCard<Txp>>();
		public Task<BuyerCreditCard> SaveCreditCardAsync(string creditcardID, BuyerCreditCard buyerCreditCard) => Request("v1", "me", "creditcards", creditcardID).PutJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard>();
		public Task<BuyerCreditCard<Txp>> SaveCreditCardAsync<Txp>(string creditcardID, BuyerCreditCard buyerCreditCard) => Request("v1", "me", "creditcards", creditcardID).PutJsonAsync(ValidateModel(buyerCreditCard)).ReceiveJson<BuyerCreditCard<Txp>>();
		public Task PatchCreditCardAsync(string creditcardID, PartialBuyerCreditCard partialBuyerCreditCard) => Request("v1", "me", "creditcards", creditcardID).PatchJsonAsync(ValidateModel(partialBuyerCreditCard));
		public Task DeleteCreditCardAsync(string creditcardID) => Request("v1", "me", "creditcards", creditcardID).DeleteAsync();
		public Task<ListPage<Category>> ListCategoriesAsync(string depth = "1", string catalogID = null, string productID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "categories").SetQueryParams(new { depth, catalogID, productID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Category>>();
		public Task<Category> GetCategoryAsync(string categoryID, string catalogID) => Request("v1", "me", "categories", categoryID).SetQueryParams(new { catalogID }).GetJsonAsync<Category>();
		public Task<Category<Txp>> GetCategoryAsync<Txp>(string categoryID, string catalogID) => Request("v1", "me", "categories", categoryID).SetQueryParams(new { catalogID }).GetJsonAsync<Category<Txp>>();
		public Task<ListPage<BuyerProduct>> ListProductsAsync(string catalogID = null, string categoryID = null, string depth = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "products").SetQueryParams(new { catalogID, categoryID, depth, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerProduct>>();
		public Task<BuyerProduct> GetProductAsync(string productID) => Request("v1", "me", "products", productID).GetJsonAsync<BuyerProduct>();
		public Task<BuyerProduct<Txp>> GetProductAsync<Txp>(string productID) => Request("v1", "me", "products", productID).GetJsonAsync<BuyerProduct<Txp>>();
		public Task<ListPage<BuyerSpec>> ListSpecsAsync(string productID, string catalogID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "products", productID, "specs").SetQueryParams(new { catalogID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<BuyerSpec>>();
		public Task<BuyerSpec> GetSpecAsync(string productID, string specID, string catalogID = null) => Request("v1", "me", "products", productID, "specs", specID).SetQueryParams(new { catalogID }).GetJsonAsync<BuyerSpec>();
		public Task<BuyerSpec<Txp>> GetSpecAsync<Txp>(string productID, string specID, string catalogID = null) => Request("v1", "me", "products", productID, "specs", specID).SetQueryParams(new { catalogID }).GetJsonAsync<BuyerSpec<Txp>>();
		public Task<ListPage<Order>> ListOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "orders").SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "orders").SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Order>> ListApprovableOrdersAsync(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "orders", "approvable").SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListApprovableOrdersAsync<Txp>(DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "orders", "approvable").SetQueryParams(new { from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<ListPage<Promotion>> ListPromotionsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "promotions").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion>>();
		public Task<ListPage<Promotion<Txp>>> ListPromotionsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "promotions").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion<Txp>>>();
		public Task<Promotion> GetPromotionAsync(string promotionID) => Request("v1", "me", "promotions", promotionID).GetJsonAsync<Promotion>();
		public Task<Promotion<Txp>> GetPromotionAsync<Txp>(string promotionID) => Request("v1", "me", "promotions", promotionID).GetJsonAsync<Promotion<Txp>>();
		public Task<ListPage<SpendingAccount>> ListSpendingAccountsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "spendingAccounts").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount>>();
		public Task<ListPage<SpendingAccount<Txp>>> ListSpendingAccountsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "spendingAccounts").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount<Txp>>>();
		public Task<SpendingAccount> GetSpendingAccountAsync(string spendingAccountID) => Request("v1", "me", "spendingaccounts", spendingAccountID).GetJsonAsync<SpendingAccount>();
		public Task<SpendingAccount<Txp>> GetSpendingAccountAsync<Txp>(string spendingAccountID) => Request("v1", "me", "spendingaccounts", spendingAccountID).GetJsonAsync<SpendingAccount<Txp>>();
		public Task<ListPage<Shipment>> ListShipmentsAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "shipments").SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment>>();
		public Task<ListPage<Shipment<Txp>>> ListShipmentsAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "shipments").SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment<Txp>>>();
		public Task<Shipment> GetShipmentAsync(string shipmentID) => Request("v1", "me", "shipments", shipmentID).GetJsonAsync<Shipment>();
		public Task<Shipment<Txp>> GetShipmentAsync<Txp>(string shipmentID) => Request("v1", "me", "shipments", shipmentID).GetJsonAsync<Shipment<Txp>>();
		public Task<ListPage<ShipmentItem>> ListShipmentItemsAsync(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "shipments", shipmentID, "items").SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem>>();
		public Task<ListPage<ShipmentItem<Txp>>> ListShipmentItemsAsync<Txp>(string shipmentID, string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "shipments", shipmentID, "items").SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem<Txp>>>();
		public Task<dynamic> RegisterAsync(MeUser meUser, string anonUserToken) => Request("v1", "me", "register").SetQueryParams(new { anonUserToken }).PutJsonAsync(ValidateModel(meUser)).ReceiveJson<dynamic>();
		public Task TransferAnonUserOrderAsync(string anonUserToken) => Request("v1", "me", "orders").SetQueryParams(new { anonUserToken }).PutAsync(null);
		public Task ResetPasswordByTokenAsync(TokenPasswordReset tokenPasswordReset) => Request("v1", "me", "password").PostJsonAsync(ValidateModel(tokenPasswordReset));
		public Task<ListPage<Catalog>> ListCatalogsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "catalogs").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog>>();
		public Task<ListPage<Catalog<Txp>>> ListCatalogsAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "me", "catalogs").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Catalog<Txp>>>();
		public Task<Catalog> GetCatalogAsync(string catalogID) => Request("v1", "me", "catalogs", catalogID).GetJsonAsync<Catalog>();
		public Task<Catalog<Txp>> GetCatalogAsync<Txp>(string catalogID) => Request("v1", "me", "catalogs", catalogID).GetJsonAsync<Catalog<Txp>>();
	}

	public class MessageSendersResource : OrderCloudResource, IMessageSendersResource
	{
		internal MessageSendersResource(OrderCloudClient client) : base(client) { }
		public Task<MessageSender> GetAsync(string messageSenderID) => Request("v1", "messagesenders", messageSenderID).GetJsonAsync<MessageSender>();
		public Task<ListPage<MessageSender>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "messagesenders").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<MessageSender>>();
		public Task<ListPage<MessageSenderAssignment>> ListAssignmentsAsync(string buyerID = null, string messageSenderID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "messagesenders", "assignments").SetQueryParams(new { buyerID, messageSenderID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<MessageSenderAssignment>>();
		public Task DeleteAssignmentAsync(string messageSenderID, string buyerID = null, string userID = null, string userGroupID = null) => Request("v1", "messagesenders", messageSenderID, "assignments").SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(MessageSenderAssignment messageSenderAssignment) => Request("v1", "messagesenders", "assignments").PostJsonAsync(ValidateModel(messageSenderAssignment));
		public Task<ListPage<MessageCCListenerAssignment>> ListCCListenerAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "messagesenders", "CCListenerAssignments").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<MessageCCListenerAssignment>>();
		public Task SaveCCListenerAssignmentAsync(MessageCCListenerAssignment messageCCListenerAssignment) => Request("v1", "messagesenders", "CCListenerAssignments").PostJsonAsync(ValidateModel(messageCCListenerAssignment));
	}

	public class OrdersResource : OrderCloudResource, IOrdersResource
	{
		internal OrdersResource(OrderCloudClient client) : base(client) { }
		public Task<Order> GetAsync(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID).GetJsonAsync<Order>();
		public Task<Order<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID).GetJsonAsync<Order<Txp>>();
		public Task<ListPage<Order>> ListAsync(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction).SetQueryParams(new { buyerID, supplierID, from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order>>();
		public Task<ListPage<Order<Txp>>> ListAsync<Txp>(OrderDirection direction, string buyerID = null, string supplierID = null, DateTimeOffset? from = null, DateTimeOffset? to = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction).SetQueryParams(new { buyerID, supplierID, from, to, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Order<Txp>>>();
		public Task<Order> CreateAsync(OrderDirection direction, Order order) => Request("v1", "orders", direction).PostJsonAsync(ValidateModel(order)).ReceiveJson<Order>();
		public Task<Order<Txp>> CreateAsync<Txp>(OrderDirection direction, Order order) => Request("v1", "orders", direction).PostJsonAsync(ValidateModel(order)).ReceiveJson<Order<Txp>>();
		public Task<Order> SaveAsync(OrderDirection direction, string orderID, Order order) => Request("v1", "orders", direction, orderID).PutJsonAsync(ValidateModel(order)).ReceiveJson<Order>();
		public Task<Order<Txp>> SaveAsync<Txp>(OrderDirection direction, string orderID, Order order) => Request("v1", "orders", direction, orderID).PutJsonAsync(ValidateModel(order)).ReceiveJson<Order<Txp>>();
		public Task DeleteAsync(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID).DeleteAsync();
		public Task<ListPage<OrderApproval>> ListApprovalsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "approvals").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OrderApproval>>();
		public Task<ListPage<User>> ListEligibleApproversAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "eligibleapprovers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListEligibleApproversAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "eligibleapprovers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<Order> PatchAsync(OrderDirection direction, string orderID, PartialOrder partialOrder) => Request("v1", "orders", direction, orderID).PatchJsonAsync(ValidateModel(partialOrder)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, PartialOrder partialOrder) => Request("v1", "orders", direction, orderID).PatchJsonAsync(ValidateModel(partialOrder)).ReceiveJson<Order<Txp>>();
		public Task<Order> SubmitAsync(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID, "submit").PostAsync(null).ReceiveJson<Order>();
		public Task<Order<Txp>> SubmitAsync<Txp>(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID, "submit").PostAsync(null).ReceiveJson<Order<Txp>>();
		public Task<Order> ApproveAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo) => Request("v1", "orders", direction, orderID, "approve").PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order>();
		public Task<Order<Txp>> ApproveAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo) => Request("v1", "orders", direction, orderID, "approve").PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order<Txp>>();
		public Task<Order> DeclineAsync(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo) => Request("v1", "orders", direction, orderID, "decline").PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order>();
		public Task<Order<Txp>> DeclineAsync<Txp>(OrderDirection direction, string orderID, OrderApprovalInfo orderApprovalInfo) => Request("v1", "orders", direction, orderID, "decline").PostJsonAsync(ValidateModel(orderApprovalInfo)).ReceiveJson<Order<Txp>>();
		public Task<Order> CancelAsync(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID, "cancel").PostAsync(null).ReceiveJson<Order>();
		public Task<Order<Txp>> CancelAsync<Txp>(OrderDirection direction, string orderID) => Request("v1", "orders", direction, orderID, "cancel").PostAsync(null).ReceiveJson<Order<Txp>>();
		public Task<Order> ShipAsync(OrderDirection direction, string orderID, Shipment shipment) => Request("v1", "orders", direction, orderID, "ship").PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Order>();
		public Task<Order<Txp>> ShipAsync<Txp>(OrderDirection direction, string orderID, Shipment shipment) => Request("v1", "orders", direction, orderID, "ship").PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Order<Txp>>();
		public Task<Order> SetShippingAddressAsync(OrderDirection direction, string orderID, Address address) => Request("v1", "orders", direction, orderID, "shipto").PutJsonAsync(ValidateModel(address)).ReceiveJson<Order>();
		public Task<Order<Txp>> SetShippingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address) => Request("v1", "orders", direction, orderID, "shipto").PutJsonAsync(ValidateModel(address)).ReceiveJson<Order<Txp>>();
		public Task<Order> PatchShippingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress) => Request("v1", "orders", direction, orderID, "shipto").PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchShippingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress) => Request("v1", "orders", direction, orderID, "shipto").PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order<Txp>>();
		public Task<Order> SetBillingAddressAsync(OrderDirection direction, string orderID, Address address) => Request("v1", "orders", direction, orderID, "billto").PutJsonAsync(ValidateModel(address)).ReceiveJson<Order>();
		public Task<Order<Txp>> SetBillingAddressAsync<Txp>(OrderDirection direction, string orderID, Address address) => Request("v1", "orders", direction, orderID, "billto").PutJsonAsync(ValidateModel(address)).ReceiveJson<Order<Txp>>();
		public Task<Order> PatchBillingAddressAsync(OrderDirection direction, string orderID, PartialAddress partialAddress) => Request("v1", "orders", direction, orderID, "billto").PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchBillingAddressAsync<Txp>(OrderDirection direction, string orderID, PartialAddress partialAddress) => Request("v1", "orders", direction, orderID, "billto").PatchJsonAsync(ValidateModel(partialAddress)).ReceiveJson<Order<Txp>>();
		public Task<Order> PatchFromUserAsync(OrderDirection direction, string orderID, PartialUser partialUser) => Request("v1", "orders", direction, orderID, "fromuser").PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<Order>();
		public Task<Order<Txp>> PatchFromUserAsync<Txp>(OrderDirection direction, string orderID, PartialUser partialUser) => Request("v1", "orders", direction, orderID, "fromuser").PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<Order<Txp>>();
		public Task<Promotion> AddPromotionAsync(OrderDirection direction, string orderID, string promoCode) => Request("v1", "orders", direction, orderID, "promotions", promoCode).PostAsync(null).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> AddPromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode) => Request("v1", "orders", direction, orderID, "promotions", promoCode).PostAsync(null).ReceiveJson<Promotion<Txp>>();
		public Task<ListPage<OrderPromotion>> ListPromotionsAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "promotions").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OrderPromotion>>();
		public Task<ListPage<OrderPromotion<Txp>>> ListPromotionsAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "promotions").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<OrderPromotion<Txp>>>();
		public Task<Order> RemovePromotionAsync(OrderDirection direction, string orderID, string promoCode) => Request("v1", "orders", direction, orderID, "promotions", promoCode).DeleteAsync().ReceiveJson<Order>();
		public Task<Order<Txp>> RemovePromotionAsync<Txp>(OrderDirection direction, string orderID, string promoCode) => Request("v1", "orders", direction, orderID, "promotions", promoCode).DeleteAsync().ReceiveJson<Order<Txp>>();
	}

	public class PasswordResetsResource : OrderCloudResource, IPasswordResetsResource
	{
		internal PasswordResetsResource(OrderCloudClient client) : base(client) { }
		public Task SendVerificationCodeAsync(PasswordResetRequest passwordResetRequest) => Request("v1", "password", "reset").PostJsonAsync(ValidateModel(passwordResetRequest));
		public Task ResetPasswordByVerificationCodeAsync(string verificationCode, PasswordReset passwordReset) => Request("v1", "password", "reset", verificationCode).PutJsonAsync(ValidateModel(passwordReset));
	}

	public class PaymentsResource : OrderCloudResource, IPaymentsResource
	{
		internal PaymentsResource(OrderCloudClient client) : base(client) { }
		public Task<Payment> GetAsync(OrderDirection direction, string orderID, string paymentID) => Request("v1", "orders", direction, orderID, "payments", paymentID).GetJsonAsync<Payment>();
		public Task<Payment<Txp>> GetAsync<Txp>(OrderDirection direction, string orderID, string paymentID) => Request("v1", "orders", direction, orderID, "payments", paymentID).GetJsonAsync<Payment<Txp>>();
		public Task<ListPage<Payment>> ListAsync(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "payments").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Payment>>();
		public Task<ListPage<Payment<Txp>>> ListAsync<Txp>(OrderDirection direction, string orderID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "orders", direction, orderID, "payments").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Payment<Txp>>>();
		public Task<Payment> CreateAsync(OrderDirection direction, string orderID, Payment payment) => Request("v1", "orders", direction, orderID, "payments").PostJsonAsync(ValidateModel(payment)).ReceiveJson<Payment>();
		public Task<Payment<Txp>> CreateAsync<Txp>(OrderDirection direction, string orderID, Payment payment) => Request("v1", "orders", direction, orderID, "payments").PostJsonAsync(ValidateModel(payment)).ReceiveJson<Payment<Txp>>();
		public Task DeleteAsync(OrderDirection direction, string orderID, string paymentID) => Request("v1", "orders", direction, orderID, "payments", paymentID).DeleteAsync();
		public Task<Payment> PatchAsync(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment) => Request("v1", "orders", direction, orderID, "payments", paymentID).PatchJsonAsync(ValidateModel(partialPayment)).ReceiveJson<Payment>();
		public Task<Payment<Txp>> PatchAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PartialPayment partialPayment) => Request("v1", "orders", direction, orderID, "payments", paymentID).PatchJsonAsync(ValidateModel(partialPayment)).ReceiveJson<Payment<Txp>>();
		public Task<Payment> CreateTransactionAsync(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions").PostJsonAsync(ValidateModel(paymentTransaction)).ReceiveJson<Payment>();
		public Task<Payment<Txp>> CreateTransactionAsync<Txp>(OrderDirection direction, string orderID, string paymentID, PaymentTransaction paymentTransaction) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions").PostJsonAsync(ValidateModel(paymentTransaction)).ReceiveJson<Payment<Txp>>();
		public Task DeleteTransactionAsync(OrderDirection direction, string orderID, string paymentID, string transactionID) => Request("v1", "orders", direction, orderID, "payments", paymentID, "transactions", transactionID).DeleteAsync();
	}

	public class PriceSchedulesResource : OrderCloudResource, IPriceSchedulesResource
	{
		internal PriceSchedulesResource(OrderCloudClient client) : base(client) { }
		public Task<PriceSchedule> GetAsync(string priceScheduleID) => Request("v1", "priceschedules", priceScheduleID).GetJsonAsync<PriceSchedule>();
		public Task<PriceSchedule<Txp>> GetAsync<Txp>(string priceScheduleID) => Request("v1", "priceschedules", priceScheduleID).GetJsonAsync<PriceSchedule<Txp>>();
		public Task<ListPage<PriceSchedule>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "priceschedules").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<PriceSchedule>>();
		public Task<ListPage<PriceSchedule<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "priceschedules").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<PriceSchedule<Txp>>>();
		public Task<PriceSchedule> CreateAsync(PriceSchedule priceSchedule) => Request("v1", "priceschedules").PostJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> CreateAsync<Txp>(PriceSchedule priceSchedule) => Request("v1", "priceschedules").PostJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule<Txp>>();
		public Task<PriceSchedule> SaveAsync(string priceScheduleID, PriceSchedule priceSchedule) => Request("v1", "priceschedules", priceScheduleID).PutJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> SaveAsync<Txp>(string priceScheduleID, PriceSchedule priceSchedule) => Request("v1", "priceschedules", priceScheduleID).PutJsonAsync(ValidateModel(priceSchedule)).ReceiveJson<PriceSchedule<Txp>>();
		public Task DeleteAsync(string priceScheduleID) => Request("v1", "priceschedules", priceScheduleID).DeleteAsync();
		public Task<PriceSchedule> PatchAsync(string priceScheduleID, PartialPriceSchedule partialPriceSchedule) => Request("v1", "priceschedules", priceScheduleID).PatchJsonAsync(ValidateModel(partialPriceSchedule)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> PatchAsync<Txp>(string priceScheduleID, PartialPriceSchedule partialPriceSchedule) => Request("v1", "priceschedules", priceScheduleID).PatchJsonAsync(ValidateModel(partialPriceSchedule)).ReceiveJson<PriceSchedule<Txp>>();
		public Task<PriceSchedule> SavePriceBreakAsync(string priceScheduleID, PriceBreak priceBreak) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").PostJsonAsync(ValidateModel(priceBreak)).ReceiveJson<PriceSchedule>();
		public Task<PriceSchedule<Txp>> SavePriceBreakAsync<Txp>(string priceScheduleID, PriceBreak priceBreak) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").PostJsonAsync(ValidateModel(priceBreak)).ReceiveJson<PriceSchedule<Txp>>();
		public Task DeletePriceBreakAsync(string priceScheduleID, int quantity) => Request("v1", "priceschedules", priceScheduleID, "PriceBreaks").SetQueryParams(new { quantity }).DeleteAsync();
	}

	public class ProductsResource : OrderCloudResource, IProductsResource
	{
		internal ProductsResource(OrderCloudClient client) : base(client) { }
		public Task<Product> GetAsync(string productID) => Request("v1", "products", productID).GetJsonAsync<Product>();
		public Task<Product<Txp>> GetAsync<Txp>(string productID) => Request("v1", "products", productID).GetJsonAsync<Product<Txp>>();
		public Task<ListPage<Product>> ListAsync(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "products").SetQueryParams(new { catalogID, categoryID, supplierID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Product>>();
		public Task<ListPage<Product<Txp>>> ListAsync<Txp>(string catalogID = null, string categoryID = null, string supplierID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "products").SetQueryParams(new { catalogID, categoryID, supplierID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Product<Txp>>>();
		public Task<Product> CreateAsync(Product product) => Request("v1", "products").PostJsonAsync(ValidateModel(product)).ReceiveJson<Product>();
		public Task<Product<Txp>> CreateAsync<Txp>(Product product) => Request("v1", "products").PostJsonAsync(ValidateModel(product)).ReceiveJson<Product<Txp>>();
		public Task<Product> SaveAsync(string productID, Product product) => Request("v1", "products", productID).PutJsonAsync(ValidateModel(product)).ReceiveJson<Product>();
		public Task<Product<Txp>> SaveAsync<Txp>(string productID, Product product) => Request("v1", "products", productID).PutJsonAsync(ValidateModel(product)).ReceiveJson<Product<Txp>>();
		public Task DeleteAsync(string productID) => Request("v1", "products", productID).DeleteAsync();
		public Task<Product> PatchAsync(string productID, PartialProduct partialProduct) => Request("v1", "products", productID).PatchJsonAsync(ValidateModel(partialProduct)).ReceiveJson<Product>();
		public Task<Product<Txp>> PatchAsync<Txp>(string productID, PartialProduct partialProduct) => Request("v1", "products", productID).PatchJsonAsync(ValidateModel(partialProduct)).ReceiveJson<Product<Txp>>();
		public Task<Product> GenerateVariantsAsync(string productID, bool overwriteExisting = false) => Request("v1", "products", productID, "variants", "generate").SetQueryParams(new { overwriteExisting }).PostAsync(null).ReceiveJson<Product>();
		public Task<Product<Txp>> GenerateVariantsAsync<Txp>(string productID, bool overwriteExisting = false) => Request("v1", "products", productID, "variants", "generate").SetQueryParams(new { overwriteExisting }).PostAsync(null).ReceiveJson<Product<Txp>>();
		public Task<ListPage<Variant>> ListVariantsAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "products", productID, "variants").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Variant>>();
		public Task<ListPage<Variant<Txp>>> ListVariantsAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "products", productID, "variants").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Variant<Txp>>>();
		public Task<Variant> SaveVariantAsync(string productID, string variantID, Variant variant) => Request("v1", "products", productID, "variants", variantID).PutJsonAsync(ValidateModel(variant)).ReceiveJson<Variant>();
		public Task<Variant<Txp>> SaveVariantAsync<Txp>(string productID, string variantID, Variant variant) => Request("v1", "products", productID, "variants", variantID).PutJsonAsync(ValidateModel(variant)).ReceiveJson<Variant<Txp>>();
		public Task<Variant> PatchVariantAsync(string productID, string variantID, PartialVariant partialVariant) => Request("v1", "products", productID, "variants", variantID).PatchJsonAsync(ValidateModel(partialVariant)).ReceiveJson<Variant>();
		public Task<Variant<Txp>> PatchVariantAsync<Txp>(string productID, string variantID, PartialVariant partialVariant) => Request("v1", "products", productID, "variants", variantID).PatchJsonAsync(ValidateModel(partialVariant)).ReceiveJson<Variant<Txp>>();
		public Task<Variant> GetVariantAsync(string productID, string variantID) => Request("v1", "products", productID, "variants", variantID).GetJsonAsync<Variant>();
		public Task<Variant<Txp>> GetVariantAsync<Txp>(string productID, string variantID) => Request("v1", "products", productID, "variants", variantID).GetJsonAsync<Variant<Txp>>();
		public Task<ListPage<Supplier>> ListSuppliersAsync(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "products", productID, "suppliers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier>>();
		public Task<ListPage<Supplier<Txp>>> ListSuppliersAsync<Txp>(string productID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "products", productID, "suppliers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier<Txp>>>();
		public Task SaveSupplierAsync(string productID, string supplierID) => Request("v1", "products", productID, "suppliers", supplierID).PutAsync(null);
		public Task RemoveSupplierAsync(string productID, string supplierID) => Request("v1", "products", productID, "suppliers", supplierID).DeleteAsync();
		public Task SaveAssignmentAsync(ProductAssignment productAssignment) => Request("v1", "products", "assignments").PostJsonAsync(ValidateModel(productAssignment));
		public Task<ListPage<ProductAssignment>> ListAssignmentsAsync(string productID = null, string priceScheduleID = null, string buyerID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "products", "assignments").SetQueryParams(new { productID, priceScheduleID, buyerID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<ProductAssignment>>();
		public Task DeleteAssignmentAsync(string productID, string buyerID, string userID = null, string userGroupID = null) => Request("v1", "products", productID, "assignments", buyerID).SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class PromotionsResource : OrderCloudResource, IPromotionsResource
	{
		internal PromotionsResource(OrderCloudClient client) : base(client) { }
		public Task<Promotion> GetAsync(string promotionID) => Request("v1", "promotions", promotionID).GetJsonAsync<Promotion>();
		public Task<Promotion<Txp>> GetAsync<Txp>(string promotionID) => Request("v1", "promotions", promotionID).GetJsonAsync<Promotion<Txp>>();
		public Task<ListPage<Promotion>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "promotions").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion>>();
		public Task<ListPage<Promotion<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "promotions").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Promotion<Txp>>>();
		public Task<Promotion> CreateAsync(Promotion promotion) => Request("v1", "promotions").PostJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> CreateAsync<Txp>(Promotion promotion) => Request("v1", "promotions").PostJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion<Txp>>();
		public Task<Promotion> SaveAsync(string promotionID, Promotion promotion) => Request("v1", "promotions", promotionID).PutJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> SaveAsync<Txp>(string promotionID, Promotion promotion) => Request("v1", "promotions", promotionID).PutJsonAsync(ValidateModel(promotion)).ReceiveJson<Promotion<Txp>>();
		public Task DeleteAsync(string promotionID) => Request("v1", "promotions", promotionID).DeleteAsync();
		public Task<Promotion> PatchAsync(string promotionID, PartialPromotion partialPromotion) => Request("v1", "promotions", promotionID).PatchJsonAsync(ValidateModel(partialPromotion)).ReceiveJson<Promotion>();
		public Task<Promotion<Txp>> PatchAsync<Txp>(string promotionID, PartialPromotion partialPromotion) => Request("v1", "promotions", promotionID).PatchJsonAsync(ValidateModel(partialPromotion)).ReceiveJson<Promotion<Txp>>();
		public Task<ListPage<PromotionAssignment>> ListAssignmentsAsync(string buyerID = null, string promotionID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "promotions", "assignments").SetQueryParams(new { buyerID, promotionID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<PromotionAssignment>>();
		public Task SaveAssignmentAsync(PromotionAssignment promotionAssignment) => Request("v1", "promotions", "assignments").PostJsonAsync(ValidateModel(promotionAssignment));
		public Task DeleteAssignmentAsync(string promotionID, string buyerID, string userID = null, string userGroupID = null) => Request("v1", "promotions", promotionID, "assignments").SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
	}

	public class SecurityProfilesResource : OrderCloudResource, ISecurityProfilesResource
	{
		internal SecurityProfilesResource(OrderCloudClient client) : base(client) { }
		public Task<SecurityProfile> GetAsync(string securityProfileID) => Request("v1", "securityprofiles", securityProfileID).GetJsonAsync<SecurityProfile>();
		public Task<ListPage<SecurityProfile>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "securityprofiles").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SecurityProfile>>();
		public Task<ListPage<SecurityProfileAssignment>> ListAssignmentsAsync(string buyerID = null, string supplierID = null, string securityProfileID = null, string userID = null, string userGroupID = null, CommerceRole? commerceRole = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "securityprofiles", "assignments").SetQueryParams(new { buyerID, supplierID, securityProfileID, userID, userGroupID, commerceRole, level, page, pageSize }).GetJsonAsync<ListPage<SecurityProfileAssignment>>();
		public Task DeleteAssignmentAsync(string securityProfileID, string buyerID = null, string userID = null, string userGroupID = null) => Request("v1", "securityprofiles", securityProfileID, "assignments").SetQueryParams(new { buyerID, userID, userGroupID }).DeleteAsync();
		public Task SaveAssignmentAsync(SecurityProfileAssignment securityProfileAssignment) => Request("v1", "securityprofiles", "assignments").PostJsonAsync(ValidateModel(securityProfileAssignment));
	}

	public class ShipmentsResource : OrderCloudResource, IShipmentsResource
	{
		internal ShipmentsResource(OrderCloudClient client) : base(client) { }
		public Task<Shipment> GetAsync(string shipmentID) => Request("v1", "shipments", shipmentID).GetJsonAsync<Shipment>();
		public Task<Shipment<Txp>> GetAsync<Txp>(string shipmentID) => Request("v1", "shipments", shipmentID).GetJsonAsync<Shipment<Txp>>();
		public Task<ListPage<Shipment>> ListAsync(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "shipments").SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment>>();
		public Task<ListPage<Shipment<Txp>>> ListAsync<Txp>(string orderID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "shipments").SetQueryParams(new { orderID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Shipment<Txp>>>();
		public Task<Shipment> CreateAsync(Shipment shipment) => Request("v1", "shipments").PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment>();
		public Task<Shipment<Txp>> CreateAsync<Txp>(Shipment shipment) => Request("v1", "shipments").PostJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment<Txp>>();
		public Task<Shipment> SaveAsync(string shipmentID, Shipment shipment) => Request("v1", "shipments", shipmentID).PutJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment>();
		public Task<Shipment<Txp>> SaveAsync<Txp>(string shipmentID, Shipment shipment) => Request("v1", "shipments", shipmentID).PutJsonAsync(ValidateModel(shipment)).ReceiveJson<Shipment<Txp>>();
		public Task DeleteAsync(string shipmentID) => Request("v1", "shipments", shipmentID).DeleteAsync();
		public Task<Shipment> PatchAsync(string shipmentID, PartialShipment partialShipment) => Request("v1", "shipments", shipmentID).PatchJsonAsync(ValidateModel(partialShipment)).ReceiveJson<Shipment>();
		public Task<Shipment<Txp>> PatchAsync<Txp>(string shipmentID, PartialShipment partialShipment) => Request("v1", "shipments", shipmentID).PatchJsonAsync(ValidateModel(partialShipment)).ReceiveJson<Shipment<Txp>>();
		public Task<ListPage<ShipmentItem>> ListItemsAsync(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "shipments", shipmentID, "items").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem>>();
		public Task<ListPage<ShipmentItem<Txp>>> ListItemsAsync<Txp>(string shipmentID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "shipments", shipmentID, "items").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<ShipmentItem<Txp>>>();
		public Task<ShipmentItem> GetItemAsync(string shipmentID, string orderID, string lineItemID) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).GetJsonAsync<ShipmentItem>();
		public Task<ShipmentItem<Txp>> GetItemAsync<Txp>(string shipmentID, string orderID, string lineItemID) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).GetJsonAsync<ShipmentItem<Txp>>();
		public Task<ShipmentItem> SaveItemAsync(string shipmentID, ShipmentItem shipmentItem) => Request("v1", "shipments", shipmentID, "items").PostJsonAsync(ValidateModel(shipmentItem)).ReceiveJson<ShipmentItem>();
		public Task<ShipmentItem<Txp>> SaveItemAsync<Txp>(string shipmentID, ShipmentItem shipmentItem) => Request("v1", "shipments", shipmentID, "items").PostJsonAsync(ValidateModel(shipmentItem)).ReceiveJson<ShipmentItem<Txp>>();
		public Task DeleteItemAsync(string shipmentID, string orderID, string lineItemID) => Request("v1", "shipments", shipmentID, "items", orderID, lineItemID).DeleteAsync();
	}

	public class SpecsResource : OrderCloudResource, ISpecsResource
	{
		internal SpecsResource(OrderCloudClient client) : base(client) { }
		public Task<Spec> GetAsync(string specID) => Request("v1", "specs", specID).GetJsonAsync<Spec>();
		public Task<Spec<Txp>> GetAsync<Txp>(string specID) => Request("v1", "specs", specID).GetJsonAsync<Spec<Txp>>();
		public Task<ListPage<Spec>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "specs").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Spec>>();
		public Task<ListPage<Spec<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "specs").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Spec<Txp>>>();
		public Task<Spec> CreateAsync(Spec spec) => Request("v1", "specs").PostJsonAsync(ValidateModel(spec)).ReceiveJson<Spec>();
		public Task<Spec<Txp>> CreateAsync<Txp>(Spec spec) => Request("v1", "specs").PostJsonAsync(ValidateModel(spec)).ReceiveJson<Spec<Txp>>();
		public Task<Spec> SaveAsync(string specID, Spec spec) => Request("v1", "specs", specID).PutJsonAsync(ValidateModel(spec)).ReceiveJson<Spec>();
		public Task<Spec<Txp>> SaveAsync<Txp>(string specID, Spec spec) => Request("v1", "specs", specID).PutJsonAsync(ValidateModel(spec)).ReceiveJson<Spec<Txp>>();
		public Task DeleteAsync(string specID) => Request("v1", "specs", specID).DeleteAsync();
		public Task<Spec> PatchAsync(string specID, PartialSpec partialSpec) => Request("v1", "specs", specID).PatchJsonAsync(ValidateModel(partialSpec)).ReceiveJson<Spec>();
		public Task<Spec<Txp>> PatchAsync<Txp>(string specID, PartialSpec partialSpec) => Request("v1", "specs", specID).PatchJsonAsync(ValidateModel(partialSpec)).ReceiveJson<Spec<Txp>>();
		public Task<ListPage<SpecProductAssignment>> ListProductAssignmentsAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "specs", "productassignments").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecProductAssignment>>();
		public Task DeleteProductAssignmentAsync(string specID, string productID) => Request("v1", "specs", specID, "productassignments", productID).DeleteAsync();
		public Task SaveProductAssignmentAsync(SpecProductAssignment specProductAssignment) => Request("v1", "specs", "productassignments").PostJsonAsync(ValidateModel(specProductAssignment));
		public Task<SpecOption> CreateOptionAsync(string specID, SpecOption specOption) => Request("v1", "specs", specID, "options").PostJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption>();
		public Task<SpecOption<Txp>> CreateOptionAsync<Txp>(string specID, SpecOption specOption) => Request("v1", "specs", specID, "options").PostJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption<Txp>>();
		public Task<ListPage<SpecOption>> ListOptionsAsync(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "specs", specID, "options").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecOption>>();
		public Task<ListPage<SpecOption<Txp>>> ListOptionsAsync<Txp>(string specID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "specs", specID, "options").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpecOption<Txp>>>();
		public Task<SpecOption> SaveOptionAsync(string specID, string optionID, SpecOption specOption) => Request("v1", "specs", specID, "options", optionID).PutJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption>();
		public Task<SpecOption<Txp>> SaveOptionAsync<Txp>(string specID, string optionID, SpecOption specOption) => Request("v1", "specs", specID, "options", optionID).PutJsonAsync(ValidateModel(specOption)).ReceiveJson<SpecOption<Txp>>();
		public Task<SpecOption> PatchOptionAsync(string specID, string optionID, PartialSpecOption partialSpecOption) => Request("v1", "specs", specID, "options", optionID).PatchJsonAsync(ValidateModel(partialSpecOption)).ReceiveJson<SpecOption>();
		public Task<SpecOption<Txp>> PatchOptionAsync<Txp>(string specID, string optionID, PartialSpecOption partialSpecOption) => Request("v1", "specs", specID, "options", optionID).PatchJsonAsync(ValidateModel(partialSpecOption)).ReceiveJson<SpecOption<Txp>>();
		public Task<SpecOption> GetOptionAsync(string specID, string optionID) => Request("v1", "specs", specID, "options", optionID).GetJsonAsync<SpecOption>();
		public Task<SpecOption<Txp>> GetOptionAsync<Txp>(string specID, string optionID) => Request("v1", "specs", specID, "options", optionID).GetJsonAsync<SpecOption<Txp>>();
		public Task DeleteOptionAsync(string specID, string optionID) => Request("v1", "specs", specID, "options", optionID).DeleteAsync();
	}

	public class SpendingAccountsResource : OrderCloudResource, ISpendingAccountsResource
	{
		internal SpendingAccountsResource(OrderCloudClient client) : base(client) { }
		public Task<SpendingAccount> GetAsync(string buyerID, string spendingAccountID) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).GetJsonAsync<SpendingAccount>();
		public Task<SpendingAccount<Txp>> GetAsync<Txp>(string buyerID, string spendingAccountID) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).GetJsonAsync<SpendingAccount<Txp>>();
		public Task<ListPage<SpendingAccount>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "spendingaccounts").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount>>();
		public Task<ListPage<SpendingAccount<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "spendingaccounts").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<SpendingAccount<Txp>>>();
		public Task<SpendingAccount> CreateAsync(string buyerID, SpendingAccount spendingAccount) => Request("v1", "buyers", buyerID, "spendingaccounts").PostJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount>();
		public Task<SpendingAccount<Txp>> CreateAsync<Txp>(string buyerID, SpendingAccount spendingAccount) => Request("v1", "buyers", buyerID, "spendingaccounts").PostJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount<Txp>>();
		public Task<SpendingAccount> SaveAsync(string buyerID, string spendingAccountID, SpendingAccount spendingAccount) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).PutJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount>();
		public Task<SpendingAccount<Txp>> SaveAsync<Txp>(string buyerID, string spendingAccountID, SpendingAccount spendingAccount) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).PutJsonAsync(ValidateModel(spendingAccount)).ReceiveJson<SpendingAccount<Txp>>();
		public Task DeleteAsync(string buyerID, string spendingAccountID) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).DeleteAsync();
		public Task<SpendingAccount> PatchAsync(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).PatchJsonAsync(ValidateModel(partialSpendingAccount)).ReceiveJson<SpendingAccount>();
		public Task<SpendingAccount<Txp>> PatchAsync<Txp>(string buyerID, string spendingAccountID, PartialSpendingAccount partialSpendingAccount) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID).PatchJsonAsync(ValidateModel(partialSpendingAccount)).ReceiveJson<SpendingAccount<Txp>>();
		public Task<ListPage<SpendingAccountAssignment>> ListAssignmentsAsync(string buyerID, string spendingAccountID = null, string userID = null, string userGroupID = null, PartyType? level = null, int? page = null, int? pageSize = null) => Request("v1", "buyers", buyerID, "spendingaccounts", "assignments").SetQueryParams(new { spendingAccountID, userID, userGroupID, level, page, pageSize }).GetJsonAsync<ListPage<SpendingAccountAssignment>>();
		public Task SaveAssignmentAsync(string buyerID, SpendingAccountAssignment spendingAccountAssignment) => Request("v1", "buyers", buyerID, "spendingaccounts", "assignments").PostJsonAsync(ValidateModel(spendingAccountAssignment));
		public Task DeleteAssignmentAsync(string buyerID, string spendingAccountID, string userID = null, string userGroupID = null) => Request("v1", "buyers", buyerID, "spendingaccounts", spendingAccountID, "assignments").SetQueryParams(new { userID, userGroupID }).DeleteAsync();
	}

	public class SuppliersResource : OrderCloudResource, ISuppliersResource
	{
		internal SuppliersResource(OrderCloudClient client) : base(client) { }
		public Task<Supplier> GetAsync(string supplierID) => Request("v1", "suppliers", supplierID).GetJsonAsync<Supplier>();
		public Task<Supplier<Txp>> GetAsync<Txp>(string supplierID) => Request("v1", "suppliers", supplierID).GetJsonAsync<Supplier<Txp>>();
		public Task<ListPage<Supplier>> ListAsync(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "suppliers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier>>();
		public Task<ListPage<Supplier<Txp>>> ListAsync<Txp>(string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "suppliers").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<Supplier<Txp>>>();
		public Task<Supplier> CreateAsync(Supplier supplier) => Request("v1", "suppliers").PostJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier>();
		public Task<Supplier<Txp>> CreateAsync<Txp>(Supplier supplier) => Request("v1", "suppliers").PostJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier<Txp>>();
		public Task DeleteAsync(string supplierID) => Request("v1", "suppliers", supplierID).DeleteAsync();
		public Task<Supplier> SaveAsync(string supplierID, Supplier supplier) => Request("v1", "suppliers", supplierID).PutJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier>();
		public Task<Supplier<Txp>> SaveAsync<Txp>(string supplierID, Supplier supplier) => Request("v1", "suppliers", supplierID).PutJsonAsync(ValidateModel(supplier)).ReceiveJson<Supplier<Txp>>();
		public Task<Supplier> PatchAsync(string supplierID, PartialSupplier partialSupplier) => Request("v1", "suppliers", supplierID).PatchJsonAsync(ValidateModel(partialSupplier)).ReceiveJson<Supplier>();
		public Task<Supplier<Txp>> PatchAsync<Txp>(string supplierID, PartialSupplier partialSupplier) => Request("v1", "suppliers", supplierID).PatchJsonAsync(ValidateModel(partialSupplier)).ReceiveJson<Supplier<Txp>>();
	}

	public class SupplierUserGroupsResource : OrderCloudResource, ISupplierUserGroupsResource
	{
		internal SupplierUserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string supplierID, string userGroupID) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).GetJsonAsync<UserGroup>();
		public Task<UserGroup<Txp>> GetAsync<Txp>(string supplierID, string userGroupID) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).GetJsonAsync<UserGroup<Txp>>();
		public Task<ListPage<UserGroup>> ListAsync(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "suppliers", supplierID, "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string supplierID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "suppliers", supplierID, "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<UserGroup> CreateAsync(string supplierID, UserGroup userGroup) => Request("v1", "suppliers", supplierID, "usergroups").PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> CreateAsync<Txp>(string supplierID, UserGroup userGroup) => Request("v1", "suppliers", supplierID, "usergroups").PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<UserGroup> SaveAsync(string supplierID, string userGroupID, UserGroup userGroup) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> SaveAsync<Txp>(string supplierID, string userGroupID, UserGroup userGroup) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task DeleteAsync(string supplierID, string userGroupID) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).DeleteAsync();
		public Task<UserGroup> PatchAsync(string supplierID, string userGroupID, PartialUserGroup partialUserGroup) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> PatchAsync<Txp>(string supplierID, string userGroupID, PartialUserGroup partialUserGroup) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string supplierID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20) => Request("v1", "suppliers", supplierID, "usergroups", "assignments").SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string supplierID, string userGroupID, string userID) => Request("v1", "suppliers", supplierID, "usergroups", userGroupID, "assignments", userID).DeleteAsync();
		public Task SaveUserAssignmentAsync(string supplierID, UserGroupAssignment userGroupAssignment) => Request("v1", "suppliers", supplierID, "usergroups", "assignments").PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class SupplierUsersResource : OrderCloudResource, ISupplierUsersResource
	{
		internal SupplierUsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string supplierID, string userID) => Request("v1", "suppliers", supplierID, "users", userID).GetJsonAsync<User>();
		public Task<User<Txp>> GetAsync<Txp>(string supplierID, string userID) => Request("v1", "suppliers", supplierID, "users", userID).GetJsonAsync<User<Txp>>();
		public Task<ListPage<User>> ListAsync(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "suppliers", supplierID, "users").SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string supplierID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "suppliers", supplierID, "users").SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<User> CreateAsync(string supplierID, User user) => Request("v1", "suppliers", supplierID, "users").PostJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> CreateAsync<Txp>(string supplierID, User user) => Request("v1", "suppliers", supplierID, "users").PostJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task<User> SaveAsync(string supplierID, string userID, User user) => Request("v1", "suppliers", supplierID, "users", userID).PutJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> SaveAsync<Txp>(string supplierID, string userID, User user) => Request("v1", "suppliers", supplierID, "users", userID).PutJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task DeleteAsync(string supplierID, string userID) => Request("v1", "suppliers", supplierID, "users", userID).DeleteAsync();
		public Task<User> PatchAsync(string supplierID, string userID, PartialUser partialUser) => Request("v1", "suppliers", supplierID, "users", userID).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User>();
		public Task<User<Txp>> PatchAsync<Txp>(string supplierID, string userID, PartialUser partialUser) => Request("v1", "suppliers", supplierID, "users", userID).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User<Txp>>();
		public Task<AccessToken> GetAccessTokenAsync(string supplierID, string userID, ImpersonateTokenRequest impersonateTokenRequest) => Request("v1", "suppliers", supplierID, "users", userID, "accesstoken").PostJsonAsync(ValidateModel(impersonateTokenRequest)).ReceiveJson<AccessToken>();
	}

	public class UserGroupsResource : OrderCloudResource, IUserGroupsResource
	{
		internal UserGroupsResource(OrderCloudClient client) : base(client) { }
		public Task<UserGroup> GetAsync(string buyerID, string userGroupID) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).GetJsonAsync<UserGroup>();
		public Task<UserGroup<Txp>> GetAsync<Txp>(string buyerID, string userGroupID) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).GetJsonAsync<UserGroup<Txp>>();
		public Task<ListPage<UserGroup>> ListAsync(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup>>();
		public Task<ListPage<UserGroup<Txp>>> ListAsync<Txp>(string buyerID, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "usergroups").SetQueryParams(new { search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<UserGroup<Txp>>>();
		public Task<UserGroup> CreateAsync(string buyerID, UserGroup userGroup) => Request("v1", "buyers", buyerID, "usergroups").PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> CreateAsync<Txp>(string buyerID, UserGroup userGroup) => Request("v1", "buyers", buyerID, "usergroups").PostJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<UserGroup> SaveAsync(string buyerID, string userGroupID, UserGroup userGroup) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> SaveAsync<Txp>(string buyerID, string userGroupID, UserGroup userGroup) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).PutJsonAsync(ValidateModel(userGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task DeleteAsync(string buyerID, string userGroupID) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).DeleteAsync();
		public Task<UserGroup> PatchAsync(string buyerID, string userGroupID, PartialUserGroup partialUserGroup) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup>();
		public Task<UserGroup<Txp>> PatchAsync<Txp>(string buyerID, string userGroupID, PartialUserGroup partialUserGroup) => Request("v1", "buyers", buyerID, "usergroups", userGroupID).PatchJsonAsync(ValidateModel(partialUserGroup)).ReceiveJson<UserGroup<Txp>>();
		public Task<ListPage<UserGroupAssignment>> ListUserAssignmentsAsync(string buyerID, string userGroupID = null, string userID = null, int page = 1, int pageSize = 20) => Request("v1", "buyers", buyerID, "usergroups", "assignments").SetQueryParams(new { userGroupID, userID, page, pageSize }).GetJsonAsync<ListPage<UserGroupAssignment>>();
		public Task DeleteUserAssignmentAsync(string buyerID, string userGroupID, string userID) => Request("v1", "buyers", buyerID, "usergroups", userGroupID, "assignments", userID).DeleteAsync();
		public Task SaveUserAssignmentAsync(string buyerID, UserGroupAssignment userGroupAssignment) => Request("v1", "buyers", buyerID, "usergroups", "assignments").PostJsonAsync(ValidateModel(userGroupAssignment));
	}

	public class UsersResource : OrderCloudResource, IUsersResource
	{
		internal UsersResource(OrderCloudClient client) : base(client) { }
		public Task<User> GetAsync(string buyerID, string userID) => Request("v1", "buyers", buyerID, "users", userID).GetJsonAsync<User>();
		public Task<User<Txp>> GetAsync<Txp>(string buyerID, string userID) => Request("v1", "buyers", buyerID, "users", userID).GetJsonAsync<User<Txp>>();
		public Task<ListPage<User>> ListAsync(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "users").SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User>>();
		public Task<ListPage<User<Txp>>> ListAsync<Txp>(string buyerID, string userGroupID = null, string search = null, string searchOn = null, string sortBy = null, int page = 1, int pageSize = 20, object filters = null) => Request("v1", "buyers", buyerID, "users").SetQueryParams(new { userGroupID, search, searchOn, sortBy, page, pageSize }).SetQueryParams(filters).GetJsonAsync<ListPage<User<Txp>>>();
		public Task<User> CreateAsync(string buyerID, User user) => Request("v1", "buyers", buyerID, "users").PostJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> CreateAsync<Txp>(string buyerID, User user) => Request("v1", "buyers", buyerID, "users").PostJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task<User> SaveAsync(string buyerID, string userID, User user) => Request("v1", "buyers", buyerID, "users", userID).PutJsonAsync(ValidateModel(user)).ReceiveJson<User>();
		public Task<User<Txp>> SaveAsync<Txp>(string buyerID, string userID, User user) => Request("v1", "buyers", buyerID, "users", userID).PutJsonAsync(ValidateModel(user)).ReceiveJson<User<Txp>>();
		public Task DeleteAsync(string buyerID, string userID) => Request("v1", "buyers", buyerID, "users", userID).DeleteAsync();
		public Task<User> PatchAsync(string buyerID, string userID, PartialUser partialUser) => Request("v1", "buyers", buyerID, "users", userID).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User>();
		public Task<User<Txp>> PatchAsync<Txp>(string buyerID, string userID, PartialUser partialUser) => Request("v1", "buyers", buyerID, "users", userID).PatchJsonAsync(ValidateModel(partialUser)).ReceiveJson<User<Txp>>();
		public Task<User> MoveAsync(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders) => Request("v1", "buyers", buyerID, "users", userID, "moveto", newBuyerID).SetQueryParams(new { orders }).PostAsync(null).ReceiveJson<User>();
		public Task<User<Txp>> MoveAsync<Txp>(string buyerID, string userID, string newBuyerID, UserOrderMoveOption orders) => Request("v1", "buyers", buyerID, "users", userID, "moveto", newBuyerID).SetQueryParams(new { orders }).PostAsync(null).ReceiveJson<User<Txp>>();
		public Task<AccessToken> GetAccessTokenAsync(string buyerID, string userID, ImpersonateTokenRequest impersonateTokenRequest) => Request("v1", "buyers", buyerID, "users", userID, "accesstoken").PostJsonAsync(ValidateModel(impersonateTokenRequest)).ReceiveJson<AccessToken>();
	}
}
