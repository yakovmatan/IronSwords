using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Nodes;
using DotNetEnv;

namespace IronSwords.LLM
{
    internal class HttpRequest
    {
        private static HttpClient Client = new HttpClient();
        private string Apikey;
        private string Url;

        public HttpRequest()
        {
            Apikey = GetKey();
        }
        public string GetKey()
        {
            Env.Load("C:\\Users\\User\\source\\repos\\IronSwords\\LLM\\.env");
            string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY").ToString();
            return apiKey;
        }

        public async Task HttpPostToGemini(string requst)
        {
            this.Url = $"https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent?key={this.Apikey}";
            var body = new
            {
                contents = new[]
                {
                    new
                    {
                        parts = new[]
                        {
                            new {text = requst}
                        }
                    }
                }
            };
            var json = JsonSerializer.Serialize(body)


        }
    }
}
