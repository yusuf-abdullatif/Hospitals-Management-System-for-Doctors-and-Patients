using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class test
    {
        public virtual int testID{get;set;}
        public virtual int patientID{get;set;}
        public virtual int appointmentNum{get;set;}
        public virtual int doctorID{get;set;}
        public virtual string attachment { get; set; } // file?
    }
}