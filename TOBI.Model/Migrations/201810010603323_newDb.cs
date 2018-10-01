namespace TOBI.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ApplicationUsers",
                c => new
                    {
                        Account_id = c.Guid(nullable: false),
                        History_id = c.String(maxLength: 256),
                        TotalAmount = c.Int(),
                        FullName = c.String(maxLength: 50),
                        Address = c.String(maxLength: 256),
                        BirthDay = c.DateTime(),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        Id = c.String(),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Account_id);
            
            CreateTable(
                "dbo.ApplicationUserClaims",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        Id = c.Int(nullable: false),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Account_id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Account_id)
                .Index(t => t.ApplicationUser_Account_id);
            
            CreateTable(
                "dbo.ApplicationUserLogins",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Account_id = c.Guid(),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Account_id)
                .Index(t => t.ApplicationUser_Account_id);
            
            CreateTable(
                "dbo.ApplicationUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        ApplicationUser_Account_id = c.Guid(),
                        IdentityRole_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.ApplicationUsers", t => t.ApplicationUser_Account_id)
                .ForeignKey("dbo.ApplicationRoles", t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Account_id)
                .Index(t => t.IdentityRole_Id);
            
            CreateTable(
                "dbo.CommentForPlayer",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        User_id = c.String(maxLength: 10, fixedLength: true),
                        UserComment_id = c.String(maxLength: 10, fixedLength: true),
                        Contents = c.String(maxLength: 10, fixedLength: true),
                        Comment_Date = c.String(maxLength: 10, fixedLength: true),
                        StarVote = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.DetailMatch",
                c => new
                    {
                        MatchDetail_id = c.Guid(nullable: false),
                        Match_id = c.String(maxLength: 256),
                        User_id = c.String(maxLength: 256),
                        GameAccount_id = c.String(maxLength: 256),
                        Team = c.String(maxLength: 256),
                    })
                .PrimaryKey(t => t.MatchDetail_id);
            
            CreateTable(
                "dbo.Errors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Message = c.String(),
                        StackTrace = c.String(),
                        CreatedDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.History",
                c => new
                    {
                        History_id = c.String(nullable: false, maxLength: 10, fixedLength: true),
                        User_id = c.String(maxLength: 10, fixedLength: true),
                        DateHistory = c.String(maxLength: 10, fixedLength: true),
                        Type = c.String(maxLength: 10, fixedLength: true),
                        Contents = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.History_id);
            
            CreateTable(
                "dbo.Match",
                c => new
                    {
                        Match_id = c.Guid(nullable: false),
                        NameMatch = c.String(maxLength: 256),
                        Contents = c.String(),
                        BettingPrice = c.Int(),
                        User_id = c.String(maxLength: 256),
                        UserConfirmed = c.String(maxLength: 256),
                        Startus = c.Int(),
                        UserWin = c.String(maxLength: 256),
                        Type = c.Int(),
                    })
                .PrimaryKey(t => t.Match_id);
            
            CreateTable(
                "dbo.ApplicationRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ApplicationUserRoles", "IdentityRole_Id", "dbo.ApplicationRoles");
            DropForeignKey("dbo.ApplicationUserRoles", "ApplicationUser_Account_id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserLogins", "ApplicationUser_Account_id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserClaims", "ApplicationUser_Account_id", "dbo.ApplicationUsers");
            DropIndex("dbo.ApplicationUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.ApplicationUserRoles", new[] { "ApplicationUser_Account_id" });
            DropIndex("dbo.ApplicationUserLogins", new[] { "ApplicationUser_Account_id" });
            DropIndex("dbo.ApplicationUserClaims", new[] { "ApplicationUser_Account_id" });
            DropTable("dbo.ApplicationRoles");
            DropTable("dbo.Match");
            DropTable("dbo.History");
            DropTable("dbo.Errors");
            DropTable("dbo.DetailMatch");
            DropTable("dbo.CommentForPlayer");
            DropTable("dbo.ApplicationUserRoles");
            DropTable("dbo.ApplicationUserLogins");
            DropTable("dbo.ApplicationUserClaims");
            DropTable("dbo.ApplicationUsers");
        }
    }
}
