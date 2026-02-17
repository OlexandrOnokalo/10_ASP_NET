using _01_ASP_MVC_Shop.Data;
using _01_ASP_MVC_Shop.Models;
using Microsoft.EntityFrameworkCore;

namespace _01_ASP_MVC_Shop.Data.Repositories
{
    public class CategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }


        public List<CategoryModel> GetAll()
        {
            return _context.Categories.ToList();
        }


        public CategoryModel? GetById(int id)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == id);
        }


        public void Create(CategoryModel category)
        {
            _context.Categories.Add(category);
            _context.SaveChanges();
        }


        public void Update(CategoryModel category)
        {
            _context.Categories.Update(category);
            _context.SaveChanges();
        }


        public void Delete(int id)
        {
            var category = _context.Categories.FirstOrDefault(c => c.Id == id);

            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();
            }
        }
    }
}
