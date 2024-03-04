29. Modelar e desserializar a classe Pais, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json)

- [x] Fazer requisição API  ✅ 2024-03-03
- [x] Criar classe Pais ✅ 2024-03-03
- [x] Usar no País: Nome (string), Capital (string), Populacao (int), idioma (string) ✅ 2024-03-03
- [x] Criar metodo ✅ 2024-03-03
- [x] Deseralizar ✅ 2024-03-03

```C#
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

```

```C#
using PaisAPI;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
        var paises = JsonSerializer.Deserialize<List<Pais>>(resposta)!;

        foreach (var pais in paises)
        {
            pais.ExibirPais();
        }
    }
    catch (Exception ex) {
        Console.WriteLine(ex);
    }
}
```

## Output:

```
Nome do País: Brasil
Nome da Capital: Brasília
População do país: 211049527
Idioma falado: Português

Nome do País: Estados Unidos
Nome da Capital: Washington, D.C.
População do país: 331002651
Idioma falado: Inglês

Nome do País: China
Nome da Capital: Pequim
População do país: 1444216107
Idioma falado: Mandarim

Nome do País: Índia
Nome da Capital: Nova Delhi
População do país: 1380004385
Idioma falado: Hindi, Inglês

Nome do País: Rússia
Nome da Capital: Moscou
População do país: 145934462
Idioma falado: Russo
````