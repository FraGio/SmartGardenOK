using SmartGarden.Control;
using SmartGarden.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartGarden.Controller
{
    interface IControllerData
    {
        void CancellaPianta(IPianta pianta, ISettore settore);
        void CreaNuovaPianta(string nomeBotanico, string nomeComune, double area, string nomeSettore, FabbisognoGiornalieroPeriodo fabbisognoPeriodo);
        void CreaNuovaCisterna(double portata, double capacità);
        void GestisciTimer();
        void CancellaSettore(string nomeSettore);
        void NuovoGiardino();
        void CambiaProvincia(string provincia);
        void CaricaProvinceComboBox(ComboBox provinceComboBox);
    }
}
