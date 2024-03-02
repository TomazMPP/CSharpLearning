7. ✅  Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace **Alura.Filmes**.
8. ✅  Criar um programa `Program.cs`, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
9. ✅  Criar uma classe `Artista`, que representa uma pessoa que atua em filmes, no namespace `Alura.Filmes`. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
10. Modificar as classes `Artista` e `Filme` do namespace `Alura.Filmes` para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.

- [x] Criar classe Filme ✅ 2024-02-29
- [x] Filme: string Titulo, int Duracao, list Elenco ✅ 2024-02-29
- [x] Criar namespace Alura.Filmes ✅ 2024-02-29
- [x] Criar 5 filmes favoritos e adicionar em uma lista, e mostrar no console. ✅ 2024-02-29
- [x] Criar classe Artista, no namespace Alura.Filmes ✅ 2024-02-29
- [x] Artista: string Nome, int Idade, list Filmes ✅ 2024-02-29
- [x] Classes Consistentes ✅ 2024-03-01

```C#
namespace Alura.Filmes;

class Artista
{
    public Artista(string nome, int idade, List<Filme> filmesAtuados)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> FilmesAtuados { get; set; }

    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
    }
    public void MostrarFilmesAtuados()
    {

        if (this.FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
            return;
        }

        Console.WriteLine($"Filmes de {this.Nome}...");
        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}
```

```C#
namespace Alura.Filmes;

class Filme {

    public string Titulo { get; }
    public int Duracao { get; }
    public List<String> Elenco = new List<string>();

    public Filme(string titulo, int duracao, List<string> elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        if (elenco == null)
        {
            Elenco = new List<string>();
        } else
        {
            Elenco = elenco;
        }
    }

    public void AdicionarElenco(string ator)
    {
        Elenco.Add(ator);
        Console.WriteLine($"{ator} adicionado ao elenco.");
    }

    public void ListarElenco()
    {
        if ( Elenco.Count == 0 )
        {
            Console.WriteLine($"Elenco vazio");
        } else
        {
            foreach (var ator in Elenco )
            {
                Console.Write($"{ator}, ");
            }
        }
    }
}```

```C#
using Alura.Filmes;

Filme filme1 = new("Limitless", 105, new List<string>() { "Bradley Cooper", "Robert De Niro" });
Filme filme2 = new("De Volta pro Futuro", 160, new List<string>() { "Michael J. Fox", "Christopher Lloyd", "Lea Thompson" });
Filme filme3 = new("De Volta pro Futuro 2", 130, new List<string>() { "Michael J. Fox", "Christopher Lloyd", "Lea Thompson" });
Filme filme4 = new("Oppenheimer", 200, new List<string>() { "Cillian Murphy", "Robert Downey Jr." });
Filme filme5 = new("Homem de Ferro 2", 80, new List<string>() { "Robert Downey Jr.", "Jon Favreau" });

List<Filme> filmeList = new()
{
    filme1,
    filme2,
    filme3,
    filme4,
    filme5
};

foreach (Filme filme in filmeList)
{
    Console.WriteLine($"\n\nFilme: {filme.Titulo} ({filme.Duracao}min.)");
    Console.Write("Elenco: ");
    filme.ListarElenco();
}

```