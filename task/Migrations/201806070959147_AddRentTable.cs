namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RentDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        startDate = c.DateTime(nullable: false),
                        endDate = c.DateTime(nullable: false),
                        Rent = c.String(),
                        Terms = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.RentDetails");
        }
    }
}
