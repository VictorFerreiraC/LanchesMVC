using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace lanchesMVC.Migrations
{
    /// <inheritdoc />
    public partial class PopularCategorias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao) VALUES ('Normal', 'lanche normal');");
            migrationBuilder.Sql("INSERT INTO Categorias (Nome, Descricao) VALUES ('Natural', 'lanche natural');");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias;");
        }
    }
}
