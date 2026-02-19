using _01_ASP_MVC_Shop.Models;
using System.Collections.Generic;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<ProductModel> Products { get; set; } = new List<ProductModel>();
        public IEnumerable<CategoryModel> Categories { get; set; } = new List<CategoryModel>();
        public PaginationVM Pagination { get; set; } = new();
        public int? CategoryId { get; set; } = null;
    }
}
