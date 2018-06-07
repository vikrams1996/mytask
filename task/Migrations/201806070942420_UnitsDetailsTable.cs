namespace task.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UnitsDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.UnitDetails",
                c => new
                    {
                        Id = c.Byte(nullable: false),
                        unitNo = c.Int(nullable: false),
                        areaSf = c.String(),
                        Location = c.String(),
                        ratePsf = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.UnitDetails");
        }
    }
}
