﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    public interface IvalvolaDiSicurezza :IOpenClose
    {
        event EventHandler stateChanged;
        string Nome { get; set; }
    }
}
