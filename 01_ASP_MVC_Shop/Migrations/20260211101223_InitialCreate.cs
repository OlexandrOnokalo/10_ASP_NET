using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace _01_ASP_MVC_Shop.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
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
                columns: new[] { "Id", "Brand", "CategoryId", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "ASUS", 1, "ROG Strix G16", 58999m },
                    { 2, "ASUS", 1, "TUF Gaming A15", 36999m },
                    { 3, "ASUS", 1, "ZenBook 14", 38999m },
                    { 4, "Apple", 1, "MacBook Air M2", 45999m },
                    { 5, "Apple", 1, "MacBook Pro 14 M3", 89999m },
                    { 6, "Lenovo", 1, "ThinkPad X13", 39999m },
                    { 7, "Lenovo", 1, "Legion 5 Pro", 54999m },
                    { 8, "Lenovo", 1, "IdeaPad 5", 21999m },
                    { 9, "HP", 1, "HP Pavilion 15", 27999m },
                    { 10, "HP", 1, "HP Omen 16", 62999m },
                    { 11, "Acer", 1, "Acer Nitro 5", 32999m },
                    { 12, "Acer", 1, "Acer Swift 3", 23999m },
                    { 13, "Dell", 1, "Dell XPS 13", 54999m },
                    { 14, "Dell", 1, "Dell Inspiron 14", 28999m },
                    { 15, "MSI", 1, "MSI Katana 15", 41999m },
                    { 16, "MSI", 1, "MSI Stealth 16", 72999m },
                    { 17, "Gigabyte", 1, "Gigabyte G5", 33999m },
                    { 18, "Huawei", 1, "Huawei MateBook D15", 25999m },
                    { 19, "Samsung", 1, "Samsung Galaxy Book3", 34999m },
                    { 20, "Razer", 1, "Razer Blade 15", 79999m },
                    { 21, "ASUS", 2, "ROG Strix GT15", 65999m },
                    { 22, "HP", 2, "HP Omen 45L", 89999m },
                    { 23, "Acer", 2, "Acer Predator Orion 3000", 72999m },
                    { 24, "Lenovo", 2, "Lenovo Legion Tower 5", 68999m },
                    { 25, "Dell", 2, "Alienware Aurora R15", 119999m },
                    { 26, "MSI", 2, "MSI Infinite X2", 94999m },
                    { 27, "Apple", 2, "Mac Studio M2", 99999m },
                    { 28, "Apple", 2, "Mac Mini M2", 29999m },
                    { 29, "ASUS", 2, "ExpertCenter D5", 25999m },
                    { 30, "HP", 2, "ProDesk 400", 21999m },
                    { 31, "Lenovo", 2, "ThinkCentre M70", 23999m },
                    { 32, "Dell", 2, "OptiPlex 7000", 28999m },
                    { 33, "Acer", 2, "Aspire TC", 19999m },
                    { 34, "Gigabyte", 2, "AORUS Model X", 109999m },
                    { 35, "MSI", 2, "Trident 3", 49999m },
                    { 36, "HP", 2, "Pavilion Gaming TG01", 37999m },
                    { 37, "Lenovo", 2, "IdeaCentre 5", 31999m },
                    { 38, "Dell", 2, "Vostro 3910", 26999m },
                    { 39, "ASUS", 2, "ROG G22CH", 74999m },
                    { 40, "Acer", 2, "Veriton X", 22999m },
                    { 41, "Samsung", 3, "Odyssey G7 27", 18999m },
                    { 42, "LG", 3, "UltraGear 27GP850", 17999m },
                    { 43, "ASUS", 3, "TUF VG27AQ", 16999m },
                    { 44, "Acer", 3, "Predator XB273", 19999m },
                    { 45, "Dell", 3, "Dell S2721DGF", 15999m },
                    { 46, "AOC", 3, "AOC CQ27G2", 12999m },
                    { 47, "MSI", 3, "MSI Optix MAG274", 14999m },
                    { 48, "Gigabyte", 3, "Gigabyte M27Q", 13999m },
                    { 49, "Philips", 3, "Philips 272E1CA", 9999m },
                    { 50, "ViewSonic", 3, "ViewSonic XG2405", 10999m },
                    { 51, "BenQ", 3, "BenQ EX2780Q", 14999m },
                    { 52, "LG", 3, "LG 34GN850", 29999m },
                    { 53, "Samsung", 3, "Samsung S80UA", 21999m },
                    { 54, "ASUS", 3, "ASUS ProArt PA32", 45999m },
                    { 55, "Dell", 3, "Dell P2422H", 8999m },
                    { 56, "Acer", 3, "Acer CB242Y", 7999m },
                    { 57, "HP", 3, "HP X27", 11999m },
                    { 58, "Lenovo", 3, "Lenovo G27q-30", 10999m },
                    { 59, "MSI", 3, "MSI MPG341", 32999m },
                    { 60, "Gigabyte", 3, "Gigabyte G32QC", 18999m },
                    { 61, "Gigabyte", 4, "RTX 4090 Gaming OC", 89999m },
                    { 62, "ASUS", 4, "RTX 4080 Super", 59999m },
                    { 63, "MSI", 4, "RTX 4070 Ti", 44999m },
                    { 64, "Gigabyte", 4, "RTX 4070", 35999m },
                    { 65, "ASUS", 4, "RTX 4060 Ti", 25999m },
                    { 66, "MSI", 4, "RTX 4060", 19999m },
                    { 67, "Sapphire", 4, "RX 7900 XTX", 54999m },
                    { 68, "Sapphire", 4, "RX 7900 XT", 47999m },
                    { 69, "Gigabyte", 4, "RX 7800 XT", 32999m },
                    { 70, "ASRock", 4, "RX 7700 XT", 28999m },
                    { 71, "MSI", 4, "RTX 3060", 14999m },
                    { 72, "ASUS", 4, "RTX 3050", 10999m },
                    { 73, "Sapphire", 4, "RX 6600", 11999m },
                    { 74, "Gigabyte", 4, "RX 6500 XT", 8999m },
                    { 75, "ASUS", 4, "RTX 3080 Ti", 34999m },
                    { 76, "MSI", 4, "RTX 3090", 39999m },
                    { 77, "Sapphire", 4, "RX 6800 XT", 25999m },
                    { 78, "Gigabyte", 4, "RX 6700 XT", 19999m },
                    { 79, "ASUS", 4, "RTX 3070", 17999m },
                    { 80, "MSI", 4, "RTX 2060", 8999m },
                    { 81, "AMD", 5, "Ryzen 9 7950X", 25999m },
                    { 82, "AMD", 5, "Ryzen 7 7800X3D", 18999m },
                    { 83, "AMD", 5, "Ryzen 5 7600X", 9999m },
                    { 84, "AMD", 5, "Ryzen 7 5800X", 8999m },
                    { 85, "AMD", 5, "Ryzen 5 5600X", 6999m },
                    { 86, "Intel", 5, "Core i9-14900K", 27999m },
                    { 87, "Intel", 5, "Core i7-14700K", 18999m },
                    { 88, "Intel", 5, "Core i5-14600K", 11999m },
                    { 89, "Intel", 5, "Core i7-13700K", 16999m },
                    { 90, "Intel", 5, "Core i5-13600K", 10999m },
                    { 91, "AMD", 5, "Ryzen 9 5900X", 13999m },
                    { 92, "AMD", 5, "Ryzen 5 5500", 4999m },
                    { 93, "Intel", 5, "Core i3-13100", 4999m },
                    { 94, "Intel", 5, "Core i9-13900K", 23999m },
                    { 95, "AMD", 5, "Ryzen 7 7700X", 14999m },
                    { 96, "Intel", 5, "Core i5-12400F", 5999m },
                    { 97, "AMD", 5, "Ryzen 3 4100", 2999m },
                    { 98, "Intel", 5, "Core i7-12700K", 13999m },
                    { 99, "AMD", 5, "Ryzen 9 7900X", 20999m },
                    { 100, "Intel", 5, "Core i5-13400", 7999m },
                    { 101, "ASUS", 6, "ROG Strix Z790-E", 18999m },
                    { 102, "ASUS", 6, "TUF B650-Plus", 7999m },
                    { 103, "MSI", 6, "MSI MPG Z790 Carbon", 17999m },
                    { 104, "MSI", 6, "MSI B550 Tomahawk", 5999m },
                    { 105, "Gigabyte", 6, "Gigabyte Z790 Aorus Elite", 14999m },
                    { 106, "Gigabyte", 6, "Gigabyte B650 Aorus", 8999m },
                    { 107, "ASRock", 6, "ASRock Z790 Steel Legend", 12999m },
                    { 108, "ASRock", 6, "ASRock B550M Pro4", 4999m },
                    { 109, "ASUS", 6, "ASUS Prime H610M", 3999m },
                    { 110, "MSI", 6, "MSI PRO B760M", 4999m },
                    { 111, "Gigabyte", 6, "Gigabyte H610M S2H", 3499m },
                    { 112, "ASRock", 6, "ASRock B650M PG", 6999m },
                    { 113, "ASUS", 6, "ROG Crosshair X670E", 23999m },
                    { 114, "MSI", 6, "MSI MEG Z790 ACE", 25999m },
                    { 115, "Gigabyte", 6, "Gigabyte X670 Aorus Master", 21999m },
                    { 116, "ASRock", 6, "ASRock X570 Taichi", 11999m },
                    { 117, "ASUS", 6, "ASUS Prime B550M-A", 4499m },
                    { 118, "MSI", 6, "MSI B450 Tomahawk", 3999m },
                    { 119, "Gigabyte", 6, "Gigabyte B760 Gaming X", 8999m },
                    { 120, "ASRock", 6, "ASRock H610M-HDV", 2999m },
                    { 121, "Kingston", 7, "Kingston Fury 16GB DDR5", 3499m },
                    { 122, "Kingston", 7, "Kingston Fury 32GB DDR5", 6999m },
                    { 123, "Corsair", 7, "Corsair Vengeance 16GB DDR4", 2499m },
                    { 124, "Corsair", 7, "Corsair Vengeance 32GB DDR4", 4999m },
                    { 125, "G.Skill", 7, "G.Skill Trident Z 16GB", 2999m },
                    { 126, "G.Skill", 7, "G.Skill Trident Z 32GB", 5999m },
                    { 127, "HyperX", 7, "HyperX Fury 16GB", 2399m },
                    { 128, "HyperX", 7, "HyperX Fury 32GB", 4799m },
                    { 129, "TeamGroup", 7, "TeamGroup T-Force 16GB", 2199m },
                    { 130, "TeamGroup", 7, "TeamGroup T-Force 32GB", 4299m },
                    { 131, "Patriot", 7, "Patriot Viper 16GB", 1999m },
                    { 132, "Patriot", 7, "Patriot Viper 32GB", 3999m },
                    { 133, "ADATA", 7, "ADATA XPG 16GB", 2299m },
                    { 134, "ADATA", 7, "ADATA XPG 32GB", 4599m },
                    { 135, "Crucial", 7, "Crucial 16GB DDR4", 1999m },
                    { 136, "Crucial", 7, "Crucial 32GB DDR4", 3999m },
                    { 137, "Kingston", 7, "Kingston ValueRAM 8GB", 999m },
                    { 138, "Corsair", 7, "Corsair Dominator 32GB", 7999m },
                    { 139, "G.Skill", 7, "G.Skill Ripjaws 16GB", 2499m },
                    { 140, "HyperX", 7, "HyperX Impact 16GB", 2699m },
                    { 141, "Samsung", 8, "Samsung 990 Pro 1TB", 4999m },
                    { 142, "Samsung", 8, "Samsung 980 Pro 2TB", 7999m },
                    { 143, "WD", 8, "WD Black SN850X 1TB", 4499m },
                    { 144, "WD", 8, "WD Blue SN570 1TB", 2999m },
                    { 145, "Kingston", 8, "Kingston NV2 1TB", 2499m },
                    { 146, "Kingston", 8, "Kingston KC3000 2TB", 6999m },
                    { 147, "Crucial", 8, "Crucial P5 Plus 1TB", 3999m },
                    { 148, "Crucial", 8, "Crucial MX500 1TB", 3499m },
                    { 149, "ADATA", 8, "ADATA SX8200 Pro 1TB", 3299m },
                    { 150, "ADATA", 8, "ADATA Legend 960 2TB", 6499m },
                    { 151, "Samsung", 8, "Samsung 870 EVO 1TB", 2999m },
                    { 152, "WD", 8, "WD Green 480GB", 1299m },
                    { 153, "Kingston", 8, "Kingston A400 480GB", 1199m },
                    { 154, "Seagate", 8, "Seagate FireCuda 530 1TB", 5499m },
                    { 155, "Samsung", 8, "Samsung 990 Pro 2TB", 8999m },
                    { 156, "WD", 8, "WD Black SN770 1TB", 3499m },
                    { 157, "Kingston", 8, "Kingston Fury Renegade 1TB", 4299m },
                    { 158, "Crucial", 8, "Crucial P3 1TB", 2799m },
                    { 159, "ADATA", 8, "ADATA SU650 480GB", 1099m },
                    { 160, "Samsung", 8, "Samsung T7 1TB External", 3999m },
                    { 161, "Logitech", 9, "MX Master 3S", 3999m },
                    { 162, "Logitech", 9, "G Pro X Superlight", 4999m },
                    { 163, "Razer", 9, "Razer DeathAdder V3", 3499m },
                    { 164, "SteelSeries", 9, "SteelSeries Rival 5", 2499m },
                    { 165, "HyperX", 9, "HyperX Alloy Origins", 3999m },
                    { 166, "Corsair", 9, "Corsair K70 RGB", 4999m },
                    { 167, "Logitech", 9, "Logitech G915", 7999m },
                    { 168, "Razer", 9, "Razer BlackWidow V4", 5499m },
                    { 169, "SteelSeries", 9, "SteelSeries Apex 7", 4499m },
                    { 170, "HyperX", 9, "HyperX Cloud II", 2999m },
                    { 171, "Logitech", 9, "Logitech G Pro X Headset", 3999m },
                    { 172, "Razer", 9, "Razer Kraken V3", 3499m },
                    { 173, "Corsair", 9, "Corsair HS80", 4499m },
                    { 174, "Logitech", 9, "Logitech C920 Webcam", 2999m },
                    { 175, "Razer", 9, "Razer Kiyo Pro", 5999m },
                    { 176, "SteelSeries", 9, "SteelSeries Arctis 7", 4999m },
                    { 177, "HyperX", 9, "HyperX Pulsefire Haste", 1999m },
                    { 178, "Logitech", 9, "Logitech G502 X", 3299m },
                    { 179, "Razer", 9, "Razer Basilisk V3", 2999m },
                    { 180, "Corsair", 9, "Corsair MM700 RGB Pad", 1999m },
                    { 181, "TP-Link", 10, "Archer AX55", 3499m },
                    { 182, "TP-Link", 10, "Archer AX73", 4999m },
                    { 183, "TP-Link", 10, "Deco X20", 6999m },
                    { 184, "ASUS", 10, "RT-AX86U", 8999m },
                    { 185, "ASUS", 10, "RT-AX58U", 4999m },
                    { 186, "Netgear", 10, "Nighthawk AX12", 12999m },
                    { 187, "Netgear", 10, "Nighthawk R7000", 3999m },
                    { 188, "Ubiquiti", 10, "UniFi Dream Router", 7999m },
                    { 189, "Ubiquiti", 10, "UniFi AP AC Pro", 5999m },
                    { 190, "MikroTik", 10, "MikroTik hAP ax3", 3499m },
                    { 191, "MikroTik", 10, "MikroTik RB4011", 7999m },
                    { 192, "D-Link", 10, "D-Link DIR-X5460", 3999m },
                    { 193, "D-Link", 10, "D-Link DIR-842", 1999m },
                    { 194, "TP-Link", 10, "TP-Link TL-SG108 Switch", 999m },
                    { 195, "Netgear", 10, "Netgear GS308 Switch", 1299m },
                    { 196, "ASUS", 10, "ASUS ZenWiFi XT8", 12999m },
                    { 197, "TP-Link", 10, "TP-Link RE650 Extender", 1999m },
                    { 198, "Netgear", 10, "Netgear Orbi RBK352", 8999m },
                    { 199, "MikroTik", 10, "MikroTik CRS326", 9999m },
                    { 200, "Ubiquiti", 10, "Ubiquiti UniFi Switch 8", 6499m }
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
