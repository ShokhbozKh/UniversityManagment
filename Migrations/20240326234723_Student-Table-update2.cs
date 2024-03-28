using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityManagment.Migrations
{
    /// <inheritdoc />
    public partial class StudentTableupdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CourseNumer",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseNumer",
                table: "Students");
        }
    }
}
