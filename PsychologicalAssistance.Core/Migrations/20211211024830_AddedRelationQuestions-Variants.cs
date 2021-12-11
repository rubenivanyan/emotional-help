using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedRelationQuestionsVariants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "QuestionVariant",
                columns: table => new
                {
                    QuestionsId = table.Column<int>(type: "int", nullable: false),
                    VariantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionVariant", x => new { x.QuestionsId, x.VariantsId });
                    table.ForeignKey(
                        name: "FK_QuestionVariant_Question_QuestionsId",
                        column: x => x.QuestionsId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionVariant_Variants_VariantsId",
                        column: x => x.VariantsId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionVariant_VariantsId",
                table: "QuestionVariant",
                column: "VariantsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionVariant");
        }
    }
}
