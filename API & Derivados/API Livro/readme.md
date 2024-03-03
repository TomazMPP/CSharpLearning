31. Modelar e desserializar a classe Livro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json)

- [x] Fazer requisição API ✅ 2024-03-03
- [x] Criar classe Livro ✅ 2024-03-03
- [x] Usar no Livro: string Titulo, string Autor, int Ano, string genero, int Paginas ✅ 2024-03-03
- [x] Criar metodo ExibirLivro ✅ 2024-03-03
- [x] Deseralizar ✅ 2024-03-03

```C#
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

```

```C#
using API_Livro;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
        var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
        foreach ( var livro in livros )
        {
            livro.ExibirLivro();
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}
```


## Output: 
```
Livro: O Senhor dos Anéis, de gênero Fantasia, escrito por J.R.R. Tolkien, no ano 1954, com 1178 páginas.

Livro: 1984, de gênero Ficção Científica, escrito por George Orwell, no ano 1949, com 328 páginas.

Livro: Orgulho e Preconceito, de gênero Romance, escrito por Jane Austen, no ano 1813, com 416 páginas.

Livro: Cem Anos de Solidão, de gênero Realismo Mágico, escrito por Gabriel García Márquez, no ano 1967, com 458 páginas.

Livro: A Guerra dos Tronos, de gênero Fantasia, escrito por George R.R. Martin, no ano 1996, com 592 páginas.
```