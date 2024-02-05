using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "GithubLink",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "InstagramLink",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LinkedinLink",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GithubLink",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "InstagramLink",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "LinkedinLink",
                table: "Resumes");
        }
    }
}
