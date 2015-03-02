using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSTYPEController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSTYPE/

        public ActionResult Index()
        {
            return View(db.PMSTYPEs.ToList());
        }

        //
        // GET: /PMSTYPE/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSTYPE pmstype = db.PMSTYPEs.Single(p => p.PK == id);
            if (pmstype == null)
            {
                return HttpNotFound();
            }
            return View(pmstype);
        }

        //
        // GET: /PMSTYPE/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSTYPE/Create

        [HttpPost]
        public ActionResult Create(PMSTYPE pmstype)
        {
            if (ModelState.IsValid)
            {
                db.PMSTYPEs.AddObject(pmstype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmstype);
        }

        //
        // GET: /PMSTYPE/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSTYPE pmstype = db.PMSTYPEs.Single(p => p.PK == id);
            if (pmstype == null)
            {
                return HttpNotFound();
            }
            return View(pmstype);
        }

        //
        // POST: /PMSTYPE/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSTYPE pmstype)
        {
            if (ModelState.IsValid)
            {
                db.PMSTYPEs.Attach(pmstype);
                db.ObjectStateManager.ChangeObjectState(pmstype, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmstype);
        }

        //
        // GET: /PMSTYPE/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSTYPE pmstype = db.PMSTYPEs.Single(p => p.PK == id);
            if (pmstype == null)
            {
                return HttpNotFound();
            }
            return View(pmstype);
        }

        //
        // POST: /PMSTYPE/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSTYPE pmstype = db.PMSTYPEs.Single(p => p.PK == id);
            db.PMSTYPEs.DeleteObject(pmstype);
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