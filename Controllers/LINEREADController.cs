using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class LINEREADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /LINEREAD/

        public ActionResult Index()
        {
            return View(db.LINEREADs.ToList());
        }

        //
        // GET: /LINEREAD/Details/5

        public ActionResult Details(int id = 0)
        {
            LINEREAD lineread = db.LINEREADs.Single(l => l.PK == id);
            if (lineread == null)
            {
                return HttpNotFound();
            }
            return View(lineread);
        }

        //
        // GET: /LINEREAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /LINEREAD/Create

        [HttpPost]
        public ActionResult Create(LINEREAD lineread)
        {
            if (ModelState.IsValid)
            {
                db.LINEREADs.AddObject(lineread);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lineread);
        }

        //
        // GET: /LINEREAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            LINEREAD lineread = db.LINEREADs.Single(l => l.PK == id);
            if (lineread == null)
            {
                return HttpNotFound();
            }
            return View(lineread);
        }

        //
        // POST: /LINEREAD/Edit/5

        [HttpPost]
        public ActionResult Edit(LINEREAD lineread)
        {
            if (ModelState.IsValid)
            {
                db.LINEREADs.Attach(lineread);
                db.ObjectStateManager.ChangeObjectState(lineread, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lineread);
        }

        //
        // GET: /LINEREAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            LINEREAD lineread = db.LINEREADs.Single(l => l.PK == id);
            if (lineread == null)
            {
                return HttpNotFound();
            }
            return View(lineread);
        }

        //
        // POST: /LINEREAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            LINEREAD lineread = db.LINEREADs.Single(l => l.PK == id);
            db.LINEREADs.DeleteObject(lineread);
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