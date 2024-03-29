﻿using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuAvaliarMusica : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Música");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write("Agora digite o nome do álbum: ");
            string tituloAlbum = Console.ReadLine()!;
            if (banda.Albuns.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                Album album = banda.Albuns.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write("Agora digite o nome da música: ");
                string nomeMusica = Console.ReadLine()!;
                if (album.Musicas.Any(b => b.Nome.Equals(nomeMusica)))
                {
                    Musica musica = album.Musicas.First(b => b.Nome.Equals(nomeMusica));
                    Console.Write($"Qual a nota que a música {nomeMusica} merece: ");
                    Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
                    musica.AdicionarNota(nota);
                    Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para a música {nomeMusica}");
                    Thread.Sleep(2000);
                    Console.Clear();
                } else
                {
                    Console.WriteLine($"\nA música {nomeMusica} não foi encontrada!");
                    Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                    Console.ReadKey();
                    Console.Clear();
                }
               
            } 
            else
            {
                Console.WriteLine($"\nO Álbum {tituloAlbum} não foi encontrado!");
                Console.WriteLine("Digite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
        else
        {
            Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
