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

		    return req.SetListOptions(opts.Search, opts.SearchOn, opts.SortBy, opts.Page, opts.PageSize, opts.Filters);
	    }

	    public static IFlurlRequest SetListOptions(this IFlurlRequest req, string search, string searchOn, string sortBy, int? page, int? pageSize, object filters) {
		    return req
			    .SetQueryParams(new { search, searchOn, sortBy, page, pageSize })
			    .SetQueryParams(filters);
	    }
    }
}
