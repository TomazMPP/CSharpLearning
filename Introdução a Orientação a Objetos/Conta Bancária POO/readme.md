✅ 1. Modelar uma classe `Conta`, que tenha como atributos uma classe `Titular`, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
✅ 2. Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.

- [x] Criar Classe Titular ✅ 2024-02-29
- [x] Dentro de Titular: Nome, CPF, Rua ✅ 2024-02-29
- [x] Criar Classe Conta ✅ 2024-02-29
- [x] Dentro de Conta: Uma classe Titular, Agência, Número da Conta, Saldo, Limite. ✅ 2024-02-29
- [x] Método dentro de Conta: Informações da conta de forma detalhada ✅ 2024-02-29
- [x] Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta. ✅ 2024-02-29

```C#
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
```

```Csharp
class Titular
{
    public string NomeDoTitular { get; set; }
    public string CpfDoTitular { get; set; }
    public string RuaDoTitular { get; set; }

}
```

```C#
class Conta
{
    public Titular TitularDaConta { get; set; }
    public int AgenciaDoBanco { get; set; }
    public int NumeroDaConta { get; set; }
    public double Saldo { get; set; }
    public double LimiteDaConta { get; set; }

    public void InformacoesDaConta()
    {
        Console.WriteLine($"Olá {TitularDaConta.NomeDoTitular}, bem-vindo a sua conta número {NumeroDaConta} da agência {AgenciaDoBanco}\n");
        Console.WriteLine($"Seu saldo atual é de {Saldo}");
        Console.WriteLine($"Seu limite de conta atual é de {LimiteDaConta}");
    }
}
```
