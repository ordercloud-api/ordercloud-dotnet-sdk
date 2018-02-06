using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Reflection;
using Flurl.Http;

namespace OrderCloud.SDK
{
	/// <summary>
	/// Abstract base class corresponding to an OrderCloud resource, such as Orders, Products, Users, etc. Contains a set of methods
	/// for calling endpoints specific to that resource.
	/// </summary>
	public abstract class OrderCloudResource
	{
		private readonly OrderCloudClient _client;
		protected OrderCloudResource(OrderCloudClient client) => _client = client;

		protected internal IFlurlRequest Request(params object[] pathSegments) => _client.Request(pathSegments);

		/// <summary>
		/// Throws an ArgumentException if any property marked [Required] is null (or empty string)
		/// </summary>
		protected internal TModel ValidateModel<TModel>(TModel model) where TModel : OrderCloudModel {
			if (!_client.EnableModelValidation)
				return model;

			foreach (var prop in typeof(TModel).GetProperties()) {
				if (prop.GetCustomAttribute<RequiredAttribute>() == null)
					continue;

				if (model is IPartial && !model.Props.ContainsKey(prop.Name))
					continue;

				var val = prop.GetValue(model);
				if (val == null || val as string == "")
					throw new ArgumentException($"{typeof(TModel).Name}.{prop.Name} is required.");
			}
			return model;
		}
	}
}
