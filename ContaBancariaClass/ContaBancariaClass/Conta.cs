using System;

class Conta
{
    public int numeroConta;
    public string nomeTitular;
    public double saldoConta;
    public string senhaLetras;

    public void ExibirInformacoes()
    {
        Console.WriteLine($"Olá, {nomeTitular}, seu saldo atual é de R${saldoConta}.");
        Console.WriteLine($"Conta Digital de ID = {numeroConta}");
    }

}

// Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha. v
// Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
// Desenvolver um método da classe Conta que exibe suas informações.