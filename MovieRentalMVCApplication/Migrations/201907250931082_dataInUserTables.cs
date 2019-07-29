namespace MovieRentalMVCApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dataInUserTables : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'3aab70a7-6445-4db8-a002-2c4587077c89', N'pr2810@user.com', 0, N'AKtH9lwPa0LIKCw2G7DNxa7xvUeEgvfVIs6M6IDjx8lvlTeW3nIZCGwkHDzdBHeoFQ==', N'66f3bb28-9f9f-477b-b046-90cf74bb2bc9', NULL, 0, 0, NULL, 1, 0, N'pr2810@user.com')
                  INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'62e89f58-c573-4dbd-8e47-f77cd40a70f2', N'dr0104@user.com', 0, N'AD+b/7zy3qIUrBnYYFoMGC39TcTV6C4cAeZIRDgiuD3YhoeJzt1iuTR0x0y6fdcVLQ==', N'e3f81a50-2c20-498f-840e-319cb469b051', NULL, 0, 0, NULL, 1, 0, N'dr0104@user.com')
                  INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'69937452-12d4-4355-a5d8-1cbf7ee2f799', N'Admin')          
                  INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'62e89f58-c573-4dbd-8e47-f77cd40a70f2', N'69937452-12d4-4355-a5d8-1cbf7ee2f799')
                 

              ");
        }
        
        public override void Down()
        {
        }
    }
}
