using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buylist.DataAccess.Migrations
{
    public partial class CreateProduto3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbItem_TB_PRODUTO_ProdutoId",
                table: "TbItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TB_PRODUTO",
                table: "TB_PRODUTO");

            migrationBuilder.RenameTable(
                name: "TB_PRODUTO",
                newName: "TbProduto");

            migrationBuilder.RenameColumn(
                name: "COM_EAN",
                table: "TbProduto",
                newName: "CodigoBarras");

            migrationBuilder.RenameColumn(
                name: "COM_DESCRICAO",
                table: "TbProduto",
                newName: "Descricao");

            migrationBuilder.RenameColumn(
                name: "COM_ID",
                table: "TbProduto",
                newName: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TbProduto",
                table: "TbProduto",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TbItem_TbProduto_ProdutoId",
                table: "TbItem",
                column: "ProdutoId",
                principalTable: "TbProduto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TbItem_TbProduto_ProdutoId",
                table: "TbItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TbProduto",
                table: "TbProduto");

            migrationBuilder.RenameTable(
                name: "TbProduto",
                newName: "TB_PRODUTO");

            migrationBuilder.RenameColumn(
                name: "Descricao",
                table: "TB_PRODUTO",
                newName: "COM_DESCRICAO");

            migrationBuilder.RenameColumn(
                name: "CodigoBarras",
                table: "TB_PRODUTO",
                newName: "COM_EAN");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "TB_PRODUTO",
                newName: "COM_ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TB_PRODUTO",
                table: "TB_PRODUTO",
                column: "COM_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TbItem_TB_PRODUTO_ProdutoId",
                table: "TbItem",
                column: "ProdutoId",
                principalTable: "TB_PRODUTO",
                principalColumn: "COM_ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
