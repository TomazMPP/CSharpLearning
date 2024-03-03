27. Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.

```C#
try
{
    List<int> numeros = new List<int> { 1, 2, 3 };
    Console.WriteLine($"Acessando um índice inexistente: {numeros[10]}");
} 

catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Erro: {ex.Message}");
}
```