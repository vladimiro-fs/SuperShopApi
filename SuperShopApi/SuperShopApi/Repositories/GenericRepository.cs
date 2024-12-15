namespace SuperShopApi.Repositories
{
    using Microsoft.EntityFrameworkCore;
    using SuperShopApi.Context;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly AppDbContext _context;

        public GenericRepository(AppDbContext context)
        {
            _context = context;
        }

        public IQueryable<T> GetAll() 
        {
            return _context.Set<T>().AsNoTracking();
        }
    }
}
