namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'00059fcd-363d-4a1c-aa13-367ae4dee630', N'admin@vidly.com', 0, N'ALCP9lDF2OSdFsF0n3JassG+rR0cZgV3Z5Hb+WJEEl++C2Db9aj8O9k6z4KuaUa+uA==', N'a6aee018-48e8-4588-9c02-a265c495fff0', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'07ac5a2d-0320-484e-a457-26612ecc18e6', N'guest@vidly.com', 0, N'AHjSxONvrTNIScPx9JwZMi456i9Cy+3DM29qOjelHvzc58e4hRexdsrz6E5cmP5InQ==', N'27d6b2c4-be36-4fcd-8f14-32c93b4d7da9', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')


INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7c3606c5-c450-4398-bae9-f6cdd455ce88', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'00059fcd-363d-4a1c-aa13-367ae4dee630', N'7c3606c5-c450-4398-bae9-f6cdd455ce88')

");
        }

        public override void Down()
        {
        }
    }
}
