namespace _01_ASP_MVC_Shop.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductModel> Products { get; set; }
    }
}
