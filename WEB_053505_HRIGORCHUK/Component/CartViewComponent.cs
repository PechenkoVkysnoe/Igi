using Microsoft.AspNetCore.Mvc;

namespace WEB_053505_HRIGORCHUK.Component
{
    public class CartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
