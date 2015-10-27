using System.Collections.Generic;

namespace SmartGarden.Model
{
    internal interface IDataPiantaFlyweight
    {
        string NomeComune{ get; set; }

        string NomeBotanico{ get; set; }

        List<FabbisognoGiornalieroPeriodo> Fabisogni{ get;}

        void AddFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab);
        void RemoveFabisognoRelativoPeriodo(FabbisognoGiornalieroPeriodo fab);
        void RemoveAllFabisogniRelativiApPeriodo();
    }
}