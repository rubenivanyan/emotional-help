using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedConsulting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "31f5a738-cda7-4cbe-b904-902deb8bdcb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72eba09f-ac80-4633-81c9-a82c340ec851");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1621163-5c11-483d-9502-03aad7576dbe");

            migrationBuilder.CreateTable(
                name: "Consultings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConvenientDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultings", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ConsultingUser");

            migrationBuilder.DropTable(
                name: "Consultings");

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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "72eba09f-ac80-4633-81c9-a82c340ec851", "9aec449a-f0cf-4037-99a9-d000b3ae652e", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c1621163-5c11-483d-9502-03aad7576dbe", "e5b635cc-ee94-4020-b4c1-adea3b10055f", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "31f5a738-cda7-4cbe-b904-902deb8bdcb0", "be68e5d3-8c66-4ed1-9bb1-1e028569cb18", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
