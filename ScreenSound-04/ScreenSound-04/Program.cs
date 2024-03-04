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
        //  LinqFilter.FiltrarArtistasPorGenero(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeArtista(musicas, "Taylor Swift");
        LinqFilter.FiltrarMusicasPorKey(musicas, "C#");

        var musicasPreferidasDoTomaz = new MusicasPreferidas("Tomaz");
        musicasPreferidasDoTomaz.AdicionarMusicasFavoritas(musicas[100]);
        musicasPreferidasDoTomaz.AdicionarMusicasFavoritas(musicas[200]);
        musicasPreferidasDoTomaz.AdicionarMusicasFavoritas(musicas[300]);
        musicasPreferidasDoTomaz.AdicionarMusicasFavoritas(musicas[400]);
        musicasPreferidasDoTomaz.AdicionarMusicasFavoritas(musicas[500]);

     //  musicasPreferidasDoTomaz.ExibirMusicasFavoritas();

      //  musicasPreferidasDoTomaz.GerarArquivoJson();

        var musicasPreferidasDoJoaozinho = new MusicasPreferidas("Joaozinho");
        musicasPreferidasDoJoaozinho.AdicionarMusicasFavoritas(musicas[600]);
        musicasPreferidasDoJoaozinho.AdicionarMusicasFavoritas(musicas[700]);
        musicasPreferidasDoJoaozinho.AdicionarMusicasFavoritas(musicas[800]);
        musicasPreferidasDoJoaozinho.AdicionarMusicasFavoritas(musicas[900]);
        musicasPreferidasDoJoaozinho.AdicionarMusicasFavoritas(musicas[1000]);
        //musicasPreferidasDoJoaozinho.ExibirMusicasFavoritas();

       
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}