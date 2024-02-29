class Jogo
{
    public Jogo(string nome, int anoLancamento, string plataforma)
    {
        Nome = nome;
        AnoLancamento = anoLancamento;
        Plataforma = plataforma;
    }

    public string Nome { get; }
    public int AnoLancamento { get; }
    public string Plataforma { get; }
}