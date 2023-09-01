using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            List<Product> products = new List<Product>()
            {

            new Product { Id = 1, Name = "pen", price = 19.20 },
            new Product { Id = 2, Name = "Mobile", price = 1900.20 },
            new Product { Id = 3, Name = "Laptop", price = 39909.20 },
            new Product { Id = 4, Name = "keybord", price = 249.20 },
            };

            ViewData["list"] = products;
            ViewBag.ProductList = products;
            return View();
        }
    }
}
