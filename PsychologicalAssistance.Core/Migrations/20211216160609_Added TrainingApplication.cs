using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedTrainingApplication : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "19771959-46ac-410b-a8a7-3dea67bedde0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c3b6aaf-5bc9-4783-9b30-9d6a668ec630");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f628faa9-0354-4b59-84a3-5cf147812db0");

            migrationBuilder.CreateTable(
                name: "TrainingApplications",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    TrainingId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingApplications", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TrainingApplications_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TrainingApplications_Trainings_TrainingId",
                        column: x => x.TrainingId,
                        principalTable: "Trainings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3d430f63-fb1f-4b19-b776-d2c0d89b726f", "0c3bc3dd-98fb-4647-8ad6-6a525ead3e18", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1bb7c3d1-d7dd-4d5a-9507-517e628074c4", "f62dc1fa-44a7-4818-879c-a2f95f9141be", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3df3e121-5fd1-4bfc-9568-b2cddcb02129", "b10760cd-69e5-4a58-900a-bd2feded221d", "Administrator", "ADMIN ISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TrainingApplications_TrainingId",
                table: "TrainingApplications",
                column: "TrainingId");

            migrationBuilder.CreateIndex(
                name: "IX_TrainingApplications_UserId",
                table: "TrainingApplications",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TrainingApplications");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1bb7c3d1-d7dd-4d5a-9507-517e628074c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d430f63-fb1f-4b19-b776-d2c0d89b726f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3df3e121-5fd1-4bfc-9568-b2cddcb02129");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c3b6aaf-5bc9-4783-9b30-9d6a668ec630", "e2ed66c1-9cd6-4d6c-9b85-910f9c8be8c6", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "f628faa9-0354-4b59-84a3-5cf147812db0", "fbba2e35-42f3-4e36-9d4f-fe45f84a6d88", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "19771959-46ac-410b-a8a7-3dea67bedde0", "cce8398d-69b5-4894-a77b-30908e68a099", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
