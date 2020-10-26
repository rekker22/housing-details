using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class newtablestructure : Migration
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
                name: "Accds",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypePreferenceOrder1 = table.Column<string>(nullable: true),
                    TypePreferenceOrder2 = table.Column<string>(nullable: true),
                    TypePreferenceOrder3 = table.Column<string>(nullable: true),
                    TypePreferenceOrder4 = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    dataLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accds", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accds_Datas_dataLocation",
                        column: x => x.dataLocation,
                        principalTable: "Datas",
                        principalColumn: "Location",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Ptvs",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    TypePreferenceOrder1 = table.Column<string>(nullable: true),
                    TypePreferenceOrder2 = table.Column<string>(nullable: true),
                    TypePreferenceOrder3 = table.Column<string>(nullable: true),
                    TypePreferenceOrder4 = table.Column<string>(nullable: true),
                    Location = table.Column<string>(nullable: true),
                    dataLocation = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ptvs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ptvs_Datas_dataLocation",
                        column: x => x.dataLocation,
                        principalTable: "Datas",
                        principalColumn: "Location",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accds_dataLocation",
                table: "Accds",
                column: "dataLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Ptvs_dataLocation",
                table: "Ptvs",
                column: "dataLocation");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Accds");

            migrationBuilder.DropTable(
                name: "Ptvs");

            migrationBuilder.DropTable(
                name: "Datas");
        }
    }
}
