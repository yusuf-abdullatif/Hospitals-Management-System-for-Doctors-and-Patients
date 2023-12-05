using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class patient
    {
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