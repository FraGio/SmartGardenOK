using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni.Fornitori
{
    public class ProviderTemperaturaDefaultHttp : IinformationProvider
    {
        //TODO da lavorarci
        FornitoreInformazioniMeteoHttp giver;
        public ProviderTemperaturaDefaultHttp()
        {
            giver = FornitoreInformazioniMeteoHttp.GetFornitore();
        }
        public void Accept(IinformationProviderVisitor visitor)
        {
            visitor.Visit(this);
        }

        public double GetTemperatura()
        {
            return giver.GetDato("precipitazioni");
        }
    }
}
