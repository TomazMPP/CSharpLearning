38. Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo.
39. Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

- [x] Criar Classe Pessoa ✅ 2024-03-03
- [x] Pessoa: string nome, int idade, string email ✅ 2024-03-03
- [x] serializar pessoa em formato json ✅ 2024-03-03
- [x] salvar arquivo json ✅ 2024-03-03
- [x] deserializar arquivo json  e consolewrite ✅ 2024-03-03

```C#
using SerializationPractice;
using System.Text.Json;

Pessoa pessoa = new Pessoa();
Console.Write("Digite o nome: ");
pessoa.Nome = Console.ReadLine();
Console.Write("Digite a idade: ");
pessoa.Idade = int.Parse(Console.ReadLine());
Console.Write("Digite o e-mail: ");
pessoa.Email = Console.ReadLine();

string json = JsonSerializer.Serialize(pessoa);
File.WriteAllText("Pessoa.json", json);

Console.WriteLine($"Json criado com sucesso em: {Path.GetFullPath("Pessoa.json")}");

string filename = "Pessoa.json";

if (File.Exists(filename))
{
    string jsonString = File.ReadAllText(filename);
    Pessoa pessoaNova = JsonSerializer.Deserialize<Pessoa>(jsonString);
    Console.WriteLine();
    Console.WriteLine(pessoaNova.Nome);
    Console.WriteLine(pessoaNova.Idade);
    Console.WriteLine(pessoaNova.Email);
} else
{
    Console.WriteLine("Arquivo não existe ou nome errado.");
}
```

```C#
namespace SerializationPractice;

internal class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

```

## Output:

```
Digite o nome: Tomaz Pontes
Digite a idade: 21
Digite o e-mail: tomazpontes.dev@gmail.com
Json criado com sucesso em: C:\Users\Tomaz\source\repos\SerializationPractice\SerializationPractice\bin\Debug\net7.0\Pessoa.json

Tomaz Pontes
21
tomazpontes.dev@gmail.com
```