using Ifpa.ApiClient.BaseClasses;
using Ifpa.ApiClient.Interfaces;
using Ifpa.Models;

namespace Ifpa.ApiClient.Endpoints
{
	public class Player : ApiClientBase, IPlayer
	{
		public static string PlayerEndpoint = "player";

		public Player(IfpaApiClient apiClient) : base(apiClient)
		{
		}

		public ApiResponse<PlayerModel> Get(int playerId)
		{
			// https://api.ifpapinball.com/v1/player/6?api_key=RNDOAMGNAJTGQWKQ
			return base.RestClient.Get<PlayerModel>($"{PlayerEndpoint}/{playerId}");
		}

		public ApiResponse<PlayerResultsModel> GetResults(int playerId)
		{
			// https://api.ifpapinball.com/v1/player/6/results?api_key=RNDOAMGNAJTGQWKQ
			return base.RestClient.Get<PlayerResultsModel>($"{PlayerEndpoint}/{playerId}/results");
		}


	}
}
