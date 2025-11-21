using Locadora.Controller;
using Locadora.Models.Enums;

//var categoriaController = new CategoriaController();

//var categoria = new Categoria("Pesado", 2500.00m, "Veículo utilitário esportivo");
//categoriaController.AdicionarCategoria(categoria);

//categoria = new Categoria("Voador", 1800.00m);
//categoriaController.AdicionarCategoria(categoria);

var veiculoController = new VeiculoController();
try
{
    //var veiculo = new Veiculo(1, "XYZ-9876", "Chevrolet", "S10", 2025, EStatusVeiculo.Disponivel.ToString());
    //veiculoController.AdicionarVeiculo(veiculo);
    //var veiculos = veiculoController.ListarTodosVeiculos();

    //foreach (var item in veiculos)
    //{
    //    Console.WriteLine(item);
    //}

    //var veiculo = veiculoController.BuscarVeiculoPlaca("XYZ-9876");

    //veiculoController.DeletarVeiculo(veiculo.VeiculoID);
    Console.WriteLine(veiculoController.BuscarVeiculoPlaca("MNO7890"));

    veiculoController.AtualizarStatusVeiculo(EStatusVeiculo.Manutencao.ToString(), "MNO7890");
    
    Console.WriteLine(veiculoController.BuscarVeiculoPlaca("MNO7890"));
}
catch (Exception ex)
{
    Console.WriteLine("Erro: " + ex.Message);
}