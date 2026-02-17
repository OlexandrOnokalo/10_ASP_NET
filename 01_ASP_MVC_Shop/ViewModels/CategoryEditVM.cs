using System.ComponentModel.DataAnnotations;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class CategoryEditVM
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Обов'язкове поле")]
        [MaxLength(200, ErrorMessage = "Максимальна довжина 200 символів")]
        public string Name { get; set; } = string.Empty;
    }
}
