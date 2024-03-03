33. Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

```C#
List<Livro> livros = new List<Livro>
{
    new Livro { Titulo = "Aprendendo LINQ", Autor = "João Silva", AnoPublicacao = 2005 },
    new Livro { Titulo = "Programação em C#", Autor = "Ana Oliveira", AnoPublicacao = 2010 },
    new Livro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Carlos Santos", AnoPublicacao = 1998 },
    new Livro { Titulo = "Introdução à Inteligência Artificial", Autor = "Mariana Costa", AnoPublicacao = 2021 },
    new Livro { Titulo = "Design Patterns", Autor = "Paulo Rocha", AnoPublicacao = 2002 }
};

var livrosOrdenados = livros.Where(livros => livros.AnoPublicacao > 2000).OrderBy(livros => livros.Titulo).Select(livros => livros.Titulo).ToList();

Console.WriteLine("Títulos de livros publicados após 2000, ordenados alfabeticamente:");
foreach (var titulo in livrosOrdenados)
{
    Console.WriteLine(titulo.Titulo);
}
```

```C#
class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public int AnoPublicacao { get; set; }
}
```

## Output:

```
Títulos de livros publicados após 2000, ordenados alfabeticamente:
Aprendendo LINQ
Design Patterns
Introdução à Inteligência Artificial
Programação em C#
```
