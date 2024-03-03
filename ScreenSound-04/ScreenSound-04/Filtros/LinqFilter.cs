using ScreenSound_04.Modelos;
using System.Linq;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosGeneros(List<Musica> musicas)
    {
        var todosOsGeneros = musicas.Select(generos => generos.Genero).Distinct().ToList();

        foreach (var genero in todosOsGeneros)
        {
            Console.WriteLine(genero);
        }
    }

    public static void FiltrarArtistasPorGenero(List<Musica> musicas, string genero)
    {
        var artistasPorGenero = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();

        Console.WriteLine($"Exibindo os artistas por gênero {genero}");

        foreach (var artist in artistasPorGenero) { Console.WriteLine("- " + artist); }
    }

    public static void FiltrarMusicasDeArtista(List<Musica> musicas, string artista) {
        var musicasDeArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).Select(musica => musica.Nome).ToList();

        Console.WriteLine($"Exibindo as músicas do artista {artista}:");

        foreach (var musica in musicasDeArtista) { Console.WriteLine("- " + musica); }
    }
}
