using Microsoft.AspNetCore.Mvc;
using WebApplication8.Models;
using WebApplication8.Services;
namespace WebApplication8.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}
