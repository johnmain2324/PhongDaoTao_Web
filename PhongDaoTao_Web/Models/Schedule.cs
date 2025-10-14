using System;
using System.ComponentModel.DataAnnotations;

namespace PhongDaoTao_Web.Models
{
    public class Schedule
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ClassroomId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Study Date")]
        public DateTime StudyDate { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "Start Time")]
        public TimeSpan StartTime { get; set; }

        [DataType(DataType.Time)]
        [Display(Name = "End Time")]
        public TimeSpan EndTime { get; set; }

        [StringLength(255)]
        [Display(Name = "Content")]
        public string? Content { get; set; }

        // Navigation property
        public Classroom? Classroom { get; set; }
    }
}
