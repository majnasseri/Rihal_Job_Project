using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsBlazorApp.Migrations
{
    public partial class updatestudentmodel2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_classes__classId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_countries_countryId",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "students",
                newName: "student_name");

            migrationBuilder.RenameColumn(
                name: "countryId",
                table: "students",
                newName: "student_countryId");

            migrationBuilder.RenameColumn(
                name: "_classId",
                table: "students",
                newName: "student_classId");

            migrationBuilder.RenameIndex(
                name: "IX_students_countryId",
                table: "students",
                newName: "IX_students_student_countryId");

            migrationBuilder.RenameIndex(
                name: "IX_students__classId",
                table: "students",
                newName: "IX_students_student_classId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_classes_student_classId",
                table: "students",
                column: "student_classId",
                principalTable: "classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_countries_student_countryId",
                table: "students",
                column: "student_countryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_classes_student_classId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_countries_student_countryId",
                table: "students");

            migrationBuilder.RenameColumn(
                name: "student_name",
                table: "students",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "student_countryId",
                table: "students",
                newName: "countryId");

            migrationBuilder.RenameColumn(
                name: "student_classId",
                table: "students",
                newName: "_classId");

            migrationBuilder.RenameIndex(
                name: "IX_students_student_countryId",
                table: "students",
                newName: "IX_students_countryId");

            migrationBuilder.RenameIndex(
                name: "IX_students_student_classId",
                table: "students",
                newName: "IX_students__classId");

            migrationBuilder.AddForeignKey(
                name: "FK_students_classes__classId",
                table: "students",
                column: "_classId",
                principalTable: "classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_countries_countryId",
                table: "students",
                column: "countryId",
                principalTable: "countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
