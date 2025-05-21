using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords
{
    internal interface Iterrorist
    {
        string name { get; set; }
        int rank { get; set; }
        bool status { get; set; }
        List<string> weapone { get; set; }
    }
}
