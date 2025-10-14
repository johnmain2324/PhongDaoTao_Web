using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PhongDaoTao_Web.Models
{
    public class Classroom
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Class Name")]
        public string ClassName { get; set; } = string.Empty;

        [Display(Name = "Max Students")]
        public int MaxStudents { get; set; } = 20;

        [Display(Name = "Current Students")]
        public int CurrentStudents { get; set; } = 0;

        [Display(Name = "Status")]
        public string Status { get; set; } = "Ongoing";

        // 🔹 Liên kết giáo viên (Teacher)
        [ForeignKey("Teacher")]
        [Display(Name = "Teacher ID")]
        public string? TeacherID { get; set; }   // ⚠ IdentityUser sử dụng string ID
        public ApplicationUser? Teacher { get; set; }

        // 🔹 Danh sách lịch học
        public ICollection<Schedule>? Schedules { get; set; }

        // 🔹 Danh sách điểm số
        public ICollection<Score>? Scores { get; set; }
    }
}
