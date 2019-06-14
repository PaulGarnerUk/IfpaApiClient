using Ifpa.ApiClient.Endpoints;
using Ifpa.ApiClient.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.ApiClient
{
	public class IfpaApiClient
	{
		private Lazy<IPlayer> player;
		private Lazy<ICalendar> calendar;

		public IfpaApiClient(string apiKey, string baseUrl = "https://api.ifpapinball.com/v1/")
		{
			this.RestClient = new RestClient(baseUrl, apiKey);

			this.player = new Lazy<IPlayer>(() => new Player(this));
			this.calendar = new Lazy<ICalendar>(() => new Calendar(this));
		}

		public IPlayer Player => this.player.Value;

		public ICalendar Calendar => this.calendar.Value;

		#region Private/internal implementation

		internal IRestClient RestClient { get; set; }

		#endregion
	}
}
