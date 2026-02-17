using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _01_ASP_MVC_Shop.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ноутбуки" },
                    { 2, "Настільні ПК" },
                    { 3, "Монітори" },
                    { 4, "Відеокарти" },
                    { 5, "Процесори" },
                    { 6, "Материнські плати" },
                    { 7, "Оперативна пам’ять" },
                    { 8, "SSD накопичувачі" },
                    { 9, "Периферія" },
                    { 10, "Мережеве обладнання" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Brand", "CategoryId", "CreatedAt", "Image", "Name", "Price", "Quantity" },
                values: new object[,]
                {
                    { 1, "ASUS", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "ROG Strix G16", 58999m, 6 },
                    { 2, "ASUS", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "TUF Gaming A15", 36999m, 6 },
                    { 3, "ASUS", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "ZenBook 14", 38999m, 17 },
                    { 4, "Apple", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "MacBook Air M2", 45999m, 13 },
                    { 5, "Apple", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "MacBook Pro 14 M3", 89999m, 17 },
                    { 6, "Lenovo", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "ThinkPad X13", 39999m, 18 },
                    { 7, "Lenovo", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Legion 5 Pro", 54999m, 7 },
                    { 8, "Lenovo", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "IdeaPad 5", 21999m, 16 },
                    { 9, "Acer", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Predator Helios 16", 67999m, 9 },
                    { 10, "Acer", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Swift X", 32999m, 13 },
                    { 11, "HP", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "OMEN 16", 55999m, 8 },
                    { 12, "HP", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Pavilion 15", 21999m, 11 },
                    { 13, "Dell", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "XPS 13", 49999m, 8 },
                    { 14, "Dell", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Inspiron 15", 23999m, 5 },
                    { 15, "Microsoft", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Surface Laptop 5", 57999m, 7 },
                    { 16, "Samsung", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Samsung Galaxy Book3", 34999m, 16 },
                    { 17, "Razer", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Razer Blade 15", 79999m, 8 },
                    { 18, "Acer", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Nitro 5", 27999m, 19 },
                    { 19, "ASUS", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "VivoBook 15", 19999m, 18 },
                    { 20, "Dell", 1, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "01noutbuki.png", "Latitude 7440", 46999m, 10 },
                    { 21, "ASUS", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "ROG Strix GT15", 65999m, 6 },
                    { 22, "HP", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "HP Omen 45L", 89999m, 13 },
                    { 23, "Acer", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Acer Predator Orion 3000", 72999m, 10 },
                    { 24, "Lenovo", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Lenovo Legion Tower 5", 68999m, 16 },
                    { 25, "Dell", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Alienware Aurora R15", 119999m, 14 },
                    { 26, "MSI", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "MSI Infinite X2", 94999m, 14 },
                    { 27, "Apple", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Mac Studio M2", 99999m, 16 },
                    { 28, "Apple", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Mac Mini M2", 29999m, 16 },
                    { 29, "ASUS", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "ExpertCenter D5", 25999m, 11 },
                    { 30, "HP", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "ProDesk 400", 21999m, 8 },
                    { 31, "Lenovo", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "ThinkCentre M70", 23999m, 15 },
                    { 32, "Dell", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "OptiPlex 7000", 28999m, 8 },
                    { 33, "Acer", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Aspire TC", 19999m, 13 },
                    { 34, "Gigabyte", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "AORUS Model X", 109999m, 12 },
                    { 35, "MSI", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Trident 3", 49999m, 9 },
                    { 36, "HP", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Pavilion Gaming TG01", 37999m, 17 },
                    { 37, "Lenovo", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "IdeaCentre 5", 31999m, 5 },
                    { 38, "Dell", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Vostro 3910", 26999m, 12 },
                    { 39, "ASUS", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "ROG G22CH", 74999m, 12 },
                    { 40, "Acer", 2, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "02kompyutery.png", "Veriton X", 22999m, 12 },
                    { 41, "Samsung", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Odyssey G7 27", 18999m, 16 },
                    { 42, "LG", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "UltraGear 27GP850", 17999m, 12 },
                    { 43, "ASUS", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "ProArt PA278", 15999m, 9 },
                    { 44, "Dell", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Dell S2721D", 13999m, 9 },
                    { 45, "AOC", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "AOC Q27G2", 12999m, 15 },
                    { 46, "ViewSonic", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "ViewSonic VX2758", 11999m, 9 },
                    { 47, "BenQ", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "BenQ EX2780Q", 16999m, 10 },
                    { 48, "Gigabyte", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Gigabyte M27Q", 14999m, 18 },
                    { 49, "Samsung", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Odyssey Neo G8", 34999m, 7 },
                    { 50, "LG", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "LG 34WN80C", 24999m, 18 },
                    { 51, "ASUS", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "ASUS VG259QM", 9999m, 15 },
                    { 52, "Dell", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Dell U2720Q", 19999m, 14 },
                    { 53, "Philips", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Philips 276E", 8999m, 12 },
                    { 54, "MSI", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "MSI Optix G241", 7999m, 12 },
                    { 55, "HP", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "HP X27", 8999m, 5 },
                    { 56, "Lenovo", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Lenovo G27", 8499m, 13 },
                    { 57, "Acer", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Acer Nitro VG240", 7499m, 16 },
                    { 58, "Samsung", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Samsung S24R350", 5999m, 6 },
                    { 59, "LG", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "LG 24MK600", 5499m, 19 },
                    { 60, "Dell", 3, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "03monitory.png", "Dell E2422H", 4999m, 7 },
                    { 61, "Gigabyte", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 4090 Gaming OC", 89999m, 6 },
                    { 62, "MSI", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 4080 SUPRIM", 69999m, 11 },
                    { 63, "ASUS", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 4070 Ti", 49999m, 10 },
                    { 64, "Gigabyte", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 4060", 19999m, 5 },
                    { 65, "Sapphire", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 7900 XTX", 57999m, 18 },
                    { 66, "PowerColor", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 7800 XT", 34999m, 5 },
                    { 67, "ASRock", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 7700 XT", 29999m, 18 },
                    { 68, "MSI", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 3060", 14999m, 16 },
                    { 69, "ASUS", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 3050", 10999m, 17 },
                    { 70, "Gigabyte", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "GTX 1660 Super", 9999m, 10 },
                    { 71, "Sapphire", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 6600", 11999m, 16 },
                    { 72, "PowerColor", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 6500 XT", 8999m, 16 },
                    { 73, "EVGA", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 3080", 32999m, 12 },
                    { 74, "Zotac", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 3070", 24999m, 10 },
                    { 75, "MSI", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 2060", 12999m, 15 },
                    { 76, "Sapphire", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 5700 XT", 13999m, 15 },
                    { 77, "NVIDIA", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 4050 Laptop GPU", 9999m, 9 },
                    { 78, "PNY", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RTX 5000 Ada", 109999m, 6 },
                    { 79, "NVIDIA", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "A2000", 25999m, 6 },
                    { 80, "ASRock", 4, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "04videocarty.jpg", "RX 6400", 7999m, 9 },
                    { 81, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 9 7950X", 25999m, 9 },
                    { 82, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 7 7800X3D", 18999m, 19 },
                    { 83, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 5 7600X", 11999m, 14 },
                    { 84, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 5 5600", 6999m, 13 },
                    { 85, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core i9-14900K", 27999m, 14 },
                    { 86, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core i7-14700K", 19999m, 6 },
                    { 87, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core i5-14600K", 14999m, 17 },
                    { 88, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core i5-13400", 9999m, 5 },
                    { 89, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core i3-13100", 5999m, 12 },
                    { 90, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 9 5900X", 17999m, 16 },
                    { 91, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 7 5700X", 10999m, 5 },
                    { 92, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 5 5500", 4999m, 19 },
                    { 93, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Xeon W-1370", 22999m, 13 },
                    { 94, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Threadripper 7970X", 99999m, 9 },
                    { 95, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core Ultra 7", 18999m, 11 },
                    { 96, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core Ultra 5", 13999m, 9 },
                    { 97, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Athlon 3000G", 1999m, 6 },
                    { 98, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Pentium Gold", 2999m, 9 },
                    { 99, "AMD", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Ryzen 3 4100", 3999m, 12 },
                    { 100, "Intel", 5, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "05prozesory.jpg", "Core i9-13900KS", 29999m, 14 },
                    { 101, "ASUS", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ROG Strix Z790-E", 18999m, 11 },
                    { 102, "MSI", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "MSI MPG Z790 Carbon", 17999m, 15 },
                    { 103, "Gigabyte", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "Gigabyte Z790 AORUS Elite", 15999m, 6 },
                    { 104, "ASRock", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ASRock Z790 Steel Legend", 13999m, 17 },
                    { 105, "ASUS", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ASUS B650-PLUS", 9999m, 6 },
                    { 106, "MSI", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "MSI B650 Tomahawk", 10999m, 19 },
                    { 107, "Gigabyte", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "Gigabyte B550M DS3H", 4999m, 7 },
                    { 108, "ASUS", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ASUS Prime H610M", 3999m, 6 },
                    { 109, "MSI", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "MSI PRO H610", 3499m, 18 },
                    { 110, "ASRock", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ASRock B450 Pro4", 2999m, 11 },
                    { 111, "ASUS", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ROG Crosshair X670E", 24999m, 9 },
                    { 112, "MSI", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "MSI MEG X670E Ace", 27999m, 15 },
                    { 113, "Gigabyte", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "Gigabyte X670 AORUS Master", 23999m, 20 },
                    { 114, "ASUS", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ASUS TUF B760M", 8999m, 15 },
                    { 115, "MSI", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "MSI B760 Gaming Plus", 9499m, 19 },
                    { 116, "Gigabyte", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "Gigabyte H510M", 2999m, 8 },
                    { 117, "ASRock", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ASRock H470 Steel Legend", 3999m, 18 },
                    { 118, "ASUS", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "ROG Strix B550-F", 7999m, 17 },
                    { 119, "MSI", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "MSI B550 Gaming Edge", 7499m, 11 },
                    { 120, "Gigabyte", 6, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "06materinskykarty.jpg", "Gigabyte B760 AORUS Elite", 10999m, 16 },
                    { 121, "Kingston", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Kingston Fury 16GB DDR5", 3499m, 9 },
                    { 122, "Corsair", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Corsair Vengeance 32GB DDR5", 6999m, 18 },
                    { 123, "G.Skill", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "G.Skill Trident Z 32GB", 7499m, 9 },
                    { 124, "Kingston", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Kingston Fury 8GB DDR4", 999m, 5 },
                    { 125, "Crucial", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Crucial 16GB DDR4", 1999m, 9 },
                    { 126, "ADATA", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "ADATA XPG 16GB", 1799m, 17 },
                    { 127, "TeamGroup", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "TeamGroup T-Force 32GB", 6499m, 7 },
                    { 128, "Patriot", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Patriot Viper 16GB", 1999m, 7 },
                    { 129, "Corsair", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Corsair Dominator 64GB", 14999m, 20 },
                    { 130, "G.Skill", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "G.Skill Ripjaws 16GB", 1899m, 10 },
                    { 131, "Kingston", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Kingston Fury 32GB", 5999m, 13 },
                    { 132, "Crucial", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Crucial 32GB DDR5", 7999m, 5 },
                    { 133, "ADATA", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "ADATA XPG 32GB", 7499m, 14 },
                    { 134, "TeamGroup", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "TeamGroup Elite 16GB", 1799m, 12 },
                    { 135, "Patriot", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Patriot Signature 8GB", 899m, 18 },
                    { 136, "Corsair", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Corsair LPX 16GB", 1999m, 14 },
                    { 137, "G.Skill", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "G.Skill 8GB DDR4", 899m, 17 },
                    { 138, "Kingston", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Kingston Server RAM", 4999m, 17 },
                    { 139, "Micron", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Micron ECC 32GB", 8999m, 11 },
                    { 140, "Samsung", 7, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "07operatyvnapamiat.jpg", "Samsung DDR5 16GB", 3499m, 15 },
                    { 141, "Samsung", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Samsung 990 Pro 1TB", 4999m, 19 },
                    { 142, "WD", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "WD Black SN850X", 4799m, 16 },
                    { 143, "Kingston", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Kingston KC3000", 4599m, 7 },
                    { 144, "Crucial", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Crucial P5 Plus", 3999m, 6 },
                    { 145, "ADATA", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "ADATA Legend 960", 3799m, 12 },
                    { 146, "Samsung", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Samsung 970 EVO", 2999m, 11 },
                    { 147, "WD", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "WD Blue SN570", 2499m, 20 },
                    { 148, "Kingston", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Kingston NV2", 1999m, 19 },
                    { 149, "Crucial", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Crucial BX500", 1499m, 10 },
                    { 150, "Samsung", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Samsung 870 QVO", 2299m, 7 },
                    { 151, "WD", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "WD Green SSD", 1199m, 12 },
                    { 152, "ADATA", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "ADATA SU800", 1399m, 10 },
                    { 153, "Kingston", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Kingston A400", 999m, 18 },
                    { 154, "Samsung", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Samsung T7 Portable", 3999m, 16 },
                    { 155, "WD", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "WD My Passport SSD", 3799m, 10 },
                    { 156, "Crucial", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Crucial X8 Portable", 3599m, 14 },
                    { 157, "Seagate", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Seagate FireCuda 530", 5499m, 10 },
                    { 158, "PNY", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "PNY CS3140", 4899m, 5 },
                    { 159, "TeamGroup", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "TeamGroup MP44", 4299m, 13 },
                    { 160, "Gigabyte", 8, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "08ssd.jpg", "Gigabyte AORUS Gen4", 4599m, 9 },
                    { 161, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "MX Master 3S", 3999m, 17 },
                    { 162, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "G Pro Wireless", 4999m, 5 },
                    { 163, "Razer", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Razer DeathAdder V3", 3499m, 6 },
                    { 164, "SteelSeries", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "SteelSeries Rival 5", 2999m, 12 },
                    { 165, "Corsair", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Corsair K95 RGB", 6999m, 18 },
                    { 166, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Logitech G915", 7999m, 9 },
                    { 167, "Razer", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Razer BlackWidow", 5999m, 5 },
                    { 168, "HyperX", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "HyperX Alloy Core", 2499m, 13 },
                    { 169, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Logitech C920", 2999m, 17 },
                    { 170, "Razer", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Razer Kiyo", 3499m, 10 },
                    { 171, "Blue", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Blue Yeti Mic", 4999m, 11 },
                    { 172, "HyperX", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "HyperX Cloud II", 3999m, 6 },
                    { 173, "SteelSeries", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "SteelSeries Arctis 7", 4999m, 10 },
                    { 174, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Logitech Z623", 5999m, 16 },
                    { 175, "Creative", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Creative Pebble", 1999m, 18 },
                    { 176, "TP-Link", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "TP-Link USB Adapter", 799m, 13 },
                    { 177, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Logitech Mouse Pad", 499m, 15 },
                    { 178, "Razer", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Razer Mouse Bungee", 999m, 8 },
                    { 179, "Elgato", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Elgato Stream Deck", 5999m, 14 },
                    { 180, "Logitech", 9, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "09peryfyria.jpg", "Logitech Brio", 6999m, 19 },
                    { 181, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Archer AX55", 3499m, 18 },
                    { 182, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Archer AX73", 4999m, 8 },
                    { 183, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Archer C6", 1999m, 18 },
                    { 184, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Deco X20", 6999m, 17 },
                    { 185, "ASUS", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "ASUS RT-AX58U", 3999m, 19 },
                    { 186, "ASUS", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "ASUS RT-AX88U", 7999m, 8 },
                    { 187, "Netgear", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Netgear Nighthawk", 6999m, 7 },
                    { 188, "Ubiquiti", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Ubiquiti UniFi AP", 5999m, 19 },
                    { 189, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "TP-Link Switch 8p", 999m, 6 },
                    { 190, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "TP-Link Switch 16p", 1999m, 9 },
                    { 191, "D-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "D-Link DIR-825", 1499m, 8 },
                    { 192, "MikroTik", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "MikroTik hAP ac2", 2499m, 17 },
                    { 193, "MikroTik", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "MikroTik RB4011", 7999m, 9 },
                    { 194, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "TP-Link Range Extender", 999m, 6 },
                    { 195, "ASUS", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "ASUS Mesh Node", 2999m, 19 },
                    { 196, "Netgear", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Netgear Switch 24p", 4999m, 19 },
                    { 197, "Ubiquiti", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Ubiquiti Switch Lite", 3999m, 14 },
                    { 198, "TP-Link", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "TP-Link LTE Router", 3499m, 15 },
                    { 199, "Huawei", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Huawei B535", 2999m, 8 },
                    { 200, "Zyxel", 10, new DateTime(2026, 2, 17, 12, 0, 0, 0, DateTimeKind.Unspecified), "10meregeve.png", "Zyxel Armor G5", 8999m, 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
