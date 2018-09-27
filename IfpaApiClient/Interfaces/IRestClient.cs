using Ifpa.ApiClient.BaseClasses;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ifpa.ApiClient.Interfaces
{
	public interface IRestClient
	{
		HttpRequestHeaders Headers { get; }

		ApiResponse<T> Get<T>(string apiPath, string jsonRequest = null);

		Task<ApiResponse<T>> GetAsync<T>(string apiPath, string jsonRequest = null);

		/*
		ApiResponse<T> Post<T>(string apiPath, object request = null);

		Task<ApiResponse<T>> PostAsync<T>(string apiPath, object request = null);
*/
		event EventHandler AuthenticationRequestHandler;
	}
}
