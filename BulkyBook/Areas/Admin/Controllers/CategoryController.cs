using BulkyBook.Models;
using ClassLibrary1.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;

namespace BulkyBook.DataAccess.Areas.Admin.Controllers
{
    [Area("Admin")]
    
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork; 
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Upsert(int? id)
        {
            Category category = new Category();
            if (id == null)
            {
                //this is for create
                return View(category);
            }

            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
            
        }

        #region API CALLS

        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _unitOfWork.Category.GetAll();

            return Json(new {data = allObj});
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Upsert(Category category)
        {
            if (ModelState.IsValid)
            {

                if(category.Id == 0)
                {
                    _unitOfWork.Category.Add(category);
                    
                }
                else
                {
                    _unitOfWork.Category.Update(category);
                }
                _unitOfWork.Save();
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }
        [HttpDelete]
        
        public IActionResult Delete(int id)
        {
            var objFromdb = _unitOfWork.Category.Get(id);
            if(objFromdb == null)
            {
                return Json(new { success = false, message = "Error while Deleting" });

            }
            _unitOfWork.Category.Remove(objFromdb);
            _unitOfWork.Save();

            return Json(new { success = true, message = "Delete Successful" });
        }

        #endregion
    }
}