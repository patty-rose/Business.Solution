using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    ShopId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    ShopType = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    TypeCategory = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.ShopId);
                });

            migrationBuilder.InsertData(
                table: "Shops",
                columns: new[] { "ShopId", "Name", "ShopType", "TypeCategory" },
                values: new object[,]
                {
                    { 1, "Powells", "Store", "Books" },
                    { 2, "Doe Donuts", "Restaurant", "Donuts" },
                    { 3, "Mississippi Records", "Shop", "Music" },
                    { 4, "Green Zebra", "Store", "Grocery" },
                    { 5, "Babydoll Pizza", "Restaurant", "Pizza" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
