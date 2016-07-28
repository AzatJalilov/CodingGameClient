using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class CGUserRes
    {
        public CGUser[] users { get; set; }
    }
    public class CGUserResult
    {
        public CGUserRes success { get; set; }
    }
    public class CGUser
    {
        public string pseudo { get; set; }
        public int agentId { get; set; }
    }
}
