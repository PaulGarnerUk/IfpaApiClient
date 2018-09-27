using Ifpa.ApiClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.ApiClient.BaseClasses
{
	public class ApiClientBase
	{
		public ApiClientBase(IfpaApiClient client)
		{
			this.RestClient = client.RestClient;
		}

		internal IRestClient RestClient { get; private set; }
	}
}
