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