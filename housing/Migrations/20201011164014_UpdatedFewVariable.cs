using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class UpdatedFewVariable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder",
                table: "PlacestoVisit");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder",
                table: "Accommodation");

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder1",
                table: "PlacestoVisit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder2",
                table: "PlacestoVisit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder3",
                table: "PlacestoVisit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder4",
                table: "PlacestoVisit",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder1",
                table: "Accommodation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder2",
                table: "Accommodation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder3",
                table: "Accommodation",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder4",
                table: "Accommodation",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder1",
                table: "PlacestoVisit");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder2",
                table: "PlacestoVisit");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder3",
                table: "PlacestoVisit");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder4",
                table: "PlacestoVisit");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder1",
                table: "Accommodation");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder2",
                table: "Accommodation");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder3",
                table: "Accommodation");

            migrationBuilder.DropColumn(
                name: "TypePreferenceOrder4",
                table: "Accommodation");

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder",
                table: "PlacestoVisit",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TypePreferenceOrder",
                table: "Accommodation",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
