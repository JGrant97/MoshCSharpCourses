namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2e14717a-24ab-44ec-aace-93be83d37d1d', N'admin@vidly.com', 0, N'AAWGr8aGJ198EfCnQscIFGbSMaLLe8iBqsYojq/irA2pM3oB+Z25qgRti80AqaW+PA==', N'fe126df3-5850-4429-965b-b14f905343c9', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'c4533893-d4a4-4e0d-9137-0d6e8a7062e4', N'guest@vidly.com', 0, N'AJawlVTg+NfA6Uhi85xIgu1XZHusU+mDdq9DiyKcrkW79awhpWmsjc39nXp8pWD4Jw==', N'6751c9fc-1549-4af7-b251-11d8040a1318', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'd9a68b48-72e2-42f1-b982-9b37b963ad73', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2e14717a-24ab-44ec-aace-93be83d37d1d', N'd9a68b48-72e2-42f1-b982-9b37b963ad73')

            ");
        }
        
        public override void Down()
        {
        }
    }
}
