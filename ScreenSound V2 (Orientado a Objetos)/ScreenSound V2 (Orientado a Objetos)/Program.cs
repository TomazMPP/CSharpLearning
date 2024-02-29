Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the Opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};


Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
}; 

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

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