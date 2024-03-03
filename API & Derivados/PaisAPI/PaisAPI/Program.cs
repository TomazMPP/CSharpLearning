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