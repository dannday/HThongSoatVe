using HThongSoatVe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HThongSoatVe.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin/Login

        DBContext db = new DBContext();

        public ActionResult Index()
        {
            if (Session["TKAdmin"] == null)
            {
                return RedirectToAction("Login", "Admin");
            }
            return View();
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection collection)
        {
            string user = collection["form-username"];
            string password = collection["form-password"];

            NhanVien nv = db.NhanViens.SingleOrDefault(a => a.sdt == user && a.pass == password);
            if (nv == null)
            {
                ViewBag.ThongBaoAdmin = "Tài Khoản Hoặc Mật Khẩu Sai";
                return this.Login();
            }
            Session["TKAdmin"] = nv;
            return RedirectToAction("Index", "Admin");
        }

    }
}