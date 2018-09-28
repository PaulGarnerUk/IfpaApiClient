using Ifpa.ApiClient.BaseClasses;
using Ifpa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.ApiClient.Interfaces
{
	public interface ICalendar
	{
		ApiResponse<CalendarModel> GetActive(string countryName = null);

		ApiResponse<CalendarModel> GetHistory(string countryName = null);

	}
}
