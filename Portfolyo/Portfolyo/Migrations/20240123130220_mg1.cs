using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Resumes",
                columns: table => new
                {
                    ResumeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sex = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AboutDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillScore = table.Column<int>(type: "int", nullable: false),
                    EducationName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExperienceDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectLink = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectPhoto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProjectAnnotation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resumes", x => x.ResumeID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Resumes");
        }
    }
}
