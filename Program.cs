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
            Terrorist a = new Terrorist("muchama");
            Terrorist b = new Terrorist("ali");
            Terrorist c = new Terrorist("yusuf");

            AttackTool F16 = new F16FighterJet();
            AttackTool Zik = new Hermes460ZikDrone();
            AttackTool M109 = new M109Artillery();

            IMessage a1 = new Message();
            IMessage b1 = new Message();
            IMessage c1 = new Message();
            IMessage d1 = new Message();

            Menu menu = new Menu();

            while(true)
            {
                menu.Show();
                Console.WriteLine("press a key to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
