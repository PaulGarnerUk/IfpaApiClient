using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models
{
	[JsonObject("player")]
	public class PlayerInformationModel
	{
		[JsonProperty("player_id")]
		public int Id { get; set; }

		[JsonProperty("first_name")]
		public string FirstName { get; set; }

		[JsonProperty("last_name")]
		public string LastName { get; set; }

		[JsonProperty("city")]
		public string City { get; set; }

		[JsonProperty("state")]
		public string State { get; set; }

		[JsonProperty("country_code")]
		public string CountryCode { get; set; }

		[JsonProperty("country_name")]
		public string CountryName { get; set; }

		[JsonProperty("initials")]
		public string Initals { get; set; }

		[JsonProperty("age")]
		public int Age { get; set; }

		[JsonProperty("excluded_flag")]
		[JsonConverter(typeof(BooleanJsonConverter))]
		public bool Excluded { get; set; }

		[JsonProperty("ifpa_registered")]
		[JsonConverter(typeof(BooleanJsonConverter))]
		public bool Registered { get; set; }

		public string FullName => FirstName + " " + LastName;
	}

}
