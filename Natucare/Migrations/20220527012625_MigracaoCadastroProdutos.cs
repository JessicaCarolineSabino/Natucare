using Microsoft.EntityFrameworkCore.Migrations;
using MySql.EntityFrameworkCore.Metadata;

namespace Natucare.Migrations
{
    public partial class MigracaoCadastroProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CADASTROPRODUTOS",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Linha = table.Column<string>(type: "text", nullable: true),
                    Código = table.Column<int>(type: "int", nullable: false),
                    Produto = table.Column<string>(type: "text", nullable: true),
                    PreçoVenda = table.Column<int>(type: "int", nullable: false),
                    QuantidadeEstoque = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CADASTROPRODUTOS", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CADASTROPRODUTOS");
        }
    }
}
