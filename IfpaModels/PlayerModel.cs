using Newtonsoft.Json;
using System;

namespace Ifpa.Models
{
	[JsonObject("player")]
	public class PlayerModel
	{
		// Not a big fan of the way IFPA have modelled things.
		// Might consider flattening this, so that all PlayerInformation and PlayerStats are available directly here.  
		// This might mean having two versions of the models. This one that matches what IFPA return, and another for my remapped models
		// (The remapped models could possibly reference the ifpa models privately, and remap like...
		//		public int CurrentRank => Stats.CurrentRank;

		[JsonProperty("player")]
		public PlayerInformationModel Information { get; set; }

		[JsonProperty("player_stats")]
		public PlayerStatsModel Stats { get; set; }

		/*
		 {  
		   "player":{  
			  "player_id":"4",
			  "first_name":"Josh",
			  "last_name":"Sharpe",
			  "city":"Palatine",
			  "state":"IL",
			  "country_code":"US",
			  "country_name":"United States",
			  "initials":"JLS",
			  "age":34,
			  "excluded_flag":"N",
			  "ifpa_registered":"Y"
		   },
		   "player_stats":{  
			  "current_wppr_rank":"18",
			  "last_month_rank":"17",
			  "last_year_rank":"16",
			  "highest_rank":"2",
			  "highest_rank_date":"2004-07-01",
			  "current_wppr_value":"591.52",
			  "wppr_points_all_time":"2893.79",
			  "best_finish":"1",
			  "best_finish_count":"39",
			  "average_finish":"8",
			  "average_finish_last_year":"11",
			  "total_events_all_time":"230",
			  "total_active_events":"92",
			  "total_events_away":"6",
			  "ratings_rank":"14",
			  "ratings_value":"1869.77",
			  "efficiency_rank":"58",
			  "efficiency_value":42.78
		   },
		   "championshipSeries":[
			  {  
				 "view_id":"90",
				 "group_code":"KY",
				 "group_name":"Kentucky",
				 "rank":"2",
				 "country_name":"US"

			  },
			  {  
				 "view_id":"87",
				 "group_code":"IL",
				 "group_name":"Illinois",
				 "rank":"6",
				 "country_name":"US"
			  },
			  { ... more... }   
		   ]
		}
	 */

	}
}
