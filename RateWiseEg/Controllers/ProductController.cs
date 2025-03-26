using Microsoft.AspNetCore.Mvc;

namespace RateWiseEg.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Listing()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
