using StoreAdministration.Models;
using System.Data.Entity;

namespace StoreAdministration.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext() : base("name=ApplicationDbContext") { }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductCategory> ProductCategories { get; set; }

        public DbSet<SalesHistory> SalesHistories { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
