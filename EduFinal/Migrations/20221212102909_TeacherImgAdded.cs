using Microsoft.EntityFrameworkCore.Migrations;

namespace EduFinal.Migrations
{
    public partial class TeacherImgAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Img",
                table: "Teachers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Img",
                table: "Teachers");
        }
    }
}
