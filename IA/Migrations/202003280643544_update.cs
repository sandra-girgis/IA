namespace IA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class update : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "Image", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "Image", c => c.Binary());
        }
    }
}
