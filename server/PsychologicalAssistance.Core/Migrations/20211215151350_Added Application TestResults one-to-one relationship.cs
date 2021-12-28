using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedApplicationTestResultsonetoonerelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1175641b-f945-4458-8ef2-c12feb6ed6ae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dd365bfa-0691-4f56-9be3-3ecaa8365e35");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb8657fd-767e-4a49-bd89-0f45b97e29b5");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Applications",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TestResultsId",
                table: "Applications",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "16983d08-8957-4e3b-8c64-9bbccd439ffa", "b6679a39-f478-4d8e-958b-2219659e5663", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eee6b5df-88b5-429c-b4d0-41f12dd60498", "e1745295-237c-4430-a09f-35b4e8f29fc8", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5b71fd6e-753c-497d-9159-b45c02560bce", "0939cf5b-bf71-4076-92f4-e0cb3e85fa60", "Administrator", "ADMIN ISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_Applications_TestResultsId",
                table: "Applications",
                column: "TestResultsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Applications_TestResults_TestResultsId",
                table: "Applications",
                column: "TestResultsId",
                principalTable: "TestResults",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Applications_TestResults_TestResultsId",
                table: "Applications");

            migrationBuilder.DropIndex(
                name: "IX_Applications_TestResultsId",
                table: "Applications");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16983d08-8957-4e3b-8c64-9bbccd439ffa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b71fd6e-753c-497d-9159-b45c02560bce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eee6b5df-88b5-429c-b4d0-41f12dd60498");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Applications");

            migrationBuilder.DropColumn(
                name: "TestResultsId",
                table: "Applications");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "dd365bfa-0691-4f56-9be3-3ecaa8365e35", "5d90b520-070f-4190-a3fe-73419b3506b0", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1175641b-f945-4458-8ef2-c12feb6ed6ae", "9335db0f-2677-4aee-af9f-f4796d73e55a", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "eb8657fd-767e-4a49-bd89-0f45b97e29b5", "62bd2583-a5c1-44f3-89e6-f4d4a946f250", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
