using OnlineShop.Data.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repos
{
    public interface IProductRepository
    {
        List<ProductEntity> GetProducts();

        ProductEntity GetProduct(int productId);
    }
}
