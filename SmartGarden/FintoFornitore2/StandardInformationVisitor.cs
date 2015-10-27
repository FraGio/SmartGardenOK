using SmartGarden.Model;
using SmartGarden.Model.Gestore_Informazioni.Fornitori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
   public class StandardInformationVisitor2 : IinformationProviderVisitor
    {
        double tot;
        IDataPianta _pianta;
        IGestioneGiardinoData _gestore;
        //IMessagePump mess= MessagePump.GetMessagePump();

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
        private void VisitSpecialization(FintoFornitoreInformazioni2 informationProvider )
        {
           // mess.SendMessage("visitato finto informatore ");
        }

        

        private void VisitSpecialization(Object informationProvider)
        {
          //  mess.SendMessage("visitato Object informatore ");
        }

        #endregion
    }
}
