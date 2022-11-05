using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControleEstoque.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Encomendas",
                columns: table => new
                {
                    NumeroProduto = table.Column<int>(type: "integer", nullable: false),
                    CodigoProduto = table.Column<string>(type: "text", nullable: false),
                    QuantidadeProduto = table.Column<int>(type: "integer", nullable: false),
                    ValorProduto = table.Column<double>(type: "double precision", nullable: false)
                },
                constraints: table =>
                {
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Encomendas");
        }
    }
}
