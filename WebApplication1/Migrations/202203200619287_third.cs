namespace WebApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class third : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Appointments", "ptemail", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Appointments", "ptemail");
        }
    }
}
