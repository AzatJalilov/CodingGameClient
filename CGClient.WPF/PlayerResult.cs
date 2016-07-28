using CGClient.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.WPF
{
    public class PlayerResult
    {
        public Player Player { get; set; }
        public int Win { get; set; }
        public int Lose { get; set; }
        public int Draw { get; set; }

        public PlayerResult(Player player)
        {
            Player = player;
            Win = 0;
            Lose = 0;
            Draw = 0;
        }
    }
}
