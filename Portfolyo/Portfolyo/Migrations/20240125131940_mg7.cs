using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EducationDescription",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "EducationName",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceDescription",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceName",
                table: "Resumes");

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EducationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationID);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ExperienceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.AddColumn<string>(
                name: "EducationDescription",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EducationName",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceDescription",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ExperienceName",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
