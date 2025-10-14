using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhongDaoTao_Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Seed10TrainingRooms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "TrainingRooms",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingRooms",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Equipment",
                table: "TrainingRooms",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TrainingRooms",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Phòng dành cho lớp giao tiếp cơ bản");

            migrationBuilder.UpdateData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Equipment", "Name", "Notes" },
                values: new object[] { 25, "Phòng học IELTS", "TV, Micro, Wifi", "Phòng A2", "Tầng 3" });

            migrationBuilder.InsertData(
                table: "TrainingRooms",
                columns: new[] { "Id", "Capacity", "Description", "Equipment", "ImageUrl", "Name", "Notes" },
                values: new object[,]
                {
                    { 3, 15, "Phòng luyện thi TOEIC", "Projector, Air Conditioner", "/images/room3.jpg", "Phòng B1", "Gần phòng giáo viên" },
                    { 4, 10, "Phòng học 1:1", "Whiteboard, TV", "/images/room4.jpg", "Phòng B2", "Có ánh sáng tự nhiên" },
                    { 5, 30, "Phòng hội thảo", "Projector, Micro, AC", "/images/room5.jpg", "Phòng C1", "Phòng lớn nhất trung tâm" },
                    { 6, 18, "Phòng giao tiếp nâng cao", "Whiteboard, TV, Laptop", "/images/room6.jpg", "Phòng C2", "Tầng 2" },
                    { 7, 12, "Phòng học kỹ năng nghe nói", "Tablet, Projector", "/images/room7.jpg", "Phòng D1", "Khu vực yên tĩnh" },
                    { 8, 22, "Phòng luyện phát âm", "AC, TV, Sound system", "/images/room8.jpg", "Phòng D2", "Có điều hòa trung tâm" },
                    { 9, 16, "Phòng học nhóm nhỏ", "Laptop, Whiteboard", "/images/room9.jpg", "Phòng E1", "Tầng 1" },
                    { 10, 28, "Phòng học trực tuyến", "Smart TV, Micro", "/images/room10.jpg", "Phòng E2", "Có camera và hệ thống ghi hình" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "TrainingRooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TrainingRooms",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Equipment",
                table: "TrainingRooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TrainingRooms",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 1,
                column: "Description",
                value: "Phòng cho lớp giao tiếp");

            migrationBuilder.UpdateData(
                table: "TrainingRooms",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Capacity", "Description", "Equipment", "Name", "Notes" },
                values: new object[] { 12, "Phòng 1:1 và nhóm nhỏ", "TV, AC", "Phòng B2", "Có cửa sổ" });
        }
    }
}
