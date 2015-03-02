using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class EX_VALVE_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /EX_VALVE_INSP/

        public ActionResult Index()
        {
            return View(db.EX_VALVE_INSP.ToList());
        }

        //
        // GET: /EX_VALVE_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            EX_VALVE_INSP ex_valve_insp = db.EX_VALVE_INSP.Single(e => e.PK == id);
            if (ex_valve_insp == null)
            {
                return HttpNotFound();
            }
            return View(ex_valve_insp);
        }

        //
        // GET: /EX_VALVE_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /EX_VALVE_INSP/Create

        [HttpPost]
        public ActionResult Create(EX_VALVE_INSP ex_valve_insp)
        {
            if (ModelState.IsValid)
            {
                db.EX_VALVE_INSP.AddObject(ex_valve_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ex_valve_insp);
        }

        //
        // GET: /EX_VALVE_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            EX_VALVE_INSP ex_valve_insp = db.EX_VALVE_INSP.Single(e => e.PK == id);
            if (ex_valve_insp == null)
            {
                return HttpNotFound();
            }
            return View(ex_valve_insp);
        }

        //
        // POST: /EX_VALVE_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(EX_VALVE_INSP ex_valve_insp)
        {
            if (ModelState.IsValid)
            {
                db.EX_VALVE_INSP.Attach(ex_valve_insp);
                db.ObjectStateManager.ChangeObjectState(ex_valve_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ex_valve_insp);
        }

        //
        // GET: /EX_VALVE_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            EX_VALVE_INSP ex_valve_insp = db.EX_VALVE_INSP.Single(e => e.PK == id);
            if (ex_valve_insp == null)
            {
                return HttpNotFound();
            }
            return View(ex_valve_insp);
        }

        //
        // POST: /EX_VALVE_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            EX_VALVE_INSP ex_valve_insp = db.EX_VALVE_INSP.Single(e => e.PK == id);
            db.EX_VALVE_INSP.DeleteObject(ex_valve_insp);
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