using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class FixedRoleTypo : Migration
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
