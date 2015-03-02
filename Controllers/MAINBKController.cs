using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINBKController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINBK/

        public ActionResult Index()
        {
            return View(db.MAINBKs.ToList());
        }

        //
        // GET: /MAINBK/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINBK mainbk = db.MAINBKs.Single(m => m.PK == id);
            if (mainbk == null)
            {
                return HttpNotFound();
            }
            return View(mainbk);
        }

        //
        // GET: /MAINBK/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINBK/Create

        [HttpPost]
        public ActionResult Create(MAINBK mainbk)
        {
            if (ModelState.IsValid)
            {
                db.MAINBKs.AddObject(mainbk);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainbk);
        }

        //
        // GET: /MAINBK/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINBK mainbk = db.MAINBKs.Single(m => m.PK == id);
            if (mainbk == null)
            {
                return HttpNotFound();
            }
            return View(mainbk);
        }

        //
        // POST: /MAINBK/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINBK mainbk)
        {
            if (ModelState.IsValid)
            {
                db.MAINBKs.Attach(mainbk);
                db.ObjectStateManager.ChangeObjectState(mainbk, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainbk);
        }

        //
        // GET: /MAINBK/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINBK mainbk = db.MAINBKs.Single(m => m.PK == id);
            if (mainbk == null)
            {
                return HttpNotFound();
            }
            return View(mainbk);
        }

        //
        // POST: /MAINBK/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINBK mainbk = db.MAINBKs.Single(m => m.PK == id);
            db.MAINBKs.DeleteObject(mainbk);
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