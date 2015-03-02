using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINTYPEController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINTYPE/

        public ActionResult Index()
        {
            return View(db.MAINTYPEs.ToList());
        }

        //
        // GET: /MAINTYPE/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINTYPE maintype = db.MAINTYPEs.Single(m => m.PK == id);
            if (maintype == null)
            {
                return HttpNotFound();
            }
            return View(maintype);
        }

        //
        // GET: /MAINTYPE/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINTYPE/Create

        [HttpPost]
        public ActionResult Create(MAINTYPE maintype)
        {
            if (ModelState.IsValid)
            {
                db.MAINTYPEs.AddObject(maintype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maintype);
        }

        //
        // GET: /MAINTYPE/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINTYPE maintype = db.MAINTYPEs.Single(m => m.PK == id);
            if (maintype == null)
            {
                return HttpNotFound();
            }
            return View(maintype);
        }

        //
        // POST: /MAINTYPE/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINTYPE maintype)
        {
            if (ModelState.IsValid)
            {
                db.MAINTYPEs.Attach(maintype);
                db.ObjectStateManager.ChangeObjectState(maintype, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maintype);
        }

        //
        // GET: /MAINTYPE/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINTYPE maintype = db.MAINTYPEs.Single(m => m.PK == id);
            if (maintype == null)
            {
                return HttpNotFound();
            }
            return View(maintype);
        }

        //
        // POST: /MAINTYPE/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINTYPE maintype = db.MAINTYPEs.Single(m => m.PK == id);
            db.MAINTYPEs.DeleteObject(maintype);
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