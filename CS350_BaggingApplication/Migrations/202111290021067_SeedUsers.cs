namespace CS350_BaggingApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'94df64b9-ece9-40fd-ae2c-13374b00f669', N'admin@email.com', 0, N'AOuabJD0c5+2ISi11mOmnrt630DERE/ZAQovkBQLVbsb2lZiEuZvxb0jAkBJOHFwzA==', N'5eec57cb-8063-4cee-9dc2-60ed36438f69', NULL, 0, 0, NULL, 1, 0, N'admin@email.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'fd100b0d-bac2-48dc-9c89-815e093b9cf4', N'guest@email.com', 0, N'ACMhSgY5701Ttbzx0fN1WF4bo/v3umKf63EEQE3CmHdZKLZzENjor3wR8ylBEPYY7w==', N'3fafacb6-fb4d-4360-8096-48945364518f', NULL, 0, 0, NULL, 1, 0, N'guest@email.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'64f9a38a-aa10-4d7d-9ea9-1f1702731f7a', N'Admin')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'94df64b9-ece9-40fd-ae2c-13374b00f669', N'64f9a38a-aa10-4d7d-9ea9-1f1702731f7a')
");


        }
        
        public override void Down()
        {
        }
    }
}
