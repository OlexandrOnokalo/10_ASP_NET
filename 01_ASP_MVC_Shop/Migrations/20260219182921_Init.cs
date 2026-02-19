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
                    Description = table.Column<string>(type: "ntext", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Amount = table.Column<int>(type: "int", nullable: false),
                    Color = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                columns: new[] { "Id", "Amount", "CategoryId", "Color", "CreatedDate", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 12, 1, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Компактний 13\" ультрабук з Intel Core i7 12-го покоління, 16GB RAM та 512GB SSD. Відмінний для мобільної роботи.", "01noutbuki.png", "Dell XPS 13 9315", 1299.99 },
                    { 2, 0, 1, "Space Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "MacBook Air на M2 — тонкий та легкий, чудова автономність, 8-ядерний процесор та Retina дисплей.", "01noutbuki.png", "Apple MacBook Air M2 13\"", 1199.0 },
                    { 3, 6, 1, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміальний бізнес-ноутбук з якісною клавіатурою, 14\" дисплеєм та захищеною конструкцією.", "01noutbuki.png", "Lenovo ThinkPad X1 Carbon Gen 11", 1499.5 },
                    { 4, 10, 1, "Nightfall Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Конвертований 2-в-1 ноутбук з сенсорним OLED-екраном, ідеальний для творчих задач.", "01noutbuki.png", "HP Spectre x360 14", 1099.99 },
                    { 5, 7, 1, "Moonlight White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ігровий ноутбук 14\" з Ryzen 9 та дискретною відеокартою високої продуктивності.", "01noutbuki.png", "Asus ROG Zephyrus G14", 1599.0 },
                    { 6, 15, 1, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Легкий 14\" ноутбук із хорошим балансом ціни та продуктивності, 8GB RAM, 256GB SSD.", "01noutbuki.png", "Acer Swift 3 (SF314)", 699.99000000000001 },
                    { 7, 9, 1, "Carbon Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ноутбук для креаторів: тонкий корпус, потужний процесор та якісна матриця дисплея.", "01noutbuki.png", "MSI Prestige 14", 1249.0 },
                    { 8, 14, 1, "Mystic Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "15\" універсальний ноутбук з хорошою автономністю і співвідношенням ціни/можливостей.", "01noutbuki.png", "Huawei MateBook D 15", 549.99000000000001 },
                    { 9, 5, 1, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум ігровий ноутбук з високою частотою оновлення дисплея та потужною графікою.", "01noutbuki.png", "Razer Blade 15", 2199.0 },
                    { 10, 11, 1, "Burgundy", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Тонкий 15\" ноутбук з AMOLED-дисплеєм, оптимізований для мобільності й мультимедіа.", "01noutbuki.png", "Samsung Galaxy Book3 Pro 15\"", 1399.0 },
                    { 11, 6, 1, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Вкрай легкий 16\" ноутбук з довгою автономністю та високою портативністю.", "01noutbuki.png", "LG Gram 16", 1699.0 },
                    { 12, 9, 1, "Platinum", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Елегантний ноутбук з якісним дисплеєм PixelSense та комфортною клавіатурою.", "01noutbuki.png", "Microsoft Surface Laptop 5", 1149.0 },
                    { 13, 10, 1, "Grey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужний універсальний ноутбук з 16\" дисплеєм для роботи та розваг.", "01noutbuki.png", "Dell Inspiron 16 Plus", 1299.0 },
                    { 14, 8, 1, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ігрова серія OMEN: 16\" дисплей, високопродуктивна начинка і система охолодження.", "01noutbuki.png", "HP Omen 16", 1399.99 },
                    { 15, 13, 1, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярний ігровий ноутбук з хорошим співвідношенням ціни та FPS.", "01noutbuki.png", "Acer Predator Helios 300", 1199.0 },
                    { 16, 12, 1, "Storm Grey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ігрова серія Legion з якісним екраном і потужним CPU/GPU.", "01noutbuki.png", "Lenovo Legion 5 Pro", 1299.0 },
                    { 17, 10, 1, "Pine Grey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стильний ультрабук з OLED-дисплеєм, тонким корпусом та тривалим часом роботи.", "01noutbuki.png", "Asus ZenBook 14 OLED", 999.99000000000001 },
                    { 18, 7, 1, "Space Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум 13.9\" ноутбук з потужною начинкою та легким корпусом.", "01noutbuki.png", "Huawei MateBook X Pro", 1399.0 },
                    { 19, 16, 1, "Steel Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Chromebook з довгою автономністю і продуктивністю для задач у ChromeOS.", "01noutbuki.png", "Acer Chromebook Spin 713", 649.99000000000001 },
                    { 20, 9, 1, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бізнес-ноутбук з корпоративними фічами, безпекою та надійною збіркою.", "01noutbuki.png", "HP EliteBook 840 G9", 1199.0 },
                    { 21, 10, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійний бізнес-десктоп для офісних завдань з можливістю апгрейду.", "02kompyutery.png", "Dell OptiPlex 7000 Tower", 999.99000000000001 },
                    { 22, 0, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ігровий десктоп початкового/середнього рівня з дискретною графікою.", "02kompyutery.png", "HP Pavilion Gaming Desktop TG01", 849.0 },
                    { 23, 14, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Компактний офісний ПК з достатньою потужністю для бізнес-додатків.", "02kompyutery.png", "Lenovo ThinkCentre M70s", 749.99000000000001 },
                    { 24, 6, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужна ігрова станція від ROG з сучасним процесором і GPU.", "02kompyutery.png", "ASUS ROG Strix GT15", 1599.99 },
                    { 25, 11, 2, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Компактний десктоп з чіпом Apple M2 — ефективний для продуктивної роботи.", "02kompyutery.png", "Apple Mac Mini (M2)", 599.0 },
                    { 26, 15, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Універсальний настільний ПК для дому та навчання з хорошим співвідношенням ціни.", "02kompyutery.png", "Acer Aspire TC", 499.99000000000001 },
                    { 27, 8, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ігровий ПК середнього класу з фокусом на продуктивність та охолодження.", "02kompyutery.png", "MSI Infinite S", 1299.0 },
                    { 28, 5, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум компактна ігрова станція з топовими комплектуючими.", "02kompyutery.png", "Corsair One i300", 2999.0 },
                    { 29, 9, 2, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Корпоративний ПК з можливістю управління та стійкою роботою.", "02kompyutery.png", "HP EliteDesk 800 G9", 1199.0 },
                    { 30, 7, 2, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужний десктоп для створення контенту та ігор.", "02kompyutery.png", "Dell XPS Desktop 8950", 1399.0 },
                    { 31, 8, 2, "Iron Grey", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ігровий корпус з можливістю апгрейду GPU та охолодження.", "02kompyutery.png", "Lenovo Legion Tower 5", 1099.99 },
                    { 32, 13, 2, "Black/Red", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Готовий ігровий ПК з добрим співвідношенням ціна/продуктивність.", "02kompyutery.png", "CyberPowerPC Gamer Xtreme", 899.99000000000001 },
                    { 33, 6, 2, "Blue", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Моноблок Apple з M1 — стильний дизайн та висока продуктивність.", "02kompyutery.png", "Apple iMac 24\" M1", 1299.0 },
                    { 34, 5, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Робоча станція для професійних застосунків CAD/3D.", "02kompyutery.png", "HP Z2 Tower G8", 1499.0 },
                    { 35, 4, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Серія Precision — націлена на професіоналів із ресурсом потужності для рендеру.", "02kompyutery.png", "Dell Precision 3650 Tower", 1799.0 },
                    { 36, 14, 2, "Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Домашній ПК з комфортною продуктивністю для мультимедіа та офісу.", "02kompyutery.png", "Lenovo IdeaCentre 5", 599.99000000000001 },
                    { 37, 3, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Станція для творців контенту з сертифікаціями для професійних додатків.", "02kompyutery.png", "ASUS ProArt PA90", 2399.0 },
                    { 38, 10, 2, "Gunmetal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Розбалансований ігровий ПК для геймерів середнього сегмента.", "02kompyutery.png", "MSI Codex R", 999.99000000000001 },
                    { 39, 5, 2, "Dark Side of the Moon", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум-ігрова платформа з топовими компонентами і яскравим дизайном.", "02kompyutery.png", "Alienware Aurora R15", 2199.0 },
                    { 40, 18, 2, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Міні-ПК формфактора small-form для компактних робочих місць.", "02kompyutery.png", "ASRock DeskMini X300", 399.99000000000001 },
                    { 41, 9, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" 4K IPS монітор з відмінною передачею кольору для професійної роботи.", "03monitory.png", "Dell UltraSharp U2723QE 27\"", 699.99000000000001 },
                    { 42, 0, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" 4K ігровий монітор з високою частотою оновлення та низькою затримкою.", "03monitory.png", "LG UltraGear 27GN950-B 27\"", 599.99000000000001 },
                    { 43, 7, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "32\" вигнутий QHD монітор для ігор з високою частотою оновлення.", "03monitory.png", "Samsung Odyssey G7 32\"", 699.0 },
                    { 44, 3, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Професійний 32\" HDR монітор з точним охопленням кольору для постпродакшн.", "03monitory.png", "ASUS ProArt PA32UCX 32\"", 2499.9899999999998 },
                    { 45, 6, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" 4K дизайнерський монітор з режимами для креативної роботи.", "03monitory.png", "BenQ PD2725U 27\"", 799.99000000000001 },
                    { 46, 4, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум 4K ігровий монітор з G-Sync та яскравим HDR.", "03monitory.png", "Acer Predator X27 27\"", 1599.0 },
                    { 47, 16, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" вигнутий монітор для роботи та мультимедіа з хорошою ціною.", "03monitory.png", "Philips 272E1CA 27\"", 249.99000000000001 },
                    { 48, 5, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Професійний 27\" монітор з точним калібруванням кольору.", "03monitory.png", "ViewSonic VP2785-4K", 1299.0 },
                    { 49, 10, 3, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" 4K монітор із сучасним дизайном та гарною матрицею.", "03monitory.png", "Samsung S27A800U 27\"", 499.99000000000001 },
                    { 50, 12, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" QHD ігровий монітор з високою частотою оновлення та адаптивними технологіями.", "03monitory.png", "AOC Agon AG273QZ 27\"", 399.99000000000001 },
                    { 51, 14, 3, "Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "24\" професійний монітор для офісу з хорошою передачею кольору.", "03monitory.png", "HP Z24n G3 24\"", 299.99000000000001 },
                    { 52, 13, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" QHD 165Hz монітор — популярний вибір для ігор.", "03monitory.png", "Dell S2721DGF 27\"", 379.99000000000001 },
                    { 53, 7, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "34\" ультраширокий монітор для роботи з кількома вікнами одночасно.", "03monitory.png", "LG 34WN80C-B 34\" Curved", 649.99000000000001 },
                    { 54, 9, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" QHD монітор із вбудованими динаміками та режимами для ігор.", "03monitory.png", "BenQ EX2780Q 27\"", 499.99000000000001 },
                    { 55, 8, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "34\" із USB-C докінгом — зручно для ноутбука та робочої станції.", "03monitory.png", "Philips 346B1C 34\"", 449.99000000000001 },
                    { 56, 2, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "49\" ультраширокий вигнутий монітор для ігрових та симуляційних задач.", "03monitory.png", "Samsung Odyssey Neo G9 49\"", 1799.99 },
                    { 57, 17, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний 24\" монітор для щоденного використання та ігор.", "03monitory.png", "Acer Nitro VG240Y 24\"", 159.99000000000001 },
                    { 58, 15, 3, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "31.5\" стильний монітор з QHD для мультимедіа та роботи.", "03monitory.png", "ViewSonic VX3276-2K-MHD", 219.99000000000001 },
                    { 59, 11, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "27\" IPS ігровий монітор з G-Sync compatible та швидким відгуком.", "03monitory.png", "LG 27GL850-B 27\"", 349.99000000000001 },
                    { 60, 18, 3, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Універсальний 27\" монітор з матовою матрицею та тонкими рамками.", "03monitory.png", "BenQ GW2780 27\"", 179.99000000000001 },
                    { 61, 5, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Флагманська відеокарта для 4K геймінгу та важких графічних задач.", "04videocarty.jpg", "NVIDIA GeForce RTX 4090 Founders", 1999.99 },
                    { 62, 0, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Висока продуктивність у 4K та трасування променів.", "04videocarty.jpg", "NVIDIA GeForce RTX 4080", 1199.99 },
                    { 63, 10, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Відмінний вибір для високих налаштувань в 1440p.", "04videocarty.jpg", "NVIDIA GeForce RTX 4070 Ti", 799.99000000000001 },
                    { 64, 7, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Флагман AMD для геймінгу з великим обсягом пам'яті.", "04videocarty.jpg", "AMD Radeon RX 7900 XTX", 999.99000000000001 },
                    { 65, 9, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Сильна альтернатива для 1440p геймінгу.", "04videocarty.jpg", "AMD Radeon RX 7800 XT", 599.99000000000001 },
                    { 66, 14, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Середній клас з хорошою енергоефективністю для 1080/1440p.", "04videocarty.jpg", "NVIDIA GeForce RTX 4060 Ti", 399.99000000000001 },
                    { 67, 8, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Кулер і система живлення від ASUS для стабільності під навантаженням.", "04videocarty.jpg", "ASUS TUF Gaming RTX 4070", 799.99000000000001 },
                    { 68, 3, 4, "Silver/Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум кастомна RTX 4090 з заводським розгоном.", "04videocarty.jpg", "MSI Suprim X RTX 4090", 2199.0 },
                    { 69, 11, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна плата AMD із хорошою системою охолодження.", "04videocarty.jpg", "Gigabyte Eagle RX 7900 XT", 899.99000000000001 },
                    { 70, 10, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярна модель для 1440p/4K продуктивності.", "04videocarty.jpg", "Sapphire Nitro+ RX 6800 XT", 679.99000000000001 },
                    { 71, 4, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Серія ZOTAC з компактною системою охолодження та хорошим розгоном.", "04videocarty.jpg", "ZOTAC GAMING GeForce RTX 3080 Ti", 1199.0 },
                    { 72, 16, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Економічна відеокарта для 1080p ігрових налаштувань.", "04videocarty.jpg", "PNY GeForce RTX 3060", 329.99000000000001 },
                    { 73, 13, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стабільна карта для середнього сегмента.", "04videocarty.jpg", "ASRock Radeon RX 6700 XT", 499.99000000000001 },
                    { 74, 18, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Базова карта для бюджетних систем і кіберспорту.", "04videocarty.jpg", "EVGA GeForce GTX 1660 Super", 229.99000000000001 },
                    { 75, 2, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужна карта з великим об'ємом пам'яті для рендеру.", "04videocarty.jpg", "Gigabyte Aorus RTX 3090", 1599.0 },
                    { 76, 12, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярний варіант RTX 3070 для гравців середнього класу.", "04videocarty.jpg", "Palit GamingPro RTX 3070", 499.99000000000001 },
                    { 77, 5, 4, "Black/Red", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Висока продуктивність від AMD з агресивним дизайном.", "04videocarty.jpg", "PowerColor Red Devil RX 6900 XT", 899.99000000000001 },
                    { 78, 20, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бюджетна карта для невимогливих ігор і мультимедіа.", "04videocarty.jpg", "MSI Ventus GTX 1650", 149.99000000000001 },
                    { 79, 3, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Професійна плата для CAD/3D та GPU-акселерації.", "04videocarty.jpg", "NVIDIA Quadro RTX 4000 (для робочих станцій)", 899.99000000000001 },
                    { 80, 4, 4, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Рідинне охолодження для стабільної продуктивності при високих навантаженнях.", "04videocarty.jpg", "ASUS ROG Strix LC RTX 3080", 1399.99 },
                    { 81, 7, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Топовий десктопний процесор Intel для ігор та контенту.", "05prozesory.jpg", "Intel Core i9-13900K", 589.99000000000001 },
                    { 82, 0, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Флагман AMD для багатопотокових задач і створення контенту.", "05prozesory.jpg", "AMD Ryzen 9 7950X", 699.99000000000001 },
                    { 83, 10, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Висока продуктивність у іграх та щоденних завданнях.", "05prozesory.jpg", "Intel Core i7-13700K", 399.99000000000001 },
                    { 84, 12, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Відмінний вибір для ігрових та потокових систем.", "05prozesory.jpg", "AMD Ryzen 7 7700X", 329.99000000000001 },
                    { 85, 14, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Баланс продуктивності та ціни для геймерів.", "05prozesory.jpg", "Intel Core i5-13600K", 269.99000000000001 },
                    { 86, 16, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Оптимальний вибір для 1080/1440p геймерів.", "05prozesory.jpg", "AMD Ryzen 5 7600X", 229.99000000000001 },
                    { 87, 18, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бюджетний процесор для офісних та побутових ПК.", "05prozesory.jpg", "Intel Core i3-13100", 119.98999999999999 },
                    { 88, 2, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Процесор робочої станції для серйозних рендер-задач.", "05prozesory.jpg", "AMD Ryzen Threadripper Pro 3975WX", 2499.9899999999998 },
                    { 89, 3, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Серверний/робочий процесор для професійних робочих навантажень.", "05prozesory.jpg", "Intel Xeon W-2295", 1899.99 },
                    { 90, 20, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійний шестиядерний процесор для геймерів та домашніх ПК.", "05prozesory.jpg", "AMD Ryzen 5 5600X", 199.99000000000001 },
                    { 91, 5, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Попереднє покоління флагмана Intel зі сильною одноядерною продуктивністю.", "05prozesory.jpg", "Intel Core i9-12900K", 499.99000000000001 },
                    { 92, 9, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Висока продуктивність у багатопотокових задачах для робочих станцій та ігор.", "05prozesory.jpg", "AMD Ryzen 7 5800X", 279.99000000000001 },
                    { 93, 19, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний процесор для простих офісних задач.", "05prozesory.jpg", "Intel Pentium Gold G6400", 79.989999999999995 },
                    { 94, 20, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бюджетний APU з інтегрованою графікою для економних збірок.", "05prozesory.jpg", "AMD Athlon 3000G", 59.990000000000002 },
                    { 95, 13, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Високий показник продуктивності для геймерів середнього класу.", "05prozesory.jpg", "Intel Core i5-12600K", 249.99000000000001 },
                    { 96, 11, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Чотириядерний процесор для бюджетних ігрових систем.", "05prozesory.jpg", "AMD Ryzen 3 3300X", 129.99000000000001 },
                    { 97, 8, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стабільний варіант для багатозадачності та ігор.", "05prozesory.jpg", "Intel Core i7-12700", 339.99000000000001 },
                    { 98, 7, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Високопродуктивний 12-ядерний процесор для складних задач.", "05prozesory.jpg", "AMD Ryzen 9 5900X", 449.99000000000001 },
                    { 99, 17, 5, "Silver", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний і ефективний чип для ігор без вбудованої графіки.", "05prozesory.jpg", "Intel Core i5-12400F", 179.99000000000001 },
                    { 100, 10, 5, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Попередня генерація Ryzen, все ще актуальна для багатьох задач.", "05prozesory.jpg", "AMD Ryzen 7 2700X", 199.99000000000001 },
                    { 101, 9, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Материнська плата для Intel 13-го покоління з розширеними можливостями розгону.", "06materinskykarty.jpg", "ASUS ROG Strix Z790-E", 399.99000000000001 },
                    { 102, 0, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна плата для платформи AMD AM5 з хорошим набором функцій.", "06materinskykarty.jpg", "MSI MPG B650 Tomahawk", 229.99000000000001 },
                    { 103, 8, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата для Ryzen з підтримкою PCIe 5.0 та швидких інтерфейсів.", "06materinskykarty.jpg", "Gigabyte X670 Aorus Elite", 279.99000000000001 },
                    { 104, 14, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Компактна micro-ATX плата для бюджетних збірок на Intel.", "06materinskykarty.jpg", "ASRock B660M Pro RS", 119.98999999999999 },
                    { 105, 13, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Збалансована плата для Ryzen з вбудованим охолодженням VRM.", "06materinskykarty.jpg", "ASUS TUF Gaming B550-PLUS", 159.99000000000001 },
                    { 106, 7, 6, "Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата для Intel з хорошою якістю збірки і портами.", "06materinskykarty.jpg", "MSI MAG Z690 Tomahawk", 249.99000000000001 },
                    { 107, 18, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бюджетна плата для старіших поколінь Ryzen.", "06materinskykarty.jpg", "Gigabyte B450 Aorus M", 89.989999999999995 },
                    { 108, 11, 6, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стабільна плата для робочих та ігрових збірок.", "06materinskykarty.jpg", "ASUS Prime Z690-P", 199.99000000000001 },
                    { 109, 2, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум плата для ентузіастів з топовими можливостями.", "06materinskykarty.jpg", "MSI MEG X570 GODLIKE", 899.99000000000001 },
                    { 110, 4, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата для високопродуктивних платформ під великий кількість ліній PCIe.", "06materinskykarty.jpg", "ASRock X299 Taichi", 329.99000000000001 },
                    { 111, 6, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата з фокусом на розгін та стабільність для Intel.", "06materinskykarty.jpg", "Gigabyte Z590 Aorus Master", 319.99000000000001 },
                    { 112, 3, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум рішення для ентузіастів та розгінщиків.", "06materinskykarty.jpg", "ASUS ROG Maximus Z790 Hero", 599.99000000000001 },
                    { 113, 15, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стабільна плата для бюджетних та середніх збірок на AMD.", "06materinskykarty.jpg", "MSI B550-A Pro", 129.99000000000001 },
                    { 114, 12, 6, "Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Хороший набір портів та надійна конструкція для Intel.", "06materinskykarty.jpg", "ASRock B660 Steel Legend", 139.99000000000001 },
                    { 115, 2, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата для Threadripper з великою кількістю ліній та портів.", "06materinskykarty.jpg", "Gigabyte TRX40 Aorus Master", 749.99000000000001 },
                    { 116, 16, 6, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Практична micro-ATX плата з базовими функціями.", "06materinskykarty.jpg", "ASUS Prime B660M-A", 109.98999999999999 },
                    { 117, 9, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата для нових Ryzen із сучасними інтерфейсами.", "06materinskykarty.jpg", "MSI X670 Pro", 279.99000000000001 },
                    { 118, 14, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна плата для 11-го/12-го покоління Intel.", "06materinskykarty.jpg", "ASRock B560 Steel Legend", 119.98999999999999 },
                    { 119, 20, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступна материнська плата для бюджетних збірок Intel.", "06materinskykarty.jpg", "Gigabyte H610M S2H", 69.989999999999995 },
                    { 120, 4, 6, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Плата для ентузіастів AMD з усіма сучасними функціями.", "06materinskykarty.jpg", "ASUS ROG Crosshair X670E Hero", 499.99000000000001 },
                    { 121, 20, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна DDR4 пам'ять для геймерів і робочих станцій.", "07operatyvnapamiat.jpg", "Corsair Vengeance LPX 16GB (2x8) DDR4-3200", 74.989999999999995 },
                    { 122, 0, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Високопродуктивна DDR5 пам'ять з RGB підсвічуванням.", "07operatyvnapamiat.jpg", "G.SKILL Trident Z5 RGB 32GB (2x16) DDR5-6000", 279.99000000000001 },
                    { 123, 18, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Оптимальне рішення для ігрових та домашніх ПК.", "07operatyvnapamiat.jpg", "Kingston FURY Beast 16GB DDR4-3200", 69.989999999999995 },
                    { 124, 9, 7, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Пам'ять з гарним розгінним потенціалом та стабільністю.", "07operatyvnapamiat.jpg", "Crucial Ballistix 32GB (2x16) DDR4-3600", 149.99000000000001 },
                    { 125, 4, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум DDR5 модулі з високими частотами та RGB.", "07operatyvnapamiat.jpg", "Corsair Dominator Platinum RGB 32GB DDR5", 459.99000000000001 },
                    { 126, 15, 7, "Gunmetal", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійні модулі з хорошим співвідношенням ціни та якості.", "07operatyvnapamiat.jpg", "Patriot Viper Steel 16GB DDR4-3200", 64.989999999999995 },
                    { 127, 17, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Пам'ять з ефектним RGB та стабільною роботою.", "07operatyvnapamiat.jpg", "TEAMGROUP T-Force Delta RGB 16GB DDR4", 59.990000000000002 },
                    { 128, 20, 7, "Green PCB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "ОЕМ модули Samsung — надійність та сумісність.", "07operatyvnapamiat.jpg", "Samsung OEM DDR4 8GB 2666MHz", 34.990000000000002 },
                    { 129, 13, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярна серія з фокусом на ігрову продуктивність.", "07operatyvnapamiat.jpg", "G.SKILL Ripjaws V 16GB DDR4-3600", 89.989999999999995 },
                    { 130, 7, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "DDR5 модулі з низькою затримкою та високою частотою.", "07operatyvnapamiat.jpg", "Kingston FURY Renegade 32GB DDR5-5200", 239.99000000000001 },
                    { 131, 19, 7, "Green PCB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна та доступна оперативна пам'ять для щоденних задач.", "07operatyvnapamiat.jpg", "Crucial 16GB DDR4-3200", 59.990000000000002 },
                    { 132, 10, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Пам'ять з ARGB та високою продуктивністю для геймерів.", "07operatyvnapamiat.jpg", "TEAMGROUP T-Force Xtreem ARGB 16GB DDR4-3600", 99.989999999999995 },
                    { 133, 8, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Відомі модулі з RGB та стабільною роботою під навантаженням.", "07operatyvnapamiat.jpg", "Corsair Vengeance RGB Pro 32GB DDR4", 179.99000000000001 },
                    { 134, 14, 7, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Яскраві RGB модули з хорошим тепловідведенням.", "07operatyvnapamiat.jpg", "ADATA XPG Spectrix D60G 16GB DDR4", 89.989999999999995 },
                    { 135, 6, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Великий комплект пам'яті для багатозадачності та ігор.", "07operatyvnapamiat.jpg", "Patriot Viper Steel RGB 32GB DDR4", 169.99000000000001 },
                    { 136, 20, 7, "Green PCB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Економічні модулі для апгрейду старих систем.", "07operatyvnapamiat.jpg", "Kingston ValueRAM 8GB DDR4-2400", 29.989999999999998 },
                    { 137, 7, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Оптимізовані для платформ AMD Ryzen.", "07operatyvnapamiat.jpg", "G.SKILL Trident Z Neo 32GB DDR4", 159.99000000000001 },
                    { 138, 12, 7, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стильні модули з RGB та компактним радіатором.", "07operatyvnapamiat.jpg", "Corsair Vengeance RGB SL 16GB DDR4", 84.989999999999995 },
                    { 139, 15, 7, "Green PCB", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний набір оперативної пам'яті для щоденних задач.", "07operatyvnapamiat.jpg", "Patriot Signature 16GB DDR4-3200", 54.990000000000002 },
                    { 140, 11, 7, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Пам'ять з ефектним ARGB освітленням для геймерського ПК.", "07operatyvnapamiat.jpg", "TEAMGROUP T-Force Delta RGB DDR4 32GB", 149.99000000000001 },
                    { 141, 20, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Швидкий NVMe SSD з відмінним співвідношенням продуктивності та ціни.", "08ssd.jpg", "Samsung 970 EVO Plus 1TB (NVMe)", 129.99000000000001 },
                    { 142, 0, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Високошвидкісний NVMe для ігрових систем та творчої роботи.", "08ssd.jpg", "WD Black SN850 1TB (NVMe)", 149.99000000000001 },
                    { 143, 18, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійний NVMe SSD для апгрейду ноутбуків і ПК.", "08ssd.jpg", "Crucial P5 Plus 1TB (NVMe)", 119.98999999999999 },
                    { 144, 14, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "SATA SSD з перевіреною надійністю і стабільною швидкістю.", "08ssd.jpg", "Samsung 860 EVO 1TB (SATA)", 89.989999999999995 },
                    { 145, 12, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "NVMe високої продуктивності для вимогливих задач.", "08ssd.jpg", "Kingston KC3000 1TB (NVMe)", 139.99000000000001 },
                    { 146, 8, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Преміум NVMe SSD з високою довговічністю та швидкостями.", "08ssd.jpg", "Seagate FireCuda 530 1TB (NVMe)", 179.99000000000001 },
                    { 147, 19, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний NVMe SSD для щоденних завдань та апгрейду.", "08ssd.jpg", "Western Digital Blue SN570 1TB", 79.989999999999995 },
                    { 148, 7, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Великий об'єм за помірну ціну для зберігання даних.", "08ssd.jpg", "Sabrent Rocket Q 2TB (NVMe QLC)", 199.99000000000001 },
                    { 149, 15, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярний NVMe SSD з хорошою продуктивністю за ціну.", "08ssd.jpg", "ADATA XPG SX8200 Pro 1TB", 99.989999999999995 },
                    { 150, 17, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійний SATA SSD з відмінною стійкістю і швидкістю читання/запису.", "08ssd.jpg", "Crucial MX500 1TB (SATA)", 84.989999999999995 },
                    { 151, 11, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "NVMe високого класу для рендерингу та ігор.", "08ssd.jpg", "Samsung 980 Pro 1TB (NVMe)", 159.99000000000001 },
                    { 152, 13, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Оптимальне рішення для зберігання великих масивів даних.", "08ssd.jpg", "Intel 670p 1TB NVMe", 109.98999999999999 },
                    { 153, 16, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний NVMe SSD для апгрейду ноутбуків та ПК.", "08ssd.jpg", "Kingston A2000 1TB NVMe", 89.989999999999995 },
                    { 154, 20, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Гібридний диск для великого об'єму з прискоренням через кеш.", "08ssd.jpg", "Seagate Barracuda 2TB HDD (Hybrid)", 69.989999999999995 },
                    { 155, 12, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний великий об'єм з використанням QLC-технології.", "08ssd.jpg", "SAMSUNG 870 QVO 1TB (SATA QLC)", 79.989999999999995 },
                    { 156, 9, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Швидкий NVMe для ігор з хорошим тепловидаленням.", "08ssd.jpg", "Western Digital Black SN770 1TB", 119.98999999999999 },
                    { 157, 10, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Великий NVMe за доступну ціну для зберігання ігор та файлів.", "08ssd.jpg", "Crucial P3 2TB NVMe", 129.99000000000001 },
                    { 158, 6, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Один з найшвидших NVMe накопичувачів для професійних задач.", "08ssd.jpg", "Sabrent Rocket 4 Plus 1TB", 229.99000000000001 },
                    { 159, 18, 8, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бюджетний NVMe SSD для швидкого апгрейду старих систем.", "08ssd.jpg", "Kingston NV1 500GB NVMe", 44.990000000000002 },
                    { 160, 20, 8, "Green", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Економічний SATA SSD для ОС та базових програм.", "08ssd.jpg", "Western Digital Green 240GB SSD (SATA)", 34.990000000000002 },
                    { 161, 20, 9, "Graphite", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Професійна бездротова миша з ергономікою для тривалих робочих сесій.", "09peryfyria.jpg", "Logitech MX Master 3", 99.989999999999995 },
                    { 162, 0, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярна ігрова миша з точним сенсором і комфортною формою.", "09peryfyria.jpg", "Razer DeathAdder V2", 59.990000000000002 },
                    { 163, 12, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Механічна клавіатура з RGB підсвічуванням та надійними перемикачами.", "09peryfyria.jpg", "Corsair K70 RGB MK.2", 159.99000000000001 },
                    { 164, 10, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бездротова ігрова гарнітура з комфортною посадкою та чистим звуком.", "09peryfyria.jpg", "SteelSeries Arctis 7", 149.99000000000001 },
                    { 165, 11, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Про-клавіатура для кіберспортивних геймерів з модульними перемикачами.", "09peryfyria.jpg", "Logitech G Pro X Keyboard", 129.99000000000001 },
                    { 166, 9, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Контролер для стримерів з програмованими макросами та кнопками.", "09peryfyria.jpg", "Elgato Stream Deck MK.2", 149.99000000000001 },
                    { 167, 17, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна вебкамера для відеодзвінків та стрімінгу в 1080p.", "09peryfyria.jpg", "Logitech C920 HD Pro Webcam", 69.989999999999995 },
                    { 168, 6, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бездротова механічна клавіатура з розширеними функціями для геймерів.", "09peryfyria.jpg", "Razer BlackWidow V3 Pro", 199.99000000000001 },
                    { 169, 13, 9, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Компактна клавіатура Apple з чудовою збіркою та сумісністю.", "09peryfyria.jpg", "Apple Magic Keyboard", 99.0 },
                    { 170, 8, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Ергономічна клавіатура для зниження навантаження на зап’ястя.", "09peryfyria.jpg", "Microsoft Sculpt Ergonomic Keyboard", 129.99000000000001 },
                    { 171, 15, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Надійна механічна клавіатура з алюмінієвою рамкою.", "09peryfyria.jpg", "HyperX Alloy Origins", 119.98999999999999 },
                    { 172, 7, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Тонка бездротова механічна клавіатура преміум класу.", "09peryfyria.jpg", "Logitech G915 TKL", 229.99000000000001 },
                    { 173, 20, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярний тканинний килимок для миші з хорошою точністю.", "09peryfyria.jpg", "SteelSeries QcK Mousepad", 19.989999999999998 },
                    { 174, 16, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступна гарнітура з 7.1 симульованим звуком для ігор.", "09peryfyria.jpg", "Logitech G432 7.1", 59.990000000000002 },
                    { 175, 4, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Аксесуар/монітор для кіберспорту з високою частотою оновлення.", "09peryfyria.jpg", "BenQ ZOWIE XL2546K (eSports monitor accessory)", 499.99000000000001 },
                    { 176, 6, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Механічна клавіатура з оптико-механічними перемикачами та RGB.", "09peryfyria.jpg", "Razer Huntsman Elite", 189.99000000000001 },
                    { 177, 19, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Провідна ігрова миша з високотомним сенсором та кількома регульованими вагами.", "09peryfyria.jpg", "Logitech G502 HERO", 49.990000000000002 },
                    { 178, 10, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Популярний USB-мікрофон для стрімінгу та запису подкастів.", "09peryfyria.jpg", "Blue Yeti USB Microphone", 129.99000000000001 },
                    { 179, 9, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Студійний USB мікрофон зі вбудованим софтом контролю.", "09peryfyria.jpg", "Elgato Wave:3", 149.99000000000001 },
                    { 180, 5, 9, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Вебкамера високої якості для професійних відеоконференцій.", "09peryfyria.jpg", "Logitech Brio 4K", 199.99000000000001 },
                    { 181, 7, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Комплексне мережеве рішення: роутер, контролер та безпека в одному корпусі.", "10meregeve.png", "Ubiquiti UniFi Dream Machine Pro", 349.99000000000001 },
                    { 182, 0, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужний домашній роутер з підтримкою WiFi 6 та великою пропускною здатністю.", "10meregeve.png", "Netgear Nighthawk RAX200 (WiFi 6)", 399.99000000000001 },
                    { 183, 12, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "WiFi 6 роутер з хорошим покриттям і безліччю портів.", "10meregeve.png", "TP-Link Archer AX6000", 279.99000000000001 },
                    { 184, 8, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужний роутер для геймерів і домашніх мереж з високою стабільністю.", "10meregeve.png", "ASUS RT-AX88U", 299.99000000000001 },
                    { 185, 20, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Компактний проводовий роутер/маршрутизатор для малих мереж та офісів.", "10meregeve.png", "MikroTik hEX RB750Gr3", 59.990000000000002 },
                    { 186, 3, 10, "Gray", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Корпоративний мережевий комутатор з розширеними можливостями управління.", "10meregeve.png", "Cisco Catalyst 2960-L (Enterprise switch)", 899.99000000000001 },
                    { 187, 25, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Простий 8-портовий гігабітний комутатор для домашніх та малих офісів.", "10meregeve.png", "TP-Link TL-SG108 (8-port Gigabit switch)", 24.989999999999998 },
                    { 188, 4, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mesh-система для великого будинку з стабільним покриттям та високою швидкістю.", "10meregeve.png", "Netgear Orbi RBK852 (Mesh WiFi 6)", 999.99000000000001 },
                    { 189, 6, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужний маршрутизатор з професійними можливостями конфігурації.", "10meregeve.png", "Ubiquiti EdgeRouter ER-4", 199.99000000000001 },
                    { 190, 7, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Роутер із хорошим набором функцій для мережевого зберігання та VPN.", "10meregeve.png", "Synology RT2600ac", 199.99000000000001 },
                    { 191, 18, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Доступний WiFi 6 роутер для домашнього використання.", "10meregeve.png", "TP-Link Archer AX20", 79.989999999999995 },
                    { 192, 5, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Хмарний маршрутизатор/гейтвей для малого бізнесу з простим управлінням.", "10meregeve.png", "Cisco Meraki Go GR10", 199.99000000000001 },
                    { 193, 6, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Комутатор з SFP+ портами для швидких корпоративних зв'язків.", "10meregeve.png", "MikroTik CRS326-24G-2S+RM", 399.99000000000001 },
                    { 194, 22, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Простий 8-портовий unmanaged гігабітний комутатор.", "10meregeve.png", "Netgear GS308 (Unmanaged switch)", 29.989999999999998 },
                    { 195, 10, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Точка доступу WiFi 6 для великих площ та стабільного сигналу.", "10meregeve.png", "Ubiquiti UniFi 6 Long-Range Access Point", 179.99000000000001 },
                    { 196, 13, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mesh-пакет для покриття будинку з простим налаштуванням.", "10meregeve.png", "TP-Link Deco M5 (Mesh kit)", 149.99000000000001 },
                    { 197, 9, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Стильний роутер з хорошими функціональними можливостями та дизайном.", "10meregeve.png", "ASUS Blue Cave AC2600", 159.99000000000001 },
                    { 198, 11, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Потужний роутер для офісних задач та складних мережевих конфігурацій.", "10meregeve.png", "MikroTik RB4011", 199.99000000000001 },
                    { 199, 6, 10, "White", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mesh-система з WiFi 6 для стабільного покриття великої оселі.", "10meregeve.png", "Linksys Velop AX4200 Mesh", 349.99000000000001 },
                    { 200, 20, 10, "Black", new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Бюджетний двохдіапазонний роутер для домашнього використання.", "10meregeve.png", "Netis WF2780 (AC1200) Router", 39.990000000000002 }
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
