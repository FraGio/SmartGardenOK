using System;
using System.Collections.Generic;

namespace SmartGarden.Model.Gestore_Informazioni
{
    internal class FactoryVisitor
    {

        Dictionary<Type, IinformationProviderVisitor> _visitors;

        public FactoryVisitor()
        {
            _visitors = new Dictionary<Type, IinformationProviderVisitor>();
        }

        internal IinformationProviderVisitor GetVisitor(Type type)
        {
           if(_visitors.ContainsKey(type))
            {
                return _visitors[type];
            }
           else
            {
                IinformationProviderVisitor _visitor = (IinformationProviderVisitor) Activator.CreateInstance(type);
                _visitors.Add(type, _visitor);
                 return _visitor;
            }
        }

        public List<IinformationProviderVisitor> GetVisitorsList()
        {
            List<IinformationProviderVisitor> list = new List<IinformationProviderVisitor>();
            list.AddRange(_visitors.Values);
            return list;
        }
    }
}