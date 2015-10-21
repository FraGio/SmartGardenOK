using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Timers;

namespace SmartGarden
{
    class SensorePressione
    {
        public event EventHandler pressionChanged;
       //TODO event pression change
        public string Descrizione { get; set; }

        public SensorePressione(string descrizione = null)
        {
            Descrizione = descrizione;
            Thread io = new Thread(CambiamentoPressione);
        }

        protected virtual void OnpressionChanged()
        {
            if (pressionChanged != null)
                pressionChanged(this, EventArgs.Empty);
        }

        public void CambiamentoPressione()
        {
            
        }
        
    }
}
