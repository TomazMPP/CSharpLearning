14. Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

- [x] Criar lógica no Program.cs para obter o operador e os numeros ✅ 2024-03-01
- [x] Criar classe Calculadora ✅ 2024-03-01
- [x] Criar metodos para operadores ✅ 2024-03-01,

```C#
class Calculadora {

    public static double Calcular(double numero1, double numero2, string operacao)
    {
        double resultado = 0;

        switch (operacao)
        {
            case "+":
                resultado = Somar(numero1, numero2);
                break;
            case "-":
                resultado = Subtrair(numero1, numero2);
                break;
            case "*":
                resultado = Multiplicar(numero1, numero2);
                break;
            case "/":
                resultado = Dividir(numero1, numero2);
                break;
            case "^":
                resultado = Potencia(numero1, numero2);
                break;
            case "Raiz":
                resultado = Raiz(numero1);
                break;
            default:
                Console.WriteLine("Operação inválida.");
                break;
        }

        return resultado;
    }

    public static double Somar(double numero1, double numero2) { return numero1 + numero2; }

    public static double Subtrair(double numero1, double numero2) { return numero1 - numero2; }

    public static double Multiplicar(double numero1, double numero2) { return numero1 * numero2; }
    
    public static double Dividir(double numero1, double numero2)
    {
        if (numero2 != 0)
            return numero1 / numero2;
        else
        {
            Console.WriteLine("Erro: Divisão por zero.");
            return 0;
        }
    }

    public static double Potencia(double numero1, double numero2) { return Math.Pow(numero1, numero2); }

    public static double Raiz(double numero1) { return Math.Sqrt(numero1) ;  }
}

```

```C#
Console.Write("Digite o primeiro número: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o segundo número: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite a operação (+, -, *, /, ^, Raiz): ");
string operacao = Console.ReadLine();

double resultado = Calculadora.Calcular(num1, num2, operacao);

if (operacao == "Raiz")
{
    Console.WriteLine($"Resultado da raiz do primeiro número: {resultado}");
}
else
{
    Console.WriteLine($"Resultado da operação: {resultado}");
}
```