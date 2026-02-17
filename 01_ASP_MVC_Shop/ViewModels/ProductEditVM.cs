using _01_ASP_MVC_Shop.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

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

        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> SelectCategories { get; set; } = new List<SelectListItem>();
    }
}
