using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ArchitectureArchiveBE.Migrations
{
    public partial class AddDescriptionToCollection : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Collections",
                type: "text",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Collections");
        }
    }
}
