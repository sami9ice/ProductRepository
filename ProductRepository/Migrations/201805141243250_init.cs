namespace ProductRepository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "Description", c => c.String(nullable: false));
            AddColumn("dbo.Cartegories", "CartegoryName", c => c.String());
            DropColumn("dbo.Products", "Decription");
            DropColumn("dbo.Cartegories", "CategoryName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Cartegories", "CategoryName", c => c.String());
            AddColumn("dbo.Products", "Decription", c => c.String(nullable: false));
            DropColumn("dbo.Cartegories", "CartegoryName");
            DropColumn("dbo.Products", "Description");
        }
    }
}
