using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SkillScore",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Skills",
                table: "Resumes");

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SkillName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SkillScore = table.Column<int>(type: "int", nullable: false),
                    ResumeID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_Skills_Resumes_ResumeID",
                        column: x => x.ResumeID,
                        principalTable: "Resumes",
                        principalColumn: "ResumeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ResumeID",
                table: "Skills",
                column: "ResumeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.AddColumn<int>(
                name: "SkillScore",
                table: "Resumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Skills",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
