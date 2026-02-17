namespace _01_ASP_MVC_Shop.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Brand { get; set; }
        public string? Image { get; set; }

        public decimal Price { get; set; }


        public int Quantity { get; set; }


        public DateTime CreatedAt { get; set; }

        public int CategoryId { get; set; }

        public CategoryModel? Category { get; set; }
    }
}
