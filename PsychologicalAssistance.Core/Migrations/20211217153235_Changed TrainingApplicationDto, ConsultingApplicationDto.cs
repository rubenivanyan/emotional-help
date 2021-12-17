using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class ChangedTrainingApplicationDtoConsultingApplicationDto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "TrainingApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserFullName",
                table: "TrainingApplications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Consultings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserFullName",
                table: "Consultings",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "TrainingApplications");

            migrationBuilder.DropColumn(
                name: "UserFullName",
                table: "TrainingApplications");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Consultings");

            migrationBuilder.DropColumn(
                name: "UserFullName",
                table: "Consultings");
        }
    }
}
