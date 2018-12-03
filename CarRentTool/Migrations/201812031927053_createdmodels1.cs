namespace CarRentTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdmodels1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cars", "Manufacturer", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Cars", "Model", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Locations", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Locations", "Adress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Locations", "Email", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "Phone", c => c.String(nullable: false));
            AlterColumn("dbo.Customers", "Name", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Surname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Adress", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "City", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Customers", "Email", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "Email", c => c.String());
            AlterColumn("dbo.Customers", "City", c => c.String());
            AlterColumn("dbo.Customers", "Adress", c => c.String());
            AlterColumn("dbo.Customers", "Surname", c => c.String());
            AlterColumn("dbo.Customers", "Name", c => c.String());
            AlterColumn("dbo.Locations", "Phone", c => c.String());
            AlterColumn("dbo.Locations", "Email", c => c.String());
            AlterColumn("dbo.Locations", "Adress", c => c.String());
            AlterColumn("dbo.Locations", "City", c => c.String());
            AlterColumn("dbo.Cars", "Model", c => c.String());
            AlterColumn("dbo.Cars", "Manufacturer", c => c.String());
        }
    }
}
