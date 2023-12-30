using System;
using System.Data.Entity;
using System.Linq;

namespace Hospital.Models.database
{
    public class hospitalDB : DbContext
    {

        public hospitalDB()
            : base("HospitalDB")
        {
        }
        public System.Data.Entity.DbSet<Hospital.Models.database.appointment> Appointments { get; set; }
        public System.Data.Entity.DbSet<Hospital.Models.database.doctor> Doctors { get; set; }
        public System.Data.Entity.DbSet<Hospital.Models.database.hospital> Hospitals { get; set; }
        public System.Data.Entity.DbSet<Hospital.Models.database.patient> Patients { get; set; }
        public System.Data.Entity.DbSet<Hospital.Models.database.prescription> Prescriptions { get; set; }
        public System.Data.Entity.DbSet<Hospital.Models.database.test> Tests { get; set; }

    }

}