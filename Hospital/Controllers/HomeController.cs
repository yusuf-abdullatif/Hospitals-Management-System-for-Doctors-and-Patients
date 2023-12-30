using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hospital.Models;
using Hospital.Models.database;
namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private hospitalDB db = new hospitalDB();
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
        public ActionResult sign_in()
        {
            return View();
        }

        public ActionResult adminDashboardPatients()
        {
            return View(db.Patients.ToList());
        }
        public ActionResult adminDashboardAppointments()
        {
            return View(db.Appointments.ToList());
        }
        public ActionResult adminDashboard()//for doctors
        {
            return View(db.Doctors.ToList());
        }
    }
}