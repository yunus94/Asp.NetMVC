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

        public ActionResult Edit(int? personId)
        {
            Person person = null;
            if (personId!=null)
            {
                DataBaseContext db = new DataBaseContext();
                person = db.Persons.Where(x => x.ID == personId).FirstOrDefault();
            }
            return View(person);
        }
        [HttpPost]
        public ActionResult Edit(Person model, int personId)
        {
            DataBaseContext db = new DataBaseContext();
            Person person = db.Persons.Where(x => x.ID == personId).FirstOrDefault();
            if (person != null)
            {
                person.Name = model.Name;
                person.SurName = model.SurName;
                person.Age = model.Age;

                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    ViewBag.Result = "Kişi başarılı bir şekilde güncellenmiştir.";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Kişi güncellenemedi.";
                    ViewBag.Status = "danger";
                }
            }
            return View();
        }

       [HttpGet]
        public ActionResult Delete(int? personId)
        {
            Person person = null;
            if (personId!=null)
            {
                DataBaseContext db = new DataBaseContext();
                person = db.Persons.Where(x => x.ID == personId).FirstOrDefault();
            }
            return View(person);
        }
        [HttpPost,ActionName("Delete")]
        public ActionResult DeleteOk(int? personId)
        {
            if (personId != null)
            {
                DataBaseContext db = new DataBaseContext();
                Person person = db.Persons.Where(x => x.ID == personId).FirstOrDefault();
                db.Persons.Remove(person);
                db.SaveChanges();
            }
            return RedirectToAction("HomePage","Home");
        }
    }
}