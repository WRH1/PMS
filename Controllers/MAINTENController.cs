using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINTENController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINTEN/

        public ActionResult Index()
        {
            return View(db.MAINTENs.ToList());
        }

        //
        // GET: /MAINTEN/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINTEN mainten = db.MAINTENs.Single(m => m.PK == id);
            if (mainten == null)
            {
                return HttpNotFound();
            }
            return View(mainten);
        }

        //
        // GET: /MAINTEN/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINTEN/Create

        [HttpPost]
        public ActionResult Create(MAINTEN mainten)
        {
            if (ModelState.IsValid)
            {
                db.MAINTENs.AddObject(mainten);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(mainten);
        }

        //
        // GET: /MAINTEN/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINTEN mainten = db.MAINTENs.Single(m => m.PK == id);
            if (mainten == null)
            {
                return HttpNotFound();
            }
            return View(mainten);
        }

        //
        // POST: /MAINTEN/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINTEN mainten)
        {
            if (ModelState.IsValid)
            {
                db.MAINTENs.Attach(mainten);
                db.ObjectStateManager.ChangeObjectState(mainten, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(mainten);
        }

        //
        // GET: /MAINTEN/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINTEN mainten = db.MAINTENs.Single(m => m.PK == id);
            if (mainten == null)
            {
                return HttpNotFound();
            }
            return View(mainten);
        }

        //
        // POST: /MAINTEN/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINTEN mainten = db.MAINTENs.Single(m => m.PK == id);
            db.MAINTENs.DeleteObject(mainten);
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