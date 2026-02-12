using _01_ASP_MVC_Shop.Data;
using Microsoft.AspNetCore.Mvc;


namespace PD411_Shop.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var Categories = _context.Categories.AsEnumerable();

            return View(Categories);
        }
    }
}