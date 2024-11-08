using Microsoft.AspNetCore.Mvc;

namespace Bai1.Controllers
{
    public class Bai1Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GiaiPTB2(int x, int y, int z)
        {
            ViewBag.x = x ; ViewBag.y = y; ViewBag.z = z ;
            return View();
        }

    }
}
