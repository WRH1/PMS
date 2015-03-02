using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class BRKDNPICController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /BRKDNPIC/

        public ActionResult Index()
        {
            return View(db.BRKDNPICs.ToList());
        }

        //
        // GET: /BRKDNPIC/Details/5

        public ActionResult Details(int id = 0)
        {
            BRKDNPIC brkdnpic = db.BRKDNPICs.Single(b => b.PK == id);
            if (brkdnpic == null)
            {
                return HttpNotFound();
            }
            return View(brkdnpic);
        }

        //
        // GET: /BRKDNPIC/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /BRKDNPIC/Create

        [HttpPost]
        public ActionResult Create(BRKDNPIC brkdnpic)
        {
            if (ModelState.IsValid)
            {
                db.BRKDNPICs.AddObject(brkdnpic);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(brkdnpic);
        }

        //
        // GET: /BRKDNPIC/Edit/5

        public ActionResult Edit(int id = 0)
        {
            BRKDNPIC brkdnpic = db.BRKDNPICs.Single(b => b.PK == id);
            if (brkdnpic == null)
            {
                return HttpNotFound();
            }
            return View(brkdnpic);
        }

        //
        // POST: /BRKDNPIC/Edit/5

        [HttpPost]
        public ActionResult Edit(BRKDNPIC brkdnpic)
        {
            if (ModelState.IsValid)
            {
                db.BRKDNPICs.Attach(brkdnpic);
                db.ObjectStateManager.ChangeObjectState(brkdnpic, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(brkdnpic);
        }

        //
        // GET: /BRKDNPIC/Delete/5

        public ActionResult Delete(int id = 0)
        {
            BRKDNPIC brkdnpic = db.BRKDNPICs.Single(b => b.PK == id);
            if (brkdnpic == null)
            {
                return HttpNotFound();
            }
            return View(brkdnpic);
        }

        //
        // POST: /BRKDNPIC/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            BRKDNPIC brkdnpic = db.BRKDNPICs.Single(b => b.PK == id);
            db.BRKDNPICs.DeleteObject(brkdnpic);
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