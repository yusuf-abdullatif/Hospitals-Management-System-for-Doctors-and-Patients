using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models.database
{
    public class doctor
    {
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual int doctorID { get; set; }
        public virtual int ssn { get; set; }
        public virtual string name { get; set; }
        public virtual string lastName { get; set; }
        public virtual string dOfBirth { get; set; }  // change to datetime???????????
        public virtual string hospital { get; set; }
        public virtual string department { get; set; }
        public virtual string position { get; set; }
    }
}