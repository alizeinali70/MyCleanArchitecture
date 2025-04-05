using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases.CreateProduct
{
    public interface ICreateProductUseCase
    {
        CreateProductResponse Execute(CreateProductRequest request);
    }
}
