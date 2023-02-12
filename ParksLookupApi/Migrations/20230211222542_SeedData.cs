using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ParksLookupApi.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Activities", "Address", "Category", "Name" },
                values: new object[,]
                {
                    { 1, " Camping, Hiking, Snowshoeing, Fishing, WildLife Observation. Visitor Information Line: 970-586-1206", "1000 Highway 36, Estes Park, CO 80517", "National Park", "Rocky Mountain National Park" },
                    { 2, " Camping, Hiking, Cliff Dwelling Tours, Bird Watching, Geologic Views. Visitor information Line: 970-529-4465", " Mesa Verde, CO", "National Park", "Mesa Verde National Park" },
                    { 3, "Camping, Birding, Trails, Fishing, Boating, Biking. Park Office number: 720-520-1876", "13401 Picadilly Rd, Brighton, CO 80603", "State Park", "Barr Lake" },
                    { 4, " Camping, Birding, Trails, Fishing, Boating, Biking, Snowshoeing, Cross-Country Skiing, Kayaking. Park Offic number: 970-879-3922", " 61105 RCR 129, Clark, CO 80429", "State Park", "Steamboat Lake" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "ParkId",
                keyValue: 4);
        }
    }
}
