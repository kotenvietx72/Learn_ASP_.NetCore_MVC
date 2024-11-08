using System.ComponentModel.DataAnnotations;

namespace Buoi4_1.Models
{
    public class NhanVien
    {
        [Required]
        [Display(Name = "Mã Nhân Viên")]
        public int MaNV { get; set; }
        [Required]
        [Display(Name = "Họ và Tên")]
        public string HoTen { get; set; }
        [Required]
        [Display(Name = "Ngày Sinh")]
        public NgaySinh a { get; set; }
        [Required]
        [Display(Name = "Giới Tính")]
        public string GioiTinh { get; set; }
        [Required]
        [Display(Name = "Số Điện Thoại")]
        public int SoDT { get; set; }
        [Required]
        [Display(Name = "Hệ Số Lương")]
        public decimal HSLuong { get; set; }
        [Required]
        [Display(Name = "Lương")]
        public float Luong { get; set; }
        [Required]
        [Display(Name = "Tên Phòng")]
        public string TenPhong { get; set; }
    }
    
}
