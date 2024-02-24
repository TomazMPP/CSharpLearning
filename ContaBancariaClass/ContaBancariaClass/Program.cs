using System.Linq;

List<Conta> todasContas = new List<Conta>();
int proximoNumeroConta = 3;
Conta conta1 = new Conta();
conta1.nomeTitular = "Tomaz Pontes";
conta1.saldoConta = 12392.32;
conta1.numeroConta = 1;
conta1.senhaLetras = "teste";
todasContas.Add(conta1);

Conta conta2 = new Conta();
conta2.nomeTitular = "Tomaz Martins";
conta2.saldoConta = 112;
conta2.numeroConta = 2;
conta2.senhaLetras = "teste";
todasContas.Add(conta2);

void ExibirLogo()
{
    Console.WriteLine(@"
████████╗░█████╗░███╗░░░███╗░█████╗░███████╗██████╗░░█████╗░███╗░░██╗██╗░░██╗
╚══██╔══╝██╔══██╗████╗░████║██╔══██╗╚════██║██╔══██╗██╔══██╗████╗░██║██║░██╔╝
░░░██║░░░██║░░██║██╔████╔██║███████║░░███╔═╝██████╦╝███████║██╔██╗██║█████═╝░
░░░██║░░░██║░░██║██║╚██╔╝██║██╔══██║██╔══╝░░██╔══██╗██╔══██║██║╚████║██╔═██╗░
░░░██║░░░╚█████╔╝██║░╚═╝░██║██║░░██║███████╗██████╦╝██║░░██║██║░╚███║██║░╚██╗
░░░╚═╝░░░░╚════╝░╚═╝░░░░░╚═╝╚═╝░░╚═╝╚══════╝╚═════╝░╚═╝░░╚═╝╚═╝░░╚══╝╚═╝░░╚═╝");
    Console.WriteLine("Olá! Bem-vindo ao TomazBank!");
}

void Menu()
{
    ExibirLogo();
    Console.WriteLine("\n1 - Checar ou adicionar saldo bancário");
    Console.WriteLine("2 - Se cadastrar no banco");
    Console.WriteLine("3 - Sair");
    Console.Write("\nEscolha (digite) um dos números: ");
    String opcaoEscolhidaString = Console.ReadLine()!;
    int opcaoEscolhida = int.Parse(opcaoEscolhidaString);

    switch (opcaoEscolhida)
    {
        case 1: AcessarConta(); break;
        case 2: CriarConta(); break;
        case 3: Console.Write("Tchau! :)"); break;
    }

}

void AcessarConta()
{
    Console.Clear();
    Console.WriteLine("Insira seu nome completo: ");
    string nomeUsuario = Console.ReadLine();
    Console.WriteLine("Insira sua senha: ");
    string senha = Console.ReadLine();

    Conta contaAtual = todasContas.FirstOrDefault(c => c.nomeTitular == nomeUsuario && c.senhaLetras == senha);

    if (contaAtual != null)
    {
        Console.Clear();
        contaAtual.ExibirInformacoes();

        Console.WriteLine("\nGostaria de adicionar/remover saldo? (S/N)");
        string resposta = Console.ReadLine();

        if (resposta == "S")
        {
            Console.Clear();
            Console.WriteLine($"Saldo Atual: {contaAtual.saldoConta}");
            Console.WriteLine("Escolha uma das opções abaixo:");
            Console.WriteLine("\n1 - Adicionar Saldo");
            Console.WriteLine("2 - Remover Saldo");
            Console.Write("\nEscolha (digite) um dos números: ");

            if (int.TryParse(Console.ReadLine(), out int opcaoEscolhida))
            {
                switch (opcaoEscolhida)
                {
                    case 1:
                        Console.Write("Quanto gostaria de adicionar?: ");
                        if (double.TryParse(Console.ReadLine(), out double valorAAdicionar))
                        {
                            contaAtual.saldoConta += valorAAdicionar;
                            Console.WriteLine($"Saldo atualizado! Novo saldo: R${contaAtual.saldoConta}");
                        }
                        break;

                    case 2:
                        Console.Write("Quanto gostaria de remover?: ");
                        if (double.TryParse(Console.ReadLine(), out double numeroSaldoMenos))
                        {
                            if (numeroSaldoMenos <= contaAtual.saldoConta)
                            {
                                contaAtual.saldoConta -= numeroSaldoMenos;
                                Console.WriteLine($"Saldo atualizado! Novo saldo: R${contaAtual.saldoConta}");
                            }
                            else
                            {
                                Console.WriteLine("Valor a ser removido é maior que o saldo. Operação não permitida.");
                                Console.WriteLine("\nRetornando ao menu...");
                                Thread.Sleep(3000);
                                Console.Clear();
                                Menu();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido.");
                            Console.WriteLine("\nRetornando ao menu...");
                            Thread.Sleep(3000);
                            Console.Clear();
                            Menu();
                        }
                        break;

                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine("\nRetornando ao menu...");
            Thread.Sleep(3000);
            Console.Clear();
            Menu();
        }

        Console.WriteLine("\nPressione qualquer tecla para retornar ao menu principal.");
        Console.ReadKey();
    }
    else
    {
        Console.WriteLine("Usuário não encontrado ou senha incorreta.");
    }

    Console.Clear();
    Menu();
}


void CriarConta()
{
    Console.Clear();
    Conta novaConta = new Conta();
    Console.Write("Insira o nome completo do titular da conta: ");
    novaConta.nomeTitular = Console.ReadLine()!;
    if (!todasContas.Any(conta => conta.nomeTitular == novaConta.nomeTitular))
    {
        Console.Write("Insira uma senha: ");
        novaConta.senhaLetras = Console.ReadLine();

        Console.Write("Seu saldo inicial: R$");
        string saldoAtualString = Console.ReadLine();
        novaConta.saldoConta += int.Parse(saldoAtualString);

        novaConta.numeroConta = proximoNumeroConta;
        proximoNumeroConta++;

        todasContas.Add(novaConta);

        Console.WriteLine("Conta criada com sucesso!");
        Console.WriteLine("\nRetornando ao menu...");
        Thread.Sleep(4000);
        Console.Clear();
        Menu();
    }
    else
    {
        Console.WriteLine("No mundo da nossa conta bancária, não existem pessoas com o mesmo nome,\ne alguém já tem o nome que você colocou!");
        Console.WriteLine("\nRetornando ao menu...");
        Thread.Sleep(3000);
        Console.Clear();
        Menu();
    }
}

Menu();