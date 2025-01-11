using StoreAdministration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace StoreAdministration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=AplicationDbContext") { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<SalesHistory> SalesHistories { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
