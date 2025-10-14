using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using PhongDaoTao_Web.Controllers;

namespace PhongDaoTao_Web.Models
{
    public class Score
    {
        [Key]
        public int MaDiem { get; set; }
        [Display(Name = "Teacher ID")]
        public int? TeacherId { get; set; }
        [ForeignKey("HocVien")]
        public int MaHocVien { get; set; }
        public User? HocVien { get; set; }

        [ForeignKey("LopHoc")]
        public int MaLop { get; set; }
        public Classroom? LopHoc { get; set; }

        [Display(Name = "Điểm giữa kỳ")]
        public double? DiemGiuaKy { get; set; }

        [Display(Name = "Điểm cuối kỳ")]
        public double? DiemCuoiKy { get; set; }

        [Display(Name = "Nhận xét")]
        public string? NhanXet { get; set; }

        [NotMapped]
        public double? DiemTrungBinh => (DiemGiuaKy + DiemCuoiKy) / 2;
    }
}
