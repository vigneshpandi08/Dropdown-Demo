using Dropdown_demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dropdown_demo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        TestEntities1 entities = new TestEntities1();
        public ActionResult Index()
        {
            return View();
        }
        public JsonResult Getcity()
        {
            var cityname = entities.CityLists.ToList();
            return Json(cityname, JsonRequestBehavior.AllowGet);

        }
    }
}