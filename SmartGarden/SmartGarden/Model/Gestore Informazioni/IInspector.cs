using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
    public interface IInspector
    {
        List<Type> GetListProvider();

        List<Type> GetListVisitor();

        List<Type> GetVisitorFromFile(String fileName);

        List<Type> GetProviderFromFile(String fileName);
    }
}
