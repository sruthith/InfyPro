using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Office()
        {
            return View();
        }
        public ActionResult Transportation()
        {
            return View();
        }
        public ActionResult ParkingLot()
        {
            return View();
        }
        public ActionResult ApartmentsAndBuildings()
        {
            return View();
        }
        public ActionResult Shopping()
        {
            return View();
        }
        public ActionResult Restaurants()
        {
            return View();
        }
    }
}