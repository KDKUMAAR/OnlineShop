using Microsoft.AspNetCore.Mvc;
using OnlineShop.Data.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineShop.Controllers.Cart
{
    public class CartController : Controller
    {
        private readonly IProductRepository _productRepository;
        public CartController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CartDetail(int id)
        {
            ViewBag.Product = _productRepository.GetProduct(id);
            return View("Cart");
        }
    }
}
