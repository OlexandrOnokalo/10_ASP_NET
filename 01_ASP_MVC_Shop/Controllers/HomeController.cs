using Microsoft.EntityFrameworkCore;
using _01_ASP_MVC_Shop.Data;
using _01_ASP_MVC_Shop.Repositories;
using _01_ASP_MVC_Shop.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _01_ASP_MVC_Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;

        public HomeController(ILogger<HomeController> logger, AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<ProductModel> products = _context.Products.AsEnumerable();

            return View(products);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
