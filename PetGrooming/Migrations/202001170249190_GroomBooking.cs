namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class GroomBooking : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Groomers");
            CreateTable(
                "dbo.GroomBookings",
                c => new
                    {
                        GroomBookingId = c.Int(nullable: false, identity: true),
                        GroomBookingDate = c.String(),
                        GroomBookingPrice = c.Int(nullable: false),
                        Weight = c.Int(nullable: false),
                        Color = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.GroomBookingId);
            
            AddColumn("dbo.Groomers", "GroomerId", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Groomers", "GroomerFirstName", c => c.String());
            AlterColumn("dbo.Pets", "Weight", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Groomers", "GroomerId");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Groomers");
            AlterColumn("dbo.Pets", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Groomers", "GroomerFirstName", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Groomers", "GroomerId");
            DropTable("dbo.GroomBookings");
            AddPrimaryKey("dbo.Groomers", "GroomerFirstName");
        }
    }
}
