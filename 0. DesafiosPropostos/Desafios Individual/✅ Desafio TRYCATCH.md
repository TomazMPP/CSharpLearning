26. Escrever um programa que solicite dois números `a` e `b` lidos do teclado e realize a divisão de `a` por `b`. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

```C#
try
{
    Console.Write($"Insira um número: ");
    string numero1String = Console.ReadLine()!;
    int numero1 = int.Parse(numero1String);
    Console.Write("Insira outro número: ");
    string numero2String = Console.ReadLine()!;
    int numero2 = int.Parse(numero2String);

    Console.WriteLine(numero1 / numero2);
} 

catch (DivideByZeroException ex)
{
    Console.WriteLine("\nErro: na matemática não é permitida a divisão por 0.");
}
```