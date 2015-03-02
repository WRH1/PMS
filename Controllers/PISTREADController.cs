using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PISTREADController : Controller
    {
        private Entities db = new Entities();

        //
        // GET: /PISTREAD/

        public ActionResult Index()
        {
            return View(db.PISTREADs.ToList());
        }

        //
        // GET: /PISTREAD/Details/5

        public ActionResult Details(int id = 0)
        {
            PISTREAD pistread = db.PISTREADs.Single(p => p.PK == id);
            if (pistread == null)
            {
                return HttpNotFound();
            }
            return View(pistread);
        }

        //
        // GET: /PISTREAD/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /PISTREAD/Create

        [HttpPost]
        public ActionResult Create(PISTREAD pistread)
        {
            if (ModelState.IsValid)
            {
                db.PISTREADs.AddObject(pistread);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pistread);
        }

        //
        // GET: /PISTREAD/Edit/5

        public ActionResult Edit(int id = 0)
        {
            PISTREAD pistread = db.PISTREADs.Single(p => p.PK == id);
            if (pistread == null)
            {
                return HttpNotFound();
            }
            return View(pistread);
        }

        //
        // POST: /PISTREAD/Edit/5

        [HttpPost]
        public ActionResult Edit(PISTREAD pistread)
        {
            if (ModelState.IsValid)
            {
                db.PISTREADs.Attach(pistread);
                db.ObjectStateManager.ChangeObjectState(pistread, System.Data.EntityState.Modified);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pistread);
        }

        //
        // GET: /PISTREAD/Delete/5

        public ActionResult Delete(int id = 0)
        {
            PISTREAD pistread = db.PISTREADs.Single(p => p.PK == id);
            if (pistread == null)
            {
                return HttpNotFound();
            }
            return View(pistread);
        }

        //
        // POST: /PISTREAD/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            PISTREAD pistread = db.PISTREADs.Single(p => p.PK == id);
            db.PISTREADs.DeleteObject(pistread);
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