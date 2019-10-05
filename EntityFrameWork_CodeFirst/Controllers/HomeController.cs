using EntityFrameWork_CodeFirst.Models;
using EntityFrameWork_CodeFirst.Models.Database_Manager;
using EntityFrameWork_CodeFirst.ViewModels.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWork_CodeFirst.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult HomePage()
        {
            DataBaseContext db = new DataBaseContext();
            //List<Person> person =db.Persons.ToList();

            HomePageViewModel model = new HomePageViewModel();
            model.Persons = db.Persons.ToList();
            model.Addresses = db.Addresses.ToList();
            return View(model);
        }
    }
}