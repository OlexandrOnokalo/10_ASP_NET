using _01_ASP_MVC_Shop.Models;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class CartPageVM
    {
        public List<CartItemWithProductVM> Items { get; set; } = new();
    }

    public class CartItemWithProductVM
    {
        public CartItemVM CartItem { get; set; } = new();
        public ProductModel? Product { get; set; }
    }
}
