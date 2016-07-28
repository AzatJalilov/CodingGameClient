using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CGClient.Infrastructure
{
    public class CGWebAPI : IWebApi
    {
        public string RemCG { get; set; }
        

        public CGWebAPI()
        {
            RemCG = "9eKVLLSCEDRW5mIORKZ3o7kATO/Rf62XcnEixaHri0Az4RsoVNgIQA5BDsLzVAEETNDMvZf18Z0LnfLxTtdEImGSyku6IxEVrMJJ0YeQYu3SfMhB1F0oVSKCsS1I/YkIEX8gtvAw7ihNiTpzpxOE4uQZ0wJQfNq0OtrIeh3hc0c/es/8a/JBrmQllMIfAW2QWkrw8iK6LNysC7XZ/8W44sQNdR6cL3Ne0qNviL10ZnclhdYEgQgQh/jmI+1J6ewQkBP1FGW/fpn/t6kkmqvTeiwF5d8Lwg9F+0X4C3h28clWLG5p5y2wsdCkHZ0qj2PyLmpirf9gGSfl5XFKYF6Kx4kh4+Hcndkv3TWi0qmEUffr46df6trj9HT6wX17sxvP1FvxVXEeAoxSD5fwGzNIAxmtBpqoQkJFgNUk/YCTmYx4SJ9hYagpWMuTlQSJBBsnQO2wV1gfARVYXRvEYPevB5e+9YWF55AaDwgrLo8rWzaaA==";
        }

        public async Task<T> PostAsync<T>(string endPoint, object[] parameters)
        {
            var baseAddress = new Uri("https://www.codingame.com/");
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {

                cookieContainer.Add(baseAddress, new Cookie("remcg", RemCG));

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = await client.PostAsJsonAsync(endPoint, parameters);
                var stringResult = await response.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(stringResult);
                return result;

            }
        }

        public T Post<T>(string endPoint, object[] parameters)
        {
            var baseAddress = new Uri("https://www.codingame.com/");
            var cookieContainer = new CookieContainer();
            using (var handler = new HttpClientHandler() { CookieContainer = cookieContainer })
            using (var client = new HttpClient(handler) { BaseAddress = baseAddress })
            {

                cookieContainer.Add(baseAddress, new Cookie("remcg", RemCG));

                client.DefaultRequestHeaders.Accept.Clear();

                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var response = client.PostAsJsonAsync(endPoint, parameters);
                var stringResult = response.Result.Content.ReadAsStringAsync();
                var result = JsonConvert.DeserializeObject<T>(stringResult.Result);
                return result;
            }
        }
    }
}
