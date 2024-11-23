using Microsoft.AspNetCore.Mvc;
using UTB.Eshop24.Application.Abstraction;
using UTB.Eshop24.Domain.Entities;

namespace UTB.Eshop24_komb.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            IList<Product> products = _productService.GetAll();
            return View(products);
        }


        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        {
            _productService.Create(product);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            if (_productService.Delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            return NotFound();
        }
    }
}
