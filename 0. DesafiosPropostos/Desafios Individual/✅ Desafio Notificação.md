23. Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.

- [x] Criar uma interface chamada INotificavel ✅ 2024-03-02
- [x] Metodo EnviarNotificacao string ✅ 2024-03-02
- [x] Criar Classe EMAIL ✅ 2024-03-02
- [x] Criar Classe SMS ✅ 2024-03-02

```C#
namespace PraticaInterface.Notificacao;

internal interface INotificavel
{
    public string EnviarNotificacao();
}

```

```C#
namespace PraticaInterface.Notificacao;

internal class Email : INotificavel
{
    public string EnviarNotificacao()
    {
        return "Isso é uma mensagem Email";
    }
}

```

```C#
namespace PraticaInterface.Notificacao;

internal class SMS : INotificavel
{
    public string EnviarNotificacao()
    {
        return "Isso é uma mensagem SMS";
    }
}

```