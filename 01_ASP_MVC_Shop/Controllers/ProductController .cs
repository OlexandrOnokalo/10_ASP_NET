using Microsoft.AspNetCore.Mvc;

namespace _01_ASP_MVC_Shop.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
