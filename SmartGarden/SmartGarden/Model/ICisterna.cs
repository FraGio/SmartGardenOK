﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    interface ICisterna
    {
        double Portata { get; set; }
        IOpenClose GetOpenClose();
    }
}
