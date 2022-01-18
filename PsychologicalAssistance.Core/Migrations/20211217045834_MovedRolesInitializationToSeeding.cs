using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class MovedRolesInitializationToSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
