using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IronSwords.HTTP
{
    internal class HttpRequester
    {
        private static readonly HttpClient Client = new HttpClient();
        
        public async Task<string> PostJsonAsync(string url,object body)
        {
            var json = JsonSerializer.Serialize(body);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await Client.PostAsync(url, content);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
