36. Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.

```C#
List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

var pares = numeros.Where(x => x % 2 == 0);

foreach (int numero in pares)
{
    Console.WriteLine(numero);
}

```

## Output:

```
2
4
6
8
10
```