﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AQ1.Web.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult Detail(int productId)
        {
            return View();
        }

        public ActionResult Category(int productCategoryId)
        {
            return View();
        }
    }
}