namespace QuickBikeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thembang : DbMigration
    {
        public override void Up()
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
                .PrimaryKey(t => t.MaCa)
                .ForeignKey("dbo.Users", t => t.MaNV)
                .Index(t => t.MaNV);
            
            AddColumn("dbo.HoaDons", "MaCa", c => c.Int(nullable: false));
            CreateIndex("dbo.HoaDons", "MaCa");
            AddForeignKey("dbo.HoaDons", "MaCa", "dbo.Shifts", "MaCa", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Shifts", "MaNV", "dbo.Users");
            DropForeignKey("dbo.HoaDons", "MaCa", "dbo.Shifts");
            DropIndex("dbo.Shifts", new[] { "MaNV" });
            DropIndex("dbo.HoaDons", new[] { "MaCa" });
            DropColumn("dbo.HoaDons", "MaCa");
            DropTable("dbo.Shifts");
        }
    }
}
