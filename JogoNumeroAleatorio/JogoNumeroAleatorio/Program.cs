Console.WriteLine(@"
░░░░░██╗░█████╗░░██████╗░░█████╗░  ███╗░░██╗██╗░░░██╗███╗░░░███╗███████╗██████╗░░█████╗░░██████╗
░░░░░██║██╔══██╗██╔════╝░██╔══██╗  ████╗░██║██║░░░██║████╗░████║██╔════╝██╔══██╗██╔══██╗██╔════╝
░░░░░██║██║░░██║██║░░██╗░██║░░██║  ██╔██╗██║██║░░░██║██╔████╔██║█████╗░░██████╔╝██║░░██║╚█████╗░
██╗░░██║██║░░██║██║░░╚██╗██║░░██║  ██║╚████║██║░░░██║██║╚██╔╝██║██╔══╝░░██╔══██╗██║░░██║░╚═══██╗
╚█████╔╝╚█████╔╝╚██████╔╝╚█████╔╝  ██║░╚███║╚██████╔╝██║░╚═╝░██║███████╗██║░░██║╚█████╔╝██████╔╝
░╚════╝░░╚════╝░░╚═════╝░░╚════╝░  ╚═╝░░╚══╝░╚═════╝░╚═╝░░░░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚═════╝░");
    Console.WriteLine("Feito por TomazMPP");

int numeroAleatorio = new Random().Next(0, 101);
int numeroInput = 0;
int tentativas = 0;
Console.WriteLine("\nAdivinhe um número aleatorio, de 0 a 100!");

while (numeroInput != numeroAleatorio)
{
    Console.Write("Número: ");
    string numeroTexto = Console.ReadLine();
    numeroInput = int.Parse(numeroTexto);
    tentativas++;
    if (numeroInput != numeroAleatorio)
    {
        Console.WriteLine("Número errado! Tente novamente");
    } 
    if (numeroInput < numeroAleatorio)
    {
        Console.WriteLine("O número misterioso é maior que o que você colocou!");
    } else if (numeroInput > numeroAleatorio) {
        Console.WriteLine("O número misterioso é menor que o que você colocou!");
    }
    if (numeroInput == numeroAleatorio)
    {
        double probabilidade = ProbabilidadeAcerto(tentativas);
        Console.WriteLine(@"
██████╗░░█████╗░██████╗░░█████╗░██████╗░███████╗███╗░░██╗░██████╗██╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝████╗░██║██╔════╝██║
██████╔╝███████║██████╔╝███████║██████╦╝█████╗░░██╔██╗██║╚█████╗░██║
██╔═══╝░██╔══██║██╔══██╗██╔══██║██╔══██╗██╔══╝░░██║╚████║░╚═══██╗╚═╝
██║░░░░░██║░░██║██║░░██║██║░░██║██████╦╝███████╗██║░╚███║██████╔╝██╗
╚═╝░░░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░╚══════╝╚═╝░░╚══╝╚═════╝░╚═╝");
        Console.WriteLine("Parabéns!! Você acertou o número {0} em apenas {1} tentativas!\nSe você não tivesse a dica de maior/menor, a probabilidade disso acontecer seria de {2:P}", numeroAleatorio, tentativas, probabilidade);
    }
}

static double ProbabilidadeAcerto(int numeroDeTentativas)
{
    int numeroDePossibilidades = 101; // De 0 a 100, inclusive
    double probabilidadeDeAcerto = 1.0 / numeroDePossibilidades;

    // Usar a fórmula correta para calcular a probabilidade
    double probabilidade = 1 - Math.Pow(1 - probabilidadeDeAcerto, numeroDeTentativas);

    return probabilidade;
}
