using System;
using System.Data.Entity;
using System.Linq;

namespace WebProject.Models
{
    public class HospitalDB : DbContext
    {

        public HospitalDB()
            : base("name=HospitalDB")
        {
        }
        public System.Data.Entity.DbSet<WebProject.Models.admin> Admin { get; set; }
        public System.Data.Entity.DbSet<WebProject.Models.appointment> Appointments { get; set; }
        public System.Data.Entity.DbSet<WebProject.Models.doctor> Doctors { get; set; }
        public System.Data.Entity.DbSet<WebProject.Models.hospital> Hospitals { get; set; }
        public System.Data.Entity.DbSet<WebProject.Models.patient> Patients { get; set; }
        public System.Data.Entity.DbSet<WebProject.Models.prescription> Prescriptions { get; set; }
        public System.Data.Entity.DbSet<WebProject.Models.test> Tests { get; set; }


    }

}