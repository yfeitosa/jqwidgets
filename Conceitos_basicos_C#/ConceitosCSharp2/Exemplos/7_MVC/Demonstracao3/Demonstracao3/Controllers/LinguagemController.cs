using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Demonstracao3.Models;

namespace Demonstracao3.Controllers
{ 
    public class LinguagemController : Controller
    {
        private CURSOEntities db = new CURSOEntities();

        //
        // GET: /Linguagem/

        public ViewResult Index()
        {
            return View(db.TB_LINGUAGEM.ToList());
        }

        //
        // GET: /Linguagem/Details/5

        public ViewResult Details(int id)
        {
            TB_LINGUAGEM tb_linguagem = db.TB_LINGUAGEM.Single(t => t.ID_LINGUAGEM == id);
            return View(tb_linguagem);
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
        public ActionResult Create(TB_LINGUAGEM tb_linguagem)
        {
            if (ModelState.IsValid)
            {
                db.TB_LINGUAGEM.AddObject(tb_linguagem);
                db.SaveChanges();
                return RedirectToAction("Index");  
            }

            return View(tb_linguagem);
        }
        
        //
        // GET: /Linguagem/Edit/5
 
        public ActionResult Edit(int id)
        {
            TB_LINGUAGEM tb_linguagem = db.TB_LINGUAGEM.Single(t => t.ID_LINGUAGEM == id);
            return View(tb_linguagem);
        }

        //
        // POST: /Linguagem/Edit/5

        [HttpPost]
        public ActionResult Edit(TB_LINGUAGEM tb_linguagem)
        {
            if (ModelState.IsValid)
            {
                db.TB_LINGUAGEM.Attach(tb_linguagem);
                db.ObjectStateManager.ChangeObjectState(tb_linguagem, EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tb_linguagem);
        }

        //
        // GET: /Linguagem/Delete/5
 
        public ActionResult Delete(int id)
        {
            TB_LINGUAGEM tb_linguagem = db.TB_LINGUAGEM.Single(t => t.ID_LINGUAGEM == id);
            return View(tb_linguagem);
        }

        //
        // POST: /Linguagem/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {            
            TB_LINGUAGEM tb_linguagem = db.TB_LINGUAGEM.Single(t => t.ID_LINGUAGEM == id);
            db.TB_LINGUAGEM.DeleteObject(tb_linguagem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}