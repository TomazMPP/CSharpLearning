using System.Text.Json.Serialization;

namespace API_Livro;

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string Titulo { get; set; }
    [JsonPropertyName("autor")]
    public string Autor { get; set; }
    [JsonPropertyName("ano_publicacao")]
    public int Ano { get; set; }
    [JsonPropertyName("genero")]
    public string Genero { get; set; }
    [JsonPropertyName("paginas")]
    public int Paginas { get; set; }

    public void ExibirLivro()
    {
        Console.WriteLine($"Livro: {Titulo}, de gênero {Genero}, escrito por {Autor}, no ano {Ano}, com {Paginas} páginas.\n");
    }
}
