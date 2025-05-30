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
using IronSwords.HTTP;

namespace IronSwords.LLM
{
    public class GeminiClient
    {
        private readonly HttpRequester Client;
        private readonly string Apikey;
        private string Url;

        public GeminiClient()
        {
            this.Client = new HttpRequester();
            this.Apikey = GetKey();
        }
        private string GetKey()
        {
            Env.Load("C:\\Users\\User\\source\\repos\\IronSwords\\HTTP\\.env");
            string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY").ToString();
            return apiKey;
        }

        public async Task<string> SendPromptAsync(string prompt)
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
                            new {text = prompt}
                        }
                    }
                }
            };
            string responsJson = await Client.PostJsonAsync(this.Url, body);
            var parsedToJson = JsonSerializer.Deserialize<GeminiResponse>(responsJson);
            var text = parsedToJson?.candidates?.FirstOrDefault()?.content?.parts?.FirstOrDefault()?.text;
            return text?.Trim() ?? "no response received";
        }
    }
}
