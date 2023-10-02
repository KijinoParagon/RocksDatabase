using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Rocks.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Rocks",
                columns: table => new
                {
                    RockId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Shape = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Size = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<int>(type: "int", nullable: false),
                    Home = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rocks", x => x.RockId);
                });

            migrationBuilder.InsertData(
                table: "Rocks",
                columns: new[] { "RockId", "Color", "Home", "Name", "Shape", "Size", "Weight" },
                values: new object[,]
                {
                    { 1, "Polynesian", "Hawaii", "Dwayne", "Built/Muscular/Good", 77, 300 },
                    { 2, "White", "Death Mountain", "Marbled Rock Roast", "Meat", 1, 800 },
                    { 3, "White", "Rio", "Christ the Redeemer", "Christ", 1176, 1400000 },
                    { 4, "Brown", "Bikini Bottom", "Parick's House", "Boulder", 12, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Rocks");
        }
    }
}
