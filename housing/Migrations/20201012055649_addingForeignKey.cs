using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class addingForeignKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accds_Datas_dataLocation",
                table: "Accds");

            migrationBuilder.DropForeignKey(
                name: "FK_Ptvs_Datas_dataLocation",
                table: "Ptvs");

            migrationBuilder.DropIndex(
                name: "IX_Ptvs_dataLocation",
                table: "Ptvs");

            migrationBuilder.DropIndex(
                name: "IX_Accds_dataLocation",
                table: "Accds");

            migrationBuilder.DropColumn(
                name: "dataLocation",
                table: "Ptvs");

            migrationBuilder.DropColumn(
                name: "dataLocation",
                table: "Accds");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Ptvs",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Accds",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ptvs_Location",
                table: "Ptvs",
                column: "Location");

            migrationBuilder.CreateIndex(
                name: "IX_Accds_Location",
                table: "Accds",
                column: "Location");

            migrationBuilder.AddForeignKey(
                name: "FK_Accds_Datas_Location",
                table: "Accds",
                column: "Location",
                principalTable: "Datas",
                principalColumn: "Location",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ptvs_Datas_Location",
                table: "Ptvs",
                column: "Location",
                principalTable: "Datas",
                principalColumn: "Location",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Accds_Datas_Location",
                table: "Accds");

            migrationBuilder.DropForeignKey(
                name: "FK_Ptvs_Datas_Location",
                table: "Ptvs");

            migrationBuilder.DropIndex(
                name: "IX_Ptvs_Location",
                table: "Ptvs");

            migrationBuilder.DropIndex(
                name: "IX_Accds_Location",
                table: "Accds");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Ptvs");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Accds");

            migrationBuilder.AddColumn<string>(
                name: "dataLocation",
                table: "Ptvs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "dataLocation",
                table: "Accds",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ptvs_dataLocation",
                table: "Ptvs",
                column: "dataLocation");

            migrationBuilder.CreateIndex(
                name: "IX_Accds_dataLocation",
                table: "Accds",
                column: "dataLocation");

            migrationBuilder.AddForeignKey(
                name: "FK_Accds_Datas_dataLocation",
                table: "Accds",
                column: "dataLocation",
                principalTable: "Datas",
                principalColumn: "Location",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Ptvs_Datas_dataLocation",
                table: "Ptvs",
                column: "dataLocation",
                principalTable: "Datas",
                principalColumn: "Location",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
