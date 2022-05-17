namespace FinalExam.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddImages : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RentalProperties", "Image", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.RentalProperties", "Image");
        }
    }
}
