using OnlineShop.Data.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repos
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppContext _dbContext;
        public ProductRepository(AppContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<ProductEntity> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
