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