class Musica
{
    public string nomeDaMusica;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome da Música: {nomeDaMusica}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel) { Console.WriteLine("Música disponível no Plano."); }
        else
        {
            Console.WriteLine("Adquira o Plano Super+");
        }
    }
}
