using BulkyBook.Models;

namespace ClassLibrary1.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}