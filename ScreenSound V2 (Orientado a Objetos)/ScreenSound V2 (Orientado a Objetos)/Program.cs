Musica musica1 = new Musica();
musica1.NomeDaMusica = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;

Musica musica2 = new Musica();
musica2.NomeDaMusica = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;

musica1.ExibirFichaTecnica();
Console.WriteLine(musica1.DescricaoResumida);
Console.WriteLine();
musica2.ExibirFichaTecnica();
Console.WriteLine(musica2.DescricaoResumida);
