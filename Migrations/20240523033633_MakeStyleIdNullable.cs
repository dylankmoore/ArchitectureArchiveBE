using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureArchiveBE.Migrations
{
    public partial class MakeStyleIdNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Styles_StyleId",
                table: "Buildings");

            migrationBuilder.AlterColumn<int>(
                name: "StyleId",
                table: "Buildings",
                type: "integer",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Styles_StyleId",
                table: "Buildings",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "StyleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_Styles_StyleId",
                table: "Buildings");

            migrationBuilder.AlterColumn<int>(
                name: "StyleId",
                table: "Buildings",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "integer",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_Styles_StyleId",
                table: "Buildings",
                column: "StyleId",
                principalTable: "Styles",
                principalColumn: "StyleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
