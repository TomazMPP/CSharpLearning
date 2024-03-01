namespace Alura.Filmes;

class Filme {

    public string Titulo { get; }
    public int Duracao { get; }
    public List<String> Elenco = new List<string>();

    public Filme(string titulo, int duracao, List<string> elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        if (elenco == null)
        {
            Elenco = new List<string>();
        } else
        {
            Elenco = elenco;
        }
    }

    public void AdicionarElenco(string ator)
    {
        Elenco.Add(ator);
        Console.WriteLine($"{ator} adicionado ao elenco.");
    }

    public void ListarElenco()
    {
        if ( Elenco.Count == 0 )
        {
            Console.WriteLine($"Elenco vazio");
        } else
        {
            foreach (var ator in Elenco )
            {
                Console.Write($"{ator}, ");
            }
        }
    }
}