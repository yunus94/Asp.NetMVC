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
    }
}