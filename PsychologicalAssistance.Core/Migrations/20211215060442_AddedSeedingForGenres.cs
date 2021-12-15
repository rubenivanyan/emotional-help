using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedSeedingForGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "22eb60a9-c6ef-4eb0-8b05-b96dc05f6983");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e633c4b-b146-4fee-ad5a-c690d301127d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66c9f390-350d-4120-9d43-7de6649489a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "dd365bfa-0691-4f56-9be3-3ecaa8365e35", "5d90b520-070f-4190-a3fe-73419b3506b0", "Client", "CLIENT" },
                    { "1175641b-f945-4458-8ef2-c12feb6ed6ae", "9335db0f-2677-4aee-af9f-f4796d73e55a", "Mentor", "MENTOR" },
                    { "eb8657fd-767e-4a49-bd89-0f45b97e29b5", "62bd2583-a5c1-44f3-89e6-f4d4a946f250", "Administrator", "ADMIN ISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "ActionRolePlaying" },
                    { 2, "ActionAdventure" },
                    { 3, "Action" },
                    { 4, "Fantasy" },
                    { 5, "Jazz" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "66c9f390-350d-4120-9d43-7de6649489a6", "0b20887f-3c13-4b02-aa1f-7b3fb4c72873", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "3e633c4b-b146-4fee-ad5a-c690d301127d", "f0f2cde7-0a1a-4bc1-a32e-24ee242b1bac", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "22eb60a9-c6ef-4eb0-8b05-b96dc05f6983", "42b0a12e-7053-46f3-ab8b-b410dec4b9d3", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
