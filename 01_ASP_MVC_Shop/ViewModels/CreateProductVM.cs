﻿using _01_ASP_MVC_Shop.Models;

namespace _01_ASP_MVC_Shop.ViewModels
{
    public class CreateProductVM
    {
        public string? Name { get; set; }
        public string? Brand { get; set; }

        public IFormFile? Image { get; set; }

        public decimal Price { get; set; }


    }
}