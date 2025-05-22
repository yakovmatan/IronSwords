using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ITerrorist tr = new Terrorist("muchamad");
            ITerrorist trf = new Terrorist("Yusuf");
            Message ms = new Message();
            Message my = new Message();
            Console.WriteLine(Aman.ReadList()[0].Terrorist.name);
        }
    }
}
