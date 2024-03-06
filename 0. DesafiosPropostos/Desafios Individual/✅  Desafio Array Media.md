#### Desafio: método que calcula a média de um Array passado por parâmetro

Contrataram você como o novo desenvolvedor da equipe da Esther, e você ficou responsável de iniciar a codificação do módulo de estatística da aplicação, iniciando o desenvolvimento da função que irá calcular a média de uma amostra. Essa amostra será um vetor de doubles que será o parâmetro de entrada do seu método.

Este é um exercício opcional e te desafiamos a criar um método que receba como parâmetro um array de double e retorne a média simples calculada.

- [x] Criar array ✅ 2024-03-06
- [x] Criar metodo (double[] amostra) ✅ 2024-03-06
- [x] Criar atribuis acumulador double, media double ✅ 2024-03-06
- [x] criar for ✅ 2024-03-06

```C#
double[] pesquisa = new double[6] { 8.3, 9.1, 9.9, 8.9, 8.8, 10.0 };

double MostrarMediaArray(double[] amostra)
{
    double acumulador = 0;
    double media = 0;

    for (int i = 0; i < amostra.Length; i++)
    {
        acumulador += amostra[i];
    }

    media = acumulador / amostra.Length;
    return media;
}
```