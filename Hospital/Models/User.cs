using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Hospital.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string SSN { get; set; }
        public string Password { get; set; }

    }
}