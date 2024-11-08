using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Buoi4_1.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu không được để trống")]
        public string Password { get; set; }
    }
}
