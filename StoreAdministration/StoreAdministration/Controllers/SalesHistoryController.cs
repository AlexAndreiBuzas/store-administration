using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreAdministration.Data;

namespace StoreAdministration.Controllers
{
    public class SalesHistoryController
    {
        private readonly ApplicationDbContext _context;

        public SalesHistoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesHistory>> GetSalesHistoryAsync()
        {
            Trace.WriteLine("Getting sales history");   

            return await Task.Run(() =>
            {
                return _context.SalesHistories.ToList();
            });
        }

        public async Task AddSalesHistoryAsync(SalesHistory sale)
        {
            Trace.WriteLine("Adding sales history");

            await Task.Run(() =>
            {
                if (!sale.SaleDate.HasValue)
                {
                    sale.SaleDate = DateTime.Now;
                }
                _context.SalesHistories.Add(sale);
                _context.SaveChanges();
            });
        }
    }
}
