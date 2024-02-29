class Episodio
{
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    private List<string> Convidados = new List<string>();
    public int Duracao { get; }
    public int Ordem { get; }
    public string Resumo => $"{Ordem}. {Titulo} ({Duracao}min.) - Convidados: {string.Join(", ", Convidados)}";
    public string Titulo { get; }

    public void AdicionarConvidado(string convidado)
    {
        Convidados.Add(convidado);
    }
}