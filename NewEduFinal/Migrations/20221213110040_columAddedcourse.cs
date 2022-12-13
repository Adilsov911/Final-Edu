using Microsoft.EntityFrameworkCore.Migrations;

namespace NewEduFinal.Migrations
{
    public partial class columAddedcourse : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "HomeAbout",
                table: "Courses",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HomeAbout",
                table: "Courses");
        }
    }
}
