using CampingApp.Mvc.extensions;
using CampingApp.Mvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace CampingApp.Mvc.ViewComponents
{
    public class BasketLinkViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var productCollection = HttpContext.Session.GetJson<ProductCollectionCart>("basket");
            return View(productCollection);
        }
    }
}
