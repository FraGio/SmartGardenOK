﻿using SmartGarden.Model.Gestore_Informazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{
    class Pianta : IPianta, IDataPianta
    {
        private Guid Guid;
        private IDataPiantaFlyweight _data;

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
        public double Area { get; set; }
        public IGestoreInformazioni GestoreInformazioni { get; set; }
        public string NomeComune { get { return _data.NomeComune; } }
        public string NomeBotanico { get { return _data.NomeBotanico; } }
        public List<FabbisognoGiornalieroPeriodo> FabbisogniPianta
        {
            get { return _data.Fabisogni; }
        }
        IGestoreInformazioni IPianta.GestoreInformazioni
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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

        public void AddFabisogno(FabbisognoGiornalieroPeriodo fab)
        {
            _data.addFabisognoRelativoPeriodo(fab);
        }

        //TODO completare il metodo
        public double FabbisognoPiantaAttuale(DateTime inizio, TimeSpan durata)
        {
            double tot = GestoreInformazioni.GetModifierRequirement(this);
            tot += GetFabisogno(inizio, durata);
            return tot;
        }

        private double GetFabisogno(DateTime inizio, TimeSpan durata)
        {
            double tot = 0;
            foreach (FabbisognoGiornalieroPeriodo fab in FabbisogniPianta)
            {
                tot += fab.GetFabisogno(inizio, durata);
            }
            return tot;
        }

    }
}
