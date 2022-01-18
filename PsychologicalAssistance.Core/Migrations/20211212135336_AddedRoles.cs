using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "25ed601e-8113-41ec-96a5-d0a4fe90bc67", "98b3c26b-af2b-4ae6-b648-c09da8abd160", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5ec82d2b-e6ac-43e1-b5aa-78e5626d5f48", "23c4993c-3c2d-4c0e-abcb-2664757ae031", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "9b8d0dd6-491a-4132-9a44-fbd3bf242a3b", "faf18343-a79f-4c98-9d2c-3a55465c54f9", "Administrator", "ADMIN ISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25ed601e-8113-41ec-96a5-d0a4fe90bc67");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5ec82d2b-e6ac-43e1-b5aa-78e5626d5f48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b8d0dd6-491a-4132-9a44-fbd3bf242a3b");
        }
    }
}
