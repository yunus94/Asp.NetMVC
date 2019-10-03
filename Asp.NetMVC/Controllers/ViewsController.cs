using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVC.Controllers
{
    public class ViewsController : Controller
    {
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View();
        }
        public ActionResult About2()
        {
            return View();
        }
        public ActionResult SectionLayout()
        {
            return View();
        }

    }
}