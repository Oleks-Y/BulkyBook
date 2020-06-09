using BulkyBook.DataAccess.Data;
using ClassLibrary1.Repository.IRepository;

namespace ClassLibrary1.Repository
{
    
    public class UnitOfWork : IUnitOfWork
    {
        
        private readonly ApplicationDbContext _db;
        public ICategoryRepository Category { get; private set; }
        public UnitOfWork(ApplicationDbContext db)
        {
            _db = db;
            Category = new CategoryRepository(_db);
            SP_Call = new SP_Call(_db);
        }
        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        
        public ISP_Call SP_Call { get; }
    }
}