using Microsoft.AspNetCore.Mvc;

namespace Bai3.Controllers
{
    public class Bai2Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult yc1()
        {
            return View();
        }
        public IActionResult Yeucau1(int a)
        {
            ViewBag.a = a;
            return View();
        }
        public IActionResult yc2()
        {
            return View();
        }
        public IActionResult Yeucau2(int a)
        {
            ViewBag.a = a;
            return View();
        }
    }
}
