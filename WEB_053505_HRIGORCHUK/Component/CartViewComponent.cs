using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEB_053505_HRIGORCHUK.Extention;
using WEB_053505_HRIGORCHUK.Models;

namespace WEB_053505_HRIGORCHUK.Component
{
    public class CartViewComponent : ViewComponent
    {
        private Cart _cart;
        public CartViewComponent(Cart cart)
        {
            _cart = cart;
        }
        public IViewComponentResult Invoke()
        {
            return View(_cart);
        }
    }
}
