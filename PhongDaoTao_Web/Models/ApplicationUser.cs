using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PhongDaoTao_Web.Models
{
    public class ApplicationUser : IdentityUser
    {
            [Required, StringLength(100)]
            [Display(Name = "Họ và tên")]
            public string FullName { get; set; } = string.Empty;

            [Display(Name = "Giới tính")]
            public string? Gender { get; set; }

            [Display(Name = "Ngày sinh")]
            [DataType(DataType.Date)]
            public DateTime? BirthDate { get; set; }

            [Display(Name = "Địa chỉ")]
            public string? Address { get; set; }

            [Display(Name = "Mã giáo viên")]
            public string? TeacherCode { get; set; } // Dành riêng cho giáo viên

            [Display(Name = "Trạng thái")]
            public string Status { get; set; } = "Hoạt động";
        }
}
