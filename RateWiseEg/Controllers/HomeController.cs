using Microsoft.AspNetCore.Mvc;
using RateWiseEg.Models;
using System.Diagnostics;

namespace RateWiseEg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Landing()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Services()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        public IActionResult MoneyRates()
        {
            return View();
        }

        public IActionResult TermsOfServices()
        {
            return View();
        }

        public IActionResult Legal()
        {
            return View();
        }

        public IActionResult PrivacyPolicy()
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
