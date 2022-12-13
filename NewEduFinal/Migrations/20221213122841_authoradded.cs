using Microsoft.EntityFrameworkCore.Migrations;

namespace NewEduFinal.Migrations
{
    public partial class authoradded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AuthorName",
                table: "Blogs",
                maxLength: 255,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AuthorSurname",
                table: "Blogs",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AuthorName",
                table: "Blogs");

            migrationBuilder.DropColumn(
                name: "AuthorSurname",
                table: "Blogs");
        }
    }
}
