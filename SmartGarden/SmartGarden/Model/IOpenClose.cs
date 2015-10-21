using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SmartGarden.Model
{
    interface IOpenClose
    {
        void Open(Object source, ElapsedEventArgs e);

        void Close(Object source, ElapsedEventArgs e);
    }
}
