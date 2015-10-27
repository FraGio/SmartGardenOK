using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
   public interface IinformationProviderVisitor
    {
        //dynamic act like object in compile time
        void Visit(dynamic informationProvider);
        void initialize(IDataPianta pianta, IGestioneGiardinoData _giard);
        double GetRequiredWater();
    }
}
