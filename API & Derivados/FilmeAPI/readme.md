28. Modelar e desserializar a classe Filme, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json)

- [x] Fazer requisição API ✅ 2024-03-03
- [x] Criar classe Filme ✅ 2024-03-03
- [x] Usar no Filme: Nome Completo (string), elenco (string), nota (double) ✅ 2024-03-03
- [x] Criar metodo ✅ 2024-03-03
- [x] Deseralizar ✅ 2024-03-03

```C#
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

```

```C#
using FilmeAPI;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try { 
    string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
        var filmes = JsonSerializer.Deserialize<List<Filme>>(resposta)!;
        filmes[0].ExibirDetalhes();
    }
    catch (Exception ex)
    {
        Console.WriteLine("Erro na requisição: " + ex);
    }
}
```