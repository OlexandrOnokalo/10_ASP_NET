using _01_ASP_MVC_Shop.Models;
using _01_ASP_MVC_Shop.Repositories;
using _01_ASP_MVC_Shop.Data.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using _01_ASP_MVC_Shop.Data;
using _01_ASP_MVC_Shop.Data.Initalizer;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
{
    string? connectionString = builder.Configuration.GetConnectionString("LocalDb");
    options.UseSqlServer(connectionString);
});

// Identity
builder.Services.AddIdentity<UserModel, IdentityRole>(options =>
{
    options.User.RequireUniqueEmail = true;

    options.Password.RequiredLength = 6;
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireLowercase = false;
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders()
    .AddDefaultUI();

// Add Session
builder.Services.AddHttpContextAccessor();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// DI реєстрація репозиторіїв
// builder.Services.AddSingleton(); // патерн Singleton - об'єкт буде один створено з початку програми
// builder.Services.AddTransient(); // об'єкт буде створюватись при кожному використанні
builder.Services.AddScoped<ProductRepository>(); // об'єкт буде створюватись при роботі зі сторінкою поки вона відкривається
builder.Services.AddScoped<CategoryRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseSession();

app.UseAuthentication();
app.UseAuthorization();

app.MapRazorPages();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();

Seeder.Seed(app);

app.Run();