namespace LIDER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateTableProduct : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        CategoryID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Link = c.String(),
                        Meta = c.String(),
                        Hide = c.Boolean(nullable: false),
                        Ranking = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CategoryID);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        ProductID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Price = c.Single(nullable: false),
                        Img = c.String(),
                        Description = c.String(),
                        Meta = c.String(),
                        Size = c.String(),
                        Color = c.String(),
                        Hide = c.Boolean(nullable: false),
                        Ranking = c.Int(nullable: false),
                        CategoryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductID)
                .ForeignKey("dbo.Categories", t => t.CategoryID, cascadeDelete: true)
                .Index(t => t.CategoryID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "CategoryID", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "CategoryID" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
