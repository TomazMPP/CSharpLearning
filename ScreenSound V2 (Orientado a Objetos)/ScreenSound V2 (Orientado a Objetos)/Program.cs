Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the Opera";

Musica musica1 = new Musica();
musica1.NomeDaMusica = "Love of my life";
musica1.Duracao = 213;

Musica musica2 = new Musica();
musica2.NomeDaMusica = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

