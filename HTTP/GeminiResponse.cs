using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords.HTTP
{
    internal class GeminiResponse
    {
        public List<Candidate> candidates { get; set; }
    }
    public class Candidate
    {
        public Content  content { get; set; }
    }
    public class Content
    {
        public List<Part> Parts { get; set; }
    }
    public class Part
    {
        public string text { get; set; }
    }
}
