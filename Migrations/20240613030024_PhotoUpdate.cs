using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureArchiveBE.Migrations
{
    public partial class PhotoUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 41,
                column: "ImageURL",
                value: "https://static.toiimg.com/thumb/msid-44848107,width=1200,height=900/44848107.jpg");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 48,
                column: "ImageURL",
                value: "https://archello.s3.eu-central-1.amazonaws.com/images/2016/09/14/01-Hollywood-Bowl2.1506082370.5043.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 41,
                column: "ImageURL",
                value: "https://upload.wikimedia.org/wikipedia/commons/b/bf/Golden_Gate_Bridge_as_seen_from_Battery_East.jpgg");

            migrationBuilder.UpdateData(
                table: "Buildings",
                keyColumn: "BuildingId",
                keyValue: 48,
                column: "ImageURL",
                value: "https://www.discoverlosangeles.com/sites/default/files/styles/hero/public/images/2019-01/Hollywood%20Bowl%20%28Photo%20courtesy%20of%20Los%20Angeles%20Philharmonic%2C%20by%20Adam%20Latham%29.jpg");
        }
    }
}
