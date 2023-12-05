using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class appointment
    {
        public virtual int appointmentNum {get;set;}
        public virtual string date {get;set;} //Datetime?
        public virtual int doctorID {get;set;}
        public virtual int patientID {get;set;}
        public virtual string hospitalName { get; set; }
    }
}