using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class BER_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /BER_INSP/

        public ActionResult Index()
        {
            return View(db.BER_INSP.ToList());
        }

        //
        // GET: /BER_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            BER_INSP ber_insp = db.BER_INSP.Single(b => b.PK == id);
            if (ber_insp == null)
            {
                return HttpNotFound();
            }
            return View(ber_insp);
        }

        //
        // GET: /BER_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BER_INSP/Create

        [HttpPost]
        public ActionResult Create(BER_INSP ber_insp)
        {
            if (ModelState.IsValid)
            {
                db.BER_INSP.AddObject(ber_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ber_insp);
        }

        //
        // GET: /BER_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BER_INSP ber_insp = db.BER_INSP.Single(b => b.PK == id);
            if (ber_insp == null)
            {
                return HttpNotFound();
            }
            return View(ber_insp);
        }

        //
        // POST: /BER_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(BER_INSP ber_insp)
        {
            if (ModelState.IsValid)
            {
                db.BER_INSP.Attach(ber_insp);
                db.ObjectStateManager.ChangeObjectState(ber_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ber_insp);
        }

        //
        // GET: /BER_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BER_INSP ber_insp = db.BER_INSP.Single(b => b.PK == id);
            if (ber_insp == null)
            {
                return HttpNotFound();
            }
            return View(ber_insp);
        }

        //
        // POST: /BER_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BER_INSP ber_insp = db.BER_INSP.Single(b => b.PK == id);
            db.BER_INSP.DeleteObject(ber_insp);
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