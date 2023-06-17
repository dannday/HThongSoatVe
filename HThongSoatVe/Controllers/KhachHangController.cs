using HThongSoatVe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HThongSoatVe.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: KhachHang
        DBContext db = new DBContext();

        public ActionResult Index()
        {
            if (Session["TKKHang"] == null)
            {
                return RedirectToAction("Login", "KhachHang");
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

            KhachHang kh = db.KhachHangs.SingleOrDefault(a => a.sdt == user && a.pass == password);
            if (kh == null)
            {
                ViewBag.ThongBaoKH = "Tài Khoản Hoặc Mật Khẩu Sai";
                return this.Login();
            }
            Session["TKKHang"] = kh;
            return RedirectToAction("Index", "Admin");
        }

    }
}