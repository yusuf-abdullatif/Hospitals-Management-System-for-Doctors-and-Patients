using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hospital.Models;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        [Authorize(Roles = MyRoles.Admin)]
        public ActionResult AdminArea()
        {
            return View();
        }
        [Authorize(Roles = MyRoles.Manager)]
        public ActionResult ManagerArea()
        {
            return View();
        }
        [Authorize(Roles = MyRoles.User)]
        public ActionResult UserArea()
        {
            return View();
        }
    }
}