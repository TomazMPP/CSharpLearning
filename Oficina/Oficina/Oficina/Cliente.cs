namespace Oficina.Oficina
{
    internal class Cliente
    {
        public Cliente(string nome, string contato)
        {
            Nome = nome;
            Contato = contato;
        }

        public string Nome { get;}
        public string Contato { get; }
    }
}
