using Microsoft.AspNetCore.Mvc;

namespace RateWiseEg.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Signup()
        {
            return View();
        }

        public IActionResult SignupForm()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        public IActionResult CodeEntering()
        {
            return View();
        }

        public IActionResult ResetPassword()
        {
            return View();
        }
    }
}
