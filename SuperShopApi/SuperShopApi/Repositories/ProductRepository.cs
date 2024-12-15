using Microsoft.EntityFrameworkCore;
using SuperShopApi.Context;
using SuperShopApi.Entities;

namespace SuperShopApi.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable GetAllWithUsers() 
        {
            return _context.Products.Include(p => p.User);
        }
    }
}
