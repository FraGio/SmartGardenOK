using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class ValvolaDiSettore : Valvola
    {
        public override void Open(object source, EventArgs e)
        {
            MessagePump.SendMessage("sono la valvola di settore " + Name + "mi apro");
        }

        public override void Close(object source, EventArgs e)
        {
            MessagePump.SendMessage("sono la valvola di settore " + Name + "mi chiudo");
        }
    }
}
