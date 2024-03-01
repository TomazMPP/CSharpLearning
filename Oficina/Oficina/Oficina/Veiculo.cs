namespace Oficina.Oficina
{
    internal class Veiculo
    {
        public Veiculo(string marca, string modelo, int ano, string placa)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
            Placa = placa;
        }

        public string Marca { get; }
        public string Modelo { get; }
        public int Ano { get; }
        public string Placa { get; }
    }
}
