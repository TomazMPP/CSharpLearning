class Produto {
    public string Nome { get; set; }
    private double preco;
    private int estoque;
    public string Marca { get; set; }

public double Preco
    {
        get => preco;
        set
        {
            if (value > 0)
            {
                preco = value;
            } else
            {
                preco = 10;
            }
        }
    }
    
    public int Estoque
{
    get => estoque;
    set
    {
        if (value > 0)
            estoque = value;
        else
            estoque = 0;

    }
}
public string Descricao => $"{this.Nome} {this.Marca} - R${this.Preco} - Quantidade: {this.Estoque}";

}

