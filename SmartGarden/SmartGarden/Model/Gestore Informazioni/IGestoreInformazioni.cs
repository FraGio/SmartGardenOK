using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
    interface IGestoreInformazioni
    {
        double GetModifierRequirement(IDataPianta pianta);
        Dictionary<Type, Type> GetTypeProviders();
    }
}
