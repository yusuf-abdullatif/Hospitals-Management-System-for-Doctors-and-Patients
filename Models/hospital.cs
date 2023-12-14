using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
//•	Patient: Patient ID(Primary), Social Security Number, Date of Birth, Name, Surname, Email, Gender, Phone Number, Blood Type, Diagnoses, Prescription
//•	Doctor: Employee ID, Name, Surname, Date of Birth, Hospital, Department, Position
//•	Admin: Admin ID(Primary), Namem, Surname.
//•	Tests: Test ID, Patient ID, Appointment Number, Doctor ID, Attachment
//•	Prescription: Prescription ID, Doctor ID, Patient ID, Drug name
//•	Appointment: Appointment Number(Primary),Date, Doctor ID, Patient ID, Hospital Name 
//•	Hospital: Hospital Name(Primary), Address, City, State
namespace WebProject.Models
{
    public class hospital
    {
        [Key] // This attribute marks the property as the primary key
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // This attribute specifies that the database should generate a value for this property
        public virtual string hospitalName{get;set;}
        public virtual string address{get;set;}
        public virtual string city{get;set;}
        public virtual string state { get; set; }
    }
}