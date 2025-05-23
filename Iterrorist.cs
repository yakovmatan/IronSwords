using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords
{
    public interface ITerrorist
    {
        string name { get;}
        int rank { get;}
        bool isLife { get;}
        List<string> weapone { get;}

        void updateIsLife();
    }
}
