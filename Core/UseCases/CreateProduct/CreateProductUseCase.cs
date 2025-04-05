using Core.Entities;
using Core.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases.CreateProduct
{
    public class CreateProductUseCase : ICreateProductUseCase
    {
        private readonly IProductRepository _productRepository;

        public CreateProductUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public CreateProductResponse Execute(CreateProductRequest request)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price
            };

            _productRepository.Add(product);
            return new CreateProductResponse { ProductId = product.Id };
        }
    }
}
