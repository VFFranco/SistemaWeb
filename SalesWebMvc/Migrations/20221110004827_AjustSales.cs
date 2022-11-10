using Microsoft.EntityFrameworkCore.Migrations;

namespace SalesWebMvc.Migrations
{
    public partial class AjustSales : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "SaleStatus",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SaleStatus",
                table: "SalesRecord");

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "SalesRecord",
                nullable: false,
                defaultValue: 0);
        }
    }
}
