using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Models
{
    public class login
    {
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public int UserID { get; set; }
        [Required(ErrorMessage = "Please enter your ssn")]
        public string ssn { get; set; }
        [Required(ErrorMessage = "Please enter your email")]
        public string email { get; set; }   
        [Required(ErrorMessage = "Please enter your password")]
        public string password { get; set; }


    }
}