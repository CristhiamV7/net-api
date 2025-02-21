using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApiCarBrands.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CarBrands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Year = table.Column<string>(type: "text", nullable: true),
                    Country = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarBrands", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "CarBrands",
                columns: new[] { "Id", "Country", "Description", "Name", "Year" },
                values: new object[,]
                {
                    { 1, "Japan", "A reliable and popular car brand", "Toyota", "1937" },
                    { 2, "Germany", "A luxury car brand with elegant designs", "Mercedes-Benz", "1926" },
                    { 3, "USA", "An innovative car brand known for the Model T", "Ford", "1903" },
                    { 4, "Italy", "A sports car brand known for its speed and performance", "Ferrari", "1939" },
                    { 5, "USA", "An electric car brand with cutting-edge technology", "Tesla", "2003" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarBrands");
        }
    }
}
