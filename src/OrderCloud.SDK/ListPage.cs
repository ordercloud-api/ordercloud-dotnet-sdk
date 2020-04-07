using System;
using System.Collections.Generic;

namespace OrderCloud.SDK
{
	/// <summary>
	/// Represents one page of a (potentially) larger data set.
	/// </summary>
	public class ListPage<T>
	{
		/// <summary>
		/// Metadata about this ListPage, including page size, total size of the data set, etc.
		/// </summary>
		public ListPageMeta Meta { get; set; }
		/// <summary>
		/// The actual data items contained in this page.
		/// </summary>
		public IList<T> Items { get; set; }
	}

	public class ListPageMeta
	{
		/// <summary>
		/// The current page of data. 1-based.
		/// </summary>
		public int Page { get; set; }
		/// <summary>
		/// Number of items per page of the data set. (If this is the last page, item count of this page may be smaller than PageSize.)
		/// </summary>
		public int PageSize { get; set; }
		/// <summary>
		/// Total number of items in the data set.
		/// </summary>
		public int TotalCount { get; set; }
		/// <summary>
		/// Total number of pages in the data set.
		/// </summary>
		public int TotalPages { get; set; }
		/// <summary>
		/// 2-integer array of first, last item number in this page. 1-based. Example: if this is page 1 and it contains 5 items, ItemRange is [1, 5].
		/// </summary>
		public int[] ItemRange { get; set; }
	}

	/// <summary>
	/// Represents one page of a (potentially) larger data set. Includes a Meta.Facets property, primarily useful for faceted navigation
	/// associated with premium product search.
	/// </summary>
	public class ListPageWithFacets<T>
	{
		/// <summary>
		/// Metadata about this ListPage, including page size, total size of the data set, etc.
		/// </summary>
		public ListPageMetaWithFacets Meta { get; set; }
		/// <summary>
		/// The actual data items contained in this page.
		/// </summary>
		public IList<T> Items { get; set; }
	}

	public class ListPageMetaWithFacets : ListPageMeta
	{
		/// <summary>
		/// Data for building faceted navigation. Currently only relevant populated for premium product search, otherwise null.
		/// </summary>
		public IList<ListFacet> Facets { get; set; }
	}

	public class ListFacet
	{
		/// <summary>
		/// Name of the facet.
		/// </summary>
		public string Name { get; set; }
		/// <summary>
		/// The field name (or path in dot notation if nested) to the facet value within product.xp.
		/// </summary>
		public string XpPath { get; set; }
		/// <summary>
		/// Values of the facet.
		/// </summary>
		public IList<ListFacetValue> Values { get; set; }
		/// <summary>
		/// Container for extended (custom) properties of the facet.
		/// </summary>
		public dynamic xp { get; set; }
	}

	public class ListFacetValue
	{
		/// <summary>
		/// Text of the facet value.
		/// </summary>
		public string Value { get; set; }
		/// <summary>
		/// Count of items within the current search context that match the facet value.
		/// </summary>
		public int Count { get; set; }
	}
}
