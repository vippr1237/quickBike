namespace QuickBikeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thembang1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.HoSoes",
                c => new
                    {
                        MaHoSo = c.Int(nullable: false, identity: true),
                        HoTen = c.String(),
                        NgaySinh = c.DateTime(nullable: false),
                        SDT = c.String(),
                        DiaChi = c.String(),
                    })
                .PrimaryKey(t => t.MaHoSo);
            
            AddColumn("dbo.Users", "MaHoSo", c => c.Int());
            CreateIndex("dbo.Users", "MaHoSo");
            AddForeignKey("dbo.Users", "MaHoSo", "dbo.HoSoes", "MaHoSo");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Users", "MaHoSo", "dbo.HoSoes");
            DropIndex("dbo.Users", new[] { "MaHoSo" });
            DropColumn("dbo.Users", "MaHoSo");
            DropTable("dbo.HoSoes");
        }
    }
}
