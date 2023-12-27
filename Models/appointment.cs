using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Models
{
    public class appointment
    {
         // This is the navigation property for doctor
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual int appointmentID {get;set;}
        public virtual string date {get;set;} //Datetime?
        [ForeignKey("doctorID")]
        public virtual doctor Doctor { get; set; }
        [ForeignKey("patientID")]
        public virtual patient Patient { get; set; }

        public virtual string hospitalName { get; set; }
    }
}