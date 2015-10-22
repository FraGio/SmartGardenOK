using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden.Model.Gestore_Informazioni
{  
    class FactoryGestoreInformazioni:IFactoryGestoreInformazioni //Pattern Singleton
    { 

        private Dictionary<GestoreInformazioni,int> _gestori;
        private static FactoryGestoreInformazioni instance = null;

        private FactoryGestoreInformazioni()
        {
            _gestori = new Dictionary<GestoreInformazioni,int>();
        }

        public static FactoryGestoreInformazioni GetFactory()
        {
            if (instance == null)
                instance = new FactoryGestoreInformazioni();
            return instance;
        }

        public GestoreInformazioni GetGestore(Dictionary<Type,Type> typeProviders)
        {
            
            foreach (GestoreInformazioni gest in _gestori.Keys)
            { 
                if (gest.IsGestoreOf(typeProviders))
                {
                    _gestori[gest]++;
                    return gest;
                }
            }

            GestoreInformazioni gestore = new GestoreInformazioni(typeProviders);
            _gestori.Add(gestore,1);

            return gestore;
        }

        //TODO gestire rimozione settore pianta giardino
        public GestoreInformazioni Modifica(GestoreInformazioni OldGestore, Dictionary<Type, Type> typeProviders)
        {
            _gestori[OldGestore]--;
            if(_gestori[OldGestore]<1)
            {
                _gestori.Remove(OldGestore);
            }

            return GetGestore(typeProviders);
        }
           
    }
}
