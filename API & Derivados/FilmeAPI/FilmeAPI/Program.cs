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