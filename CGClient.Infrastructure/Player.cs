using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class Player
    {
        public Player(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public string Name { get; set; }
        public int Id { get; set; }
    }
}
