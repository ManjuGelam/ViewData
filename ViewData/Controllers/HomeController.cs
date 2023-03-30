using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ViewData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index( int? id,string name,double? price)
        {
            ViewData["id"] = id;
            ViewData["name"] = name;
            ViewData["price"] = price;
            return View();
        }
    }
}
