using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CodeFirstFilmes.Migrations
{
    /// <inheritdoc />
    public partial class AjusteDecimalNota : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnoLanncamento",
                table: "Filmes",
                newName: "AnoLancamento");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AnoLancamento",
                table: "Filmes",
                newName: "AnoLanncamento");
        }
    }
}
