using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSDESCController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PMSDESC/

        public ActionResult Index()
        {
            return View(db.PMSDESCs.ToList());
        }

        //
        // GET: /PMSDESC/Details/5

        public ActionResult Details(int id = 0)
        {
            PMSDESC pmsdesc = db.PMSDESCs.Single(p => p.PK == id);
            if (pmsdesc == null)
            {
                return HttpNotFound();
            }
            return View(pmsdesc);
        }

        //
        // GET: /PMSDESC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PMSDESC/Create

        [HttpPost]
        public ActionResult Create(PMSDESC pmsdesc)
        {
            if (ModelState.IsValid)
            {
                db.PMSDESCs.AddObject(pmsdesc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pmsdesc);
        }

        //
        // GET: /PMSDESC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PMSDESC pmsdesc = db.PMSDESCs.Single(p => p.PK == id);
            if (pmsdesc == null)
            {
                return HttpNotFound();
            }
            return View(pmsdesc);
        }

        //
        // POST: /PMSDESC/Edit/5

        [HttpPost]
        public ActionResult Edit(PMSDESC pmsdesc)
        {
            if (ModelState.IsValid)
            {
                db.PMSDESCs.Attach(pmsdesc);
                db.ObjectStateManager.ChangeObjectState(pmsdesc, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pmsdesc);
        }

        //
        // GET: /PMSDESC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PMSDESC pmsdesc = db.PMSDESCs.Single(p => p.PK == id);
            if (pmsdesc == null)
            {
                return HttpNotFound();
            }
            return View(pmsdesc);
        }

        //
        // POST: /PMSDESC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PMSDESC pmsdesc = db.PMSDESCs.Single(p => p.PK == id);
            db.PMSDESCs.DeleteObject(pmsdesc);
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