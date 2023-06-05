using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HThongSoatVe.Controllers
{
    public class ChuongTrinhController : Controller
    {
        // GET: ChuongTrinh

        public ActionResult Index()
        {
            string path = "http://huefestival.com/mobile_api/index.php?key=88888888&lang=vn&module=get_service_detail&cate_id=2&typedata=1&service_id=225";
            object chuongtrinh = GetChuongTrinh(path);
            JObject jObject =  JObject.Parse(chuongtrinh.ToString());
            ViewBag.data = jObject["detail"];


            return View();
        }

        public object GetChuongTrinh(string path)
        {

            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<object>(
                    webClient.DownloadString(path));
            }

            
        }
         
        public ActionResult TieuDiem()
        {
            return View();
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