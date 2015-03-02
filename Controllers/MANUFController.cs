using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MANUFController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MANUF/

        public ActionResult Index()
        {
            return View(db.MANUFs.ToList());
        }

        //
        // GET: /MANUF/Details/5

        public ActionResult Details(int id = 0)
        {
            MANUF manuf = db.MANUFs.Single(m => m.PK == id);
            if (manuf == null)
            {
                return HttpNotFound();
            }
            return View(manuf);
        }

        //
        // GET: /MANUF/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MANUF/Create

        [HttpPost]
        public ActionResult Create(MANUF manuf)
        {
            if (ModelState.IsValid)
            {
                db.MANUFs.AddObject(manuf);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(manuf);
        }

        //
        // GET: /MANUF/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MANUF manuf = db.MANUFs.Single(m => m.PK == id);
            if (manuf == null)
            {
                return HttpNotFound();
            }
            return View(manuf);
        }

        //
        // POST: /MANUF/Edit/5

        [HttpPost]
        public ActionResult Edit(MANUF manuf)
        {
            if (ModelState.IsValid)
            {
                db.MANUFs.Attach(manuf);
                db.ObjectStateManager.ChangeObjectState(manuf, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(manuf);
        }

        //
        // GET: /MANUF/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MANUF manuf = db.MANUFs.Single(m => m.PK == id);
            if (manuf == null)
            {
                return HttpNotFound();
            }
            return View(manuf);
        }

        //
        // POST: /MANUF/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MANUF manuf = db.MANUFs.Single(m => m.PK == id);
            db.MANUFs.DeleteObject(manuf);
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