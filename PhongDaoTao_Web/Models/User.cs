using System.ComponentModel.DataAnnotations;

namespace PhongDaoTao_Web.Models
{
    public class User
    {
        [Key]
        public int MaNguoiDung { get; set; }

        [Display(Name = "Họ tên")]
        public string HoTen { get; set; } = string.Empty;

        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }

        public string? Email { get; set; }

        [Display(Name = "Tên đăng nhập")]
        public string TenDangNhap { get; set; } = string.Empty;
    }
}
