using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WEB_053505_HRIGORCHUK.Data;
using WEB_053505_HRIGORCHUK.Extention;
using WEB_053505_HRIGORCHUK.Models;

namespace WEB_053505_HRIGORCHUK.Controllers
{
    public class CartController : Controller
    {
        private ApplicationDbContext _context;
        private Cart _cart;
        public CartController(ApplicationDbContext context, Cart cart)
        {
            _context = context;
            _cart = cart;
        }
        public IActionResult Index()
        {
            return View(_cart.Items.Values);
        }
        [Authorize]
        public IActionResult Add(int id, string returnUrl)
        {
            var item = _context.Product.Find(id);
            if (item != null)
            {
                _cart.AddToCart(item);
            }
            return Redirect(returnUrl);
        }

        public IActionResult Delete(int id)
        {
            _cart.RemoveFromCart(id);
            return RedirectToAction("Index");
        }
    }
}
