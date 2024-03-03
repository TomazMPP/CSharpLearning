37. Dada uma lista de strings, criar uma consulta LINQ para ordenar as palavras por comprimento e retornar apenas aquelas que têm mais de 3 caracteres.

```C#
List<string> palavras = new List<string> { "cachorro", "gato", "elefante", "leão", "cobra", "cão" };

var palavrasOrdenadas = palavras.Where(palavras => palavras.Length > 3).OrderBy(palavras => palavras.Length).ToList();

Console.WriteLine("Palavras com mais de 3 caracteres, ordenadas:");
foreach (var palavra in palavrasOrdenadas)
{
    Console.WriteLine(palavra);
}
```

## Output:

```
Palavras com mais de 3 caracteres, ordenadas:
gato
leão
cobra
cachorro
elefante
```
