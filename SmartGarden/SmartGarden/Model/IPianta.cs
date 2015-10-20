using SmartGarden.Model.Gestore_Informazioni;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartGarden.Model
{ 
   interface IPianta
    {
       
        IGestoreInformazioni GestoreInformazioni { get; set; }
        List<FabbisognoGiornalieroPeriodo> FabbisogniPianta{ get; }
        void AddFabisogno(FabbisognoGiornalieroPeriodo fab);
        double FabbisognoPiantaAttuale(DateTime inizio, TimeSpan durata);
        Guid Guid { get; }
    }
}
