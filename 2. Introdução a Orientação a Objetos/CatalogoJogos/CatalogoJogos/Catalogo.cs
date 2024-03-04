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