using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Hospital.Models.database
{
    public class appointment
    {
        [Key] 
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual int appointmentID { get; set; }
        public virtual string date { get; set; } //change to datetime??????????????
        public virtual int doctorID { get; set; }
        public virtual int patientID { get; set; }
        public virtual string hospitalName { get; set; }
    }
}