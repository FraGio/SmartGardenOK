using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface IGestioneGiardinoData
    {
        TimeSpan Intervallo { get; }
        DateTime OraInizioInnaffiatura { get; }
        string Luogo { get; }
    }
}
