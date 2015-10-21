using SmartGarden.Model.Gestore_Informazioni.Fornitori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model.Gestore_Informazioni
{
    class ProviderVisitorInspector : IInspector
    {
        //TODO cambiare interfaccia con interf 
        private readonly string @namespaceVisitor = "SmartGarden.Model.Gestore_Informazioni.Fornitori";
        private readonly string @namespaceProvider = "SmartGarden.Model.Gestore_Informazioni";
        private readonly Type interfaceVisitor = typeof(IinformationProviderVisitor);
        private readonly Type interfaceProvider = typeof(IinformationProvider);
        private static ProviderVisitorInspector instance = null;
        private ProviderVisitorInspector()
        {

        }

        public static ProviderVisitorInspector GetInspector()
        {
            if (instance == null)
                instance = new ProviderVisitorInspector();
            return instance;
        }

        #region Self Inspector
        public List<Type> GetListProvider()
        {
            return GetListTypeAssociatedInterface(namespaceProvider, interfaceProvider);
        }

        public List<Type> GetListVisitor()
        {
            return GetListTypeAssociatedInterface(namespaceVisitor,interfaceVisitor);
        }

        private List<Type> GetListTypeAssociatedInterface(String name,Type interf)
        {
            var q = from type in Assembly.GetExecutingAssembly().GetTypes()
                    where type.IsClass && type.Namespace == @name
                    && type.GetInterface(interf.Name) != null
                    select type;
            return q.ToList<Type>();
        }
        #endregion

        #region file inspector
        public List<Type> GetVisitorFromFile( String fileName)
        {
            return GetTypeFromFile(fileName,interfaceVisitor);
        }

        public List<Type> GetProviderFromFile(String fileName)
        {
            return GetTypeFromFile(fileName, interfaceProvider);
        }

        private List<Type> GetTypeFromFile(String fileName,Type interf)
        {
            var q = from type in Assembly.LoadFile(fileName).GetExportedTypes()
                    where type.IsClass && type.GetInterface(interf.Name) != null
                    select type;
            return q.ToList<Type>();
        }
        #endregion

    }
}