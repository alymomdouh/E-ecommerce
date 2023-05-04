using Core.Entities;
using Core.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Infrastrucure.Data
{
    public class ProductRepository : IProductRepository
    {
        private readonly StoreContext _context;
        public ProductRepository(StoreContext context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<Product>> GetProductsAsync()
        {
            return await _context.Products
               .ToListAsync();
        }

        public async Task<Product> GetProductsByIdAsync(int id)
        {
            return await _context.Products
                 .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}
