using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;


namespace WebProject.Models
{
    public class doctor
    {
     public virtual int doctorID {get;set;}
     public virtual string name{get;set;}
     public virtual string lastName{get;set;}
     public virtual string dOfBirth {get;set;}  // can be changed to different type ,Datetime?
     public virtual string hospital{get;set;}
     public virtual string department{get;set;}
     public virtual string position{get;set;}
     
    }
}