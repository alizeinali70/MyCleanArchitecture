using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.UseCases.GetProducts
{
    public class GetProductsResponse
    {
        public List<Product> Products { get; set; }
    }
}
