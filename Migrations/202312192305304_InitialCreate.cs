namespace WebProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        adminID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        surname = c.String(),
                    })
                .PrimaryKey(t => t.adminID);
            
            CreateTable(
                "dbo.appointments",
                c => new
                    {
                        appointmentID = c.Int(nullable: false, identity: true),
                        date = c.String(),
                        doctorID = c.Int(nullable: false),
                        patientID = c.Int(nullable: false),
                        hospitalName = c.String(),
                    })
                .PrimaryKey(t => t.appointmentID);
            
            CreateTable(
                "dbo.doctors",
                c => new
                    {
                        doctorID = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        lastName = c.String(),
                        dOfBirth = c.String(),
                        hospital = c.String(),
                        department = c.String(),
                        position = c.String(),
                    })
                .PrimaryKey(t => t.doctorID);
            
            CreateTable(
                "dbo.hospitals",
                c => new
                    {
                        hospitalName = c.String(nullable: false, maxLength: 128),
                        address = c.String(),
                        city = c.String(),
                        state = c.String(),
                    })
                .PrimaryKey(t => t.hospitalName);
            
            CreateTable(
                "dbo.logins",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        ssn = c.String(nullable: false),
                        email = c.String(nullable: false),
                        password = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.patients",
                c => new
                    {
                        patientID = c.Int(nullable: false, identity: true),
                        ssn = c.Int(nullable: false),
                        dOfBirth = c.String(),
                        name = c.String(),
                        surname = c.String(),
                        email = c.String(),
                        phoneNum = c.Int(nullable: false),
                        bloodType = c.String(),
                        diagnoses = c.String(),
                        prescription = c.String(),
                        receivedMessage = c.String(),
                    })
                .PrimaryKey(t => t.patientID);
            
            CreateTable(
                "dbo.prescriptions",
                c => new
                    {
                        prescriptionID = c.Int(nullable: false, identity: true),
                        doctorID = c.Int(nullable: false),
                        patientID = c.Int(nullable: false),
                        drugName = c.String(),
                    })
                .PrimaryKey(t => t.prescriptionID);
            
            CreateTable(
                "dbo.tests",
                c => new
                    {
                        testID = c.Int(nullable: false, identity: true),
                        patientID = c.Int(nullable: false),
                        appointmentNum = c.Int(nullable: false),
                        doctorID = c.Int(nullable: false),
                        attachment = c.String(),
                    })
                .PrimaryKey(t => t.testID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.tests");
            DropTable("dbo.prescriptions");
            DropTable("dbo.patients");
            DropTable("dbo.logins");
            DropTable("dbo.hospitals");
            DropTable("dbo.doctors");
            DropTable("dbo.appointments");
            DropTable("dbo.Admins");
        }
    }
}
