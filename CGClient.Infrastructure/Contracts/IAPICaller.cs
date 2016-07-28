using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public interface IAPICaller
    {
        int GetGameResult(string code, int firstId, int secondId);
        List<Player> GetPlayers();
        Task<List<Player>> GetPlayersAsync();
    }
}
