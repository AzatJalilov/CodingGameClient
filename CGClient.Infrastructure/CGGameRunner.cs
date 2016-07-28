using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class CGGameRunner : IGameRunner
    {
        public string IDEId { get; set; }
        IWebApi _webApi { get; set; }

        public CGGameRunner(IWebApi webApi)
        {
            _webApi = webApi;
            IDEId = "4845563ca6d433ef34c1e63e98a";
        }

        
        
        public int Run(string code, int firstId, int secondId)
        {
            var parameters = new object[2] { IDEId, new CGMultiRequest(code, firstId, secondId) };
            var r = _webApi.Post<CGGameResult>("services/TestSessionRemoteService/play", parameters);
            if (r.success.scores[0] > r.success.scores[1])
            {
                return 1;
            }
            else if (r.success.scores[0] < r.success.scores[1])
            {
                return -1;
            }
            return 0;
        }

        public async Task<int> RunAsync(string code, int firstId, int secondId)
        {
            var parameters = new object[2] { IDEId, new CGMultiRequest(code, firstId, secondId) };
            var r = await _webApi.PostAsync<CGGameResult>("services/TestSessionRemoteService/play", parameters);
            if (r.success.scores[0] > r.success.scores[1])
            {
                return 1;
            }
            else if (r.success.scores[0] < r.success.scores[1])
            {
                return -1;
            }
            return 0;


        }
    }
}

