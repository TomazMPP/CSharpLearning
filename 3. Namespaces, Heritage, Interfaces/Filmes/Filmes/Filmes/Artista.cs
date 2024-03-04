namespace Alura.Filmes;

class Artista
{
    public Artista(string nome, int idade, List<Filme> filmesAtuados)
    {
        Nome = nome;
        Idade = idade;
        FilmesAtuados = new List<Filme>();
    }

    public string Nome { get; }
    public int Idade { get; }
    public List<Filme> FilmesAtuados { get; set; }

    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
    }
    public void MostrarFilmesAtuados()
    {

        if (this.FilmesAtuados.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base para {this.Nome}");
            return;
        }

        Console.WriteLine($"Filmes de {this.Nome}...");
        foreach (var filme in FilmesAtuados)
        {
            Console.WriteLine($"Filme: {filme.Titulo}");
        }
    }
}