using Microsoft.EntityFrameworkCore;
using _01_ASP_MVC_Shop.Data;
using _01_ASP_MVC_Shop.Models;



namespace _01_ASP_MVC_Shop.Repositories
{
    public class ProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IQueryable<ProductModel>> GetProductsAsync()
        {
            return _context.Products.AsNoTracking();
        }
    }
}
