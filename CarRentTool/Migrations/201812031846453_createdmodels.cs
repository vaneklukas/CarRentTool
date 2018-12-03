namespace CarRentTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdmodels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FromDate = c.DateTime(nullable: false),
                        ToDate = c.DateTime(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        CarId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cars", t => t.CarId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId)
                .Index(t => t.CarId);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        Km = c.Int(nullable: false),
                        NoSeats = c.Int(nullable: false),
                        priceDay = c.Decimal(nullable: false, precision: 18, scale: 2),
                        priceKm = c.Decimal(nullable: false, precision: 18, scale: 2),
                        LocationId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Locations", t => t.LocationId, cascadeDelete: true)
                .Index(t => t.LocationId);
            
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        City = c.String(),
                        Adress = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Surname = c.String(),
                        Adress = c.String(),
                        City = c.String(),
                        PSC = c.Int(nullable: false),
                        Phone = c.Int(nullable: false),
                        Email = c.String(),
                        DrivingLicenceNo = c.Int(nullable: false),
                        PersonalCard = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Invoices",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOfInvoice = c.DateTime(nullable: false),
                        InvoiceNumber = c.Int(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Bookings", "CarId", "dbo.Cars");
            DropForeignKey("dbo.Cars", "LocationId", "dbo.Locations");
            DropIndex("dbo.Cars", new[] { "LocationId" });
            DropIndex("dbo.Bookings", new[] { "CarId" });
            DropIndex("dbo.Bookings", new[] { "CustomerId" });
            DropTable("dbo.Invoices");
            DropTable("dbo.Customers");
            DropTable("dbo.Locations");
            DropTable("dbo.Cars");
            DropTable("dbo.Bookings");
        }
    }
}
