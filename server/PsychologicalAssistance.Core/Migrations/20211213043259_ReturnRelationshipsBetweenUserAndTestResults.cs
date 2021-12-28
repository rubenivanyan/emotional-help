using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class ReturnRelationshipsBetweenUserAndTestResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13d692e4-6b5d-4b5c-85c4-e4d4783ed1c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1b49b724-0ae8-4067-a65b-0b1b5ced026c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "303f2f9e-02be-4ffc-a32d-ccb732544ae7");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TestResults",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05650395-37b6-4124-8e6e-665d6597cf37", "cc9c914e-bc1a-4d38-9a08-2138fc3cba35", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e583dea9-c00e-41bd-b585-53dda77683d0", "6351c4f2-b6a0-46aa-83ff-bb1a1a8ecd5a", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac307142-42c1-42c1-8899-568aa9d398f3", "d668ba8c-d3ce-4f01-829e-321751e3e6a4", "Administrator", "ADMIN ISTRATOR" });

            migrationBuilder.CreateIndex(
                name: "IX_TestResults_UserId",
                table: "TestResults",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TestResults_AspNetUsers_UserId",
                table: "TestResults",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TestResults_AspNetUsers_UserId",
                table: "TestResults");

            migrationBuilder.DropIndex(
                name: "IX_TestResults_UserId",
                table: "TestResults");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05650395-37b6-4124-8e6e-665d6597cf37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac307142-42c1-42c1-8899-568aa9d398f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e583dea9-c00e-41bd-b585-53dda77683d0");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TestResults");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "303f2f9e-02be-4ffc-a32d-ccb732544ae7", "52fbef8d-b31d-4533-a4a8-66efdf4620bc", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1b49b724-0ae8-4067-a65b-0b1b5ced026c", "000f263c-4689-4401-9bba-b5eeebdb3a6d", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "13d692e4-6b5d-4b5c-85c4-e4d4783ed1c2", "b451ffa5-17ba-4f1f-96af-1da70c12af59", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
