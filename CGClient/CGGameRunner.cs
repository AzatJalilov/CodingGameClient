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
    public class CGGameRunner
    {
        public int myScore = 0;
        public int oppScore = 0;

        public void Run()
        {
            while (true)
            {
                var r = RunAsync();
                if(r != null)
                {
                    r.Wait();
                    Console.WriteLine($"{myScore} - {oppScore}");
                }

                

            }
        }

        public async Task RunAsync()
        {
            var baseAddress = new Uri("https://www.codingame.com/");
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {

                cookieContainer.Add(baseAddress, new Cookie("remcg", "9eKVLLSCEDRW5mIORKZ3o7kATO/Rf62XcnEiJjIc9cjZzxxXqdd5DmS3lz0/Mzsqi7rSklTQW6BKXgm+DS0dNMGqSYqtKRA4cws6XqbNU588pNTKCe7MXISL3Ua+B3rgo5V6KbR2oaLXnxaHri0Az4RsoVNgIQA5BDsLzVAEETNDMvZf18Z0LnfLxTtdEImGSyku6IxEVrMJJ0YeQYu3SfMhB1F0oVSKCsS1I/YkIEX8gtvAw7ihNiTpzpxOE4uQZ0wJQfNq0OtrIeh3hc0c/es/8a/JBrmQllMIfAW2QWkrw8iK6LNysC7XZ/8W44sQNdR6cL3Ne0qNviL10ZnclhdYEgQgQh/jmI+1J6ewQkBP1FGW/fpn/t6kkmqvTeiwF5d8Lwg9F+0X4C3h28clWLG5p5y2wsdCkHZ0qj2PyLmpirf9gGSfl5XFKYF6Kx4kh4+Hcndkv3TWi0qmEUffr46df6trj9HT6wX17sxvP1FvxVXEeAoxSD5fwGzNIAxmtBpqoQkJFgNUk/YCTmYx4SJ9hYagpWMuTlQSJBBsnQO2wV1gfARVYXRvEYPevB5e+9YWF55AaDwgrLo8rWzaaA==	"));

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                var code = File.ReadAllText("D:/code.txt");
                var request = new object[2] { "4845563ca6d433ef34c6a8622d542931e63e98a", new CGMultiRequest(code, 604826) };

                var response = await client.PostAsJsonAsync("services/TestSessionRemoteService/play", request);
                var stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<CGGameResult>(stringResult);
                if (result.success.scores[0] > result.success.scores[1])
                {
                    myScore++;
                }
                else if (result.success.scores[0] < result.success.scores[1])
                {
                    oppScore++;
                }

            }
        }
    }
}

