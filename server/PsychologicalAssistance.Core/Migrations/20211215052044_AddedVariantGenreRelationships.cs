using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedVariantGenreRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmotionsGenres");

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

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GenreVariant",
                columns: table => new
                {
                    GenresId = table.Column<int>(type: "int", nullable: false),
                    VariantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GenreVariant", x => new { x.GenresId, x.VariantsId });
                    table.ForeignKey(
                        name: "FK_GenreVariant_Genres_GenresId",
                        column: x => x.GenresId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GenreVariant_Variants_VariantsId",
                        column: x => x.VariantsId,
                        principalTable: "Variants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GenreVariant_VariantsId",
                table: "GenreVariant",
                column: "VariantsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GenreVariant");

            migrationBuilder.DropTable(
                name: "Genres");

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

            migrationBuilder.CreateTable(
                name: "EmotionsGenres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emotion = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmotionsGenres", x => x.Id);
                });

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
                table: "EmotionsGenres",
                columns: new[] { "Id", "Emotion", "Genre" },
                values: new object[,]
                {
                    { 1, "Happiness", "ActionRolePlaying" },
                    { 2, "Boredom", "ActionAdventure" },
                    { 3, "Boredom", "Action" },
                    { 4, "Boredom", "Fantasy" },
                    { 5, "Compassion", "Jazz" }
                });
        }
    }
}
