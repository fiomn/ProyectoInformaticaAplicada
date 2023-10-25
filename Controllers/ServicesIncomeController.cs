﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ProyectoAplicada.Controllers
{
    public class ServicesIncomeController : Controller
    {
        // GET: ServicesIncomeController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ServicesIncomeController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ServicesIncomeController/Create
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

        // GET: ServicesIncomeController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServicesIncomeController/Edit/5
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

        // GET: ServicesIncomeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServicesIncomeController/Delete/5
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
