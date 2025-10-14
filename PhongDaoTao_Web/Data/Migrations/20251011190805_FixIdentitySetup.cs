using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PhongDaoTao_Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixIdentitySetup : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingRooms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Capacity = table.Column<int>(type: "int", nullable: false),
                    Equipment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingRooms", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "TrainingRooms",
                columns: new[] { "Id", "Capacity", "Description", "Equipment", "ImageUrl", "Name", "Notes" },
                values: new object[,]
                {
                    { 1, 20, "Phòng cho lớp giao tiếp", "Projector, Whiteboard", "/images/room1.jpg", "Phòng A1", "Nằm tầng 2" },
                    { 2, 12, "Phòng 1:1 và nhóm nhỏ", "TV, AC", "/images/room2.jpg", "Phòng B2", "Có cửa sổ" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingRooms");
        }
    }
}
