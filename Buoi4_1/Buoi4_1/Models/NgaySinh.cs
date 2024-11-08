using System.ComponentModel.DataAnnotations;

namespace Buoi4_1.Models
{
    public class NgaySinh
    {
        [Required]
        public int Ngay {  get; set; }
        [Required]
        public int Thang { get; set; }
        [Required]
        public int Nam { get; set; }
    }
}
