using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MindxTest.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreateVerSix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Educations_EducationId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Experiences_ExperienceId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Informations_InformationId",
                table: "Resumes");

            migrationBuilder.DropForeignKey(
                name: "FK_Resumes_Skills_SkillId",
                table: "Resumes");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "Experiences");

            migrationBuilder.DropTable(
                name: "Informations");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_EducationId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_ExperienceId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_InformationId",
                table: "Resumes");

            migrationBuilder.DropIndex(
                name: "IX_Resumes_SkillId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "EducationId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "ExperienceId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "InformationId",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Resumes");

            migrationBuilder.AddColumn<string>(
                name: "Company",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Falcuty",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Github",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Gpa",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "JobTitle",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Linkedin",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Mobile",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Period",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SoftSkill",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "University",
                table: "Resumes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Company",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Falcuty",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Github",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Gpa",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "JobTitle",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Linkedin",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Mobile",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "Period",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "SoftSkill",
                table: "Resumes");

            migrationBuilder.DropColumn(
                name: "University",
                table: "Resumes");

            migrationBuilder.AddColumn<int>(
                name: "EducationId",
                table: "Resumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExperienceId",
                table: "Resumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InformationId",
                table: "Resumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Resumes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    EducationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Falcuty = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gpa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "Experiences",
                columns: table => new
                {
                    ExperienceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Period = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Experiences", x => x.ExperienceId);
                });

            migrationBuilder.CreateTable(
                name: "Informations",
                columns: table => new
                {
                    InformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Github = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Linkedin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Informations", x => x.InformationId);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftSkill = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_EducationId",
                table: "Resumes",
                column: "EducationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_ExperienceId",
                table: "Resumes",
                column: "ExperienceId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_InformationId",
                table: "Resumes",
                column: "InformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Resumes_SkillId",
                table: "Resumes",
                column: "SkillId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Educations_EducationId",
                table: "Resumes",
                column: "EducationId",
                principalTable: "Educations",
                principalColumn: "EducationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Experiences_ExperienceId",
                table: "Resumes",
                column: "ExperienceId",
                principalTable: "Experiences",
                principalColumn: "ExperienceId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Informations_InformationId",
                table: "Resumes",
                column: "InformationId",
                principalTable: "Informations",
                principalColumn: "InformationId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Resumes_Skills_SkillId",
                table: "Resumes",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "SkillId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
