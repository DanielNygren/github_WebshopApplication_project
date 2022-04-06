using Microsoft.EntityFrameworkCore.Migrations;

namespace WebShopApplication_project.Data.Migrations
{
    public partial class updatedDbContext : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockLocationID",
                table: "Stocks",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StockLocation",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StockLocation", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stocks_StockLocationID",
                table: "Stocks",
                column: "StockLocationID");

            migrationBuilder.AddForeignKey(
                name: "FK_Stocks_StockLocation_StockLocationID",
                table: "Stocks",
                column: "StockLocationID",
                principalTable: "StockLocation",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Stocks_StockLocation_StockLocationID",
                table: "Stocks");

            migrationBuilder.DropTable(
                name: "StockLocation");

            migrationBuilder.DropIndex(
                name: "IX_Stocks_StockLocationID",
                table: "Stocks");

            migrationBuilder.DropColumn(
                name: "StockLocationID",
                table: "Stocks");
        }
    }
}
