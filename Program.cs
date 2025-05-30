using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using IronSwords.Factory;
using IronSwords.LLM;

namespace IronSwords
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ProgramInitializer initializer = new ProgramInitializer();
            await initializer.Initializer();
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
