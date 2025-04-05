using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases.Repositories
{
    public interface IProductRepository
    {
        Product Add(Product product);
        List<Product> GetAll();
    }
}
