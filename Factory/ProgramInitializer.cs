using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IronSwords.LLM;

namespace IronSwords.Factory
{
    internal class ProgramInitializer
    {
        private readonly GeminiClient Client = new GeminiClient();
        private readonly AttackToolFactory Weapon = new AttackToolFactory();
        private readonly TerroristFactory Terrorist = new TerroristFactory();
        private readonly MessageFactory Message = new MessageFactory();


        public async Task Initializer()
        {
            Weapon.createWeapon();
            await Terrorist.CreateTerrorists(Client);
            Message.CreateMessage();
        }
       

    }
}
