using System.Windows.Forms;
using SmartGarden.Model;
using SmartGarden.View;
using SmartGarden.Controller;

namespace SmartGarden.Control
{
    interface IController : IControllerData, IControllerView
    {
        bool CreaLoginForm();
    }
}
