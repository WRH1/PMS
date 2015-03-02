using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class NEARPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /NEARPIC/

        public ActionResult Index()
        {
            return View(db.NEARPICs.ToList());
        }

        //
        // GET: /NEARPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            NEARPIC nearpic = db.NEARPICs.Single(n => n.PK == id);
            if (nearpic == null)
            {
                return HttpNotFound();
            }
            return View(nearpic);
        }

        //
        // GET: /NEARPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /NEARPIC/Create

        [HttpPost]
        public ActionResult Create(NEARPIC nearpic)
        {
            if (ModelState.IsValid)
            {
                db.NEARPICs.AddObject(nearpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nearpic);
        }

        //
        // GET: /NEARPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            NEARPIC nearpic = db.NEARPICs.Single(n => n.PK == id);
            if (nearpic == null)
            {
                return HttpNotFound();
            }
            return View(nearpic);
        }

        //
        // POST: /NEARPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(NEARPIC nearpic)
        {
            if (ModelState.IsValid)
            {
                db.NEARPICs.Attach(nearpic);
                db.ObjectStateManager.ChangeObjectState(nearpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nearpic);
        }

        //
        // GET: /NEARPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            NEARPIC nearpic = db.NEARPICs.Single(n => n.PK == id);
            if (nearpic == null)
            {
                return HttpNotFound();
            }
            return View(nearpic);
        }

        //
        // POST: /NEARPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            NEARPIC nearpic = db.NEARPICs.Single(n => n.PK == id);
            db.NEARPICs.DeleteObject(nearpic);
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