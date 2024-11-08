using Buoi3._1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Buoi3._1.Controllers
{
    public class GiaiBTController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult TimUCLN()
        {
            return View();
        }
        public IActionResult TimUCLN1(int a, int b)
        {
            ViewBag.a = a; ViewBag.b = b;
            return View();
        }
        public IActionResult MotDT()
        {
            Users user = new Users
            {
                Id = 1,
                Name = "Việt Anh",
                Address = "Hà Nội",
                Email = "vanh@gmail.com",
                Password = "12345",
                Gender = true,
            };
            return View(user);
        }
        public IActionResult MotDT(Users user)
        {
            return View();
        }
    }
}
