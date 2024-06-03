using Kurohtin.UI.Services.ProductService;
using Microsoft.AspNetCore.Mvc;

namespace Kurohtin.UI.Controllers
{
    public class ProductController(IProductService categoryService,IProductService productService) : Controller
    {
        public async Task<IActionResult> Index()
        {
            var productResponse =
            await productService.GetProductListAsync(null);
            if (!productResponse.Success)
            return NotFound(productResponse.ErrorMessage);
            return View(productResponse.Data.Items);
        }
    }
}
