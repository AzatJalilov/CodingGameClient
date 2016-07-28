using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class APICaller : IAPICaller
    {
        
        private IGameRunner _gameRunner { get; set; }
        private IPlayersList _playersList { get; set; }
        public APICaller(IGameRunner gameRunner, IPlayersList playersList)
        {
            _gameRunner = gameRunner;
            _playersList = playersList;
        }
        public int GetGameResult(string code, int firstId, int secondId)
        {
            return _gameRunner.Run(code, firstId, secondId);
        }

        public List<Player> GetPlayers()
        {
            return _playersList.GetPlayers();
        }

        public Task<List<Player>> GetPlayersAsync()
        {
            return _playersList.GetPlayersAsync();
        }
    }
}
