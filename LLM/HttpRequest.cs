using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;

namespace IronSwords.LLM
{
    internal class HttpRequest
    {
        public string GetKey()
        {
            Env.Load("C:\\Users\\User\\source\\repos\\IronSwords\\LLM\\.env");
            string apiKey = Environment.GetEnvironmentVariable("GEMINI_API_KEY").ToString();
            return apiKey;
        }
    }
}
