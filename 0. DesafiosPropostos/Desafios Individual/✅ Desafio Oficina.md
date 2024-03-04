 12. ✅ Modelar o funcionamento de uma oficina automobilistica.
13. ✅ Criar um programa `Program.cs` e simular o funcionamento do programa.

- [x] Criar classe Veículo ✅ 2024-03-01
- [x] Veiculo: string Marca, string Modelo, int Ano, string Placa ✅ 2024-03-01
- [x] Criar classe Cliente ✅ 2024-03-01
- [x] Cliente: string Nome, string Contato ✅ 2024-03-01
- [x] Criar clesse Mecânico ✅ 2024-03-01
- [x] Mecanico: string Nome, stirng Especialidade ✅ 2024-03-01
- [x] Criar classe Oficina ✅ 2024-03-01
- [x] Oficina: List VeiculasNaOifinca ✅ 2024-03-01
- [x] Oficina: AgendarSerivco() ✅ 2024-03-01
- [x] Oficina: RealizarServico() ✅ 2024-03-01
- [x] Criar um programa no program.cs ✅ 2024-03-01

```C#
namespace Oficina.Oficina
{
    internal class Veiculo
    {
        public Veiculo(string marca, string modelo, int ano, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
        }

        public string Marca { get; }
        public string Modelo { get; }
        public int Ano { get; }
        public string Placa { get; }
    }
}

```

```C#
namespace Oficina.Oficina
{
    internal class Cliente
    {
        public Cliente(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }

        public string Nome { get;}
        public string Contato { get; }
    }
}

```

```C#
namespace Oficina.Oficina
{
    internal class Mecanico
    {
        public Mecanico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; }
        public string Especialidade { get; }
    }
}

```

```C#
namespace Oficina.Oficina
{
    internal class OficinaDoMecanico
    {
        private List<Veiculo> VeiculoNaOficina;
        public OficinaDoMecanico()
        {
            VeiculoNaOficina = new List<Veiculo>();
        }

        public void AgendarServico(Veiculo veiculo, string dataAgendamento, Mecanico mecanico)
        {
            VeiculoNaOficina.Add(veiculo);
            Console.WriteLine(value: $"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}.");
        }

        public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
        {
            if (VeiculoNaOficina.Contains(veiculo))
            {
                Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo Mecânico {mecanico.Nome}.");
                VeiculoNaOficina.Remove(veiculo);
            }
            else
            {
                Console.WriteLine($"O veículo {veiculo.Placa} ainda não está na Oficina. Tente Agendar um Serviço");
            }
        }

    }
}

```

```C#
using Oficina.Oficina;

Veiculo meuCarro = new("BMW", "M3 Competition", 2023, "JRB-6524");
Cliente cliente = new("Tomaz Pontes", "tomazpontes.dev@gmail.com");
Mecanico mecanico = new("Setonp Zamot", "Mecânica Geral");
OficinaDoMecanico oficinaZamot = new();

oficinaZamot.AgendarServico(meuCarro, "01-03-2024", mecanico);
oficinaZamot.RealizarServico(meuCarro, mecanico);
```