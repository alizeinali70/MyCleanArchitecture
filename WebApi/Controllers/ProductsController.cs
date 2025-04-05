using Core.UseCases.CreateProduct;
using Core.UseCases.GetProducts;
using Microsoft.AspNetCore.Mvc;
using WebApi.Models;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly ICreateProductUseCase _createProductUseCase;
        private readonly IGetProductsUseCase _getProductsUseCase;

        public ProductsController(ICreateProductUseCase createProductUseCase, IGetProductsUseCase getProductsUseCase)
        {
            _createProductUseCase = createProductUseCase;
            _getProductsUseCase = getProductsUseCase;
        }

        [HttpPost]
        public IActionResult CreateProduct(ProductDto productDto)
        {
            var request = new CreateProductRequest { Name = productDto.Name, Price = productDto.Price };
            var response = _createProductUseCase.Execute(request);
            return CreatedAtAction(nameof(GetProducts), new { id = response.ProductId }, response);
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var response = _getProductsUseCase.Execute();
            return Ok(response.Products);
        }
    }
}

