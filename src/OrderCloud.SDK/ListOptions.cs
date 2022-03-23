using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderCloud.SDK
{
	/// <summary>
	/// An object built fluently in certain List*Async overloads, serialized as URL query parameters.
	/// </summary>
	public class ListOptions
	{
		public string Search { get; set; }
		public string SearchOn { get; set; }
		/// <summary>
		/// Available only for endpoints that support Premium Search.
		/// </summary>
		public SearchType? SearchType { get; set; }
		public string SortBy { get; set; }
		public int? Page { get; set; }
		public int? PageSize { get; set; }
		/// <summary>
		/// Preferred alternative to Page and PageSize when Page > 1 AND value is provided in previous page's Meta.NextPageKey. Provides additional metadata to OC for improved performance.
		/// </summary>
		public string PageKey { get; set; }
		public IList<KeyValuePair<string, string>> Filters { get; set; } = new List<KeyValuePair<string, string>>();
	}
}
