using Microsoft.AspNetCore.Mvc;
using System.Web;

namespace Bai1.Controllers
{
    public class HelloController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Index1()
        {
            return "This is my default action...";
        }
        public string Welcome(string name, int numTimes = 1)
        {
            // HttpUtility.HtmlEncode: Tránh chèn 1 đoạn mã độc nếu người dùng lỡ may truyền vào
            return HttpUtility.HtmlEncode("Hello" + name + ", NumTimes is: " + numTimes);
            // Khi k truyền tham số, thì dữ liệu in ra rỗng
            // Chèn dữ liệu trên web: /Controller/action?name=Thai&numTimes=5
            // => Chèn dữ liệu bằng chuỗi truy vấn
            // Cách chèn khác: /Controller/Function/5?name=Thai => Vì mặc định sau action là id, nên ngẫu nhiên trùng id
        }
    }
}
