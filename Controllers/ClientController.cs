using Microsoft.AspNetCore.Mvc;

namespace ProyectoAplicada.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult Main_Client()
        {
            return View();
        }
    }
}
