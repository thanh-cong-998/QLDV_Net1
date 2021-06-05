namespace QLDV_Net1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class create_database : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.ChiDoans", "TenChiDoan", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.ChiDoans", "TenChiDoan", c => c.String(nullable: false));
        }
    }
}
