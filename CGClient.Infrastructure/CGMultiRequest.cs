using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class CGMultiRequest
    {
        public string code { get; set; }
        public string programmingLanguageId { get; set; }
        public CGMulti multi { get; set; }
        public CGMultiRequest(string code, int firstId, int secondId)
        {
            this.code = code;
            programmingLanguageId = "C#";
            multi = new CGMulti() { agentsIds = new int[2] { firstId, secondId }, gameOptions = "null" };
        }

    }

    public class CGMulti
    {
        public int[] agentsIds { get; set; }
        public string gameOptions { get; set; }
    }
}
