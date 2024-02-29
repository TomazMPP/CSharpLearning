
Titular titular1 = new Titular();
titular1.NomeDoTitular = "Tomaz Pontes";
titular1.CpfDoTitular = "123456789-10";
titular1.RuaDoTitular = "Rua do seu Zé";

Conta conta1 = new Conta();
conta1.TitularDaConta = titular1;
conta1.Saldo = 1000.05;
conta1.LimiteDaConta = 10000;
conta1.AgenciaDoBanco = 1;
conta1.NumeroDaConta = 12321;

conta1.InformacoesDaConta();

Console.WriteLine("Informações do Titular: ");
Console.WriteLine($"Nome: {conta1.TitularDaConta.NomeDoTitular}");
Console.WriteLine($"CPF: {conta1.TitularDaConta.CpfDoTitular}");
Console.WriteLine($"Endereco: {conta1.TitularDaConta.RuaDoTitular}");