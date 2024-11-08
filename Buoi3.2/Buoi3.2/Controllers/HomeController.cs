using Buoi3._2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Buoi3._2.Controllers
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
        public IActionResult Bai1()
        {
            return View();
        }
        public IActionResult Bai1_1(string myList) 
        {
            ViewBag.s = myList;
            return View();
        }
        public IActionResult Bai2()
        {
            return View();
        }
        public IActionResult Bai2_1(int a)
        {
            ViewBag.a = a;
            return View();
        }
        public IActionResult Bai4()
        {
            return View();
        }
        public IActionResult Bai4_1(PTB2 x)
        {
            return View(x);
        }
    }
}
