using Dynamicpage.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Dynamicpage.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public class Person
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public double Salary { get; set; }

            public string Address { get; set; }
        }
        public IActionResult Employee()
        {
            var people = new Person[]
                {
                    new Person{ Name = "Fathima", Age = 30, Salary = 50000, Address = "123 Main St" },
                    new Person{ Name = "Anna George", Age = 25, Salary = 55000, Address = "456 Elm St" },
                    new Person{ Name = "Benny ", Age = 40, Salary = 60000, Address = "789 Oak St" },
                    new Person{ Name = "Alice ", Age = 27, Salary = 55000, Address = "321 Pine St" },
                    new Person{ Name = "Arjun", Age = 35, Salary = 70000, Address = "654 Maple St" },
                };
            ViewBag.People = people;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
