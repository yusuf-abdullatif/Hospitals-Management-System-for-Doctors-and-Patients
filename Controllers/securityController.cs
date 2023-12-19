using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebProject.Models;

namespace WebProject.Controllers
{
    public class securityController : Controller
    {
        HospitalDB db = new HospitalDB();

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(login user)
        {
            var usr = db.logins.Where(u => u.password == user.password && u.ssn == user.ssn).FirstOrDefault();
            if (usr != null)
            {
                FormsAuthentication.SetAuthCookie(usr.ssn, false); //auth based on ssn
                return RedirectToAction("Index", "doctors");//redirect to home page when login change this 
            }
            else
            {
                ViewBag.Message = "Invalid username or password";
                return View();
            }
            //login login = db.logins.Find(usr);
            //if (login == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(login);
        }

    }
}
