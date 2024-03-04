using System.Text.Json.Serialization;

namespace PaisAPI;

internal class Pais
{
    [JsonPropertyName("nome")]
    public string? Nome { get; set; }
    [JsonPropertyName("capital")]
    public string? Capital { get; set; }
    [JsonPropertyName("populacao")]
    public int Populacao { get; set; }
    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }

    public void ExibirPais()
    {
        Console.WriteLine($"Nome do País: {Nome}");
        Console.WriteLine($"Nome da Capital: {Capital}");
        Console.WriteLine($"População do país: {Populacao}");
        Console.WriteLine($"Idioma falado: {Idioma}\n");
    }
}
