using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient
{
    public class CGMultiRequest
    {
        public string code { get; set; }
        public string programmingLanguageId { get; set; }
        public CGMulti multi { get; set; }
        public CGMultiRequest(string code, int opponentAgentId)
        {
            this.code = code;
            programmingLanguageId = "C#";
            multi = new CGMulti() { agentsIds = new int[2] { -1, opponentAgentId }, gameOptions = "null" };
        }

    }

    public class CGMulti
    {
        public int[] agentsIds { get; set; }
        public string gameOptions { get; set; }
    }
}
