using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "Welcome to Mvc Demo";

            List<string> list=new List<string>()
            {
                "Red",
                "Green",
                "Yellow",
                "Black",
                "White",
                "Pink"

            };
            ViewData["colors"] = list;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}