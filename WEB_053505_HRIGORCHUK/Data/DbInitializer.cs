using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
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
            if (!context.Categories.Any())
            {
                context.Categories.AddRange(
                new List<Category>
                {
                    new Category {CategoryName="Футбольные мячи"},
                    new Category {CategoryName="Велосипеды"},
                    new Category {CategoryName="Биты"},
                    new Category {CategoryName="Гантели"}
                });
                await context.SaveChangesAsync();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                new List<Product>
                {
                    new Product{ ProductName="Скок", Description="Делает только скок",
                    Price=7, CategoryId=1, Image="ball2.jpg"},
                    new Product{ ProductName="Прык-скок", Description="Делает прык и скок",
                    Price=19, CategoryId=1, Image="ball2.jpg"},
                    new Product{ ProductName="Прык", Description="Делает прык но не делает скок",
                    Price=9, CategoryId=1, Image="ball3.jpg"},
                    new Product{ ProductName="Мужская гантеля", Description="Для настоящих мужиков",
                    Price=45, CategoryId=4, Image="gant1.jpg"},

                    new Product {ProductName="Бита-ударник",
                    Description="Ударяет больно", CategoryId=3, Price=88, Image="beat1.jpg" },
                    new Product {ProductName="Бита-приёмник",
                    Description="Принимает хорошо", CategoryId=3, Price=99, Image="beat2.jfif" },
                    new Product {ProductName="Велосипед-Аист",
                    Description="Можно залететь",CategoryId=2, Price=425, Image="cycle1.jpg" },
                    new Product {ProductName="Велосипед-горник",
                    Description="Для медведей на велосипеде", CategoryId=2, Price=555, Image="cycle2.png" },

                });
                await context.SaveChangesAsync();
            }
        }
    }
}
