using Asp.NetMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVC.Controllers
{
    public class ModelController : Controller
    {
        // GET: Model
        public ActionResult HomePage()
        {
            Person person = new Person();
            person.Name = "Yunus";
            person.Surname = "ÖNAL";
            person.Age = 25;
            return View(person);
        }
        [HttpPost]
        public ActionResult HomePage(Person p)
        {
            return View(p);
        }
    }
}