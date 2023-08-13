using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MobilyaMagazasi_Crud_MVC.Migrations
{
    /// <inheritdoc />
    public partial class First : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mobilyalar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mobilyalar", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Mobilyalar",
                columns: new[] { "Id", "Name", "Stock" },
                values: new object[,]
                {
                    { 1, "Kanepe", 10 },
                    { 2, "Koltuk", 15 },
                    { 3, "Sandalye", 20 },
                    { 4, "Tv Ünitesi", 25 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mobilyalar");
        }
    }
}
