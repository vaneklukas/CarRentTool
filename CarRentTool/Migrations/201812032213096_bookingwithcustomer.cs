namespace CarRentTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookingwithcustomer : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            AddColumn("dbo.Bookings", "Name", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Bookings", "Surname", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Bookings", "Adress", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Bookings", "City", c => c.String(nullable: false, maxLength: 50));
            AddColumn("dbo.Bookings", "PSC", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "Phone", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "Email", c => c.String(nullable: false));
            AddColumn("dbo.Bookings", "DrivingLicenceNo", c => c.Int(nullable: false));
            AddColumn("dbo.Bookings", "PersonalCard", c => c.Int(nullable: false));
            DropColumn("dbo.Bookings", "CustomerId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "CustomerId", c => c.Int(nullable: false));
            DropColumn("dbo.Bookings", "PersonalCard");
            DropColumn("dbo.Bookings", "DrivingLicenceNo");
            DropColumn("dbo.Bookings", "Email");
            DropColumn("dbo.Bookings", "Phone");
            DropColumn("dbo.Bookings", "PSC");
            DropColumn("dbo.Bookings", "City");
            DropColumn("dbo.Bookings", "Adress");
            DropColumn("dbo.Bookings", "Surname");
            DropColumn("dbo.Bookings", "Name");
            CreateIndex("dbo.Bookings", "CustomerId");
            AddForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers", "Id", cascadeDelete: true);
        }
    }
}
