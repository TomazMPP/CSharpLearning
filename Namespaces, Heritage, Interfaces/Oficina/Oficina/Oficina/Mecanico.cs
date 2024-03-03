namespace Oficina.Oficina
{
    internal class Mecanico
    {
        public Mecanico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; }
        public string Especialidade { get; }
    }
}
