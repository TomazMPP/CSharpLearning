30. Modelar e desserializar a classe Carro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json)

- [x] Fazer requisição API ✅ 2024-03-03
- [x] Criar classe Carro ✅ 2024-03-03
- [x] Usar no Carro: string Marca, string Modelo, int Ano, string, tipo, string transmissao, string autonomia ✅ 2024-03-03
- [x] Criar metodo ExibirCarro ✅ 2024-03-03
- [x] Deseralizar ✅ 2024-03-03

```C#
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

```

```C#
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
```

## Output:

```
Toyota Corolla - 2022 (Sedan - Transmissão: Automática)
Honda Civic - 2022 (Sedan - Transmissão: CVT)
Ford Mustang - 2022 (Coupé - Transmissão: Manual)
Tesla Model 3 - 2022 (Elétrico - Autonomia: 450 km)
Chevrolet Silverado - 2022 (Caminhonete - Transmissão: Automática)
```