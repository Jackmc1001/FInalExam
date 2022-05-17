namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentalProperties",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        rentalType = c.Int(nullable: false),
                        Location = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RentalProperties");
        }
    }
}
