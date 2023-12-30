using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hospital.Models.database
{
    public class hospital
    {
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual string hospitalName { get; set; }
        public virtual string address { get; set; }
        public virtual string city { get; set; }
        public virtual string state { get; set; }
    }
}