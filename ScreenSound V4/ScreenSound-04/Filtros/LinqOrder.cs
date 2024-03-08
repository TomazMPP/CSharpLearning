using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musicas => musicas.Artista).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine("Lista Ordenada de Artistas:");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}
