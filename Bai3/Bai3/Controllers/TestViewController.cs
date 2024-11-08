using Microsoft.AspNetCore.Mvc;

namespace Bai3.Controllers
{
    public class TestViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Test() {
            return View();
        }
        public IActionResult DungLayoutChiDinh()
        {
            return View();
        }
        public IActionResult TruyenDuLieu()
        {
            // 3 cách truyền dữ liệu
            ViewBag.name = "Việt Anh";
            ViewData["Tuoi"] = 18;
            TempData["Truong"] = "Uneti";
            /* So sánh giữa 3 cách truyền dữ liệu
            - TempData: Khi chuyển hướng sang action khác thì giữ thông tin
            - ViewBag và ViewData không được như vậy */
            //Redirect("/TestView/NhanChuyenHuong"); => Chuyển hướng sang action khác
            return View();
        }
        public IActionResult NhanChuyenHuong()
        {
            return View();
        }
        public IActionResult TestRazor()
        {
            ViewBag.a = 10;
            return View();
        }
        public IActionResult UocChungLN() // Form để người dùng nhập số
        {
            return View();
        }
        public IActionResult UCLN(int a, int b) { // Nhận dữ liệu từ form trên và hiển thị kết quả
            ViewBag.a = a; ViewBag.b = b;
            return View();
        }
    }
}
