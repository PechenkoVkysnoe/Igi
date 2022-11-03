using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WEB_053505_HRIGORCHUK.Entities;
using WEB_053505_HRIGORCHUK.Models;

namespace WEB_053505_HRIGORCHUK.Controllers
{
    public class ProductController : Controller
    {
        List<Product> _products;
        List<Category> _categories;
        int _pageSize;
        public ProductController()
        {
            _pageSize = 3;
            SetupData();
        }
        public IActionResult Index(int? group, int pageNo = 1)
        {
            var productsFiltered = _products
            .Where(d => !group.HasValue || d.CategoryId == group.Value);
            // Поместить список групп во ViewData
            ViewData["Groups"] = _categories;

            ViewData["CurrentGroup"] = group ?? 0;
            return View(ListViewModel<Product>.GetModel(productsFiltered,
            pageNo, _pageSize));
        }

        private void SetupData()
        {
            _categories = new List<Category>
            {
                new Category {CategoryId=1, CategoryName="Футбольные мячи"},
                new Category {CategoryId=2, CategoryName="Велосипеды"},
                new Category {CategoryId=3, CategoryName="Биты"},
                new Category {CategoryId=4, CategoryName="Гантели"}
            };

            _products = new List<Product>
            {
                new Product{ ProductId = 1, ProductName="Скок", Description="Делает только скок",
                    Price=7, CategoryId=1, Image="ball2.jpg"},
                new Product{ ProductId = 2, ProductName="Прык-скок", Description="Делает прык и скок", 
                    Price=19, CategoryId=1, Image="ball2.jpg"},
                new Product{ ProductId = 3, ProductName="Прык", Description="Делает прык но не делает скок",
                    Price=9, CategoryId=1, Image="ball3.jpg"},

                new Product{ ProductId = 4, ProductName="Мужская гантеля", Description="Для настоящих мужиков",
                    Price=45, CategoryId=4, Image="gant1.jpg"},

            };
        }
    }
}
