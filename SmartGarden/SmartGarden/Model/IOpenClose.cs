using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartGarden.Model
{
    public interface IOpenClose
    {
        void Open(Object source, EventArgs e);

        void Close(Object source, EventArgs e);
    }
}
