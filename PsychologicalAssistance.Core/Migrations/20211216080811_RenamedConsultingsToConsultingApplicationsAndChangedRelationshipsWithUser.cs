using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class RenamedConsultingsToConsultingApplicationsAndChangedRelationshipsWithUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultingUser");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2c1956f0-315d-415e-92e7-e609ef003c1d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69475074-92cc-4bd7-841e-a6605a596f22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce84df42-892f-4d71-af83-96bea9d279bf");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Consultings",
                type: "nvarchar(450)",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Consultings_UserId",
                table: "Consultings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Consultings_AspNetUsers_UserId",
                table: "Consultings",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Consultings_AspNetUsers_UserId",
                table: "Consultings");

            migrationBuilder.DropIndex(
                name: "IX_Consultings_UserId",
                table: "Consultings");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Consultings");

            migrationBuilder.CreateTable(
                name: "ConsultingUser",
                columns: table => new
                {
                    ConsultingsId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsultingUser", x => new { x.ConsultingsId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ConsultingUser_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ConsultingUser_Consultings_ConsultingsId",
                        column: x => x.ConsultingsId,
                        principalTable: "Consultings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ce84df42-892f-4d71-af83-96bea9d279bf", "7310abac-88b2-4253-ac2b-f9a4ac0fd154", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "69475074-92cc-4bd7-841e-a6605a596f22", "c5c625a9-6c91-4900-9e29-eab8f03dea1a", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2c1956f0-315d-415e-92e7-e609ef003c1d", "effbc54a-7645-43d3-bb1f-9dcbd2a8d46b", "Administrator", "ADMIN ISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_ConsultingUser_UserId",
                table: "ConsultingUser",
                column: "UserId");
        }
    }
}
