using Microsoft.AspNetCore.Mvc;

namespace ProyectoAplicada.Controllers
{
    public class UserAuthenticationController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Registration()
        {            
            return View();
        }
    }
}
