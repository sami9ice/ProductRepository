namespace ProductRepository.Migrations
{
    using ProductRepository.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ProductRepository.DatabaseContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ProductRepository.DatabaseContext context)
        {
            context.Product.Add(new Product
            {
                Id=1,
                Name=" Biro",
                Description="Red ",
                Price= 100,
                Cartegory=new Cartegory { CartegoryName=" Stationary"}
            });
            context.Product.Add(new Product
            {
                Id = 2,
                Name = " Cocacola",
                Description = "Lowsugar",
                Price = 1500,
                Cartegory = new Cartegory { CartegoryName = " Beverage" }
            });
            context.Product.Add(new Product
            {
                Id = 3,
                Name = "Rice ",
                Description = " Onebag",
                Price = 13800,
                Cartegory = new Cartegory { CartegoryName = " FoodStuff" }
            });
            context.Product.Add(new Product
            {
                Id = 4,
                Name = "T-Shirt",
                Description = "Red Colour",
                Price = 3000,
                Cartegory = new Cartegory { CartegoryName = " Clothings" }
            });

        }
    }
}
