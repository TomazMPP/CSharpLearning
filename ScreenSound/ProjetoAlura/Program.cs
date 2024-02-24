String mensagemDeBoasVindas = "Seja bem-vindo ao Screen Sound";
// List<string> listaDasBandas = new List<string> { "Pink Floyd", "Beatles", "U2" };
Dictionary<string, List<int>> bandasRegistradas =  new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> { 10, 10, 9, 8 });
bandasRegistradas.Add("Pink Floyd", new List<int>());
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    String opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    
    switch (opcaoEscolhidaNumerica)
    {
        case 1: RegistrarBanda(); break;
            case 2: MostrarBandas(); break;
            case 3: NotasDeBandas(); break;
            case 4: MediaDeNotas(); break;
            case -1: Console.WriteLine("Tchau :)"); break;
        default: Console.WriteLine("Opção inválida"); break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTitulo("Registro de Bandas");
    Console.Write("\nDigite o nome da banda que deseja registrar: ");
    String nomeDaBanda = Console.ReadLine()!;
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine("A banda {0} foi registrada com sucesso!", nomeDaBanda);
    Thread.Sleep(2000);
    Console.Clear();
    ExibirMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTitulo("Exibindo todas as bandas registradas:");

  //   for (int i = 0; i < listaDasBandas.Count; i++)
  //   {
  //        Console.WriteLine((i + 1) + ". " + listaDasBandas[i].ToString());
  //   }

   foreach (string banda in bandasRegistradas.Keys)
   {
       Console.WriteLine($"Banda: {banda}");
   }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    ExibirMenu();
}

void NotasDeBandas()
{
    // digite qual banda avaliar
    // se existir no dic >> atribuir nota
    // se não, volta ao menu principal
    Console.Clear();
    ExibirTitulo("Avaliação de Bandas");
    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeDeBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDeBanda))
    {
        Console.Write($"Qual nota a banda {nomeDeBanda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeDeBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDeBanda}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirMenu();
    } else
    {
        Console.WriteLine($"\nA banda {nomeDeBanda} não foi encontrada. Retornando ao menu em 3 segundos");
        Thread.Sleep(3000);
        Console.Clear();
        ExibirMenu();
    }

}
void ExibirTitulo(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.Write(asteriscos + "\n");
}

void MediaDeNotas()
{
    // clear V
    // titulo V
    // perguntar nome da banda v
    // consultar se banda existe v
    // calcular media se sim
    Console.Clear() ;
    ExibirTitulo("Média de Notas das Bandas");
    Console.Write("\nQual banda você gostaria de saber a média de notas: ");
    String nomeDaBandaMedia = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBandaMedia))
    {

        List<int> notasDaBanda = bandasRegistradas[nomeDaBandaMedia];
        Console.WriteLine($"A média da banda {nomeDaBandaMedia} é de {notasDaBanda.Average()}!");
        Console.WriteLine("\nPara retornar ao menu principal, pressione qualquer tecla");
        Console.ReadKey();
        Console.Clear();
        ExibirMenu();

    } else
    {
        Console.WriteLine("Essa banda não existe em nosso banco de dados! Retornando ao Menu...");
        Thread.Sleep(3000);
        ExibirMenu() ;
    }
}
ExibirMenu();
