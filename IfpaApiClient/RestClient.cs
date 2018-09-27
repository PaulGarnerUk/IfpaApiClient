using Ifpa.ApiClient.BaseClasses;
using Ifpa.ApiClient.Interfaces;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Ifpa.ApiClient
{
	/// <summary>
	/// Class for managing REST requests
	/// This is effectively a singleton due to the way it's atached to the Client
	/// </summary>
	internal class RestClient : IRestClient
	{
		private HttpClient httpClient = new HttpClient();

		public RestClient(string baseUrl, string apiKey)
		{
			this.BaseUrl = baseUrl;
			this.ApiKey = apiKey;
		}

		public string BaseUrl { get; private set; }

		public string ApiKey { get; private set; }

		/// <summary>
		/// Event is triggered when API requests authentication.
		/// </summary>
		public event EventHandler AuthenticationRequestHandler;

		public HttpRequestHeaders Headers => httpClient.DefaultRequestHeaders;

		public ApiResponse<T> Get<T>(string endpoint, string jsonRequest = null)
		{
			string urlWithEndpoint = $"{BaseUrl}{endpoint}?api_key={ApiKey}";

			HttpResponseMessage httpResponse;
			int attempt = 0;

			do
			{
				attempt++;
				httpResponse = httpClient.GetAsync(urlWithEndpoint).Result;
			}
			while (RetryRequired(httpResponse, attempt));

			return ApiResponseFromHttpResponse<T>(httpResponse);
		}

		public async Task<ApiResponse<T>> GetAsync<T>(string endpoint, string jsonRequest = null)
		{
			string urlWithEndpoint = $"{BaseUrl}{endpoint}?api_key={ApiKey}";
			//Uri moop = new Uri("");
			
			HttpResponseMessage httpResponse;
			int attempt = 0;

			do
			{
				attempt++;
				httpResponse = await httpClient.GetAsync(urlWithEndpoint);
			}
			while (RetryRequired(httpResponse, attempt));

			return ApiResponseFromHttpResponse<T>(httpResponse);
		}


		private bool RetryRequired(HttpResponseMessage responseMessage, int attempt)
		{
			if (responseMessage.IsSuccessStatusCode) return false;

			if (responseMessage.StatusCode == System.Net.HttpStatusCode.Unauthorized && attempt <= 1)
			{
				// Perform authentication
				this.AuthenticationRequestHandler?.Invoke(this, new EventArgs());
				return true; // to try again
			}

			// Could have something about timeout retries here?

			return false; // Something else bad happened, but a retry won't solve it.
		}

		private ApiResponse<T> ApiResponseFromHttpResponse<T>(HttpResponseMessage httpResponse)
		{
			if (httpResponse.IsSuccessStatusCode)
			{
				string json = httpResponse.Content.ReadAsStringAsync().Result;
				T modelResponse = JsonConvert.DeserializeObject<T>(json);
				return new ApiResponse<T>(httpResponse.StatusCode, modelResponse);
			}
			else
			{
				string httpResponseData = httpResponse.Content.ReadAsStringAsync().Result;
				return new ApiResponse<T>(httpResponse.StatusCode, default(T), new ErrorModel(httpResponseData));
			}
		}



	}


}
