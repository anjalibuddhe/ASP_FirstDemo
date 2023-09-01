using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;



namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee emp)
        {
            return View();
        }
    }
}
