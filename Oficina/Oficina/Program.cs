using Oficina.Oficina;

Veiculo meuCarro = new("BMW", "M3 Competition", 2023, "JRB-6524");
Cliente cliente = new("Tomaz Pontes", "tomazpontes.dev@gmail.com");
Mecanico mecanico = new("Setonp Zamot", "Mecânica Geral");
OficinaDoMecanico oficinaZamot = new();

oficinaZamot.AgendarServico(meuCarro, "01-03-2024", mecanico);
oficinaZamot.RealizarServico(meuCarro, mecanico);