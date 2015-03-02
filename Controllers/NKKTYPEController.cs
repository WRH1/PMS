using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class NKKTYPEController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /NKKTYPE/

        public ActionResult Index()
        {
            return View(db.NKKTYPEs.ToList());
        }

        //
        // GET: /NKKTYPE/Details/5

        public ActionResult Details(int id = 0)
        {
            NKKTYPE nkktype = db.NKKTYPEs.Single(n => n.PK == id);
            if (nkktype == null)
            {
                return HttpNotFound();
            }
            return View(nkktype);
        }

        //
        // GET: /NKKTYPE/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NKKTYPE/Create

        [HttpPost]
        public ActionResult Create(NKKTYPE nkktype)
        {
            if (ModelState.IsValid)
            {
                db.NKKTYPEs.AddObject(nkktype);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nkktype);
        }

        //
        // GET: /NKKTYPE/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NKKTYPE nkktype = db.NKKTYPEs.Single(n => n.PK == id);
            if (nkktype == null)
            {
                return HttpNotFound();
            }
            return View(nkktype);
        }

        //
        // POST: /NKKTYPE/Edit/5

        [HttpPost]
        public ActionResult Edit(NKKTYPE nkktype)
        {
            if (ModelState.IsValid)
            {
                db.NKKTYPEs.Attach(nkktype);
                db.ObjectStateManager.ChangeObjectState(nkktype, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nkktype);
        }

        //
        // GET: /NKKTYPE/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NKKTYPE nkktype = db.NKKTYPEs.Single(n => n.PK == id);
            if (nkktype == null)
            {
                return HttpNotFound();
            }
            return View(nkktype);
        }

        //
        // POST: /NKKTYPE/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NKKTYPE nkktype = db.NKKTYPEs.Single(n => n.PK == id);
            db.NKKTYPEs.DeleteObject(nkktype);
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