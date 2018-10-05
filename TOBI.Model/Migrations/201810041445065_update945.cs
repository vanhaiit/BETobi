namespace TOBI.Model.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update945 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ApplicationRoles", "type", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ApplicationRoles", "type");
        }
    }
}
