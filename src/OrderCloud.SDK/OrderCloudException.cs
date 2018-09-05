using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Flurl.Http;

namespace OrderCloud.SDK
{
	public class OrderCloudException : Exception
	{
		public HttpStatusCode? HttpStatus { get; }
		public ApiError[] Errors { get; }

		internal OrderCloudException(HttpCall call, ApiErrorResponse resp) : base(BuildMessage(call, resp), call.Exception) {
			HttpStatus = call.HttpStatus;
			Errors = resp.Errors;
		}

		private static string BuildMessage(HttpCall call, ApiErrorResponse resp) =>
			resp?.Errors?.FirstOrDefault()?.Message ??
			call?.Exception?.Message ??
			"An unknown error occurred.";
	}

	public class ApiErrorResponse
	{
		public ApiError[] Errors { get; set; }
	}

	public class ApiError
	{
		public string ErrorCode { get; set; }
		public string Message { get; set; }
		public object Data { get; set; }
	}
}
