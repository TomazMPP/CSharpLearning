using System.Text.Json.Serialization;

namespace APICarro;

internal class Carro
{
    [JsonPropertyName("marca")]
    public string Marca { get; set; }
    [JsonPropertyName("modelo")]
    public string Modelo { get; set; }
    [JsonPropertyName("ano")]
    public int Ano { get; set; }
    [JsonPropertyName("tipo")]
    public string Tipo { get; set; }
    [JsonPropertyName("transmissao")]
    public string Transmissao { get; set; }
    [JsonPropertyName("autonomia")]
    public string Autonomia { get; set; }

    public void ExibirCarro()
    {
        if (Tipo == "Elétrico")
        {
            Console.WriteLine($"{Marca} {Modelo} - {Ano} ({Tipo} - Autonomia: {Autonomia})");
        } else { 
        Console.WriteLine($"{Marca} {Modelo} - {Ano} ({Tipo} - Transmissão: {Transmissao})");
        }
    }
}
