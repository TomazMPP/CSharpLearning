>[!NOTE]
>Resoluções no final do README!

## Desafios (Arrays e Coleções):
44. ✅  Método que calcula a média de um Array passado por parâmetro. Contrataram você como o novo desenvolvedor da equipe da Esther, e você ficou responsável de iniciar a codificação do módulo de estatística da aplicação, iniciando o desenvolvimento da função que irá calcular a média de uma amostra. Essa amostra será um vetor de doubles que será o parâmetro de entrada do seu método.

## Desafios (Serialization + File JSON):
38. ✅ Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo.
39. ✅ Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.
40. ✅ Criar um programa que permite ao usuário inserir informações de várias pessoas, armazena essas informações em uma lista, serializa a lista em formato JSON e salva em um arquivo.
41. ✅ Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, desserializa essas informações em uma lista e exibe na tela.
42. ✅ Criar um programa que lê um arquivo JSON contendo informações de várias pessoas, permite ao usuário inserir uma idade e exibe as pessoas com aquela idade.
43. [✅ Aumentar Aplicação V2]

## Desafios (Linq):
32. ✅ Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.
33. ✅ Dadas duas listas de números, criar uma consulta LINQ para retornar uma lista que contenha apenas os números que estão presentes em ambas as listas
34. ✅ Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.
35. ✅ Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.
36. ✅ Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.
37. ✅ Dada uma lista de strings, criar uma consulta LINQ para ordenar as palavras por comprimento e retornar apenas aquelas que têm mais de 3 caracteres.

## Desafios (API & Derivados):
25. ✅ Escrever um programa que faça uma requisição para a API de games **CheapShark** e mostre na tela a lista de promoções cadastrada na ferramenta (Você pode utilizar o endpoint: [https://www.cheapshark.com/api/1.0/deals](https://www.cheapshark.com/api/1.0/deals)).
26. ✅ Escrever um programa que solicite dois números `a` e `b` lidos do teclado e realize a divisão de `a` por `b`. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.
27. ✅ Declarar uma lista de inteiros e tente acessar um elemento em um índice inexistente. Tratar a exceção apropriada.
28. ✅ Modelar e desserializar a classe Filme, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json)
29. ✅ Modelar e desserializar a classe Pais, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json)
30. ✅ Modelar e desserializar a classe Carro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Carros.json)
31. ✅ Modelar e desserializar a classe Livro, que pode ser encontrada no [endpoint disponibilizado](https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json)

## ✅ Desafios (Interface):
20. ✅ Criar uma interface chamada IForma que declare métodos para calcular a área e o perímetro de uma forma geométrica. Implemente esta interface em duas classes: Circulo e Retangulo.
21. ✅ Criar duas interfaces adicionais, IPilotavel e IVoavel. Implemente essas interfaces na classe Veiculo.
22. ✅ Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.
23. ✅ Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.
24. ✅ Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

## ✅ Desafios (Hierarquia): 
15. ✅ Criar uma hierarquia de classes representando formas geométricas, como Quadrado, Círculo e Triângulo. Utilize herança para criar uma classe base chamada FormaGeometrica, que contenha métodos para calcular a área e o perímetro de uma forma.
16. ✅ Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.
17. ✅ Criar uma hierarquia de classes representando contas bancárias, como ContaCorrente e ContaPoupanca. Utilize herança e o conceito de métodos virtuais para implementar um método CalcularSaldo que retorne o saldo atual da conta.
18. ✅ Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.
19. ✅ Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

## Desafios (Geral - primeiros)
1. ✅Modelar uma classe `Conta`, que tenha como atributos uma classe `Titular`, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada.
2. ✅ Instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.
3. ✅ Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos, e exibir todos os produtos no estoque.
4. ✅ Modelar o sistema de uma escola. Crie classes para Aluno, Professor e Disciplina. A classe Aluno deve ter informações como nome, idade e notas. A classe Professor deve ter informações sobre nome e disciplinas lecionadas. A classe Disciplina deve armazenar o nome da disciplina e a lista de alunos matriculados.
5. ✅ Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.
6. [✅  Aumentar Aplicação]
7. ✅ Criar uma classe que representa um filme, com dados como seu titulo, duração e elenco. Após isso, colocá-la no namespace **Alura.Filmes**.
8. ✅ Criar um programa `Program.cs`, instanciar seus 5 filmes favoritos, guardá-los em uma lista e mostrar as suas informações no console.
9. ✅ Criar uma classe `Artista`, que representa uma pessoa que atua em filmes, no namespace `Alura.Filmes`. A classe deve conter atributos como o nome, idade e uma lista de filmes onde o artista atuou.
10. ✅ Modificar as classes `Artista` e `Filme` do namespace `Alura.Filmes` para que elas sejam consistentes uma com a outra, ou seja, sempre que for adicionado um artista a um filme, terá de ser adicionado também o filme à lista de filmes do artista.
11. ✅ Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.
12. ✅ Modelar o funcionamento de uma oficina automobilistica.
13. ✅ Criar um programa `Program.cs` e simular o funcionamento do programa.
14. ✅ Escrever um programa que funcione como uma calculadora, que pode realizar as 4 operações básicas, além de calcular raiz quadrada e potências. O usuario deve entrar com dois números e um simbolo que represente a operação a ser feita.

###### Desafios (Arrays e coleções):
44. [✅  Desafio Array Media](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Array%20+%20Media.md)

###### Desafios (Serialization + File JSON):
38-39. [✅ Desafio Serial + DesPessoa](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Serial%20+%20DesPessoa.md)
<br>40-41-42. [✅ Desafio SerialPessoas](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20SerialPessoas.md)

###### Resolução Desafios (Linq):
32. [✅ Desafio LinqNumeros](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20LinqNumeros.md)
33. [✅ Desafio Numeros Listas](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Numeros%20Listas.md)
34. [✅ Desafio LinqLivros](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20LinqLivros.md)
35. [✅ Desafio LinqProdutos](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20LinqProdutos.md)
36. [✅ Desafio LinqPares](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20LinqPares.md)
37. [✅ Desafio LinqString](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20LinqString.md)

###### Resolução Desafios (API & Derivados):
25. [✅ Desafio API Games](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20API%20Games.md)
26. [✅ Desafio TRYCATCH](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20TRYCATCH.md)
27. [✅ Desafio TryCatch Inteiros](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20TryCatch%20Inteiros.md)
28. [✅ Desafio FilmeAPI](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20FilmeAPI.md)
29. [✅ Desafio PaísAPI](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Pa%C3%ADsAPI.md)
30. [✅ Desafio CarroAPI](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20CarroAPI.md)
31. [✅ Desafio LivroAPI](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20LivroAPI.md)


###### Resolução Desafios (Interface):
22. [✅ Desafio Interface Pagamento](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Interface%20Pagamento.md)
23. [✅ Desafio Notificação](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Notificação.md)
24. [✅ Desafio Armazenamento](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Armazenamento.md)

###### Resolução Desafios (Hierarquia):
15. [✅ Desafio Geometria](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Geometria.md)
16. [✅ Desafio Empresa](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Empresa.md)
17. [✅ Desafio Conta Bancaria](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Conta%20Bancaria.md)
18. [✅ Desafio Hierarquia Animais](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Hierarquia%20Animais.md)

###### Resolução Desafios (Geral - primeiros):
1-2. [✅ Desafio Conta Titular POO](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Conta%20Titular%20POO.md)
<br>3. [✅ Desafio Estoque POO](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Estoque%20POO.md)
<br>4. [✅ Desafio Escola](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Escola.md)
<br>5. [✅ Desafio Catalogo Jogos](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Catalogo%20Jogos.md)
<br>6. [✅  Aumentar Aplicação](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20%20Aumentar%20Aplica%C3%A7%C3%A3o.md)
<br>7-8-9-10. [✅ Desafio Filmes](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Filmes.md)
<br>11.  [✅ DesafIo Petshop](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20DesafIo%20Petshop.md)
<br>12-13. [✅ Desafio Oficina](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Oficina.md)
<br>14. [✅ Desafio Calculadora](https://github.com/TomazMPP/CSharpLearning/blob/main/DesafiosPropostos/Desafios%20Individual/%E2%9C%85%20Desafio%20Calculadora.md)
