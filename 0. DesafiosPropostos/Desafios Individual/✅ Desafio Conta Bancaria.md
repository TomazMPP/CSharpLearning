17. Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.

- [x] Criar classe ContaCorrente ✅ 2024-03-01
- [x] Criar Classe ContaPoupanca ✅ 2024-03-01
- [x] Criar Classe Conta ✅ 2024-03-01
- [x] Conta: Metodo CalcularSaldo ✅ 2024-03-01
- [x] Conta: Metodo Depositar ✅ 2024-03-01
- [x] Conta: Metodo Sacar ✅ 2024-03-01
- [x] ContaCorrente: TaxaManutencao ✅ 2024-03-01
- [x] ContaPoupanca: TaxaRendimento ✅ 2024-03-01

```C#
namespace Conta_Bancaria_V4__Heritage_.Banco
{
    internal class ContaCorrente : Conta
    {
        private double TaxaManutencao {  get; set; }
        public override void Sacar(double valor)
        {
            base.Sacar(valor + TaxaManutencao);
        }
    }
}

```

```C#
namespace Conta_Bancaria_V4__Heritage_.Banco
{
    internal class ContaPoupanca : Conta
    {
        private double TaxaRendimento {  get; set; }
        public override double CalcularSaldo()
        {
            return base.CalcularSaldo() * (1 + TaxaRendimento);
        }
    }
}

```

```C#
namespace Conta_Bancaria_V4__Heritage_.Banco
{
    internal class Conta
    {
        protected double Saldo { get; set; }

        public virtual void Depositar(double valor)
        {
            Saldo += valor;
        }

        public virtual void Sacar(double valor)
        {
            Saldo -= valor;
        }

        public virtual double CalcularSaldo() { return Saldo; }
    }
}

```