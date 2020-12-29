namespace QuickBikeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.HoaDons", "MaCa", "dbo.Shifts");
            DropForeignKey("dbo.Shifts", "MaNV", "dbo.Users");
            DropIndex("dbo.HoaDons", new[] { "MaCa" });
            DropIndex("dbo.Shifts", new[] { "MaNV" });
            DropColumn("dbo.HoaDons", "MaCa");
            DropTable("dbo.Shifts");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.Shifts",
                c => new
                    {
                        MaCa = c.Int(nullable: false, identity: true),
                        Ngay = c.DateTime(nullable: false),
                        Ca = c.Int(nullable: false),
                        MaNV = c.String(maxLength: 10),
                    })
                .PrimaryKey(t => t.MaCa);
            
            AddColumn("dbo.HoaDons", "MaCa", c => c.Int(nullable: false));
            CreateIndex("dbo.Shifts", "MaNV");
            CreateIndex("dbo.HoaDons", "MaCa");
            AddForeignKey("dbo.Shifts", "MaNV", "dbo.Users", "MaNV");
            AddForeignKey("dbo.HoaDons", "MaCa", "dbo.Shifts", "MaCa", cascadeDelete: true);
        }
    }
}
