using System.ComponentModel.DataAnnotations;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class CreateCategoryVM
    {
        [Required(ErrorMessage = "Поле Назва є обов'язковим")]
        [StringLength(100, ErrorMessage = "Назва не може перевищувати 100 символів")]
        public string Name { get; set; } = string.Empty;
    }
}
