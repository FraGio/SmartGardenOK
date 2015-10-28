using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    public interface IGestioneGiardinoData
    {
        TimeSpan Intervallo { get; }
        DateTime OraInizioInnaffiatura { get; }
        string Luogo { get; }
    }
}
