namespace Layer1.DATA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CStudents", "Password", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.CStudents", "Password");
        }
    }
}
