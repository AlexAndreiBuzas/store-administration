using StoreAdministration.Data;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreAdministration.Controllers
{
    public class CategoryController
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<ProductCategory>> GetCategoriesAsync()
        {
            Trace.WriteLine("Getting all Categories");

            return await Task.Run(() =>
            {
                return _context.ProductCategories.ToList();
            });
        }

        public async Task AddCategoryAsync(ProductCategory category)
        {
            Trace.WriteLine($"Adding a new Category: {category}");

            await Task.Run(() =>
            {
                _context.ProductCategories.Add(category);
                _context.SaveChanges();
            });
        }

        public async Task DeleteCategoryAsync(int id)
        {
            Trace.WriteLine($"Deleting Category with ID: {id}");

            await Task.Run(() =>
            {
                var category = _context.ProductCategories.Find(id);
                if (category != null)
                {
                    _context.ProductCategories.Remove(category);
                    _context.SaveChanges();
                }
            });
        }
    }
}
