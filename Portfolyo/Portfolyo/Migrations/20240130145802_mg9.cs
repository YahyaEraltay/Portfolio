using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProjectAnnotation",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ProjectLink",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ProjectPhoto",
                table: "Resumes");

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    ProjectID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectAnnotation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.ProjectID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.AddColumn<string>(
                name: "ProjectAnnotation",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectLink",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProjectPhoto",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
