using Ifpa.ApiClient;
using System;

namespace ApiDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			IfpaApiClient apiClient = new IfpaApiClient("https://api.ifpapinball.com/v1/", "6e3db34fce30f6f614425382344eee91");

			//			var playerApiResponse = apiClient.Player.Get(123);
			//			if (playerApiResponse.Success) Console.WriteLine(playerApiResponse.Data.Information.FirstName);
			//			else Console.WriteLine(playerApiResponse.Error.Code)

			var response = apiClient.Calendar.GetActive();
			if (response.Success) Console.WriteLine("woo");
		}
	}
}
