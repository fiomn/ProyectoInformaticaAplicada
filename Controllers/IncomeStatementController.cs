using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAplicada.Controllers
{
    public class IncomeStatementController : Controller
    {
        // GET: IncomeStatementController
        public ActionResult Index()
        {
            return View();
        }

        // GET: IncomeStatementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IncomeStatementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IncomeStatementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: IncomeStatementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IncomeStatementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
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

        // GET: IncomeStatementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IncomeStatementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
