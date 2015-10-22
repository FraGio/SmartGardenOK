using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface IGestioneGiardino
    {
        IGiardino Giardino { get; set; }
        string Luogo { get; set; }
        DateTime OraInizioInnaffiatura { get; }
        TimeSpan Intervallo { get; }
        void SetTimer(DateTime date, TimeSpan intervallo);
        event EventHandler Changed;
    }
}
