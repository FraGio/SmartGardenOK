using System;


namespace SmartGarden.Model
{
    class GestioneGiardino:IGestioneGiardinoData
    {
        private IGiardino _giardino;
        public event EventHandler Changed;
        private MyTimer _timers;
        private static GestioneGiardino _instance = null;
        DateTime OraInizioInnaffiatura { get; }
        TimeSpan Intervallo { get; }

        private GestioneGiardino()
        {
            _giardino = new Giardino();
            _timers = new MyTimer();
            OraInizioInnaffiatura = DateTime.Now;
            TimeSpan ts;
            if(OraInizioInnaffiatura.Hour>19)
            {
                ts = new TimeSpan(1, 19, 0, 0);
            }
            else
            {
                ts = new TimeSpan(19, 0, 0);
            }
            OraInizioInnaffiatura = OraInizioInnaffiatura.Date + ts;
            Intervallo = new TimeSpan(1, 0, 0, 0);
        }

        public static GestioneGiardino GetGestoreGiardino()
        {
            if(_instance==null)
            {
                _instance = new GestioneGiardino();
            }
            return _instance;
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
            foreach(TurnoItem turno in _giardino.GetTurni(inizio,fine))
            {
                foreach(IOpenClose openclose in turno.Mehtods)
                _timers.SetTimer(turno.Attesa, turno.Durata,openclose);
            }
        }
        
    }
}