![[Pasted image 20240229184839.png]]

- Podcast nasce com Host e Nome
- ExibirDetalhes = deve mostrar nome do podcast e seu host na primeira linha. E em seguida, sua lista de episódios ordenados por sequência e por fim um total de episódios
- Resumo do episodio será concatenado com Número, Titulo e Convidados

- [x] Criar classe episódio ✅ 2024-02-29
- [x] Criar propriedades (Constructor em Titulo e Ordem) ✅ 2024-02-29
- [x] Criar metodo adicionarConvidados ✅ 2024-02-29
- [x] Criar classe Podcast ✅ 2024-02-29
- [x] Criar propriedades (Constructor em Host e Nome), talvez List em total episodios? ✅ 2024-02-29
- [x] Criar metodo adicionarConvidados ✅ 2024-02-29
- [x] Criar metodo AdicionarEpisodio ✅ 2024-02-29
- [x] Criar metodo ExibirDetalhes ✅ 2024-02-29

```C#
class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public List<string> Convidados = new List<string>();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} - Convidados: {string.Join(", ", Convidados)}";
    public string Titulo { get; }

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}
```

```C#
class Podcast {
    public Podcast(string host, string nome)
    {
        Host = host;
        Nome = nome;
    }

    public string Host { get; }
    public string Nome { get; }
    private List<Episodio> TotalEpisodios = new List<Episodio>();
    public int Total => TotalEpisodios.Count;
    public void AdicionarEpisodio(Episodio episodio)
    {
        TotalEpisodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome}, Host: {Host}\n");
        Console.WriteLine($"Todos os {TotalEpisodios.Count} podcasts feitos abaixo:");
        foreach (Episodio episodio in TotalEpisodios)
        {
            Console.WriteLine(episodio.Titulo);
        }
    }
}
```

```C#
Episodio episodio1 = new Episodio(1, "Isso e um teste", 660);
episodio1.AdicionarConvidado("Tomazino Pontesco");
Episodio episodio2 = new Episodio(1, "Isso e um teste2", 260);
episodio2.AdicionarConvidado("Tomazino Pontessaasco");
episodio2.AdicionarConvidado("Tomatestiano");

Podcast podcast1 = new Podcast("Tomaresco Martiney", "Podcast do Tomaresco");
podcast1.AdicionarEpisodio(episodio1);
podcast1.AdicionarEpisodio(episodio2);
podcast1.ExibirDetalhes();
Console.WriteLine(episodio1.Resumo);
Console.WriteLine(episodio2.Resumo);
```