using SmartGarden.Model.Gestore_Informazioni.Fornitori;
using System;
using System.Collections.Generic;

namespace SmartGarden.Model.Gestore_Informazioni
{
    class GestoreInformazioni :IGestoreInformazioni
    {
        private Dictionary<IinformationProvider, IinformationProviderVisitor> _providers;
        private FactoryVisitor _factoryVisitor;

        public GestoreInformazioni(Dictionary<Type, Type> typeProviders)
        {
            _factoryVisitor = new FactoryVisitor();
            _providers = new Dictionary<IinformationProvider, IinformationProviderVisitor>();
            foreach(Type prov in typeProviders.Keys)
            {
                _providers.Add((IinformationProvider)Activator.CreateInstance(prov), _factoryVisitor.GetVisitor(typeProviders[prov]));
            }
        }

        public double GetModifierRequirement(IDataPianta pianta)
        {
            double tot = 0;
            IGestioneGiardinoData _giard = GestioneGiardino.GetData();

            foreach(IinformationProviderVisitor visitor in _factoryVisitor.GetVisitorsList())
            {
                visitor.initialize(pianta,_giard);
            }

            foreach(IinformationProvider prov in _providers.Keys)
            {
                prov.Accept(_providers[prov]);
            }

            foreach(IinformationProviderVisitor visitor in _factoryVisitor.GetVisitorsList())
            {
                tot += visitor.GetRequiredWater();
            }

            return tot;
        }

        public Dictionary<Type,Type> GetTypeProviders()
        {
            Dictionary<Type, Type> typeProv = new Dictionary<Type, Type>();
            foreach(IinformationProvider prov in _providers.Keys)
            {
                typeProv.Add(prov.GetType(), _providers[prov].GetType());
            }
            return typeProv;
        }

        public bool IsGestoreOf(Dictionary<Type, Type> typeProviders)
        {
            Dictionary<Type, Type> myTypes = GetTypeProviders();
            if (myTypes.Keys.Count != typeProviders.Keys.Count)
                return false;

            foreach (Type type in typeProviders.Keys)
            {
                if (!myTypes.ContainsKey(type) || myTypes[type] != typeProviders[type])
                    return false;
            }

            return true;
        }
    }
}
