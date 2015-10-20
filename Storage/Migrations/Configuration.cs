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
              //new Product { Name = "Bj�llra", Price = 123.50M, Category = "Toys", Shelf = "H3", Count = 34, Description = "En leksak f�r b�bisar" },

              new Product { Name = "Bj�llra", Price = 123.50m, Category = "Toys", Shelf = "H3", Count = 34, Description = "En leksak f�r b�bisar" },
              new Product { Name = "Skjorta", Price = 270.00m, Category = "Kl�der", Shelf = "B2", Count = 56, Description = "En manlig skjorta f�r manliga m�n..." },
              new Product { Name = "Shampoo", Price = 350.50m, Category = "H�r", Shelf = "F45", Count = 22, Description = "Shampoo med h�g kvalite f�r kvinnor" }

             // p.Price, p.Category, p.Shelf, p.Count, p.Description,

            );

        }
    }
}
