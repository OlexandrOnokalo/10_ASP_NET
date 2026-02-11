namespace _01_ASP_MVC_Shop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public required string Name { get; set; }

        public required string Brand { get; set; }

        public decimal Price { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel? Category { get; set; }
    }
}
