using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class DoctorModel
    {
        [Required(ErrorMessage = "Please enter yor Username")]
        public string DoctorUsername { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string DoctorPassword { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string DoctorName { get; set; }
        [Required(ErrorMessage = "Please enter your Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string DoctorEmail { get; set; }
    }
}