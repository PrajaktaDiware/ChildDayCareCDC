namespace Layer1.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChildGenderAdded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AddStudents", "ChildGender", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AddStudents", "ChildGender");
        }
    }
}
