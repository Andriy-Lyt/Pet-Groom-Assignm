namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Groomer : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Groomers",
                c => new
                    {
                        GroomerFirstName = c.Int(nullable: false, identity: true),
                        GroomerLastName = c.String(),
                        GroomerBirthDate = c.String(),
                        GroomerPhone = c.String(),
                        GroomerRate = c.String(),
                    })
                .PrimaryKey(t => t.GroomerFirstName);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Groomers");
        }
    }
}
