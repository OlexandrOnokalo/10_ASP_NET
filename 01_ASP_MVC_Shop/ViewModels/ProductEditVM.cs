using _01_ASP_MVC_Shop.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class ProductEditVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [MaxLength(200, ErrorMessage = "Максимальна довжина 200 символів")]
        public string? Name { get; set; }


        [Required(ErrorMessage = "Обов'язкове поле")]
        [MaxLength(200, ErrorMessage = "Максимальна довжина 200 символів")]
        public string? Brand { get; set; }


        [Required(ErrorMessage = "Потрібно вказати ціну")]
        [Range(0, 99999999, ErrorMessage = "К-сть повинна бути в діапазоні 0 - 99999999")]
        public decimal Price { get; set; }
        public IFormFile? Image { get; set; }

        public string? CurrentImage { get; set; }

        [Range(0, 1000000, ErrorMessage = "Кількість повинна бути невід'ємна")]
        public int Quantity { get; set; }

        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }
        public IEnumerable<SelectListItem> SelectCategories { get; set; } = new List<SelectListItem>();
    }
}
