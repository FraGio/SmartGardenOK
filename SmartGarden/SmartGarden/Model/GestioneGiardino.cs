using System;


namespace SmartGarden.Model
{
    class GestioneGiardino : IGestioneGiardinoData,IGestioneGiardino
    {
        public IGiardino Giardino { get; set; }
        public string Luogo { get; set; }
        public event EventHandler Changed;
        private MyTimer _timers;
        private static GestioneGiardino _instance = null;
        private DateTime _oraInizioInnaffiatura;
        private TimeSpan _intervallo;

        public DateTime OraInizioInnaffiatura
        {
            get { return _oraInizioInnaffiatura};
        }
        public TimeSpan Intervallo
        {
            get { return _intervallo}
        }
        private GestioneGiardino()
        {
            Giardino = new Giardino();
            _timers = MyTimer.GetMyTimer();
            _oraInizioInnaffiatura = DateTime.Now;
            TimeSpan ts;
            if(OraInizioInnaffiatura.Hour>19)
            {
                ts = new TimeSpan(1, 19, 0, 0);
            }
            else
            {
                ts = new TimeSpan(19, 0, 0);
            }
            _oraInizioInnaffiatura = OraInizioInnaffiatura.Date + ts;
            _intervallo = new TimeSpan(1, 0, 0, 0);
            _timers.SetTimerPrincipale(OraInizioInnaffiatura, Intervallo);
        }

        public static GestioneGiardino GetGestoreGiardino()
        {
            if(_instance==null)
            {
                _instance = new GestioneGiardino();
            }
            return _instance;
        }

        public void SetTimer(DateTime date,TimeSpan intervallo)
        {
            _oraInizioInnaffiatura = date;
            _intervallo = intervallo;
            _timers.SetTimerPrincipale(date, intervallo);
        }

        protected virtual void OnChanged()
        {
            if (Changed != null)
                Changed(this, EventArgs.Empty); //aggiorna la view
        }

        public static IGestioneGiardinoData GetData()
        {
            return _instance ;
        }

        private void IniziaInnaffiatura(DateTime inizio ,DateTime fine)
        {
            foreach(TurnoItem turno in Giardino.GetTurni(inizio,fine))
            {
                foreach(IOpenClose openclose in turno.Mehtods)
                _timers.SetTimers(turno.Attesa, turno.Durata,openclose);
            }
        } 

    }
}