using BulkyBook.Models;

namespace ClassLibrary1.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}