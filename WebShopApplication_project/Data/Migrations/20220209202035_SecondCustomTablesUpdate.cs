using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopApplication_project.Data.Migrations
{
    public partial class SecondCustomTablesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Whith",
                table: "Articles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Price",
                table: "Articles",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "NetWweight",
                table: "Articles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Hight",
                table: "Articles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "GrossWeight",
                table: "Articles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Depth",
                table: "Articles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(double),
                oldType: "float",
                oldMaxLength: 50);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Whith",
                table: "Articles",
                type: "float",
                maxLength: 50,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Articles",
                type: "float",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<double>(
                name: "NetWweight",
                table: "Articles",
                type: "float",
                maxLength: 50,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Hight",
                table: "Articles",
                type: "float",
                maxLength: 50,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "GrossWeight",
                table: "Articles",
                type: "float",
                maxLength: 50,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "Depth",
                table: "Articles",
                type: "float",
                maxLength: 50,
                nullable: false,
                defaultValue: 0.0,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);
        }
    }
}
