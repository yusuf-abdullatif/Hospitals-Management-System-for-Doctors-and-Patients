using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebProject.Models
{
    public class patient
    {
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual int patientID{ get; set; }
        public virtual int ssn{ get; set; }
        public virtual string dOfBirth{ get; set; }
        public virtual string name{ get; set; }
        public virtual string surname{ get; set; }
        public virtual string email{ get; set; }
        public virtual char gender{ get; set; }
        public virtual int phoneNum{ get; set; }
        public virtual string bloodType{ get; set; } //can be changed to char array
        public virtual string diagnoses{ get; set; }
        public virtual string prescription{ get; set; }
        public virtual string receivedMessage { get; set; }


    }
}