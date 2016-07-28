using Caliburn.Micro;
using CGClient.Infrastructure;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows;
namespace CGClient.WPF
{
    
    public class ShellViewModel : PropertyChangedBase, IShell {
        IAPICaller _api;
        private readonly BackgroundWorker worker = new BackgroundWorker();
        public ShellViewModel(IAPICaller api)
        {
            _api = api;
            Code = File.ReadAllText("D:/code.txt");
            PlayerResults = new List<PlayerResult>();
            foreach(var player in api.GetPlayers())
            {
                PlayerResults.Add(new PlayerResult(player));
            }
            
        }
        string _code;
        public string Code
        {
            get
            {
                return _code;
            }
            set
            {
                _code = value;
                NotifyOfPropertyChange(() => Code);
            }
        }

        PlayerResult _selectedPlayerResult;
        public PlayerResult SelectedPlayerResult
        {
            get
            {
                return _selectedPlayerResult;
            }
            set
            {
                _selectedPlayerResult = value;
                NotifyOfPropertyChange(() => SelectedPlayerResult);
            }
        }

        public void Run()
        {
            if(SelectedPlayerResult != null && SelectedPlayerResult.Player != null)
            {
                if (!worker.IsBusy)
                {
                    worker.DoWork += worker_DoWork;
                    worker.RunWorkerCompleted += worker_RunWorkerCompleted;
                    worker.RunWorkerAsync();
                }

                
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var r = _api.GetGameResult(Code, -1, SelectedPlayerResult.Player.Id);
                var player = PlayerResults.First(x => x.Player.Id == SelectedPlayerResult.Player.Id);
                if (r > 0)
                {
                    player.Win++;
                }
                else if (r < 0)
                {
                    player.Lose++;
                }
                else
                {
                    player.Draw++;
                }
                var newResults = new List<PlayerResult>();
                foreach (var res in PlayerResults)
                {
                    newResults.Add(res);
                }
                PlayerResults = newResults;
            }
        }

        private void worker_RunWorkerCompleted(object sender,
                                               RunWorkerCompletedEventArgs e)
        {
            
            
        }

        List<PlayerResult> _playerResults;
        public List<PlayerResult> PlayerResults
        {
            get
            {
                return _playerResults;
            }
            set
            {
                _playerResults = value;
                NotifyOfPropertyChange(() => PlayerResults);
                NotifyOfPropertyChange(() => SelectedPlayerResult);

            }
        }

    }
}
