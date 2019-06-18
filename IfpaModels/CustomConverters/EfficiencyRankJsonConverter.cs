using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models.CustomConverters
{
	// Custom converter, because sometimes this integer is a string 'Not Ranked'
	public class EfficiencyRankJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return (objectType == typeof(int));
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			if (reader.Value.ToString().ToLower().Trim() == "not ranked") return 0;
			else return new JsonSerializer().Deserialize(reader, objectType);
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			// N/A
		}
	}

}
