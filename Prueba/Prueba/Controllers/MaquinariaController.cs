using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class MaquinariaController : Controller
    {
        // GET: Maquinaria
        public ActionResult Index()
        {
            return View();
        }

        // GET: Maquinaria/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Maquinaria/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Maquinaria/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maquinaria/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Maquinaria/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Maquinaria/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Maquinaria/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
