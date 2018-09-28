using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.Models
{
	public class CalendarModel
	{
		[JsonProperty("calendar")]
		public List<CalendarEntryModel> CalendarEntries { get; set; }
	}
}
