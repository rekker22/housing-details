using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class removedLocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Location",
                table: "Ptvs");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Accds");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Ptvs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Accds",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
