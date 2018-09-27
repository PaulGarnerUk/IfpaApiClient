using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models
{
	public sealed class PlayerResultsModel
	{
		[JsonProperty("player_id")]
		public int PlayerId { get; set; }

		public int ResultsCount => TournamentResults.Count;

		[JsonProperty("results")]
		public List<PlayerTournamentResultModel> TournamentResults { get; set; } = new List<PlayerTournamentResultModel>();
	}
}
