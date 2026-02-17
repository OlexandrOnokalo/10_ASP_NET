using _01_ASP_MVC_Shop.Data.Repositories;
using _01_ASP_MVC_Shop.Models;
using _01_ASP_MVC_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _01_ASP_MVC_Shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoryController(CategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IActionResult Index()
        {
            var categories = _categoryRepository.GetAll();
            return View(categories);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CreateCategoryVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var category = new CategoryModel
            {
                Name = model.Name
            };

            _categoryRepository.Create(category);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            var category = _categoryRepository.GetById(id);

            if (category == null)
                return NotFound();

            var model = new CategoryEditVM
            {
                Id = category.Id,
                Name = category.Name
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(CategoryEditVM model)
        {
            if (!ModelState.IsValid)
                return View(model);

            var category = _categoryRepository.GetById(model.Id);

            if (category == null)
                return NotFound();

            category.Name = model.Name;

            _categoryRepository.Update(category);

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            _categoryRepository.Delete(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
