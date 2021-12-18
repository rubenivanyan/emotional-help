using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedQuestionGroupsValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionGroupsValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionGroup = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<int>(type: "int", nullable: false),
                    TestResultsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionGroupsValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionGroupsValues_TestResults_TestResultsId",
                        column: x => x.TestResultsId,
                        principalTable: "TestResults",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionGroupsValues_TestResultsId",
                table: "QuestionGroupsValues",
                column: "TestResultsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionGroupsValues");
        }
    }
}
