namespace SuperShopApi.Repositories
{
    using SuperShopApi.Entities;

    public interface IProductRepository : IGenericRepository<Product>
    {
        IQueryable GetAllWithUsers();
    }
}
