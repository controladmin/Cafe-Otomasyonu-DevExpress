namespace CafeOtomasyonuEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateDatase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Menu",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuAdı = c.String(maxLength: 50, unicode: false),
                        Aciklama = c.String(maxLength: 250, unicode: false),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Urun",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        MenuID = c.Int(nullable: false),
                        UrunKodu = c.String(maxLength: 50, unicode: false),
                        UrunAdi = c.String(),
                        BirimFiyat1 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        BirimFiyat2 = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Aciklama = c.String(),
                        Tarih = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Menu", t => t.MenuID, cascadeDelete: true)
                .Index(t => t.MenuID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Urun", "MenuID", "dbo.Menu");
            DropIndex("dbo.Urun", new[] { "MenuID" });
            DropTable("dbo.Urun");
            DropTable("dbo.Menu");
        }
    }
}
