using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace OrderCloud.SDK
{
	public abstract class WebhookPayload<TRequest, TResponse, TRouteParams, TConfigData>
	{
		public string Route { get; set; }
		public TRouteParams RouteParams { get; set; }
		public string Verb { get; set; }
		public DateTimeOffset? Date { get; set; }
		public string LogID { get; set; }
		public string UserToken { get; set; }
		public HttpMessage<TRequest> Request { get; set; }
		public HttpMessage<TResponse> Response { get; set; }
		public TConfigData ConfigData { get; set; }

		public class HttpMessage<TBody>
		{
			public TBody Body { get; set; }
			public string Headers { get; set; }
		}
	}

	/// <summary>
	/// Webhook payload sent by OrderCloud. Strongly-typed payloads corresponding to specific endpoints are available
	/// under WebhookPayloads.{Resource}.{Endpoint}, i.e. WebhookPayloads.Orders.Submit.
	/// </summary>
	public class WebhookPayload : WebhookPayload<dynamic, dynamic, dynamic, dynamic> { }

	/// <summary>
	/// Webhook payload sent by OrderCloud. Strongly-typed payloads corresponding to specific endpoints are available
	/// under WebhookPayloads.{Resource}.{Endpoint}, i.e. WebhookPayloads.Orders.Submit.
	/// </summary>
	/// <typeparam name="TConfigData">Type whose properties represent Config Data name/value pairs specified in OrderCloud Dev Center.</typeparam>
	public class WebhookPayload<TConfigData> : WebhookPayload<dynamic, dynamic, dynamic, TConfigData> { }

	public class SentOnAttribute : Attribute
	{
		public SentOnAttribute(string verb, string route) {
			Verb = verb;
			Route = route;
		}

		public string Verb { get; }
		public string Route { get; }
	}

	/// <summary>
	/// Webhooks configured as pre-hooks can return a response indicating whether or not OrderCloud.io should
	/// proceed with processing the request. For example, you can use a webhook to provide custom validation
	/// on order submit, and block the submission if that validation fails.
	/// </summary>
	public class WebhookResponse
	{
		/// <summary>
		/// Returns a webhook response indicating that OrderCloud.io should proceed with normal processing of the request.
		/// </summary>
		public static WebhookResponse Proceed() => new WebhookResponse { proceed = true };

		/// <summary>
		/// Returns a webhook response indicating that OrderCloud.io should NOT proceed with normal processing of the request.
		/// </summary>
		public static WebhookResponse Block() => new WebhookResponse { proceed = false };

		/// <summary>
		/// A value indicating whether OrderCloud.io should proceed with normal processing of the request.
		/// </summary>
		public bool proceed { get; set; }
	}
}
