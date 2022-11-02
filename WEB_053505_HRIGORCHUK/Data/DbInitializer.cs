using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using WEB_053505_HRIGORCHUK.Entities;

namespace WEB_053505_HRIGORCHUK.Data
{
    public class DbInitializer
    {
        public static async Task Seed(ApplicationDbContext context,
        UserManager<ApplicationUser> userManager,
        RoleManager<IdentityRole> roleManager)
        {
            // создать БД, если она еще не создана
            context.Database.EnsureCreated();
            // проверка наличия ролей
            if (!context.Roles.Any())
            {
                var roleAdmin = new IdentityRole
                {
                    Name = "admin",
                    NormalizedName = "admin"
                };
                // создать роль admin
                await roleManager.CreateAsync(roleAdmin);
            }
            // проверка наличия пользователей
            if (!context.Users.Any())
            {
                // создать пользователя user@mail.ru
                var user = new ApplicationUser
                {
                    Email = "user@mail.ru",
                    UserName = "user@mail.ru"
                };
                await userManager.CreateAsync(user, "123456");
                // создать пользователя admin@mail.ru
                var admin = new ApplicationUser
                {
                    Email = "admin@mail.ru",
                    UserName = "admin@mail.ru"
                };
                await userManager.CreateAsync(admin, "123456");
                // назначить роль admin
                admin = await userManager.FindByEmailAsync("admin@mail.ru");
                await userManager.AddToRoleAsync(admin, "admin");
            }
            //проверка наличия групп объектов
            /*if (!context.ProductGroups.Any())
            {
                context.ProductGroups.AddRange(
                new List<ProductGroup>
                {
                    new ProductGroup {ProductGroupId=1, GroupName="Биты"},
                    new ProductGroup {ProductGroupId=2, GroupName="Мячи"},
                    new ProductGroup {ProductGroupId=3, GroupName="Чешки"},
                    new ProductGroup {ProductGroupId=4, GroupName="Велосипеды"},
                });
                await context.SaveChangesAsync();
            }
            // проверка наличия объектов
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new List<Product>
                {
                    new Product {ProductId = 1, ProductName="Бита-ударник",
                    Description="Ударяет больно", ProductGroupId=1, Image="1.png" },
                    new Product {ProductId = 2, ProductName="Бита-приёмник",
                    Description="Принимает хорошо", ProductGroupId=1, Image="2.jpg" },
                    new Product {ProductId = 3, ProductName="Мяч-скакун",
                    Description="Скачет", ProductGroupId=2, Image="3.jpg" },
                    new Product {ProductId = 4, ProductName="Мяч-прыгун",
                    Description="Прыгает", ProductGroupId=2, Image="4.jpg" },
                    new Product {ProductId = 5, ProductName="Чешки из Чехии",
                    Description="Само совершенство", ProductGroupId=3, Image="5.jpg" },
                    new Product {ProductId = 6, ProductName="Чешки из Китая",
                    Description="Хуже не придумаешь", ProductGroupId=3, Image="6.jpg" },
                    new Product {ProductId = 7, ProductName="Велосипед-Аист",
                    Description="Можно залететь", ProductGroupId=4, Image="7.jpg" },
                    new Product {ProductId = 8, ProductName="Велосипед-горник",
                    Description="Для медведей на велосипеде", ProductGroupId=4, Image="8.jpg" },

                });
                await context.SaveChangesAsync();
            }*/
        }
    }
}
