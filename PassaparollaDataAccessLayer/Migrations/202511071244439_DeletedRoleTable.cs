namespace PassaparollaDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeletedRoleTable : DbMigration
    {
        public override void Up()
        {
            DropTable("dbo.Roles");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Roles",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        RoleType = c.String(maxLength: 10, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            AddColumn("dbo.Admins", "RoleId", c => c.Int(nullable: false));
            CreateIndex("dbo.Admins", "RoleId");
            AddForeignKey("dbo.Admins", "RoleId", "dbo.Roles", "ID", cascadeDelete: true);
        }
    }
}
