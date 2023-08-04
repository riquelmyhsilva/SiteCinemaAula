using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SiteCinema.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult movieBarbie()
        {
            return View();
        }

        public ActionResult movieBezouroAzul()
        {
            return View();
        }

        public ActionResult filmeIndisponivel()
        {
            return View();
        }
    }
}