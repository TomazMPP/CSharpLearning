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