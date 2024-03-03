namespace Oficina.Oficina
{
    internal class OficinaDoMecanico
    {
        private List<Veiculo> VeiculoNaOficina;
        public OficinaDoMecanico()
        {
            VeiculoNaOficina = new List<Veiculo>();
        }

        public void AgendarServico(Veiculo veiculo, string dataAgendamento, Mecanico mecanico)
        {
            VeiculoNaOficina.Add(veiculo);
            Console.WriteLine(value: $"Serviço agendado para {veiculo.Placa} em {dataAgendamento} com o mecânico {mecanico.Nome}.");
        }

        public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
        {
            if (VeiculoNaOficina.Contains(veiculo))
            {
                Console.WriteLine($"Serviço realizado em {veiculo.Placa} pelo Mecânico {mecanico.Nome}.");
                VeiculoNaOficina.Remove(veiculo);
            }
            else
            {
                Console.WriteLine($"O veículo {veiculo.Placa} ainda não está na Oficina. Tente Agendar um Serviço");
            }
        }

    }
}
