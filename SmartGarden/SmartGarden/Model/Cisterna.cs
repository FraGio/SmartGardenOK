using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden
{
    class Cisterna
    {
        private SensorePressione _sensorePressione;

        public double Portata { get; set; }
        public double Capienza { get; set; }

        public Cisterna(double portata = 0, double capienza = 0) //argomenti opzionali
        {
            if (portata < 0 || capienza < 0)
                throw new ArgumentException("Valore di portata o capienza non accettabile");

            Portata = portata;
            Capienza = capienza;
            _sensorePressione = new SensorePressione();
        }

        public SensorePressione SensorePressione
        {
            get { return _sensorePressione; }
            set{ _sensorePressione = value; }
        }
    }
}
