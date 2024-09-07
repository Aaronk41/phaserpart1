using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Assignment2.Migrations
{
    /// <inheritdoc />
    public partial class AdditionalData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Music",
                columns: table => new
                {
                    songId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    albumName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    songName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Music", x => x.songId);
                });

            migrationBuilder.InsertData(
                table: "Music",
                columns: new[] { "songId", "albumName", "songName" },
                values: new object[,]
                {
                    { 1, "Supernatural", "RightNow" },
                    { 2, "BornToBe", "RunAway" },
                    { 3, "ItzMe", "Wannabe" },
                    { 4, "NJWMX", "Ditto(250Remix)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Music");
        }
    }
}
