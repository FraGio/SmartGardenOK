using System.Windows.Forms;
using SmartGarden.Model;
using SmartGarden.View;
using SmartGarden.Controller;

namespace SmartGarden.Controller
{
    interface IMyController : IControllerData, IControllerView
    {
        bool CreaLoginForm();
    }
}
