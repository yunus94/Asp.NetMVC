using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWork_CodeFirst.Controllers
{
    public class AddressController : Controller
    {
        // GET: Address
        public ActionResult New()
        {
            return View();
        }
    }
}