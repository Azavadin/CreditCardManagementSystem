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
            ContextKey = "CreditCardManagementSystem.DAL.StoreContext";
        }

        protected override void Seed(CreditCardManagementSystem.DAL.StoreContext context)
        {
            var categories = new List<Category>
            {
                new Category { Name = "dummycc1", InterchangeRate = "1"},
                new Category { Name = "dummycc2", InterchangeRate = "2" },
                new Category { Name = "dummycc3", InterchangeRate = "3" }
            };
            categories.ForEach(c => context.Categories.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
            var products = new List<Product>
            {
                new Product { Name = "dummyBank1", Interest=1, CategoryID=categories.Single( c => c.Name == "dummycc1").ID },
                new Product { Name = "dummyBank1", Interest=2, CategoryID=categories.Single( c => c.Name == "dummycc2").ID },
                new Product { Name = "dummyBank1", Interest=3, CategoryID=categories.Single( c => c.Name == "dummycc3").ID },
                new Product { Name = "dummyBank2", Interest=4, CategoryID=categories.Single( c => c.Name == "dummycc1").ID },
                new Product { Name = "dummyBank2", Interest=5, CategoryID=categories.Single( c => c.Name == "dummycc2").ID },
                new Product { Name = "dummyBank2", Interest=1, CategoryID=categories.Single( c => c.Name == "dummycc3").ID },
                new Product { Name = "dummyBank3", Interest=2, CategoryID=categories.Single( c => c.Name == "dummycc1").ID },
                new Product { Name = "dummyBank3", Interest=3, CategoryID=categories.Single( c => c.Name == "dummycc2").ID },
                new Product { Name = "dummyBank3", Interest=4, CategoryID=categories.Single( c => c.Name == "dummycc3").ID }

            };
            products.ForEach(c => context.Products.AddOrUpdate(p => p.Name, c));
            context.SaveChanges();
        }
    }
}
  