using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class FixDuplicateRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { "49282e03-d1a3-4842-bb8c-b4a131949e2a", "2eb94be4-4ba6-496a-840b-6342a67b7531", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5336cb0a-ea0d-4125-bef2-0f4bba687db1", "19f062b9-9684-4b28-bad7-a9fc469318bb", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "51ad33c3-2ffc-4d56-8df4-f9435318e1d1", "a3569d9c-95cd-465b-8a4e-0baefb0f0c4a", "Administrator", "ADMIN ISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "49282e03-d1a3-4842-bb8c-b4a131949e2a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51ad33c3-2ffc-4d56-8df4-f9435318e1d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5336cb0a-ea0d-4125-bef2-0f4bba687db1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16983d08-8957-4e3b-8c64-9bbccd439ffa", "b6679a39-f478-4d8e-958b-2219659e5663", "Client", "CLIENT" },
                    { "eee6b5df-88b5-429c-b4d0-41f12dd60498", "e1745295-237c-4430-a09f-35b4e8f29fc8", "Mentor", "MENTOR" },
                    { "5b71fd6e-753c-497d-9159-b45c02560bce", "0939cf5b-bf71-4076-92f4-e0cb3e85fa60", "Administrator", "ADMIN ISTRATOR" }
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
