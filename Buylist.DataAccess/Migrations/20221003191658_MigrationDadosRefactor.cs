using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buylist.DataAccess.Migrations
{
    public partial class MigrationDadosRefactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Total",
                table: "TbCompra");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "TbCompra",
                type: "decimal(18,2)",
                nullable: true);
        }
    }
}
