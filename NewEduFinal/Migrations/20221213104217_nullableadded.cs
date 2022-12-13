using Microsoft.EntityFrameworkCore.Migrations;

namespace NewEduFinal.Migrations
{
    public partial class nullableadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Events_EventsId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Speakers_SpeakersId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherHobbies_Hobbies_HobbiesId",
                table: "TeacherHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherHobbies_Teachers_TeacherId",
                table: "TeacherHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherPositions_Positions_PositionId",
                table: "TeacherPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherPositions_Teachers_TeacherId",
                table: "TeacherPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Skills_SkillsId",
                table: "TeacherSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "TeacherSkills",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "TeacherSkills",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "TeacherPositions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "TeacherPositions",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "TeacherHobbies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "HobbiesId",
                table: "TeacherHobbies",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "SpeakersId",
                table: "EventSpeakers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "EventsId",
                table: "EventSpeakers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Courses",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Events_EventsId",
                table: "EventSpeakers",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Speakers_SpeakersId",
                table: "EventSpeakers",
                column: "SpeakersId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherHobbies_Hobbies_HobbiesId",
                table: "TeacherHobbies",
                column: "HobbiesId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherHobbies_Teachers_TeacherId",
                table: "TeacherHobbies",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherPositions_Positions_PositionId",
                table: "TeacherPositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherPositions_Teachers_TeacherId",
                table: "TeacherPositions",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Skills_SkillsId",
                table: "TeacherSkills",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Events_EventsId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_EventSpeakers_Speakers_SpeakersId",
                table: "EventSpeakers");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherHobbies_Hobbies_HobbiesId",
                table: "TeacherHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherHobbies_Teachers_TeacherId",
                table: "TeacherHobbies");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherPositions_Positions_PositionId",
                table: "TeacherPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherPositions_Teachers_TeacherId",
                table: "TeacherPositions");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Skills_SkillsId",
                table: "TeacherSkills");

            migrationBuilder.DropForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills");

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "TeacherSkills",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SkillsId",
                table: "TeacherSkills",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "TeacherPositions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PositionId",
                table: "TeacherPositions",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TeacherId",
                table: "TeacherHobbies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HobbiesId",
                table: "TeacherHobbies",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "SpeakersId",
                table: "EventSpeakers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "EventsId",
                table: "EventSpeakers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Courses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Categories_CategoryId",
                table: "Courses",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Events_EventsId",
                table: "EventSpeakers",
                column: "EventsId",
                principalTable: "Events",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EventSpeakers_Speakers_SpeakersId",
                table: "EventSpeakers",
                column: "SpeakersId",
                principalTable: "Speakers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherHobbies_Hobbies_HobbiesId",
                table: "TeacherHobbies",
                column: "HobbiesId",
                principalTable: "Hobbies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherHobbies_Teachers_TeacherId",
                table: "TeacherHobbies",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherPositions_Positions_PositionId",
                table: "TeacherPositions",
                column: "PositionId",
                principalTable: "Positions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherPositions_Teachers_TeacherId",
                table: "TeacherPositions",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Skills_SkillsId",
                table: "TeacherSkills",
                column: "SkillsId",
                principalTable: "Skills",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TeacherSkills_Teachers_TeacherId",
                table: "TeacherSkills",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
