class Album
{

    private List<Musica> musicas = new List<Musica>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicas() {
        Console.WriteLine($"Lista de músicas do album > {Nome} <:");
        foreach (Musica musica in musicas)
        {
            Console.WriteLine($"Música: {musica.NomeDaMusica}");
        }
        Console.WriteLine($"Duração total do album em segundos: {DuracaoTotal}");
    }
}