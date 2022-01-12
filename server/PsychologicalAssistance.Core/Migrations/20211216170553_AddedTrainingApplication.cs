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
                keyValue: "11d809b7-7892-4610-b936-97ba643ebc87");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "482598cf-36c0-459a-a18b-d9e092dba645");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53bf7f28-9c35-4074-aec7-80192a5220b3");

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
                values: new object[] { "206b5875-ce46-4a4d-9605-555ca904d4b5", "4781a85a-ca83-49fb-82a5-71ba0a482fee", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6cb9a1e2-e7ba-479f-a86c-687933f681e2", "06b66485-4150-4516-bbb0-d484443b08bd", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "779128cb-2824-4219-beb9-278b47cb16d9", "746b595a-0538-412d-bfdf-842e494505ec", "Administrator", "ADMINISTRATOR" });

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
                keyValue: "206b5875-ce46-4a4d-9605-555ca904d4b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6cb9a1e2-e7ba-479f-a86c-687933f681e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "779128cb-2824-4219-beb9-278b47cb16d9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "482598cf-36c0-459a-a18b-d9e092dba645", "1edc5d56-9b78-42c0-9d72-a28b6036e639", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "53bf7f28-9c35-4074-aec7-80192a5220b3", "50b3fd32-7ac1-4b6b-86a9-4afa5e4e57bb", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "11d809b7-7892-4610-b936-97ba643ebc87", "e9d57210-bb70-42aa-9c43-999bf43e64cd", "Administrator", "ADMINISTRATOR" });
        }
    }
}
