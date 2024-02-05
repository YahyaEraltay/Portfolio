using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg12 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Status",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Contacts");
        }
    }
}
