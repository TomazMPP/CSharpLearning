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