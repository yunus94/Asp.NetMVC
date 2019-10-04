using Asp.NetMVC.Models;
using Asp.NetMVC.ViewsModels;
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

            Address address = new Address();
            address.AddressDefinition = "Deneme adresi.";
            address.City = "Malatya";

            HomePageViewModel mod = new HomePageViewModel();
            mod.Persons = person;
            mod.Addresss = address;
            return View(mod);
        }
        [HttpPost]
        public ActionResult HomePage(Person p)
        {
            return View(p);
        }
    }
}