using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface ICisterna
    {
        double Portata { get; set; }
        double Capienza { get; set; }
        Guid Guid { get; }
        IOpenClose GetOpenClose();
        IvalvolaDiSicurezza ValvolaSicurezza { get; set; }
        IRilevatorePressione SensorePressione { get; set; }
    }
}
