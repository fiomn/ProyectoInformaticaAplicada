using Microsoft.AspNetCore.Mvc;

namespace ProyectoAplicada.Controllers
{
    public class ClientController : Controller
    {
        public IActionResult MainClient()
        {
            return View();
        }

    }
}
