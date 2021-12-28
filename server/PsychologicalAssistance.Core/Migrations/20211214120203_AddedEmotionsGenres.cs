using Microsoft.EntityFrameworkCore.Migrations;

namespace PsychologicalAssistance.Core.Migrations
{
    public partial class AddedEmotionsGenres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "05650395-37b6-4124-8e6e-665d6597cf37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac307142-42c1-42c1-8899-568aa9d398f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e583dea9-c00e-41bd-b585-53dda77683d0");

            migrationBuilder.RenameColumn(
                name: "FilmDuraction",
                table: "Films",
                newName: "FilmDuration");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EmotionsGenres");

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

            migrationBuilder.RenameColumn(
                name: "FilmDuration",
                table: "Films",
                newName: "FilmDuraction");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "05650395-37b6-4124-8e6e-665d6597cf37", "cc9c914e-bc1a-4d38-9a08-2138fc3cba35", "Client", "CLIENT" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "e583dea9-c00e-41bd-b585-53dda77683d0", "6351c4f2-b6a0-46aa-83ff-bb1a1a8ecd5a", "Mentor", "MENTOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ac307142-42c1-42c1-8899-568aa9d398f3", "d668ba8c-d3ce-4f01-829e-321751e3e6a4", "Administrator", "ADMIN ISTRATOR" });
        }
    }
}
