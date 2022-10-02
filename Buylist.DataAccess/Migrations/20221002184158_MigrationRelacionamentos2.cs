using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buylist.DataAccess.Migrations
{
    public partial class MigrationRelacionamentos2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbItem_TbCompra_CompraId",
                table: "TbItem");

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

            migrationBuilder.AlterColumn<int>(
                name: "CompraId",
                table: "TbItem",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_TbItem_TbCompra_CompraId",
                table: "TbItem",
                column: "CompraId",
                principalTable: "TbCompra",
                principalColumn: "CompraId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbItem_TbCompra_CompraId",
                table: "TbItem");

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

            migrationBuilder.AlterColumn<int>(
                name: "CompraId",
                table: "TbItem",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_TbItem_TbCompra_CompraId",
                table: "TbItem",
                column: "CompraId",
                principalTable: "TbCompra",
                principalColumn: "Id");
        }
    }
}
