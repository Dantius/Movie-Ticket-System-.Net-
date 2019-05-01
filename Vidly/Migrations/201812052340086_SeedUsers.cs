namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"

INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'71ba1da0-a32d-4ec2-a24e-ae7ca864193f', N'admin@final.com', 0, N'AJ2O9uV1SDWbs/twUFQ9b1WpqzspKyZTm0XQazslB42f9GRCHyQ2sCA9BNmIruxBeg==', N'e48d8dc1-4618-4102-93ee-4e92672718df', NULL, 0, 0, NULL, 1, 0, N'admin@final.com')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'4b42a3e3-c776-48d0-a575-41607f117aef', N'PuedeInsertarPeliculas')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'71ba1da0-a32d-4ec2-a24e-ae7ca864193f', N'4b42a3e3-c776-48d0-a575-41607f117aef')

");
        }
        
        public override void Down()
        {
        }
    }
}
