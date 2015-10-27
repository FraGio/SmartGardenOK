using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FintoFornitore2
{
    interface IinformationProvider
    {
        void Accept(IinformationProviderVisitor visitor);
    }
}
