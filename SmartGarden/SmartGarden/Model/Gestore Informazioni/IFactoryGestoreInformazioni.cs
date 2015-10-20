using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
    interface IFactoryGestoreInformazioni
    {
        GestoreInformazioni GetGestore(Dictionary<Type, Type> typeProviders);

        GestoreInformazioni Modifica(GestoreInformazioni OldGestore, Dictionary<Type, Type> typeProviders);
      
    }
}
