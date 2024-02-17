using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_with_Razor.Data.Migrations
{
    public partial class Grouping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentCount",
                table: "Student",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentCount",
                table: "Student");
        }
    }
}
