using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MessageBoard.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodId);
                });

            migrationBuilder.CreateTable(
                name: "Businesses",
                columns: table => new
                {
                    BusinessId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(50) CHARACTER SET utf8mb4", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    PhoneNumber = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: false),
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Businesses", x => x.BusinessId);
                    table.ForeignKey(
                        name: "FK_Businesses_Neighborhoods_NeighborhoodId",
                        column: x => x.NeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Neighborhoods",
                columns: new[] { "NeighborhoodId", "Name" },
                values: new object[,]
                {
                    { 1, "Northwest Portland" },
                    { 28, "Collins View" },
                    { 29, "South Waterfront" },
                    { 30, "Mount Tabor" },
                    { 31, "Multnomah" },
                    { 32, "Overlook" },
                    { 33, "Hawthorne" },
                    { 34, "St.Johns" },
                    { 35, "Boise" },
                    { 36, "Central Eastside" },
                    { 37, "Nob Hill" },
                    { 38, "Montavilla" },
                    { 39, "Southeast Portland" },
                    { 40, "Pleasant Valley" },
                    { 41, "Lloyd District" },
                    { 42, "Creston - Kenilworth" },
                    { 43, "University Park" },
                    { 44, "Cully" },
                    { 45, "Southwest Portland" },
                    { 46, "Sabin" },
                    { 47, "Alameda" },
                    { 48, "Richmond" },
                    { 27, "Arnold Creek" },
                    { 26, "Buckman" },
                    { 25, "Hollywood" },
                    { 24, "Northeast Portland" },
                    { 2, "Pearl District" },
                    { 3, "Goose Hollow Foothills League" },
                    { 4, "Portland Downtown" },
                    { 5, "Laurelhurst" },
                    { 6, "Arlington Heights" },
                    { 7, "Sellwood - Moreland" },
                    { 8, "Eastmoreland" },
                    { 9, "Irvington" },
                    { 10, "Southwest Hills" },
                    { 11, "Hosford-Abernethy" },
                    { 49, "Sunnyside" },
                    { 12, "Northwest Heights" },
                    { 14, "Healy Heights" },
                    { 15, "Kerns" },
                    { 16, "South Portland" },
                    { 17, "Forest Park" },
                    { 18, "Sylvan - Highlands" },
                    { 19, "Old Town" },
                    { 20, "Sullivan's Gulch" },
                    { 21, "Marshall Park" },
                    { 22, "Northwest Industrial" },
                    { 23, "Grant Park" },
                    { 13, "Beaumont - Wilshire" },
                    { 50, "Hillsdale" }
                });

            migrationBuilder.InsertData(
                table: "Businesses",
                columns: new[] { "BusinessId", "Description", "Name", "NeighborhoodId", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "Portrait, Branding, and Boudoir Photography", "Abigayle Tarsches Photography", 1, "415-609-7914" },
                    { 2, "Full service bike shop", "Gladys Bikes", 1, "971-373-8388" },
                    { 3, "Women's clothing, costume jewelry, accessories, fashion face mask", "Moods of Florence Italy", 19, "503-740-1874" },
                    { 4, "Local family owned shoe repair in the Hollywood District", "Shoe", 25, "503-206-6455" },
                    { 5, "Your photos printed on Canvas and Fine Art Papers", "Photo to Canvas", 41, "503-896-5643" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Businesses_NeighborhoodId",
                table: "Businesses",
                column: "NeighborhoodId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Businesses");

            migrationBuilder.DropTable(
                name: "Neighborhoods");
        }
    }
}
