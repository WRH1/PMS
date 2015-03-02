using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class MSGDATAController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /MSGDATA/

        public ActionResult Index()
        {
            return View(db.MSGDATAs.ToList());
        }

        //
        // GET: /MSGDATA/Details/5

        public ActionResult Details(int id = 0)
        {
            MSGDATA msgdata = db.MSGDATAs.Single(m => m.PK == id);
            if (msgdata == null)
            {
                return HttpNotFound();
            }
            return View(msgdata);
        }

        //
        // GET: /MSGDATA/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /MSGDATA/Create

        [HttpPost]
        public ActionResult Create(MSGDATA msgdata)
        {
            if (ModelState.IsValid)
            {
                db.MSGDATAs.AddObject(msgdata);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(msgdata);
        }

        //
        // GET: /MSGDATA/Edit/5

        public ActionResult Edit(int id = 0)
        {
            MSGDATA msgdata = db.MSGDATAs.Single(m => m.PK == id);
            if (msgdata == null)
            {
                return HttpNotFound();
            }
            return View(msgdata);
        }

        //
        // POST: /MSGDATA/Edit/5

        [HttpPost]
        public ActionResult Edit(MSGDATA msgdata)
        {
            if (ModelState.IsValid)
            {
                db.MSGDATAs.Attach(msgdata);
                db.ObjectStateManager.ChangeObjectState(msgdata, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(msgdata);
        }

        //
        // GET: /MSGDATA/Delete/5

        public ActionResult Delete(int id = 0)
        {
            MSGDATA msgdata = db.MSGDATAs.Single(m => m.PK == id);
            if (msgdata == null)
            {
                return HttpNotFound();
            }
            return View(msgdata);
        }

        //
        // POST: /MSGDATA/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            MSGDATA msgdata = db.MSGDATAs.Single(m => m.PK == id);
            db.MSGDATAs.DeleteObject(msgdata);
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