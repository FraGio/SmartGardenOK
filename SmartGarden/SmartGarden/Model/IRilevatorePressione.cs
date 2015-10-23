using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface IRilevatorePressione
    {
        event EventHandler pressionChanged;
        string Descrizione { get; set; }
    }
}
