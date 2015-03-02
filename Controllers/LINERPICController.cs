using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LINERPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /LINERPIC/

        public ActionResult Index()
        {
            return View(db.LINERPICs.ToList());
        }

        //
        // GET: /LINERPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            LINERPIC linerpic = db.LINERPICs.Single(l => l.PK == id);
            if (linerpic == null)
            {
                return HttpNotFound();
            }
            return View(linerpic);
        }

        //
        // GET: /LINERPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LINERPIC/Create

        [HttpPost]
        public ActionResult Create(LINERPIC linerpic)
        {
            if (ModelState.IsValid)
            {
                db.LINERPICs.AddObject(linerpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(linerpic);
        }

        //
        // GET: /LINERPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LINERPIC linerpic = db.LINERPICs.Single(l => l.PK == id);
            if (linerpic == null)
            {
                return HttpNotFound();
            }
            return View(linerpic);
        }

        //
        // POST: /LINERPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(LINERPIC linerpic)
        {
            if (ModelState.IsValid)
            {
                db.LINERPICs.Attach(linerpic);
                db.ObjectStateManager.ChangeObjectState(linerpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(linerpic);
        }

        //
        // GET: /LINERPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LINERPIC linerpic = db.LINERPICs.Single(l => l.PK == id);
            if (linerpic == null)
            {
                return HttpNotFound();
            }
            return View(linerpic);
        }

        //
        // POST: /LINERPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LINERPIC linerpic = db.LINERPICs.Single(l => l.PK == id);
            db.LINERPICs.DeleteObject(linerpic);
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