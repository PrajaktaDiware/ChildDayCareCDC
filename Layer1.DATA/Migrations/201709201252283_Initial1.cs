namespace Layer1.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AddClasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ClassName = c.String(),
                        Category = c.String(),
                        Status = c.Boolean(nullable: false),
                        EnrollCapacity = c.Int(nullable: false),
                        Session = c.String(),
                        Room = c.String(),
                        Mon = c.Boolean(),
                        Tue = c.Boolean(),
                        Wed = c.Boolean(),
                        Thu = c.Boolean(),
                        Fri = c.Boolean(),
                        Sat = c.Boolean(),
                        Gender = c.String(),
                        MinAge = c.Int(nullable: false),
                        MaxAge = c.Int(nullable: false),
                        AgeCutOffDate = c.DateTime(nullable: false),
                        RegistrationStartDate = c.DateTime(nullable: false),
                        ClassStartDate = c.DateTime(nullable: false),
                        ClassEndDate = c.DateTime(nullable: false),
                        StartTime = c.String(),
                        EndTime = c.String(),
                        Description = c.String(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AddStudents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        ChildFirstName = c.String(),
                        ChildLastName = c.String(),
                        DOB = c.DateTime(),
                        ParentFatherName = c.String(),
                        ParentMotherName = c.String(),
                        ParentMobile = c.String(),
                        ParentEmailId = c.String(),
                        GuardianFirstName = c.String(),
                        GuardianLastName = c.String(),
                        GuardianRelation = c.String(),
                        GuardianMobile = c.String(),
                        GuardianEmailId = c.String(),
                        Address = c.String(),
                        Country = c.String(),
                        State = c.String(),
                        City = c.String(),
                        PostalCode = c.Int(nullable: false),
                        Enrolledclass = c.String(),
                        EnrolledRoom = c.String(),
                        EnrolledStartDate = c.DateTime(),
                        EnrolledEndDate = c.DateTime(),
                        AdditionalDetails = c.String(),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.CStudents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Password = c.String(),
                        Email = c.String(),
                        Age = c.Int(nullable: false),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfileClasses",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Class = c.String(),
                        Session = c.String(),
                        RegistrationDate = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        StartTime = c.String(),
                        EndTime = c.String(),
                        Category = c.String(),
                        Status = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProfileStudents",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(),
                        Class = c.String(),
                        Room = c.String(),
                        Gender = c.String(),
                        DOB = c.DateTime(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProfileStudents");
            DropTable("dbo.ProfileClasses");
            DropTable("dbo.CStudents");
            DropTable("dbo.AddStudents");
            DropTable("dbo.AddClasses");
        }
    }
}
