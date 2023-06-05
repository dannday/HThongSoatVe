using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HThongSoatVe.Areas.Admin.Controllers
{
    public class HomeADController : Controller
    {
        // GET: Admin/HomeAD

        public ActionResult Index()
        {
            return View();
        }



        public ActionResult Report()
        {
            return View();
        }

        public ActionResult ListEvent()
        {
            return View();
        }

        public ActionResult CheckIn()
        {
            return View();
        }

    }
}