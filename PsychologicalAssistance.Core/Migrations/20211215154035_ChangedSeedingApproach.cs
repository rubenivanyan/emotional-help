using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class ChangedSeedingApproach : Migration
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

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ComputerGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComputerGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

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

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Variants",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e301ea7f-9436-4690-8792-2bfe42eeaa7e", "931193f3-0155-4a7d-beb7-f847aec5e794", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "706fcc69-1215-48a5-b3f3-7125ce064448", "1fa68a82-d9fd-4403-88bb-27630c1a77ea", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "59e8170c-63c8-496c-934a-657da92a53ad", "ecb195ac-b2d9-45d3-ae04-71e50ccc5dfc", "Administrator", "ADMIN ISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59e8170c-63c8-496c-934a-657da92a53ad");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "706fcc69-1215-48a5-b3f3-7125ce064448");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e301ea7f-9436-4690-8792-2bfe42eeaa7e");

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
                table: "Books",
                columns: new[] { "Id", "Author", "Genre", "Language", "Title" },
                values: new object[,]
                {
                    { 1, "Imbolo Mbue", 5, "EN", "How Beautiful We Were" },
                    { 2, "Katie Kitamura", 5, "EN", "Intimacies" },
                    { 3, "Michael Connelly", 0, "EN", "The Dark Hours" }
                });

            migrationBuilder.InsertData(
                table: "ComputerGames",
                columns: new[] { "Id", "Company", "Genre", "Language", "Review", "Title" },
                values: new object[,]
                {
                    { 1, "CDProjectRed", 6, "RU", "93/100", "The Witcher 3: Wild Hunt" },
                    { 2, "Rockstar", 5, "EN", "97/100", "Red Dead Redemption 2" }
                });

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "Country", "FilmDuration", "Genre", "Language", "Producer", "Title", "VideoUrl", "Year" },
                values: new object[,]
                {
                    { 1, "USA", 0, 4, "EN", null, "The Godfather", "google.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972) },
                    { 2, "USA", 0, 4, "EN", null, "The Shawshank Redemption", "www.facebook.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994) },
                    { 3, "USA", 0, 1, "EN", null, "The Dark Knight", "www.twitter.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008) }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 5, "Jazz" },
                    { 4, "Fantasy" },
                    { 2, "ActionAdventure" },
                    { 1, "ActionRolePlaying" },
                    { 3, "Action" }
                });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Executor", "Genre", "Language", "Title" },
                values: new object[] { 1, "Frank Sinatra", 1, "EN", "A Jolly Christmas from Frank Sinatra" });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Formulation", "ImageUrl" },
                values: new object[,]
                {
                    { 1, "How are you? Your mood?", "dasddsa@fsfdss" },
                    { 2, "What is your emotion now?", "dasddsa@fsfdss" },
                    { 3, "How do you feel now?", "dasddsa@fsfdss" }
                });

            migrationBuilder.InsertData(
                table: "Variants",
                columns: new[] { "Id", "Formulation" },
                values: new object[,]
                {
                    { 5, "Disappointment" },
                    { 1, "Happiness" },
                    { 2, "Boredom" },
                    { 3, "Certainty" },
                    { 4, "Compassion" },
                    { 6, "Embarrassment" }
                });
        }
    }
}
