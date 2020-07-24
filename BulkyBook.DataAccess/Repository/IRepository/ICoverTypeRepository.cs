using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
