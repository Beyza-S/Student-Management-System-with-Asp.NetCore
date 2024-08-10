using Microsoft.EntityFrameworkCore.Migrations;

namespace projebeyza.Migrations
{
    public partial class AddGraduationYearToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GraduationYear",
                table: "Students",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GraduationYear",
                table: "Students");
        }
    }
}
