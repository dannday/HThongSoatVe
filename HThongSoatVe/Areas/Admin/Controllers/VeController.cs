using HThongSoatVe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HThongSoatVe.Areas.Admin.Controllers
{
    public class VeController : Controller
    {

        DBContext context = new DBContext();
        // GET: Admin/Ve
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult ThemVe()
        {

            return View();
        }
    }
}