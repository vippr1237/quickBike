namespace QuickBikeProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class trngthai : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Bikes", "TrangThai", c => c.String());
            AlterColumn("dbo.DichVus", "TrangThai", c => c.String());
            AlterColumn("dbo.HoaDons", "TrangThai", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.HoaDons", "TrangThai", c => c.Boolean(nullable: false));
            AlterColumn("dbo.DichVus", "TrangThai", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Bikes", "TrangThai", c => c.Boolean(nullable: false));
        }
    }
}
