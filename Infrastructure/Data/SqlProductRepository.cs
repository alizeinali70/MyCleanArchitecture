using Core.Entities;
using Core.UseCases.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class SqlProductRepository : IProductRepository
    {
        private readonly AppDbContext _context;

        public SqlProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public Product Add(Product product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        public List<Product> GetAll()
        {
            return _context.Products.ToList();
        }
    }
}
