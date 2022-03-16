using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Repos;
using OnlineShop.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers.Product
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;
        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            var productList = _productRepository.GetProducts();
            ViewBag.Products = productList;
            return View("ProductList");
        }
    }
}
