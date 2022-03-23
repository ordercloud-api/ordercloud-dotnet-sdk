using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace OrderCloud.SDK
{
    public static class FlurlExtensions
    {
	    public static IFlurlRequest SetListOptions<T>(this IFlurlRequest req, Action<ListOptionsBuilder<T>> buildListOpts) {
		    if (buildListOpts == null)
			    return req;

		    var builder = new ListOptionsBuilder<T>();
		    buildListOpts(builder);

		    return req.SetListOptions(builder.Build());
	    }

		public static IFlurlRequest SetListOptions<T>(this IFlurlRequest req, Action<ListOptionsBuilder2<T>> buildListOpts) {
		    if (buildListOpts == null)
			    return req;

		    var builder = new ListOptionsBuilder2<T>();
		    buildListOpts(builder);

		    return req.SetListOptions(builder.Build());
	    }

		private static IFlurlRequest SetListOptions(this IFlurlRequest req, ListOptions opts) {
		    return req
			    .SetQueryParams(new {
				    search = opts.Search,
				    searchOn = opts.SearchOn,
				    searchType = opts.SearchType,
				    sortBy = opts.SortBy,
				    page = opts.Page,
				    pageSize = opts.PageSize,
				    pageKey = opts.PageKey
			    })
			    .SetQueryParams(opts.Filters
				    .GroupBy(f => f.Key, f => f.Value)
				    .Select(g => new { key = g.Key, value = g }));
	    }
    }
}
