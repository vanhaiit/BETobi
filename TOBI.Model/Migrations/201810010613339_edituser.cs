namespace TOBI.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class edituser : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.ApplicationUserClaims", "ApplicationUser_Account_id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserLogins", "ApplicationUser_Account_id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserRoles", "ApplicationUser_Account_id", "dbo.ApplicationUsers");
            DropIndex("dbo.ApplicationUserClaims", new[] { "ApplicationUser_Account_id" });
            DropIndex("dbo.ApplicationUserLogins", new[] { "ApplicationUser_Account_id" });
            DropIndex("dbo.ApplicationUserRoles", new[] { "ApplicationUser_Account_id" });
            RenameColumn(table: "dbo.ApplicationUserClaims", name: "ApplicationUser_Account_id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.ApplicationUserLogins", name: "ApplicationUser_Account_id", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.ApplicationUserRoles", name: "ApplicationUser_Account_id", newName: "ApplicationUser_Id");
            DropPrimaryKey("dbo.ApplicationUsers");
            AlterColumn("dbo.ApplicationUsers", "Id", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.ApplicationUserClaims", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.ApplicationUserLogins", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AlterColumn("dbo.ApplicationUserRoles", "ApplicationUser_Id", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.ApplicationUsers", "Id");
            CreateIndex("dbo.ApplicationUserClaims", "ApplicationUser_Id");
            CreateIndex("dbo.ApplicationUserLogins", "ApplicationUser_Id");
            CreateIndex("dbo.ApplicationUserRoles", "ApplicationUser_Id");
            AddForeignKey("dbo.ApplicationUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers", "Id");
            AddForeignKey("dbo.ApplicationUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers", "Id");
            AddForeignKey("dbo.ApplicationUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers", "Id");
            DropColumn("dbo.ApplicationUsers", "Account_id");
        }
        
        public override void Down()
        {
            AddColumn("dbo.ApplicationUsers", "Account_id", c => c.Guid(nullable: false));
            DropForeignKey("dbo.ApplicationUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.ApplicationUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropIndex("dbo.ApplicationUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUserLogins", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.ApplicationUserClaims", new[] { "ApplicationUser_Id" });
            DropPrimaryKey("dbo.ApplicationUsers");
            AlterColumn("dbo.ApplicationUserRoles", "ApplicationUser_Id", c => c.Guid());
            AlterColumn("dbo.ApplicationUserLogins", "ApplicationUser_Id", c => c.Guid());
            AlterColumn("dbo.ApplicationUserClaims", "ApplicationUser_Id", c => c.Guid());
            AlterColumn("dbo.ApplicationUsers", "Id", c => c.String());
            AddPrimaryKey("dbo.ApplicationUsers", "Account_id");
            RenameColumn(table: "dbo.ApplicationUserRoles", name: "ApplicationUser_Id", newName: "ApplicationUser_Account_id");
            RenameColumn(table: "dbo.ApplicationUserLogins", name: "ApplicationUser_Id", newName: "ApplicationUser_Account_id");
            RenameColumn(table: "dbo.ApplicationUserClaims", name: "ApplicationUser_Id", newName: "ApplicationUser_Account_id");
            CreateIndex("dbo.ApplicationUserRoles", "ApplicationUser_Account_id");
            CreateIndex("dbo.ApplicationUserLogins", "ApplicationUser_Account_id");
            CreateIndex("dbo.ApplicationUserClaims", "ApplicationUser_Account_id");
            AddForeignKey("dbo.ApplicationUserRoles", "ApplicationUser_Account_id", "dbo.ApplicationUsers", "Account_id");
            AddForeignKey("dbo.ApplicationUserLogins", "ApplicationUser_Account_id", "dbo.ApplicationUsers", "Account_id");
            AddForeignKey("dbo.ApplicationUserClaims", "ApplicationUser_Account_id", "dbo.ApplicationUsers", "Account_id");
        }
    }
}
