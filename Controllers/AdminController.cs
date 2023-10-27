using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProyectoAplicada.Models;

namespace ProyectoAplicada.Controllers
{
    public class AdminController : Controller
    {

        // lista de clientes
        public IActionResult ClientList()
        {
            var clientList = new List<Client>
            {
                 new Client
                 {
                    name = "Daniel Solano Madrigal",
                    address = "Paraíso, Cartago",
                    email = "danso0117@gmail.com",
                    tel = "88811554",
                    ced = "305310222",
                    id=0
                 },
                 new Client
                 {
                    name = "Sara Fernandez Mora",
                    address = "Taras, Cartago",
                    email = "sarafm01@gmail.com",
                    tel = "78241211",
                    ced = "306580985",
                    id=1
                 }
            };
            return View(clientList);
        }

        // lista de empleados
        public IActionResult EmployeesList()
        {
            var employeesList = new List<Employees>
            {
                 new Employees
                 {
                    name = "Diego Alvarez Rojas",
                    address = "Paraíso, Cartago",
                    email = "diegoo0117@gmail.com",
                    tel = "88811754",
                    ced = "305210222",
                    depto="Contabilidad",
                    id=0,
                    salarioB=785000.0,
                    horasExtras=2,
                    total=799718
                 },
                 new Employees
                 {
                    name = "Rosa Fernandez Granados",
                    address = "San Rafael, Cartago",
                    email = "rosfg01@gmail.com",
                    tel = "78242211",
                    ced = "306110985",
                    depto="Desarrollo",
                    id=1,
                    salarioB=950000,
                    horasExtras=4,
                    total= 985625
                 }
            };
            return View(employeesList);
        }

        public IActionResult AdminMain()
        {
            return View();
        }

        // GET: AdminController/Details/5
        public ActionResult DetailsEmployee(int id)
        {
            return View();
        }


        // GET: AdminController/Edit/5
        public ActionResult EditEmployee(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditEmployee(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult DeleteEmployee(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteEmployee(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Details/5
        public ActionResult DetailsClient(int id)
        {
            return View();
        }

        
        // GET: AdminController/Edit/5
        public ActionResult EditClient(int id)
        {
            return View();
        }

        // POST: AdminController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditClient(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminController/Delete/5
        public ActionResult DeleteClient(int id)
        {
            return View();
        }

        // POST: AdminController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteClient(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
