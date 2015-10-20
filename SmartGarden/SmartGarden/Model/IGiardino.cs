﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface IGiardino
    {
        ICisterna Cisterna { get; set; }

        IEnumerable<string> GetNomiSettori();

        ISettore GetSettore(string name);

        IEnumerable<TurnoItem> GetTurni(DateTime inizio, DateTime fine);
    }
}
