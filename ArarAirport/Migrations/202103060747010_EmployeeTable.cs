namespace ArarAirport.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EmployeeTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FullName = c.String(nullable: false),
                        DateofBirth = c.DateTime(nullable: false),
                        IDCodeNum = c.String(),
                        MailAddress = c.String(),
                        PhoneNumber = c.String(),
                        ContractType = c.Int(nullable: false),
                        ContractTypeID = c.Int(nullable: false),
                        Position = c.Int(nullable: false),
                        PositionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Employees");
        }
    }
}
