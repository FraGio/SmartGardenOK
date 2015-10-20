using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace SmartGarden
{
    class SensorePressione
    {
       
       //TODO event pression change
        public string Descrizione { get; set; }

        public SensorePressione(string descrizione = null)
        {
            Descrizione = descrizione;
        }

       
    }
}
