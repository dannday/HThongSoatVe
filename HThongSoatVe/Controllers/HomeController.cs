﻿using HThongSoatVe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;


namespace HThongSoatVe.Controllers
{
    public class HomeController : Controller
    {
        DBContext context = new DBContext();
        
        public ActionResult Index()
        {
           return View();
        }

        

    }
}