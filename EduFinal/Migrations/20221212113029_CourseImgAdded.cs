using Microsoft.EntityFrameworkCore.Migrations;

namespace EduFinal.Migrations
{
    public partial class CourseImgAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Courses");
        }
    }
}
