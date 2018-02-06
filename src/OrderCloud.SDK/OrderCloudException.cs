using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace OrderCloud.SDK
{
	public class OrderCloudException : Exception
	{
		public HttpStatusCode? HttpStatus { get; }
		public ApiError[] Errors { get; }

		public OrderCloudException(Exception innerException, HttpStatusCode? httpStatus, ApiError[] errors) : base(innerException.Message, innerException) {
			HttpStatus = httpStatus;
			Errors = errors;
		}
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
