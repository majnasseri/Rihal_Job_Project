using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsBlazorApp.Migrations
{
    public partial class updatestudentmodel3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_classes_student_classId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_countries_student_countryId",
                table: "students");

            migrationBuilder.DropTable(
                name: "countries");

            migrationBuilder.RenameColumn(
                name: "student_countryId",
                table: "students",
                newName: "StudentCountryId");

            migrationBuilder.RenameColumn(
                name: "student_classId",
                table: "students",
                newName: "StudentClassId");

            migrationBuilder.RenameIndex(
                name: "IX_students_student_countryId",
                table: "students",
                newName: "IX_students_StudentCountryId");

            migrationBuilder.RenameIndex(
                name: "IX_students_student_classId",
                table: "students",
                newName: "IX_students_StudentClassId");

            migrationBuilder.CreateTable(
                name: "countries_master",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    country_name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries_master", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_students_classes_StudentClassId",
                table: "students",
                column: "StudentClassId",
                principalTable: "classes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_students_countries_master_StudentCountryId",
                table: "students",
                column: "StudentCountryId",
                principalTable: "countries_master",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_students_classes_StudentClassId",
                table: "students");

            migrationBuilder.DropForeignKey(
                name: "FK_students_countries_master_StudentCountryId",
                table: "students");

            migrationBuilder.DropTable(
                name: "countries_master");

            migrationBuilder.RenameColumn(
                name: "StudentCountryId",
                table: "students",
                newName: "student_countryId");

            migrationBuilder.RenameColumn(
                name: "StudentClassId",
                table: "students",
                newName: "student_classId");

            migrationBuilder.RenameIndex(
                name: "IX_students_StudentCountryId",
                table: "students",
                newName: "IX_students_student_countryId");

            migrationBuilder.RenameIndex(
                name: "IX_students_StudentClassId",
                table: "students",
                newName: "IX_students_student_classId");

            migrationBuilder.CreateTable(
                name: "countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_countries", x => x.Id);
                });

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
    }
}
