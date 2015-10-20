using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni.Fornitori
{
    class ProviderPrecipitazioniDefaultHttp : IinformationProvider
    {
        //TODO da lavorarci
        FornitoreInformazioniMeteoHttp giver;
        public ProviderPrecipitazioniDefaultHttp()
        {
            giver = FornitoreInformazioniMeteoHttp.GetFornitore();
        }
        public void Accept(IinformationProviderVisitor visitor)
        {
            visitor.Visit(this);
        }
       
        public double GetPrecipitazioni()
        {
            return giver.GetDato("precipitazioni");
        }

    }
}
