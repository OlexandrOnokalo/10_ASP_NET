using _01_ASP_MVC_Shop.Data;
using _01_ASP_MVC_Shop.Models;
using _01_ASP_MVC_Shop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _01_ASP_MVC_Shop.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var products = _context.Products.AsEnumerable();
            return View(products);
        }


        public async Task<IActionResult> Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] CreateProductVM vm)
        {
            var category = _context.Categories.FirstOrDefault();
            if (category == null)
            {
                return View();
            }

            ProductModel model = new ProductModel
            {
                Name = vm.Name ?? string.Empty,
                Brand = vm.Brand,
                Price = vm.Price,
                Category = category
            };


            if (vm.Image != null)
            {
                string root = Directory.GetCurrentDirectory();
                string imagesPath = Path.Combine(root, "wwwroot", "images");

                string ext = Path.GetExtension(vm.Image.FileName);
                string name = Guid.NewGuid().ToString();
                string fileName = name + ext;
                string filePath = Path.Combine(imagesPath, fileName);

                using var imageStream = vm.Image.OpenReadStream();
                using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                imageStream.CopyTo(fileStream);

                model.Image = fileName;
            }

            await _context.Products.AddAsync(model);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);

            if (product != null)
            {
                if (product.Image != null)
                {
                    string root = Directory.GetCurrentDirectory();
                    string imagesPath = Path.Combine(root, "wwwroot", "images");
                    string filePath = Path.Combine(imagesPath, product.Image);

                    if (System.IO.File.Exists(filePath))
                    {
                        System.IO.File.Delete(filePath);
                    }
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction("Index");
        }


        public IActionResult Update(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null)
            {
                return NotFound();
            }

            var vm = new ProductEditVM
            {
                Id = product.Id,
                Name = product.Name,
                Brand = product.Brand,
                Price = product.Price,
                CurrentImage = product.Image
            };

            return View(vm);
        }


        [HttpPost]
        public async Task<IActionResult> Update([FromForm] ProductEditVM vm)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == vm.Id);

            if (product == null)
            {
                return NotFound();
            }

            product.Name = vm.Name ?? string.Empty;
            product.Brand = vm.Brand;
            product.Price = vm.Price;

            if (vm.Image != null)
            {
                string root = Directory.GetCurrentDirectory();
                string imagesPath = Path.Combine(root, "wwwroot", "images");


                if (!string.IsNullOrEmpty(vm.CurrentImage))
                {
                    string oldPath = Path.Combine(imagesPath, vm.CurrentImage);

                    if (System.IO.File.Exists(oldPath))
                    {
                        System.IO.File.Delete(oldPath);
                    }
                }

    
                string ext = Path.GetExtension(vm.Image.FileName);
                string name = Guid.NewGuid().ToString();
                string fileName = name + ext;
                string filePath = Path.Combine(imagesPath, fileName);

                using var imageStream = vm.Image.OpenReadStream();
                using var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
                imageStream.CopyTo(fileStream);

                product.Image = fileName;
            }

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
    }
}
