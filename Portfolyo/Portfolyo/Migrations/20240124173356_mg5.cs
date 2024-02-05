using Microsoft.EntityFrameworkCore.Migrations;

namespace Portfolyo.Migrations
{
    public partial class mg5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Resumes_ResumeID",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_ResumeID",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "ResumeID",
                table: "Skills");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ResumeID",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_ResumeID",
                table: "Skills",
                column: "ResumeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Resumes_ResumeID",
                table: "Skills",
                column: "ResumeID",
                principalTable: "Resumes",
                principalColumn: "ResumeID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
