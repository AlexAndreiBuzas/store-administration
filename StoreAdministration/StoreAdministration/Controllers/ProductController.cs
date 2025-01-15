using StoreAdministration.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAdministration.Controllers
{
    public class ProductController
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Product>> GetProductsAsync()
        {
            Trace.WriteLine("Getting all Products");

            try
            {
                return await Task.Run(() =>
                {
                    return _context.Products
                        .Include(p => p.ProductCategory).ToList();
                });
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving products.", ex);
            }
        }

        public async Task AddProductAsync(Product product)
        {
            Trace.WriteLine("Adding a new Product");

            await Task.Run(() =>
            {
                if (product.EntryDate.HasValue && product.ExpiryDate.HasValue)
                {
                    _context.Products.Add(product);
                    _context.SaveChanges();
                }
                else
                {
                    throw new ApplicationException("EntryDate and ExpiryDate must be valid timestamps.");
                }
            });
        }

        public async Task UpdateProductAsync(Product product)
        {
            Trace.WriteLine($"Updating the Product: {product.Name}");

            await Task.Run(() =>
            {
                var existingProduct = _context.Products.Find(product.Id);
                if (existingProduct != null)
                {
                    _context.Entry(existingProduct).CurrentValues.SetValues(product);
                    _context.SaveChanges();
                }
            });
        }

        public async Task DeleteProductAsync(int id)
        {
            Trace.WriteLine($"Deleting the Product: {id}");

            await Task.Run(() =>
            {
                var product = _context.Products.Find(id);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    _context.SaveChanges();
                }
            });
        }

        public async Task<List<Product>> SearchProductsAsync(string searchText)
        {
            Trace.WriteLine("Searching for Products");

            return await Task.Run(() =>
            {
                return _context.Products
                    .Include(p => p.ProductCategory)
                    .Where(p => p.Name.Contains(searchText))
                    .ToList();
            });
        }
    }
}
