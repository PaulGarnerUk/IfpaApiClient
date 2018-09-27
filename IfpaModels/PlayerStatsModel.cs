using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models
{
	public class PlayerStatsModel
	{
		/*
		  "player_stats":{  
			"total_events_away":"6",
			"ratings_rank":"14",
			"ratings_value":"1869.77",
			"efficiency_rank":"58",
			"efficiency_value":42.78
		},

		 * */

		[JsonProperty("current_wppr_rank")]
		public int CurrentRank { get; set; }

		[JsonProperty("last_month_rank")]
		public int LastMonthRank { get; set; }

		[JsonProperty("last_year_rank")]
		public int LastYearRank { get; set; }

		[JsonProperty("highest_rank")]
		public int HighestRank { get; set; }

		[JsonProperty("highest_rank_date")]
		public DateTime HighestRankDate { get; set; }

		[JsonProperty("current_wppr_value")]
		public decimal CurrentWpprValue { get; set; }

		[JsonProperty("wppr_points_all_time")]
		public decimal WpprPointsAllTime { get; set; }

		[JsonProperty("best_finish")]
		public int BestFinish { get; set; }

		[JsonProperty("best_finish_count")]
		public int BestFinishCount { get; set; }

		[JsonProperty("average_finish")]
		public int AverageFinish { get; set; }

		[JsonProperty("average_finish_last_year")]
		public int AverageFinishLastYear { get; set; }

		[JsonProperty("total_events_all_time")]
		public int TotalEventsAllTime { get; set; }

		[JsonProperty("total_active_events")]
		public int TotalActiveEvents { get; set; }

		[JsonProperty("total_events_away")]
		public int TotalEventsAway { get; set; }

		[JsonProperty("ratings_rank")]
		public int RatingsRank { get; set; }

		[JsonProperty("ratings_value")]
		public decimal RatingsValue { get; set; }

		[JsonProperty("efficiency_rank")]
		public int EfficiencyRank { get; set; }

		[JsonProperty("efficiency_value")]
		public decimal EfficiencyValue { get; set; }
	}
}
