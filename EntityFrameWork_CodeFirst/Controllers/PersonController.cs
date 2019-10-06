using EntityFrameWork_CodeFirst.Models;
using EntityFrameWork_CodeFirst.Models.Database_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityFrameWork_CodeFirst.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult New()
        {

            return View();
        }

        [HttpPost]
        public ActionResult New(Person person)
        {
            DataBaseContext db = new DataBaseContext();
            db.Persons.Add(person);
            int sonuc = db.SaveChanges();

            if (sonuc>0)
            {
                ViewBag.Result = "Kişi başarılı bir şekilde kaydedilmiştir.";
                ViewBag.Status = "success";
            }
            else
            {
                ViewBag.Result = "Kişi kaydedilmedi.";
                ViewBag.Status = "danger";
            }

            return View();
        }
    }
}