class Musica
{
    public Musica(Banda artista, string nomeDaMusica)
    {
        Artista = artista;
        NomeDaMusica = nomeDaMusica;
    }

    public Genero Genero { get; set; }
    public string NomeDaMusica { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }

    public string DescricaoResumida => $"A música {NomeDaMusica} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero}");
        if (Disponivel) { Console.WriteLine("Música disponível no Plano."); }
        else
        {
            Console.WriteLine("Adquira o Plano Super+");
        }
    }
}
