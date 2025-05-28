using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AttackToolFactory weapon = new AttackToolFactory();
            TerroristFactory terrorist = new TerroristFactory();
            MessageFactory message = new MessageFactory();
            weapon.createWeapon();
            terrorist.CreateTerrorist();
            message.CreateMessage();

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
