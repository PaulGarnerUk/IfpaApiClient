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

		public IfpaApiClient(string baseUrl, string apiKey)
		{
			this.RestClient = new RestClient(baseUrl, apiKey);

			this.player = new Lazy<IPlayer>(() => new Player(this));
		}

		public IPlayer Player => this.player.Value;

		#region Private/interal implementation

		internal IRestClient RestClient { get; set; }

		#endregion
	}
}
