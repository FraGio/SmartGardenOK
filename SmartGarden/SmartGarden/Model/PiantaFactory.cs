using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class PiantaFactory
    {
       private static readonly Dictionary<string,IDataPiantaFlyweight> _piante= new Dictionary<string, IDataPiantaFlyweight>();

        public static IDataPiantaFlyweight GetDatiPianta(string NomeBotanico,string NomeComune)
        {
            if (!_piante.ContainsKey(NomeBotanico))
            {
                _piante.Add(NomeBotanico, new DatiPiantaFlyweight(NomeComune,NomeBotanico));
            }

            return _piante[NomeBotanico];
        }

        public static IDataPiantaFlyweight GetDatiPianta(string key)
        {
            if (!_piante.ContainsKey(key))
            {
                _piante.Add(key,Createinstance(key));
            }
            
                return _piante[key];
        }
        //TODO interrogo database e trovo pianta con caratteristiche
        private static IDataPiantaFlyweight Createinstance(string key)
        {
            return new DatiPiantaFlyweight("", "");
        }


        private class DatiPiantaFlyweight : IDataPiantaFlyweight
        {
            private string _nomeComune;
            private string _nomeBotanico;
            private List<FabbisognoGiornalieroPeriodo> _fabisogni;
            
            public DatiPiantaFlyweight(string nomeComune,string nomeBotanico)
            {
                _nomeBotanico = nomeBotanico;
                _nomeComune = nomeComune;
                _fabisogni = new List<FabbisognoGiornalieroPeriodo>();
            }

            public string NomeComune
            {
                get{ return _nomeComune;}
                set { _nomeComune = value; }
            }

            public string NomeBotanico
            {
                get{ return _nomeBotanico;}
                set { _nomeBotanico = value; }
            }
            //TODO da cambiare e non esporre lista
            public List<FabbisognoGiornalieroPeriodo> Fabisogni
            {
                get
                {
                    return _fabisogni;
                }
            }

            public void AddFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab)
            {
                _fabisogni.Add(fab);
            }

            public void RemoveFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab)
            {
                _fabisogni.Remove(fab);
            }
        }
    }
}
