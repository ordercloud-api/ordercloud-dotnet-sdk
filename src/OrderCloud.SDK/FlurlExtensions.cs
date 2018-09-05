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
		    var opts = builder.Build();

		    var filters = opts.Filters
			    .GroupBy(f => f.Key, f => f.Value)
			    .Select(g => new { key = g.Key,  value = g });

		    return req.SetListOptions(opts.Search, opts.SearchOn, opts.SortBy, opts.Page, opts.PageSize, filters);
	    }

	    public static IFlurlRequest SetListOptions(this IFlurlRequest req, string search, string searchOn, string sortBy, int? page, int? pageSize, object filters) {
		    return req
			    .SetQueryParams(new { search, searchOn, sortBy, page, pageSize })
			    .SetQueryParams(filters);
	    }
    }
}
