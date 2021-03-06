using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CleanArchMvc.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchMvc.WebUI.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;    
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}