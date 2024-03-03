35. Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.


```C#
using PraticaLinq;

List<Produto> produtos = new List<Produto>
        {
            new Produto { Nome = "Laptop", Preco = 1200 },
            new Produto { Nome = "Smartphone", Preco = 800 },
            new Produto { Nome = "Tablet", Preco = 500 },
            new Produto { Nome = "Câmera", Preco = 300 }
        };

var lista = produtos.Average(p => p.Preco);

Console.WriteLine(lista);

```

```C#
namespace PraticaLinq;

internal class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

```

## Output:

```
700
```