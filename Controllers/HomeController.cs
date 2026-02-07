using System.Diagnostics;
using ManagementPortal.Models;
using Microsoft.AspNetCore.Mvc;

namespace ManagementPortal.Controllers
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
            return View();
        }

        public IActionResult Salary(string name,string position, int hours, int payRate)
        {
            ViewData["Title"] = "Salary Calculator";
            ViewData["Message"] = "Salary calculator for employee: " + name;
            ViewData["Position"] = position;
            ViewData["Hours"] = hours;
            ViewData["PayRate"] = payRate;

            return View();
        }

        public IActionResult Privacy()
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
