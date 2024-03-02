24. Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

- [x] Criar Interface IArmazenavel ✅ 2024-03-02
- [x] IArmazenavel -> Metodo string Salvar ✅ 2024-03-02
- [x] IArmazenavel -> Metodo string Recuperar ✅ 2024-03-02
- [x] Criar classe Arquivo ✅ 2024-03-02
- [x] Criar classe BancoDeDados ✅ 2024-03-02
- [x] string NomeArquivo ✅ 2024-03-02
- [x] string NomeBanco ✅ 2024-03-02


```C#
namespace PraticaInterface.Armazenamento;

internal interface IArmazenavel
{
    public string Salvar();
    public string Recuperar();
}

```

```C#
namespace PraticaInterface.Armazenamento;

internal class Arquivo : IArmazenavel
{
    public string NomeDoArquivo { get; set; }
    public string Salvar()
    {
        return $"Salvando dados no arquivo {NomeDoArquivo}";
    }

    public string Recuperar()
    {
        return $"Recuperando arquivo {NomeDoArquivo}";
    }
}

```

```C#
namespace PraticaInterface.Armazenamento;

internal class BancoDeDados : IArmazenavel
{
    public string NomeDoBanco { get; set; }
    public string Salvar()
    {
        return $"Salvando dados no banco de dados {NomeDoBanco}";
    }

    public string Recuperar()
    {
        return $"Recuperando dados do banco de dados {NomeDoBanco}";
    }
}

```