namespace ArarAirport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddIsCancel : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "IsCancel", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "IsCancel");
        }
    }
}
