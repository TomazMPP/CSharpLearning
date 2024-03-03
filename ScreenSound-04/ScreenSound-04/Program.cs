using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;


using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;
        // LinqFilter.FiltrarTodosGeneros(musicas);
        // LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
        //   LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        LinqFilter.FiltrarMusicasDeArtista(musicas, "Taylor Swift");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}