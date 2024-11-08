using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Buoi_4.Models
{
    public class Login
    {
        [Required] // Yêu cầu phải nhập
        public int ID { get; set; }
        [Required]
        [DisplayName("Họ và tên")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Phải nhập mật khẩu")]
        //[StringLength(20, MinimumLength = 4)] // Tối đa 20 kí tự, tối thiểu 4 kí tự
        [MaxLength(50)] // Nhập được tối đa 30 kí tự
        [MinLength(1)] // Nhập tối thiểu 1 kí tự
        [DataType(DataType.Password)] // Mật khẩu hiển thị theo kiểu dấu ***, bảo mật hơn
        public string Password { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Compare("Password")] // Nhập lại mật khẩu và mật khẩu phải giống nhau
        public string ReEnterPassword { get; set; }
        //[ReadOnly(true)] // Không lấy dữ liệu nhập ở người dùng
        [ScaffoldColumn(false)] // Người dùng không thể nhập tuổi
        public int Age { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        public bool Gender { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }
        public string ClassName { get; set; }
        /*[Phone] // Kiểu số diện thoại
        [CreditCard] // Lưu thẻ ngân hàng */
    }
}
