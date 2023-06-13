using System.Text.Json;
using CampingApp.DataTransferObjects.responses;
using CampingApp.Mvc.extensions;
using CampingApp.Mvc.Models;
using CampingApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace CampingApp.Mvc.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IProductService _productService;

        public ShoppingController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var productCollection = GetProductCollectionFromSession();
            return View(productCollection);
        }
        public IActionResult AddProductIntoCart(int id)
        {
            ProductDisplayResponseDto selectedProduct = _productService.GetProduct(id);
            var productItem = new ProductItem
            {
                Product = selectedProduct,
                Quantity = 1
            };
            ProductCollectionCart productCollection = GetProductCollectionFromSession();
            productCollection.AddNewProduct(productItem);
            SaveToSession(productCollection);

            return Json(new { message = $"{selectedProduct.ProductName} Sepete Eklendi." });
        }

        private ProductCollectionCart GetProductCollectionFromSession()
        {
            return HttpContext.Session.GetJson<ProductCollectionCart>("basket") ?? new ProductCollectionCart();
        }

        private void SaveToSession(ProductCollectionCart productCollection)
        {
            HttpContext.Session.SetJson( "basket",productCollection);
        }
    }
}