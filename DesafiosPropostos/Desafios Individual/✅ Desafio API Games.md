Escrever um programa que faça uma requisição para a API de games **CheapShark** e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: [https://www.cheapshark.com/api/1.0/deals](https://www.cheapshark.com/api/1.0/deals)).

```C#
using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
        Console.WriteLine(resposta);
    }

    catch (Exception ex) {
        Console.WriteLine(ex);
    }
}
```

(Início do curso, ainda não aprendi a organizar a informação)