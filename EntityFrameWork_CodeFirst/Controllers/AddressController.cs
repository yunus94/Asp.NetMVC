using EntityFrameWork_CodeFirst.Models;
using EntityFrameWork_CodeFirst.Models.Database_Manager;
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
            //DataBaseContext db = new DataBaseContext();
            //List<Person> person = db.Persons.ToList();
            //List<SelectListItem> personList = new List<SelectListItem>();
            //foreach (Person persons in person)
            //{
            //    SelectListItem item = new SelectListItem();
            //    item.Text = persons.Name + " " + persons.SurName;
            //    item.Value = persons.ID.ToString();
            //    personList.Add(item);
            //}

            //LinQ  
            DataBaseContext db = new DataBaseContext();
            List<SelectListItem> personList =
                (from person in db.Persons.ToList()
                 select new SelectListItem()
                 {
                     Text = person.Name + " " + person.SurName,
                     Value = person.ID.ToString()
                 }).ToList();

            TempData["person"] = personList;
            ViewBag.person = personList;
            return View();
        }
        [HttpPost]
        public ActionResult New(Address address)
        {
            DataBaseContext db = new DataBaseContext();
            Person person = db.Persons.Where(x => x.ID == address.Persons.ID).FirstOrDefault();
            if (person!=null)
            {
                address.Persons = person;
                db.Addresses.Add(address);
                int sonuc = db.SaveChanges();

                if (sonuc > 0)
                {
                    ViewBag.Result = "Adres başarılı bir şekilde kaydedilmiştir.";
                    ViewBag.Status = "success";
                }
                else
                {
                    ViewBag.Result = "Adres kaydedilmedi.";
                    ViewBag.Status = "danger";
                }
            }
            ViewBag.person = TempData["person"];
            return View();
        }
    }
}