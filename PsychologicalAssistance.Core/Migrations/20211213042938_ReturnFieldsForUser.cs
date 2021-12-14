using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class ReturnFieldsForUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "UserSurname",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserSurname",
                table: "AspNetUsers");

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
    }
}
