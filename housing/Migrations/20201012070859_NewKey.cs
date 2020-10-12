using Microsoft.EntityFrameworkCore.Migrations;

namespace housing.Migrations
{
    public partial class NewKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Datas",
                table: "Datas");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Datas",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Datas",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Datas",
                table: "Datas",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Datas",
                table: "Datas");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Datas");

            migrationBuilder.AlterColumn<string>(
                name: "Location",
                table: "Datas",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Datas",
                table: "Datas",
                column: "Location");
        }
    }
}
