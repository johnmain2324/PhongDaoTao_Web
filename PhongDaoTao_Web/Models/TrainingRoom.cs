using System.ComponentModel.DataAnnotations;

namespace PhongDaoTao_Web.Models
{
    public class TrainingRoom
    {
        [Key]
        public int IdTrainingRoom { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập tên phòng học.")]
        [StringLength(100)]
        [Display(Name = "Tên phòng")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Mô tả")]
        [StringLength(300)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Vui lòng nhập sức chứa.")]
        [Range(1, 200, ErrorMessage = "Sức chứa phải từ 1 đến 200.")]
        [Display(Name = "Sức chứa")]
        public int Capacity { get; set; }

        [Display(Name = "Thiết bị")]
        [StringLength(200)]
        public string? Equipment { get; set; } // ví dụ: "Projector, Whiteboard, AC"

        [Display(Name = "Ảnh (URL)")]
        [Url(ErrorMessage = "Đường dẫn ảnh không hợp lệ.")]
        public string? ImageUrl { get; set; }

        [Display(Name = "Ghi chú")]
        [StringLength(200)]
        public string? Notes { get; set; }

        // ✅ Giữ lại đúng 1 thuộc tính IsActive duy nhất
        [Display(Name = "Đang sử dụng")]
        public bool IsActive { get; set; } = false; // false = trống, true = đang sử dụng
    }
}
