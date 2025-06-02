using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords
{
    public interface ITerrorist
    {
        string Name { get;}
        int Rank { get;}
        bool IsLife { get;}

        string Id { get; }
        List<string> Weapons { get;}

        void KillTerrorist();
    }
}
