using System.Text.Json.Serialization;

namespace FilmeAPI;

internal class Filme
{
    [JsonPropertyName("fullTitle")]
    public string? NomeCompleto { get; set; }
    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }
    [JsonPropertyName("imDbRating")]
    public string Nota { get; set; }

        public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome do Filme: {NomeCompleto}");
        Console.WriteLine($"Elenco: {Elenco}");
        Console.WriteLine($"Nota IMDB: {Nota}");
    }
}
