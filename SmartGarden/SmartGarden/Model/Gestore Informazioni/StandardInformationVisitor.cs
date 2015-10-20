using SmartGarden.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
    class StandardInformationVisitor : IinformationProviderVisitor
    {
        double tot;
        IDataPianta _pianta;
        IGestioneGiardinoData _gestore;


        public double GetRequiredWater()
        {
            return tot;
        }

        public void initialize(IDataPianta pianta, IGestioneGiardinoData giard)
        {
            _pianta = pianta;
            _gestore = giard;
            tot = 0;
        }

        public void Visit(dynamic informationProvider)
        {
            VisitSpecialization(informationProvider as dynamic);
        }
        
        #region VisitSpecialization
        private void VisitSpecialization(FintoFornitoreInformazioni informationProvider )
        {
            MessagePump.SendMessage("visitato finto informatore ");
        }

        private void VisitSpecialization(ProviderPrecipitazioniDefaultHttp informationProvider)
        {
            tot -= informationProvider.GetPrecipitazioni() * _pianta.Area;
        }
        //TODO migliorare algoritmo
        private void VisitSpecialization(ProviderTemperaturaDefaultHttp informationProvider)
        {
            tot += informationProvider.GetTemperatura() * _pianta.Area;
        }
        #endregion
    }
}
