﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PMS.Controllers
{
    public class PMSStatusController : Controller
    {
        private PMSDataEntities db = new PMSDataEntities();
        //
        // GET: /PMSStatus/

        public ActionResult AlramSetPoint() { return View(); }
        public ActionResult Budgeting() { return View(); }
        public ActionResult EquipmentDetails() { return View(); }
        public ActionResult Incident() { return View(); }
        public ActionResult Inculation() { return View(); }
        public ActionResult Index() { return View(); }
        public ActionResult MonthlyReport() { return View(); }
        public ActionResult MultipleAddEdit() { return View(); }
        public ActionResult Overdue() { return View(); }
        public ActionResult PostponedItems() { return View(); }
        public ActionResult RunningHours() { return View(); }
        public ActionResult SetCriticalItems() { return View(); }
        public ActionResult SingleAddEdit() { return View(); }
        public ActionResult TracingComp() { return View(); }
        public ActionResult Vendor() { return View(); }


        // Tree Main and pms items
        public ActionResult TreeMainAndPmsItems()
        {
            var tree = (from m in db.MAINITEMs
                        join p in db.PMSITEMs on m.MAINCODE equals p.MAINCODE
                        select new{m.MAINCODE, p.PMSCODE, p.PMSITEM1}).ToList();
            return View();
        }

    }
}
