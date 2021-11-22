namespace CS350_BaggingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ItemModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ContainerTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            AddColumn("dbo.Items", "Description", c => c.String());
            AddColumn("dbo.Items", "X", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Y", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Z", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Price", c => c.Int(nullable: false));
            AddColumn("dbo.Items", "Container_Id", c => c.Int());
            CreateIndex("dbo.Items", "Container_Id");
            AddForeignKey("dbo.Items", "Container_Id", "dbo.ContainerTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Items", "Container_Id", "dbo.ContainerTypes");
            DropIndex("dbo.Items", new[] { "Container_Id" });
            DropColumn("dbo.Items", "Container_Id");
            DropColumn("dbo.Items", "Price");
            DropColumn("dbo.Items", "Z");
            DropColumn("dbo.Items", "Y");
            DropColumn("dbo.Items", "X");
            DropColumn("dbo.Items", "Description");
            DropTable("dbo.ContainerTypes");
        }
    }
}
