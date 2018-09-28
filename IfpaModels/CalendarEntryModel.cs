using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models
{
	public class CalendarEntryModel
	{
		[JsonProperty("calendar_id")]
		public int CalendarId { get; set; }

		[JsonProperty("tournament_id")]
		public int TournamentId { get; set; }

		[JsonProperty("tournament_name")]
		public string TournamentName { get; set; }

		[JsonProperty("address1")]
		public string Address1 { get; set; }

		[JsonProperty("address2")]
		public string Address2 { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("zipcode")]
		public string Zipcode { get; set; }

		[JsonProperty("country_name")]
		public string Country { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("website")]
		public string Website { get; set; }

		[JsonProperty("euro_champ_flag")]
		[JsonConverter(typeof(BooleanJsonConverter))]
		public bool EuroChampionship { get; set; }

		[JsonProperty("papa_circuit_flag")]
		[JsonConverter(typeof(BooleanJsonConverter))]
		public bool PapaCircuit { get; set; }

		[JsonProperty("director_name")]
		public string DirectorName { get; set; }

		[JsonProperty("latitude")]
		public double Latitude { get; set; }

		[JsonProperty("longitude")]
		public double Longitude { get; set; }

		[JsonProperty("details")]
		public string Details { get; set; }

		[JsonProperty("private_flag")]
		[JsonConverter(typeof(BooleanJsonConverter))]
		public bool Private { get; set; }

		[JsonProperty("start_date")]
		public DateTime StartDate { get; set; }

		[JsonProperty("end_date")]
		public DateTime EndDate { get; set; }

		/*
		 * {
			 "calendar_id":"6981",
			 "tournament_id":"6616",
			 "tournament_name":"Stockholm Pinball",
			 "address1":"123 Main St",
			 "address2":"",
			 "city":"Stockholm",
			 "state":"",
			 "zipcode":"12632",
			 "country":"Sweden",
			 "website":"http:\/\/stockholmpinball.com\/",
			 "euro_champ_flag":"N",
			 "papa_circuit_flag":"N",
			 "director_name":"Some person",
			 "latitude":"59.3022",
			 "longitude":"18.0149",
			 "details":"System varies, but typically set-the-highscore qualifications and then top-8",
			 "private_flag":"N",
			 "start_date":"2014-08-22",
			 "end_date":"2014-08-22"
		  },
		 */
	}
}
