using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class CURRMASTController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /CURRMAST/

        public ActionResult Index()
        {
            return View(db.CURRMASTs.ToList());
        }

        //
        // GET: /CURRMAST/Details/5

        public ActionResult Details(int id = 0)
        {
            CURRMAST currmast = db.CURRMASTs.Single(c => c.PK == id);
            if (currmast == null)
            {
                return HttpNotFound();
            }
            return View(currmast);
        }

        //
        // GET: /CURRMAST/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CURRMAST/Create

        [HttpPost]
        public ActionResult Create(CURRMAST currmast)
        {
            if (ModelState.IsValid)
            {
                db.CURRMASTs.AddObject(currmast);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(currmast);
        }

        //
        // GET: /CURRMAST/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CURRMAST currmast = db.CURRMASTs.Single(c => c.PK == id);
            if (currmast == null)
            {
                return HttpNotFound();
            }
            return View(currmast);
        }

        //
        // POST: /CURRMAST/Edit/5

        [HttpPost]
        public ActionResult Edit(CURRMAST currmast)
        {
            if (ModelState.IsValid)
            {
                db.CURRMASTs.Attach(currmast);
                db.ObjectStateManager.ChangeObjectState(currmast, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(currmast);
        }

        //
        // GET: /CURRMAST/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CURRMAST currmast = db.CURRMASTs.Single(c => c.PK == id);
            if (currmast == null)
            {
                return HttpNotFound();
            }
            return View(currmast);
        }

        //
        // POST: /CURRMAST/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CURRMAST currmast = db.CURRMASTs.Single(c => c.PK == id);
            db.CURRMASTs.DeleteObject(currmast);
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