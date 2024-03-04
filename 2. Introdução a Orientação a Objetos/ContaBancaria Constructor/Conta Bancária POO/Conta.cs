class Conta
{
    public Conta(Titular titularDaConta, int agenciaDoBanco, int numeroDaConta, double saldo, double limiteDaConta)
    {
        TitularDaConta = titularDaConta;
        AgenciaDoBanco = agenciaDoBanco;
        NumeroDaConta = numeroDaConta;
        Saldo = saldo;
        LimiteDaConta = limiteDaConta;
    }

    public Titular TitularDaConta { get; }
    public int AgenciaDoBanco { get;}
    public int NumeroDaConta { get; }
    public double Saldo { get; }
    public double LimiteDaConta { get; }

    public string InformacoesDaConta()
    {
        string info = $"Olá {TitularDaConta.NomeDoTitular}, bem-vindo a sua conta número {NumeroDaConta} da agência {AgenciaDoBanco}\n";
        info += $"Seu saldo atual é de {Saldo}\n";
        info += $"Seu limite de conta atual é de {LimiteDaConta}";

        return info;
    }
}