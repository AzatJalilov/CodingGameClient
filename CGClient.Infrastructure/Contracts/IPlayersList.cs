using System.Collections.Generic;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public interface IPlayersList
    {
        Task<List<Player>> GetPlayersAsync();
        List<Player> GetPlayers();
    }
}