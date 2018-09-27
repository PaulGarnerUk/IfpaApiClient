using Ifpa.ApiClient.BaseClasses;
using Ifpa.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ifpa.ApiClient.Interfaces
{
    public interface IPlayer
    {
		ApiResponse<PlayerModel> Get(int playerId);

//		ApiResponse<PlayerModel> GetResults(int playerId);
	}
}
