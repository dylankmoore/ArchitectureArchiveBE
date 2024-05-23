using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureArchiveBE.Migrations
{
    public partial class UserUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "JPK4oOnHEhbgR0qjSjkTOkEnaU22");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "iRYTPiEULDdTF8vwgIn7daszg7v1");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_StyleId",
                table: "Buildings",
                column: "StyleId");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_UserId",
                table: "Buildings",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Styles_StyleId",
                table: "Buildings",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "StyleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Users_UserId",
                table: "Buildings",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Styles_StyleId",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Users_UserId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_StyleId",
                table: "Buildings");

            migrationBuilder.DropIndex(
                name: "IX_Buildings_UserId",
                table: "Buildings");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                column: "Uid",
                value: "uidstring");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                column: "Uid",
                value: "uidstring");
        }
    }
}
