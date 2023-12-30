using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models.database
{
    public class prescription
    {
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual int prescriptionID { get; set; }
        public virtual int doctorID { get; set; }
        public virtual int patientID { get; set; }
        public virtual string drugName { get; set; }
    }
}