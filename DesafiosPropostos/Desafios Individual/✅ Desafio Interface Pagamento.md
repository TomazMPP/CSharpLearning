22. Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

- [x] Criar Interface IPagavel ✅ 2024-03-02
- [x] Criar metodo CalcularPagamento (double) ✅ 2024-03-02
- [x] Criar classe Produto ✅ 2024-03-02
- [x] Criar classe Servico ✅ 2024-03-02
- [x] extender com interface e adicionar metodo CalcularPagamento em ambos ✅ 2024-03-02
- [x] prop int TaxaHonoraria em Servico ✅ 2024-03-02
- [x] prop int HorasTrabalhadas em Servico ✅ 2024-03-02
- [x] prop int Quantidade em Produto ✅ 2024-03-02
- [x] prop int PrecoUnitario em Produto ✅ 2024-03-02

```C#
namespace PraticaInterface.Pagamento;

internal interface IPagavel
{

    double CalcularPagamento();
}

```

```C#
namespace PraticaInterface.Pagamento;

internal class Produto
{
    public int Quantidade { get; set; }
    public int PrecoUnitario { get; set; }
    public double CalcularPagamento()
    {
        return Quantidade * PrecoUnitario;
    }
}

```

```C#
namespace PraticaInterface.Pagamento;

internal class Servico : IPagavel
{
    public int Taxa { get; set; }
    public int HorasTrabalhadas { get; set; }
    public double CalcularPagamento() {

        return Taxa * HorasTrabalhadas;
    }
}

```