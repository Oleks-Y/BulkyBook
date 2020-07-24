using BulkyBook.DataAccess.Data;
using BulkyBook.Models;
using ClassLibrary1.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace ClassLibrary1.Repository
{
    class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;   
        }
        

        public void Update(CoverType coverType)
        {
            var objFromDb = _db.CoverTypes.FirstOrDefault(s => s.Id == coverType.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = coverType.Name;


            }
        }
    }
}
