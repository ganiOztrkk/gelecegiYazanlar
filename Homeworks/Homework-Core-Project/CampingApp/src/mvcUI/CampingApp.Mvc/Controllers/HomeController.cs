using CampingApp.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CampingApp.Services;

namespace CampingApp.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        public IActionResult Index(int pageNo = 1, int? id = null)
        {
            var products = id == null ?  _productService.GetProductDisplayResponses() : 
                                                                        _productService.GetProductByCategory(id.Value);

            const int productPerPage = 8;
            var totalProduct = products.Count();

            var pagingInfo = new PagingInfo()
            {
                CurrentPage = pageNo,
                ItemsPerPage = productPerPage,
                TotalItems = totalProduct
            };

            var paginatedProducts = products.OrderBy(_ => _.ProductID)
                                                                      .Skip((pageNo - 1) * productPerPage)
                                                                      .Take(productPerPage)
                                                                      .ToList();
            var model = new PaginationProductViewModel()
            {
                Products = paginatedProducts,
                PagingInfo = pagingInfo
            };

            return View(model);
        }
    }
}