using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg14 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "ReadReceipt",
                table: "Contacts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReadReceipt",
                table: "Contacts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");
        }
    }
}
