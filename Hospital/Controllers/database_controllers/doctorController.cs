using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Hospital.Models.database;

namespace Hospital.Controllers.database_controllers
{
    public class doctorController : Controller
    {
        private hospitalDB db = new hospitalDB();

        // GET: doctor
        public ActionResult Index()
        {
            return View(db.Doctors.ToList());
        }

        // GET: doctor/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // GET: doctor/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: doctor/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "doctorID,ssn,name,lastName,dOfBirth,hospital,department,position")] doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Doctors.Add(doctor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doctor);
        }

        // GET: doctor/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: doctor/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "doctorID,ssn,name,lastName,dOfBirth,hospital,department,position")] doctor doctor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doctor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doctor);
        }

        // GET: doctor/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            doctor doctor = db.Doctors.Find(id);
            if (doctor == null)
            {
                return HttpNotFound();
            }
            return View(doctor);
        }

        // POST: doctor/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            doctor doctor = db.Doctors.Find(id);
            db.Doctors.Remove(doctor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private List<doctor> GetDoctors()
        {
            return new List<doctor>
            {
                new doctor { doctorID = 1, ssn = 123456789, name = "John", lastName = "Doe", dOfBirth = "01/01/1980", hospital = "General Hospital", department = "Cardiology", position = "Cardiologist" },
                new doctor { doctorID = 2, ssn = 987654321, name = "Jane", lastName = "Smith", dOfBirth = "05/15/1985", hospital = "City Hospital", department = "Pediatrics", position = "Pediatrician" },
                // Add more doctors as needed
            };
        }

        public ActionResult dashboard()
        {
            var doctors = GetDoctors();
            return View(doctors);
        }

        public ActionResult doctor_info(int? id)
        {
            if (id == null)
            {
                // Handle case where ID is not provided
                return RedirectToAction("dashboard");
            }

            var doctorInfo = GetDoctors().Find(d => d.doctorID == id);

            if (doctorInfo == null)
            {
                // Handle case where doctor with given ID is not found
                return RedirectToAction("dashboard");
            }

            return View(doctorInfo);
        }
    }

}
