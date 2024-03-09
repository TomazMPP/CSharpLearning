using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScreenSound.Migrations
{
    /// <inheritdoc />
    public partial class AtualizarMusicasExistentes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_artistaId",
                table: "Musicas");

            migrationBuilder.RenameColumn(
                name: "artistaId",
                table: "Musicas",
                newName: "ArtistaId");

            migrationBuilder.RenameIndex(
                name: "IX_Musicas_artistaId",
                table: "Musicas",
                newName: "IX_Musicas_ArtistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id");

            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 1");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 2");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 3");
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 1 WHERE Id = 4");
            migrationBuilder.InsertData("Artistas", new string[] { "Nome", "Bio", "FotoPerfil" }, new object[] { "Coldplay", "Coldplay é uma banda britânica de rock fundada em 1996 na Inglaterra pelo vocalista e pianista Chris Martin e o guitarrista Jonny Buckland no University College London.", "https://i.scdn.co/image/ab6761610000e5eb989ed05e1f0570cc4726c2d3" });
            migrationBuilder.InsertData("Musicas", new string[] { "Nome", "AnoLancamento", "ArtistaId" }, new object[] { "Viva la Vida", 2008, 8 });
            migrationBuilder.Sql("UPDATE Musicas SET ArtistaId = 8 WHERE Id = 5");

        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Musicas_Artistas_ArtistaId",
                table: "Musicas");

            migrationBuilder.RenameColumn(
                name: "ArtistaId",
                table: "Musicas",
                newName: "artistaId");

            migrationBuilder.RenameIndex(
                name: "IX_Musicas_ArtistaId",
                table: "Musicas",
                newName: "IX_Musicas_artistaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Musicas_Artistas_artistaId",
                table: "Musicas",
                column: "ArtistaId",
                principalTable: "Artistas",
                principalColumn: "Id");
        }
    }
}
