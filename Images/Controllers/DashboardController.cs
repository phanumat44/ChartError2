using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Images.Models;

namespace Images.Controllers
{
    public class DashboardController : Controller
    {
        private Entities1 db = new Entities1();
        // GET: Dashboard
        public ActionResult Index()
        {
            var data = db.Pictures.Select(n => n.Pic_ID).Count();
            ViewData["Message"] = data;
            return View();
        }
    }
}