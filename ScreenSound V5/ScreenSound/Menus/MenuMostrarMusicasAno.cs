using ScreenSound.Banco;
using ScreenSound.Modelos;

namespace ScreenSound.Menus;

internal class MenuMostrarMusicasAno : Menu
{
    public override void Executar(DAL<Artista> artistaDAL)
    {
        base.Executar(artistaDAL);
        ExibirTituloDaOpcao("Músicas por Ano");
        Console.Write("Digite o ano que deseja filtrar as músicas: ");
        string anoString = Console.ReadLine()!;
        var musicaDAL = new DAL<Musica>(new ScreenSoundContext());
        var listaAnoLancamento = musicaDAL.EnumerarPor(a => a.AnoLancamento == Convert.ToInt32(anoString));
        if (listaAnoLancamento.Any())
        {
            foreach (var musica in listaAnoLancamento)
            {
                musica.ExibirFichaTecnica();
                Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }
        }
        else
        {
            Console.WriteLine($"Nenhuma música registrada no ano {anoString}!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
