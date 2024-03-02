1. Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.

- [x] Criar Classe Produto ✅ 2024-02-29
- [x] Produto: double Preco, int Estoque, string Nome, string Marca ✅ 2024-02-29
- [x] Criar Classe EstoqueDeProduto ✅ 2024-02-29
- [x] Estoque: Produto List< produtos>, método exibir produtos, metodo adicionar produtos ✅ 2024-02-29

```C#
class Produto {
    public string Nome { get; set; }
    private double preco;
    private int estoque;
    public string Marca { get; set; }

public double Preco
    { get => preco; set {
            if (value > 0)
            {
                preco = value;
            } else
            {
                preco = 10;
            }
        }
    }
    
    public int Estoque
{  get => estoque; set {
        if (value > 0)
            estoque = value;
        else
            estoque = 0;

    }
}
public string Descricao => $"{this.Nome} {this.Marca} - R${this.Preco} - Quantidade: {this.Estoque}";
}

```

```C#
class EstoqueDeProdutos {

    private List<Produto> Produtos { get; set; }  = new List<Produto>();

    public void ExibirProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
    public void AdicionarProdutos(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque.");
    }
}
```

```C#
Produto produto1 = new Produto();
EstoqueDeProdutos estoqueDeProdutos = new EstoqueDeProdutos();

produto1.Nome = "Maçã";
produto1.Marca = "Seara";
produto1.Estoque = 12;
produto1.Preco = 1.90;

estoqueDeProdutos.AdicionarProdutos(produto1);
estoqueDeProdutos.ExibirProdutos();
```