using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentsBlazorApp.Migrations
{
    public partial class updatedStudents : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "class_id",
                table: "students");

            migrationBuilder.DropColumn(
                name: "country_id",
                table: "students");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "class_id",
                table: "students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "country_id",
                table: "students",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
