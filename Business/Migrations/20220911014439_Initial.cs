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
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    ShopType = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    TypeCategory = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false)
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
                    { 5, "Babydoll Pizza", "Restaurant", "Pizza" },
                    { 6, "New Seasons", "Store", "Grocery" },
                    { 7, "JoJo's", "Restaurant", "Fried Chicken" },
                    { 8, "People's Food Coop", "Store", "Grocery" },
                    { 9, "Academy", "Theater", "Film" },
                    { 10, "Arlene Schintzer", "Concert Hall", "Music" },
                    { 11, "The Laurelhurst Theater", "Theater", "Film" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shops");
        }
    }
}
