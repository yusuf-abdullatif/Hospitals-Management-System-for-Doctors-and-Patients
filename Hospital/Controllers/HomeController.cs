using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Hospital.Models;
using Hospital.Models.database;
using System.Dynamic;
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
        public ActionResult adminDashboardDoctor()
        {
            return View(db.Doctors.ToList());
        }
        public ActionResult adminDashboard()//for doctors
        {
            return View(db.Doctors.ToList());
        }
        public ActionResult CreateAppointment(appointment appointment)
        {
            db.Appointments.Add(appointment);
            db.SaveChanges();
            return RedirectToAction("Appointment");
        }
        [HttpGet]
        public JsonResult GetMyPatientId()
        {
            var patient = db.Patients.Where(p => p.email == User.Identity.Name).FirstOrDefault();
            return Json(patient.patientID, JsonRequestBehavior.AllowGet);
        }

        public ActionResult Appointment()
        {
            dynamic mymodel = new ExpandoObject();
            var user = User.Identity;
            mymodel.userId = user;
            mymodel.thisappointment = new appointment();
            mymodel.Appointments = db.Appointments.ToList();
            mymodel.Patient = db.Patients.Where(x => x.email == user.Name).FirstOrDefault();
            mymodel.Doctors = db.Doctors.ToList();
            return View(mymodel.thisappointment);
        }
        [HttpGet]
        public JsonResult GetDoctors(string departmentId)
        {
            var doctors = db.Doctors.Where(d => d.department == departmentId)
                                    .Select(d => new { Value = d.doctorID, Text = d.name })
                                    .ToList();
            return Json(doctors, JsonRequestBehavior.AllowGet);
        }
        [HttpGet]
        public JsonResult GetNotBusyDates(int doctorId)
        {
            var dates = Enumerable.Range(0, 30).Select(i => DateTime.Now.AddDays(i)).ToList();
            var appointments = db.Appointments.Where(a => a.doctorID == doctorId)
                                              .ToList();

            foreach (var appointment in appointments)
            {
                dates.Remove(appointment.date);
            }

            var returnedValues = dates.Select(d => new { Value = d, Text = d.ToString("yyyy-MM-dd") }).ToList();
            return Json(returnedValues, JsonRequestBehavior.AllowGet);
        }

    }
}