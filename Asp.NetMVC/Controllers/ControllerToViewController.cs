using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVC.Controllers
{
    public class ControllerToViewController : Controller
    {
        // GET: ControllerToView
        public ActionResult Index()
        {
            //ViewData["FullName"] = "yunus önal";     //Viewdata ve viewbag yazım şekli farklı olsada kullanımı aynıdır.
            //ViewData["check"] = true;

            //TempData["FullName"] = "yunus önal";       tempdata ya farklı sayfalardan da ulaşılabilir. İkinci sayfaya kadar veriyi saklar.
            //TempData["Check"] = true;

            ViewBag.FullName = "Yunus ÖNAL";            //Viewbag ve viewdata veriyi sadece tek bir sayfada tutar. 
            ViewBag.Check = true;

            ViewBag.List = new SelectListItem[]
            {
                new SelectListItem() {Text = "Malatya"},
                new SelectListItem() {Text = "Diyarbakır"},
                new SelectListItem() {Text = "Ankara"},
                new SelectListItem() {Text = "İstanbul"}
            };
            return View();
        }

        public ActionResult HomePage()
        {
            return View();
        }

        [HttpPost]
        public ActionResult HomePage(string Name, bool Check, string list1)
        {
            //var n1 = Request.Form["Name"];
            //var l1 = Request.Form["list1"];
            //var c1 = Request.Form.GetValues("Check")[0];  //Seçili durumu başa alır. Checkbox işaretliyse True,False , işaretli değilse False,true yapar.
            return View();
        }
    }
}