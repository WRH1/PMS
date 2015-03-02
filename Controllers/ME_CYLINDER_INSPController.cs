using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class ME_CYLINDER_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /ME_CYLINDER_INSP/

        public ActionResult Index()
        {
            return View(db.ME_CYLINDER_INSP.ToList());
        }

        //
        // GET: /ME_CYLINDER_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            ME_CYLINDER_INSP me_cylinder_insp = db.ME_CYLINDER_INSP.Single(m => m.PK == id);
            if (me_cylinder_insp == null)
            {
                return HttpNotFound();
            }
            return View(me_cylinder_insp);
        }

        //
        // GET: /ME_CYLINDER_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /ME_CYLINDER_INSP/Create

        [HttpPost]
        public ActionResult Create(ME_CYLINDER_INSP me_cylinder_insp)
        {
            if (ModelState.IsValid)
            {
                db.ME_CYLINDER_INSP.AddObject(me_cylinder_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(me_cylinder_insp);
        }

        //
        // GET: /ME_CYLINDER_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            ME_CYLINDER_INSP me_cylinder_insp = db.ME_CYLINDER_INSP.Single(m => m.PK == id);
            if (me_cylinder_insp == null)
            {
                return HttpNotFound();
            }
            return View(me_cylinder_insp);
        }

        //
        // POST: /ME_CYLINDER_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(ME_CYLINDER_INSP me_cylinder_insp)
        {
            if (ModelState.IsValid)
            {
                db.ME_CYLINDER_INSP.Attach(me_cylinder_insp);
                db.ObjectStateManager.ChangeObjectState(me_cylinder_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(me_cylinder_insp);
        }

        //
        // GET: /ME_CYLINDER_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            ME_CYLINDER_INSP me_cylinder_insp = db.ME_CYLINDER_INSP.Single(m => m.PK == id);
            if (me_cylinder_insp == null)
            {
                return HttpNotFound();
            }
            return View(me_cylinder_insp);
        }

        //
        // POST: /ME_CYLINDER_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            ME_CYLINDER_INSP me_cylinder_insp = db.ME_CYLINDER_INSP.Single(m => m.PK == id);
            db.ME_CYLINDER_INSP.DeleteObject(me_cylinder_insp);
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