namespace CS350_BaggingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Packaging : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Packagings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        WeightCapacity = c.Int(nullable: false),
                        HardItemLimit = c.Int(nullable: false),
                        Length = c.Int(nullable: false),
                        Height = c.Int(nullable: false),
                        Width = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Packagings");
        }
    }
}
