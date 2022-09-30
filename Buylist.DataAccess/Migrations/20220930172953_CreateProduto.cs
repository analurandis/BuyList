using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buylist.DataAccess.Migrations
{
    public partial class CreateProduto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TB_PRODUTO",
                columns: table => new
                {
                    COM_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    COM_EAN = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    COM_DESCRICAO = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TB_PRODUTO", x => x.COM_ID);
                });

            migrationBuilder.CreateTable(
                name: "TbLocal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Localizacao = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbLocal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TbCompra",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Finalizada = table.Column<bool>(type: "bit", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    LocalId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbCompra", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbCompra_TbLocal_LocalId",
                        column: x => x.LocalId,
                        principalTable: "TbLocal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TbItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Valor = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    CompraId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TbItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TbItem_TB_PRODUTO_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "TB_PRODUTO",
                        principalColumn: "COM_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TbItem_TbCompra_CompraId",
                        column: x => x.CompraId,
                        principalTable: "TbCompra",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TbCompra_LocalId",
                table: "TbCompra",
                column: "LocalId");

            migrationBuilder.CreateIndex(
                name: "IX_TbItem_CompraId",
                table: "TbItem",
                column: "CompraId");

            migrationBuilder.CreateIndex(
                name: "IX_TbItem_ProdutoId",
                table: "TbItem",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TbItem");

            migrationBuilder.DropTable(
                name: "TB_PRODUTO");

            migrationBuilder.DropTable(
                name: "TbCompra");

            migrationBuilder.DropTable(
                name: "TbLocal");
        }
    }
}
