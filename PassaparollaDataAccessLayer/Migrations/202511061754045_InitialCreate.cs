namespace PassaparollaDataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AD = c.String(maxLength: 15, unicode: false),
                        SOYAD = c.String(maxLength: 15, unicode: false),
                        KullanıcıAdı = c.String(maxLength: 15, unicode: false),
                        Sıfre = c.String(maxLength: 5, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sorulars",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Harf = c.String(maxLength: 1, fixedLength: true, unicode: false),
                        Soru = c.String(maxLength: 500, unicode: false),
                        Cevap = c.String(),
                        Durum = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Sorulars");
            DropTable("dbo.Admins");
        }
    }
}
