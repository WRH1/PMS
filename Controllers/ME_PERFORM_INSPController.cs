using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class ME_PERFORM_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /ME_PERFORM_INSP/

        public ActionResult Index()
        {
            return View(db.ME_PERFORM_INSP.ToList());
        }

        //
        // GET: /ME_PERFORM_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            ME_PERFORM_INSP me_perform_insp = db.ME_PERFORM_INSP.Single(m => m.PK == id);
            if (me_perform_insp == null)
            {
                return HttpNotFound();
            }
            return View(me_perform_insp);
        }

        //
        // GET: /ME_PERFORM_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ME_PERFORM_INSP/Create

        [HttpPost]
        public ActionResult Create(ME_PERFORM_INSP me_perform_insp)
        {
            if (ModelState.IsValid)
            {
                db.ME_PERFORM_INSP.AddObject(me_perform_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(me_perform_insp);
        }

        //
        // GET: /ME_PERFORM_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ME_PERFORM_INSP me_perform_insp = db.ME_PERFORM_INSP.Single(m => m.PK == id);
            if (me_perform_insp == null)
            {
                return HttpNotFound();
            }
            return View(me_perform_insp);
        }

        //
        // POST: /ME_PERFORM_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(ME_PERFORM_INSP me_perform_insp)
        {
            if (ModelState.IsValid)
            {
                db.ME_PERFORM_INSP.Attach(me_perform_insp);
                db.ObjectStateManager.ChangeObjectState(me_perform_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(me_perform_insp);
        }

        //
        // GET: /ME_PERFORM_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ME_PERFORM_INSP me_perform_insp = db.ME_PERFORM_INSP.Single(m => m.PK == id);
            if (me_perform_insp == null)
            {
                return HttpNotFound();
            }
            return View(me_perform_insp);
        }

        //
        // POST: /ME_PERFORM_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ME_PERFORM_INSP me_perform_insp = db.ME_PERFORM_INSP.Single(m => m.PK == id);
            db.ME_PERFORM_INSP.DeleteObject(me_perform_insp);
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