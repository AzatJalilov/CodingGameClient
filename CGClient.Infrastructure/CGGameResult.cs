using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class CGGameRes
    {
        public int gameId { get; set; }
        public string refereeInput { get; set; }
        public double[] scores { get; set; }
        public int[] ranks { get; set; }
    }
    public class CGGameResult
    {
        public CGGameRes success { get; set; }
    }
}
