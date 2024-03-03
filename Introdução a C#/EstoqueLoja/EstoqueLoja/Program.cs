Dictionary<string, List<int>> estoqueDeProdutos = new Dictionary<string, List<int>>();
estoqueDeProdutos.Add("Maçã", new List<int> { 5, 5 });
estoqueDeProdutos.Add("Pera", new List<int> { 35 });
estoqueDeProdutos.Add("Banana", new List<int> { 15 });
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░███████╗░██████╗████████╗░█████╗░░█████╗░
██╔════╝░██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░██╗░█████╗░░╚█████╗░░░░██║░░░███████║██║░░██║
██║░░╚██╗██╔══╝░░░╚═══██╗░░░██║░░░██╔══██║██║░░██║
╚██████╔╝███████╗██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚═════╝░╚══════╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░

███████╗░██████╗████████╗░█████╗░░██████╗░██╗░░░██╗███████╗
██╔════╝██╔════╝╚══██╔══╝██╔══██╗██╔═══██╗██║░░░██║██╔════╝
█████╗░░╚█████╗░░░░██║░░░██║░░██║██║██╗██║██║░░░██║█████╗░░
██╔══╝░░░╚═══██╗░░░██║░░░██║░░██║╚██████╔╝██║░░░██║██╔══╝░░
███████╗██████╔╝░░░██║░░░╚█████╔╝░╚═██╔═╝░╚██████╔╝███████╗
╚══════╝╚═════╝░░░░╚═╝░░░░╚════╝░░░░╚═╝░░░░╚═════╝░╚══════╝");
    Console.WriteLine("\nBem-vindo a simulação de gestão de estoque");

}

void Menu()
{
    ExibirLogo();
    // Checar lista de produtos existentes
    // Adicionar novo produto
    // Sair
    Console.WriteLine("\n1 - Checar lista de produtos existentes");
    Console.WriteLine("2 - Adicionar novo produto ou quantidade");
    Console.WriteLine("3 - Sair");
    Console.Write("\nEscolha (digite) um dos números: ");
    String opcaoEscolhidaString = Console.ReadLine();
    int opcaoEscolhida = int.Parse(opcaoEscolhidaString);

    switch (opcaoEscolhida)
    {
        case 1: MostrarProdutos(); break;
        case 2: AdicionarNovoProduto(); break;
        case 3: Console.Write("Desligando computador... Brincadeira, tchau!");  break;
    }

}

void MostrarProdutos()
{
    Console.Clear();
    Console.WriteLine(@"
██████╗░██████╗░░█████╗░██████╗░██╗░░░██╗████████╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██║░░░██║╚══██╔══╝██╔══██╗██╔════╝
██████╔╝██████╔╝██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║╚█████╗░
██╔═══╝░██╔══██╗██║░░██║██║░░██║██║░░░██║░░░██║░░░██║░░██║░╚═══██╗
██║░░░░░██║░░██║╚█████╔╝██████╔╝╚██████╔╝░░░██║░░░╚█████╔╝██████╔╝
╚═╝░░░░░╚═╝░░╚═╝░╚════╝░╚═════╝░░╚═════╝░░░░╚═╝░░░░╚════╝░╚═════╝░");
    Console.WriteLine("\nOlá! Esses são os produtos atualmente cadastrados:\n");

    foreach (var produto in estoqueDeProdutos)
    {
        string nomeProduto = produto.Key;
        List<int> quantidades = produto.Value;

        Console.Write($"\n{nomeProduto} - Quantidades: ");

        int somaQuantidades = SomarLista(quantidades);

        Console.Write(somaQuantidades);
    }

    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal!");
    Console.ReadKey();
    Console.Clear();
    Menu();
}

void AdicionarNovoProduto()
{
    Console.Clear();
    Console.WriteLine("Olá! Para adicionar um produto novo, basta digitar o nome.\nCaso queira adicionar quantidade, digite o nome do produto existente:\n");
    Console.Write("Digite apenas o nome do produto: ");
    String nomeNovo = Console.ReadLine();
    Console.Write("Ótimo, quantas unidades? (Apenas valor inteiro): ");
    String quantidadeNovaString = Console.ReadLine()!;

    int quantidadeNova = int.Parse(quantidadeNovaString);

    if (estoqueDeProdutos.ContainsKey(nomeNovo))
    {
        estoqueDeProdutos[nomeNovo].Add(quantidadeNova);
    }
    else
    {

        estoqueDeProdutos.Add(nomeNovo, new List<int> { quantidadeNova });

    }

    Console.WriteLine($"\nO produto {nomeNovo} com {quantidadeNova} unidades foi adicionado ao Estoque! Retornando ao menu...");

    Thread.Sleep(3000);
    Console.Clear();
    Menu();
}

int SomarLista(List<int> lista)
{
    int soma = 0;
    foreach (int valor in lista)
    {
        soma += valor;
    }
    return soma;
}

Menu();