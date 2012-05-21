using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demonstracao2.Controllers
{
    public class DesenvolvedorController : Controller
    {
        //
        // GET: /Desenvolvedor/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Desenvolvedor/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Desenvolvedor/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Desenvolvedor/Create

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
        
        //
        // GET: /Desenvolvedor/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Desenvolvedor/Edit/5

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

        //
        // GET: /Desenvolvedor/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Desenvolvedor/Delete/5

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
