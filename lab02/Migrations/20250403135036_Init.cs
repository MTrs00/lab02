using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lab02.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PeopleInSpaces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    message = table.Column<string>(type: "TEXT", nullable: true),
                    number = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleInSpaces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "personInSpace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    name = table.Column<string>(type: "TEXT", nullable: false),
                    craft = table.Column<string>(type: "TEXT", nullable: false),
                    peopleInSpaceId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_personInSpace", x => x.Id);
                    table.ForeignKey(
                        name: "FK_personInSpace_PeopleInSpaces_peopleInSpaceId",
                        column: x => x.peopleInSpaceId,
                        principalTable: "PeopleInSpaces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "PeopleInSpaces",
                columns: new[] { "Id", "message", "number" },
                values: new object[] { 1, "success", 1 });

            migrationBuilder.InsertData(
                table: "personInSpace",
                columns: new[] { "Id", "craft", "name", "peopleInSpaceId" },
                values: new object[] { 1, "ISS", "Mateusz", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_personInSpace_peopleInSpaceId",
                table: "personInSpace",
                column: "peopleInSpaceId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "personInSpace");

            migrationBuilder.DropTable(
                name: "PeopleInSpaces");
        }
    }
}
