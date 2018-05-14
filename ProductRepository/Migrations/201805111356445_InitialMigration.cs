namespace ProductRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Decription = c.String(nullable: false),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Cartegory_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cartegories", t => t.Cartegory_Id, cascadeDelete: true)
                .Index(t => t.Cartegory_Id);
            
            CreateTable(
                "dbo.Cartegories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CategoryName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "Cartegory_Id", "dbo.Cartegories");
            DropIndex("dbo.Products", new[] { "Cartegory_Id" });
            DropTable("dbo.Cartegories");
            DropTable("dbo.Products");
        }
    }
}
