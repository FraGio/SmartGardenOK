using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartGarden.Model
{
    class Cisterna : ICisterna
    {
        private Guid _guid;
        private SensorePressione _sensorePressione ;
        public IvalvolaDiSicurezza _valvolaSicurezza;
        public double Portata { get; set; }
        public double Capienza { get; set; }
        private bool attivata=false;

        public Guid Guid
        {
            get
            {
               return _guid;
            }
        }
        public SensorePressione SensorePressione
        {
            get
            {
                return _sensorePressione;
            }
            set
            {
                if(value==null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _sensorePressione = value;
                    _sensorePressione.pressionChanged += PressioneChanged;
                }
            }
        }
        public IvalvolaDiSicurezza ValvolaSicurezza
        {
            get { return _valvolaSicurezza; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                else
                {
                    _valvolaSicurezza = value;
                    _valvolaSicurezza.stateChanged +=AttivataChanged ;
                }
            }
        }
        private void PressioneChanged(Object source, EventArgs e)
        {
            if(attivata==false)
            {
                _valvolaSicurezza.Close(source, e);
            }
            
        }
        private void AttivataChanged(Object source, EventArgs e)
        {
            
                if (attivata)
                { attivata = true; }
                else
                { attivata = false; }
        }

        public Cisterna(double portata = 0, double capienza = 0) //argomenti opzionali
        {
            if (portata < 0 || capienza < 0)
                throw new ArgumentException("Valore di portata o capienza non accettabile");

            Portata = portata;
            Capienza = capienza;
            _guid = new Guid();
        }

        public IOpenClose GetOpenClose()
        {
            return ValvolaSicurezza;
        }

    }
}
