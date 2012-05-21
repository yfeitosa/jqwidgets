using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demonstracao2.Models;

namespace Demonstracao2.Controllers
{
    public class LinguagemController : Controller
    {
        CURSOEntities Contexto = new CURSOEntities();

        //
        // GET: /Linguagem/

        public ActionResult Index()
        {
            return View(Contexto.TB_LINGUAGEM);
        }

        //
        // GET: /Linguagem/Details/5

        public ActionResult Details(int id)
        {
            TB_LINGUAGEM Linguagem = 
             Contexto.TB_LINGUAGEM
             .Where(x => x.ID_LINGUAGEM == id).First();

            return View(Linguagem);
        }

        //
        // GET: /Linguagem/Edit/5

        public ActionResult Edit(int id)
        {
            TB_LINGUAGEM Linguagem = 
            Contexto.TB_LINGUAGEM.Where(x => x.ID_LINGUAGEM == id).First();

            return View(Linguagem);
        }

        //
        // GET: /Linguagem/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Linguagem/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                Contexto.AddToTB_LINGUAGEM(
                new TB_LINGUAGEM 
                { NM_LINGUAGEM = collection["NM_LINGUAGEM"] });
                Contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // POST: /Linguagem/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                TB_LINGUAGEM Registro = 
                Contexto.TB_LINGUAGEM.Where(x => x.ID_LINGUAGEM == id).First();
                Registro.NM_LINGUAGEM = collection["NM_LINGUAGEM"];

                Contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Linguagem/Delete/5

        public ActionResult Delete(int id)
        {
            TB_LINGUAGEM Linguagem 
            = Contexto.TB_LINGUAGEM.Where(x => x.ID_LINGUAGEM == id).First();

            return View(Linguagem);
        }

        //
        // POST: /Linguagem/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
                TB_LINGUAGEM Registro 
                = Contexto.TB_LINGUAGEM.Where(x => x.ID_LINGUAGEM == id).First();
                Contexto.DeleteObject(Registro);
                Contexto.SaveChanges();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
