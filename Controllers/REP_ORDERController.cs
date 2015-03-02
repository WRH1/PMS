using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class REP_ORDERController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /REP_ORDER/

        public ActionResult Index()
        {
            return View(db.REP_ORDER.ToList());
        }

        //
        // GET: /REP_ORDER/Details/5

        public ActionResult Details(int id = 0)
        {
            REP_ORDER rep_order = db.REP_ORDER.Single(r => r.PK == id);
            if (rep_order == null)
            {
                return HttpNotFound();
            }
            return View(rep_order);
        }

        //
        // GET: /REP_ORDER/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /REP_ORDER/Create

        [HttpPost]
        public ActionResult Create(REP_ORDER rep_order)
        {
            if (ModelState.IsValid)
            {
                db.REP_ORDER.AddObject(rep_order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rep_order);
        }

        //
        // GET: /REP_ORDER/Edit/5

        public ActionResult Edit(int id = 0)
        {
            REP_ORDER rep_order = db.REP_ORDER.Single(r => r.PK == id);
            if (rep_order == null)
            {
                return HttpNotFound();
            }
            return View(rep_order);
        }

        //
        // POST: /REP_ORDER/Edit/5

        [HttpPost]
        public ActionResult Edit(REP_ORDER rep_order)
        {
            if (ModelState.IsValid)
            {
                db.REP_ORDER.Attach(rep_order);
                db.ObjectStateManager.ChangeObjectState(rep_order, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rep_order);
        }

        //
        // GET: /REP_ORDER/Delete/5

        public ActionResult Delete(int id = 0)
        {
            REP_ORDER rep_order = db.REP_ORDER.Single(r => r.PK == id);
            if (rep_order == null)
            {
                return HttpNotFound();
            }
            return View(rep_order);
        }

        //
        // POST: /REP_ORDER/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            REP_ORDER rep_order = db.REP_ORDER.Single(r => r.PK == id);
            db.REP_ORDER.DeleteObject(rep_order);
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