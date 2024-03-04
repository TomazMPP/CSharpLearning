5. Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

- [x] Criar classe catalogo ✅ 2024-02-29
- [x] Criar classe jogo ✅ 2024-02-29
- [x] Jogo: string nome, int anolancamento, string plataforma ✅ 2024-02-29
- [x] Catalogo: list jogo, metodos info, construtores inicialização ✅ 2024-02-29

```C#
class Jogo
{
    public Jogo(string nome, int anoLancamento, string plataforma)
    {
        Nome = nome;
        AnoLancamento = anoLancamento;
        Plataforma = plataforma;
    }

    public string Nome { get; }
    public int AnoLancamento { get; }
    public string Plataforma { get; }
}
```

```C#
class Catalogo
{
    public List<Jogo> Jogos { get; set; }

    public bool CatalogoVazio => Jogos.Count == 0;

    public Catalogo(List<Jogo> jogos)
    {
        Jogos = new List<Jogo>();
    }

   
    public void AdicionarJogo(string nome, int anoLancamento, string plataforma)
    {
        Jogo novoJogo = new Jogo(nome, anoLancamento, plataforma);
        Jogos.Add(novoJogo);
        Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");
    }

    public void ListarJogos()
    {
        if (CatalogoVazio)
        {
            Console.WriteLine("O catálogo de jogos está vazio.");
        }
        else
        {
            Console.WriteLine("Catálogo de Jogos:");
            foreach (var jogo in Jogos)
            {
                Console.WriteLine($"Nome: {jogo.Nome}, Ano de Lançamento: {jogo.AnoLancamento}, Plataforma: {jogo.Plataforma}");
            }
        }
    }
}
```

```C#
List<Jogo> listaJogos = new List<Jogo>();
Catalogo cata1 = new Catalogo(listaJogos);

cata1.AdicionarJogo("Teste", 2024, "Xbox");
cata1.ListarJogos();
```