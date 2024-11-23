using Microsoft.AspNetCore.Mvc;
using Moq;
using UTB.Eshop24.Application.Abstraction;
using UTB.Eshop24.Domain.Entities;
using UTB.Eshop24_komb.Web.Areas.Admin.Controllers;

namespace UTB.Eshop24.Tests
{
    public class ProductControllerTests
    {
        [Fact]
        public void CreatePositive()
        {
            //arrange
            Mock<IProductService> service = new Mock<IProductService>();
            service.Setup(productService => productService.Create(It.IsAny<Product>())).Callback(() => { return; });

            IProductService prodService = service.Object;
            var prodController = new ProductController(prodService);

            Product prod = new Product();

            //act
            IActionResult result = prodController.Create(prod);

            //assert
            var redirectToActionResult = Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal(nameof(ProductController.Index), redirectToActionResult.ActionName);
        }


        [Fact]
        public void CreateNegative()
        {
            //arrange
            Mock<IProductService> service = new Mock<IProductService>();
            service.Setup(productService => productService.Create(It.IsAny<Product>())).Callback(() => { return; });

            IProductService prodService = service.Object;
            var prodController = new ProductController(prodService);

            Product prod = new Product();

            prodController.ModelState.AddModelError(nameof(Product.Name), "The Name field is required.");

            //act
            IActionResult result = prodController.Create(prod);

            //assert
            var viewResult = Assert.IsType<ViewResult>(result);
            Assert.IsType<Product>(viewResult.Model);
        }
    }
}