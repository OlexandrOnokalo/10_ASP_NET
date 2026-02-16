using _01_ASP_MVC_Shop.Models;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class ProductEditVM
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Brand { get; set; }
        public decimal Price { get; set; }
        public IFormFile? Image { get; set; }

        public string? CurrentImage { get; set; }
    }
}
