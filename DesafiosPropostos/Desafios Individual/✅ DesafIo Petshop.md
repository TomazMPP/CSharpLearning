11. Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

- [x] Criar classe Pet ✅ 2024-03-01
- [x] Pet: string Nome, double Peso, string Raça ✅ 2024-03-01
- [x] Criar classe Dono ✅ 2024-03-01
- [x] Dono: string Nome, string Rua, string Cpf, int Idade ✅ 2024-03-01
- [x] Criar classe médico ✅ 2024-03-01
- [x] Médico: string Nome,  string Especialidade ✅ 2024-03-01
- [x] Criar classe consulta ✅ 2024-03-01
- [x] Consulta: string DataConsulta, Pet pet, Dono dono, Medico medico ✅ 2024-03-01

```C#
namespace PetShop.PetShop
{
    internal class Pet
    {
        public Pet(string nome, double peso, string raca)
        {
            Nome = nome;
            Peso = peso;
            Raca = raca;
        }

        public string Nome { get; }
        public double Peso { get; }
        public string Raca { get; }
    }


}
```

```C#
namespace PetShop.PetShop
{
    internal class Dono
    {
        public Dono(string nome, string rua, string cpf, int idade)
        {
            Nome = nome;
            Rua = rua;
            Cpf = cpf;
            Idade = idade;
        }

        public string Nome { get; }
        public string Rua { get; }
        public string Cpf { get; }
        public int Idade { get; }
    }
}
```

```C#
namespace PetShop.PetShop
{
    internal class Medico
    {
        public Medico(string nome, string especialidade)
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
namespace PetShop.PetShop
{
    internal class Consulta
    {
        public Consulta(Pet pet, Dono dono, Medico medico)
        {
            Pet = pet;
            Dono = dono;
            Medico = medico;
        }

        public string DataConsulta { get; set; }
        public Pet Pet { get; }
        public Dono Dono { get;}
        public Medico Medico { get; }
    }
}


```