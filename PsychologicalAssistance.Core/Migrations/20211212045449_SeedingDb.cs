using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class SeedingDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Films",
                columns: new[] { "Id", "Country", "FilmDuraction", "Genre", "Language", "Producer", "Title", "VideoUrl", "Year" },
                values: new object[,]
                {
                    { 1, "USA", 0, 4, "EN", null, "The Godfather", "google.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1972) },
                    { 2, "USA", 0, 4, "EN", null, "The Shawshank Redemption", "www.facebook.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(1994) },
                    { 3, "USA", 0, 1, "EN", null, "The Dark Knight", "www.twitter.com", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddTicks(2008) }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Formulation", "ImageUrl", "TestId" },
                values: new object[,]
                {
                    { 1, "How are you? Your mood?", "dasddsa@fsfdss", null },
                    { 2, "What is your emotion now?", "dasddsa@fsfdss", null },
                    { 3, "How do you feel now?", "dasddsa@fsfdss", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "MailAddress", "Name", "Role", "Surname" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 12, 12, 10, 54, 49, 155, DateTimeKind.Local).AddTicks(1450), "123123@sad", "Tom", 3, "Ivanov" },
                    { 2, new DateTime(2021, 12, 12, 10, 54, 49, 155, DateTimeKind.Local).AddTicks(8575), "dasdas@sad", "Alice", 1, "Denisov" },
                    { 3, new DateTime(2021, 12, 12, 10, 54, 49, 155, DateTimeKind.Local).AddTicks(8586), "asdsadas3123@sad", "Sam", 0, "Donikas" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
