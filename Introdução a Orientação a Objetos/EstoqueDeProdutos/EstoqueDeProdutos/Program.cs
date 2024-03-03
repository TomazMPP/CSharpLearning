Produto produto1 = new Produto();
EstoqueDeProdutos estoqueDeProdutos = new EstoqueDeProdutos();

produto1.Nome = "Maçã";
produto1.Marca = "Seara";
produto1.Estoque = 12;
produto1.Preco = 1.90;

estoqueDeProdutos.AdicionarProdutos(produto1);
estoqueDeProdutos.ExibirProdutos();