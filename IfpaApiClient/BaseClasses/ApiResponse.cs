using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Ifpa.ApiClient.BaseClasses
{
	public class ApiResponse<T>
	{
		public ApiResponse(HttpStatusCode httpStatusCode, T data, ErrorModel error = null)
		{
			this.HttpStatusCode = httpStatusCode;
			this.Data = data;
			this.Error = error;
		}

		public HttpStatusCode HttpStatusCode { get; private set; }

		public T Data { get; private set; }

		public ErrorModel Error { get; private set; }

		/// <summary>
		/// Returns true if the HTTPStatus indicates the request was successful.
		/// </summary>
		public bool Success => ((int)HttpStatusCode >= 200 && (int)HttpStatusCode <= 299);
	}
}
