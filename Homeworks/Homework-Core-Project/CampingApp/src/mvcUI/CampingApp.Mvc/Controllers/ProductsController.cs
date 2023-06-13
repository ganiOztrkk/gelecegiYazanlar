using CampingApp.DataTransferObjects.requests;
using CampingApp.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace CampingApp.Mvc.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetProductDisplayResponses();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = GetCategoriesForSelectList();
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateNewProductRequestDto request)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateProductAsync(request);
                return RedirectToAction("Index");
            }
            ViewBag.Categories = GetCategoriesForSelectList();
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var product = await _productService.GetProductForUpdateAsync(id);
            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(int id, UpdateProductRequestDto updateProduct)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateProductAsync(updateProduct);
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var deletingProduct = await _productService.GetProductByIdAsync(id);
            await _productService.DeleteProductAsync(deletingProduct);
            return RedirectToAction("Index");
        }
















        private IEnumerable<SelectListItem> GetCategoriesForSelectList()
        {
            var categoryList = _categoryService.GetCategoryDisplayResponses().Select(c => new SelectListItem
            {
                Text = c.CategoryName,
                Value = c.CategoryID.ToString()
            });
            return categoryList;
        }
    }
}
