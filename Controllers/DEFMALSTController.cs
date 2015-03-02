using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class DEFMALSTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /DEFMALST/

        public ActionResult Index()
        {
            return View(db.DEFMALSTs.ToList());
        }

        //
        // GET: /DEFMALST/Details/5

        public ActionResult Details(int id = 0)
        {
            DEFMALST defmalst = db.DEFMALSTs.Single(d => d.PK == id);
            if (defmalst == null)
            {
                return HttpNotFound();
            }
            return View(defmalst);
        }

        //
        // GET: /DEFMALST/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /DEFMALST/Create

        [HttpPost]
        public ActionResult Create(DEFMALST defmalst)
        {
            if (ModelState.IsValid)
            {
                db.DEFMALSTs.AddObject(defmalst);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(defmalst);
        }

        //
        // GET: /DEFMALST/Edit/5

        public ActionResult Edit(int id = 0)
        {
            DEFMALST defmalst = db.DEFMALSTs.Single(d => d.PK == id);
            if (defmalst == null)
            {
                return HttpNotFound();
            }
            return View(defmalst);
        }

        //
        // POST: /DEFMALST/Edit/5

        [HttpPost]
        public ActionResult Edit(DEFMALST defmalst)
        {
            if (ModelState.IsValid)
            {
                db.DEFMALSTs.Attach(defmalst);
                db.ObjectStateManager.ChangeObjectState(defmalst, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(defmalst);
        }

        //
        // GET: /DEFMALST/Delete/5

        public ActionResult Delete(int id = 0)
        {
            DEFMALST defmalst = db.DEFMALSTs.Single(d => d.PK == id);
            if (defmalst == null)
            {
                return HttpNotFound();
            }
            return View(defmalst);
        }

        //
        // POST: /DEFMALST/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            DEFMALST defmalst = db.DEFMALSTs.Single(d => d.PK == id);
            db.DEFMALSTs.DeleteObject(defmalst);
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