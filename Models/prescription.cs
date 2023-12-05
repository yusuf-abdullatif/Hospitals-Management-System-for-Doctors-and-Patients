using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebProject.Models
{
    public class prescription
    {
        public virtual int prescriptionID{get;set;}
        public virtual int doctorID{get;set;}
        public virtual int patientID{get;set;}
        public virtual string drugName { get; set; }
    }
}