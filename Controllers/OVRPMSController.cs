using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class OVRPMSController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /OVRPMS/

        public ActionResult Index()
        {
            return View(db.OVRPMS.ToList());
        }

        //
        // GET: /OVRPMS/Details/5

        public ActionResult Details(int id = 0)
        {
            OVRPM ovrpm = db.OVRPMS.Single(o => o.PK == id);
            if (ovrpm == null)
            {
                return HttpNotFound();
            }
            return View(ovrpm);
        }

        //
        // GET: /OVRPMS/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /OVRPMS/Create

        [HttpPost]
        public ActionResult Create(OVRPM ovrpm)
        {
            if (ModelState.IsValid)
            {
                db.OVRPMS.AddObject(ovrpm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ovrpm);
        }

        //
        // GET: /OVRPMS/Edit/5

        public ActionResult Edit(int id = 0)
        {
            OVRPM ovrpm = db.OVRPMS.Single(o => o.PK == id);
            if (ovrpm == null)
            {
                return HttpNotFound();
            }
            return View(ovrpm);
        }

        //
        // POST: /OVRPMS/Edit/5

        [HttpPost]
        public ActionResult Edit(OVRPM ovrpm)
        {
            if (ModelState.IsValid)
            {
                db.OVRPMS.Attach(ovrpm);
                db.ObjectStateManager.ChangeObjectState(ovrpm, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ovrpm);
        }

        //
        // GET: /OVRPMS/Delete/5

        public ActionResult Delete(int id = 0)
        {
            OVRPM ovrpm = db.OVRPMS.Single(o => o.PK == id);
            if (ovrpm == null)
            {
                return HttpNotFound();
            }
            return View(ovrpm);
        }

        //
        // POST: /OVRPMS/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            OVRPM ovrpm = db.OVRPMS.Single(o => o.PK == id);
            db.OVRPMS.DeleteObject(ovrpm);
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