using Microsoft.EntityFrameworkCore.Migrations;

namespace EduFinal.Migrations
{
    public partial class IntChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Teachers",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 255);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Teachers",
                type: "int",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 255,
                oldNullable: true);
        }
    }
}
