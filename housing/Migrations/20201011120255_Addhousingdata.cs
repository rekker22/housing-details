using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class Addhousingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Datas",
                columns: table => new
                {
                    Location = table.Column<string>(nullable: false),
                    Dfd = table.Column<int>(nullable: false),
                    Budget = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Datas", x => x.Location);
                });

            migrationBuilder.CreateTable(
                name: "Accommodation",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypePreferenceOrder = table.Column<string>(nullable: true),
                    dataLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodation", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accommodation_Datas_dataLocation",
                        column: x => x.dataLocation,
                        principalTable: "Datas",
                        principalColumn: "Location",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PlacestoVisit",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypePreferenceOrder = table.Column<string>(nullable: true),
                    dataLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlacestoVisit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlacestoVisit_Datas_dataLocation",
                        column: x => x.dataLocation,
                        principalTable: "Datas",
                        principalColumn: "Location",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accommodation_dataLocation",
                table: "Accommodation",
                column: "dataLocation");

            migrationBuilder.CreateIndex(
                name: "IX_PlacestoVisit_dataLocation",
                table: "PlacestoVisit",
                column: "dataLocation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accommodation");

            migrationBuilder.DropTable(
                name: "PlacestoVisit");

            migrationBuilder.DropTable(
                name: "Datas");
        }
    }
}
