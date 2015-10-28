using SmartGarden.Model.Gestore_Informazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    public class Pianta : IPianta, IDataPianta
    {
        private Guid Guid;
        private IDataPiantaFlyweight _data;
        public double Area { get; set; }
        public IGestoreInformazioni GestoreInformazioni { get; set; }

        #region getter and setter methods
        Guid IDataPianta.Guid
        {
            get
            {
                return Guid;
            }
        }
        Guid IPianta.Guid
        {
            get
            {
                return Guid;
            }
        }
        public string NomeComune { get { return _data.NomeComune; } }
        public string NomeBotanico { get { return _data.NomeBotanico; } }
        public List<FabbisognoGiornalieroPeriodo> FabbisogniPianta
        {
            get { return _data.Fabisogni; }
        }
        string IPianta.NomeComune
        {
            get
            {
                return NomeComune;
            }

            set
            {
               _data.NomeComune=value;
            }
        }
        string IPianta.NomeBotanico
        {
            get
            {
                return NomeBotanico;
            }

            set
            {
                _data.NomeBotanico = value;
            }
        }
        #endregion

        public Pianta(string nomeBotanico, string nomeComune = null, double area = 0)
        {
            if (string.IsNullOrWhiteSpace(nomeBotanico) || string.IsNullOrWhiteSpace(nomeComune))
                throw new ArgumentNullException("Nome botanico o comune non accettabile");

            Guid = Guid.NewGuid();
            _data = PiantaFactory.GetDatiPianta(nomeBotanico, nomeComune);
        }

        public bool AddFabisogno(FabbisognoGiornalieroPeriodo fab)
        {
            _data.AddFabisognoRelativoPeriodo(fab);

            //TODO respingi periodo già occupato

            return false;
        }
        
        public double FabbisognoPiantaAttuale(DateTime inizio, DateTime durata)
        {
            double tot = 0;

            if (GestoreInformazioni != null)
            {
                tot = GestoreInformazioni.GetModifierRequirement(this);
            }
            tot += GetFabisogno(inizio, durata);
            return tot;
        }

        private double GetFabisogno(DateTime inizio, DateTime durata)
        {
            double tot = 0;
            foreach (FabbisognoGiornalieroPeriodo fab in FabbisogniPianta)
            {
                tot += fab.GetFabisogno(inizio, durata);
            }
            return tot;
        }

        public void RemoveAllFabisogniRelativiApPeriodo()
        {
            _data.RemoveAllFabisogniRelativiApPeriodo();
        }

    }
}
