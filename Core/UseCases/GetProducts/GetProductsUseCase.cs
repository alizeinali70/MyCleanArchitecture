using Core.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases.GetProducts
{
    public class GetProductsUseCase : IGetProductsUseCase
    {
        private readonly IProductRepository _productRepository;

        public GetProductsUseCase(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public GetProductsResponse Execute()
        {
            var products = _productRepository.GetAll();
            return new GetProductsResponse { Products = products };
        }
    }
}
