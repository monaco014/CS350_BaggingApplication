   namespace CS350_BaggingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateDataTyeps : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Items", "Length", c => c.Double(nullable: false));
            AlterColumn("dbo.Items", "Height", c => c.Double(nullable: false));
            AlterColumn("dbo.Items", "Width", c => c.Double(nullable: false));
            AlterColumn("dbo.Items", "Weight", c => c.Double(nullable: false));
            AlterColumn("dbo.Items", "Price", c => c.Double(nullable: false));
            AlterColumn("dbo.Packagings", "WeightCapacity", c => c.Double(nullable: false));
            AlterColumn("dbo.Packagings", "Height", c => c.Double(nullable: false));
            AlterColumn("dbo.Packagings", "Width", c => c.Double(nullable: false));
            AlterColumn("dbo.Packagings", "Length", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Packagings", "Length", c => c.Int(nullable: false));
            AlterColumn("dbo.Packagings", "Width", c => c.Int(nullable: false));
            AlterColumn("dbo.Packagings", "Height", c => c.Int(nullable: false));
            AlterColumn("dbo.Packagings", "WeightCapacity", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Price", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Weight", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Width", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Height", c => c.Int(nullable: false));
            AlterColumn("dbo.Items", "Length", c => c.Int(nullable: false));
        }
    }
}
