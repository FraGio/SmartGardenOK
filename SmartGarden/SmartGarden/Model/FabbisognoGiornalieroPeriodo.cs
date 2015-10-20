using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmartGarden.Model
{
    class FabbisognoGiornalieroPeriodo
    {
        private DateTime _inizioPeriodo = new DateTime();
        private DateTime _finePeriodo = new DateTime();
        private double _fabbisognoAcquaGiornaliero = 0;

        public DateTime InizioPeriodo { get;}
        public DateTime FinePeriodo { get;}
        public double FabbisognoAcquaGiornaliero { get;}
        

        public FabbisognoGiornalieroPeriodo(DateTime inizio, DateTime fine, double fabbisognoGiornaliero)
        {
            if (fine.CompareTo(inizio) <= 0)
                throw new ArgumentException("Date non compatibili tra loro");
            if (fabbisognoGiornaliero <= 0)
                throw new ArgumentException("Fabbisogno inferiore o uguale a zero non consentito");

            InizioPeriodo = inizio;
            FinePeriodo = fine;
            FabbisognoAcquaGiornaliero = fabbisognoGiornaliero;
        }
        private bool IsInPeriod(DateTime data)
        {
            return _inizioPeriodo.CompareTo(data) <= 0 && _finePeriodo.CompareTo(data) >= 0;
        }

        public double GetFabisogno(DateTime inizio, DateTime fine)
        {
            double tot = 0;
            TimeSpan inter = fine - inizio;
            if(inter.TotalSeconds<60)
            {
                throw new InvalidDifferenceOfTime();
            }

            tot = _fabbisognoAcquaGiornaliero * inter.TotalDays;

           return tot ;
        }
    }
}
