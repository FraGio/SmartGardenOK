using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class Cisterna :ICisterna
    {

        public SensorePressione SensorePressione { get; set; }
        public IOpenClose ValvolaSicurezza { get; set; }
        public double Portata { get; set; }
        public double Capienza { get; set; }

        public Cisterna(double portata = 0, double capienza = 0) //argomenti opzionali
        {
            if (portata < 0 || capienza < 0)
                throw new ArgumentException("Valore di portata o capienza non accettabile");

            Portata = portata;
            Capienza = capienza;
        }

        public IOpenClose GetOpenClose()
        {
            return ValvolaSicurezza;
        }

    }
}
