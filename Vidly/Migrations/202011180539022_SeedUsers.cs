namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'2899d2c9-4936-4ab5-9fcb-9e1720612d31', N'admin@vidly.com', 0, N'AKs+G5NecGPY6s3SOUl68+Nyf8WIXeIBZSvGOjKaRtc2D7fDuHisFsLqXl2hyeUxYw==', N'52b53e67-02b3-472e-91ec-22796e6761f4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                    INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'985f7bf9-8e48-4d17-a6f8-c0f70494aa9a', N'guest@vidly.com', 0, N'AKfnjD+4RjE4iX03aW21frySeFInTfRHF9/zFJWzeg/+Y2cXFVkOUB3p+CN4PMluIw==', N'5e54ace8-4fe8-4dbe-aab9-48597163b014', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                    INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'672cf567-01ea-47be-a348-74ba52f451a9', N'CanManageMovies')
                    INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2899d2c9-4936-4ab5-9fcb-9e1720612d31', N'672cf567-01ea-47be-a348-74ba52f451a9')
            ");
        }
        
        public override void Down()
        {
        }
    }
}
