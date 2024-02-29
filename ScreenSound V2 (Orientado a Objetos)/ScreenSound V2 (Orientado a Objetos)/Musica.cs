class Musica
{
    public Genero Genero { get; set; }
    public string NomeDaMusica { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public bool Disponivel {  get; set; }

    public string DescricaoResumida => $"A música {NomeDaMusica} pertence a banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {NomeDaMusica}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        Console.WriteLine($"Gênero: {Genero}");
        if (Disponivel) { Console.WriteLine("Música disponível no Plano."); }
        else
        {
            Console.WriteLine("Adquira o Plano Super+");
        }
    }
}
