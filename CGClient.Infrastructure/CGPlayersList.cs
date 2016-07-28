using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class CGPlayersList : IPlayersList
    {
        private IWebApi _webApi;

        public CGPlayersList(IWebApi webApi)
        {
            _webApi = webApi;
        }

        public async Task<List<Player>> GetPlayersAsync()
        {
            var parameters = new object[2] { new { divisionId = 38, roomIndex = 0 }, ""};
            var r = await _webApi.PostAsync<CGUserResult>("/services/LeaderboardsRemoteService/getCompatibleAgentsLeaderboard", parameters);
            return r.success.users.Select(x => new Player(x.agentId, x.pseudo)).ToList();

        }

        public List<Player> GetPlayers()
        {
            var parameters = new object[2] { new { divisionId = 38, roomIndex = 0 }, "" };
            var r = _webApi.Post<CGUserResult>("/services/LeaderboardsRemoteService/getCompatibleAgentsLeaderboard", parameters);
            return r.success.users.Select(x => new Player(x.agentId, x.pseudo)).ToList();
        }
    }
}
