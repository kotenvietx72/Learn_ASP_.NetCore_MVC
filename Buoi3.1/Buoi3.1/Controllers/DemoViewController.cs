using Microsoft.AspNetCore.Mvc;

namespace Buoi3._1.Controllers
{
    public class DemoViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TestHTMLHelper()
        {
            return View();
        }
    }
}
