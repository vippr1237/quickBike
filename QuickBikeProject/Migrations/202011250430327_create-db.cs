namespace QuickBikeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class createdb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        MaXe = c.Int(nullable: false, identity: true),
                        TenXe = c.String(),
                        LoaiXe = c.String(),
                        NgayNhap = c.DateTime(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaXe);
            
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
                .PrimaryKey(t => t.MaThue)
                .ForeignKey("dbo.Bikes", t => t.MaXe)
                .Index(t => t.MaXe);
            
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        MaDV = c.Int(nullable: false, identity: true),
                        MaThue = c.Int(),
                        NgayBD = c.DateTime(nullable: false),
                        NgayKT = c.DateTime(nullable: false),
                        MaHD = c.Int(),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaDV)
                .ForeignKey("dbo.GiaThues", t => t.MaThue)
                .ForeignKey("dbo.HoaDons", t => t.MaHD)
                .Index(t => t.MaThue)
                .Index(t => t.MaHD);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHD = c.Int(nullable: false, identity: true),
                        MaKH = c.Int(),
                        MaNV = c.String(nullable: false, maxLength: 10),
                        NgayLap = c.DateTime(nullable: false),
                        ThanhTien = c.Single(nullable: false),
                        TrangThai = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaHD)
                .ForeignKey("dbo.Guests", t => t.MaKH)
                .ForeignKey("dbo.Users", t => t.MaNV, cascadeDelete: true)
                .Index(t => t.MaKH)
                .Index(t => t.MaNV);
            
            CreateTable(
                "dbo.Guests",
                c => new
                    {
                        MaKH = c.Int(nullable: false, identity: true),
                        TenKH = c.String(nullable: false, maxLength: 30),
                        CMND = c.String(nullable: false),
                        NgaySinh = c.DateTime(nullable: false),
                        DiaChi = c.String(),
                        SDT = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MaKH);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        MaNV = c.String(nullable: false, maxLength: 10),
                        PassWord = c.String(nullable: false, maxLength: 10),
                        Admin = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.MaNV);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.HoaDons", "MaNV", "dbo.Users");
            DropForeignKey("dbo.HoaDons", "MaKH", "dbo.Guests");
            DropForeignKey("dbo.DichVus", "MaHD", "dbo.HoaDons");
            DropForeignKey("dbo.DichVus", "MaThue", "dbo.GiaThues");
            DropForeignKey("dbo.GiaThues", "MaXe", "dbo.Bikes");
            DropIndex("dbo.HoaDons", new[] { "MaNV" });
            DropIndex("dbo.HoaDons", new[] { "MaKH" });
            DropIndex("dbo.DichVus", new[] { "MaHD" });
            DropIndex("dbo.DichVus", new[] { "MaThue" });
            DropIndex("dbo.GiaThues", new[] { "MaXe" });
            DropTable("dbo.Users");
            DropTable("dbo.Guests");
            DropTable("dbo.HoaDons");
            DropTable("dbo.DichVus");
            DropTable("dbo.GiaThues");
            DropTable("dbo.Bikes");
        }
    }
}
