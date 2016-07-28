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

namespace CGClient
{
    class Program
    {

        static void Main(string[] args)
        {
            var runner = new CGGameRunner();
            runner.Run();

        }
    }
}
