namespace PetGrooming.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Owner : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Owners",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        OwnerFirstName = c.String(),
                        OwnerLastName = c.String(),
                        OwnerAddress = c.String(),
                        OwnerPhoneWork = c.String(),
                        OwnerPhoneHome = c.String(),
                    })
                .PrimaryKey(t => t.OwnerId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Owners");
        }
    }
}
