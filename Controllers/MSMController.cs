using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MSMController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MSM/

        public ActionResult Index()
        {
            return View(db.MSMs.ToList());
        }

        //
        // GET: /MSM/Details/5

        public ActionResult Details(int id = 0)
        {
            MSM msm = db.MSMs.Single(m => m.PK == id);
            if (msm == null)
            {
                return HttpNotFound();
            }
            return View(msm);
        }

        //
        // GET: /MSM/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MSM/Create

        [HttpPost]
        public ActionResult Create(MSM msm)
        {
            if (ModelState.IsValid)
            {
                db.MSMs.AddObject(msm);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(msm);
        }

        //
        // GET: /MSM/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MSM msm = db.MSMs.Single(m => m.PK == id);
            if (msm == null)
            {
                return HttpNotFound();
            }
            return View(msm);
        }

        //
        // POST: /MSM/Edit/5

        [HttpPost]
        public ActionResult Edit(MSM msm)
        {
            if (ModelState.IsValid)
            {
                db.MSMs.Attach(msm);
                db.ObjectStateManager.ChangeObjectState(msm, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(msm);
        }

        //
        // GET: /MSM/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MSM msm = db.MSMs.Single(m => m.PK == id);
            if (msm == null)
            {
                return HttpNotFound();
            }
            return View(msm);
        }

        //
        // POST: /MSM/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MSM msm = db.MSMs.Single(m => m.PK == id);
            db.MSMs.DeleteObject(msm);
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