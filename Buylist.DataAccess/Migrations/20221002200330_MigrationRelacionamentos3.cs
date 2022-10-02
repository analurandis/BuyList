using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buylist.DataAccess.Migrations
{
    public partial class MigrationRelacionamentos3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ProdutoId",
                table: "TbProduto",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "LocalId",
                table: "TbLocal",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "TbItem",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "CompraId",
                table: "TbCompra",
                newName: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TbProduto",
                newName: "ProdutoId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TbLocal",
                newName: "LocalId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TbItem",
                newName: "ItemId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TbCompra",
                newName: "CompraId");
        }
    }
}
