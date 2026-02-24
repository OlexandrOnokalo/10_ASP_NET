using _01_ASP_MVC_Shop.Data;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using _01_ASP_MVC_Shop.Models;
using _01_ASP_MVC_Shop.Services;
using _01_ASP_MVC_Shop.ViewModels;

namespace _01_ASP_MVC_Shop.Controllers
{
    public class CartController : Controller
    {
        private readonly AppDbContext _context;

        public CartController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var cartItems = HttpContext.Session.Get<List<CartItemVM>>() ?? new List<CartItemVM>();
            
            var viewModel = new CartPageVM();
            foreach (var item in cartItems)
            {
                var product = await _context.Products.FindAsync(item.ProductId);
                viewModel.Items.Add(new CartItemWithProductVM 
                { 
                    CartItem = item, 
                    Product = product 
                });
            }

            return View(viewModel);
        }

        public async Task<IActionResult> Add(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product != null)
            {
                CartService.AddToCart(HttpContext.Session, id);
            }

            return RedirectToAction("Index", "Home");
        }

        public IActionResult Remove(int id)
        {
            CartService.RemoveFromCart(HttpContext.Session, id);
            return RedirectToAction("Index");
        }

        public IActionResult Increment(int id)
        {
            CartService.Increment(HttpContext.Session, id);
            return RedirectToAction("Index");
        }

        public IActionResult Decrement(int id)
        {
            CartService.Decrement(HttpContext.Session, id);
            var items = HttpContext.Session.Get<List<CartItemVM>>() ?? new List<CartItemVM>();
            var item = items.FirstOrDefault(i => i.ProductId == id);
            
            if (item != null && item.Count < 1)
            {
                CartService.RemoveFromCart(HttpContext.Session, id);
            }

            return RedirectToAction("Index");
        }
    }
}