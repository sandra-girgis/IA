namespace IA.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        number_of_products = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        price = c.Single(nullable: false),
                        Image = c.Binary(),
                        description = c.String(),
                        category_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_id, cascadeDelete: true)
                .Index(t => t.category_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_id" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
