using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class MakingSingleDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AccdName",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccdTypePreferenceOrder1",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccdTypePreferenceOrder2",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccdTypePreferenceOrder3",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AccdTypePreferenceOrder4",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtvName",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtvTypePreferenceOrder1",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtvTypePreferenceOrder2",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtvTypePreferenceOrder3",
                table: "Datas",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PtvTypePreferenceOrder4",
                table: "Datas",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Accds",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccdName",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "AccdTypePreferenceOrder1",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "AccdTypePreferenceOrder2",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "AccdTypePreferenceOrder3",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "AccdTypePreferenceOrder4",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "PtvName",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "PtvTypePreferenceOrder1",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "PtvTypePreferenceOrder2",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "PtvTypePreferenceOrder3",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "PtvTypePreferenceOrder4",
                table: "Datas");

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Ptvs",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Accds",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

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
    }
}
