using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface IGiardino
    {
        ICisterna Cisterna { get; set; }

        int NumeroPianteTotali { get; }

        IEnumerable<string> GetNomiSettori();

        ISettore GetSettore(string name);

        IEnumerable<TurnoItem> GetTurni(DateTime inizio, DateTime fine);

        bool RemoveSettore(string settore);

        bool AddSettore(ISettore settore);
    }
}
