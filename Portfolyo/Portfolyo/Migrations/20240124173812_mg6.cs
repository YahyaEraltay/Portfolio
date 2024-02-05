using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Skills",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Skills");
        }
    }
}
