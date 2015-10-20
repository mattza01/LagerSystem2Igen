namespace Storage.Migrations
{
    using Storage.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Storage.DataAccessLayer.StorageContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Storage.DataAccessLayer.StorageContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
              p => p.Name, 
              //new Product { Name = "Bjällra", Price = 123.50M, Category = "Toys", Shelf = "H3", Count = 34, Description = "En leksak för bäbisar" },

              new Product { Name = "Bjällra", Price = 123.50m, Category = "Toys", Shelf = "H3", Count = 34, Description = "En leksak för bäbisar" },
              new Product { Name = "Skjorta", Price = 270.00m, Category = "Kläder", Shelf = "B2", Count = 56, Description = "En manlig skjorta för manliga män..." },
              new Product { Name = "Shampoo", Price = 350.50m, Category = "Hår", Shelf = "F45", Count = 22, Description = "Shampoo med hög kvalite för kvinnor" }

             // p.Price, p.Category, p.Shelf, p.Count, p.Description,

            );

        }
    }
}
