using SmartGarden.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;

namespace SmartGarden.Model
{
    class SensorePressione :IRilevatorePressione
    {
        public event EventHandler pressionChanged;
        public string Descrizione { get; set; }
        private IMessagePump mess;

        public SensorePressione(string descrizione = null)
        {
            Descrizione = descrizione;
            Random ran = new Random();
            Timer timer = new Timer(ran.Next(120*1000,600*1000));
            timer.Elapsed += CambiamentoPressione;
            mess = MessagePump.GetMessagePump();
        }

        protected virtual void OnpressionChanged()
        {
            if (pressionChanged != null)
                pressionChanged(this, EventArgs.Empty);
        }

        private void CambiamentoPressione(object e,EventArgs ev)
        {
            OnpressionChanged();
            mess.SendMessage("sono il sensore di pressione è cambiata la pressione");
        }
        
    }
}
