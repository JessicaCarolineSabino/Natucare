using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Natucare.Migrations
{
    public partial class Inial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CADASTROCLIENTE",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(type: "text", nullable: true),
                    Endereço = table.Column<string>(type: "text", nullable: true),
                    Telefone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTROCLIENTE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CADASTROPRODUTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Linha = table.Column<string>(type: "text", nullable: true),
                    Codigo = table.Column<int>(type: "int", nullable: false),
                    Produto = table.Column<string>(type: "text", nullable: true),
                    PrecoVenda = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTROPRODUTOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "USUARIOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Login = table.Column<string>(type: "text", nullable: true),
                    Senha = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USUARIOS", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VENDAS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    CadastroClienteId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    precoProduto = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18, 2)", nullable: false),
                    Ciclo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VENDAS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_VENDAS_CADASTROCLIENTE_CadastroClienteId",
                        column: x => x.CadastroClienteId,
                        principalTable: "CADASTROCLIENTE",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VENDAS_CADASTROPRODUTOS_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "CADASTROPRODUTOS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_CadastroClienteId",
                table: "VENDAS",
                column: "CadastroClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_VENDAS_ProdutoId",
                table: "VENDAS",
                column: "ProdutoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USUARIOS");

            migrationBuilder.DropTable(
                name: "VENDAS");

            migrationBuilder.DropTable(
                name: "CADASTROCLIENTE");

            migrationBuilder.DropTable(
                name: "CADASTROPRODUTOS");
        }
    }
}
