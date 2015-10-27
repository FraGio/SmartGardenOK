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
        bool AddFabisogno(FabbisognoGiornalieroPeriodo fab);
        double FabbisognoPiantaAttuale(DateTime inizio, DateTime fine);
        Guid Guid { get; }
        double Area { get; set; }
        string NomeComune { get; set; }
        string NomeBotanico { get; set;}
    }
}
