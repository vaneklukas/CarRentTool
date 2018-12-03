namespace CarRentTool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class carAvailibility : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Availible", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Availible");
        }
    }
}
