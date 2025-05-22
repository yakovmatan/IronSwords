using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IronSwords
{
    public interface IMessage
    {

        ITerrorist Terrorist { get; }
        string Location { get; }

        DateTime Timestamp { get;  }
    }
}
