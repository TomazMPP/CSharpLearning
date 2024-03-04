using APICarro;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json");
        var carros = JsonSerializer.Deserialize<List<Carro>>(resposta)!;
        foreach (var carro in carros)
        {
            carro.ExibirCarro();
        }


    } catch (Exception ex)
    {
        Console.WriteLine(ex);
    }
}