using HThongSoatVe.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace HThongSoatVe.Controllers
{
    public class ChuongTrinhController : Controller
    {
       
        DBContext context = new DBContext();
        private List<ChuongTrinh> ListCT(int count)
        {
            return context.ChuongTrinhs.OrderByDescending(a => a.id_chuongtrinh).Take(count).ToList();
        }
        public ActionResult Index(int? page)
        {
            int pagesize = 5;
            int pageNum = (page ?? 1);
            var Sachmoi = ListCT(20);
            return View(Sachmoi.ToPagedList(pageNum, pagesize));
        }



        public ActionResult AllSP(int? page)
        {
            var allSP = from ct in context.ChuongTrinhs select ct;

            int pagesize = 5;
            int pageNum = (page ?? 1);
            return View(allSP.ToPagedList(pageNum, pagesize));
        }

        //public ActionResult Index()
        //{
        //    return View();
        //}

        //public ActionResult ChitietCT()
        //{
        //    return View();
        //}

        public ActionResult ChitietCT(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var chitietSP = from s in context.ChuongTrinhs where s.id_chuongtrinh == id select s;
            return View(chitietSP.Single());


        }



        public ActionResult CongDong()
        {
            return View();
        }

        public ActionResult NgheSi()
        {
            return View();
        }

        public ActionResult LichDien()
        {
            return View();
        }
    }
}