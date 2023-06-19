using HThongSoatVe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;


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
        public ActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(FormCollection collection, KhachHang kh)
        {
            //
            var Ten = collection["ten"];
            string Date = String.Format("{0:MM/dd/yyyy}", collection["ngaysinh"]);


            var Sdt = collection["sdt"];
            var Pass = collection["pass"];
            var ConfirmMK = collection["ConfirmPass"];

            
            if (Pass.Equals(ConfirmMK))
            {
                if (Ten == null || Sdt == null || Pass == null )
                {
                    return HttpNotFound();
                }
                else
                {
                    MD5 md5 = new MD5CryptoServiceProvider();

                    md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(ConfirmMK));

                    byte[] bytedata = md5.Hash;

                    StringBuilder builder = new StringBuilder();
                    for (int i = 0; i < bytedata.Length; i++)
                    {

                        builder.Append(bytedata[i].ToString("x2"));
                    }

                    string MaHoa = builder.ToString();

                    kh.ten = Ten;
                    kh.sdt = Sdt;
                    kh.pass = MaHoa;
                    kh.ngaysinh = DateTime.Parse(Date);
                    //db.KhachHangs.InsertOnSubmit(kh);

                    //db.SubmitChanges();

                    //sentmail
                    //string subject = "HueVestival";
                    string mess = "Chào mừng " + kh.ten + " đến với HueVestival";
                    return RedirectToAction("Login", "KhachHang");
                }
            }
            else
            {
                @ViewData["error"] = "Mật Khẩu Không Trùng Khớp";
                return this.SignUp();
            }

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
            return RedirectToAction("Index", "KhachHang");
        }

    }
}