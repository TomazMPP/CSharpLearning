40. ✅ Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.
41. ✅ Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.
42. ✅ Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.


```C#
using SerializationPractice;
using System.Text.Json;

List<Pessoa> pessoas = new List<Pessoa>();

while (true)
{
    Pessoa pessoa = new Pessoa();
    Console.Write("Digite o nome (ou 'sair' para encerrar): ");
    string nome = Console.ReadLine();

    if (nome == "sair")
    {
        break;
    }

    pessoa.Nome = nome;
    Console.Write("Digite a idade: ");
    pessoa.Idade = int.Parse(Console.ReadLine());
    Console.Write("Digite o e-mail: ");
    pessoa.Email = Console.ReadLine();
    pessoas.Add(pessoa);
}

string json = JsonSerializer.Serialize(pessoas);
File.WriteAllText("pessoasgeradas.json", json);
Console.WriteLine($"Json criado com sucesso em: {Path.GetFullPath("pessoasgearadas.json")}");

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

```C#
string json = JsonSerializer.Serialize(pessoas);
File.WriteAllText("pessoasgeradas.json", json);
Console.WriteLine($"Json criado com sucesso em: {Path.GetFullPath("pessoasgearadas.json")}");

if (File.Exists("pessoasgeradas.json")) {

    string jsonString = File.ReadAllText("pessoasgeradas.json");
    List<Pessoa> pessoasDes = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
    foreach (Pessoa pessoa in pessoasDes)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
    }
}
else
{
    Console.WriteLine($"O arquivo {"pessoasgeradas.json"} não existe.");
};

```

```C#
if (File.Exists("pessoasgeradas.json")) {

    string jsonString = File.ReadAllText("pessoasgeradas.json");
    List<Pessoa> pessoasDes = JsonSerializer.Deserialize<List<Pessoa>>(jsonString);
    Console.Write("Insira uma idade para ver pessoas com essa idade (Dica: 21, 20, 50): ");
    string idadeString = Console.ReadLine()!;
    int idade = int.Parse(idadeString);
    var pessoasComIdade = pessoasDes.Where(pessoa => pessoa.Idade == idade);
    Console.WriteLine($"Pessoas com {idade} anos: ");
    foreach (Pessoa pessoa in pessoasComIdade)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, E-mail: {pessoa.Email}");
  }
}
else
{
    Console.WriteLine($"O arquivo {"pessoasgeradas.json"} não existe.");
};
```
## Output:

```
Digite o nome (ou 'sair' para encerrar): tomaz pontes
Digite a idade: 21
Digite o e-mail: tomazpontes.dev@gmail.com
Digite o nome (ou 'sair' para encerrar): joao
Digite a idade: 20
Digite o e-mail: joao@gmail.com
Digite o nome (ou 'sair' para encerrar): jose
Digite a idade: 50
Digite o e-mail: jose@gmail.com
Digite o nome (ou 'sair' para encerrar): sair

Json criado com sucesso em: C:\Users\Tomaz\source\repos\SerializationPractice\SerializationPractice\bin\Debug\net7.0\pessoasgearadas.json

Nome: tomaz pontes, Idade: 21, E-mail: tomazpontes.dev@gmail.com
Nome: joao, Idade: 20, E-mail: joao@gmail.com
Nome: jose, Idade: 50, E-mail: jose@gmail.com
```

```
Insira uma idade para ver pessoas com essa idade (Dica: 21, 20, 50): 21
Pessoas com 21 anos:
Nome: tomaz pontes, Idade: 21, E-mail: tomazpontes.dev@gmail.com
```