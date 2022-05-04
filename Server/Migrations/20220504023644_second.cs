using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRAppMudBlazorProject.Server.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Designation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Designation",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
