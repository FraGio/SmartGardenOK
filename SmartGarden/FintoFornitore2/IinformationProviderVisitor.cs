using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintoFornitore2
{
    interface IinformationProviderVisitor
    {
        //dynamic act like object in compile time
        void Visit(dynamic informationProvider);
        void initialize(IDataPianta pianta, IGestioneGiardinoData _giard);
        double GetRequiredWater();
    }
}
