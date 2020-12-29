namespace QuickBikeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fix : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.GiaThues", "MaXe", "dbo.Bikes");
            DropForeignKey("dbo.DichVus", "MaThue", "dbo.GiaThues");
            DropIndex("dbo.GiaThues", new[] { "MaXe" });
            DropIndex("dbo.DichVus", new[] { "MaThue" });
            AddColumn("dbo.Bikes", "DonGia", c => c.Single(nullable: false));
            AddColumn("dbo.DichVus", "MaXe", c => c.Int());
            AddColumn("dbo.DichVus", "ThoiGian", c => c.Int(nullable: false));
            AddColumn("dbo.DichVus", "ThanhTien", c => c.Single(nullable: false));
            CreateIndex("dbo.DichVus", "MaXe");
            AddForeignKey("dbo.DichVus", "MaXe", "dbo.Bikes", "MaXe");
            DropColumn("dbo.DichVus", "MaThue");
            DropTable("dbo.GiaThues");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.GiaThues",
                c => new
                    {
                        MaThue = c.Int(nullable: false, identity: true),
                        Gia = c.Int(nullable: false),
                        ThoiGian = c.DateTime(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                        MaXe = c.Int(),
                    })
                .PrimaryKey(t => t.MaThue);
            
            AddColumn("dbo.DichVus", "MaThue", c => c.Int());
            DropForeignKey("dbo.DichVus", "MaXe", "dbo.Bikes");
            DropIndex("dbo.DichVus", new[] { "MaXe" });
            DropColumn("dbo.DichVus", "ThanhTien");
            DropColumn("dbo.DichVus", "ThoiGian");
            DropColumn("dbo.DichVus", "MaXe");
            DropColumn("dbo.Bikes", "DonGia");
            CreateIndex("dbo.DichVus", "MaThue");
            CreateIndex("dbo.GiaThues", "MaXe");
            AddForeignKey("dbo.DichVus", "MaThue", "dbo.GiaThues", "MaThue");
            AddForeignKey("dbo.GiaThues", "MaXe", "dbo.Bikes", "MaXe");
        }
    }
}
