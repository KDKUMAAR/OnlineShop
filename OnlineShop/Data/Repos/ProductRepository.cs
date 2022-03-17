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

        public ProductEntity GetProduct(int productId)
        {
            return _dbContext.Products.FirstOrDefault(x => x.Id == productId);
        }

        public List<ProductEntity> GetProducts()
        {
            return _dbContext.Products.ToList();
        }
    }
}
