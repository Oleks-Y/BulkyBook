using System;

namespace ClassLibrary1.Repository.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ICategoryRepository Catefory { get; }
        
        ISP_Call SP_Call { get; }
        
    }
}