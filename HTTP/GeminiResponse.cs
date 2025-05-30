using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.HTTP
{
    internal class GeminiResponse
    {
        public List<candidate> candidates { get; set; }
    }
    public class candidate
    {
        public content  content { get; set; }
    }
    public class content
    {
        public List<part> parts { get; set; }
    }
    public class part
    {
        public string text { get; set; }
    }
}
