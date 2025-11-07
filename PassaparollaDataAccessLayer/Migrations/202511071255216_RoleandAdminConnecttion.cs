namespace PassaparollaDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RoleandAdminConnecttion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Admins", "RoleID", c => c.Int(nullable: false, defaultValue: 1));
            CreateIndex("dbo.Admins", "RoleID");
            AddForeignKey("dbo.Admins", "RoleID", "dbo.Roles", "ID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Admins", "RoleID", "dbo.Roles");
            DropIndex("dbo.Admins", new[] { "RoleID" });
            DropColumn("dbo.Admins", "RoleID");
        }
    }
}
