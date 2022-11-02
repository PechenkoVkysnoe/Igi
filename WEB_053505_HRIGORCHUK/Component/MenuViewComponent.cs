using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using WEB_053505_HRIGORCHUK.Models;

namespace WEB_053505_HRIGORCHUK.Component
{
    public class MenuViewComponent : ViewComponent
    {
        private List<MenuItem> _menu = new List<MenuItem>
        {
            new MenuItem{ Controller="Home", Action="Index", Text="Lab 3"},
            new MenuItem{ Controller="Product", Action="Index", Text="Каталог"},
            new MenuItem{ IsPage=true, Area="Admin", Page="/Index", Text="Администратор"}
        };

        public IViewComponentResult Invoke()
        {
            var controller = ViewContext.RouteData.Values["controller"];
            var page = ViewContext.RouteData.Values["page"];
            var area = ViewContext.RouteData.Values["area"];
            foreach (var item in _menu)
            {
                var _matchController = controller?.Equals(item.Controller) ?? false;
                var _matchArea = area?.Equals(item.Area) ?? false;
                if (_matchController || _matchArea)
                {
                    item.Active = "active";
                }
            }
            return View(_menu);
        }
    }
}
