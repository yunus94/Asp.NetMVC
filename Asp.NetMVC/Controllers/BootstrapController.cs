using Asp.NetMVC.Models;
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
        public ActionResult HelperMethod()
        {
            return View();
        }
        public ActionResult CustomHelper()
        {
            List<Message> messages = new List<Message>();
            messages.Add(new Message { Level = 1, Text = "Uyarı mesajı" });
            messages.Add(new Message { Level = 2, Text = "Uyarı mesajı2" });
            messages.Add(new Message { Level = 3, Text = "Uyarı mesajı3" });
            return View(messages);
        }
        
    }
}