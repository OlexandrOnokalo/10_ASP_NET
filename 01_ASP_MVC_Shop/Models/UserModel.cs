using Microsoft.AspNetCore.Identity;

namespace _01_ASP_MVC_Shop.Models
{
    public class UserModel : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Image { get; set; }
    }
}