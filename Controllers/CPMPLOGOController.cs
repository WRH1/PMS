using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class CPMPLOGOController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /CPMPLOGO/

        public ActionResult Index()
        {
            return View(db.CPMPLOGOes.ToList());
        }

        //
        // GET: /CPMPLOGO/Details/5

        public ActionResult Details(int id = 0)
        {
            CPMPLOGO cpmplogo = db.CPMPLOGOes.Single(c => c.PK == id);
            if (cpmplogo == null)
            {
                return HttpNotFound();
            }
            return View(cpmplogo);
        }

        //
        // GET: /CPMPLOGO/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CPMPLOGO/Create

        [HttpPost]
        public ActionResult Create(CPMPLOGO cpmplogo)
        {
            if (ModelState.IsValid)
            {
                db.CPMPLOGOes.AddObject(cpmplogo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cpmplogo);
        }

        //
        // GET: /CPMPLOGO/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CPMPLOGO cpmplogo = db.CPMPLOGOes.Single(c => c.PK == id);
            if (cpmplogo == null)
            {
                return HttpNotFound();
            }
            return View(cpmplogo);
        }

        //
        // POST: /CPMPLOGO/Edit/5

        [HttpPost]
        public ActionResult Edit(CPMPLOGO cpmplogo)
        {
            if (ModelState.IsValid)
            {
                db.CPMPLOGOes.Attach(cpmplogo);
                db.ObjectStateManager.ChangeObjectState(cpmplogo, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cpmplogo);
        }

        //
        // GET: /CPMPLOGO/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CPMPLOGO cpmplogo = db.CPMPLOGOes.Single(c => c.PK == id);
            if (cpmplogo == null)
            {
                return HttpNotFound();
            }
            return View(cpmplogo);
        }

        //
        // POST: /CPMPLOGO/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CPMPLOGO cpmplogo = db.CPMPLOGOes.Single(c => c.PK == id);
            db.CPMPLOGOes.DeleteObject(cpmplogo);
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