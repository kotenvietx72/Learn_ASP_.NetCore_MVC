using Buoi4_1.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buoi4_1.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult DangNhap()
        {
            return View();
        }
        public IActionResult DangNhap_1(Login x)
        {
            if (x.UserName == "admin" && x.Password == "admin")
            {
                return View();
            }
            else
            {
                TempData["Error"] = "Thông tin đăng nhập chưa chính xác";
                return RedirectToAction("DangNhap");
            }
        }
    }
}
