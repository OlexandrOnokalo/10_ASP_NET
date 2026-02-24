using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using _01_ASP_MVC_Shop.Models;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class CartItemVM
    {
        public int ProductId { get; set; }
        public int Count { get; set; } = 1;
    }
}