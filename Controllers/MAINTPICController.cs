using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MAINTPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MAINTPIC/

        public ActionResult Index()
        {
            return View(db.MAINTPICs.ToList());
        }

        //
        // GET: /MAINTPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            MAINTPIC maintpic = db.MAINTPICs.Single(m => m.PK == id);
            if (maintpic == null)
            {
                return HttpNotFound();
            }
            return View(maintpic);
        }

        //
        // GET: /MAINTPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MAINTPIC/Create

        [HttpPost]
        public ActionResult Create(MAINTPIC maintpic)
        {
            if (ModelState.IsValid)
            {
                db.MAINTPICs.AddObject(maintpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(maintpic);
        }

        //
        // GET: /MAINTPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MAINTPIC maintpic = db.MAINTPICs.Single(m => m.PK == id);
            if (maintpic == null)
            {
                return HttpNotFound();
            }
            return View(maintpic);
        }

        //
        // POST: /MAINTPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(MAINTPIC maintpic)
        {
            if (ModelState.IsValid)
            {
                db.MAINTPICs.Attach(maintpic);
                db.ObjectStateManager.ChangeObjectState(maintpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(maintpic);
        }

        //
        // GET: /MAINTPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MAINTPIC maintpic = db.MAINTPICs.Single(m => m.PK == id);
            if (maintpic == null)
            {
                return HttpNotFound();
            }
            return View(maintpic);
        }

        //
        // POST: /MAINTPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MAINTPIC maintpic = db.MAINTPICs.Single(m => m.PK == id);
            db.MAINTPICs.DeleteObject(maintpic);
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