using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVC.Controllers
{
    public class BootstrapController : Controller
    {
        // GET: Bootstrap
        public ActionResult HomePage()
        {
            return View();
        }
    }
}