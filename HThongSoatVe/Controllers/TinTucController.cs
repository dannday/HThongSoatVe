using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace HThongSoatVe.Controllers
{
    public class TinTucController : Controller
    {
        // GET: TinTuc
        public ActionResult Index()
        {
            string path = "http://huefestival.com/mobile_api/index.php?key=88888888&lang=vn&module=get_service_detail&cate_id=2&typedata=1&service_id=225";
            object tintuc = GetTinTuc(path);
            JObject jObject = JObject.Parse(tintuc.ToString());
            ViewBag.data = jObject["detail"];


            return View();
        }

        public object GetTinTuc(string path)
        {

            using (WebClient webClient = new WebClient())
            {
                return JsonConvert.DeserializeObject<object>(
                    webClient.DownloadString(path));
            }


        }
    }
}