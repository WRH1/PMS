using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class CYL_COND_INSPController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /CYL_COND_INSP/

        public ActionResult Index()
        {
            return View(db.CYL_COND_INSP.ToList());
        }

        //
        // GET: /CYL_COND_INSP/Details/5

        public ActionResult Details(int id = 0)
        {
            CYL_COND_INSP cyl_cond_insp = db.CYL_COND_INSP.Single(c => c.PK == id);
            if (cyl_cond_insp == null)
            {
                return HttpNotFound();
            }
            return View(cyl_cond_insp);
        }

        //
        // GET: /CYL_COND_INSP/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /CYL_COND_INSP/Create

        [HttpPost]
        public ActionResult Create(CYL_COND_INSP cyl_cond_insp)
        {
            if (ModelState.IsValid)
            {
                db.CYL_COND_INSP.AddObject(cyl_cond_insp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(cyl_cond_insp);
        }

        //
        // GET: /CYL_COND_INSP/Edit/5

        public ActionResult Edit(int id = 0)
        {
            CYL_COND_INSP cyl_cond_insp = db.CYL_COND_INSP.Single(c => c.PK == id);
            if (cyl_cond_insp == null)
            {
                return HttpNotFound();
            }
            return View(cyl_cond_insp);
        }

        //
        // POST: /CYL_COND_INSP/Edit/5

        [HttpPost]
        public ActionResult Edit(CYL_COND_INSP cyl_cond_insp)
        {
            if (ModelState.IsValid)
            {
                db.CYL_COND_INSP.Attach(cyl_cond_insp);
                db.ObjectStateManager.ChangeObjectState(cyl_cond_insp, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cyl_cond_insp);
        }

        //
        // GET: /CYL_COND_INSP/Delete/5

        public ActionResult Delete(int id = 0)
        {
            CYL_COND_INSP cyl_cond_insp = db.CYL_COND_INSP.Single(c => c.PK == id);
            if (cyl_cond_insp == null)
            {
                return HttpNotFound();
            }
            return View(cyl_cond_insp);
        }

        //
        // POST: /CYL_COND_INSP/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            CYL_COND_INSP cyl_cond_insp = db.CYL_COND_INSP.Single(c => c.PK == id);
            db.CYL_COND_INSP.DeleteObject(cyl_cond_insp);
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