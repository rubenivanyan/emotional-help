using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedNewSeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "724eb8af-300a-4e95-b79c-92f3df6f20eb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8305be1d-7517-4a81-8450-d5029a7dfcd2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3ea5659-d1ee-457a-9464-fc31402e6693");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "f3e14eb2-7472-48af-b415-c4740d18e7a3", "fd49d7cc-216c-4008-b826-53b3122a961f", "Client", "CLIENT" },
                    { "a4efe2da-27c3-47d3-b208-4a846510ca6d", "ce9fe3a8-788d-4e20-81fb-250e8058d10c", "Mentor", "MENTOR" },
                    { "667d77bd-189c-4558-a50d-7d1d097fa029", "e233bef2-1409-420f-b592-e98f8e758776", "Administrator", "ADMIN ISTRATOR" }
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
                table: "EmotionsGenres",
                columns: new[] { "Id", "Emotion", "Genre" },
                values: new object[,]
                {
                    { 5, "Compassion", "Jazz" },
                    { 3, "Boredom", "Action" },
                    { 4, "Boredom", "Fantasy" },
                    { 1, "Happiness", "ActionRolePlaying" },
                    { 2, "Boredom", "ActionAdventure" }
                });

            migrationBuilder.InsertData(
                table: "Musics",
                columns: new[] { "Id", "Executor", "Genre", "Language", "Title" },
                values: new object[] { 1, "Frank Sinatra", 1, "EN", "A Jolly Christmas from Frank Sinatra" });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "667d77bd-189c-4558-a50d-7d1d097fa029");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a4efe2da-27c3-47d3-b208-4a846510ca6d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f3e14eb2-7472-48af-b415-c4740d18e7a3");

            migrationBuilder.DeleteData(
                table: "ComputerGames",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ComputerGames",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmotionsGenres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmotionsGenres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmotionsGenres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmotionsGenres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "EmotionsGenres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Musics",
                keyColumn: "Id",
                keyValue: 1);

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
                values: new object[] { "724eb8af-300a-4e95-b79c-92f3df6f20eb", "7afe4164-6332-4488-a579-07190a1861fb", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "8305be1d-7517-4a81-8450-d5029a7dfcd2", "ef970cda-ea3c-4516-a018-a5738be0428a", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3ea5659-d1ee-457a-9464-fc31402e6693", "0e87a12d-2c7b-4746-9d90-6f431146da0c", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
