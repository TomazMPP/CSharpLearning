class EstoqueDeProdutos {

    private List<Produto> Produtos { get; set; }  = new List<Produto>();

    public void ExibirProdutos()
    {
        if (Produtos.Count == 0)
        {
            Console.WriteLine("Estoque vazio. Nenhum produto disponível");
        }
        else
        {
            Console.WriteLine("Lista de produtos no estoque:");
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine(produto.Descricao);
            }
        }
    }
    public void AdicionarProdutos(Produto produto)
    {
        Produtos.Add((produto));
        Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque.");
    }
}