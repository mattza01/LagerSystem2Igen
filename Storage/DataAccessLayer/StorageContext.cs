using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Storage.DataAccessLayer
{
    public class StorageContext : DbContext
    {

        public StorageContext() : base("name=DefaultConnection")
        {

        }

        public DbSet<Models.Product> Products { get; set; }
        
    }
}