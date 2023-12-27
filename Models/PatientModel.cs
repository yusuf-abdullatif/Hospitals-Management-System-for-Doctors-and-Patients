using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class PatientModel
    {
        [Required(ErrorMessage = "Please enter your SSN")]
        public int PatientSsn { get; set; }
        [Required(ErrorMessage = "Please enter your name")]
        public string PatientName { get; set; }
        public string PatientAddress { get; set; }
        public string PatientPhone { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string PatientEmail { get; set; }
        [Required(ErrorMessage = "Please enter your password")]
        public string PatientPassword { get; set; }

    }
}