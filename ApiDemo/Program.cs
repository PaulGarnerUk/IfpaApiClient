using Ifpa.ApiClient;
using System;

namespace ApiDemo
{
    class Program
    {
		static void Main(string[] args)
        {
			IfpaApiClient apiClient = new IfpaApiClient("https://api.ifpapinball.com/v1/", "keygoeshere");

			var playerApiResponse = apiClient.Player.Get(123);

			if (playerApiResponse.Success) Console.WriteLine(playerApiResponse.Data.Information.FirstName);
//			else Console.WriteLine(playerApiResponse.Error.Code)
        }
    }
}
