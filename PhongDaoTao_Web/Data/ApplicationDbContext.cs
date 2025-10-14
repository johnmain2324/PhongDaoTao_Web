using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PhongDaoTao_Web.Models;

namespace PhongDaoTao_Web.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Score> Score { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Classroom> Classrooms { get; set; }
        public DbSet<Student> Students { get; set; }

        public DbSet<TrainingRoom> TrainingRooms { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 🧩 Gọi lại cấu hình mặc định của Identity (BẮT BUỘC)
            base.OnModelCreating(modelBuilder);

            // 🧱 Cấu hình dữ liệu mẫu cho bảng TrainingRooms
            modelBuilder.Entity<TrainingRoom>().HasData(
        new TrainingRoom { IdTrainingRoom = 1, Name = "Phòng A1", Capacity = 20, Equipment = "Projector, Whiteboard", ImageUrl = "/images/room1.jpg", Description = "Phòng dành cho lớp giao tiếp cơ bản", Notes = "Nằm tầng 2" },
        new TrainingRoom { IdTrainingRoom = 2, Name = "Phòng A2", Capacity = 25, Equipment = "TV, Micro, Wifi", ImageUrl = "/images/room2.jpg", Description = "Phòng học IELTS", Notes = "Tầng 3" },
        new TrainingRoom { IdTrainingRoom = 3, Name = "Phòng B1", Capacity = 15, Equipment = "Projector, Air Conditioner", ImageUrl = "/images/room3.jpg", Description = "Phòng luyện thi TOEIC", Notes = "Gần phòng giáo viên" },
        new TrainingRoom { IdTrainingRoom = 4, Name = "Phòng B2", Capacity = 10, Equipment = "Whiteboard, TV", ImageUrl = "/images/room4.jpg", Description = "Phòng học 1:1", Notes = "Có ánh sáng tự nhiên" },
        new TrainingRoom { IdTrainingRoom = 5, Name = "Phòng C1", Capacity = 30, Equipment = "Projector, Micro, AC", ImageUrl = "/images/room5.jpg", Description = "Phòng hội thảo", Notes = "Phòng lớn nhất trung tâm" },
        new TrainingRoom { IdTrainingRoom = 6, Name = "Phòng C2", Capacity = 18, Equipment = "Whiteboard, TV, Laptop", ImageUrl = "/images/room6.jpg", Description = "Phòng giao tiếp nâng cao", Notes = "Tầng 2" },
        new TrainingRoom { IdTrainingRoom = 7, Name = "Phòng D1", Capacity = 12, Equipment = "Tablet, Projector", ImageUrl = "/images/room7.jpg", Description = "Phòng học kỹ năng nghe nói", Notes = "Khu vực yên tĩnh" },
        new TrainingRoom { IdTrainingRoom = 8, Name = "Phòng D2", Capacity = 22, Equipment = "AC, TV, Sound system", ImageUrl = "/images/room8.jpg", Description = "Phòng luyện phát âm", Notes = "Có điều hòa trung tâm" },
        new TrainingRoom { IdTrainingRoom = 9, Name = "Phòng E1", Capacity = 16, Equipment = "Laptop, Whiteboard", ImageUrl = "/images/room9.jpg", Description = "Phòng học nhóm nhỏ", Notes = "Tầng 1" },
        new TrainingRoom { IdTrainingRoom = 10, Name = "Phòng E2", Capacity = 28, Equipment = "Smart TV, Micro", ImageUrl = "/images/room10.jpg", Description = "Phòng học trực tuyến", Notes = "Có camera và hệ thống ghi hình" }
            );
        }
    }
}
