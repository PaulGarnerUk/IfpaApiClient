using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models
{
	/// <summary>
	/// Returned from query to GET /player/:id/results
	/// 
	/// Example in API documentation seems wrong. There is no sub list	
	/// </summary>
	public sealed class PlayerTournamentResultModel
	{
		[JsonProperty("tournament_id")]
		public int TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("event_name")]
		public string EventName { get; set; }

		[JsonProperty("event_date")]
		public DateTime EventDate { get; set; }

		// not finished

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("periodic_flag")]
		[JsonConverter(typeof(BooleanJsonConverter))]
		public bool Periodic { get; set; }

		[JsonProperty("wppr_state")]
		public string WpprState { get; set; } // TODO: Enumerate or make bool.  Value like 'Active' (and presumably Not Active?)

//		public List<PlayerTournamentEventResultModel>
	}
}
