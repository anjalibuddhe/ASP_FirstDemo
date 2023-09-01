using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult StudentData()
        {
            List<Student> students = new List<Student>()
            {
               new Student {Id=1,Name="Sara",Course="PHP",Duration="6 months" },
               new Student {Id=2,Name="Hari",Course="Java",Duration="5 months" },
               new Student {Id=3,Name="John", Course="Angular",Duration="3 months"},
               new Student {Id=4,Name="Sita", Course="React",Duration="3 months"},
            };
            ViewData["list"] = students;
            return View();
        }
    }
}
