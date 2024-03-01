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
