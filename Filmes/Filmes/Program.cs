using Alura.Filmes;

Filme filme1 = new("Limitless", 105, new List<string>() { "Bradley Cooper", "Robert De Niro" });
Filme filme2 = new("De Volta pro Futuro", 160, new List<string>() { "Michael J. Fox", "Christopher Lloyd", "Lea Thompson" });
Filme filme3 = new("De Volta pro Futuro 2", 130, new List<string>() { "Michael J. Fox", "Christopher Lloyd", "Lea Thompson" });
Filme filme4 = new("Oppenheimer", 200, new List<string>() { "Cillian Murphy", "Robert Downey Jr." });
Filme filme5 = new("Homem de Ferro 2", 80, new List<string>() { "Robert Downey Jr.", "Jon Favreau" });

List<Filme> filmeList = new()
{
    filme1,
    filme2,
    filme3,
    filme4,
    filme5
};

foreach (Filme filme in filmeList)
{
    Console.WriteLine($"\n\nFilme: {filme.Titulo} ({filme.Duracao}min.)");
    Console.Write("Elenco: ");
    filme.ListarElenco();
}
