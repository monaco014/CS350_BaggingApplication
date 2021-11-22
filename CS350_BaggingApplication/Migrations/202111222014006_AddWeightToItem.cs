namespace CS350_BaggingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddWeightToItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Weight", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Weight");
        }
    }
}
