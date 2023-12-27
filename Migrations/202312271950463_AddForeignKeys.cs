namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddForeignKeys : DbMigration
    {
        public override void Up()
        {
            CreateIndex("dbo.appointments", "doctorID");
            CreateIndex("dbo.appointments", "patientID");
            AddForeignKey("dbo.appointments", "doctorID", "dbo.doctors", "doctorID", cascadeDelete: true);
            AddForeignKey("dbo.appointments", "patientID", "dbo.patients", "patientID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.appointments", "patientID", "dbo.patients");
            DropForeignKey("dbo.appointments", "doctorID", "dbo.doctors");
            DropIndex("dbo.appointments", new[] { "patientID" });
            DropIndex("dbo.appointments", new[] { "doctorID" });
        }
    }
}
