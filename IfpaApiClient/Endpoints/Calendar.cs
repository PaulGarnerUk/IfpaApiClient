using Ifpa.ApiClient.BaseClasses;
using Ifpa.ApiClient.Interfaces;
using Ifpa.Models;
using System.Collections.Generic;

namespace Ifpa.ApiClient.Endpoints
{
	class Calendar : ApiClientBase, ICalendar
	{
		public static string CalendarEndpoint = "calendar";

		public Calendar(IfpaApiClient apiClient) : base(apiClient)
		{
		}

		public ApiResponse<CalendarModel> GetActive(string countryName = null)
		{
			// https://api.ifpapinball.com/v1/calendar/active?api_key=RNDOAMGNAJTGQWKQ&country=Sweden
			return base.RestClient.Get<CalendarModel> ($"{CalendarEndpoint}/active");
		}

		public ApiResponse<CalendarModel> GetHistory(string countryName = null)
		{ 
			// https://api.ifpapinball.com/v1/calendar/history?api_key=RNDOAMGNAJTGQWKQ&country=Sweden
			return base.RestClient.Get<CalendarModel> ($"{CalendarEndpoint}/history");
		}

	}
}
