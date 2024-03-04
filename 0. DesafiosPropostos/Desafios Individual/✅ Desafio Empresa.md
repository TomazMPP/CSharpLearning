16. Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

- [x] Criar Classe Gerente ✅ 2024-03-01
- [x] Gerente: String Setor ✅ 2024-03-01
- [x] Criar Classe Programador ✅ 2024-03-01
- [x] Programador: string Linguagem ✅ 2024-03-01
- [x] Criar Classe Analista ✅ 2024-03-01
- [x] Analista: string AreaDeAtuacao ✅ 2024-03-01
- [x] Criar Classe Pai Funcionario ✅ 2024-03-01
- [x] Funcionario: Nome e Salario ✅ 2024-03-01


```C#
namespace Empresa.Empresa
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public double Salario { get; set; }
    }
}

```

```C#
namespace Empresa.Empresa
{
    internal class Analista : Funcionario
    {
        public Analista(string areaDeAtuacao)
        {
            AreaDeAtuacao = areaDeAtuacao;
        }

        public string AreaDeAtuacao { get; }
    }
}

```

```C#
namespace Empresa.Empresa
{
    internal class Programador : Funcionario
    {
        public Programador(string linguagem)
        {
            Linguagem = linguagem;
        }

        public string Linguagem { get; }
    }
}

```

```C#
namespace Empresa.Empresa
{
    internal class Gerente : Funcionario
    {
        public Gerente(string setor)
        {
            Setor = setor;
        }

        public string Setor { get; }
    }
}

```