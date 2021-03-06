﻿using System.Linq;
using BulkyBook.DataAccess.Data;
using BulkyBook.Models;
using ClassLibrary1.Repository.IRepository;

namespace ClassLibrary1.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }


        public void Update(Category category)
        {
            var objFromDb = _db.Categories.FirstOrDefault(s => s.Id ==category.Id);

            if (objFromDb != null)
            {
                objFromDb.Name = category.Name;

                
            }
        }
    }
}