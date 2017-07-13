namespace CreditCardManagementSystem.Migrations
{
    using CreditCardManagementSystem.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<CreditCardManagementSystem.DAL.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(CreditCardManagementSystem.DAL.StoreContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "Dummycc1" },
                new Category { Name = "Dummycc2" },
                new Category { Name = "Dummycc3" },
                new Category { Name = "Dummycc4" },
                new Category { Name = "Dummycc5" },
                new Category { Name = "Dummycc6" }
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Product>
            {
                new Product { Name = "Bank1", Interest=4, CategoryID=categories.Single( c => c.Name == "Dummycc1").ID },
                new Product { Name = "Bank2", Interest=2, CategoryID=categories.Single( c => c.Name =="Dummycc1").ID },
                new Product { Name = "Bank3", Interest=3, CategoryID=categories.Single( c => c.Name == "Dummycc2").ID  },
                new Product { Name = "Bank4", Interest=5, CategoryID=categories.Single(c => c.Name == "Dummycc2").ID},
            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
    