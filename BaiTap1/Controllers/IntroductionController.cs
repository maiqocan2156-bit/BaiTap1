using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BaiTap1.Controllers
{
    public class IntroductionController : Controller
    {
        // GET: Introduction
        public ActionResult intro()
        {
            return View();
        }
    }
}